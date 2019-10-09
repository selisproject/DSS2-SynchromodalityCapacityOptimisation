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
using DSS2_SynchromodalityCapacityOptimisation.Services.DataSeed.DataContracts;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using AutoMapper;

namespace DSS2_SynchromodalityCapacityOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class DataSeedService : IDataSeedService
    {
        public void Orders(DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS[] _orders, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputorders = _orders;
                OrdersImplementation(inputorders);
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void InitRegionalAgents(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                InitRegionalAgentsImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void Change(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                ChangeImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void TestGoogleAPI(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                TestGoogleAPIImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void initWarehouse(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                initWarehouseImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<OrderWMSDTO> testOrderGenerator(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var _exposedOperation = testOrderGeneratorImplementation();
                var result = Mapper.Map<System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>, System.Collections.Generic.List<OrderWMSDTO>>(_exposedOperation);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public System.Collections.Generic.List<PubMessageDTO> testReflection(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var _exposedOperation = testReflectionImplementation();
                var result = Mapper.Map<System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.PubMessage>, System.Collections.Generic.List<PubMessageDTO>>(_exposedOperation);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }
        public void TruckPosistions(string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                TruckPosistionsImplementation();
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("DataSeed Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<OrderWMSDTO, DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS, OrderWMSDTO>();
            Mapper.CreateMap<PubMessageDTO, DSS2_SynchromodalityCapacityOptimisation.BO.PubMessage>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.PubMessage, PubMessageDTO>();
            Mapper.CreateMap<TruckDTO, DSS2_SynchromodalityCapacityOptimisation.BO.Truck>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.Truck, TruckDTO>();
        }

        public static void OrdersImplementation(DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS[] orders)
        {
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Communication started ");
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Started insertion of " + orders.Length.ToString() + " on " + DateTime.UtcNow.ToString());
            DSS2_SynchromodalityCapacityOptimisation.Services.RAService.GetRAImplementation("test");
            try
            {
                foreach (var order in orders ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>())
                {
                    order.Id = 0;
                    new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Save<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>(order);
                }
            }
            catch (System.Exception x)
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void InitRegionalAgentsImplementation()
        {
            try
            {
                foreach (var order in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAll<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>() ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>())
                {
                    string racode = (order?.OrdAgencyCode ?? "");
                    DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent ra = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent>((r) => r.AgencyCode == racode)?.FirstOrDefault();
                    if ((ra == null))
                    {
                        ra = new DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent();
                        ra.AgencyCode = racode;
                        ra.AgencyAddress = (order?.OrdAgencyAddress ?? "");
                        ra.AgencyDescription = (order?.OrdAgencyDescr ?? "");
                        new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Save<DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgent>(ra);
                    }
                }
            }
            catch (System.Exception x)
            {
                throw x;
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void ChangeImplementation()
        {
            try
            {
                foreach (var order in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAll<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>() ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>())
                {
                    int? r = zAppDev.DotNet.Framework.Utilities.Common.Random.Next(1, 100);
                    order.OrdDeliveryValue = float.Parse((r?.ToString() ?? ""), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                    new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Update<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>(order);
                }
            }
            catch (System.Exception x)
            {
                throw x;
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, x);
            }
        }

        public static void TestGoogleAPIImplementation()
        {
            DSS2_SynchromodalityCapacityOptimisation.BO.RegionalAgentExtensions.InitAddressGeocoordinates();
        }

        public static void initWarehouseImplementation()
        {
            DSS2_SynchromodalityCapacityOptimisation.BO.WarehouseExtensions.InitWarehouse();
        }

        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS> testOrderGeneratorImplementation()
        {
            return DSS2_SynchromodalityCapacityOptimisation.BO.OrderGeneratorExtensions.GenerateOrders(10);
        }

        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.PubMessage> testReflectionImplementation()
        {
            var _count0 = 0;
            DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS order = zAppDev.DotNet.Framework.Utilities.Common.GetItemFromList(new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAll<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>(01, 10,out _count0), 3);
            return DSS2_SynchromodalityCapacityOptimisation.BO.UtilsExtensions.InitPubMessage(order);
        }

        public static void TruckPosistionsImplementation()
        {
            DSS2_SynchromodalityCapacityOptimisation.BO.UtilsExtensions.InitTruckPositions();
        }


    }
}