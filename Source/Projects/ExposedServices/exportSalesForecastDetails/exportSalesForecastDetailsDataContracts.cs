// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS2_SynchromodalityCapacityOptimisation.Services.exportSalesForecastDetails.DataContracts
{
    public class SalesDTO
    {
        public DateTime? ForecastDate
        {
            get;
            set;
        }
        public int? Units
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