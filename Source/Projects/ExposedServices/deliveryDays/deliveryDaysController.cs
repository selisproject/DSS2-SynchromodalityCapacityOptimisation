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


    [RoutePrefix("api/deliveryDays")]
    [WebApiThrottle.EnableThrottling()]
    public class deliveryDaysController : BasicApiCtrl
    {

        /// <summary>
        /// Import Delivery Days and Lead Time
        /// </summary>
        /// <returns>Response</returns>
        [CustomWebApiActionFilter(LogEnabled = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("import")]
        [HttpPost]
        public DSS2_SynchromodalityCapacityOptimisation.Services.deliveryDays.DataContracts.ResponseDTO Import([FromBody]System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.Services.deliveryDays.DataContracts.DeliveryScheduleDTO> deliverySchedules)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS2_SynchromodalityCapacityOptimisation.Services.deliveryDaysService()).Import(deliverySchedules,_RequestSourceIp, _UserName);
            return result;
        }
    }
}
