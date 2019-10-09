using System.Web.Http;
using zAppDev.DotNet.Framework.Data;
using WebApiThrottle;

namespace DSS2_SynchromodalityCapacityOptimisation.Web.Code.WebApi
{
    [RoutePrefix("api/_health")]
    [EnableThrottling(PerSecond = 1)]
    public class HealthCheckController : BasicApiCtrl
    {
        [Route("check")]
        [HttpGet]
        public HealthCheckResult Check()
        {
            // TODO - do additional checks here, besides checking the db
            return MiniSessionManager.ExecuteInUoW(manager => new HealthCheckResult
            {
                status = "ok"
            });
        }

        public class HealthCheckResult
        {
            public string status
            {
                get;
                set;
            }
        }
    }
}