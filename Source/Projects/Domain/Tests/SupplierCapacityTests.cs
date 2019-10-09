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
    ///This is a test class for SupplierCapacityTest and is intended
    ///to contain all SupplierCapacityTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierCapacity Repository Tests")]
    [Category("SupplierCapacity Repository Tests")]
    internal class SupplierCapacityTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierCapacity`")]
        [Order(0)]
        public void SupplierCapacity_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _item_item_suppliercapacities = new DSS2_SynchromodalityCapacityOptimisation.BO.Item
            {
                SKU = "a91cc335-bdc9-4572-840b-293406335fb5Item_SKU",
                Description = "Item_Description",
                UPC = "Item_UPC",
                AvgDailyDemand = 222222.22M,
                PalletSize = 637,
                SupplierPackSize = 59,
                InnerPackSize = 6212,
                PalletType = "Item_PalletType",
                PalTI = 1799,
                PalHI = 5138,
                UOM = "Item_UOM",
            };
            var _item_supplier_suppliercapacities = new DSS2_SynchromodalityCapacityOptimisation.BO.Supplier
            {
                Code = "Supplier_Code",
                Name = "Supplier_Name",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity>(Session)
            .CheckProperty(p => p.DateOfStockUpdate, now)
            .CheckProperty(p => p.DailyProduction, 3524)
            .CheckProperty(p => p.Stock, 1752)
            .CheckReference(p => p.Item, _item_item_suppliercapacities)
            .CheckReference(p => p.Supplier, _item_supplier_suppliercapacities)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierCapacity`")]
        [Order(1)]
        public void SupplierCapacity_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity>(
                              a => true
                              && a.DateOfStockUpdate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.DailyProduction + 123 > 0)
                              && (a.Stock + 123 > 0)
                              && a.Item != null
                              && a.Supplier != null
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