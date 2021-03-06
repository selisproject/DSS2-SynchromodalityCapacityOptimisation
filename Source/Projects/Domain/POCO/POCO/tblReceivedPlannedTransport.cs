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
    /// The tblReceivedPlannedTransport class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblReceivedPlannedTransport : IDomainModelClass
    {
        #region tblReceivedPlannedTransport's Fields

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
        [DataMember(Name="ReceivedPlannedTransportID")]
        protected long? receivedPlannedTransportID = 0L;
        [DataMember(Name="EntryDate")]
        protected DateTime? entryDate;
        [DataMember(Name="transport_identifier")]
        protected string _transport_identifier;
        [DataMember(Name="IsActive")]
        protected bool isActive;
        [DataMember(Name="LastUpdated")]
        protected DateTime? lastUpdated;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblReceivedPlannedTransport's Properties
/// <summary>
/// The ReceivedPlannedTransportID property
///
/// </summary>
///
        [Key]
        public virtual long? ReceivedPlannedTransportID
        {
            get
            {
                return receivedPlannedTransportID;
            }
            set
            {
                receivedPlannedTransportID = value;
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
/// The transport_identifier property
///
/// </summary>
///
        public virtual string transport_identifier
        {
            get
            {
                return _transport_identifier;
            }
            set
            {
                _transport_identifier = value;
            }
        }
/// <summary>
/// The IsActive property
///
/// </summary>
///
        public virtual bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
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
/// Public constructors of the tblReceivedPlannedTransport class
/// </summary>
/// <returns>New tblReceivedPlannedTransport object</returns>
/// <remarks></remarks>
        public tblReceivedPlannedTransport() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (ReceivedPlannedTransportID == null)
            {
                __errors.Add("Property 'ReceivedPlannedTransportID' is required.");
            }
            if (transport_identifier != null && transport_identifier.Length > 100)
            {
                __errors.Add("Length of property 'transport_identifier' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblReceivedPlannedTransport' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (ReceivedPlannedTransportID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EntryDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (transport_identifier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (IsActive.GetHashCode() );
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
/// <param name="copy">Optional - An existing [tblReceivedPlannedTransport] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblReceivedPlannedTransport Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblReceivedPlannedTransport copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblReceivedPlannedTransport)copiedObjects[this];
            copy = copy ?? new tblReceivedPlannedTransport();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.ReceivedPlannedTransportID = this.ReceivedPlannedTransportID;
            }
            copy.EntryDate = this.EntryDate;
            copy.transport_identifier = this.transport_identifier;
            copy.IsActive = this.IsActive;
            copy.LastUpdated = this.LastUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblReceivedPlannedTransport;
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
        public static bool operator ==(tblReceivedPlannedTransport x, tblReceivedPlannedTransport y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblReceivedPlannedTransport x, tblReceivedPlannedTransport y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("ReceivedPlannedTransportID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.ReceivedPlannedTransportID.GetHashCode();
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
            return this.ReceivedPlannedTransportID == default(long) || this.ReceivedPlannedTransportID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblReceivedPlannedTransport compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.ReceivedPlannedTransportID.Equals(compareTo.ReceivedPlannedTransportID);
        }

        #endregion


    }
}
