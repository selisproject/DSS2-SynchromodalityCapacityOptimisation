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
    ///This is a test class for RouteTest and is intended
    ///to contain all RouteTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Route Repository Tests")]
    [Category("Route Repository Tests")]
    internal class RouteTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Route`")]
        [Order(0)]
        public void Route_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _vrpsolution_vehicule_routes = new DSS2_SynchromodalityCapacityOptimisation.BO.Shipment
            {
                Owner = "Shipment_Owner",
                DepartureTime = now,
                CurrentStatus = "Shipment_CurrentStatus",
                Temperature = "Shipment_Temperature",
                LoadPercentage = 9331,
                TotalVolume = 222222.22M,
                AverageVolume = 222222.22M,
                MaxTravelTime = 6414,
            };
            var _vrpsolution_activities_routes = new DSS2_SynchromodalityCapacityOptimisation.BO.Activity
            {
                TravelDistance = 1758,
                TravelDuration = 9114,
            };
            var _vrpsolution_activities_routes2 = new DSS2_SynchromodalityCapacityOptimisation.BO.Activity
            {
                TravelDistance = 4598,
                TravelDuration = 6677,
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.Route>(Session)
            .CheckProperty(p => p.TotalTime, 45)
            .CheckProperty(p => p.TotalDistance, 8487)
            .CheckReference(p => p.Vehicule, _vrpsolution_vehicule_routes)
            .CheckBag(p => p.Activities, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.Activity>
            {
                _vrpsolution_activities_routes,
                _vrpsolution_activities_routes2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Route`")]
        [Order(1)]
        public void Route_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.Route> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Route>(
                              a => true
                              && (a.TotalTime + 123 > 0)
                              && (a.TotalDistance + 123 > 0)
                              && a.Vehicule != null
                              && a.Activities.Any()
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