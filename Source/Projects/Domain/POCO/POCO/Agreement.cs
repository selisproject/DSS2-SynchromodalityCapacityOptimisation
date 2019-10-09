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
    /// The Agreement class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Agreement : IDomainModelClass
    {
        #region Agreement's Fields

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
        [DataMember(Name="FullTruckLoad")]
        protected bool fullTruckLoad;
        [DataMember(Name="AgreementDocument")]
        protected string agreementDocument;
        [DataMember(Name="LeadTime")]
        protected string leadTime;
        [DataMember(Name="DateCreated")]
        protected DateTime? dateCreated;
        [DataMember(Name="WDDeliveries")]
        protected bool wDDeliveries;
        [DataMember(Name="TargetInventoryDays")]
        protected int? targetInventoryDays;
        [DataMember(Name="Profile")]
        protected string profile;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

#pragma warning disable 0649
        private bool disableInternalAdditions;
#pragma warning restore 0649
        #endregion
        #region Agreement's Properties
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
/// The FullTruckLoad property
///
/// </summary>
///
        public virtual bool FullTruckLoad
        {
            get
            {
                return fullTruckLoad;
            }
            set
            {
                fullTruckLoad = value;
            }
        }
/// <summary>
/// The AgreementDocument property
///
/// </summary>
///
        public virtual string AgreementDocument
        {
            get
            {
                return agreementDocument;
            }
            set
            {
                agreementDocument = value;
            }
        }
/// <summary>
/// The LeadTime property
///
/// </summary>
///
        public virtual string LeadTime
        {
            get
            {
                return leadTime;
            }
            set
            {
                leadTime = value;
            }
        }
/// <summary>
/// The DateCreated property
///
/// </summary>
///
        public virtual DateTime? DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }
/// <summary>
/// The WDDeliveries property
///
/// </summary>
///
        public virtual bool WDDeliveries
        {
            get
            {
                return wDDeliveries;
            }
            set
            {
                wDDeliveries = value;
            }
        }
/// <summary>
/// The TargetInventoryDays property
///
/// </summary>
///
        public virtual int? TargetInventoryDays
        {
            get
            {
                return targetInventoryDays;
            }
            set
            {
                targetInventoryDays = value;
            }
        }
