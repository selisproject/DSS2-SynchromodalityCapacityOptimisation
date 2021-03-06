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
    ///This is a test class for FileDataTest and is intended
    ///to contain all FileDataTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("FileData Repository Tests")]
    [Category("FileData Repository Tests")]
    internal class FileDataTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `FileData`")]
        [Order(0)]
        public void FileData_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS2_SynchromodalityCapacityOptimisation.BO.FileData>(Session)
            .CheckProperty(p => p.FileName, "FileData_FileName")
            .CheckProperty(p => p.FolderPath, "FileData_FolderPath")
            .CheckProperty(p => p.MaxFileSize, 3497)
            .CheckProperty(p => p.AllowedExtensions, "FileData_AllowedExtensions")
            .CheckProperty(p => p.Blob, (new System.Text.ASCIIEncoding()).GetBytes("TestValue_Blob"))
            .CheckProperty(p => p.UploadedBy, "FileData_UploadedBy")
            .CheckProperty(p => p.UploadDateTime, now)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `FileData`")]
        [Order(1)]
        public void FileData_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS2_SynchromodalityCapacityOptimisation.BO.FileData> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS2_SynchromodalityCapacityOptimisation.BO.FileData>(
                              a => true
                              && (a.FileName != string.Empty && a.FileName != null)
                              && (a.FolderPath != string.Empty && a.FolderPath != null)
                              && (a.MaxFileSize + 123 > 0)
                              && (a.AllowedExtensions != string.Empty && a.AllowedExtensions != null)
                              && a.Blob != null
                              && a.StorageMedium == DSS2_SynchromodalityCapacityOptimisation.BO.StorageMedium.FileSystem
                              && (a.UploadedBy != string.Empty && a.UploadedBy != null)
                              && a.UploadDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
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