// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'stocksOnHand' Service
         */
        var stocksOnHandServiceClient = (function () {
            function stocksOnHandServiceClient() {
            }
            /**
            * Import Stock on Hand
            */
            stocksOnHandServiceClient.Import = function (stocks) {
                var _data = stocks;
                return axios.post(window._context.siteRoot + stocksOnHandServiceClient.baseUrl + "import", _data);
            };
            return stocksOnHandServiceClient;
        }());
        /**
         * Base url for 'stocksOnHand' Service
         */
        stocksOnHandServiceClient.baseUrl = "/api/stocksOnHand/";
        Services.stocksOnHandServiceClient = stocksOnHandServiceClient;
    })(Services = DSS2_SynchromodalityCapacityOptimisation.Services || (DSS2_SynchromodalityCapacityOptimisation.Services = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.stocksOnHand = DSS2_SynchromodalityCapacityOptimisation.Services.stocksOnHandServiceClient;
