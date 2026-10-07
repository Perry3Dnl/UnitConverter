#if NET8_0_OR_GREATER
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using UnitConverter.Catalog;
using UnitConverter.Quantities;
using UnitConverter.Time;
using UnitConverter.Temperature;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class CatalogWideNamedQuantityTests
    {
        [Test]
        public void EveryCatalogFamilyHasACompileTimeNamedQuantitySurface()
        {
            Assembly assembly = typeof(Length<>).Assembly;
            int namedFamilies = 0;

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (family.Family == UnitConverterFamily.FuelEconomy)
                    continue;

                string quantityName = GetQuantityTypeName(family.Family);
                Type genericQuantity = assembly.GetType(
                    "UnitConverter.Quantities." + quantityName + "`1",
                    throwOnError: false);
                Type methods = assembly.GetType(
                    "UnitConverter.Quantities." + quantityName + "Methods",
                    throwOnError: false);

                Assert.That(genericQuantity, Is.Not.Null, family.Name);
                Assert.That(methods, Is.Not.Null, family.Name);
                namedFamilies++;
            }

            Assert.That(namedFamilies, Is.EqualTo(149));
            Assert.That(typeof(FuelEfficiency<decimal>), Is.Not.Null);
            Assert.That(typeof(FuelConsumption<decimal>), Is.Not.Null);
        }

        [Test]
        public void EveryCatalogUnitHasTypedPropertyAndFactory()
        {
            Assembly assembly = typeof(Length<>).Assembly;

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (family.Family == UnitConverterFamily.FuelEconomy)
                    continue;

                string quantityName = GetQuantityTypeName(family.Family);
                Type genericQuantity = assembly.GetType(
                    "UnitConverter.Quantities." + quantityName + "`1",
                    throwOnError: true);
                Type quantity = genericQuantity.MakeGenericType(typeof(decimal));
                Type methods = assembly.GetType(
                    "UnitConverter.Quantities." + quantityName + "Methods",
                    throwOnError: true);

                string[] helperMethodNames = methods
                    .GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Select(method => method.Name)
                    .ToArray();

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    string context = family.Name + "." + unit.Name;

                    string propertyName =
                        unit.Name == quantityName
                            ? unit.Name + "Value"
                            : unit.Name;

                    Assert.That(
                        quantity.GetProperty(
                            propertyName,
                            BindingFlags.Public | BindingFlags.Instance),
                        Is.Not.Null,
                        context + " property");

                    Assert.That(
                        quantity.GetMethod(
                            "From" + unit.Name,
                            BindingFlags.Public | BindingFlags.Static,
                            binder: null,
                            types: new[] { typeof(decimal) },
                            modifiers: null),
                        Is.Not.Null,
                        context + " factory");

                    Assert.That(
                        helperMethodNames,
                        Does.Contain("From" + unit.Name),
                        context + " helper factory");
                    Assert.That(
                        helperMethodNames,
                        Does.Contain("To" + unit.Name),
                        context + " helper projection");
                }
            }
        }

        [Test]
        public void EveryNamedQuantityImplementsModernContracts()
        {
            Assembly assembly = typeof(Length<>).Assembly;

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (family.Family == UnitConverterFamily.FuelEconomy)
                    continue;

                string quantityName = GetQuantityTypeName(family.Family);
                Type genericQuantity = assembly.GetType(
                    "UnitConverter.Quantities." + quantityName + "`1",
                    throwOnError: true);
                Type quantity = genericQuantity.MakeGenericType(typeof(decimal));

                Assert.That(
                    typeof(IEquatable<>).MakeGenericType(quantity).IsAssignableFrom(quantity),
                    Is.True,
                    family.Name + " IEquatable");
                Assert.That(
                    typeof(IComparable<>).MakeGenericType(quantity).IsAssignableFrom(quantity),
                    Is.True,
                    family.Name + " IComparable");
                Assert.That(typeof(IFormattable).IsAssignableFrom(quantity), Is.True, family.Name + " IFormattable");
                Assert.That(typeof(ISpanFormattable).IsAssignableFrom(quantity), Is.True, family.Name + " ISpanFormattable");
                Assert.That(
                    typeof(IParsable<>).MakeGenericType(quantity).IsAssignableFrom(quantity),
                    Is.True,
                    family.Name + " IParsable");
                Assert.That(
                    typeof(ISpanParsable<>).MakeGenericType(quantity).IsAssignableFrom(quantity),
                    Is.True,
                    family.Name + " ISpanParsable");
            }
        }

        [Test]
        public void ExistingNamedQuantityIndirectApiNowCoversUnitsOutsideItsOldSubset()
        {
            Time<decimal> twoWeeks = TimeMethods.From(
                2m,
                UnitConverterTimeUnit.Week);

            Assert.That(twoWeeks.Week, Is.EqualTo(2m));
            Assert.That(twoWeeks.In(UnitConverterTimeUnit.Day), Is.EqualTo(14m));

            Time<decimal> parsed = Time<decimal>.Parse(
                "3 Week",
                CultureInfo.InvariantCulture);

            Assert.That(parsed.Day, Is.EqualTo(21m));
        }

        [Test]
        public void NewlyNamedTemperatureKeepsExactDecimalAffineConversion()
        {
            Temperature<decimal> freezing =
                Temperature<decimal>.FromCelsius(0m);

            Assert.That(freezing.Fahrenheit, Is.EqualTo(32m));

            Temperature<decimal> parsed = Temperature<decimal>.Parse(
                "32 Fahrenheit",
                CultureInfo.InvariantCulture);

            Assert.That(parsed.Celsius, Is.EqualTo(0m));
        }

        [Test]
        public void NewlyNamedLegacyQuantitySupportsSpanParsingAndFormatting()
        {
            Angle<decimal> angle = Angle<decimal>.Parse(
                "180 Degree",
                CultureInfo.InvariantCulture);

            Assert.That(angle.Degree, Is.EqualTo(180m));

            Span<char> buffer = stackalloc char[64];
            Assert.That(
                angle.TryFormat(
                    buffer,
                    out int written,
                    default,
                    CultureInfo.InvariantCulture),
                Is.True);

            Assert.That(
                new string(buffer.Slice(0, written)),
                Is.EqualTo("180 " + UnitConverter.Angle.UnitConverterAngle.GetSymbol(
                    UnitConverter.Angle.UnitConverterAngleUnit.Degree)));
        }

        private static string GetQuantityTypeName(UnitConverterFamily family)
        {
            switch (family)
            {
                case UnitConverterFamily.Current:
                    return "ElectricCurrent";
                case UnitConverterFamily.ElectricResistance:
                    return "Resistance";
                default:
                    return family.ToString();
            }
        }
    }
}
#endif
