// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS2_SynchromodalityCapacityOptimisation.Services {
/**
 * Client for 'pastSales' Service
 */
export class pastSalesServiceClient {

    /**
     * Base url for 'pastSales' Service
     */
    static baseUrl = "/api/pastSales/";

    /**
    * Import Past Sales
    */
    public static Import(pastSales?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = pastSales;
                return axios.post(window._context.siteRoot + pastSalesServiceClient.baseUrl + "import",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.pastSales = DSS2_SynchromodalityCapacityOptimisation.Services.pastSalesServiceClient;
