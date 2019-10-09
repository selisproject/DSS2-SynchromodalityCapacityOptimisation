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
    /// The tblDhlRouteStopOperation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblDhlRouteStopOperation : IDomainModelClass
    {
        #region tblDhlRouteStopOperation's Fields

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
        [DataMember(Name="RouteStopOperationID")]
        protected long? routeStopOperationID = 0L;
        [DataMember(Name="EntryDate")]
        protected DateTime? entryDate;
        [DataMember(Name="PlannedRouteIdentifier")]
        protected string plannedRouteIdentifier;
        [DataMember(Name="RouteStopIdentifier")]
        protected string routeStopIdentifier;
        [DataMember(Name="OperationDescription")]
        protected string operationDescription;
        [DataMember(Name="OperationIdentifier")]
        protected string operationIdentifier;
        [DataMember(Name="OperationCode")]
        protected string operationCode;
        [DataMember(Name="ClientIdentifier")]
        protected string clientIdentifier;
        [DataMember(Name="ClientDescription")]
        protected string clientDescription;
        [DataMember(Name="Weight")]
        protected string weight;
        [DataMember(Name="Volume")]
        protected string volume;
        [DataMember(Name="Packages")]
        protected string packages;
        [DataMember(Name="LinealMeasure")]
        protected string linealMeasure;
        [DataMember(Name="Pallets")]
        protected int? pallets;
        [DataMember(Name="LastUpdated")]
        protected DateTime? lastUpdated;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblDhlRouteStopOperation's Properties
/// <summary>
/// The RouteStopOperationID property
///
/// </summary>
///
        [Key]
        public virtual long? RouteStopOperationID
        {
            get
            {
                return routeStopOperationID;
            }
            set
            {
                routeStopOperationID = value;
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
/// The PlannedRouteIdentifier property
///
/// </summary>
///
        public virtual string PlannedRouteIdentifier
        {
            get
            {
                return plannedRouteIdentifier;
            }
            set
            {
                plannedRouteIdentifier = value;
            }
        }
/// <summary>
/// The RouteStopIdentifier property
///
/// </summary>
///
        public virtual string RouteStopIdentifier
        {
            get
            {
                return routeStopIdentifier;
            }
            set
            {
                routeStopIdentifier = value;
            }
        }
/// <summary>
/// The OperationDescription property
///
/// </summary>
///
        public virtual string OperationDescription
        {
            get
            {
                return operationDescription;
            }
            set
            {
                operationDescription = value;
            }
        }
/// <summary>
/// The OperationIdentifier property
///
/// </summary>
///
        public virtual string OperationIdentifier
        {
            get
            {
                return operationIdentifier;
            }
            set
            {
                operationIdentifier = value;
            }
        }
/// <summary>
/// The OperationCode property
///
/// </summary>
///
        public virtual string OperationCode
        {
            get
            {
                return operationCode;
            }
            set
            {
                operationCode = value;
            }
        }
/// <summary>
/// The ClientIdentifier property
///
/// </summary>
///
        public virtual string ClientIdentifier
        {
            get
            {
                return clientIdentifier;
            }
            set
            {
                clientIdentifier = value;
            }
        }
/// <summary>
/// The ClientDescription property
///
/// </summary>
///
        public virtual string ClientDescription
        {
            get
            {
                return clientDescription;
            }
            set
            {
                clientDescription = value;
            }
        }
/// <summary>
/// The Weight property
///
/// </summary>
///
        public virtual string Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
/// <summary>
/// The Volume property
///
/// </summary>
///
        public virtual string Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
/// <summary>
/// The Packages property
///
/// </summary>
///
        public virtual string Packages
        {
            get
            {
                return packages;
            }
            set
            {
                packages = value;
            }
        }
/// <summary>
/// The LinealMeasure property
///
/// </summary>
///
        public virtual string LinealMeasure
        {
            get
            {
                return linealMeasure;
            }
            set
            {
                linealMeasure = value;
            }
        }
/// <summary>
/// The Pallets property
///
/// </summary>
///
        public virtual int? Pallets
        {
            get
            {
                return pallets;
            }
            set
            {
                pallets = value;
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
/// Public constructors of the tblDhlRouteStopOperation class
/// </summary>
/// <returns>New tblDhlRouteStopOperation object</returns>
/// <remarks></remarks>
        public tblDhlRouteStopOperation() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (RouteStopOperationID == null)
            {
                __errors.Add("Property 'RouteStopOperationID' is required.");
            }
            if (PlannedRouteIdentifier != null && PlannedRouteIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'PlannedRouteIdentifier' cannot be greater than 100.");
            }
            if (RouteStopIdentifier != null && RouteStopIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'RouteStopIdentifier' cannot be greater than 100.");
            }
            if (OperationDescription != null && OperationDescription.Length > 100)
            {
                __errors.Add("Length of property 'OperationDescription' cannot be greater than 100.");
            }
            if (OperationIdentifier != null && OperationIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'OperationIdentifier' cannot be greater than 100.");
            }
            if (OperationCode != null && OperationCode.Length > 100)
            {
                __errors.Add("Length of property 'OperationCode' cannot be greater than 100.");
            }
            if (ClientIdentifier != null && ClientIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'ClientIdentifier' cannot be greater than 100.");
            }
            if (ClientDescription != null && ClientDescription.Length > 100)
            {
                __errors.Add("Length of property 'ClientDescription' cannot be greater than 100.");
            }
            if (Weight != null && Weight.Length > 100)
            {
                __errors.Add("Length of property 'Weight' cannot be greater than 100.");
            }
            if (Volume != null && Volume.Length > 100)
            {
                __errors.Add("Length of property 'Volume' cannot be greater than 100.");
            }
            if (Packages != null && Packages.Length > 100)
            {
                __errors.Add("Length of property 'Packages' cannot be greater than 100.");
            }
            if (LinealMeasure != null && LinealMeasure.Length > 100)
            {
                __errors.Add("Length of property 'LinealMeasure' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblDhlRouteStopOperation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (RouteStopOperationID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EntryDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PlannedRouteIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteStopIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OperationDescription?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OperationIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OperationCode?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ClientIdentifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ClientDescription?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Weight?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Volume?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Packages?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LinealMeasure?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Pallets?.GetHashCode() ?? 0);
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
/// <param name="copy">Optional - An existing [tblDhlRouteStopOperation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblDhlRouteStopOperation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblDhlRouteStopOperation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblDhlRouteStopOperation)copiedObjects[this];
            copy = copy ?? new tblDhlRouteStopOperation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.RouteStopOperationID = this.RouteStopOperationID;
            }
            copy.EntryDate = this.EntryDate;
            copy.PlannedRouteIdentifier = this.PlannedRouteIdentifier;
            copy.RouteStopIdentifier = this.RouteStopIdentifier;
            copy.OperationDescription = this.OperationDescription;
            copy.OperationIdentifier = this.OperationIdentifier;
            copy.OperationCode = this.OperationCode;
            copy.ClientIdentifier = this.ClientIdentifier;
            copy.ClientDescription = this.ClientDescription;
            copy.Weight = this.Weight;
            copy.Volume = this.Volume;
            copy.Packages = this.Packages;
            copy.LinealMeasure = this.LinealMeasure;
            copy.Pallets = this.Pallets;
            copy.LastUpdated = this.LastUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblDhlRouteStopOperation;
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
        public static bool operator ==(tblDhlRouteStopOperation x, tblDhlRouteStopOperation y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblDhlRouteStopOperation x, tblDhlRouteStopOperation y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("RouteStopOperationID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.RouteStopOperationID.GetHashCode();
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
            return this.RouteStopOperationID == default(long) || this.RouteStopOperationID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblDhlRouteStopOperation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.RouteStopOperationID.Equals(compareTo.RouteStopOperationID);
        }

        #endregion


    }
}
