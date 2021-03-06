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
    ///This is a test class for BusinessUnitTest and is intended
    ///to contain all BusinessUnitTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("BusinessUnit Repository Tests")]
    [Category("BusinessUnit Repository Tests")]
    internal class BusinessUnitTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `BusinessUnit`")]
        [Order(0)]
        public void BusinessUnit_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _hierarchy_categories_businessunit = new DSS2_SynchromodalityCapacityOptimisation.BO.Category
            {
                Number = 449,
                Description = "Category_Description",
            };
            var _hierarchy_categories_businessunit2 = new DSS2_SynchromodalityCapacityOptimisation.BO.Category
            {
                Number = 728,
                Description = "Category_Description",
            };
            var _supplier_supplier_businessunit = new DSS2_SynchromodalityCapacityOptimisation.BO.Supplier
            {
                Code = "Supplier_Code",
                Name = "Supplier_Name",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit>(Session)
            .CheckProperty(p => p.Number, 7351)
            .CheckProperty(p => p.Description, "BusinessUnit_Description")
            .CheckBag(p => p.Categories, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.Category>
            {
                _hierarchy_categories_businessunit,
                _hierarchy_categories_businessunit2
            }))
            .CheckReference(p => p.Supplier, _supplier_supplier_businessunit)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `BusinessUnit`")]
        [Order(1)]
        public void BusinessUnit_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit>(
                              a => true
                              && (a.Number + 123 > 0)
                              && (a.Description != string.Empty && a.Description != null)
                              && a.Categories.Any()
                              && a.Supplier != null
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