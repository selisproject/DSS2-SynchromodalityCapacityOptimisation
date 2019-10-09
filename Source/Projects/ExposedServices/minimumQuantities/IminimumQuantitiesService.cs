// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSS2_SynchromodalityCapacityOptimisation.Services.minimumQuantities.DataContracts;

namespace DSS2_SynchromodalityCapacityOptimisation.Services
{
    [XmlSerializerFormat]
    [ServiceContract]
    public interface IminimumQuantitiesService
    {
        [OperationContract]
        DSS2_SynchromodalityCapacityOptimisation.Services.minimumQuantities.DataContracts.ResponseDTO Import(System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.Services.minimumQuantities.DataContracts.MinimumQuantityDTO> _minQuantities, string _RequestSourceIp, string _UserName);


    }
}