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
    public class GoogleDirectionsRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:GoogleDirections:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "https://maps.googleapis.com/maps/api/directions/";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.DirectionsResponse Directions(float? originLat, float? originLong, float? destinationLat, float? destinationLong)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "json?origin=" + originLat.GetValueOrDefault(0) + "," + originLong.GetValueOrDefault(0) + "&destination=" + destinationLat.GetValueOrDefault(0) + "," + destinationLong.GetValueOrDefault(0) + "&key=AIzaSyDn7jvEi9-m-NbaNj8vJjggUCAq7-43hMM";
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
                ApiName = "GoogleDirections",
                Operation = "Directions"
            };
            Func<ServiceConsumptionContainer, DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.DirectionsResponse> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.DirectionsResponse>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.DirectionsResponse>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.DirectionsResponse>(_invocation);
            return _consumer.Invoke(_options);
        }

    }
}