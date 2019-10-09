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
    public class Router_MapotempoRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:Router_Mapotempo:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "https://router.mapotempo.com/0.1/";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot route(string dimension, string geometry, string motorway, string toll, string max_walk_distance, string currency, string lang, string loc, string api_key)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "route" + "?dimension=" + dimension + "&geometry=" + geometry + "&motorway=" + motorway + "&toll=" + toll + "&max_walk_distance=" + max_walk_distance + "&currency=" + currency + "&lang=" + lang + "&loc=" + loc + "&api_key=" + api_key;
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
                Verb = RestHTTPVerb.GET,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "Accept", "application/json"
                    }
                },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "Router_Mapotempo",
                Operation = "route"
            };
            Func<ServiceConsumptionContainer, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.Router_MapotempoRoot>(_invocation);
            return _consumer.Invoke(_options);
        }

    }
}