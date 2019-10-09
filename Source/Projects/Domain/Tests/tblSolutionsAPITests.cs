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
    ///This is a test class for tblSolutionsAPITest and is intended
    ///to contain all tblSolutionsAPITest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("tblSolutionsAPI Repository Tests")]
    [Category("tblSolutionsAPI Repository Tests")]
    internal class tblSolutionsAPITests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `tblSolutionsAPI`")]
        [Order(0)]
        public void tblSolutionsAPI_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _adriakombibo_tblroutesapi_tblsolutionsapi = new DSS2_SynchromodalityCapacityOptimisation.BO.tblRoutesAPI
            {
                EntryDate = now,
                VehicleId = "tblRoutesAPI_VehicleId",
                InitialLoads = 222222.22M,
                TotalTravelTime = 222222.22M,
                TotalDistance = 222222.22M,
                LastUpdated = now,
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI>(Session)
            .CheckProperty(p => p.EntryDate, now)
            .CheckProperty(p => p.Cost, 1481)
            .CheckProperty(p => p.Iterations, 7478)
            .CheckProperty(p => p.Unassigned, 'F')
            .CheckProperty(p => p.Elapsed, 222222.22M)
            .CheckProperty(p => p.TotalDistance, 222222.22M)
            .CheckProperty(p => p.JobId, "tblSolutionsAPI_JobId")
            .CheckProperty(p => p.LastUpdated, now)
            .CheckReference(p => p.tblRoutesAPI, _adriakombibo_tblroutesapi_tblsolutionsapi)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `tblSolutionsAPI`")]
        [Order(1)]
        public void tblSolutionsAPI_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.tblSolutionsAPI>(
                              a => true
                              && a.EntryDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.Cost + 123 > 0)
                              && (a.Iterations + 123 > 0)
                              && a.Unassigned == 'F'
                              && (a.Elapsed + 123 > 0)
                              && (a.TotalDistance + 123 > 0)
                              && (a.JobId != string.Empty && a.JobId != null)
                              && a.LastUpdated.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.tblRoutesAPI != null
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