
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
	/// The StockOnHand extensions
	/// </summary>
	public static class StockOnHandExtensions
	{
        public static void DailyStock(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("StockOnHand", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "DailyStock")) {
}
}


public static void CalculateCurrentInventoryDays(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("StockOnHand", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculateCurrentInventoryDays")) {
foreach (var stock in new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAll<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>() ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>()) {
var _var0 = stock?.Item?.SKU;var _var1 = stock?.Warehouse?.Id;DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails salesfor = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails>((a) => a.Item.SKU == _var0 && a.Warehouse.Id == _var1)?.FirstOrDefault();
if ((salesfor == null || salesfor?.AvgDailyDemandForecast == 0)) {
stock.CurrentInventoryDays = 0;new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Save<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>(stock);
continue;}
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "StockOnHand",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "salesfor.AvgDailyDemandForecast : " + (salesfor?.AvgDailyDemandForecast ?? 0) + " ::: " + (stock?.Units ?? 0));
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "StockOnHand",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "(stock.Units / salesfor.AvgDailyDemandForecast) : " + ((stock?.Units ?? 0) / (salesfor?.AvgDailyDemandForecast ?? 0)));
stock.CurrentInventoryDays = zAppDev.DotNet.Framework.Utilities.Common.SafeCast<decimal?>(((stock?.Units ?? 0) / (salesfor?.AvgDailyDemandForecast ?? 0)));new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Save<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>(stock);
}
}
}



        
	}
}
