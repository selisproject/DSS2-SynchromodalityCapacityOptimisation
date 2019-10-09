// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS2_SynchromodalityCapacityOptimisation.Services.exportOFDetails.DataContracts
{
    public class OrderForecastDetailsDTO
    {
        public decimal? Quantity
        {
            get;
            set;
        }
        public DateTime? RecommendedOrderDate
        {
            get;
            set;
        }
        public int? ItemCoverageDays
        {
            get;
            set;
        }
        public int? SupplierAvailableQuantity
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public ItemDTO Item
        {
            get;
            set;
        }
    }

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
    }


}