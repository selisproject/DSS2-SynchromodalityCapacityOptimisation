
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
	/// The OrdersPerMonth extensions
	/// </summary>
	public static class OrdersPerMonthExtensions
	{
        public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth> GroupOrders(int? year){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrdersPerMonth", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GroupOrders")) {
DateTime? d = new DateTime((year).GetValueOrDefault(0), 01, 01, 0, 0, 0, DateTimeKind.Utc);
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth> ordersPerMonth = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth>();
for (var i = 1; i < 13; i = i + 1) {
DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth orderPerMonth = new DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth();
orderPerMonth.Label = i.ToString();DateTime? currentMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse(i.ToString()), 01, 0, 0, 0, DateTimeKind.Utc);
int? j = new int?();
DateTime? nextMonth = new DateTime?();
if ((i == 12)) {
year = year.GetValueOrDefault(0) + 1;j = 01;nextMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse((j?.ToString() ?? "")), 01, 0, 0, 0, DateTimeKind.Utc);}
else {
j = i + 1;nextMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse((j?.ToString() ?? "")), 01, 0, 0, 0, DateTimeKind.Utc);}
orderPerMonth.Value = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetCount<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>((ord) => ord.OrdRegDateTime >= currentMonth && ord.OrdRegDateTime < nextMonth);ordersPerMonth?.Add(orderPerMonth);
}
return ordersPerMonth;
}
}


public static System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth> GroupRAOrders(int? year, string agentCode){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrdersPerMonth", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GroupRAOrders")) {
DateTime? d = new DateTime((year).GetValueOrDefault(0), 01, 01, 0, 0, 0, DateTimeKind.Utc);
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS> ordersFiltered = new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().Get<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS>((or) => or.OrdAgencyCode == agentCode);
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth> ordersPerMonth = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth>();
for (var i = 1; i < 13; i = i + 1) {
DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth orderPerMonth = new DSS2_SynchromodalityCapacityOptimisation.BO.OrdersPerMonth();
orderPerMonth.Label = i.ToString();DateTime? currentMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse(i.ToString()), 01, 0, 0, 0, DateTimeKind.Utc);
int? j = new int?();
DateTime? nextMonth = new DateTime?();
if ((i == 12)) {
year = year.GetValueOrDefault(0) + 1;j = 01;nextMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse((j?.ToString() ?? "")), 01, 0, 0, 0, DateTimeKind.Utc);}
else {
j = i + 1;nextMonth = new DateTime(int.Parse((year?.ToString() ?? "")), int.Parse((j?.ToString() ?? "")), 01, 0, 0, 0, DateTimeKind.Utc);}
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "OrdersPerMonth",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Current month " + currentMonth.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value) + " next month " + nextMonth.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value));
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderWMS> ordersCounted = ordersFiltered?.Where((ord) => ord.OrdRegDateTime >= currentMonth && ord.OrdRegDateTime < nextMonth).ToList();
orderPerMonth.Value = (ordersCounted?.Count() ?? 0);ordersPerMonth?.Add(orderPerMonth);
}
return ordersPerMonth;
}
}



        
	}
}
