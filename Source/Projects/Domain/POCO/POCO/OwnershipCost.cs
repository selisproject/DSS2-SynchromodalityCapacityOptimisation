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
    /// The OwnershipCost class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class OwnershipCost : IDomainModelClass
    {
        #region OwnershipCost's Fields

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
        [DataMember(Name="VehiculePurchaseCost")]
        protected decimal? vehiculePurchaseCost;
        [DataMember(Name="RefrigerationSystemCost")]
        protected decimal? refrigerationSystemCost;
        [DataMember(Name="LetteringCost")]
        protected decimal? letteringCost;
        [DataMember(Name="InterestRate")]
        protected decimal? interestRate;
        [DataMember(Name="PaybackPeriod")]
        protected decimal? paybackPeriod;
        [DataMember(Name="TotalDistancePerVehicule")]
        protected decimal? totalDistancePerVehicule;
        [DataMember(Name="AmortizationPeriod")]
        protected decimal? amortizationPeriod;
        [DataMember(Name="ResidualValue")]
        protected decimal? residualValue;
        [DataMember(Name="UtilizationPeriod")]
        protected decimal? utilizationPeriod;
        [DataMember(Name="Cost")]
        protected decimal? cost;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region OwnershipCost's Properties
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
/// The VehiculePurchaseCost property
///
/// </summary>
///
        public virtual decimal? VehiculePurchaseCost
        {
            get
            {
                return vehiculePurchaseCost;
            }
            set
            {
                vehiculePurchaseCost = value;
            }
        }
/// <summary>
/// The RefrigerationSystemCost property
///
/// </summary>
///
        public virtual decimal? RefrigerationSystemCost
        {
            get
            {
                return refrigerationSystemCost;
            }
            set
            {
                refrigerationSystemCost = value;
            }
        }
/// <summary>
/// The LetteringCost property
///
/// </summary>
///
        public virtual decimal? LetteringCost
        {
            get
            {
                return letteringCost;
            }
            set
            {
                letteringCost = value;
            }
        }
/// <summary>
/// The InterestRate property
///
/// </summary>
///
        public virtual decimal? InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
/// <summary>
/// The PaybackPeriod property
///
/// </summary>
///
        public virtual decimal? PaybackPeriod
        {
            get
            {
                return paybackPeriod;
            }
            set
            {
                paybackPeriod = value;
            }
        }
/// <summary>
/// The TotalDistancePerVehicule property
///
/// </summary>
///
        public virtual decimal? TotalDistancePerVehicule
        {
            get
            {
                return totalDistancePerVehicule;
            }
            set
            {
                totalDistancePerVehicule = value;
            }
        }
/// <summary>
/// The AmortizationPeriod property
///
/// </summary>
///
        public virtual decimal? AmortizationPeriod
        {
            get
            {
                return amortizationPeriod;
            }
            set
            {
                amortizationPeriod = value;
            }
        }
/// <summary>
/// The ResidualValue property
///
/// </summary>
///
        public virtual decimal? ResidualValue
        {
            get
            {
                return residualValue;
            }
            set
            {
                residualValue = value;
            }
        }
/// <summary>
/// The UtilizationPeriod property
///
/// </summary>
///
        public virtual decimal? UtilizationPeriod
        {
            get
            {
                return utilizationPeriod;
            }
            set
            {
                utilizationPeriod = value;
            }
        }
/// <summary>
/// The Cost property
///
/// </summary>
///
        public virtual decimal? Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
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
        #region OwnershipCost's Participant Properties
        [DataMember(Name="Vehicule")]
        protected Vehicule vehicule;
        public virtual Vehicule Vehicule
        {
            get
            {
                return vehicule;
            }
            set
            {
                if(Equals(vehicule, value)) return;
                var __oldValue = vehicule;
                if (value != null)
                {
                    if(vehicule != null && !Equals(vehicule, value))
                        vehicule.OwnershipCost = null;
                    vehicule = value;
                    if(vehicule.OwnershipCost != this)
                        vehicule.OwnershipCost = this;
                }
                else
                {
                    if (vehicule != null)
                    {
                        var __obj = vehicule;
                        vehicule = null;
                        __obj.OwnershipCost = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the OwnershipCost class
/// </summary>
/// <returns>New OwnershipCost object</returns>
/// <remarks></remarks>
        public OwnershipCost() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'OwnershipCost' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (VehiculePurchaseCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RefrigerationSystemCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LetteringCost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (InterestRate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PaybackPeriod?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalDistancePerVehicule?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AmortizationPeriod?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ResidualValue?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (UtilizationPeriod?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Cost?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [OwnershipCost] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual OwnershipCost Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, OwnershipCost copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (OwnershipCost)copiedObjects[this];
            copy = copy ?? new OwnershipCost();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.VehiculePurchaseCost = this.VehiculePurchaseCost;
            copy.RefrigerationSystemCost = this.RefrigerationSystemCost;
            copy.LetteringCost = this.LetteringCost;
            copy.InterestRate = this.InterestRate;
            copy.PaybackPeriod = this.PaybackPeriod;
            copy.TotalDistancePerVehicule = this.TotalDistancePerVehicule;
            copy.AmortizationPeriod = this.AmortizationPeriod;
            copy.ResidualValue = this.ResidualValue;
            copy.UtilizationPeriod = this.UtilizationPeriod;
            copy.Cost = this.Cost;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.vehicule != null)
            {
                if (!copiedObjects.Contains(this.vehicule))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Vehicule = this.Vehicule;
                    else if (asNew)
                        copy.Vehicule = this.Vehicule.Copy(deep, copiedObjects, true);
                    else
                        copy.vehicule = this.vehicule.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Vehicule = (Vehicule)copiedObjects[this.Vehicule];
                    else
                        copy.vehicule = (Vehicule)copiedObjects[this.Vehicule];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as OwnershipCost;
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
        public static bool operator ==(OwnershipCost x, OwnershipCost y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(OwnershipCost x, OwnershipCost y)
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
        protected bool HasSameNonDefaultIdAs(OwnershipCost compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
