namespace UnitTools.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using UnitTools.Catalog;
    using UnitTools.Length;

    public sealed class UnitToolsAssemblyTests
    {
        [Test]
        public void ConversionAssembly_DoesNotReferenceUnityOrTheSharedCore()
        {
            var assembly = typeof(UnitToolsLength).Assembly;
            var references = assembly.GetReferencedAssemblies();
            Assert.AreEqual("UnitTools", assembly.GetName().Name);
            Assert.IsTrue(assembly.GetExportedTypes().All(type =>
                type.Namespace == "UnitTools" || type.Namespace.StartsWith("UnitTools.", StringComparison.Ordinal)));
            Assert.IsFalse(references.Any(reference => reference.Name.StartsWith("Unity", StringComparison.Ordinal)));
            Assert.IsFalse(references.Any(reference => reference.Name.StartsWith("RealisticPhysics.Core", StringComparison.Ordinal)));
            Assert.IsFalse(assembly.GetTypes().Any(type => type.Name == "UnitToolsSettings"));
        }

        [Test]
        public void StandaloneAssembly_PreservesTheOriginalConversionCoverage()
        {
            var unitEnums = typeof(UnitToolsLength).Assembly.GetTypes()
                .Where(type => type.IsEnum && type.Name.StartsWith("UnitTools", StringComparison.Ordinal))
                .Where(type => type.Name.EndsWith("Unit", StringComparison.Ordinal))
                .ToArray();
            Assert.AreEqual(150, unitEnums.Length);
            Assert.AreEqual(1858, unitEnums.Sum(type => Enum.GetNames(type).Length));
            CollectionAssert.AreEquivalent(
                UnitToolsCatalog.GetFamilyNames(),
                unitEnums.Select(type => type.Name.Substring("UnitTools".Length,
                    type.Name.Length - "UnitTools".Length - "Unit".Length)).ToArray());
        }
    }
}
