// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS2_SynchromodalityCapacityOptimisation.Services {
/**
 * Client for 'CostModel' Service
 */
export class CostModelServiceClient {

    /**
     * Base url for 'CostModel' Service
     */
    static baseUrl = "/api/CostModel/";

    /**
    *
    */
    public static CalculateCost(DriverSalary?:any, AvWorkH?:any, AvServiceH?:any, VehiculeAnnualHours?:any, VehiculeAnnualDays?:any, CostOfReplacementVehicule?:any, DaysReplacementVehicule?:any, AmortizationPeriod?:any, UtilisationPeriod?:any, ResidualValue?:any, MaintainanceCost?:any, VehiculeInsuranceCost?:any, GoodsInsurancecCost?:any, RoadTax?:any, VehiculePurchaseCost?:any, AmortizationType?:any, TotalDistanceDriven?:any, TotalDistanceService?:any, CNGDistance?:any, FuelDistance?:any, DieselDistance?:any, CNGCost?:any, CNGConsumption?:any, FuelCost?:any, FuelConsumption?:any, DieselCost?:any, DieselConsumption?:any, RefriCost?:any, Lettering?:any, TotalDistanceVehicule?:any, OilCost?:any, OilConsumption?:any, TireCost?:any, DistancePerTire?:any, YearlyReparationCost?:any, RouteDistance?:any, RouteTime?:any, OverHeadFactor?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: { DriverSalary: DriverSalary,AvWorkH: AvWorkH,AvServiceH: AvServiceH,VehiculeAnnualHours: VehiculeAnnualHours,VehiculeAnnualDays: VehiculeAnnualDays,CostOfReplacementVehicule: CostOfReplacementVehicule,DaysReplacementVehicule: DaysReplacementVehicule,AmortizationPeriod: AmortizationPeriod,UtilisationPeriod: UtilisationPeriod,ResidualValue: ResidualValue,MaintainanceCost: MaintainanceCost,VehiculeInsuranceCost: VehiculeInsuranceCost,GoodsInsurancecCost: GoodsInsurancecCost,RoadTax: RoadTax,VehiculePurchaseCost: VehiculePurchaseCost,AmortizationType: AmortizationType,TotalDistanceDriven: TotalDistanceDriven,TotalDistanceService: TotalDistanceService,CNGDistance: CNGDistance,FuelDistance: FuelDistance,DieselDistance: DieselDistance,CNGCost: CNGCost,CNGConsumption: CNGConsumption,FuelCost: FuelCost,FuelConsumption: FuelConsumption,DieselCost: DieselCost,DieselConsumption: DieselConsumption,RefriCost: RefriCost,Lettering: Lettering,TotalDistanceVehicule: TotalDistanceVehicule,OilCost: OilCost,OilConsumption: OilConsumption,TireCost: TireCost,DistancePerTire: DistancePerTire,YearlyReparationCost: YearlyReparationCost,RouteDistance: RouteDistance,RouteTime: RouteTime,OverHeadFactor: OverHeadFactor } };
                return axios.get(window._context.siteRoot + CostModelServiceClient.baseUrl + "CalculateCost",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.CostModel = DSS2_SynchromodalityCapacityOptimisation.Services.CostModelServiceClient;
