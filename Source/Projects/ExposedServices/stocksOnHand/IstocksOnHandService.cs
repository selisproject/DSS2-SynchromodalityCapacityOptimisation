// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSS2_SynchromodalityCapacityOptimisation.Services.stocksOnHand.DataContracts;

namespace DSS2_SynchromodalityCapacityOptimisation.Services
{
    [XmlSerializerFormat]
    [ServiceContract]
    public interface IstocksOnHandService
    {
        [OperationContract]
        DSS2_SynchromodalityCapacityOptimisation.Services.stocksOnHand.DataContracts.ResponseDTO Import(System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.Services.stocksOnHand.DataContracts.StockOnHandDTO> _stocks, string _RequestSourceIp, string _UserName);


    }
}