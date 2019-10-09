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
    ///This is a test class for ApplicationUserClaimTest and is intended
    ///to contain all ApplicationUserClaimTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationUserClaim Repository Tests")]
    [Category("ApplicationUserClaim Repository Tests")]
    internal class ApplicationUserClaimTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationUserClaim`")]
        [Order(0)]
        public void ApplicationUserClaim_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_user_claims = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser
            {
                UserName = "b0e0ab34-e3a2-4199-bb5c-75d735d4e32bApplicationUser_UserName",
                PasswordHash = "ApplicationUser_PasswordHash",
                SecurityStamp = "ApplicationUser_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 8382,
                Name = "ApplicationUser_Name",
                Email = "ApplicationUser_Email",
                PhoneNumber = "ApplicationUser_PhoneNumber",
                LockoutEndDate = now,
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim>(Session)
            .CheckProperty(p => p.ClaimType, "ApplicationUserClaim_ClaimType")
            .CheckProperty(p => p.ClaimValue, "ApplicationUserClaim_ClaimValue")
            .CheckProperty(p => p.ClaimValueType, "ApplicationUserClaim_ClaimValueType")
            .CheckProperty(p => p.Issuer, "ApplicationUserClaim_Issuer")
            .CheckProperty(p => p.OriginalIssuer, "ApplicationUserClaim_OriginalIssuer")
            .CheckReference(p => p.User, _applicationsystembo_user_claims)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationUserClaim`")]
        [Order(1)]
        public void ApplicationUserClaim_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim>(
                              a => true
                              && (a.ClaimType != string.Empty && a.ClaimType != null)
                              && (a.ClaimValue != string.Empty && a.ClaimValue != null)
                              && (a.ClaimValueType != string.Empty && a.ClaimValueType != null)
                              && (a.Issuer != string.Empty && a.Issuer != null)
                              && (a.OriginalIssuer != string.Empty && a.OriginalIssuer != null)
                              && a.User != null
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