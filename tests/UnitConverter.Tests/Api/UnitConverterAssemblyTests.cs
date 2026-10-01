namespace UnitConverter.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using UnitConverter.Catalog;
    using UnitConverter.Length;

    public sealed class UnitConverterAssemblyTests
    {
        [Test]
        public void ConversionAssembly_DoesNotReferenceUnityOrTheSharedCore()
        {
            var assembly = typeof(UnitConverterLength).Assembly;
            var references = assembly.GetReferencedAssemblies();
            Assert.AreEqual("UnitConverter", assembly.GetName().Name);
            Assert.IsTrue(assembly.GetExportedTypes().All(type =>
                type.Namespace == "UnitConverter" || type.Namespace.StartsWith("UnitConverter.", StringComparison.Ordinal)));
            Assert.IsFalse(references.Any(reference => reference.Name.StartsWith("Unity", StringComparison.Ordinal)));
            Assert.IsFalse(references.Any(reference => reference.Name.StartsWith("RealisticPhysics.Core", StringComparison.Ordinal)));
            Assert.IsFalse(assembly.GetTypes().Any(type => type.Name == "UnitConverterSettings"));
        }

        [Test]
        public void StandaloneAssembly_PreservesTheOriginalConversionCoverage()
        {
            var unitEnums = typeof(UnitConverterLength).Assembly.GetTypes()
                .Where(type => type.IsEnum && type.Name.StartsWith("UnitConverter", StringComparison.Ordinal))
                .Where(type => type.Name.EndsWith("Unit", StringComparison.Ordinal))
                .ToArray();
            Assert.AreEqual(97, unitEnums.Length);
            Assert.AreEqual(1632, unitEnums.Sum(type => Enum.GetNames(type).Length));
            CollectionAssert.AreEquivalent(
                UnitConverterCatalog.GetFamilyNames(),
                unitEnums.Select(type => type.Name.Substring("UnitConverter".Length,
                    type.Name.Length - "UnitConverter".Length - "Unit".Length)).ToArray());
        }
    }
}
