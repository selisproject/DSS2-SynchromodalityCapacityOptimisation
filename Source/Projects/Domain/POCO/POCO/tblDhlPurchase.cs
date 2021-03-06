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
    /// The tblDhlPurchase class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblDhlPurchase : IDomainModelClass
    {
        #region tblDhlPurchase's Fields

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
        [DataMember(Name="Purchase_ID")]
        protected long? purchase_ID = 0L;
        [DataMember(Name="PurchaseOrder")]
        protected string purchaseOrder;
        [DataMember(Name="OriginCountry")]
        protected string originCountry;
        [DataMember(Name="OriginProvince")]
        protected string originProvince;
        [DataMember(Name="OriginCity")]
        protected string originCity;
        [DataMember(Name="OriginZipCode")]
        protected string originZipCode;
        [DataMember(Name="OriginAddress")]
        protected string originAddress;
        [DataMember(Name="OriginLat")]
        protected string originLat;
        [DataMember(Name="OriginLng")]
        protected string originLng;
        [DataMember(Name="DestinationCountry")]
        protected string destinationCountry;
        [DataMember(Name="DestinationProvince")]
        protected string destinationProvince;
        [DataMember(Name="DestinationCity")]
        protected string destinationCity;
        [DataMember(Name="DestinationZipCode")]
        protected string destinationZipCode;
        [DataMember(Name="DestinationAddress")]
        protected string destinationAddress;
        [DataMember(Name="DestinationName")]
        protected string destinationName;
        [DataMember(Name="DestinationLat")]
        protected string destinationLat;
        [DataMember(Name="DestinationLng")]
        protected string destinationLng;
        [DataMember(Name="RouteNumber")]
        protected string routeNumber;
        [DataMember(Name="RouteType")]
        protected string routeType;
        [DataMember(Name="FlowType")]
        protected string flowType;
        [DataMember(Name="NumberOfStops")]
        protected string numberOfStops;
        [DataMember(Name="LoadingType")]
        protected string loadingType;
        [DataMember(Name="Master")]
        protected string master;
        [DataMember(Name="RouteKm")]
        protected decimal? routeKm;
        [DataMember(Name="SupplierName")]
        protected string supplierName;
        [DataMember(Name="TaxIdentificationNumberSupplier")]
        protected string taxIdentificationNumberSupplier;
        [DataMember(Name="OracleSupplier")]
        protected string oracleSupplier;
        [DataMember(Name="CustomerName")]
        protected string customerName;
        [DataMember(Name="TaxIdentificationNumberCustomer")]
        protected string taxIdentificationNumberCustomer;
        [DataMember(Name="OracleCustomer")]
        protected string oracleCustomer;
        [DataMember(Name="TotalUtilizationTruck")]
        protected string totalUtilizationTruck;
        [DataMember(Name="NumberOfPallets")]
        protected int? numberOfPallets;
        [DataMember(Name="OrderM3")]
        protected decimal? orderM3;
        [DataMember(Name="OrderKgs")]
        protected decimal? orderKgs;
        [DataMember(Name="LoadingDateTime")]
        protected DateTime? loadingDateTime;
        [DataMember(Name="DeliveryDateTime")]
        protected DateTime? deliveryDateTime;
        [DataMember(Name="EntryIngress")]
        protected int? entryIngress;
        [DataMember(Name="Cost")]
        protected decimal? cost;
        [DataMember(Name="AbsolutMargin")]
        protected int? absolutMargin;
        [DataMember(Name="Margin")]
        protected int? margin;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblDhlPurchase's Properties
/// <summary>
/// The Purchase_ID property
///
/// </summary>
///
        [Key]
        public virtual long? Purchase_ID
        {
            get
            {
                return purchase_ID;
            }
            set
            {
                purchase_ID = value;
            }
        }
/// <summary>
/// The PurchaseOrder property
///
/// </summary>
///
        public virtual string PurchaseOrder
        {
            get
            {
                return purchaseOrder;
            }
            set
            {
                purchaseOrder = value;
            }
        }
/// <summary>
/// The OriginCountry property
///
/// </summary>
///
        public virtual string OriginCountry
        {
            get
            {
                return originCountry;
            }
            set
            {
                originCountry = value;
            }
        }
/// <summary>
/// The OriginProvince property
///
/// </summary>
///
        public virtual string OriginProvince
        {
            get
            {
                return originProvince;
            }
            set
            {
                originProvince = value;
            }
        }
/// <summary>
/// The OriginCity property
///
/// </summary>
///
        public virtual string OriginCity
        {
            get
            {
                return originCity;
            }
            set
            {
                originCity = value;
            }
        }
/// <summary>
/// The OriginZipCode property
///
/// </summary>
///
        public virtual string OriginZipCode
        {
            get
            {
                return originZipCode;
            }
            set
            {
                originZipCode = value;
            }
        }
/// <summary>
/// The OriginAddress property
///
/// </summary>
///
        public virtual string OriginAddress
        {
            get
            {
                return originAddress;
            }
            set
            {
                originAddress = value;
            }
        }
/// <summary>
/// The OriginLat property
///
/// </summary>
///
        public virtual string OriginLat
        {
            get
            {
                return originLat;
            }
            set
            {
                originLat = value;
            }
        }
/// <summary>
/// The OriginLng property
///
/// </summary>
///
        public virtual string OriginLng
        {
            get
            {
                return originLng;
            }
            set
            {
                originLng = value;
            }
        }
/// <summary>
/// The DestinationCountry property
///
/// </summary>
///
        public virtual string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                destinationCountry = value;
            }
        }
