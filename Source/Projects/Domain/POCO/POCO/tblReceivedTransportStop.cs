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
    /// The tblReceivedTransportStop class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblReceivedTransportStop : IDomainModelClass
    {
        #region tblReceivedTransportStop's Fields

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
        [DataMember(Name="ReceivedTransportStopID")]
        protected long? receivedTransportStopID = 0L;
        [DataMember(Name="EntryDate")]
        protected DateTime? entryDate;
        [DataMember(Name="stop_order")]
        protected int? _stop_order;
        [DataMember(Name="stop_name")]
        protected string _stop_name;
        [DataMember(Name="stop_lat")]
        protected string _stop_lat;
        [DataMember(Name="stop_long")]
        protected string _stop_long;
        [DataMember(Name="planned_departure_time")]
        protected string _planned_departure_time;
        [DataMember(Name="planned_eta")]
        protected string _planned_eta;
        [DataMember(Name="LastUpdated")]
        protected char? lastUpdated;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblReceivedTransportStop's Properties
/// <summary>
/// The ReceivedTransportStopID property
///
/// </summary>
///
        [Key]
        public virtual long? ReceivedTransportStopID
        {
            get
            {
                return receivedTransportStopID;
            }
            set
            {
                receivedTransportStopID = value;
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
/// The stop_order property
///
/// </summary>
///
        public virtual int? stop_order
        {
            get
            {
                return _stop_order;
            }
            set
            {
                _stop_order = value;
            }
        }
/// <summary>
/// The stop_name property
///
/// </summary>
///
        public virtual string stop_name
        {
            get
            {
                return _stop_name;
            }
            set
            {
                _stop_name = value;
            }
        }
/// <summary>
/// The stop_lat property
///
/// </summary>
///
        public virtual string stop_lat
        {
            get
            {
                return _stop_lat;
            }
            set
            {
                _stop_lat = value;
            }
        }
/// <summary>
/// The stop_long property
///
/// </summary>
///
        public virtual string stop_long
        {
            get
            {
                return _stop_long;
            }
            set
            {
                _stop_long = value;
            }
        }
/// <summary>
/// The planned_departure_time property
///
/// </summary>
///
        public virtual string planned_departure_time
        {
            get
            {
                return _planned_departure_time;
            }
            set
            {
                _planned_departure_time = value;
            }
        }
/// <summary>
/// The planned_eta property
///
/// </summary>
///
        public virtual string planned_eta
        {
            get
            {
                return _planned_eta;
            }
            set
            {
                _planned_eta = value;
            }
        }
/// <summary>
/// The LastUpdated property
///
/// </summary>
///
        public virtual char? LastUpdated
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
        #region tblReceivedTransportStop's Participant Properties
        [DataMember(Name="tblReceivedPlannedTransport")]
        protected tblReceivedPlannedTransport _tblReceivedPlannedTransport;
        public virtual tblReceivedPlannedTransport tblReceivedPlannedTransport
        {
            get
            {
                return _tblReceivedPlannedTransport;
            }
            set
            {
                if(Equals(_tblReceivedPlannedTransport, value)) return;
                var __oldValue = _tblReceivedPlannedTransport;
                if (value != null)
                {
                    _tblReceivedPlannedTransport = value;
                }
                else
                {
                    if (_tblReceivedPlannedTransport != null)
                    {
                        _tblReceivedPlannedTransport = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblReceivedTransportStop class
/// </summary>
/// <returns>New tblReceivedTransportStop object</returns>
/// <remarks></remarks>
        public tblReceivedTransportStop() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (ReceivedTransportStopID == null)
            {
                __errors.Add("Property 'ReceivedTransportStopID' is required.");
            }
            if (stop_name != null && stop_name.Length > 100)
            {
                __errors.Add("Length of property 'stop_name' cannot be greater than 100.");
            }
            if (stop_lat != null && stop_lat.Length > 100)
            {
                __errors.Add("Length of property 'stop_lat' cannot be greater than 100.");
            }
            if (stop_long != null && stop_long.Length > 100)
            {
                __errors.Add("Length of property 'stop_long' cannot be greater than 100.");
            }
            if (planned_departure_time != null && planned_departure_time.Length > 100)
            {
                __errors.Add("Length of property 'planned_departure_time' cannot be greater than 100.");
            }
            if (planned_eta != null && planned_eta.Length > 100)
            {
                __errors.Add("Length of property 'planned_eta' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblReceivedTransportStop' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (ReceivedTransportStopID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EntryDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (stop_order?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (stop_name?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (stop_lat?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (stop_long?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (planned_departure_time?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (planned_eta?.GetHashCode() ?? 0);
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
/// <param name="copy">Optional - An existing [tblReceivedTransportStop] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblReceivedTransportStop Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblReceivedTransportStop copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblReceivedTransportStop)copiedObjects[this];
            copy = copy ?? new tblReceivedTransportStop();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.ReceivedTransportStopID = this.ReceivedTransportStopID;
            }
            copy.EntryDate = this.EntryDate;
            copy.stop_order = this.stop_order;
            copy.stop_name = this.stop_name;
            copy.stop_lat = this.stop_lat;
            copy.stop_long = this.stop_long;
            copy.planned_departure_time = this.planned_departure_time;
            copy.planned_eta = this.planned_eta;
            copy.LastUpdated = this.LastUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._tblReceivedPlannedTransport != null)
            {
                if (!copiedObjects.Contains(this._tblReceivedPlannedTransport))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblReceivedPlannedTransport = this.tblReceivedPlannedTransport;
                    else if (asNew)
                        copy.tblReceivedPlannedTransport = this.tblReceivedPlannedTransport.Copy(deep, copiedObjects, true);
                    else
                        copy._tblReceivedPlannedTransport = this._tblReceivedPlannedTransport.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblReceivedPlannedTransport = (tblReceivedPlannedTransport)copiedObjects[this.tblReceivedPlannedTransport];
                    else
                        copy._tblReceivedPlannedTransport = (tblReceivedPlannedTransport)copiedObjects[this.tblReceivedPlannedTransport];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblReceivedTransportStop;
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
        public static bool operator ==(tblReceivedTransportStop x, tblReceivedTransportStop y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblReceivedTransportStop x, tblReceivedTransportStop y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("ReceivedTransportStopID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.ReceivedTransportStopID.GetHashCode();
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
            return this.ReceivedTransportStopID == default(long) || this.ReceivedTransportStopID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblReceivedTransportStop compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.ReceivedTransportStopID.Equals(compareTo.ReceivedTransportStopID);
        }

        #endregion


    }
}
