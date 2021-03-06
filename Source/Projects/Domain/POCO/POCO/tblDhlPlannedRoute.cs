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
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS2_SynchromodalityCapacityOptimisation.BO
{
    /// <summary>
    /// The tblDhlPlannedRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblDhlPlannedRoute : IDomainModelClass
    {
        #region tblDhlPlannedRoute's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="PlannedRouteID")]
        protected long? plannedRouteID = 0L;
        [DataMember(Name="EntryDate")]
        protected DateTime? entryDate;
        [DataMember(Name="RouteIdentifier")]
        protected string routeIdentifier;
        [DataMember(Name="RouteNumber")]
        protected string routeNumber;
        [DataMember(Name="RouteDescription")]
        protected string routeDescription;
        [DataMember(Name="VehicleIdentifier")]
        protected string vehicleIdentifier;
        [DataMember(Name="DriverIdentifier")]
        protected string driverIdentifier;
        [DataMember(Name="DriverName")]
        protected string driverName;
        [DataMember(Name="RouteDate")]
        protected string routeDate;
        [DataMember(Name="LastUpdated")]
        protected DateTime? lastUpdated;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblDhlPlannedRoute's Properties
/// <summary>
/// The PlannedRouteID property
///
/// </summary>
///
        [Key]
        public virtual long? PlannedRouteID
        {
            get
            {
                return plannedRouteID;
            }
            set
            {
                plannedRouteID = value;
            }
        }
/// <summary>
/// The EntryDate property
///
/// </summary>
///
        public virtual DateTime? EntryDate
        {
            get
            {
                return entryDate;
            }
            set
            {
                entryDate = value;
            }
        }
/// <summary>
/// The RouteIdentifier property
///
/// </summary>
///
        public virtual string RouteIdentifier
        {
            get
            {
                return routeIdentifier;
            }
            set
            {
                routeIdentifier = value;
            }
        }
/// <summary>
/// The RouteNumber property
///
/// </summary>
///
        public virtual string RouteNumber
        {
            get
            {
                return routeNumber;
            }
            set
            {
                routeNumber = value;
            }
        }
/// <summary>
/// The RouteDescription property
///
/// </summary>
///
        public virtual string RouteDescription
        {
            get
            {
                return routeDescription;
            }
            set
            {
                routeDescription = value;
            }
        }
/// <summary>
/// The VehicleIdentifier property
///
/// </summary>
///
        public virtual string VehicleIdentifier
        {
            get
            {
                return vehicleIdentifier;
            }
            set
            {
                vehicleIdentifier = value;
            }
        }
/// <summary>
/// The DriverIdentifier property
///
/// </summary>
///
        public virtual string DriverIdentifier
        {
            get
            {
                return driverIdentifier;
            }
            set
            {
                driverIdentifier = value;
            }
        }
/// <summary>
/// The DriverName property
///
/// </summary>
///
        public virtual string DriverName
        {
            get
            {
                return driverName;
            }
            set
            {
                driverName = value;
            }
        }
/// <summary>
/// The RouteDate property
///
/// </summary>
///
        public virtual string RouteDate
        {
            get
            {
                return routeDate;
            }
            set
            {
                routeDate = value;
            }
        }
/// <summary>
/// The LastUpdated property
///
/// </summary>
///
        public virtual DateTime? LastUpdated
        {
            get
            {
                return lastUpdated;
            }
            set
            {
                lastUpdated = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblDhlPlannedRoute class
/// </summary>
/// <returns>New tblDhlPlannedRoute object</returns>
/// <remarks></remarks>
        public tblDhlPlannedRoute() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (PlannedRouteID == null)
            {
                __errors.Add("Property 'PlannedRouteID' is required.");
            }
            if (RouteIdentifier != null && RouteIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'RouteIdentifier' cannot be greater than 100.");
            }
            if (RouteNumber != null && RouteNumber.Length > 100)
            {
                __errors.Add("Length of property 'RouteNumber' cannot be greater than 100.");
            }
            if (RouteDescription != null && RouteDescription.Length > 100)
            {
                __errors.Add("Length of property 'RouteDescription' cannot be greater than 100.");
            }
            if (VehicleIdentifier != null && VehicleIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'VehicleIdentifier' cannot be greater than 100.");
            }
            if (DriverIdentifier != null && DriverIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'DriverIdentifier' cannot be greater than 100.");
            }
            if (DriverName != null && DriverName.Length > 100)
            {
                __errors.Add("Length of property 'DriverName' cannot be greater than 100.");
            }
            if (RouteDate != null && RouteDate.Length > 100)
            {
                __errors.Add("Length of property 'RouteDate' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblDhlPlannedRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (PlannedRouteID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EntryDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteNumber?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteDescription?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (VehicleIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DriverIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DriverName?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LastUpdated?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblDhlPlannedRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblDhlPlannedRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblDhlPlannedRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblDhlPlannedRoute)copiedObjects[this];
            copy = copy ?? new tblDhlPlannedRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.PlannedRouteID = this.PlannedRouteID;
            }
            copy.EntryDate = this.EntryDate;
            copy.RouteIdentifier = this.RouteIdentifier;
            copy.RouteNumber = this.RouteNumber;
            copy.RouteDescription = this.RouteDescription;
            copy.VehicleIdentifier = this.VehicleIdentifier;
            copy.DriverIdentifier = this.DriverIdentifier;
            copy.DriverName = this.DriverName;
            copy.RouteDate = this.RouteDate;
            copy.LastUpdated = this.LastUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblDhlPlannedRoute;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(tblDhlPlannedRoute x, tblDhlPlannedRoute y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblDhlPlannedRoute x, tblDhlPlannedRoute y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("PlannedRouteID");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.PlannedRouteID.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.PlannedRouteID == default(long) || this.PlannedRouteID.Equals(default(long));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(tblDhlPlannedRoute compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.PlannedRouteID.Equals(compareTo.PlannedRouteID);
        }

        #endregion


    }
}
