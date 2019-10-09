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
using DSS2_SynchromodalityCapacityOptimisation.Services.pastOrders.DataContracts;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using AutoMapper;

namespace DSS2_SynchromodalityCapacityOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class pastOrdersService : IpastOrdersService
    {
        public ResponseDTO Import(System.Collections.Generic.List<PastOrderDTO> _pOrders, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputpOrders = Mapper.Map<System.Collections.Generic.List<PastOrderDTO>, System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder>>(_pOrders);
                var _import = ImportImplementation(inputpOrders);
                var result = Mapper.Map<DSS2_SynchromodalityCapacityOptimisation.BO.Response, ResponseDTO>(_import);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("pastOrders Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<ItemDTO, DSS2_SynchromodalityCapacityOptimisation.BO.Item>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.Item, ItemDTO>();
            Mapper.CreateMap<PastOrderDTO, DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder, PastOrderDTO>();
            Mapper.CreateMap<ResponseDTO, DSS2_SynchromodalityCapacityOptimisation.BO.Response>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.Response, ResponseDTO>();
            Mapper.CreateMap<StockOnHandDTO, DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand, StockOnHandDTO>();
            Mapper.CreateMap<SupplierCapacityDTO, DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity, SupplierCapacityDTO>();
            Mapper.CreateMap<WarehouseDTO, DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse>();
            Mapper.CreateMap<DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse, WarehouseDTO>();
        }

        public static DSS2_SynchromodalityCapacityOptimisation.BO.Response ImportImplementation(System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder> pOrders)
        {
            string message = "";
            foreach (var pOrder in pOrders ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder>())
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Caller : " + (pOrder?.Caller ?? ""));
                if ((pOrder?.Item == null || pOrder?.Warehouse == null))
                {
                    message = message + (pOrder?.Id ?? 0) + " ,";
                    continue;
                }
                var _var0 = pOrder?.Item?.SKU;
                DSS2_SynchromodalityCapacityOptimisation.BO.Item existingItem = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Item>((s) => s.SKU == _var0)?.FirstOrDefault();
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Item: " + (pOrder?.Item?.SKU ?? ""));
                var _var1 = pOrder?.Warehouse?.Code;
                DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse existingWarehouse = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse>((w) => w.Code == _var1)?.FirstOrDefault();
                if ((existingItem == null || existingWarehouse == null))
                {
                    message = message + (pOrder?.Id ?? 0) + " ,";
                    continue;
                }
                DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder newPastOrder = new DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder();
                newPastOrder.Warehouse = existingWarehouse;
                newPastOrder.Item = existingItem;
                newPastOrder.OrderNumber = (pOrder?.OrderNumber ?? 0);
                newPastOrder.WrittenDate = (pOrder?.WrittenDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                newPastOrder.NotBeforeDate = (pOrder?.NotBeforeDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                if ((pOrder?.Caller == "Vitacress" || pOrder?.Caller == "Schreiber"))
                {
                    int? supPack = (existingItem?.SupplierPackSize ?? 0);
                    newPastOrder.QuantityOrdered = (int)((supPack.GetValueOrDefault(0) * (pOrder?.QuantityOrdered ?? 0)));
                    newPastOrder.QuantityReceived = (int)((supPack.GetValueOrDefault(0) * (pOrder?.QuantityReceived ?? 0)));
                }
                else
                {
                    newPastOrder.QuantityOrdered = (pOrder?.QuantityOrdered ?? 0);
                    newPastOrder.QuantityReceived = (pOrder?.QuantityReceived ?? 0);
                }
                newPastOrder.ReceiveDate = (pOrder?.ReceiveDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Save<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder>(newPastOrder);
            }
            if (((((message == null || message == "")) == false)))
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "API",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Error message: " + message);
                return DSS2_SynchromodalityCapacityOptimisation.BO.ResponseExtensions.GenerateResponse("Failed", "Failed to import the entries with Ids " + message, "", "-1");
            }
            return DSS2_SynchromodalityCapacityOptimisation.BO.ResponseExtensions.GenerateResponse("Succeed", "All entries imported successfully.", "", "1");
        }


    }
}