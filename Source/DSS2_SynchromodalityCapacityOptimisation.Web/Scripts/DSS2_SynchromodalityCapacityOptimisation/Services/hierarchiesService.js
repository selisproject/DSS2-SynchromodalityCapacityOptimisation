// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'hierarchies' Service
         */
        var hierarchiesServiceClient = (function () {
            function hierarchiesServiceClient() {
            }
            return hierarchiesServiceClient;
        }());
        /**
         * Base url for 'hierarchies' Service
         */
        hierarchiesServiceClient.baseUrl = "/api/hierarchies/";
        Services.hierarchiesServiceClient = hierarchiesServiceClient;
    })(Services = DSS2_SynchromodalityCapacityOptimisation.Services || (DSS2_SynchromodalityCapacityOptimisation.Services = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.hierarchies = DSS2_SynchromodalityCapacityOptimisation.Services.hierarchiesServiceClient;
