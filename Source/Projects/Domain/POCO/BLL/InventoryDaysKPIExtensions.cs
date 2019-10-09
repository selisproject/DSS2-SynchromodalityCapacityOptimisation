
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
	/// The InventoryDaysKPI extensions
	/// </summary>
	public static class InventoryDaysKPIExtensions
	{
        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI> InventoryDaysKPIWithCriteria(System.Collections.Generic.List<int?> supplierIds, System.Collections.Generic.List<int?> warehouseIds, System.Collections.Generic.List<int?> businessUnitIds, System.Collections.Generic.List<int?> categoryIds, System.Collections.Generic.List<int?> subCategoryIds, System.Collections.Generic.List<int?> baseUnitIds, System.Collections.Generic.List<string> SKUs, DateTime? fromDate, DateTime? toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("InventoryDaysKPI", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "InventoryDaysKPIWithCriteria")) {
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI> kpis = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI>();
System.Collections.Generic.List<int?> emptyIDs = new System.Collections.Generic.List<int?>();
System.Collections.Generic.List<string> emptySKUs = new System.Collections.Generic.List<string>();
if ((warehouseIds == null)) {
warehouseIds = emptyIDs.ToList();}
if ((SKUs == null)) {
SKUs = emptySKUs.ToList();}
if ((businessUnitIds == null)) {
businessUnitIds = emptyIDs.ToList();}
if ((categoryIds == null)) {
categoryIds = emptyIDs.ToList();}
if ((subCategoryIds == null)) {
subCategoryIds = emptyIDs.ToList();}
if ((baseUnitIds == null)) {
baseUnitIds = emptyIDs.ToList();}
if ((supplierIds == null)) {
supplierIds = emptyIDs.ToList();}
var _var0 = (fromDate?.Date ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);var _var1 = (toDate?.Date ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand> filteredStockOnHand = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>((a) => (SKUs.Count() == 0 || SKUs.Contains(a.Item.SKU)) && (businessUnitIds.Count() == 0 || businessUnitIds.Contains((a.Item.BusinessUnit.Id).GetValueOrDefault(0))) && (categoryIds.Count() == 0 || categoryIds.Contains((a.Item.Category.Id).GetValueOrDefault(0))) && (subCategoryIds.Count() == 0 || subCategoryIds.Contains((a.Item.SubCategory.Id).GetValueOrDefault(0))) && (baseUnitIds.Count() == 0 || baseUnitIds.Contains((a.Item.BaseUnit.Id).GetValueOrDefault(0))) && (supplierIds.Count() == 0 || supplierIds.Contains((a.Item.Supplier.Id).GetValueOrDefault(0))) && (warehouseIds.Count() == 0 || warehouseIds.Contains((a.Warehouse.Id).GetValueOrDefault(0))) && (fromDate == null || a.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date >= _var0) && (toDate == null || a.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date <= _var1));
var _var2 = (fromDate?.Date ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);var _var3 = (toDate?.Date.AddDays(30) ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails> filteredSales = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails>((a) => (SKUs.Count() == 0 || SKUs.Contains(a.Item.SKU)) && (businessUnitIds.Count() == 0 || businessUnitIds.Contains((a.Item.BusinessUnit.Id).GetValueOrDefault(0))) && (categoryIds.Count() == 0 || categoryIds.Contains((a.Item.Category.Id).GetValueOrDefault(0))) && (subCategoryIds.Count() == 0 || subCategoryIds.Contains((a.Item.SubCategory.Id).GetValueOrDefault(0))) && (baseUnitIds.Count() == 0 || baseUnitIds.Contains((a.Item.BaseUnit.Id).GetValueOrDefault(0))) && (supplierIds.Count() == 0 || supplierIds.Contains((a.Item.Supplier.Id).GetValueOrDefault(0))) && (warehouseIds.Count() == 0 || warehouseIds.Contains((a.Warehouse.Id).GetValueOrDefault(0))) && (fromDate == null || a.ForecastDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date >= _var2) && (toDate == null || a.ForecastDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date <= _var3));
System.Collections.Generic.List<DateTime?> uniqueDates = filteredStockOnHand?.Select((a) => a.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date).Select(_n => _n as DateTime?).ToList().Distinct().ToList().OrderBy((a) => a).ToList();
System.Collections.Generic.List<string> uniqueItemSKUs = filteredStockOnHand?.Select((a) => a.Item.SKU).ToList().Distinct().ToList();
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "InventoryDaysKPI",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "uniqueItemSKUs: " + uniqueItemSKUs.Count());
foreach (var dt in uniqueDates ?? Enumerable.Empty<DateTime?>()) {
DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI kpi = new DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI();
kpi.SalesForecastDate = dt;kpi.SalesForecastDateFormatted = (dt?.ToString("dd/MM") ?? "");int? totalStockForDay = (filteredStockOnHand?.Where((a) => a.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date == dt).Sum((a) => a.Units) ?? 0);
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails> salesAfterToday = filteredSales?.Where((a) => a.ForecastDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date >= dt).ToList();
int? runningTotalSales = 0;
int? inventoryDays = 0;
foreach (var sale in salesAfterToday ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails>()) {
runningTotalSales = runningTotalSales.GetValueOrDefault(0) + (sale?.Units ?? 0);if ((runningTotalSales > totalStockForDay)) {
break;}
inventoryDays = inventoryDays.GetValueOrDefault(0) + 1;}
kpi.InventoryDays = inventoryDays;if ((uniqueItemSKUs.Count() > 1)) {
int? calcInvDays = (int)((inventoryDays.GetValueOrDefault(0) / uniqueItemSKUs.Count()));
if ((calcInvDays == 0)) {
calcInvDays = 1;}
kpi.InventoryDays = calcInvDays;}
kpis?.Add(kpi);
}
return kpis;
}
}


public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI> InventoryDaysKPI(string sku, int? warehouseId, DateTime? fromDate, DateTime? toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("InventoryDaysKPI", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "InventoryDaysKPI")) {
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI> kpis = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI>();
DSS2_SynchromodalityCapacityOptimisation.BO.Item item = new DSS2_SynchromodalityCapacityOptimisation.BO.Item();
try {
item =  new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetById<DSS2_SynchromodalityCapacityOptimisation.BO.Item>(sku);}
catch (System.Exception x) {
}
if ((item == null)) {
return kpis;
}
DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse warehouse = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse>((a) => a.Id == warehouseId)?.FirstOrDefault();
DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails sale = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.SalesForecastDetails>((s) => s.Item.SKU == item.SKU && s.Warehouse.Id == warehouse.Id)?.FirstOrDefault();
decimal? inventoryDays = 0;
var _var4 = (fromDate?.Date ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);var _var5 = (toDate?.Date ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);foreach (var stock in item?.StocksOnHand?.Where((s) => s.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date >= _var4 && s.StockOnHandDate.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Date <= _var5 && s.Warehouse == warehouse).ToList() ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>()) {
DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI kpi = new DSS2_SynchromodalityCapacityOptimisation.BO.InventoryDaysKPI();
kpi.SalesForecastDate = (stock?.StockOnHandDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);kpi.SalesForecastDateFormatted = (stock?.StockOnHandDate?.ToString("yyyy/MM/dd") ?? "");if (sale == null) {
kpi.InventoryDays = 0;}
else {
kpi.InventoryDays = (stock?.Units ?? 0) / (sale?.AvgDailyDemandForecast ?? 0);}
kpi.ItemDescription = (item?.Description?.Substring(0, 15) ?? "");kpis?.Add(kpi);
}
kpis = kpis?.OrderBy((a) => a.SalesForecastDate).ToList().ToList();zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "InventoryDaysKPI",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "stats length: " + (kpis?.Count() ?? 0));
return kpis;
}
}



        
	}
}
