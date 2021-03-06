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
    /// The ScheduledRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ScheduledRoute : IDomainModelClass
    {
        #region ScheduledRoute's Fields

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
        [DataMember(Name="Origin")]
        protected string origin;
        [DataMember(Name="Destination")]
        protected string destination;
        [DataMember(Name="DaysOfWeek")]
        protected string daysOfWeek;
        [DataMember(Name="PricePerPallet")]
        protected decimal? pricePerPallet;
        [DataMember(Name="PricePerKilogram")]
        protected decimal? pricePerKilogram;
        [DataMember(Name="PricePerCubicMeter")]
        protected decimal? pricePerCubicMeter;
        [DataMember(Name="TotalAvailableCapacityKG")]
        protected decimal? totalAvailableCapacityKG;
        [DataMember(Name="EffectiveFrom")]
        protected DateTime? effectiveFrom;
        [DataMember(Name="EffectiveTo")]
        protected DateTime? effectiveTo;
        [DataMember(Name="TypeOfGoods")]
        protected DSS2_SynchromodalityCapacityOptimisation.BO.TruckContent? typeOfGoods;
        [DataMember(Name="Revision")]
        protected int? revision;
        [DataMember(Name="GUID")]
        protected string gUID;
        [DataMember(Name="ReservedCapacityLaden")]
        protected int? reservedCapacityLaden;
        [DataMember(Name="State")]
        protected DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState? state;
        [DataMember(Name="BaseId")]
        protected int? baseId;
        [DataMember(Name="Frequency")]
        protected DSS2_SynchromodalityCapacityOptimisation.BO.RouteFrequency? frequency;
        [DataMember(Name="TotalAvailableCapacityM3")]
        protected decimal? totalAvailableCapacityM3;
        [DataMember(Name="TotalAvailableCapacityLaden")]
        protected int? totalAvailableCapacityLaden;
        [DataMember(Name="ReservedCapacityKG")]
        protected decimal? reservedCapacityKG;
        [DataMember(Name="ReservedCapacityM3")]
        protected decimal? reservedCapacityM3;
        [DataMember(Name="FixedPrice")]
        protected decimal? fixedPrice;
        [DataMember(Name="OriginComments")]
        protected string originComments;
        [DataMember(Name="DestinationComments")]
        protected string destinationComments;
        [DataMember(Name="TruckPlate")]
        protected string truckPlate;
        [DataMember(Name="stringenum")]
        protected string _stringenum;
        [DataMember(Name="DeliveryDate")]
        protected DateTime? deliveryDate;
        [DataMember(Name="Attribute")]
        protected DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState? attribute;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region ScheduledRoute's Properties
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
/// The Origin property
///
/// </summary>
///
        public virtual string Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }
/// <summary>
/// The Destination property
///
/// </summary>
///
        public virtual string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
/// <summary>
/// The DaysOfWeek property
///
/// </summary>
///
        public virtual string DaysOfWeek
        {
            get
            {
                return daysOfWeek;
            }
            set
            {
                daysOfWeek = value;
            }
        }
/// <summary>
/// The PricePerPallet property
///
/// </summary>
///
        public virtual decimal? PricePerPallet
        {
            get
            {
                return pricePerPallet;
            }
            set
            {
                pricePerPallet = value;
            }
        }
/// <summary>
/// The PricePerKilogram property
///
/// </summary>
///
        public virtual decimal? PricePerKilogram
        {
            get
            {
                return pricePerKilogram;
            }
            set
            {
                pricePerKilogram = value;
            }
        }
/// <summary>
/// The PricePerCubicMeter property
///
/// </summary>
///
        public virtual decimal? PricePerCubicMeter
        {
            get
            {
                return pricePerCubicMeter;
            }
            set
            {
                pricePerCubicMeter = value;
            }
        }
/// <summary>
/// The TotalAvailableCapacityKG property
///
/// </summary>
///
        public virtual decimal? TotalAvailableCapacityKG
        {
            get
            {
                return totalAvailableCapacityKG;
            }
            set
            {
                totalAvailableCapacityKG = value;
            }
        }
/// <summary>
/// The EffectiveFrom property
///
/// </summary>
///
        public virtual DateTime? EffectiveFrom
        {
            get
            {
                return effectiveFrom;
            }
            set
            {
                effectiveFrom = value;
            }
        }
/// <summary>
/// The EffectiveTo property
///
/// </summary>
///
        public virtual DateTime? EffectiveTo
        {
            get
            {
                return effectiveTo;
            }
            set
            {
                effectiveTo = value;
            }
        }
