using System;
using System.Web;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using log4net;
using zAppDev.DotNet.Framework.Data;
using System.Web.Routing;
using DSS2_SynchromodalityCapacityOptimisation.DAL;
using System.Security.Authentication;
using System.Security;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Mvc;

namespace AppCode
{
    public class CustomControllerActionFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        public bool LogEnabled
        {
            get;
            set;
        }

        public bool CausesValidation
        {
            get;
            set;
        }

        public bool HasDefaultResultView
        {
            get;
            set;
        }

        public string ActionName
        {
            get;
            set;
        }

        public bool ListensToEvent
        {
            get;
            set;
        }

        public string ClaimType
        {
            get;
            set;
        }

        public bool FillDropDownInitialValues
        {
            get;
            set;
        }

        private bool AllowMultipleSessionsPerUser = true;

        private void ValidateRequestHeader(HttpRequestBase request)
        {
            if (string.Equals(request.HttpMethod, "get", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            string cookieToken = "";
            string formToken = "";
            string[] tokens = request.Headers.Get("RequestVerificationToken")?.Split(':');
            if (tokens != null && tokens.Length == 2)
            {
                cookieToken = tokens[0].Trim();
                formToken = tokens[1].Trim();
            }
            System.Web.Helpers.AntiForgery.Validate(cookieToken, formToken);
        }

        private void CheckForMultipleSessionsPerUser()
        {
            if (AllowMultipleSessionsPerUser) return;
            var user = IdentityHelper.GetCurrentApplicationUser();
            IdentityHelper.AddUserSession(user?.UserName);
            if (IdentityHelper.UserHasAnotherSession(user.UserName, HttpContext.Current?.Session?.SessionID))
            {
                IdentityHelper.SignOutUserFromAllSessions(user, HttpContext.Current?.Session?.SessionID);
            }
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            ValidateRequestHeader(filterContext.HttpContext.Request);
            var controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var getFromFilterContext = string.IsNullOrWhiteSpace(ActionName) || string.IsNullOrWhiteSpace(ClaimType);
            var action = getFromFilterContext ? filterContext.ActionDescriptor.ActionName : ActionName;
            var claimType = getFromFilterContext ? ClaimTypes.ControllerAction : ClaimType;
            filterContext.HttpContext.Items["_currentControllerAction"] = controller;
            var accessible = ClaimPermission.CheckAccess(claimType, controller, action);
            if (accessible) return;
            if (LogEnabled)
            {
                IdentityHelper.LogAction(
                    filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                    filterContext.ActionDescriptor.ActionName,
                    false,
                    "Unauthorized");
            }
            filterContext.Result = PrepareUnauthorizedResult(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            MiniSessionManager.Instance.OpenSessionWithTransaction();
            base.OnActionExecuting(filterContext);
            var controller = (CustomControllerBase)filterContext.Controller;
            var result = controller.PreActionFilterHook(CausesValidation, ListensToEvent, ActionName);
            if (result != null)
            {
                filterContext.Result = result;
            }
            var response = filterContext.HttpContext.Response;
            response.AppendHeader("zappuser", IdentityHelper.GetCurrentUserName());
            var encodingsAccepted = filterContext.HttpContext.Request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(encodingsAccepted)) return;
            encodingsAccepted = encodingsAccepted.ToLowerInvariant();
            if (encodingsAccepted.Contains("deflate"))
            {
                response.AppendHeader("Content-encoding", "deflate");
                response.Filter = new Ionic.Zlib.DeflateStream(response.Filter, Ionic.Zlib.CompressionMode.Compress);
            }
            else if (encodingsAccepted.Contains("gzip"))
            {
                response.AppendHeader("Content-encoding", "gzip");
                response.Filter = new Ionic.Zlib.GZipStream(response.Filter, Ionic.Zlib.CompressionMode.Compress);
            }
            var id = ProfileHelper.GetCurrentLocale().Id;
            if (id == null) return;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(id.Value);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(id.Value);
        }

        private static NHibernate.StaleObjectStateException EnrichStaleObjectStateException(NHibernate.StaleObjectStateException staleObjectStateException)
        {
            //If it's already enriched, return it and get out
            if(staleObjectStateException.Data["ZAPPDEV_MESSAGE"] != null)
            {
                return staleObjectStateException;
            }
            //Otherwise, enrich it
            string defaultMessage = @"Somebody already committed modifications to the data you are about to commit. <br/>You have been working with <i>stale data</i>.<br/>Please, refresh your page in order to restart with fresh data.";
            string defaultTitle = "Stale Data";
            string message = AppCode.BaseViewPage<string>.GetResourceValue("GlobalResources", "RES_SITE_StaleObjectStateExceptionMessage").ToString();
            string title = AppCode.BaseViewPage<string>.GetResourceValue("GlobalResources", "RES_SITE_StaleObjectStateExceptionTitle").ToString();
            if (string.IsNullOrWhiteSpace(message)) message = defaultMessage;
            if (string.IsNullOrWhiteSpace(title)) title = defaultTitle;
            staleObjectStateException.Data.Add("ZAPPDEV_MESSAGE", message);
            staleObjectStateException.Data.Add("ZAPPDEV_TITLE", title);
            return staleObjectStateException;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            try
            {
                var miniSessionManagerWillFlush = MiniSessionManager.Instance.WillFlush;
                var controller = (CustomControllerBase)filterContext.Controller;
                if (miniSessionManagerWillFlush)
                {
                    controller.CommitAllFiles();
                }
                MiniSessionManager.Instance.CommitChanges(filterContext.Exception, () =>
                {
                    if (miniSessionManagerWillFlush)
                    {
                        controller.CommitAllFilesLegacy();
                    }
                    if (!HasException(filterContext) && filterContext.Result is EmptyResult)
                    {
                        filterContext.Result = controller.PostActionFilterHook(HasDefaultResultView, FillDropDownInitialValues);
                    }
                });
            }
            catch (NHibernate.StaleObjectStateException staleObjectStateException)
            {
                filterContext.Exception = EnrichStaleObjectStateException(staleObjectStateException);
            }
            catch (Exception x)
            {
                filterContext.Exception = x;
            }
            if (LogEnabled)
            {
                IdentityHelper.LogAction(
                    filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                    filterContext.ActionDescriptor.ActionName,
                    filterContext.Exception == null,
                    filterContext.Exception?.Message);
            }
            HandleException(filterContext);
        }

        protected ActionResult PrepareUnauthorizedResult(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Clear();
            var isAuthenticated = filterContext.HttpContext.User.Identity.IsAuthenticated;
            filterContext.HttpContext.Response.StatusCode = isAuthenticated ? 403 : 401;
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            var controller = (CustomControllerBase) filterContext.Controller;
            if (controller.Request.IsAjaxRequest())
            {
                return new JsonResult
                {
                    Data = new
                    {
                        Type = "Unauthorized"
                    },
                    MaxJsonLength = int.MaxValue,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            var routeData =
                new
            {
                controller = isAuthenticated ? "Unauthorized" : "SignInPage",
                action = isAuthenticated ? "Render" : "Load",
                returnUrl = GetReturnUrl(filterContext)
            };
            return new RedirectToRouteResult(new RouteValueDictionary(routeData));
        }

        private static string GetReturnUrl(ControllerContext filterContext)

        {
            var isAuthenticated = filterContext.HttpContext.User.Identity.IsAuthenticated;
            if (isAuthenticated || filterContext.HttpContext?.Request?.Url == null) return "";
            var appPath = filterContext.HttpContext.Request.ApplicationPath;
            var localPath = filterContext.HttpContext.Request.Url.LocalPath;
            var query = filterContext.HttpContext.Request.Url.Query;
            if (localPath.StartsWith(appPath) && appPath != "/")
            {
                localPath = localPath.Substring(appPath.Length);
            }
            return localPath + query;
        }

        private static void HandleException(ActionExecutedContext filterContext)
        {
            if (!HasException(filterContext)) return;
            if(filterContext?.Exception?.GetType() == typeof(NHibernate.StaleObjectStateException))
            {
                filterContext.Exception = EnrichStaleObjectStateException(filterContext.Exception as NHibernate.StaleObjectStateException);
            }
            DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseApplicationError(filterContext.Exception);
            filterContext.ExceptionHandled = true;
            LogManager.GetLogger(filterContext.Controller.GetType()).Error(filterContext.Exception);
            zAppDev.DotNet.Framework.Utilities.Common.SetLastError(filterContext.Exception);
            filterContext.Result = GetErrorResult(filterContext, "Render", "ErrorPage");
        }

        private static bool HasException(ActionExecutedContext context)
        {
            return context.Exception != null;
        }

        private static ActionResult GetErrorResult(ActionExecutedContext filterContext, string actionName,
                string formName)
        {
            string errorContent;
            try
            {
                filterContext.HttpContext.Response.Clear();
                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
                var friendlyMessageHandler = new zAppDev.DotNet.Framework.Utilities.ExceptionHandler();
                var msgObject = friendlyMessageHandler.HandleException(filterContext.Exception);
                errorContent = Newtonsoft.Json.JsonConvert.SerializeObject(msgObject,
                               new Newtonsoft.Json.JsonSerializerSettings
                {
                    PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects
                });
            }
            catch (Exception e)
            {
                LogManager.GetLogger(typeof(zAppDev.DotNet.Framework.Utilities.ExceptionHandler))
                .Error("Could not produce friendly message for exception!", e);
                errorContent = filterContext.Exception.Message;
            }
            var controller = ((CustomControllerBase) filterContext.Controller);
            if (controller.Request.IsAjaxRequest())
            {
                return new JsonResult
                {
                    Data = new
                    {
                        Type = "Error",
                        Data = errorContent, filterContext.Exception.StackTrace,
                        RedirectURL = $"{formName}/{actionName}"
                    },
                    MaxJsonLength = int.MaxValue,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            return new RedirectToRouteResult(new RouteValueDictionary
            {
                ["action"] = actionName,
                             ["controller"] = formName
            });
        }
    }
}