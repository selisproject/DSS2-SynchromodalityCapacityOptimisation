// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'RA' Service
         */
        var RAServiceClient = (function () {
            function RAServiceClient() {
            }
            /**
            *
            */
            RAServiceClient.GetRA = function (raname) {
                var _data = { params: { raname: raname } };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetRA", _data);
            };
            /**
            *
            */
            RAServiceClient.GetOrderWMS = function (id) {
                var _data = { params: { id: id } };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetOrderWMS", _data);
            };
            /**
            *
            */
            RAServiceClient.SaveOrder = function (order) {
                var _data = order;
                return axios.post(window._context.siteRoot + RAServiceClient.baseUrl + "SaveOrder", _data);
            };
            /**
            *
            */
            RAServiceClient.GetTruckDriver = function (username) {
                var _data = { params: { username: username } };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetTruckDriver", _data);
            };
            /**
            *
            */
            RAServiceClient.GetAllOrderWMS = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetAllOrderWMS", _data);
            };
            /**
            *
            */
            RAServiceClient.GetOrderByTruck = function (plateNumber) {
                var _data = { params: { plateNumber: plateNumber } };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetOrderByTruck", _data);
            };
            /**
            *
            */
            RAServiceClient.GetOrderByAgency = function (agencyCode) {
                var _data = { params: { agencyCode: agencyCode } };
                return axios.get(window._context.siteRoot + RAServiceClient.baseUrl + "GetOrderByAgency", _data);
            };
            return RAServiceClient;
        }());
        /**
         * Base url for 'RA' Service
         */
        RAServiceClient.baseUrl = "/api/RA/";
        Services.RAServiceClient = RAServiceClient;
    })(Services = DSS2_SynchromodalityCapacityOptimisation.Services || (DSS2_SynchromodalityCapacityOptimisation.Services = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.RA = DSS2_SynchromodalityCapacityOptimisation.Services.RAServiceClient;