/// <summary>
/// The TypeOfGoods property
///
/// </summary>
///
        public virtual DSS2_SynchromodalityCapacityOptimisation.BO.TruckContent? TypeOfGoods
        {
            get
            {
                return typeOfGoods;
            }
            set
            {
                typeOfGoods = value;
            }
        }
/// <summary>
/// The Revision property
///
/// </summary>
///
        public virtual int? Revision
        {
            get
            {
                return revision;
            }
            set
            {
                revision = value;
            }
        }
/// <summary>
/// The GUID property
///
/// </summary>
///
        public virtual string GUID
        {
            get
            {
                return gUID;
            }
            set
            {
                gUID = value;
            }
        }
/// <summary>
/// The ReservedCapacityLaden property
///
/// </summary>
///
        public virtual int? ReservedCapacityLaden
        {
            get
            {
                return reservedCapacityLaden;
            }
            set
            {
                reservedCapacityLaden = value;
            }
        }
/// <summary>
/// The State property
///
/// </summary>
///
        public virtual DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState? State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
/// <summary>
/// The BaseId property
///
/// </summary>
///
        public virtual int? BaseId
        {
            get
            {
                return baseId;
            }
            set
            {
                baseId = value;
            }
        }
/// <summary>
/// The Frequency property
///
/// </summary>
///
        public virtual DSS2_SynchromodalityCapacityOptimisation.BO.RouteFrequency? Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }
/// <summary>
/// The TotalAvailableCapacityM3 property
///
/// </summary>
///
        public virtual decimal? TotalAvailableCapacityM3
        {
            get
            {
                return totalAvailableCapacityM3;
            }
            set
            {
                totalAvailableCapacityM3 = value;
            }
        }
/// <summary>
/// The TotalAvailableCapacityLaden property
///
/// </summary>
///
        public virtual int? TotalAvailableCapacityLaden
        {
            get
            {
                return totalAvailableCapacityLaden;
            }
            set
            {
                totalAvailableCapacityLaden = value;
            }
        }
/// <summary>
/// The ReservedCapacityKG property
///
/// </summary>
///
        public virtual decimal? ReservedCapacityKG
        {
            get
            {
                return reservedCapacityKG;
            }
            set
            {
                reservedCapacityKG = value;
            }
        }
/// <summary>
/// The ReservedCapacityM3 property
///
/// </summary>
///
        public virtual decimal? ReservedCapacityM3
        {
            get
            {
                return reservedCapacityM3;
            }
            set
            {
                reservedCapacityM3 = value;
            }
        }
/// <summary>
/// The FixedPrice property
///
/// </summary>
///
        public virtual decimal? FixedPrice
        {
            get
            {
                return fixedPrice;
            }
            set
            {
                fixedPrice = value;
            }
        }
/// <summary>
/// The OriginComments property
///
/// </summary>
///
        public virtual string OriginComments
        {
            get
            {
                return originComments;
            }
            set
            {
                originComments = value;
            }
        }
/// <summary>
/// The DestinationComments property
///
/// </summary>
///
        public virtual string DestinationComments
        {
            get
            {
                return destinationComments;
            }
            set
            {
                destinationComments = value;
            }
        }
/// <summary>
/// The TruckPlate property
///
/// </summary>
///
        public virtual string TruckPlate
        {
            get
            {
                return truckPlate;
            }
            set
            {
                truckPlate = value;
            }
        }
/// <summary>
/// The stringenum property
///
/// </summary>
///
        public virtual string stringenum
        {
            get
            {
                return _stringenum;
            }
            set
            {
                _stringenum = value;
            }
        }
/// <summary>
/// The DeliveryDate property
///
/// </summary>
///
        public virtual DateTime? DeliveryDate
        {
            get
            {
                return deliveryDate;
            }
            set
            {
                deliveryDate = value;
            }
        }
