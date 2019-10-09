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
    ///This is a test class for AgreementStatusTest and is intended
    ///to contain all AgreementStatusTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("AgreementStatus Repository Tests")]
    [Category("AgreementStatus Repository Tests")]
    internal class AgreementStatusTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `AgreementStatus`")]
        [Order(0)]
        public void AgreementStatus_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus>(Session)
            .CheckProperty(p => p.IssuedBy, "AgreementStatus_IssuedBy")
            .CheckProperty(p => p.Status, "AgreementStatus_Status")
            .CheckProperty(p => p.DateIssued, now)
            .CheckProperty(p => p.ApprovedBySonae, true)
            .CheckProperty(p => p.ApprovedBySupplier, true)
            .CheckProperty(p => p.InProgress, true)
            .CheckProperty(p => p.Active, true)
            .CheckProperty(p => p.UnderRevision, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `AgreementStatus`")]
        [Order(1)]
        public void AgreementStatus_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.AgreementStatus>(
                              a => true
                              && (a.IssuedBy != string.Empty && a.IssuedBy != null)
                              && (a.Status != string.Empty && a.Status != null)
                              && a.DateIssued.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && !a.ApprovedBySonae
                              && !a.ApprovedBySupplier
                              && !a.InProgress
                              && !a.Active
                              && !a.UnderRevision
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