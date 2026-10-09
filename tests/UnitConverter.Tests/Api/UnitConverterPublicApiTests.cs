namespace UnitConverter.Tests.Api
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;

    public sealed class UnitConverterPublicApiTests
    {
        [TestCase(typeof(UnitConverterParseResult<>))]
        [TestCase(typeof(UnitConverterDynamicResult))]
        [TestCase(typeof(UnitConverterConversionResult))]
        [TestCase(typeof(UnitConverterExpressionParseResult))]
        [TestCase(typeof(UnitConverterCompositeResult))]
        public void ResultTypes_DoNotExposeConstructionFactories(Type openType)
        {
            Type type = openType.IsGenericTypeDefinition
                ? openType.MakeGenericType(typeof(UnitConverter.Length.UnitConverterLengthUnit))
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
                type.FullName + " should only be created by UnitConverter operations.");
        }

        [Test]
        public void CoreResultTypesRemainPublicAndReadable()
        {
            Assert.That(typeof(UnitConverterDynamicResult).IsPublic, Is.True);
            Assert.That(typeof(UnitConverterConversionResult).IsPublic, Is.True);
            Assert.That(typeof(UnitConverterExpressionParseResult).IsPublic, Is.True);
            Assert.That(typeof(UnitConverterCompositeResult).IsPublic, Is.True);

            Assert.That(
                typeof(UnitConverterDynamicResult).GetProperty("Success"),
                Is.Not.Null);
            Assert.That(
                typeof(UnitConverterDynamicResult).GetProperty("Error"),
                Is.Not.Null);
            Assert.That(
                typeof(UnitConverterDynamicResult).GetProperty("ErrorMessage"),
                Is.Not.Null);
        }
    }
}
