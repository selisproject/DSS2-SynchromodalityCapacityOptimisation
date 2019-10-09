
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
	/// The SLALeadTime extensions
	/// </summary>
	public static class SLALeadTimeExtensions
	{
        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics> ItemLeadTimePercentageWithCriteria(System.Collections.Generic.List<int?> supplierIds, System.Collections.Generic.List<int?> warehouseIds, System.Collections.Generic.List<int?> businessUnitIds, System.Collections.Generic.List<int?> categoryIds, System.Collections.Generic.List<int?> subCategoryIds, System.Collections.Generic.List<int?> baseUnitIds, System.Collections.Generic.List<string> SKUs, DateTime? fromDate, DateTime? toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("SLALeadTime", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "ItemLeadTimePercentageWithCriteria")) {
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics> stats = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics>();
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
var _var0 = (fromDate?.Month ?? 0);var _var1 = (toDate?.Month ?? 0);System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime> filteredLeadTimes = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime>((a) => (SKUs.Count() == 0 || SKUs.Contains(a.Item.SKU)) && (businessUnitIds.Count() == 0 || businessUnitIds.Contains((a.Item.BusinessUnit.Id).GetValueOrDefault(0))) && (categoryIds.Count() == 0 || categoryIds.Contains((a.Item.Category.Id).GetValueOrDefault(0))) && (subCategoryIds.Count() == 0 || subCategoryIds.Contains((a.Item.SubCategory.Id).GetValueOrDefault(0))) && (baseUnitIds.Count() == 0 || baseUnitIds.Contains((a.Item.BaseUnit.Id).GetValueOrDefault(0))) && (supplierIds.Count() == 0 || supplierIds.Contains((a.Item.Supplier.Id).GetValueOrDefault(0))) && (warehouseIds.Count() == 0 || warehouseIds.Contains((a.Warehouse.Id).GetValueOrDefault(0))) && (fromDate == null || a.Month >= _var0) && (toDate == null || a.Month <= _var1));
System.Collections.Generic.List<int?> uniqueMonths = filteredLeadTimes?.Select((a) => a.Month).ToList().Distinct().ToList().OrderBy((a) => a).ToList();
foreach (var i in uniqueMonths ?? Enumerable.Empty<int?>()) {
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime> thisMonthsLTs = filteredLeadTimes?.Where((a) => a.Month == i).ToList();
if ((thisMonthsLTs?.Count() == 0)) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "SLALeadTime",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Continue...");
continue;}
decimal? test = (thisMonthsLTs?.Sum((a) => a.MonthlyPercentage) ?? 0);
DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics stat = new DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics();
stat.Percentage = (thisMonthsLTs?.Sum((a) => a.MonthlyPercentage) ?? 0) / (thisMonthsLTs?.Count() ?? 0);stat.Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((i).GetValueOrDefault(0));stat.Threshold = 80;stats?.Add(stat);
}
return stats;
}
}


public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics> ItemLeadTimePercentage(string sku){using (new zAppDev.DotNet.Framework.Profiling.Profiler("SLALeadTime", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "ItemLeadTimePercentage")) {
DSS2_SynchromodalityCapacityOptimisation.BO.Item item = new DSS2_SynchromodalityCapacityOptimisation.BO.Item();
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics> stats = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics>();
if ((sku == null || sku == "")) {
return stats;
}
else {
try {
item =  new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetById<DSS2_SynchromodalityCapacityOptimisation.BO.Item>(sku);}
catch (System.Exception x) {
}
}
foreach (var leadTime in item?.SLALeadTimes ?? Enumerable.Empty<DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime>()) {
DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics stat = new DSS2_SynchromodalityCapacityOptimisation.BO.SLAStatistics();
stat.Item = item;stat.Percentage = (leadTime?.MonthlyPercentage ?? 0);stat.Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((leadTime?.Month ?? 0));stat.Threshold = 80;stats?.Add(stat);
}
return stats;
}
}



        
	}
}