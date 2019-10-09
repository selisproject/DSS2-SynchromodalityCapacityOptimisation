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
    ///This is a test class for tblZslWorkerTest and is intended
    ///to contain all tblZslWorkerTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("tblZslWorker Repository Tests")]
    [Category("tblZslWorker Repository Tests")]
    internal class tblZslWorkerTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `tblZslWorker`")]
        [Order(0)]
        public void tblZslWorker_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _zanardobo_worker_tblzslworker = new DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker
            {
                WorkerFullName = "tblZslWorker_WorkerFullName",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker>(Session)
            .CheckProperty(p => p.WorkerFullName, "tblZslWorker_WorkerFullName")
            .CheckReference(p => p.Worker, _zanardobo_worker_tblzslworker)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `tblZslWorker`")]
        [Order(1)]
        public void tblZslWorker_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.tblZslWorker>(
                              a => true
                              && (a.WorkerFullName != string.Empty && a.WorkerFullName != null)
                              && a.Worker != null
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