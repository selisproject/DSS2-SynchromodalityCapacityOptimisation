// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS2_SynchromodalityCapacityOptimisation.Services.stocksOnHand.DataContracts
{
    public class ItemDTO
    {
        public string SKU
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string UPC
        {
            get;
            set;
        }
    }

    public class ResponseDTO
    {
        public string Status
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string Details
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
    }

    public class StockOnHandDTO
    {
        public int? Units
        {
            get;
            set;
        }
        public WarehouseDTO Warehouse
        {
            get;
            set;
        }
        public ItemDTO Item
        {
            get;
            set;
        }
        public DateTime? StockOnHandDate
        {
            get;
            set;
        }
    }

    public class WarehouseDTO
    {
        public int? Id
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }


}