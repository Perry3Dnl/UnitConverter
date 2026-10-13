#if NET8_0_OR_GREATER
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using UnitTools.Catalog;
using UnitTools.Quantities;

namespace UnitTools.Tests.Quantities
{
    [TestFixture]
    public sealed class AdditionalNamedQuantityTests
    {
        [Test]
        public void EveryAdditionalFamilyHasNamedQuantityAndMethodsTypes()
        {
            Assembly assembly = typeof(Stress<>).Assembly;

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                if ((int)family.Family < 98)
                    continue;

                Type quantity = assembly.GetType(
                    "UnitTools.Quantities." + family.Name + "`1",
                    throwOnError: false);
                Type methods = assembly.GetType(
                    "UnitTools.Quantities." + family.Name + "Methods",
                    throwOnError: false);

                Assert.That(quantity, Is.Not.Null, family.Name);
                Assert.That(methods, Is.Not.Null, family.Name);
            }
        }

        [Test]
        public void EveryAdditionalQuantityExposesEveryFamilyUnit()
        {
            Assembly assembly = typeof(Stress<>).Assembly;

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                if ((int)family.Family < 98)
                    continue;

                Type generic = assembly.GetType("UnitTools.Quantities." + family.Name + "`1");
                Type quantity = generic.MakeGenericType(typeof(decimal));

                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    Assert.That(
                        quantity.GetProperty(unit.Name, BindingFlags.Public | BindingFlags.Instance),
                        Is.Not.Null,
                        family.Name + "." + unit.Name + " property");

                    Assert.That(
                        quantity.GetMethod(
                            "From" + unit.Name,
                            BindingFlags.Public | BindingFlags.Static,
                            binder: null,
                            types: new[] { typeof(decimal) },
                            modifiers: null),
                        Is.Not.Null,
                        family.Name + ".From" + unit.Name);
                }
            }
        }

        [Test]
        public void AdditionalQuantitiesImplementModernGenericContracts()
        {
            Type quantity = typeof(Stress<decimal>);

            Assert.That(typeof(IEquatable<Stress<decimal>>).IsAssignableFrom(quantity), Is.True);
            Assert.That(typeof(IComparable<Stress<decimal>>).IsAssignableFrom(quantity), Is.True);
            Assert.That(typeof(IFormattable).IsAssignableFrom(quantity), Is.True);
            Assert.That(typeof(ISpanFormattable).IsAssignableFrom(quantity), Is.True);
            Assert.That(typeof(IParsable<Stress<decimal>>).IsAssignableFrom(quantity), Is.True);
            Assert.That(typeof(ISpanParsable<Stress<decimal>>).IsAssignableFrom(quantity), Is.True);
        }

        [Test]
        public void StressParsesFormatsAndConvertsWithoutLosingDecimalPrecision()
        {
            Stress<decimal> stress = Stress<decimal>.Parse(
                "1.25 MPa",
                CultureInfo.InvariantCulture);

            Assert.That(stress.Kilopascal, Is.EqualTo(1250m));

            Span<char> buffer = stackalloc char[64];
            Assert.That(
                stress.TryFormat(buffer, out int written, default, CultureInfo.InvariantCulture),
                Is.True);
            Assert.That(new string(buffer.Slice(0, written)), Is.EqualTo("1250000 Pa"));
        }

        [Test]
        public void RationalScaleRemainsExactInsideNamedQuantity()
        {
            AmountFlowRate<decimal> flow =
                AmountFlowRate<decimal>.FromMolePerMinute(1m);

            Assert.That(flow.MolePerSecond, Is.EqualTo(1m / 60m));
        }

        [Test]
        public void MechanicalDerivedOperatorsAreDimensionSafe()
        {
            Stress<decimal> stress =
                YoungModulus<decimal>.FromGigapascal(200m) *
                Strain<decimal>.FromMicrostrain(500m);

            Force<decimal> force =
                SpringConstant<decimal>.FromNewtonPerMeter(100m) *
                Length<decimal>.FromMetres(0.25m);

            Assert.That(stress.Megapascal, Is.EqualTo(100m));
            Assert.That(force.Newtons, Is.EqualTo(25m));
        }

        [Test]
        public void ElectricalAndThermalDerivedOperatorsComposeWithExistingTypes()
        {
            Voltage<decimal> voltage =
                Impedance<decimal>.FromOhm(50m) *
                ElectricCurrent<decimal>.FromAmperes(2m);

            Power<decimal> power =
                HeatFluxDensity<decimal>.FromWattPerSquareMeter(250m) *
                Area<decimal>.FromSquareMetres(4m);

            Assert.That(voltage.Volts, Is.EqualTo(100m));
            Assert.That(power.Watts, Is.EqualTo(1000m));
        }
    }
}
#endif