/// <summary>
/// The Profile property
///
/// </summary>
///
        public virtual string Profile
        {
            get
            {
                return profile;
            }
            set
            {
                profile = value;
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
        #region Agreement's Participant Properties
        [DataMember(Name="AgreementStatuses")]
        protected IList<AgreementStatus> agreementStatuses = new List<AgreementStatus>();
        public virtual List<AgreementStatus> AgreementStatuses
        {
            get
            {
                if (agreementStatuses is AgreementStatus[])
                {
                    agreementStatuses = agreementStatuses.ToList();
                }
                if (agreementStatuses == null)
                {
                    agreementStatuses = new List<AgreementStatus>();
                }
                return agreementStatuses.ToList();
            }
            set
            {
                if (agreementStatuses is AgreementStatus[])
                {
                    agreementStatuses = agreementStatuses.ToList();
                }
                if (agreementStatuses != null)
                {
                    var __itemsToDelete = new List<AgreementStatus>(agreementStatuses);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAgreementStatuses(__item);
                    }
                }
                if(value == null)
                {
                    agreementStatuses = new List<AgreementStatus>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAgreementStatuses(__item);
                }
            }
        }
        public virtual void AddAgreementStatuses(IList<AgreementStatus> __items)
        {
            foreach (var __item in __items)
            {
                AddAgreementStatuses(__item);
            }
        }

        public virtual void InternalAddAgreementStatuses(AgreementStatus __item)
        {
            if (__item == null || disableInternalAdditions) return;
            agreementStatuses?.Add(__item);
        }

        public virtual void InternalRemoveAgreementStatuses(AgreementStatus __item)
        {
            if (__item == null) return;
            agreementStatuses?.Remove(__item);
        }

        public virtual void AddAgreementStatuses(AgreementStatus __item)
        {
            if (__item == null) return;
            InternalAddAgreementStatuses(__item);
        }

        public virtual void AddAtIndexAgreementStatuses(int index, AgreementStatus __item)
        {
            if (__item == null) return;
            agreementStatuses?.Insert(index, __item);
        }

        public virtual void RemoveAgreementStatuses(AgreementStatus __item)
        {
            if (__item != null)
            {
                InternalRemoveAgreementStatuses(__item);
            }
        }
        public virtual void SetAgreementStatusesAt(AgreementStatus __item, int __index)
        {
            if (__item == null)
            {
                agreementStatuses[__index] = null;
            }
            else
            {
                agreementStatuses[__index] = __item;
            }
        }

        public virtual void ClearAgreementStatuses()
        {
            if (agreementStatuses!=null)
            {
                var __itemsToRemove = agreementStatuses.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAgreementStatuses(__item);
                }
            }
        }
        [DataMember(Name="Items")]
        protected IList<Item> items = new List<Item>();
        public virtual List<Item> Items
        {
            get
            {
                if (items is Item[])
                {
                    items = items.ToList();
                }
                if (items == null)
                {
                    items = new List<Item>();
                }
                return items.ToList();
            }
            set
            {
                if (items is Item[])
                {
                    items = items.ToList();
                }
                if (items != null)
                {
                    var __itemsToDelete = new List<Item>(items);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveItems(__item);
                    }
                }
                if(value == null)
                {
                    items = new List<Item>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddItems(__item);
                }
            }
        }
        public virtual void AddItems(IList<Item> __items)
        {
            foreach (var __item in __items)
            {
                AddItems(__item);
            }
        }

        public virtual void InternalAddItems(Item __item)
        {
            if (__item == null || disableInternalAdditions) return;
            items?.Add(__item);
        }

        public virtual void InternalRemoveItems(Item __item)
        {
            if (__item == null) return;
            items?.Remove(__item);
        }

        public virtual void AddItems(Item __item)
        {
            if (__item == null) return;
            if (!items.Contains(__item))
                InternalAddItems(__item);
            if (!__item.Agreements.Contains(this))
                __item.AddAgreements(this);
        }

        public virtual void AddAtIndexItems(int index, Item __item)
        {
            if (__item == null) return;
            if (!items.Contains(__item))
                items.Insert(index, __item);
            if (!__item.Agreements.Contains(this))
                __item.AddAgreements(this);
        }

        public virtual void RemoveItems(Item __item)
        {
            if (__item != null)
            {
                if (items.Contains(__item))
                    InternalRemoveItems(__item);
                if(__item.Agreements.Contains(this))
                    __item.RemoveAgreements(this);
            }
        }
        public virtual void SetItemsAt(Item __item, int __index)
        {
            if (__item == null)
            {
                items[__index].RemoveAgreements(this);
            }
            else
            {
                items[__index] = __item;
                if (!__item.Agreements.Contains(this))
                    __item.AddAgreements(this);
            }
        }

        public virtual void ClearItems()
        {
            if (items!=null)
            {
                var __itemsToRemove = items.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveItems(__item);
                }
            }
        }
        [DataMember(Name="Supplier")]
        protected Supplier supplier;
        public virtual Supplier Supplier
        {
            get
            {
                return supplier;
            }
            set
            {
                if(Equals(supplier, value)) return;
                var __oldValue = supplier;
                supplier = value;
            }
        }
        [DataMember(Name="Warehouses")]
        protected IList<Warehouse> warehouses = new List<Warehouse>();
        public virtual List<Warehouse> Warehouses
        {
            get
            {
                if (warehouses is Warehouse[])
                {
                    warehouses = warehouses.ToList();
                }
                if (warehouses == null)
                {
                    warehouses = new List<Warehouse>();
                }
                return warehouses.ToList();
            }
            set
            {
                if (warehouses is Warehouse[])
                {
                    warehouses = warehouses.ToList();
                }
                if (warehouses != null)
                {
                    var __itemsToDelete = new List<Warehouse>(warehouses);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveWarehouses(__item);
                    }
                }
                if(value == null)
                {
                    warehouses = new List<Warehouse>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddWarehouses(__item);
                }
            }
        }
        public virtual void AddWarehouses(IList<Warehouse> __items)
        {
            foreach (var __item in __items)
            {
                AddWarehouses(__item);
            }
        }

        public virtual void InternalAddWarehouses(Warehouse __item)
        {
            if (__item == null || disableInternalAdditions) return;
            warehouses?.Add(__item);
        }

        public virtual void InternalRemoveWarehouses(Warehouse __item)
        {
            if (__item == null) return;
            warehouses?.Remove(__item);
        }

        public virtual void AddWarehouses(Warehouse __item)
        {
            if (__item == null) return;
            if (!warehouses.Contains(__item))
                InternalAddWarehouses(__item);
        }

        public virtual void AddAtIndexWarehouses(int index, Warehouse __item)
        {
            if (__item == null) return;
            if (!warehouses.Contains(__item))
                warehouses.Insert(index, __item);
        }

        public virtual void RemoveWarehouses(Warehouse __item)
        {
            if (__item != null)
            {
                InternalRemoveWarehouses(__item);
            }
        }
        public virtual void SetWarehousesAt(Warehouse __item, int __index)
        {
            if (__item == null)
            {
                warehouses[__index] = null;
            }
            else
            {
                warehouses[__index] = __item;
            }
        }

        public virtual void ClearWarehouses()
        {
            if (warehouses!=null)
            {
                var __itemsToRemove = warehouses.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveWarehouses(__item);
                }
            }
        }
        [DataMember(Name="StockOnHands")]
        protected IList<StockOnHand> stockOnHands = new List<StockOnHand>();
        public virtual List<StockOnHand> StockOnHands
        {
            get
            {
                if (stockOnHands is StockOnHand[])
                {
                    stockOnHands = stockOnHands.ToList();
                }
                if (stockOnHands == null)
                {
                    stockOnHands = new List<StockOnHand>();
                }
                return stockOnHands.ToList();
            }
            set
            {
                if (stockOnHands is StockOnHand[])
                {
                    stockOnHands = stockOnHands.ToList();
                }
                if (stockOnHands != null)
                {
                    var __itemsToDelete = new List<StockOnHand>(stockOnHands);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveStockOnHands(__item);
                    }
                }
                if(value == null)
                {
                    stockOnHands = new List<StockOnHand>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddStockOnHands(__item);
                }
            }
        }
        public virtual void AddStockOnHands(IList<StockOnHand> __items)
        {
            foreach (var __item in __items)
            {
                AddStockOnHands(__item);
            }
        }

        public virtual void InternalAddStockOnHands(StockOnHand __item)
        {
            if (__item == null || disableInternalAdditions) return;
            stockOnHands?.Add(__item);
        }

        public virtual void InternalRemoveStockOnHands(StockOnHand __item)
        {
            if (__item == null) return;
            stockOnHands?.Remove(__item);
        }

        public virtual void AddStockOnHands(StockOnHand __item)
        {
            if (__item == null) return;
            if (__item.Agreement != this)
                __item.Agreement = this;
        }

        public virtual void AddAtIndexStockOnHands(int index, StockOnHand __item)
        {
            if (__item == null) return;
            stockOnHands?.Insert(index, __item);
            disableInternalAdditions = true;
            try
            {
                if (__item.Agreement != this)
                    __item.Agreement = this;
            }
            finally
            {
                disableInternalAdditions = false;
            }
        }

        public virtual void RemoveStockOnHands(StockOnHand __item)
        {
            if (__item != null)
            {
                __item.Agreement = null;
            }
        }
        public virtual void SetStockOnHandsAt(StockOnHand __item, int __index)
        {
            if (__item == null)
            {
                stockOnHands[__index].Agreement = null;
            }
            else
            {
                stockOnHands[__index] = __item;
                if (__item.Agreement != this)
                    __item.Agreement = this;
            }
        }

        public virtual void ClearStockOnHands()
        {
            if (stockOnHands!=null)
            {
                var __itemsToRemove = stockOnHands.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveStockOnHands(__item);
                }
            }
        }
        [DataMember(Name="TransportUnCaps")]
        protected IList<TransportUnCap> transportUnCaps = new List<TransportUnCap>();
        public virtual List<TransportUnCap> TransportUnCaps
        {
            get
            {
                if (transportUnCaps is TransportUnCap[])
                {
                    transportUnCaps = transportUnCaps.ToList();
                }
                if (transportUnCaps == null)
                {
                    transportUnCaps = new List<TransportUnCap>();
                }
                return transportUnCaps.ToList();
            }
            set
            {
                if (transportUnCaps is TransportUnCap[])
                {
                    transportUnCaps = transportUnCaps.ToList();
                }
                if (transportUnCaps != null)
                {
                    var __itemsToDelete = new List<TransportUnCap>(transportUnCaps);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTransportUnCaps(__item);
                    }
                }
                if(value == null)
                {
                    transportUnCaps = new List<TransportUnCap>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTransportUnCaps(__item);
                }
            }
        }
        public virtual void AddTransportUnCaps(IList<TransportUnCap> __items)
        {
            foreach (var __item in __items)
            {
                AddTransportUnCaps(__item);
            }
        }

        public virtual void InternalAddTransportUnCaps(TransportUnCap __item)
        {
            if (__item == null || disableInternalAdditions) return;
            transportUnCaps?.Add(__item);
        }

        public virtual void InternalRemoveTransportUnCaps(TransportUnCap __item)
        {
            if (__item == null) return;
            transportUnCaps?.Remove(__item);
        }

        public virtual void AddTransportUnCaps(TransportUnCap __item)
        {
            if (__item == null) return;
            InternalAddTransportUnCaps(__item);
        }

        public virtual void AddAtIndexTransportUnCaps(int index, TransportUnCap __item)
        {
            if (__item == null) return;
            transportUnCaps?.Insert(index, __item);
        }

        public virtual void RemoveTransportUnCaps(TransportUnCap __item)
        {
            if (__item != null)
            {
                InternalRemoveTransportUnCaps(__item);
            }
        }
        public virtual void SetTransportUnCapsAt(TransportUnCap __item, int __index)
        {
            if (__item == null)
            {
                transportUnCaps[__index] = null;
            }
            else
            {
                transportUnCaps[__index] = __item;
            }
        }

        public virtual void ClearTransportUnCaps()
        {
            if (transportUnCaps!=null)
            {
                var __itemsToRemove = transportUnCaps.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTransportUnCaps(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Agreement class
/// </summary>
/// <returns>New Agreement object</returns>
/// <remarks></remarks>
        public Agreement() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (AgreementDocument != null && AgreementDocument.Length > 2147483647)
            {
                __errors.Add("Length of property 'AgreementDocument' cannot be greater than 2147483647.");
            }
            if (LeadTime != null && LeadTime.Length > 100)
            {
                __errors.Add("Length of property 'LeadTime' cannot be greater than 100.");
            }
            if (Profile != null && Profile.Length > 100)
            {
                __errors.Add("Length of property 'Profile' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'Agreement' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (FullTruckLoad.GetHashCode() );
            hashCode = hashCode * -1521134295 + (AgreementDocument?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LeadTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DateCreated?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (WDDeliveries.GetHashCode() );
            hashCode = hashCode * -1521134295 + (TargetInventoryDays?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Profile?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [Agreement] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Agreement Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Agreement copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Agreement)copiedObjects[this];
            copy = copy ?? new Agreement();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.FullTruckLoad = this.FullTruckLoad;
            copy.AgreementDocument = this.AgreementDocument;
            copy.LeadTime = this.LeadTime;
            copy.DateCreated = this.DateCreated;
            copy.WDDeliveries = this.WDDeliveries;
            copy.TargetInventoryDays = this.TargetInventoryDays;
            copy.Profile = this.Profile;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.agreementStatuses = new List<AgreementStatus>();
            if(deep && this.agreementStatuses != null)
            {
                foreach (var __item in this.agreementStatuses)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAgreementStatuses(__item);
                        else
                            copy.AddAgreementStatuses(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAgreementStatuses((AgreementStatus)copiedObjects[__item]);
                    }
                }
            }
            copy.items = new List<Item>();
            if(deep && this.items != null)
            {
                foreach (var __item in this.items)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddItems(__item);
                        else
                            copy.AddItems(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddItems((Item)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.supplier != null)
            {
                if (!copiedObjects.Contains(this.supplier))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Supplier = this.Supplier;
                    else if (asNew)
                        copy.Supplier = this.Supplier.Copy(deep, copiedObjects, true);
                    else
                        copy.supplier = this.supplier.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Supplier = (Supplier)copiedObjects[this.Supplier];
                    else
                        copy.supplier = (Supplier)copiedObjects[this.Supplier];
                }
            }
            copy.warehouses = new List<Warehouse>();
            if(deep && this.warehouses != null)
            {
                foreach (var __item in this.warehouses)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddWarehouses(__item);
                        else
                            copy.AddWarehouses(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddWarehouses((Warehouse)copiedObjects[__item]);
                    }
                }
            }
            copy.stockOnHands = new List<StockOnHand>();
            if(deep && this.stockOnHands != null)
            {
                foreach (var __item in this.stockOnHands)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddStockOnHands(__item);
                        else
                            copy.AddStockOnHands(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddStockOnHands((StockOnHand)copiedObjects[__item]);
                    }
                }
            }
            copy.transportUnCaps = new List<TransportUnCap>();
            if(deep && this.transportUnCaps != null)
            {
                foreach (var __item in this.transportUnCaps)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTransportUnCaps(__item);
                        else
                            copy.AddTransportUnCaps(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTransportUnCaps((TransportUnCap)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Agreement;
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
        public static bool operator ==(Agreement x, Agreement y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(Agreement x, Agreement y)
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
        protected bool HasSameNonDefaultIdAs(Agreement compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}