/// <summary>
/// The DestinationProvince property
///
/// </summary>
///
        public virtual string DestinationProvince
        {
            get
            {
                return destinationProvince;
            }
            set
            {
                destinationProvince = value;
            }
        }
/// <summary>
/// The DestinationCity property
///
/// </summary>
///
        public virtual string DestinationCity
        {
            get
            {
                return destinationCity;
            }
            set
            {
                destinationCity = value;
            }
        }
/// <summary>
/// The DestinationZipCode property
///
/// </summary>
///
        public virtual string DestinationZipCode
        {
            get
            {
                return destinationZipCode;
            }
            set
            {
                destinationZipCode = value;
            }
        }
/// <summary>
/// The DestinationAddress property
///
/// </summary>
///
        public virtual string DestinationAddress
        {
            get
            {
                return destinationAddress;
            }
            set
            {
                destinationAddress = value;
            }
        }
/// <summary>
/// The DestinationName property
///
/// </summary>
///
        public virtual string DestinationName
        {
            get
            {
                return destinationName;
            }
            set
            {
                destinationName = value;
            }
        }
/// <summary>
/// The DestinationLat property
///
/// </summary>
///
        public virtual string DestinationLat
        {
            get
            {
                return destinationLat;
            }
            set
            {
                destinationLat = value;
            }
        }
