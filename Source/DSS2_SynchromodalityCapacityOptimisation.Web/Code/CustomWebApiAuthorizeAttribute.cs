using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.WebApi;

namespace AppCode
{
    public class CustomWebApiAuthorizeAttribute: CustomWebApiAuthorizeAttributeBase
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
            var service = actionContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var method = actionContext.ActionDescriptor.ActionName;
            var isAuthenticated = actionContext.RequestContext.Principal.Identity.IsAuthenticated;
            var identityName = isAuthenticated ? actionContext.RequestContext.Principal.Identity.Name : null;
            var identityNameExists = !string.IsNullOrWhiteSpace(identityName);
            if (isAuthenticated && identityNameExists)
            {
                if (!ClaimPermission.CheckAccess(ClaimTypes.ExposedService, service, method, identityName))
                {
                    this.HandleUnauthorizedRequest(actionContext);
                }
            }
            else
            {
                // Log this weird case
                if (isAuthenticated && !identityNameExists)
                {
                    log4net.LogManager.GetLogger(nameof(CustomWebApiAuthorizeAttribute)).Warn($"Authenticated user without Identity.Name! Handling as unauthenticated... ({service}/{method})");
                }
                if (!ClaimPermission.CheckAccess(ClaimTypes.ExposedService, service, method))
                {
                    this.HandleUnauthenticatedRequest(actionContext);
                }
            }
        }

        protected new void CreateResponseAndLog(HttpActionContext actionContext, HttpStatusCode status, string msg = "")
        {
            var errorCode = string.IsNullOrWhiteSpace(msg) ?
                            (status == HttpStatusCode.Forbidden ? "You are not authorized!" : "Please provide credentials!") :
                            msg;
            actionContext.Response = actionContext.Request.CreateErrorResponse(status, errorCode);
            _stopwatch.Stop();
            if (!LogEnabled) return;
            // TODO - evaluate if this is needed. Maybe it should be refactored to a pure access log but it needs to also record IP, etc.
            IdentityHelper.LogAction(
                actionContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                actionContext.ActionDescriptor.ActionName,
                false,
                actionContext.Response.StatusCode.ToString());
            MessagingPublisher?.LogExposedAPIAccess(_id, actionContext, _stopwatch.Elapsed, false);
        }
    }
}