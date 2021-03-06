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
    ///This is a test class for ItemTest and is intended
    ///to contain all ItemTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Item Repository Tests")]
    [Category("Item Repository Tests")]
    internal class ItemTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Item`")]
        [Order(0)]
        public void Item_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_agreements_items = new DSS2_SynchromodalityCapacityOptimisation.BO.Agreement
            {
                FullTruckLoad = true,
                AgreementDocument = "Agreement_AgreementDocument",
                LeadTime = "Agreement_LeadTime",
                DateCreated = now,
                WDDeliveries = true,
                TargetInventoryDays = 7095,
                Profile = "Agreement_Profile",
            };
            var _agreement_agreements_items2 = new DSS2_SynchromodalityCapacityOptimisation.BO.Agreement
            {
                FullTruckLoad = true,
                AgreementDocument = "Agreement_AgreementDocument",
                LeadTime = "Agreement_LeadTime",
                DateCreated = now,
                WDDeliveries = true,
                TargetInventoryDays = 8105,
                Profile = "Agreement_Profile",
            };
            var _forecast_deliveryschedules_item = new DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule
            {
                LeadTime = 7790,
                Weekday = 9583,
                NameOfDay = "DeliverySchedule_NameOfDay",
                DBWeekday = 7955,
            };
            var _forecast_deliveryschedules_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule
            {
                LeadTime = 5995,
                Weekday = 4935,
                NameOfDay = "DeliverySchedule_NameOfDay",
                DBWeekday = 6679,
            };
            var _inventoryitem_inventoryitems_item = new DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem
            {
                CoverageDays = 8493,
                SafetyStock = 7740,
                Status = "InventoryItem_Status",
            };
            var _inventoryitem_inventoryitems_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem
            {
                CoverageDays = 7152,
                SafetyStock = 4404,
                Status = "InventoryItem_Status",
            };
            var _item_suppliercapacities_item = new DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity
            {
                DateOfStockUpdate = now,
                DailyProduction = 1807,
                Stock = 5,
            };
            var _item_suppliercapacities_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity
            {
                DateOfStockUpdate = now,
                DailyProduction = 9191,
                Stock = 5937,
            };
            var _item_supplier_items = new DSS2_SynchromodalityCapacityOptimisation.BO.Supplier
            {
                Code = "Supplier_Code",
                Name = "Supplier_Name",
            };
            var _item_businessunit_item = new DSS2_SynchromodalityCapacityOptimisation.BO.BusinessUnit
            {
                Number = 1593,
                Description = "BusinessUnit_Description",
            };
            var _item_category_item = new DSS2_SynchromodalityCapacityOptimisation.BO.Category
            {
                Number = 2274,
                Description = "Category_Description",
            };
            var _item_subcategory_item = new DSS2_SynchromodalityCapacityOptimisation.BO.SubCategory
            {
                Number = 4550,
                Description = "SubCategory_Description",
            };
            var _item_baseunit_item = new DSS2_SynchromodalityCapacityOptimisation.BO.BaseUnit
            {
                Number = 8152,
                Description = "BaseUnit_Description",
            };
            var _minimumquantity_minimumquantity_item = new DSS2_SynchromodalityCapacityOptimisation.BO.MinimumQuantity
            {
                Country = "MinimumQuantity_Country",
                Quantity = 6282,
            };
            var _notification_notifications_item = new DSS2_SynchromodalityCapacityOptimisation.BO.Notification
            {
                Message = "Notification_Message",
                TotalSupplierStock = 3571,
                OrderForecastQuantity = 6353,
                Diff = 6734,
                SalesForecastDate = now,
                CreatedBy = "Notification_CreatedBy",
            };
            var _notification_notifications_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.Notification
            {
                Message = "Notification_Message",
                TotalSupplierStock = 3331,
                OrderForecastQuantity = 5322,
                Diff = 6857,
                SalesForecastDate = now,
                CreatedBy = "Notification_CreatedBy",
            };
            var _pastorder_pastorders_item = new DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder
            {
                OrderNumber = 8722,
                WrittenDate = now,
                NotBeforeDate = now,
                QuantityOrdered = 9192,
                ReceiveDate = now,
                QuantityReceived = 1671,
                Caller = "PastOrder_Caller",
            };
            var _pastorder_pastorders_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder
            {
                OrderNumber = 1690,
                WrittenDate = now,
                NotBeforeDate = now,
                QuantityOrdered = 5377,
                ReceiveDate = now,
                QuantityReceived = 5090,
                Caller = "PastOrder_Caller",
            };
            var _sale_itemsforecast_item = new DSS2_SynchromodalityCapacityOptimisation.BO.Sales
            {
                ForecastDate = now,
                Units = 6752,
            };
            var _sale_itemsforecast_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.Sales
            {
                ForecastDate = now,
                Units = 5349,
            };
            var _sla_slaleadtimes_item = new DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime
            {
                AgreedLeadTime = 1272,
                RealLeadTime = 928,
                Percentage = 222222.22M,
                ItemDescription = "SLALeadTime_ItemDescription",
                DateFormatted = "SLALeadTime_DateFormatted",
                Threshold = 222222.22M,
                SLALeadDate = now,
                Month = 3347,
                MonthlyDelayed = 222222.22M,
                MontlhyOrders = 222222.22M,
                MonthlyPercentage = 222222.22M,
            };
            var _sla_slaleadtimes_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime
            {
                AgreedLeadTime = 5733,
                RealLeadTime = 6575,
                Percentage = 222222.22M,
                ItemDescription = "SLALeadTime_ItemDescription",
                DateFormatted = "SLALeadTime_DateFormatted",
                Threshold = 222222.22M,
                SLALeadDate = now,
                Month = 7264,
                MonthlyDelayed = 222222.22M,
                MontlhyOrders = 222222.22M,
                MonthlyPercentage = 222222.22M,
            };
            var _sla_sladeliveries_item = new DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery
            {
                OrderedQuantities = 222222.22M,
                DeliveredQuantities = 222222.22M,
                Percentage = 222222.22M,
                ItemDescription = "SLADelivery_ItemDescription",
                Threshold = 222222.22M,
                SLADate = now,
                DateFormatted = "SLADelivery_DateFormatted",
                Month = 3292,
            };
            var _sla_sladeliveries_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery
            {
                OrderedQuantities = 222222.22M,
                DeliveredQuantities = 222222.22M,
                Percentage = 222222.22M,
                ItemDescription = "SLADelivery_ItemDescription",
                Threshold = 222222.22M,
                SLADate = now,
                DateFormatted = "SLADelivery_DateFormatted",
                Month = 8638,
            };
            var _stockonhand_stocksonhand_item = new DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand
            {
                Units = 2708,
                CurrentInventoryDays = 222222.22M,
                StockOnHandDate = now,
                LeadTime = "StockOnHand_LeadTime",
                TargetInventoryDays = 222222.22M,
                FullTrackLoad = true,
                WDDays = true,
            };
            var _stockonhand_stocksonhand_item2 = new DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand
            {
                Units = 3575,
                CurrentInventoryDays = 222222.22M,
                StockOnHandDate = now,
                LeadTime = "StockOnHand_LeadTime",
                TargetInventoryDays = 222222.22M,
                FullTrackLoad = true,
                WDDays = true,
            };
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.Item>(Session)
            .CheckProperty(p => p.SKU, "4e556bfc-8487-4c7a-aed5-ebbaa665375aItem_SKU")
            .CheckProperty(p => p.Description, "Item_Description")
            .CheckProperty(p => p.UPC, "Item_UPC")
            .CheckProperty(p => p.AvgDailyDemand, 222222.22M)
            .CheckProperty(p => p.PalletSize, 2948)
            .CheckProperty(p => p.SupplierPackSize, 5806)
            .CheckProperty(p => p.InnerPackSize, 5288)
            .CheckProperty(p => p.PalletType, "Item_PalletType")
            .CheckProperty(p => p.PalTI, 6629)
            .CheckProperty(p => p.PalHI, 9340)
            .CheckProperty(p => p.UOM, "Item_UOM")
            .CheckBag(p => p.Agreements, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.Agreement>
            {
                _agreement_agreements_items,
                _agreement_agreements_items2
            }))
            .CheckBag(p => p.DeliverySchedules, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.DeliverySchedule>
            {
                _forecast_deliveryschedules_item,
                _forecast_deliveryschedules_item2
            }))
            .CheckBag(p => p.InventoryItems, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.InventoryItem>
            {
                _inventoryitem_inventoryitems_item,
                _inventoryitem_inventoryitems_item2
            }))
            .CheckBag(p => p.SupplierCapacities, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.SupplierCapacity>
            {
                _item_suppliercapacities_item,
                _item_suppliercapacities_item2
            }))
            .CheckReference(p => p.Supplier, _item_supplier_items)
            .CheckReference(p => p.BusinessUnit, _item_businessunit_item)
            .CheckReference(p => p.Category, _item_category_item)
            .CheckReference(p => p.SubCategory, _item_subcategory_item)
            .CheckReference(p => p.BaseUnit, _item_baseunit_item)
            .CheckReference(p => p.MinimumQuantity, _minimumquantity_minimumquantity_item)
            .CheckBag(p => p.Notifications, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.Notification>
            {
                _notification_notifications_item,
                _notification_notifications_item2
            }))
            .CheckBag(p => p.PastOrders, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.PastOrder>
            {
                _pastorder_pastorders_item,
                _pastorder_pastorders_item2
            }))
            .CheckBag(p => p.ItemsForecast, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.Sales>
            {
                _sale_itemsforecast_item,
                _sale_itemsforecast_item2
            }))
            .CheckBag(p => p.SLALeadTimes, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.SLALeadTime>
            {
                _sla_slaleadtimes_item,
                _sla_slaleadtimes_item2
            }))
            .CheckBag(p => p.SLADeliveries, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.SLADelivery>
            {
                _sla_sladeliveries_item,
                _sla_sladeliveries_item2
            }))
            .CheckBag(p => p.StocksOnHand, (new List<DSS2_SynchromodalityCapacityOptimisation.BO.StockOnHand>
            {
                _stockonhand_stocksonhand_item,
                _stockonhand_stocksonhand_item2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Item`")]
        [Order(1)]
        public void Item_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.Item> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.Item>(
                              a => true
                              && (a.SKU != string.Empty && a.SKU != null)
                              && (a.Description != string.Empty && a.Description != null)
                              && (a.UPC != string.Empty && a.UPC != null)
                              && (a.AvgDailyDemand + 123 > 0)
                              && (a.PalletSize + 123 > 0)
                              && (a.SupplierPackSize + 123 > 0)
                              && (a.InnerPackSize + 123 > 0)
                              && (a.PalletType != string.Empty && a.PalletType != null)
                              && (a.PalTI + 123 > 0)
                              && (a.PalHI + 123 > 0)
                              && (a.UOM != string.Empty && a.UOM != null)
                              && a.Agreements.Any()
                              && a.DeliverySchedules.Any()
                              && a.InventoryItems.Any()
                              && a.SupplierCapacities.Any()
                              && a.Supplier != null
                              && a.BusinessUnit != null
                              && a.Category != null
                              && a.SubCategory != null
                              && a.BaseUnit != null
                              && a.MinimumQuantity != null
                              && a.Notifications.Any()
                              && a.PastOrders.Any()
                              && a.ItemsForecast.Any()
                              && a.SLALeadTimes.Any()
                              && a.SLADeliveries.Any()
                              && a.StocksOnHand.Any()
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