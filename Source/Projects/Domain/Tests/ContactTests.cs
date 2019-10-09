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
    ///This is a test class for ContactTest and is intended
    ///to contain all ContactTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Contact Repository Tests")]
    [Category("Contact Repository Tests")]
    internal class ContactTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Contact`")]
        [Order(0)]
        public void Contact_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _company_company_contacts = new DSS2_SynchromodalityCapacityOptimisation.BO.Company
            {
                Code = "Company_Code",
                Name = "Company_Name",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.Contact>(Session)
            .CheckProperty(p => p.Id, 6796)
            .CheckProperty(p => p.UserName, "d9e788f1-8b80-4321-bd54-15905ce334b5Contact_UserName")
            .CheckProperty(p => p.PasswordHash, "Contact_PasswordHash")
            .CheckProperty(p => p.SecurityStamp, "Contact_SecurityStamp")
            .CheckProperty(p => p.EmailConfirmed, true)
            .CheckProperty(p => p.LockoutEnabled, true)
            .CheckProperty(p => p.PhoneNumberConfirmed, true)
            .CheckProperty(p => p.TwoFactorEnabled, true)
            .CheckProperty(p => p.AccessFailedCount, 7590)
            .CheckProperty(p => p.Name, "Contact_Name")
            .CheckProperty(p => p.Email, "Contact_Email")
            .CheckProperty(p => p.PhoneNumber, "Contact_PhoneNumber")
            .CheckProperty(p => p.LockoutEndDate, now)
            .CheckReference(p => p.Company, _company_company_contacts)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Contact`")]
        [Order(1)]
        public void Contact_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.Contact> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Contact>(
                              a => true
                              && (a.Id + 123 > 0)
                              && (a.UserName != string.Empty && a.UserName != null)
                              && (a.PasswordHash != string.Empty && a.PasswordHash != null)
                              && (a.SecurityStamp != string.Empty && a.SecurityStamp != null)
                              && !a.EmailConfirmed
                              && !a.LockoutEnabled
                              && !a.PhoneNumberConfirmed
                              && !a.TwoFactorEnabled
                              && (a.AccessFailedCount + 123 > 0)
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.PhoneNumber != string.Empty && a.PhoneNumber != null)
                              && a.LockoutEndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.Company != null
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