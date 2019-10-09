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
    ///This is a test class for VolumeCompositionTest and is intended
    ///to contain all VolumeCompositionTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("VolumeComposition Repository Tests")]
    [Category("VolumeComposition Repository Tests")]
    internal class VolumeCompositionTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `VolumeComposition`")]
        [Order(0)]
        public void VolumeComposition_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _volumebo_volumecomponent_volumecomposition = new DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComponent
            {
                Name = "VolumeComponent_Name",
                StandardVolume = 222222.22M,
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition>(Session)
            .CheckProperty(p => p.Units, 4351)
            .CheckReference(p => p.VolumeComponent, _volumebo_volumecomponent_volumecomposition)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `VolumeComposition`")]
        [Order(1)]
        public void VolumeComposition_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.VolumeComposition>(
                              a => true
                              && (a.Units + 123 > 0)
                              && a.VolumeComponent != null
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