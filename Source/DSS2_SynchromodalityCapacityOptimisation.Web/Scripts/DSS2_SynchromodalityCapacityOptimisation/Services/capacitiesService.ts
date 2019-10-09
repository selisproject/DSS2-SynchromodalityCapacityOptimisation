// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS2_SynchromodalityCapacityOptimisation.Services {
/**
 * Client for 'capacities' Service
 */
export class capacitiesServiceClient {

    /**
     * Base url for 'capacities' Service
     */
    static baseUrl = "/api/capacities/";

    /**
    *
    */
    public static Publish(capacities?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = capacities;
                return axios.post(window._context.siteRoot + capacitiesServiceClient.baseUrl + "Publish",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.capacities = DSS2_SynchromodalityCapacityOptimisation.Services.capacitiesServiceClient;
