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
    /// The TransportUnCap class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class TransportUnCap : IDomainModelClass
    {
        #region TransportUnCap's Fields

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
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="UOP")]
        protected string uOP;
        [DataMember(Name="PercRound")]
        protected decimal? percRound;
        [DataMember(Name="Tuc1")]
        protected decimal? tuc1;
        [DataMember(Name="SplitOcInd")]
        protected string splitOcInd;
        [DataMember(Name="Status")]
        protected string status;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region TransportUnCap's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The UOP property
///
/// </summary>
///
        public virtual string UOP
        {
            get
            {
                return uOP;
            }
            set
            {
                uOP = value;
            }
        }
/// <summary>
/// The PercRound property
///
/// </summary>
///
        public virtual decimal? PercRound
        {
            get
            {
                return percRound;
            }
            set
            {
                percRound = value;
            }
        }
/// <summary>
/// The Tuc1 property
///
/// </summary>
///
        public virtual decimal? Tuc1
        {
            get
            {
                return tuc1;
            }
            set
            {
                tuc1 = value;
            }
        }
/// <summary>
/// The SplitOcInd property
///
/// </summary>
///
        public virtual string SplitOcInd
        {
            get
            {
                return splitOcInd;
            }
            set
            {
                splitOcInd = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
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
        #region TransportUnCap's Participant Properties
        [DataMember(Name="Warehouse")]
        protected Warehouse warehouse;
        public virtual Warehouse Warehouse
        {
            get
            {
                return warehouse;
            }
            set
            {
                if(Equals(warehouse, value)) return;
                var __oldValue = warehouse;
                warehouse = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the TransportUnCap class
/// </summary>
/// <returns>New TransportUnCap object</returns>
/// <remarks></remarks>
        public TransportUnCap() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (UOP != null && UOP.Length > 100)
            {
                __errors.Add("Length of property 'UOP' cannot be greater than 100.");
            }
            if (SplitOcInd != null && SplitOcInd.Length > 100)
            {
                __errors.Add("Length of property 'SplitOcInd' cannot be greater than 100.");
            }
            if (Status != null && Status.Length > 100)
            {
                __errors.Add("Length of property 'Status' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'TransportUnCap' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (UOP?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PercRound?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Tuc1?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (SplitOcInd?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Status?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [TransportUnCap] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual TransportUnCap Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, TransportUnCap copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (TransportUnCap)copiedObjects[this];
            copy = copy ?? new TransportUnCap();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.UOP = this.UOP;
            copy.PercRound = this.PercRound;
            copy.Tuc1 = this.Tuc1;
            copy.SplitOcInd = this.SplitOcInd;
            copy.Status = this.Status;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.warehouse != null)
            {
                if (!copiedObjects.Contains(this.warehouse))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Warehouse = this.Warehouse;
                    else if (asNew)
                        copy.Warehouse = this.Warehouse.Copy(deep, copiedObjects, true);
                    else
                        copy.warehouse = this.warehouse.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Warehouse = (Warehouse)copiedObjects[this.Warehouse];
                    else
                        copy.warehouse = (Warehouse)copiedObjects[this.Warehouse];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as TransportUnCap;
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
        public static bool operator ==(TransportUnCap x, TransportUnCap y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(TransportUnCap x, TransportUnCap y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
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
            return this.Id == default(int) || this.Id.Equals(default(int));
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
        protected bool HasSameNonDefaultIdAs(TransportUnCap compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}