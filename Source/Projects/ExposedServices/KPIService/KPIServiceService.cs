// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;
using System.Security.Permissions;
using System.Security.Principal;
using NHibernate;
using System.ServiceModel.Activation;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using DSS2_SynchromodalityCapacityOptimisation.Services.KPIService.DataContracts;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using AutoMapper;

namespace DSS2_SynchromodalityCapacityOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class KPIServiceService : IKPIServiceService
    {
        public System.Collections.Generic.List<VolumePerShipperDTO> GetVolumePerLSP(string name, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputName = name;
                var _getVolumePerLSP = GetVolumePerLSPImplementation(inputName);
                var result = Mapper.Map<System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper>, System.Collections.Generic.List<VolumePerShipperDTO>>(_getVolumePerLSP);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("KPIService Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<VolumePerShipperDTO> GetVolumePerUnit(string name, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputName = name;
                var _getVolumePerUnit = GetVolumePerUnitImplementation(inputName);
                var result = Mapper.Map<System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper>, System.Collections.Generic.List<VolumePerShipperDTO>>(_getVolumePerUnit);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("KPIService Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<CO2PerCarrierDTO> CO2PerCarrier(string name, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputName = name;
                var _cO2PerCarrier = CO2PerCarrierImplementation(inputName);
                var result = Mapper.Map<System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier>, System.Collections.Generic.List<CO2PerCarrierDTO>>(_cO2PerCarrier);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("KPIService Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<VolumePerShipperDTO, DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper, VolumePerShipperDTO>();
            Mapper.CreateMap<CO2PerCarrierDTO, DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier, CO2PerCarrierDTO>();
        }

        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper> GetVolumePerLSPImplementation(string Name)
        {
            System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper> ChartElement = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper>();
            foreach (var i in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>((a) => a.Shipper == Name) ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>())
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, i?.Carrier != "");
                if ((i?.Carrier != ""))
                {
                    decimal? OrderVolume = (i?.Get_AggregateVolume() ?? 0);
                    var _var0 = i?.Carrier;
                    if ((ChartElement?.Any((a) => a.Description == _var0) ?? false))
                    {
                        var _var1 = i?.Carrier;
                        ChartElement.FirstOrDefault((a) => a.Description == i.Carrier).Volume = (ChartElement?.FirstOrDefault((a) => a.Description == _var1)?.Volume ?? 0) + OrderVolume.GetValueOrDefault(0);
                    }
                    else
                    {
                        DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper GraphElement = new DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper();
                        GraphElement.Description = (i?.Carrier ?? "");
                        GraphElement.Volume = OrderVolume;
                        ChartElement?.Add(GraphElement);
                    }
                }
            }
            return ChartElement;
        }

        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper> GetVolumePerUnitImplementation(string Name)
        {
            System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper> VolumeSpreadChart = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper>();
            foreach (var i in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>((a) => a.Shipper == Name) ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>())
            {
                foreach (var j in i?.PlannedVolume ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.CustomVolume>())
                {
                    foreach (var k in j?.VolumeComposition ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition>())
                    {
                        var _var2 = k?.VolumeComponent?.Name;
                        if ((VolumeSpreadChart?.Any((a) => a.Description == _var2) ?? false))
                        {
                            var _var3 = k?.VolumeComponent?.Name;
                            VolumeSpreadChart.FirstOrDefault((a) => a.Description == k.VolumeComponent.Name).Volume = (VolumeSpreadChart?.FirstOrDefault((a) => a.Description == _var3)?.Volume ?? 0) + 1;
                        }
                        else
                        {
                            DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper GraphElement = new DSS2_SynchromodalityCapacityOptimisation.BO.VolumePerShipper();
                            GraphElement.Description = (k?.VolumeComponent?.Name ?? "");
                            GraphElement.Volume = 1;
                            VolumeSpreadChart?.Add(GraphElement);
                        }
                    }
                }
            }
            return VolumeSpreadChart;
        }

        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier> CO2PerCarrierImplementation(string Name)
        {
            System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier> ChartElement = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier>();
            foreach (var i in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>((a) => a.Shipper == Name) ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder>())
            {
                if ((i?.Carrier != ""))
                {
                    decimal? OrderVolume = (i?.Get_AggregateVolume() ?? 0);
                    var _var4 = i?.Carrier;
                    if ((ChartElement?.Any((a) => a.Description == _var4) ?? false))
                    {
                        var _var5 = i?.Carrier;
                        ChartElement.FirstOrDefault((a) => a.Description == i.Carrier).KgCO2 = (ChartElement?.FirstOrDefault((a) => a.Description == _var5)?.KgCO2 ?? 0) + OrderVolume.GetValueOrDefault(0);
                    }
                    else
                    {
                        DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier GraphElement = new DSS2_SynchromodalityCapacityOptimisation.BO.CO2PerCarrier();
                        GraphElement.Description = (i?.Carrier ?? "");
                        GraphElement.KgCO2 = OrderVolume.GetValueOrDefault(0) * 5.8m;
                        ChartElement?.Add(GraphElement);
                    }
                }
            }
            return ChartElement;
        }


    }
}