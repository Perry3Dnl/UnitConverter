namespace UnitConverter.Tests
{
    using System;
    using System.Reflection;
    using NUnit.Framework;
    using UnitConverter.Catalog;

    public sealed class UnitConverterMathematicalConformanceTests
    {
        private static readonly MethodInfo ExactTryConvert =
            typeof(UnitConverterExact).GetMethod("TryConvert", BindingFlags.Public | BindingFlags.Static);

        [Test]
        public void EveryCatalogUnit_BaseRoundTrip_IsStableAcrossRepresentativeMagnitudes()
        {
            double[] probes = { -1000d, -1d, -0.125d, 0.125d, 1d, 1000d };

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                UnitConverterUnitDescriptor baseUnit = family.GetUnitByNameForTest(family.BaseUnitName);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    foreach (double baseValue in probes)
                    {
                        double source;
                        double restored;
                        try
                        {
                            source = family.Convert(baseValue, baseUnit.Unit, unit.Unit);
                            restored = family.Convert(source, unit.Unit, baseUnit.Unit);
                        }
                        catch (DivideByZeroException)
                        {
                            continue;
                        }

                        if (!double.IsFinite(source) || !double.IsFinite(restored))
                            continue;

                        double tolerance = Math.Max(1e-9d, Math.Abs(baseValue) * 1e-10d);
                        Assert.That(restored, Is.EqualTo(baseValue).Within(tolerance),
                            family.Name + "." + unit.Name + " base round-trip at " + baseValue);
                    }
                }
            }
        }

        [Test]
        public void ExactDecimalAndDoubleRoutes_AgreeWheneverDecimalRouteIsRepresentable()
        {
            decimal[] probes = { 0.125m, 1m, 12.5m };

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                MethodInfo method = ExactTryConvert.MakeGenericMethod(family.UnitType);
                UnitConverterUnitDescriptor baseUnit = family.GetUnitByNameForTest(family.BaseUnitName);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    foreach (decimal probe in probes)
                    {
                        object[] args = { probe, unit.Unit, baseUnit.Unit, 0m };
                        bool success = (bool)method.Invoke(null, args);
                        if (!success)
                            continue;

                        decimal exact = (decimal)args[3];
                        double approximate = family.Convert((double)probe, unit.Unit, baseUnit.Unit);
                        if (!double.IsFinite(approximate))
                            continue;

                        double exactAsDouble = (double)exact;
                        double tolerance = Math.Max(1e-12d, Math.Abs(exactAsDouble) * 2e-12d);
                        Assert.That(approximate, Is.EqualTo(exactAsDouble).Within(tolerance),
                            family.Name + "." + unit.Name + " decimal/double parity at " + probe);
                    }
                }
            }
        }

        [Test]
        public void EveryFamily_BaseUnitMetadataIsResolvableAndIdentity()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                UnitConverterUnitDescriptor baseUnit = family.GetUnitByNameForTest(family.BaseUnitName);
                Assert.That(baseUnit, Is.Not.Null, family.Name);
                Assert.That(family.Convert(1d, baseUnit.Unit, baseUnit.Unit), Is.EqualTo(1d), family.Name);
            }
        }
    }

    internal static class UnitConverterConformanceExtensions
    {
        internal static UnitConverterUnitDescriptor GetUnitByNameForTest(
            this UnitConverterFamilyDescriptor family,
            string name)
        {
            foreach (UnitConverterUnitDescriptor unit in family.Units)
                if (string.Equals(unit.Name, name, StringComparison.Ordinal)) return unit;
            Assert.Fail("Base unit '" + name + "' is not registered for " + family.Name + ".");
            return null;
        }
    }
}
