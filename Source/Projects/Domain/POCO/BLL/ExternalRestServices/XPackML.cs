// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using zAppDev.DotNet.Framework.Services;
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DSS2_SynchromodalityCapacityOptimisation.BLL.ExternalRestServices
{
    public class XPackMLRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:XPackML:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "https://api-analytics.zappdev.com/q";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results GetAnomaliesOnMaxElapseTime(int? hits, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.RecordRequest q)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "/.ml-anomalies-custom-obapi_hm_resp_elapsed_time_per_service/_search?filter_path=hits.total,hits.max_score,hits.hits._id,hits.hits._source&size=" + hits.GetValueOrDefault(0);
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.POST,
                SecurityType = RestSecurityType.BasicAuth,
                UserName = "kview",
                Password = "@2FwBe&#uWER",
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "XPackML",
                Operation = "GetAnomaliesOnMaxElapseTime",
                PostType = PostType.JSON,
                Data = q, FormData = new Dictionary<string, object> {{"q",q}}
            };
            Func<ServiceConsumptionContainer, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_invocation);
            return _consumer.Invoke(_options);
        }
        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results GetAnomaliesOnHits(int? hits, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.RecordRequest q)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "/.ml-anomalies-custom-obapi_hm_resp_hits_per_service/_search?size=" + hits.GetValueOrDefault(0);
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.POST,
                SecurityType = RestSecurityType.BasicAuth,
                UserName = "kview",
                Password = "@2FwBe&#uWER",
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "XPackML",
                Operation = "GetAnomaliesOnHits",
                PostType = PostType.JSON,
                Data = q, FormData = new Dictionary<string, object> {{"q",q}}
            };
            Func<ServiceConsumptionContainer, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Results>(_invocation);
            return _consumer.Invoke(_options);
        }

    }
}