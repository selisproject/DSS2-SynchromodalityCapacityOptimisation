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
    public class GoogleGeocodeRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:GoogleGeocode:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "https://maps.googleapis.com/maps/api/geocode/";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.Root GeoLocation(string address)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "json?address=" + address + "&key=AIzaSyCZs5R7fS9r6xCoilVedcK-Oq-hHk7mzdI";
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
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "GoogleGeocode",
                Operation = "GeoLocation"
            };
            Func<ServiceConsumptionContainer, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.Root> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.Root>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.Root>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.Root>(_invocation);
            return _consumer.Invoke(_options);
        }

    }
}