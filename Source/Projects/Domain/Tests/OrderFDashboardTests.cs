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
    ///This is a test class for OrderFDashboardTest and is intended
    ///to contain all OrderFDashboardTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("OrderFDashboard Repository Tests")]
    [Category("OrderFDashboard Repository Tests")]
    internal class OrderFDashboardTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `OrderFDashboard`")]
        [Order(0)]
        public void OrderFDashboard_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _orderforecastdashboard_orderforecaststatistics_dashboard = new DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic
            {
                Quantity = 222222.22M,
                RoundQuantity = 9851,
                OrderDate = now,
                OrderDateFormatted = "OrderForecastStatistic_OrderDateFormatted",
            };
            var _orderforecastdashboard_orderforecaststatistics_dashboard2 = new DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic
            {
                Quantity = 222222.22M,
                RoundQuantity = 1034,
                OrderDate = now,
                OrderDateFormatted = "OrderForecastStatistic_OrderDateFormatted",
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard>(Session)
            .CheckBag(p => p.OrderForecastStatistics, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderForecastStatistic>
            {
                _orderforecastdashboard_orderforecaststatistics_dashboard,
                _orderforecastdashboard_orderforecaststatistics_dashboard2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `OrderFDashboard`")]
        [Order(1)]
        public void OrderFDashboard_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.OrderFDashboard>(
                              a => true
                              && a.OrderForecastStatistics.Any()
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