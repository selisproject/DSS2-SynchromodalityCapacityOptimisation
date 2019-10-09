using System;
using System.Diagnostics;
using System.Web.Http.Filters;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.WebApi;

namespace DSS2_SynchromodalityCapacityOptimisation.Web.Code
{
    public class CustomWebApiActionFilter : CustomWebApiActionFilterBase
    {
        public override void OnActionExecuted(HttpActionExecutedContext filterContext)
        {
            try
            {
                MiniSessionManager.Instance.CommitChanges(filterContext.Exception);
                if(AllowPartialResponse) TryToCreatePartialResponse(filterContext);
            }
            catch (Exception x)
            {
                filterContext.Exception = x;
            }
            HandleException(filterContext);
            var timer = (Stopwatch)filterContext.Request.Properties["logtimer"];
            timer.Stop();
            _elapsed = timer.Elapsed;
            if (!LogEnabled) return;
            IdentityHelper.LogAction(
                filterContext.ActionContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                filterContext.ActionContext.ActionDescriptor.ActionName,
                filterContext.Exception == null,
                filterContext.Exception?.Message);
            if (!(bool)filterContext.Request.Properties["requestIsLogged"])
            {
                APILogger?.LogExposedAPIAccess(_id, filterContext.ActionContext, _elapsed, false);
                filterContext.Request.Properties["requestIsLogged"] = true;
            }
        }
    }
}