
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
	/// The QueryBuilder extensions
	/// </summary>
	public static class QueryBuilderExtensions
	{
        public static string GetClientToken(string username){using (new zAppDev.DotNet.Framework.Profiling.Profiler("QueryBuilder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetClientToken")) {
string q = "+ClientId";
return q;
}
}


public static string GetQuery(string username, string product, string service){using (new zAppDev.DotNet.Framework.Profiling.Profiler("QueryBuilder", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetQuery")) {
string clientKeys = DSS2_SynchromodalityCapacityOptimisation.BO.QueryBuilderExtensions.GetClientToken(username);
string q = "+tags:exposed " + clientKeys;
if (((((product == null || product.Trim() == "")) == false))) {
q = q + " +Product:" + product;}
if (((((service == null || service.Trim() == "")) == false))) {
q = q + " +Service:" + service;}
return q;
}
}



        
	}
}
