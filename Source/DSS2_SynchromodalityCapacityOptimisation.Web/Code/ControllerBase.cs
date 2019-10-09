using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.SessionState;
using Newtonsoft.Json.Linq;
using System.Globalization;
using Newtonsoft.Json;
using Ionic.Zip;
using System.IO;
using System.Web.Routing;

using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Utilities;



namespace AppCode
{
    [SessionState(SessionStateBehavior.Required)]
    public class ControllerBase<T, Y> : ClmsControllerBase<T, Y>, IControllerBase
    {




        protected new JObject _ParsePostedData()
        {
            if (Request.Files.Count > 0)
            {
                var postedData = new JObject();
                foreach (var key in Request.Form.AllKeys)
                {
                    postedData.Add(key, Request.Form[key]);
                }
                return postedData;
            }
            else
            {
                Request.InputStream.Position = 0;
                var json = "";
                if (Request.Headers["IsZipped"] == "true")
                {
                    json = Unzip(Request.InputStream);
                }
                else
                {
                    //json = new StreamReader(new MemoryStream(HttpContext.Request.BinaryRead(HttpContext.Request.ContentLength))).ReadToEnd();
                    using (var ms = new MemoryStream(HttpContext.Request.BinaryRead(HttpContext.Request.ContentLength)))
                    {
                        using (var sr = new StreamReader(ms))
                        {
                            json = sr.ReadToEnd();
                        }
                    }
                }
                return JObject.Parse(json);
            }
        }

        protected new JObject _LoadViewModel()
        {
            var postedData = _ParsePostedData();
            if (postedData["_isDirty"] != null)
            {
                IsDirty = (bool) (((JValue) (postedData["_isDirty"])).Value);
            }
            if (postedData["model"] != null)
            {
                var serializedData = postedData["model"].ToString();
                var _vm = (IViewModelDTO<T>) Utilities.Deserialize<Y>(serializedData);
                @model = _vm.Convert();
            }
            else
            {
                var type = typeof(T);
                var ctor = type.GetConstructor(new Type[] {});
                @model = (T) ctor.Invoke(new object[] {});
            }
            ViewModelLoaded();
            return postedData;
        }

        protected new object CreateDtoInstancesFromKeys(Type viewModelType, string dataType, List<string> keys, string jbID, Type[] partialTypes = null)
        {
            _logger = log4net.LogManager.GetLogger(typeof(ControllerBase));
            var getInstanceMethod = GetViewModelTypeForPartialControl(viewModelType, dataType, partialTypes);
            object data;
            if (keys.Count() == 1)
            {
                if (string.IsNullOrEmpty(keys[0]) || keys[0] == "0")
                {
                    data = null;
                }
                else
                {
                    try
                    {
                        data = getInstanceMethod.Invoke(null, new object[] { (keys[0]), (jbID) });
                    }
                    catch (Exception ex)
                    {
                        data = null;
                        _logger.Error(ex);
                    }
                }
            }
            else
            {
                var instances = new List<object>();
                foreach (var key in keys)
                {
                    if (string.IsNullOrEmpty(key) || key == "0") continue;
                    try
                    {
                        var instanceMethod = getInstanceMethod.Invoke(null, new object[] { (key), (jbID) });
                        instances.Add(instanceMethod);
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex);
                    }
                }
                data = instances;
            }
            return data;
        }

        protected override MethodInfo GetViewModelTypeForPartialControl(Type viewModelType, string dataType, Type[] partialTypes = null)
        {
            if (partialTypes == null)
            {
                var type = Assembly.GetExecutingAssembly().GetType($"{viewModelType.Namespace}.{dataType}");
                return type.GetMethod("GetInstance");
            }
            else
            {
                foreach (var partialType in partialTypes)
                {
                    var type = Assembly.GetExecutingAssembly().GetType($"{partialType.Namespace}.{dataType}");
                    if (type == null) continue;
                    var getInstanceMethod = type.GetMethod("GetInstance");
                    if (getInstanceMethod == null) continue;
                    return getInstanceMethod;
                }
                return null;
            }
        }

        protected new List<V> DeserializeViewModelCollectionProperty<V, VDTO>(string serializedData)
        {
            var deserialized = Utilities.Deserialize<List<VDTO>>(serializedData); // as List<IViewModelDTO<V>>;
            var instances = new List<V>();
            foreach (var item in deserialized)
            {
                if (item == null)
                {
                    instances.Add(default(V));
                    continue;
                }
                var entry =  item as IViewModelDTO<V>;
                if (entry == null)
                {
                    instances.Add((V) Convert.ChangeType(item, typeof(V)));
                    continue;
                }
                var typeHash = (entry as ViewModelDTOBase)?._typeHash;
                var found = false;
                foreach (ViewModelDTOBase dto in ViewModelDTOBase.DTOHelper.SeenModelInstances?.Keys)
                {
                    if (dto._clientKey != null && dto._clientKey.Equals(entry?._clientKey) && dto._typeHash == typeHash)
                    {
                        instances.Add((V) ViewModelDTOBase.DTOHelper.SeenModelInstances[dto]);
                        found = true;
                        break;
                    }
                    ;
                }
                if (!found)
                {
                    instances.Add(entry.Convert());
                }
            }
            return instances;
        }

