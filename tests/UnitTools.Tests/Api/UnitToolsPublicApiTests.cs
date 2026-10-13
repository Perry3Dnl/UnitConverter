namespace UnitTools.Tests.Api
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;

    public sealed class UnitToolsPublicApiTests
    {
        [TestCase(typeof(UnitToolsParseResult<>))]
        [TestCase(typeof(UnitToolsDynamicResult))]
        [TestCase(typeof(UnitToolsConversionResult))]
        [TestCase(typeof(UnitToolsExpressionParseResult))]
        [TestCase(typeof(UnitToolsCompositeResult))]
        public void ResultTypes_DoNotExposeConstructionFactories(Type openType)
        {
            Type type = openType.IsGenericTypeDefinition
                ? openType.MakeGenericType(typeof(UnitTools.Length.UnitToolsLengthUnit))
                : openType;

            string[] publicFactoryNames =
                type.GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Where(method =>
                        method.Name == "Ok" ||
                        method.Name == "Fail")
                    .Select(method => method.Name)
                    .Distinct()
                    .ToArray();

            Assert.That(
                publicFactoryNames,
                Is.Empty,
                type.FullName + " should only be created by UnitTools operations.");
        }

        [Test]
        public void CoreResultTypesRemainPublicAndReadable()
        {
            Assert.That(typeof(UnitToolsDynamicResult).IsPublic, Is.True);
            Assert.That(typeof(UnitToolsConversionResult).IsPublic, Is.True);
            Assert.That(typeof(UnitToolsExpressionParseResult).IsPublic, Is.True);
            Assert.That(typeof(UnitToolsCompositeResult).IsPublic, Is.True);

            Assert.That(
                typeof(UnitToolsDynamicResult).GetProperty("Success"),
                Is.Not.Null);
            Assert.That(
                typeof(UnitToolsDynamicResult).GetProperty("Error"),
                Is.Not.Null);
            Assert.That(
                typeof(UnitToolsDynamicResult).GetProperty("ErrorMessage"),
                Is.Not.Null);
        }
    }
}
