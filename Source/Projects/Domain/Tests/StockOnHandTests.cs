// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using DSS2_SynchromodalityCapacityOptimisation.BoTesting.Tests.Common;
using DSS2_SynchromodalityCapacityOptimisation.DAL;

namespace DSS2_SynchromodalityCapacityOptimisation.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for StockOnHandTest and is intended
    ///to contain all StockOnHandTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("StockOnHand Repository Tests")]
    [Category("StockOnHand Repository Tests")]
    internal class StockOnHandTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `StockOnHand`")]
        [Order(0)]
        public void StockOnHand_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_agreement_stockonhands = new DSS2_SynchromodalityCapacityOptimisation.BO.Agreement
            {
                FullTruckLoad = true,
                AgreementDocument = "Agreement_AgreementDocument",
                LeadTime = "Agreement_LeadTime",
                DateCreated = now,
                WDDeliveries = true,
                TargetInventoryDays = 8036,
                Profile = "Agreement_Profile",
            };
            var _stockonhand_warehouse_stockonhand = new DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse
            {
                Code = "Warehouse_Code",
                Description = "Warehouse_Description",
                FlowType = "Warehouse_FlowType",
                Title = "Warehouse_Title",
                Address = "Warehouse_Address",
                Telephone = "Warehouse_Telephone",
            };
            var _stockonhand_item_stocksonhand = new DSS2_SynchromodalityCapacityOptimisation.BO.Item
            {
                SKU = "44a0bcff-87ce-489e-ab01-da273fbfbefbItem_SKU",
                Description = "Item_Description",
                UPC = "Item_UPC",
                AvgDailyDemand = 222222.22M,
                PalletSize = 3228,
                SupplierPackSize = 1307,
                InnerPackSize = 4503,
                PalletType = "Item_PalletType",
                PalTI = 7760,
                PalHI = 295,
                UOM = "Item_UOM",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>(Session)
            .CheckProperty(p => p.Units, 5435)
            .CheckProperty(p => p.CurrentInventoryDays, 222222.22M)
            .CheckProperty(p => p.StockOnHandDate, now)
            .CheckProperty(p => p.LeadTime, "StockOnHand_LeadTime")
            .CheckProperty(p => p.TargetInventoryDays, 222222.22M)
            .CheckProperty(p => p.FullTrackLoad, true)
            .CheckProperty(p => p.WDDays, true)
            .CheckReference(p => p.Agreement, _agreement_agreement_stockonhands)
            .CheckReference(p => p.Warehouse, _stockonhand_warehouse_stockonhand)
            .CheckReference(p => p.Item, _stockonhand_item_stocksonhand)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `StockOnHand`")]
        [Order(1)]
        public void StockOnHand_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>(
                              a => true
                              && (a.Units + 123 > 0)
                              && (a.CurrentInventoryDays + 123 > 0)
                              && a.StockOnHandDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.LeadTime != string.Empty && a.LeadTime != null)
                              && (a.TargetInventoryDays + 123 > 0)
                              && !a.FullTrackLoad
                              && !a.WDDays
                              && a.Agreement != null
                              && a.Warehouse != null
                              && a.Item != null
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}