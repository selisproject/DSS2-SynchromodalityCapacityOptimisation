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
    ///This is a test class for ApplicationSettingTest and is intended
    ///to contain all ApplicationSettingTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationSetting Repository Tests")]
    [Category("ApplicationSetting Repository Tests")]
    internal class ApplicationSettingTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationSetting`")]
        [Order(0)]
        public void ApplicationSetting_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>(Session)
            .CheckProperty(p => p.Key, "ApplicationSetting_Key")
            .CheckProperty(p => p.Value, "ApplicationSetting_Value")
            .CheckProperty(p => p.IsCustom, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationSetting`")]
        [Order(1)]
        public void ApplicationSetting_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>(
                              a => true
                              && (a.Key != string.Empty && a.Key != null)
                              && (a.Value != string.Empty && a.Value != null)
                              && !a.IsCustom
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