/// <summary>
/// The Attribute property
///
/// </summary>
///
        public virtual DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState? Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
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
        #region ScheduledRoute's Participant Properties
        [DataMember(Name="WorkContract")]
        protected WorkContract workContract;
        public virtual WorkContract WorkContract
        {
            get
            {
                return workContract;
            }
            set
            {
                if(Equals(workContract, value)) return;
                var __oldValue = workContract;
                workContract?.InternalRemoveScheduledRoutes(this);
                workContract = value;
                if (value != null)
                {
                    workContract.InternalAddScheduledRoutes(this);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ScheduledRoute class
/// </summary>
/// <returns>New ScheduledRoute object</returns>
/// <remarks></remarks>
        public ScheduledRoute() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Origin != null && Origin.Length > 100)
            {
                __errors.Add("Length of property 'Origin' cannot be greater than 100.");
            }
            if (Destination != null && Destination.Length > 100)
            {
                __errors.Add("Length of property 'Destination' cannot be greater than 100.");
            }
            if (DaysOfWeek != null && DaysOfWeek.Length > 100)
            {
                __errors.Add("Length of property 'DaysOfWeek' cannot be greater than 100.");
            }
            if (GUID != null && GUID.Length > 100)
            {
                __errors.Add("Length of property 'GUID' cannot be greater than 100.");
            }
            if (OriginComments != null && OriginComments.Length > 100)
            {
                __errors.Add("Length of property 'OriginComments' cannot be greater than 100.");
            }
            if (DestinationComments != null && DestinationComments.Length > 100)
            {
                __errors.Add("Length of property 'DestinationComments' cannot be greater than 100.");
            }
            if (TruckPlate != null && TruckPlate.Length > 100)
            {
                __errors.Add("Length of property 'TruckPlate' cannot be greater than 100.");
            }
            if (stringenum != null && stringenum.Length > 100)
            {
                __errors.Add("Length of property 'stringenum' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'ScheduledRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Origin?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Destination?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DaysOfWeek?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PricePerPallet?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PricePerKilogram?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PricePerCubicMeter?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalAvailableCapacityKG?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EffectiveFrom?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EffectiveTo?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TypeOfGoods?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Revision?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (GUID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ReservedCapacityLaden?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (State?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (BaseId?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Frequency?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalAvailableCapacityM3?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalAvailableCapacityLaden?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ReservedCapacityKG?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ReservedCapacityM3?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (FixedPrice?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginComments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationComments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TruckPlate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (stringenum?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DeliveryDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Attribute?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [ScheduledRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ScheduledRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ScheduledRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ScheduledRoute)copiedObjects[this];
            copy = copy ?? new ScheduledRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Origin = this.Origin;
            copy.Destination = this.Destination;
            copy.DaysOfWeek = this.DaysOfWeek;
            copy.PricePerPallet = this.PricePerPallet;
            copy.PricePerKilogram = this.PricePerKilogram;
            copy.PricePerCubicMeter = this.PricePerCubicMeter;
            copy.TotalAvailableCapacityKG = this.TotalAvailableCapacityKG;
            copy.EffectiveFrom = this.EffectiveFrom;
            copy.EffectiveTo = this.EffectiveTo;
            copy.TypeOfGoods = this.TypeOfGoods;
            copy.Revision = this.Revision;
            copy.GUID = this.GUID;
            copy.ReservedCapacityLaden = this.ReservedCapacityLaden;
            copy.State = this.State;
            copy.BaseId = this.BaseId;
            copy.Frequency = this.Frequency;
            copy.TotalAvailableCapacityM3 = this.TotalAvailableCapacityM3;
            copy.TotalAvailableCapacityLaden = this.TotalAvailableCapacityLaden;
            copy.ReservedCapacityKG = this.ReservedCapacityKG;
            copy.ReservedCapacityM3 = this.ReservedCapacityM3;
            copy.FixedPrice = this.FixedPrice;
            copy.OriginComments = this.OriginComments;
            copy.DestinationComments = this.DestinationComments;
            copy.TruckPlate = this.TruckPlate;
            copy.stringenum = this.stringenum;
            copy.DeliveryDate = this.DeliveryDate;
            copy.Attribute = this.Attribute;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.workContract != null)
            {
                if (!copiedObjects.Contains(this.workContract))
                {
                    if (asNew && reuseNestedObjects)
                        copy.WorkContract = this.WorkContract;
                    else if (asNew)
                        copy.WorkContract = this.WorkContract.Copy(deep, copiedObjects, true);
                    else
                        copy.workContract = this.workContract.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.WorkContract = (WorkContract)copiedObjects[this.WorkContract];
                    else
                        copy.workContract = (WorkContract)copiedObjects[this.WorkContract];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ScheduledRoute;
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
        public static bool operator ==(ScheduledRoute x, ScheduledRoute y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(ScheduledRoute x, ScheduledRoute y)
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
        protected bool HasSameNonDefaultIdAs(ScheduledRoute compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
