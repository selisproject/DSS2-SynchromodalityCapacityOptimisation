// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS2_SynchromodalityCapacityOptimisation.Services.capacities.DataContracts
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
        public decimal? AvgDailyDemand
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

    public class SupplierDTO
    {
        public string Code
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }

    public class SupplierCapacityDTO
    {
        public DateTime? DateOfStockUpdate
        {
            get;
            set;
        }
        public int? DailyProduction
        {
            get;
            set;
        }
        public int? Stock
        {
            get;
            set;
        }
        public ItemDTO Item
        {
            get;
            set;
        }
        public SupplierDTO Supplier
        {
            get;
            set;
        }
    }


}