        protected new ActionResult GetRedirectInfo(string url, string homeController, string homeAction)
        {
            var controller = url;
            var action = "";
            if (string.IsNullOrWhiteSpace(url) || !Url.IsLocalUrl(url))
            {
                controller = homeController;
                action = homeAction;
                url = homeController + "/" + homeAction;
            }
            if (Request.IsAjaxRequest() ||
                    zAppDev.DotNet.Framework.Utilities.Web.CurrentServerRole == zAppDev.DotNet.Framework.Utilities.Web.ServerRole.Application)
            {
                var result = Json(new
                {
                    Type = "Redirect",
                    Controller = controller.Replace("~/", ""),
                    Action = action,
                    Method = "GET",
                }, JsonRequestBehavior.AllowGet);
                result.MaxJsonLength = int.MaxValue;
                return result;
            }
            return Redirect(url);
        }

        protected new ActionResult GetRedirectInfo(string formName, string actionName, RouteValueDictionary parameters)
        {
            if (Request.IsAjaxRequest() ||
                    zAppDev.DotNet.Framework.Utilities.Web.CurrentServerRole == zAppDev.DotNet.Framework.Utilities.Web.ServerRole.Application)
            {
                var result = Json(new
                {
                    Type = "Redirect",
                    Controller = formName,
                    Action = actionName,
                    QueryParameters = parameters?.Select(x => x.Value),
                    Method = "GET",
                }, JsonRequestBehavior.AllowGet);
                result.MaxJsonLength = int.MaxValue;
                return result;
            }
            else
            {
                return RedirectToAction(actionName, formName, parameters);
            }
        }

        public override ActionResult _RaiseEvent()
        {
            var _data = _LoadViewModel();
            var methodName = "Raise" + _data["eventName"];
            var assemblyName = "DSS2_SynchromodalityCapacityOptimisation.Hubs";
            ReflectionHelper.InvokeStaticVoidMethod(assemblyName, methodName, _data["parameters"], false, false);
            // Logging. Parameters may not be exactly 'parseable'
            // to Logger requirements, but this is handled by DebugHelper class
            var parameters = _data["parameters"]?.ToString();
            var paramsArray = Utilities.Deserialize<List<string>>(parameters);
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(paramsArray, this.GetType().Name);
            return Content("OK");
        }

        protected new void AddToResponse(string path, object instance, Func<object, object> toDtoMethod = null)
        {
            var entry = new ClientUpdateInfo
            {
                Instance = instance,
                DtoConverter = toDtoMethod,
                Order = ClientResponseIndex++
            };
            if (_clientData.ContainsKey(path))
            {
                _clientData[path] = entry;
            }
            else
            {
                _clientData.Add(path, entry);
            }
        }

        protected new List<ResponseAssigment> GetClientResponse()
        {
            var resp = new List<ResponseAssigment>();
            foreach (var item in _clientData.OrderBy(i => i.Value.Order))
            {
                resp.Add(new ResponseAssigment
                {
                    Path = item.Key,
                    Value = item.Value.DtoConverter == null ? item.Value.Instance : item.Value.DtoConverter(item.Value.Instance)
                });
            }
            return resp;
        }

        #region External Account Functions
        public new ActionResult _ExecuteExternalProviderEvent(string actionType, string provider, string controller, string successAction, string failAction, string userClass)
        {
            var validActionTypesText = "(Valid action types: 'Login', 'Link', 'Register')";
            if (string.IsNullOrWhiteSpace(actionType))
            {
                throw new ApplicationException($"Request did not provide an Action Type (actionType). {validActionTypesText}");
            }
            if (string.IsNullOrWhiteSpace(provider))
            {
                throw new ApplicationException("Request did not provide an External Login Provider (provider). (Valid providers: 'Google', 'Facebook')");
            }
            if (string.IsNullOrWhiteSpace(controller))
            {
                throw new ApplicationException("Request did not provide an Callback Controller (controller).");
            }
            if (string.Compare(actionType, "Link", true) == 0)
            {
                return new ChallengeResult(provider, Url.Action("_LinkExternalAccountCallback", controller, new { successAction = successAction, failAction = failAction }));
            }
            if (string.Compare(actionType, "Login", true) == 0)
            {
                return new ChallengeResult(provider, Url.Action("_LoginWithExternalAccountCallback", controller, new { successAction = successAction, failAction = failAction }));
            }
            if (string.Compare(actionType, "Register", true) == 0)
            {
                return new ChallengeResult(provider, Url.Action("_RegisterExternalAccountCallback", controller, new { successAction = successAction, failAction = failAction, userClass = userClass }));
            }
            if (string.Compare(actionType, "GetProfile", true) == 0)
            {
                return new ChallengeResult(provider, Url.Action("_GetExternalProfileCallback", controller, new { successAction = successAction, failAction = failAction }));
            }
            throw new ApplicationException($"Request got an invalid Action Type: {actionType}. {validActionTypesText}");
        }


        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
            : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider
            {
                get;
                set;
            }
            public string RedirectUri
            {
                get;
                set;
            }
            public string UserId
            {
                get;
                set;
            }
            private const string XsrfKey = "XsrfId";
            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new Microsoft.Owin.Security.AuthenticationProperties {RedirectUri = RedirectUri};
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }

        #endregion
    }
}
