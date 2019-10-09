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
    ///This is a test class for DeliveryScheduleTest and is intended
    ///to contain all DeliveryScheduleTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("DeliverySchedule Repository Tests")]
    [Category("DeliverySchedule Repository Tests")]
    internal class DeliveryScheduleTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `DeliverySchedule`")]
        [Order(0)]
        public void DeliverySchedule_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _forecast_supplier_deliveryschedules = new DSS2_SynchromodalityCapacityOptimisation.BO.Supplier
            {
                Code = "Supplier_Code",
                Name = "Supplier_Name",
            };
            var _forecast_item_deliveryschedules = new DSS2_SynchromodalityCapacityOptimisation.BO.Item
            {
                SKU = "f21a47e0-91d9-4498-a8b7-ee5d95c31fe7Item_SKU",
                Description = "Item_Description",
                UPC = "Item_UPC",
                AvgDailyDemand = 222222.22M,
                PalletSize = 4543,
                SupplierPackSize = 4469,
                InnerPackSize = 3900,
                PalletType = "Item_PalletType",
                PalTI = 4022,
                PalHI = 6140,
                UOM = "Item_UOM",
            };
            var _forecast_warehouse_deliveryschedules = new DSS2_SynchromodalityCapacityOptimisation.BO.Warehouse
            {
                Code = "Warehouse_Code",
                Description = "Warehouse_Description",
                FlowType = "Warehouse_FlowType",
                Title = "Warehouse_Title",
                Address = "Warehouse_Address",
                Telephone = "Warehouse_Telephone",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule>(Session)
            .CheckProperty(p => p.LeadTime, 5042)
            .CheckProperty(p => p.Weekday, 8172)
            .CheckProperty(p => p.NameOfDay, "DeliverySchedule_NameOfDay")
            .CheckProperty(p => p.DBWeekday, 2445)
            .CheckReference(p => p.Supplier, _forecast_supplier_deliveryschedules)
            .CheckReference(p => p.Item, _forecast_item_deliveryschedules)
            .CheckReference(p => p.Warehouse, _forecast_warehouse_deliveryschedules)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `DeliverySchedule`")]
        [Order(1)]
        public void DeliverySchedule_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule>(
                              a => true
                              && (a.LeadTime + 123 > 0)
                              && (a.Weekday + 123 > 0)
                              && (a.NameOfDay != string.Empty && a.NameOfDay != null)
                              && (a.DBWeekday + 123 > 0)
                              && a.Supplier != null
                              && a.Item != null
                              && a.Warehouse != null
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