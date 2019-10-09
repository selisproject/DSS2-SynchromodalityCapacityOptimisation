// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using Iesi.Collections;
using log4net;
using NHibernate.Event;
using NHibernate.Util;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DSS2_SynchromodalityCapacityOptimisation.BO;

namespace DSS2_SynchromodalityCapacityOptimisation.DAL
{
    public class OnDeleteListener : IDeleteEventListener
    {
        public System.Threading.Tasks.Task OnDeleteAsync(DeleteEvent @event, CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.Run(() => OnDelete(@event), cancellationToken);
        }

        public System.Threading.Tasks.Task OnDeleteAsync(DeleteEvent @event, ISet<object> transientEntities, CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.Run(() => OnDelete(@event, transientEntities), cancellationToken);
        }

        public void OnDelete(DeleteEvent @event)
        {
            OnDelete(@event, new IdentitySet());
        }

        public void OnDelete(DeleteEvent @event, ISet<object> transientEntities)
        {
            var entity = @event.Entity;
            System.Type entityType = entity.GetType();
            if (entityType.AssemblyQualifiedName.IndexOf("ProxyAssembly", StringComparison.OrdinalIgnoreCase) > -1)
            {
                entityType = entityType.BaseType;
            }
            try
            {
                switch (entity.GetType().FullName)
                {
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlEvent":
                    (new Repository()).DeletetblDhlEvent((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlEvent)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlIncident":
                    (new Repository()).DeletetblDhlIncident((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlIncident)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPlannedRoute":
                    (new Repository()).DeletetblDhlPlannedRoute((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPlannedRoute)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPurchase":
                    (new Repository()).DeletetblDhlPurchase((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlPurchase)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStopOperation":
                    (new Repository()).DeletetblDhlRouteStopOperation((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStopOperation)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStop":
                    (new Repository()).DeletetblDhlRouteStop((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlRouteStop)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlTracking":
                    (new Repository()).DeletetblDhlTracking((DSS2_SynchromodalityCapacityOptimisation.BO.tblDhlTracking)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Shipment":
                    (new Repository()).DeleteShipment((DSS2_SynchromodalityCapacityOptimisation.BO.Shipment)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ShipmentStatus":
                    (new Repository()).DeleteShipmentStatus((DSS2_SynchromodalityCapacityOptimisation.BO.ShipmentStatus)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Point":
                    (new Repository()).DeletePoint((DSS2_SynchromodalityCapacityOptimisation.BO.Point)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Driver":
                    (new Repository()).DeleteDriver((DSS2_SynchromodalityCapacityOptimisation.BO.Driver)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder":
                    (new Repository()).DeleteShippingOrder((DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.StatusEvolution":
                    (new Repository()).DeleteStatusEvolution((DSS2_SynchromodalityCapacityOptimisation.BO.StatusEvolution)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Volume":
                    (new Repository()).DeleteVolume((DSS2_SynchromodalityCapacityOptimisation.BO.Volume)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ItemType":
                    (new Repository()).DeleteItemType((DSS2_SynchromodalityCapacityOptimisation.BO.ItemType)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Priority":
                    (new Repository()).DeletePriority((DSS2_SynchromodalityCapacityOptimisation.BO.Priority)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Status":
                    (new Repository()).DeleteStatus((DSS2_SynchromodalityCapacityOptimisation.BO.Status)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Location":
                    (new Repository()).DeleteLocation((DSS2_SynchromodalityCapacityOptimisation.BO.Location)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Coordinates":
                    (new Repository()).DeleteCoordinates((DSS2_SynchromodalityCapacityOptimisation.BO.Coordinates)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Reason":
                    (new Repository()).DeleteReason((DSS2_SynchromodalityCapacityOptimisation.BO.Reason)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Condition":
                    (new Repository()).DeleteCondition((DSS2_SynchromodalityCapacityOptimisation.BO.Condition)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.LegVolumeDetails":
                    (new Repository()).DeleteLegVolumeDetails((DSS2_SynchromodalityCapacityOptimisation.BO.LegVolumeDetails)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.PathVolumeDetail":
                    (new Repository()).DeletePathVolumeDetail((DSS2_SynchromodalityCapacityOptimisation.BO.PathVolumeDetail)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.CostSplit":
                    (new Repository()).DeleteCostSplit((DSS2_SynchromodalityCapacityOptimisation.BO.CostSplit)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.StatusRule":
                    (new Repository()).DeleteStatusRule((DSS2_SynchromodalityCapacityOptimisation.BO.StatusRule)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Vehicule":
                    (new Repository()).DeleteVehicule((DSS2_SynchromodalityCapacityOptimisation.BO.Vehicule)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.DistanceCosts":
                    (new Repository()).DeleteDistanceCosts((DSS2_SynchromodalityCapacityOptimisation.BO.DistanceCosts)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.TimeCosts":
                    (new Repository()).DeleteTimeCosts((DSS2_SynchromodalityCapacityOptimisation.BO.TimeCosts)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OwnershipCost":
                    (new Repository()).DeleteOwnershipCost((DSS2_SynchromodalityCapacityOptimisation.BO.OwnershipCost)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.PropulsionTypeCost":
                    (new Repository()).DeletePropulsionTypeCost((DSS2_SynchromodalityCapacityOptimisation.BO.PropulsionTypeCost)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OilType":
                    (new Repository()).DeleteOilType((DSS2_SynchromodalityCapacityOptimisation.BO.OilType)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.AmortizationType":
                    (new Repository()).DeleteAmortizationType((DSS2_SynchromodalityCapacityOptimisation.BO.AmortizationType)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper":
                    (new Repository()).DeleteVolumePerShipper((DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier":
                    (new Repository()).DeleteCO2PerCarrier((DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.CustomVolume":
                    (new Repository()).DeleteCustomVolume((DSS2_SynchromodalityCapacityOptimisation.BO.CustomVolume)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComponent":
                    (new Repository()).DeleteVolumeComponent((DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComponent)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition":
                    (new Repository()).DeleteVolumeComposition((DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Solution":
                    (new Repository()).DeleteSolution((DSS2_SynchromodalityCapacityOptimisation.BO.Solution)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Route":
                    (new Repository()).DeleteRoute((DSS2_SynchromodalityCapacityOptimisation.BO.Route)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Activity":
                    (new Repository()).DeleteActivity((DSS2_SynchromodalityCapacityOptimisation.BO.Activity)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics":
                    (new Repository()).DeleteOrderStatistics((DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.LSP":
                    (new Repository()).DeleteLSP((DSS2_SynchromodalityCapacityOptimisation.BO.LSP)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.LSPUser":
                    (new Repository()).DeleteLSPUser((DSS2_SynchromodalityCapacityOptimisation.BO.LSPUser)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS":
                    (new Repository()).DeleteOrderWMS((DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ProofOfDelivery":
                    (new Repository()).DeleteProofOfDelivery((DSS2_SynchromodalityCapacityOptimisation.BO.ProofOfDelivery)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent":
                    (new Repository()).DeleteRegionalAgent((DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgentUser":
                    (new Repository()).DeleteRegionalAgentUser((DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgentUser)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.GeoCoordinates":
                    (new Repository()).DeleteGeoCoordinates((DSS2_SynchromodalityCapacityOptimisation.BO.GeoCoordinates)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.GeoArea":
                    (new Repository()).DeleteGeoArea((DSS2_SynchromodalityCapacityOptimisation.BO.GeoArea)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.TruckDriver":
                    (new Repository()).DeleteTruckDriver((DSS2_SynchromodalityCapacityOptimisation.BO.TruckDriver)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Truck":
                    (new Repository()).DeleteTruck((DSS2_SynchromodalityCapacityOptimisation.BO.Truck)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth":
                    (new Repository()).DeleteOrdersPerMonth((DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ChartWorkaround":
                    (new Repository()).DeleteChartWorkaround((DSS2_SynchromodalityCapacityOptimisation.BO.ChartWorkaround)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.MapPoints":
                    (new Repository()).DeleteMapPoints((DSS2_SynchromodalityCapacityOptimisation.BO.MapPoints)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.AVGTime":
                    (new Repository()).DeleteAVGTime((DSS2_SynchromodalityCapacityOptimisation.BO.AVGTime)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.StatePeriod":
                    (new Repository()).DeleteStatePeriod((DSS2_SynchromodalityCapacityOptimisation.BO.StatePeriod)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteTemplate":
                    (new Repository()).DeleteScheduledRouteTemplate((DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteTemplate)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute":
                    (new Repository()).DeleteScheduledRoute((DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.WorkContract":
                    (new Repository()).DeleteWorkContract((DSS2_SynchromodalityCapacityOptimisation.BO.WorkContract)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.TblZslNormalisationSuggestion":
                    (new Repository()).DeleteTblZslNormalisationSuggestion((DSS2_SynchromodalityCapacityOptimisation.BO.TblZslNormalisationSuggestion)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslBookingType":
                    (new Repository()).DeletetblZslBookingType((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslBookingType)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCarrier":
                    (new Repository()).DeletetblZslCarrier((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCarrier)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCustomer":
                    (new Repository()).DeletetblZslCustomer((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslCustomer)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslDeliveryStatus":
                    (new Repository()).DeletetblZslDeliveryStatus((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslDeliveryStatus)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslPlatformBookingOrder":
                    (new Repository()).DeletetblZslPlatformBookingOrder((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslPlatformBookingOrder)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslRoute":
                    (new Repository()).DeletetblZslRoute((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslRoute)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportDetail":
                    (new Repository()).DeletetblZslTransportDetail((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportDetail)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportEvent":
                    (new Repository()).DeletetblZslTransportEvent((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportEvent)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportExecutionPlan":
                    (new Repository()).DeletetblZslTransportExecutionPlan((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportExecutionPlan)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportOrder":
                    (new Repository()).DeletetblZslTransportOrder((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslTransportOrder)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker":
                    (new Repository()).DeletetblZslWorker((DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblActivitiesAPI":
                    (new Repository()).DeletetblActivitiesAPI((DSS2_SynchromodalityCapacityOptimisation.BO.tblActivitiesAPI)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedEvent":
                    (new Repository()).DeletetblReceivedEvent((DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedEvent)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport":
                    (new Repository()).DeletetblReceivedPlannedTransport((DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTrainStatus":
                    (new Repository()).DeletetblReceivedTrainStatus((DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTrainStatus)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStopVehicle":
                    (new Repository()).DeletetblReceivedTransportStopVehicle((DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStopVehicle)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStop":
                    (new Repository()).DeletetblReceivedTransportStop((DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedTransportStop)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblRoutesAPI":
                    (new Repository()).DeletetblRoutesAPI((DSS2_SynchromodalityCapacityOptimisation.BO.tblRoutesAPI)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI":
                    (new Repository()).DeletetblSolutionsAPI((DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Agreement":
                    (new Repository()).DeleteAgreement((DSS2_SynchromodalityCapacityOptimisation.BO.Agreement)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus":
                    (new Repository()).DeleteAgreementStatus((DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Response":
                    (new Repository()).DeleteResponse((DSS2_SynchromodalityCapacityOptimisation.BO.Response)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.AppNotification":
                    (new Repository()).DeleteAppNotification((DSS2_SynchromodalityCapacityOptimisation.BO.AppNotification)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.AppNotificationAction":
                    (new Repository()).DeleteAppNotificationAction((DSS2_SynchromodalityCapacityOptimisation.BO.AppNotificationAction)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Company":
                    (new Repository()).DeleteCompany((DSS2_SynchromodalityCapacityOptimisation.BO.Company)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Contact":
                    (new Repository()).DeleteContact((DSS2_SynchromodalityCapacityOptimisation.BO.Contact)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Dashboard":
                    (new Repository()).DeleteDashboard((DSS2_SynchromodalityCapacityOptimisation.BO.Dashboard)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Statistics":
                    (new Repository()).DeleteStatistics((DSS2_SynchromodalityCapacityOptimisation.BO.Statistics)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule":
                    (new Repository()).DeleteDeliverySchedule((DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Category":
                    (new Repository()).DeleteCategory((DSS2_SynchromodalityCapacityOptimisation.BO.Category)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SubCategory":
                    (new Repository()).DeleteSubCategory((DSS2_SynchromodalityCapacityOptimisation.BO.SubCategory)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit":
                    (new Repository()).DeleteBusinessUnit((DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.BaseUnit":
                    (new Repository()).DeleteBaseUnit((DSS2_SynchromodalityCapacityOptimisation.BO.BaseUnit)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem":
                    (new Repository()).DeleteInventoryItem((DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Item":
                    (new Repository()).DeleteItem((DSS2_SynchromodalityCapacityOptimisation.BO.Item)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity":
                    (new Repository()).DeleteSupplierCapacity((DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.WasteOld":
                    (new Repository()).DeleteWasteOld((DSS2_SynchromodalityCapacityOptimisation.BO.WasteOld)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.MinimumQuantity":
                    (new Repository()).DeleteMinimumQuantity((DSS2_SynchromodalityCapacityOptimisation.BO.MinimumQuantity)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Notification":
                    (new Repository()).DeleteNotification((DSS2_SynchromodalityCapacityOptimisation.BO.Notification)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard":
                    (new Repository()).DeleteOrderFDashboard((DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic":
                    (new Repository()).DeleteOrderForecastStatistic((DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastDetails":
                    (new Repository()).DeleteOrderForecastDetails((DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastDetails)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecast":
                    (new Repository()).DeleteOrderForecast((DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecast)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.ItemParameter":
                    (new Repository()).DeleteItemParameter((DSS2_SynchromodalityCapacityOptimisation.BO.ItemParameter)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SupplierParameter":
                    (new Repository()).DeleteSupplierParameter((DSS2_SynchromodalityCapacityOptimisation.BO.SupplierParameter)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Comment":
                    (new Repository()).DeleteComment((DSS2_SynchromodalityCapacityOptimisation.BO.Comment)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder":
                    (new Repository()).DeletePastOrder((DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Retailer":
                    (new Repository()).DeleteRetailer((DSS2_SynchromodalityCapacityOptimisation.BO.Retailer)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Sales":
                    (new Repository()).DeleteSales((DSS2_SynchromodalityCapacityOptimisation.BO.Sales)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.PastSales":
                    (new Repository()).DeletePastSales((DSS2_SynchromodalityCapacityOptimisation.BO.PastSales)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.DeliveryPlan":
                    (new Repository()).DeleteDeliveryPlan((DSS2_SynchromodalityCapacityOptimisation.BO.DeliveryPlan)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails":
                    (new Repository()).DeleteSalesForecastDetails((DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecast":
                    (new Repository()).DeleteSalesForecast((DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecast)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime":
                    (new Repository()).DeleteSLALeadTime((DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery":
                    (new Repository()).DeleteSLADelivery((DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Platform":
                    (new Repository()).DeletePlatform((DSS2_SynchromodalityCapacityOptimisation.BO.Platform)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics":
                    (new Repository()).DeleteSLAStatistics((DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.UnitsKPI":
                    (new Repository()).DeleteUnitsKPI((DSS2_SynchromodalityCapacityOptimisation.BO.UnitsKPI)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Stats":
                    (new Repository()).DeleteStats((DSS2_SynchromodalityCapacityOptimisation.BO.Stats)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand":
                    (new Repository()).DeleteStockOnHand((DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Store":
                    (new Repository()).DeleteStore((DSS2_SynchromodalityCapacityOptimisation.BO.Store)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Supplier":
                    (new Repository()).DeleteSupplier((DSS2_SynchromodalityCapacityOptimisation.BO.Supplier)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.TransportUnCap":
                    (new Repository()).DeleteTransportUnCap((DSS2_SynchromodalityCapacityOptimisation.BO.TransportUnCap)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse":
                    (new Repository()).DeleteWarehouse((DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserAction":
                    (new Repository()).DeleteApplicationUserAction((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserAction)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserExternalProfile":
                    (new Repository()).DeleteApplicationUserExternalProfile((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserExternalProfile)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting":
                    (new Repository()).DeleteApplicationSetting((zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUser":
                    (new Repository()).DeleteApplicationUser((zAppDev.DotNet.Framework.Identity.Model.ApplicationUser)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationRole":
                    (new Repository()).DeleteApplicationRole((zAppDev.DotNet.Framework.Identity.Model.ApplicationRole)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation":
                    (new Repository()).DeleteApplicationOperation((zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission":
                    (new Repository()).DeleteApplicationPermission((zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationClient":
                    (new Repository()).DeleteApplicationClient((zAppDev.DotNet.Framework.Identity.Model.ApplicationClient)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin":
                    (new Repository()).DeleteApplicationUserLogin((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim":
                    (new Repository()).DeleteApplicationUserClaim((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ProfileSetting":
                    (new Repository()).DeleteProfileSetting((zAppDev.DotNet.Framework.Identity.Model.ProfileSetting)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.Profile":
                    (new Repository()).DeleteProfile((zAppDev.DotNet.Framework.Identity.Model.Profile)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage":
                    (new Repository()).DeleteApplicationLanguage((zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat":
                    (new Repository()).DeleteDateTimeFormat((zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme":
                    (new Repository()).DeleteApplicationTheme((zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.FileData":
                    (new Repository()).DeleteFileData((DSS2_SynchromodalityCapacityOptimisation.BO.FileData)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditEntityConfiguration":
                    (new Repository()).DeleteAuditEntityConfiguration((zAppDev.DotNet.Framework.Auditing.Model.AuditEntityConfiguration)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditPropertyConfiguration":
                    (new Repository()).DeleteAuditPropertyConfiguration((zAppDev.DotNet.Framework.Auditing.Model.AuditPropertyConfiguration)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry":
                    (new Repository()).DeleteAuditLogEntry((zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType":
                    (new Repository()).DeleteAuditLogEntryType((zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType":
                    (new Repository()).DeleteAuditLogPropertyActionType((zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Workflow.WorkflowContextBase":
                    (new Repository()).DeleteWorkflowContextBase((zAppDev.DotNet.Framework.Workflow.WorkflowContextBase)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Workflow.WorkflowSchedule":
                    (new Repository()).DeleteWorkflowSchedule((zAppDev.DotNet.Framework.Workflow.WorkflowSchedule)entity, true, true, null);
                    break;
                case "DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext":
                    (new Repository()).DeleteWorkflowSockContext((DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext)entity, true, true, null);
                    break;
                }
            }
            catch (Exception e)
            {
                (LogManager.GetLogger(this.GetType())).Error("Error deleting: " + entityType.FullName, e);
                throw;
            }
        }
    }
}