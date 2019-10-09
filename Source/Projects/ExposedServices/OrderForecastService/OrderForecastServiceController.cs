// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using zAppDev.DotNet.Framework.Mvc;
using AppCode;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
namespace DSS2_SynchromodalityCapacityOptimisation.Web.Code.WebApi
{


    [RoutePrefix("api/OrderForecastService")]
    [WebApiThrottle.EnableThrottling()]
    public class OrderForecastServiceController : BasicApiCtrl
    {

        /// <summary>
        ///
        /// </summary>
        /// <returns>Collection</returns>
        [CustomWebApiActionFilter(LogEnabled = true, AllowPartialResponse = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("calculate")]
        [HttpGet]
        public System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.Services.OrderForecastService.DataContracts.OrderForecastDetailsDTO> CalculateForSKU(string sku = "")
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS2_SynchromodalityCapacityOptimisation.Services.OrderForecastServiceService()).CalculateForSKU(sku,_RequestSourceIp, _UserName);
            return result;
        }
    }
}
