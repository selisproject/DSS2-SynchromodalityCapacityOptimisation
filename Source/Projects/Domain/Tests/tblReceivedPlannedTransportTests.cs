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
    ///This is a test class for tblReceivedPlannedTransportTest and is intended
    ///to contain all tblReceivedPlannedTransportTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("tblReceivedPlannedTransport Repository Tests")]
    [Category("tblReceivedPlannedTransport Repository Tests")]
    internal class tblReceivedPlannedTransportTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `tblReceivedPlannedTransport`")]
        [Order(0)]
        public void tblReceivedPlannedTransport_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport>(Session)
            .CheckProperty(p => p.EntryDate, now)
            .CheckProperty(p => p.transport_identifier, "tblReceivedPlannedTransport_transport_identifier")
            .CheckProperty(p => p.IsActive, true)
            .CheckProperty(p => p.LastUpdated, now)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `tblReceivedPlannedTransport`")]
        [Order(1)]
        public void tblReceivedPlannedTransport_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.tblReceivedPlannedTransport>(
                              a => true
                              && a.EntryDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.transport_identifier != string.Empty && a.transport_identifier != null)
                              && !a.IsActive
                              && a.LastUpdated.GetValueOrDefault().Date <= DateTime.UtcNow.Date
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