// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Data.DAL;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Auditing;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS2_SynchromodalityCapacityOptimisation.DAL
{
    public interface IRepository: ICreateRepository, IIdentityRepository, IAuditingRepository, IDeleteRepository, IRetrieveRepository, IUpdateRepository, IWorkflowRepository
    {
        void DeletetblDhlEvent(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlEvent tbldhlevent, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlIncident(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlIncident tbldhlincident, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlPlannedRoute(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPlannedRoute tbldhlplannedroute, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlPurchase(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPurchase tbldhlpurchase, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlRouteStopOperation(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStopOperation tbldhlroutestopoperation, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlRouteStop(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStop tbldhlroutestop, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblDhlTracking(DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlTracking tbldhltracking, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteShipment(DSS2_SynchromodalityCapacityOptimisation.BO.Shipment shipment, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteShipmentStatus(DSS2_SynchromodalityCapacityOptimisation.BO.ShipmentStatus shipmentstatus, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePoint(DSS2_SynchromodalityCapacityOptimisation.BO.Point point, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDriver(DSS2_SynchromodalityCapacityOptimisation.BO.Driver driver, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteShippingOrder(DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder shippingorder, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStatusEvolution(DSS2_SynchromodalityCapacityOptimisation.BO.StatusEvolution statusevolution, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteVolume(DSS2_SynchromodalityCapacityOptimisation.BO.Volume volume, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteItemType(DSS2_SynchromodalityCapacityOptimisation.BO.ItemType itemtype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePriority(DSS2_SynchromodalityCapacityOptimisation.BO.Priority priority, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStatus(DSS2_SynchromodalityCapacityOptimisation.BO.Status status, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteLocation(DSS2_SynchromodalityCapacityOptimisation.BO.Location location, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCoordinates(DSS2_SynchromodalityCapacityOptimisation.BO.Coordinates coordinates, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteReason(DSS2_SynchromodalityCapacityOptimisation.BO.Reason reason, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCondition(DSS2_SynchromodalityCapacityOptimisation.BO.Condition condition, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteLegVolumeDetails(DSS2_SynchromodalityCapacityOptimisation.BO.LegVolumeDetails legvolumedetails, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePathVolumeDetail(DSS2_SynchromodalityCapacityOptimisation.BO.PathVolumeDetail pathvolumedetail, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCostSplit(DSS2_SynchromodalityCapacityOptimisation.BO.CostSplit costsplit, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStatusRule(DSS2_SynchromodalityCapacityOptimisation.BO.StatusRule statusrule, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteVehicule(DSS2_SynchromodalityCapacityOptimisation.BO.Vehicule vehicule, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDistanceCosts(DSS2_SynchromodalityCapacityOptimisation.BO.DistanceCosts distancecosts, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteTimeCosts(DSS2_SynchromodalityCapacityOptimisation.BO.TimeCosts timecosts, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOwnershipCost(DSS2_SynchromodalityCapacityOptimisation.BO.OwnershipCost ownershipcost, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePropulsionTypeCost(DSS2_SynchromodalityCapacityOptimisation.BO.PropulsionTypeCost propulsiontypecost, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOilType(DSS2_SynchromodalityCapacityOptimisation.BO.OilType oiltype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAmortizationType(DSS2_SynchromodalityCapacityOptimisation.BO.AmortizationType amortizationtype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteVolumePerShipper(DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper volumepershipper, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCO2PerCarrier(DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier co2percarrier, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCustomVolume(DSS2_SynchromodalityCapacityOptimisation.BO.CustomVolume customvolume, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteVolumeComponent(DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComponent volumecomponent, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteVolumeComposition(DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition volumecomposition, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSolution(DSS2_SynchromodalityCapacityOptimisation.BO.Solution solution, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteRoute(DSS2_SynchromodalityCapacityOptimisation.BO.Route route, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteActivity(DSS2_SynchromodalityCapacityOptimisation.BO.Activity activity, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderStatistics(DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics orderstatistics, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteLSP(DSS2_SynchromodalityCapacityOptimisation.BO.LSP lsp, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteLSPUser(DSS2_SynchromodalityCapacityOptimisation.BO.LSPUser lspuser, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderWMS(DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS orderwms, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteProofOfDelivery(DSS2_SynchromodalityCapacityOptimisation.BO.ProofOfDelivery proofofdelivery, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteRegionalAgent(DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent regionalagent, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteRegionalAgentUser(DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgentUser regionalagentuser, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteGeoCoordinates(DSS2_SynchromodalityCapacityOptimisation.BO.GeoCoordinates geocoordinates, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteGeoArea(DSS2_SynchromodalityCapacityOptimisation.BO.GeoArea geoarea, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteTruckDriver(DSS2_SynchromodalityCapacityOptimisation.BO.TruckDriver truckdriver, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteTruck(DSS2_SynchromodalityCapacityOptimisation.BO.Truck truck, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrdersPerMonth(DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth orderspermonth, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteChartWorkaround(DSS2_SynchromodalityCapacityOptimisation.BO.ChartWorkaround chartworkaround, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteMapPoints(DSS2_SynchromodalityCapacityOptimisation.BO.MapPoints mappoints, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAVGTime(DSS2_SynchromodalityCapacityOptimisation.BO.AVGTime avgtime, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStatePeriod(DSS2_SynchromodalityCapacityOptimisation.BO.StatePeriod stateperiod, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteScheduledRouteTemplate(DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteTemplate scheduledroutetemplate, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteScheduledRoute(DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute scheduledroute, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWorkContract(DSS2_SynchromodalityCapacityOptimisation.BO.WorkContract workcontract, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteTblZslNormalisationSuggestion(DSS2_SynchromodalityCapacityOptimisation.BO.TblZslNormalisationSuggestion tblzslnormalisationsuggestion, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslBookingType(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslBookingType tblzslbookingtype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslCarrier(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCarrier tblzslcarrier, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslCustomer(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCustomer tblzslcustomer, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslDeliveryStatus(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslDeliveryStatus tblzsldeliverystatus, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslPlatformBookingOrder(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslPlatformBookingOrder tblzslplatformbookingorder, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslRoute(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslRoute tblzslroute, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslTransportDetail(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportDetail tblzsltransportdetail, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslTransportEvent(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportEvent tblzsltransportevent, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslTransportExecutionPlan(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportExecutionPlan tblzsltransportexecutionplan, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslTransportOrder(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportOrder tblzsltransportorder, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblZslWorker(DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker tblzslworker, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblActivitiesAPI(DSS2_SynchromodalityCapacityOptimisation.BO.tblActivitiesAPI tblactivitiesapi, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblReceivedEvent(DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedEvent tblreceivedevent, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblReceivedPlannedTransport(DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport tblreceivedplannedtransport, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblReceivedTrainStatus(DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTrainStatus tblreceivedtrainstatus, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblReceivedTransportStopVehicle(DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStopVehicle tblreceivedtransportstopvehicle, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblReceivedTransportStop(DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStop tblreceivedtransportstop, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblRoutesAPI(DSS2_SynchromodalityCapacityOptimisation.BO.tblRoutesAPI tblroutesapi, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletetblSolutionsAPI(DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI tblsolutionsapi, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAgreement(DSS2_SynchromodalityCapacityOptimisation.BO.Agreement agreement, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAgreementStatus(DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus agreementstatus, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteResponse(DSS2_SynchromodalityCapacityOptimisation.BO.Response response, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAppNotification(DSS2_SynchromodalityCapacityOptimisation.BO.AppNotification appnotification, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAppNotificationAction(DSS2_SynchromodalityCapacityOptimisation.BO.AppNotificationAction appnotificationaction, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCompany(DSS2_SynchromodalityCapacityOptimisation.BO.Company company, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteContact(DSS2_SynchromodalityCapacityOptimisation.BO.Contact contact, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDashboard(DSS2_SynchromodalityCapacityOptimisation.BO.Dashboard dashboard, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStatistics(DSS2_SynchromodalityCapacityOptimisation.BO.Statistics statistics, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDeliverySchedule(DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule deliveryschedule, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteCategory(DSS2_SynchromodalityCapacityOptimisation.BO.Category category, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSubCategory(DSS2_SynchromodalityCapacityOptimisation.BO.SubCategory subcategory, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteBusinessUnit(DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit businessunit, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteBaseUnit(DSS2_SynchromodalityCapacityOptimisation.BO.BaseUnit baseunit, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteInventoryItem(DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem inventoryitem, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteItem(DSS2_SynchromodalityCapacityOptimisation.BO.Item item, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSupplierCapacity(DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity suppliercapacity, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWasteOld(DSS2_SynchromodalityCapacityOptimisation.BO.WasteOld wasteold, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteMinimumQuantity(DSS2_SynchromodalityCapacityOptimisation.BO.MinimumQuantity minimumquantity, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteNotification(DSS2_SynchromodalityCapacityOptimisation.BO.Notification notification, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderFDashboard(DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard orderfdashboard, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderForecastStatistic(DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic orderforecaststatistic, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderForecastDetails(DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastDetails orderforecastdetails, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteOrderForecast(DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecast orderforecast, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteItemParameter(DSS2_SynchromodalityCapacityOptimisation.BO.ItemParameter itemparameter, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSupplierParameter(DSS2_SynchromodalityCapacityOptimisation.BO.SupplierParameter supplierparameter, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteComment(DSS2_SynchromodalityCapacityOptimisation.BO.Comment comment, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePastOrder(DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder pastorder, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteRetailer(DSS2_SynchromodalityCapacityOptimisation.BO.Retailer retailer, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSales(DSS2_SynchromodalityCapacityOptimisation.BO.Sales sales, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePastSales(DSS2_SynchromodalityCapacityOptimisation.BO.PastSales pastsales, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDeliveryPlan(DSS2_SynchromodalityCapacityOptimisation.BO.DeliveryPlan deliveryplan, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSalesForecastDetails(DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails salesforecastdetails, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSalesForecast(DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecast salesforecast, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSLALeadTime(DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime slaleadtime, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSLADelivery(DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery sladelivery, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeletePlatform(DSS2_SynchromodalityCapacityOptimisation.BO.Platform platform, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSLAStatistics(DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics slastatistics, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteUnitsKPI(DSS2_SynchromodalityCapacityOptimisation.BO.UnitsKPI unitskpi, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStats(DSS2_SynchromodalityCapacityOptimisation.BO.Stats stats, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStockOnHand(DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand stockonhand, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteStore(DSS2_SynchromodalityCapacityOptimisation.BO.Store store, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteSupplier(DSS2_SynchromodalityCapacityOptimisation.BO.Supplier supplier, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteTransportUnCap(DSS2_SynchromodalityCapacityOptimisation.BO.TransportUnCap transportuncap, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWarehouse(DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse warehouse, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationUserAction(zAppDev.DotNet.Framework.Identity.Model.ApplicationUserAction applicationuseraction, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationUserExternalProfile(zAppDev.DotNet.Framework.Identity.Model.ApplicationUserExternalProfile applicationuserexternalprofile, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationSetting(zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting applicationsetting, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationUser(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser applicationuser, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationRole(zAppDev.DotNet.Framework.Identity.Model.ApplicationRole applicationrole, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationOperation(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation applicationoperation, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationPermission(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission applicationpermission, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationClient(zAppDev.DotNet.Framework.Identity.Model.ApplicationClient applicationclient, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationUserLogin(zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin applicationuserlogin, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationUserClaim(zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim applicationuserclaim, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteProfileSetting(zAppDev.DotNet.Framework.Identity.Model.ProfileSetting profilesetting, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteProfile(zAppDev.DotNet.Framework.Identity.Model.Profile profile, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationLanguage(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage applicationlanguage, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteDateTimeFormat(zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat datetimeformat, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteApplicationTheme(zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme applicationtheme, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteFileData(DSS2_SynchromodalityCapacityOptimisation.BO.FileData filedata, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAuditEntityConfiguration(zAppDev.DotNet.Framework.Auditing.Model.AuditEntityConfiguration auditentityconfiguration, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAuditPropertyConfiguration(zAppDev.DotNet.Framework.Auditing.Model.AuditPropertyConfiguration auditpropertyconfiguration, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAuditLogEntry(zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry auditlogentry, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAuditLogEntryType(zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType auditlogentrytype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteAuditLogPropertyActionType(zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType auditlogpropertyactiontype, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWorkflowContextBase(zAppDev.DotNet.Framework.Workflow.WorkflowContextBase workflowcontextbase, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWorkflowSchedule(zAppDev.DotNet.Framework.Workflow.WorkflowSchedule workflowschedule, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        void DeleteWorkflowSockContext(DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext workflowsockcontext, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null);
        List<T> Get<T>(Expression<Func<T, bool>> predicate, bool cacheQuery = true);
        List<T> Get<T>(Expression<Func<T, bool>> predicate,
                       int startRowIndex,
                       int pageSize,
                       Dictionary<Expression<Func<T, object>>, bool> orderBy,
                       out int totalRecords, bool cacheQuery = true);

        List<T> GetAll<T>(bool cacheQuery = true);
        List<T> GetAll<T>(int startRowIndex, int pageSize, out int totalRecords, bool cacheQuery = true);
    }
}
