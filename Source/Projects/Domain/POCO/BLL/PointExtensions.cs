
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
	/// The Point extensions
	/// </summary>
	public static class PointExtensions
	{
        public static DSS2_SynchromodalityCapacityOptimisation.BO.Location GetLocation(this BO.Point @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Point", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetLocation")) {
return  new DSS2_SynchromodalityCapacityOptimisation.DAL.Repository().GetById<DSS2_SynchromodalityCapacityOptimisation.BO.Location>((@this?.LocId ?? 0));
}
}



        
	}
}