/// <summary>
/// The DestinationLng property
///
/// </summary>
///
        public virtual string DestinationLng
        {
            get
            {
                return destinationLng;
            }
            set
            {
                destinationLng = value;
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
/// The RouteType property
///
/// </summary>
///
        public virtual string RouteType
        {
            get
            {
                return routeType;
            }
            set
            {
                routeType = value;
            }
        }
/// <summary>
/// The FlowType property
///
/// </summary>
///
        public virtual string FlowType
        {
            get
            {
                return flowType;
            }
            set
            {
                flowType = value;
            }
        }
/// <summary>
/// The NumberOfStops property
///
/// </summary>
///
        public virtual string NumberOfStops
        {
            get
            {
                return numberOfStops;
            }
            set
            {
                numberOfStops = value;
            }
        }
/// <summary>
/// The LoadingType property
///
/// </summary>
///
        public virtual string LoadingType
        {
            get
            {
                return loadingType;
            }
            set
            {
                loadingType = value;
            }
        }
/// <summary>
/// The Master property
///
/// </summary>
///
        public virtual string Master
        {
            get
            {
                return master;
            }
            set
            {
                master = value;
            }
        }
/// <summary>
/// The RouteKm property
///
/// </summary>
///
        public virtual decimal? RouteKm
        {
            get
            {
                return routeKm;
            }
            set
            {
                routeKm = value;
            }
        }
/// <summary>
/// The SupplierName property
///
/// </summary>
///
        public virtual string SupplierName
        {
            get
            {
                return supplierName;
            }
            set
            {
                supplierName = value;
            }
        }
/// <summary>
/// The TaxIdentificationNumberSupplier property
///
/// </summary>
///
        public virtual string TaxIdentificationNumberSupplier
        {
            get
            {
                return taxIdentificationNumberSupplier;
            }
            set
            {
                taxIdentificationNumberSupplier = value;
            }
        }
/// <summary>
/// The OracleSupplier property
///
/// </summary>
///
        public virtual string OracleSupplier
        {
            get
            {
                return oracleSupplier;
            }
            set
            {
                oracleSupplier = value;
            }
        }
/// <summary>
/// The CustomerName property
///
/// </summary>
///
        public virtual string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
/// <summary>
/// The TaxIdentificationNumberCustomer property
///
/// </summary>
///
        public virtual string TaxIdentificationNumberCustomer
        {
            get
            {
                return taxIdentificationNumberCustomer;
            }
            set
            {
                taxIdentificationNumberCustomer = value;
            }
        }
/// <summary>
/// The OracleCustomer property
///
/// </summary>
///
        public virtual string OracleCustomer
        {
            get
            {
                return oracleCustomer;
            }
            set
            {
                oracleCustomer = value;
            }
        }
/// <summary>
/// The TotalUtilizationTruck property
///
/// </summary>
///
        public virtual string TotalUtilizationTruck
        {
            get
            {
                return totalUtilizationTruck;
            }
            set
            {
                totalUtilizationTruck = value;
            }
        }
/// <summary>
/// The NumberOfPallets property
///
/// </summary>
///
        public virtual int? NumberOfPallets
        {
            get
            {
                return numberOfPallets;
            }
            set
            {
                numberOfPallets = value;
            }
        }
/// <summary>
/// The OrderM3 property
///
/// </summary>
///
        public virtual decimal? OrderM3
        {
            get
            {
                return orderM3;
            }
            set
            {
                orderM3 = value;
            }
        }
/// <summary>
/// The OrderKgs property
///
/// </summary>
///
        public virtual decimal? OrderKgs
        {
            get
            {
                return orderKgs;
            }
            set
            {
                orderKgs = value;
            }
        }
/// <summary>
/// The LoadingDateTime property
///
/// </summary>
///
        public virtual DateTime? LoadingDateTime
        {
            get
            {
                return loadingDateTime;
            }
            set
            {
                loadingDateTime = value;
            }
        }
/// <summary>
/// The DeliveryDateTime property
///
/// </summary>
///
        public virtual DateTime? DeliveryDateTime
        {
            get
            {
                return deliveryDateTime;
            }
            set
            {
                deliveryDateTime = value;
            }
        }
/// <summary>
/// The EntryIngress property
///
/// </summary>
///
        public virtual int? EntryIngress
        {
            get
            {
                return entryIngress;
            }
            set
            {
                entryIngress = value;
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
/// The AbsolutMargin property
///
/// </summary>
///
        public virtual int? AbsolutMargin
        {
            get
            {
                return absolutMargin;
            }
            set
            {
                absolutMargin = value;
            }
        }
/// <summary>
/// The Margin property
///
/// </summary>
///
        public virtual int? Margin
        {
            get
            {
                return margin;
            }
            set
            {
                margin = value;
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
/// Public constructors of the tblDhlPurchase class
/// </summary>
/// <returns>New tblDhlPurchase object</returns>
/// <remarks></remarks>
        public tblDhlPurchase() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Purchase_ID == null)
            {
                __errors.Add("Property 'Purchase_ID' is required.");
            }
            if (PurchaseOrder != null && PurchaseOrder.Length > 100)
            {
                __errors.Add("Length of property 'PurchaseOrder' cannot be greater than 100.");
            }
            if (OriginCountry != null && OriginCountry.Length > 100)
            {
                __errors.Add("Length of property 'OriginCountry' cannot be greater than 100.");
            }
            if (OriginProvince != null && OriginProvince.Length > 100)
            {
                __errors.Add("Length of property 'OriginProvince' cannot be greater than 100.");
            }
            if (OriginCity != null && OriginCity.Length > 100)
            {
                __errors.Add("Length of property 'OriginCity' cannot be greater than 100.");
            }
            if (OriginZipCode != null && OriginZipCode.Length > 100)
            {
                __errors.Add("Length of property 'OriginZipCode' cannot be greater than 100.");
            }
            if (OriginAddress != null && OriginAddress.Length > 100)
            {
                __errors.Add("Length of property 'OriginAddress' cannot be greater than 100.");
            }
            if (OriginLat != null && OriginLat.Length > 100)
            {
                __errors.Add("Length of property 'OriginLat' cannot be greater than 100.");
            }
            if (OriginLng != null && OriginLng.Length > 100)
            {
                __errors.Add("Length of property 'OriginLng' cannot be greater than 100.");
            }
            if (DestinationCountry != null && DestinationCountry.Length > 100)
            {
                __errors.Add("Length of property 'DestinationCountry' cannot be greater than 100.");
            }
            if (DestinationProvince != null && DestinationProvince.Length > 100)
            {
                __errors.Add("Length of property 'DestinationProvince' cannot be greater than 100.");
            }
            if (DestinationCity != null && DestinationCity.Length > 100)
            {
                __errors.Add("Length of property 'DestinationCity' cannot be greater than 100.");
            }
            if (DestinationZipCode != null && DestinationZipCode.Length > 100)
            {
                __errors.Add("Length of property 'DestinationZipCode' cannot be greater than 100.");
            }
            if (DestinationAddress != null && DestinationAddress.Length > 100)
            {
                __errors.Add("Length of property 'DestinationAddress' cannot be greater than 100.");
            }
            if (DestinationName != null && DestinationName.Length > 100)
            {
                __errors.Add("Length of property 'DestinationName' cannot be greater than 100.");
            }
            if (DestinationLat != null && DestinationLat.Length > 100)
            {
                __errors.Add("Length of property 'DestinationLat' cannot be greater than 100.");
            }
            if (DestinationLng != null && DestinationLng.Length > 100)
            {
                __errors.Add("Length of property 'DestinationLng' cannot be greater than 100.");
            }
            if (RouteNumber != null && RouteNumber.Length > 100)
            {
                __errors.Add("Length of property 'RouteNumber' cannot be greater than 100.");
            }
            if (RouteType != null && RouteType.Length > 100)
            {
                __errors.Add("Length of property 'RouteType' cannot be greater than 100.");
            }
            if (FlowType != null && FlowType.Length > 100)
            {
                __errors.Add("Length of property 'FlowType' cannot be greater than 100.");
            }
            if (NumberOfStops != null && NumberOfStops.Length > 100)
            {
                __errors.Add("Length of property 'NumberOfStops' cannot be greater than 100.");
            }
            if (LoadingType != null && LoadingType.Length > 100)
            {
                __errors.Add("Length of property 'LoadingType' cannot be greater than 100.");
            }
            if (Master != null && Master.Length > 100)
            {
                __errors.Add("Length of property 'Master' cannot be greater than 100.");
            }
            if (SupplierName != null && SupplierName.Length > 100)
            {
                __errors.Add("Length of property 'SupplierName' cannot be greater than 100.");
            }
            if (TaxIdentificationNumberSupplier != null && TaxIdentificationNumberSupplier.Length > 100)
            {
                __errors.Add("Length of property 'TaxIdentificationNumberSupplier' cannot be greater than 100.");
            }
            if (OracleSupplier != null && OracleSupplier.Length > 100)
            {
                __errors.Add("Length of property 'OracleSupplier' cannot be greater than 100.");
            }
            if (CustomerName != null && CustomerName.Length > 100)
            {
                __errors.Add("Length of property 'CustomerName' cannot be greater than 100.");
            }
            if (TaxIdentificationNumberCustomer != null && TaxIdentificationNumberCustomer.Length > 100)
            {
                __errors.Add("Length of property 'TaxIdentificationNumberCustomer' cannot be greater than 100.");
            }
            if (OracleCustomer != null && OracleCustomer.Length > 100)
            {
                __errors.Add("Length of property 'OracleCustomer' cannot be greater than 100.");
            }
            if (TotalUtilizationTruck != null && TotalUtilizationTruck.Length > 100)
            {
                __errors.Add("Length of property 'TotalUtilizationTruck' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblDhlPurchase' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Purchase_ID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PurchaseOrder?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginCountry?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginProvince?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginCity?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginZipCode?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginAddress?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginLat?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OriginLng?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationCountry?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationProvince?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationCity?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationZipCode?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationAddress?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationName?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationLat?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DestinationLng?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteNumber?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (FlowType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (NumberOfStops?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LoadingType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Master?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteKm?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (SupplierName?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TaxIdentificationNumberSupplier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OracleSupplier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CustomerName?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TaxIdentificationNumberCustomer?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OracleCustomer?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalUtilizationTruck?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (NumberOfPallets?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OrderM3?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OrderKgs?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (LoadingDateTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DeliveryDateTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EntryIngress?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Cost?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AbsolutMargin?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Margin?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblDhlPurchase] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblDhlPurchase Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblDhlPurchase copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblDhlPurchase)copiedObjects[this];
            copy = copy ?? new tblDhlPurchase();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Purchase_ID = this.Purchase_ID;
            }
            copy.PurchaseOrder = this.PurchaseOrder;
            copy.OriginCountry = this.OriginCountry;
            copy.OriginProvince = this.OriginProvince;
            copy.OriginCity = this.OriginCity;
            copy.OriginZipCode = this.OriginZipCode;
            copy.OriginAddress = this.OriginAddress;
            copy.OriginLat = this.OriginLat;
            copy.OriginLng = this.OriginLng;
            copy.DestinationCountry = this.DestinationCountry;
            copy.DestinationProvince = this.DestinationProvince;
            copy.DestinationCity = this.DestinationCity;
            copy.DestinationZipCode = this.DestinationZipCode;
            copy.DestinationAddress = this.DestinationAddress;
            copy.DestinationName = this.DestinationName;
            copy.DestinationLat = this.DestinationLat;
            copy.DestinationLng = this.DestinationLng;
            copy.RouteNumber = this.RouteNumber;
            copy.RouteType = this.RouteType;
            copy.FlowType = this.FlowType;
            copy.NumberOfStops = this.NumberOfStops;
            copy.LoadingType = this.LoadingType;
            copy.Master = this.Master;
            copy.RouteKm = this.RouteKm;
            copy.SupplierName = this.SupplierName;
            copy.TaxIdentificationNumberSupplier = this.TaxIdentificationNumberSupplier;
            copy.OracleSupplier = this.OracleSupplier;
            copy.CustomerName = this.CustomerName;
            copy.TaxIdentificationNumberCustomer = this.TaxIdentificationNumberCustomer;
            copy.OracleCustomer = this.OracleCustomer;
            copy.TotalUtilizationTruck = this.TotalUtilizationTruck;
            copy.NumberOfPallets = this.NumberOfPallets;
            copy.OrderM3 = this.OrderM3;
            copy.OrderKgs = this.OrderKgs;
            copy.LoadingDateTime = this.LoadingDateTime;
            copy.DeliveryDateTime = this.DeliveryDateTime;
            copy.EntryIngress = this.EntryIngress;
            copy.Cost = this.Cost;
            copy.AbsolutMargin = this.AbsolutMargin;
            copy.Margin = this.Margin;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblDhlPurchase;
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
        public static bool operator ==(tblDhlPurchase x, tblDhlPurchase y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblDhlPurchase x, tblDhlPurchase y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Purchase_ID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Purchase_ID.GetHashCode();
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
            return this.Purchase_ID == default(long) || this.Purchase_ID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblDhlPurchase compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Purchase_ID.Equals(compareTo.Purchase_ID);
        }

        #endregion


    }
}
