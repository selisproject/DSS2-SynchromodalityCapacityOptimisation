// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS2_SynchromodalityCapacityOptimisation.Services.items.DataContracts
{
    public class BaseUnitDTO
    {
        public int? Number
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

    public class BusinessUnitDTO
    {
        public int? Number
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

    public class CategoryDTO
    {
        public int? Number
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
        public SupplierDTO Supplier
        {
            get;
            set;
        }
        public BusinessUnitDTO BusinessUnit
        {
            get;
            set;
        }
        public CategoryDTO Category
        {
            get;
            set;
        }
        public SubCategoryDTO SubCategory
        {
            get;
            set;
        }
        public BaseUnitDTO BaseUnit
        {
            get;
            set;
        }
        public int? PalletSize
        {
            get;
            set;
        }
        public int? SupplierPackSize
        {
            get;
            set;
        }
        public int? InnerPackSize
        {
            get;
            set;
        }
        public string PalletType
        {
            get;
            set;
        }
        public int? PalTI
        {
            get;
            set;
        }
        public int? PalHI
        {
            get;
            set;
        }
        public string UOM
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

    public class SubCategoryDTO
    {
        public int? Number
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


}