// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'exportInventoryItems' Service
         */
        var exportInventoryItemsServiceClient = (function () {
            function exportInventoryItemsServiceClient() {
            }
            /**
            *
            */
            exportInventoryItemsServiceClient.Export = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + exportInventoryItemsServiceClient.baseUrl + "Export", _data);
            };
            return exportInventoryItemsServiceClient;
        }());
        /**
         * Base url for 'exportInventoryItems' Service
         */
        exportInventoryItemsServiceClient.baseUrl = "/api/exportInventoryItems/";
        Services.exportInventoryItemsServiceClient = exportInventoryItemsServiceClient;
    })(Services = DSS2_SynchromodalityCapacityOptimisation.Services || (DSS2_SynchromodalityCapacityOptimisation.Services = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.exportInventoryItems = DSS2_SynchromodalityCapacityOptimisation.Services.exportInventoryItemsServiceClient;
