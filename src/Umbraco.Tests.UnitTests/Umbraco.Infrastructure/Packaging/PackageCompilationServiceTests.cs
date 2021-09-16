﻿using NUnit.Framework;
using Umbraco.Cms.Infrastructure.Packaging;
using Umbraco.Extensions;

namespace Umbraco.Cms.Tests.UnitTests.Umbraco.Infrastructure.Packaging
{
    [TestFixture]
    public class PackageCompilationServiceTests
    {
        [Test]
        [TestCase("Perfectly.Valid.Name", "Perfectly.Valid.Name")]
        [TestCase("Semi.Valid Package Name", "Semi.Valid.Package.Name")]
        [TestCase("Not Valid Package (Name)", "Not.Valid.Package.Name")]
        [TestCase("NoNumber After.1Dot", "NoNumber.After.Dot")]
        [TestCase("Handle Number After (1 parenthesis)", "Handle.Number.After.parenthesis")]
        [TestCase("No-Dashes-Allowed", "No.Dashes.Allowed")]
        [TestCase("No  Double  Dots", "No.Double.Dots")]
        [TestCase("", "")]
        [TestCase(".", "")]
        [TestCase("%", "")]
        [TestCase("BackOfficeAutoGenerated.C5C9D5E3-7057-4C8F-8835-E86DE32246C5", "BackOfficeAutoGenerated.C5C9D5E3.C8F.E86DE32246C5")]
        public void CanCleanPackageNameForNamespace(string packageName, string expectedPackageName)
        {
            var CleanedName = packageName.CleanStringForNamespace();

            Assert.AreEqual(expectedPackageName, CleanedName);
        }
    }
}
