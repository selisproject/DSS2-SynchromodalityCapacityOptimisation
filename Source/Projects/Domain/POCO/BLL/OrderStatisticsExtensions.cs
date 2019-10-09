
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS2_SynchromodalityCapacityOptimisation.DAL;

namespace DSS2_SynchromodalityCapacityOptimisation.BO
{
	/// <summary>
	/// The OrderStatistics extensions
	/// </summary>
	public static class OrderStatisticsExtensions
	{
        public static void Initialize(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrderStatistics", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Initialize")) {
DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics stats = new DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics();
stats.TotalAsOrdered = (new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>()?.Where((x) => x.ProofOfDelivery != null && x.ProofOfDelivery.QualityStatus == "As Ordered").Count() ?? 0);stats.TotalDeliveries = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetCount<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>();stats.TotalInFull = (new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>()?.Where((y) => y.ProofOfDelivery != null && y.ProofOfDelivery.QuantityStatus == "In Full").Count() ?? 0);stats.TotalOnTime = (new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>()?.Where((z) => z.ProofOfDelivery != null && z.ProofOfDelivery.DeliveryStatus == "On Time").Count() ?? 0);stats.TotalImpeachments = (new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>()?.Where((y) => y.ProofOfDelivery != null && (y.ProofOfDelivery.DeliveryStatus != "On Time" || y.ProofOfDelivery.QuantityStatus != "In Full" || y.ProofOfDelivery.QualityStatus != "As Ordered")).Count() ?? 0);}
}


public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics> GetStats(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrderStatistics", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetStats")) {
return new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAll<DSS2_SynchromodalityCapacityOptimisation.BO.OrderStatistics>();
}
}



        
	}
}