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
    ///This is a test class for ScheduledRouteTest and is intended
    ///to contain all ScheduledRouteTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ScheduledRoute Repository Tests")]
    [Category("ScheduledRoute Repository Tests")]
    internal class ScheduledRouteTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ScheduledRoute`")]
        [Order(0)]
        public void ScheduledRoute_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _workcontract_workcontract_scheduledroutes = new DSS2_SynchromodalityCapacityOptimisation.BO.WorkContract
            {
                CreationDate = now,
                LastUpdate = now,
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute>(Session)
            .CheckProperty(p => p.Origin, "ScheduledRoute_Origin")
            .CheckProperty(p => p.Destination, "ScheduledRoute_Destination")
            .CheckProperty(p => p.DaysOfWeek, "ScheduledRoute_DaysOfWeek")
            .CheckProperty(p => p.PricePerPallet, 222222.22M)
            .CheckProperty(p => p.PricePerKilogram, 222222.22M)
            .CheckProperty(p => p.PricePerCubicMeter, 222222.22M)
            .CheckProperty(p => p.TotalAvailableCapacityKG, 222222.22M)
            .CheckProperty(p => p.EffectiveFrom, now)
            .CheckProperty(p => p.EffectiveTo, now)
            .CheckProperty(p => p.Revision, 5122)
            .CheckProperty(p => p.GUID, "ScheduledRoute_GUID")
            .CheckProperty(p => p.ReservedCapacityLaden, 1154)
            .CheckProperty(p => p.BaseId, 9744)
            .CheckProperty(p => p.TotalAvailableCapacityM3, 222222.22M)
            .CheckProperty(p => p.TotalAvailableCapacityLaden, 7678)
            .CheckProperty(p => p.ReservedCapacityKG, 222222.22M)
            .CheckProperty(p => p.ReservedCapacityM3, 222222.22M)
            .CheckProperty(p => p.FixedPrice, 222222.22M)
            .CheckProperty(p => p.OriginComments, "ScheduledRoute_OriginComments")
            .CheckProperty(p => p.DestinationComments, "ScheduledRoute_DestinationComments")
            .CheckProperty(p => p.TruckPlate, "ScheduledRoute_TruckPlate")
            .CheckProperty(p => p.DeliveryDate, now)
            .CheckReference(p => p.WorkContract, _workcontract_workcontract_scheduledroutes)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ScheduledRoute`")]
        [Order(1)]
        public void ScheduledRoute_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRoute>(
                              a => true
                              && (a.Origin != string.Empty && a.Origin != null)
                              && (a.Destination != string.Empty && a.Destination != null)
                              && (a.DaysOfWeek != string.Empty && a.DaysOfWeek != null)
                              && (a.PricePerPallet + 123 > 0)
                              && (a.PricePerKilogram + 123 > 0)
                              && (a.PricePerCubicMeter + 123 > 0)
                              && (a.TotalAvailableCapacityKG + 123 > 0)
                              && a.EffectiveFrom.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.EffectiveTo.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.TypeOfGoods == DSS2_SynchromodalityCapacityOptimisation.BO.TruckContent.Frozen
                              && (a.Revision + 123 > 0)
                              && (a.GUID != string.Empty && a.GUID != null)
                              && (a.ReservedCapacityLaden + 123 > 0)
                              && a.State == DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState.UnderNegotiation
                              && (a.BaseId + 123 > 0)
                              && a.Frequency == DSS2_SynchromodalityCapacityOptimisation.BO.RouteFrequency.Weekly
                              && (a.TotalAvailableCapacityM3 + 123 > 0)
                              && (a.TotalAvailableCapacityLaden + 123 > 0)
                              && (a.ReservedCapacityKG + 123 > 0)
                              && (a.ReservedCapacityM3 + 123 > 0)
                              && (a.FixedPrice + 123 > 0)
                              && (a.OriginComments != string.Empty && a.OriginComments != null)
                              && (a.DestinationComments != string.Empty && a.DestinationComments != null)
                              && (a.TruckPlate != string.Empty && a.TruckPlate != null)
                              && a.DeliveryDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.Attribute == DSS2_SynchromodalityCapacityOptimisation.BO.ScheduledRouteState.UnderNegotiation
                              && a.WorkContract != null
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