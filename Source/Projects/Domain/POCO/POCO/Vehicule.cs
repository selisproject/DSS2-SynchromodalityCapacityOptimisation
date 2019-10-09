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
    /// The Vehicule class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Vehicule : IDomainModelClass
    {
        #region Vehicule's Fields

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
        [DataMember(Name="OverHeadCost")]
        protected decimal? overHeadCost;
        [DataMember(Name="CalculatedTimeCost")]
        protected decimal? calculatedTimeCost;
        [DataMember(Name="CalculatedDistanceCost")]
        protected decimal? calculatedDistanceCost;
        [DataMember(Name="CalculatedOwnershipCost")]
        protected decimal? calculatedOwnershipCost;
        [DataMember(Name="VehiculeType")]
        protected string vehiculeType;
        [DataMember(Name="Volume")]
        protected string volume;
        [DataMember(Name="CO2perKm")]
        protected decimal? cO2perKm;
        [DataMember(Name="AmortizationType")]
        protected string amortizationType;
        [DataMember(Name="MaximumLoad")]
        protected decimal? maximumLoad;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region Vehicule's Properties
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
/// The OverHeadCost property
///
/// </summary>
///
        public virtual decimal? OverHeadCost
        {
            get
            {
                return overHeadCost;
            }
            set
            {
                overHeadCost = value;
            }
        }
/// <summary>
/// The CalculatedTimeCost property
///
/// </summary>
///
        public virtual decimal? CalculatedTimeCost
        {
            get
            {
                return calculatedTimeCost;
            }
            set
            {
                calculatedTimeCost = value;
            }
        }
/// <summary>
/// The CalculatedDistanceCost property
///
/// </summary>
///
        public virtual decimal? CalculatedDistanceCost
        {
            get
            {
                return calculatedDistanceCost;
            }
            set
            {
                calculatedDistanceCost = value;
            }
        }
/// <summary>
/// The CalculatedOwnershipCost property
///
/// </summary>
///
        public virtual decimal? CalculatedOwnershipCost
        {
            get
            {
                return calculatedOwnershipCost;
            }
            set
            {
                calculatedOwnershipCost = value;
            }
        }
/// <summary>
/// The VehiculeType property
///
/// </summary>
///
        public virtual string VehiculeType
        {
            get
            {
                return vehiculeType;
            }
            set
            {
                vehiculeType = value;
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
/// The CO2perKm property
///
/// </summary>
///
        public virtual decimal? CO2perKm
        {
            get
            {
                return cO2perKm;
            }
            set
            {
                cO2perKm = value;
            }
        }
/// <summary>
/// The AmortizationType property
///
/// </summary>
///
        public virtual string AmortizationType
        {
            get
            {
                return amortizationType;
            }
            set
            {
                amortizationType = value;
            }
        }
/// <summary>
/// The MaximumLoad property
///
/// </summary>
///
        public virtual decimal? MaximumLoad
        {
            get
            {
                return maximumLoad;
            }
            set
            {
                maximumLoad = value;
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
        #region Vehicule's Participant Properties
        [DataMember(Name="DistanceCosts")]
        protected DistanceCosts distanceCosts;
        public virtual DistanceCosts DistanceCosts
        {
            get
            {
                return distanceCosts;
            }
            set
            {
                if(Equals(distanceCosts, value)) return;
                var __oldValue = distanceCosts;
                if (value != null)
                {
                    distanceCosts = value;
                }
                else
                {
                    if (distanceCosts != null)
                    {
                        distanceCosts = null;
                    }
                }
            }
        }
        [DataMember(Name="TimeCosts")]
        protected TimeCosts timeCosts;
        public virtual TimeCosts TimeCosts
        {
            get
            {
                return timeCosts;
            }
            set
            {
                if(Equals(timeCosts, value)) return;
                var __oldValue = timeCosts;
                if (value != null)
                {
                    timeCosts = value;
                }
                else
                {
                    if (timeCosts != null)
                    {
                        timeCosts = null;
                    }
                }
            }
        }
        [DataMember(Name="OwnershipCost")]
        protected OwnershipCost ownershipCost;
        public virtual OwnershipCost OwnershipCost
        {
            get
            {
                return ownershipCost;
            }
            set
            {
                if(Equals(ownershipCost, value)) return;
                var __oldValue = ownershipCost;
                if (value != null)
                {
                    if(ownershipCost != null && !Equals(ownershipCost, value))
                        ownershipCost.Vehicule = null;
                    ownershipCost = value;
                    if(ownershipCost.Vehicule != this)
                        ownershipCost.Vehicule = this;
                }
                else
                {
                    if (ownershipCost != null)
                    {
                        var __obj = ownershipCost;
                        ownershipCost = null;
                        __obj.Vehicule = null;
                    }
                }
            }
        }
        [DataMember(Name="AmortizationType1")]
        protected AmortizationType amortizationType1;
        public virtual AmortizationType AmortizationType1
        {
            get
            {
                return amortizationType1;
            }
            set
            {
                if(Equals(amortizationType1, value)) return;
                var __oldValue = amortizationType1;
                amortizationType1 = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Vehicule class
/// </summary>
/// <returns>New Vehicule object</returns>
/// <remarks></remarks>
        public Vehicule() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (VehiculeType != null && VehiculeType.Length > 100)
            {
                __errors.Add("Length of property 'VehiculeType' cannot be greater than 100.");
            }
            if (Volume != null && Volume.Length > 100)
            {
                __errors.Add("Length of property 'Volume' cannot be greater than 100.");
            }
            if (AmortizationType != null && AmortizationType.Length > 100)
            {
                __errors.Add("Length of property 'AmortizationType' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'Vehicule' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OverHeadCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CalculatedTimeCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CalculatedDistanceCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CalculatedOwnershipCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (VehiculeType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Volume?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CO2perKm?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AmortizationType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (MaximumLoad?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [Vehicule] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Vehicule Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Vehicule copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Vehicule)copiedObjects[this];
            copy = copy ?? new Vehicule();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.OverHeadCost = this.OverHeadCost;
            copy.CalculatedTimeCost = this.CalculatedTimeCost;
            copy.CalculatedDistanceCost = this.CalculatedDistanceCost;
            copy.CalculatedOwnershipCost = this.CalculatedOwnershipCost;
            copy.VehiculeType = this.VehiculeType;
            copy.Volume = this.Volume;
            copy.CO2perKm = this.CO2perKm;
            copy.AmortizationType = this.AmortizationType;
            copy.MaximumLoad = this.MaximumLoad;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.distanceCosts != null)
            {
                if (!copiedObjects.Contains(this.distanceCosts))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DistanceCosts = this.DistanceCosts;
                    else if (asNew)
                        copy.DistanceCosts = this.DistanceCosts.Copy(deep, copiedObjects, true);
                    else
                        copy.distanceCosts = this.distanceCosts.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DistanceCosts = (DistanceCosts)copiedObjects[this.DistanceCosts];
                    else
                        copy.distanceCosts = (DistanceCosts)copiedObjects[this.DistanceCosts];
                }
            }
            if(deep && this.timeCosts != null)
            {
                if (!copiedObjects.Contains(this.timeCosts))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TimeCosts = this.TimeCosts;
                    else if (asNew)
                        copy.TimeCosts = this.TimeCosts.Copy(deep, copiedObjects, true);
                    else
                        copy.timeCosts = this.timeCosts.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TimeCosts = (TimeCosts)copiedObjects[this.TimeCosts];
                    else
                        copy.timeCosts = (TimeCosts)copiedObjects[this.TimeCosts];
                }
            }
            if(deep && this.ownershipCost != null)
            {
                if (!copiedObjects.Contains(this.ownershipCost))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OwnershipCost = this.OwnershipCost;
                    else if (asNew)
                        copy.OwnershipCost = this.OwnershipCost.Copy(deep, copiedObjects, true);
                    else
                        copy.ownershipCost = this.ownershipCost.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OwnershipCost = (OwnershipCost)copiedObjects[this.OwnershipCost];
                    else
                        copy.ownershipCost = (OwnershipCost)copiedObjects[this.OwnershipCost];
                }
            }
            if(deep && this.amortizationType1 != null)
            {
                if (!copiedObjects.Contains(this.amortizationType1))
                {
                    if (asNew && reuseNestedObjects)
                        copy.AmortizationType1 = this.AmortizationType1;
                    else if (asNew)
                        copy.AmortizationType1 = this.AmortizationType1.Copy(deep, copiedObjects, true);
                    else
                        copy.amortizationType1 = this.amortizationType1.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.AmortizationType1 = (AmortizationType)copiedObjects[this.AmortizationType1];
                    else
                        copy.amortizationType1 = (AmortizationType)copiedObjects[this.AmortizationType1];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Vehicule;
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
        public static bool operator ==(Vehicule x, Vehicule y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(Vehicule x, Vehicule y)
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
        protected bool HasSameNonDefaultIdAs(Vehicule compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}