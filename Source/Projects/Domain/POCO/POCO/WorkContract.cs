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
    /// The WorkContract class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class WorkContract : IDomainModelClass
    {
        #region WorkContract's Fields

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
        [DataMember(Name="CreationDate")]
        protected DateTime? creationDate;
        [DataMember(Name="LastUpdate")]
        protected DateTime? lastUpdate;
        [DataMember(Name="Status")]
        protected DSS2_SynchromodalityCapacityOptimisation.BO.ContractStatus? status;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

#pragma warning disable 0649
        private bool disableInternalAdditions;
#pragma warning restore 0649
        #endregion
        #region WorkContract's Properties
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
/// The CreationDate property
///
/// </summary>
///
        public virtual DateTime? CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
            }
        }
/// <summary>
/// The LastUpdate property
///
/// </summary>
///
        public virtual DateTime? LastUpdate
        {
            get
            {
                return lastUpdate;
            }
            set
            {
                lastUpdate = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual DSS2_SynchromodalityCapacityOptimisation.BO.ContractStatus? Status
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
        #region WorkContract's Participant Properties
        [DataMember(Name="RegionalAgent")]
        protected RegionalAgent regionalAgent;
        public virtual RegionalAgent RegionalAgent
        {
            get
            {
                return regionalAgent;
            }
            set
            {
                if(Equals(regionalAgent, value)) return;
                var __oldValue = regionalAgent;
                regionalAgent?.InternalRemoveWorkContract(this);
                regionalAgent = value;
                if (value != null)
                {
                    regionalAgent.InternalAddWorkContract(this);
                }
            }
        }
        [DataMember(Name="ScheduledRoutes")]
        protected IList<ScheduledRoute> scheduledRoutes = new List<ScheduledRoute>();
        public virtual List<ScheduledRoute> ScheduledRoutes
        {
            get
            {
                if (scheduledRoutes is ScheduledRoute[])
                {
                    scheduledRoutes = scheduledRoutes.ToList();
                }
                if (scheduledRoutes == null)
                {
                    scheduledRoutes = new List<ScheduledRoute>();
                }
                return scheduledRoutes.ToList();
            }
            set
            {
                if (scheduledRoutes is ScheduledRoute[])
                {
                    scheduledRoutes = scheduledRoutes.ToList();
                }
                if (scheduledRoutes != null)
                {
                    var __itemsToDelete = new List<ScheduledRoute>(scheduledRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveScheduledRoutes(__item);
                    }
                }
                if(value == null)
                {
                    scheduledRoutes = new List<ScheduledRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddScheduledRoutes(__item);
                }
            }
        }
        public virtual void AddScheduledRoutes(IList<ScheduledRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddScheduledRoutes(__item);
            }
        }

        public virtual void InternalAddScheduledRoutes(ScheduledRoute __item)
        {
            if (__item == null || disableInternalAdditions) return;
            scheduledRoutes?.Add(__item);
        }

        public virtual void InternalRemoveScheduledRoutes(ScheduledRoute __item)
        {
            if (__item == null) return;
            scheduledRoutes?.Remove(__item);
        }

        public virtual void AddScheduledRoutes(ScheduledRoute __item)
        {
            if (__item == null) return;
            if (__item.WorkContract != this)
                __item.WorkContract = this;
        }

        public virtual void AddAtIndexScheduledRoutes(int index, ScheduledRoute __item)
        {
            if (__item == null) return;
            scheduledRoutes?.Insert(index, __item);
            disableInternalAdditions = true;
            try
            {
                if (__item.WorkContract != this)
                    __item.WorkContract = this;
            }
            finally
            {
                disableInternalAdditions = false;
            }
        }

        public virtual void RemoveScheduledRoutes(ScheduledRoute __item)
        {
            if (__item != null)
            {
                __item.WorkContract = null;
            }
        }
        public virtual void SetScheduledRoutesAt(ScheduledRoute __item, int __index)
        {
            if (__item == null)
            {
                scheduledRoutes[__index].WorkContract = null;
            }
            else
            {
                scheduledRoutes[__index] = __item;
                if (__item.WorkContract != this)
                    __item.WorkContract = this;
            }
        }

        public virtual void ClearScheduledRoutes()
        {
            if (scheduledRoutes!=null)
            {
                var __itemsToRemove = scheduledRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveScheduledRoutes(__item);
                }
            }
        }
        [DataMember(Name="LSP")]
        protected LSP lSP;
        public virtual LSP LSP
        {
            get
            {
                return lSP;
            }
            set
            {
                if(Equals(lSP, value)) return;
                var __oldValue = lSP;
                lSP?.InternalRemoveWorkContracts(this);
                lSP = value;
                if (value != null)
                {
                    lSP.InternalAddWorkContracts(this);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the WorkContract class
/// </summary>
/// <returns>New WorkContract object</returns>
/// <remarks></remarks>
        public WorkContract() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (RegionalAgent == null)
            {
                __errors.Add("Association with 'RegionalAgent' is required.");
            }
            if (LSP == null)
            {
                __errors.Add("Association with 'LSP' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'WorkContract' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CreationDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LastUpdate?.GetHashCode() ?? 0);
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
/// <param name="copy">Optional - An existing [WorkContract] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual WorkContract Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, WorkContract copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (WorkContract)copiedObjects[this];
            copy = copy ?? new WorkContract();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.CreationDate = this.CreationDate;
            copy.LastUpdate = this.LastUpdate;
            copy.Status = this.Status;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.regionalAgent != null)
            {
                if (!copiedObjects.Contains(this.regionalAgent))
                {
                    if (asNew && reuseNestedObjects)
                        copy.RegionalAgent = this.RegionalAgent;
                    else if (asNew)
                        copy.RegionalAgent = this.RegionalAgent.Copy(deep, copiedObjects, true);
                    else
                        copy.regionalAgent = this.regionalAgent.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.RegionalAgent = (RegionalAgent)copiedObjects[this.RegionalAgent];
                    else
                        copy.regionalAgent = (RegionalAgent)copiedObjects[this.RegionalAgent];
                }
            }
            copy.scheduledRoutes = new List<ScheduledRoute>();
            if(deep && this.scheduledRoutes != null)
            {
                foreach (var __item in this.scheduledRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddScheduledRoutes(__item);
                        else
                            copy.AddScheduledRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddScheduledRoutes((ScheduledRoute)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.lSP != null)
            {
                if (!copiedObjects.Contains(this.lSP))
                {
                    if (asNew && reuseNestedObjects)
                        copy.LSP = this.LSP;
                    else if (asNew)
                        copy.LSP = this.LSP.Copy(deep, copiedObjects, true);
                    else
                        copy.lSP = this.lSP.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.LSP = (LSP)copiedObjects[this.LSP];
                    else
                        copy.lSP = (LSP)copiedObjects[this.LSP];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as WorkContract;
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
        public static bool operator ==(WorkContract x, WorkContract y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(WorkContract x, WorkContract y)
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
        protected bool HasSameNonDefaultIdAs(WorkContract compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
