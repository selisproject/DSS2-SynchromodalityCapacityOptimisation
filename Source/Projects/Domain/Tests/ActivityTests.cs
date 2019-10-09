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
    ///This is a test class for ActivityTest and is intended
    ///to contain all ActivityTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Activity Repository Tests")]
    [Category("Activity Repository Tests")]
    internal class ActivityTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Activity`")]
        [Order(0)]
        public void Activity_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _vrpsolution_order_activity = new DSS2_SynchromodalityCapacityOptimisation.BO.ShippingOrder
            {
                DepartureDate = now,
                ArrivalDate = now,
                Shipper = "ShippingOrder_Shipper",
                Carrier = "ShippingOrder_Carrier",
                ItemDescription = "ShippingOrder_ItemDescription",
                Conditions = "ShippingOrder_Conditions",
                AggregateVolume = 222222.22M,
                Priority = 9572,
            };
            var _vrpsolution_point_activity = new DSS2_SynchromodalityCapacityOptimisation.BO.Location
            {
                Name = "Location_Name",
                Street = "Location_Street",
                City = "Location_City",
                Country = "Location_Country",
                Number = "Location_Number",
                PostCode = "Location_PostCode",
                Label = "Location_Label",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.Activity>(Session)
            .CheckProperty(p => p.TravelDistance, 6404)
            .CheckProperty(p => p.TravelDuration, 7879)
            .CheckReference(p => p.Order, _vrpsolution_order_activity)
            .CheckReference(p => p.Point, _vrpsolution_point_activity)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Activity`")]
        [Order(1)]
        public void Activity_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.Activity> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Activity>(
                              a => true
                              && (a.TravelDistance + 123 > 0)
                              && (a.TravelDuration + 123 > 0)
                              && a.Order != null
                              && a.Point != null
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