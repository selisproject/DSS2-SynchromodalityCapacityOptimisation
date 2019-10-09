// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'CostModel' Service
         */
        var CostModelServiceClient = (function () {
            function CostModelServiceClient() {
            }
            /**
            *
            */
            CostModelServiceClient.CalculateCost = function (DriverSalary, AvWorkH, AvServiceH, VehiculeAnnualHours, VehiculeAnnualDays, CostOfReplacementVehicule, DaysReplacementVehicule, AmortizationPeriod, UtilisationPeriod, ResidualValue, MaintainanceCost, VehiculeInsuranceCost, GoodsInsurancecCost, RoadTax, VehiculePurchaseCost, AmortizationType, TotalDistanceDriven, TotalDistanceService, CNGDistance, FuelDistance, DieselDistance, CNGCost, CNGConsumption, FuelCost, FuelConsumption, DieselCost, DieselConsumption, RefriCost, Lettering, TotalDistanceVehicule, OilCost, OilConsumption, TireCost, DistancePerTire, YearlyReparationCost, RouteDistance, RouteTime, OverHeadFactor) {
                var _data = { params: { DriverSalary: DriverSalary, AvWorkH: AvWorkH, AvServiceH: AvServiceH, VehiculeAnnualHours: VehiculeAnnualHours, VehiculeAnnualDays: VehiculeAnnualDays, CostOfReplacementVehicule: CostOfReplacementVehicule, DaysReplacementVehicule: DaysReplacementVehicule, AmortizationPeriod: AmortizationPeriod, UtilisationPeriod: UtilisationPeriod, ResidualValue: ResidualValue, MaintainanceCost: MaintainanceCost, VehiculeInsuranceCost: VehiculeInsuranceCost, GoodsInsurancecCost: GoodsInsurancecCost, RoadTax: RoadTax, VehiculePurchaseCost: VehiculePurchaseCost, AmortizationType: AmortizationType, TotalDistanceDriven: TotalDistanceDriven, TotalDistanceService: TotalDistanceService, CNGDistance: CNGDistance, FuelDistance: FuelDistance, DieselDistance: DieselDistance, CNGCost: CNGCost, CNGConsumption: CNGConsumption, FuelCost: FuelCost, FuelConsumption: FuelConsumption, DieselCost: DieselCost, DieselConsumption: DieselConsumption, RefriCost: RefriCost, Lettering: Lettering, TotalDistanceVehicule: TotalDistanceVehicule, OilCost: OilCost, OilConsumption: OilConsumption, TireCost: TireCost, DistancePerTire: DistancePerTire, YearlyReparationCost: YearlyReparationCost, RouteDistance: RouteDistance, RouteTime: RouteTime, OverHeadFactor: OverHeadFactor } };
                return axios.get(window._context.siteRoot + CostModelServiceClient.baseUrl + "CalculateCost", _data);
            };
            return CostModelServiceClient;
        }());
        /**
         * Base url for 'CostModel' Service
         */
        CostModelServiceClient.baseUrl = "/api/CostModel/";
        Services.CostModelServiceClient = CostModelServiceClient;
    })(Services = DSS2_SynchromodalityCapacityOptimisation.Services || (DSS2_SynchromodalityCapacityOptimisation.Services = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.CostModel = DSS2_SynchromodalityCapacityOptimisation.Services.CostModelServiceClient;