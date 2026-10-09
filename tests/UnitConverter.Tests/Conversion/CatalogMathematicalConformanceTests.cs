namespace UnitConverter.Tests.Conversion
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using UnitConverter.Catalog;

    [TestFixture]
    public sealed class CatalogMathematicalConformanceTests
    {
        private const double Sample = 1.23456789d;

        [Test]
        public void EveryCatalogPair_RoundTripsThroughExistingConversionMath()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor from in family.Units)
                {
                    foreach (UnitConverterUnitDescriptor to in family.Units)
                    {
                        string context =
                            family.Name + ": " + from.Name + " -> " + to.Name + " -> " + from.Name;

                        double converted = family.Convert(Sample, from.Unit, to.Unit);
                        Assert.That(double.IsNaN(converted), Is.False, context + " produced NaN.");
                        Assert.That(double.IsInfinity(converted), Is.False, context + " produced infinity.");

                        double restored = family.Convert(converted, to.Unit, from.Unit);
                        Assert.That(double.IsNaN(restored), Is.False, context + " restored NaN.");
                        Assert.That(double.IsInfinity(restored), Is.False, context + " restored infinity.");

                        double relativeTolerance;
                        if (family.Family == UnitConverterFamily.SpecificGravity)
                        {
                            relativeTolerance = 1e-3d;
                        }
                        else if (family.Family == UnitConverterFamily.Temperature)
                        {
                            relativeTolerance = 1e-7d;
                        }
                        else
                        {
                            relativeTolerance = 1e-8d;
                        }
                        double tolerance =
                            Math.Max(relativeTolerance, Math.Abs(Sample) * relativeTolerance);
                        Assert.That(restored, Is.EqualTo(Sample).Within(tolerance), context);
                    }
                }
            }
        }

        [Test]
        public void EveryCatalogUnit_StableEnumNameIsKnownOrExplicitlyAmbiguous()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object resolved;
                    UnitConverterUnitResolution resolution =
                        family.ResolveUnit(unit.Name, out resolved);

                    string context = family.Name + "." + unit.Name;
                    Assert.That(
                        resolution,
                        Is.Not.EqualTo(UnitConverterUnitResolution.Unknown),
                        context);

                    if (resolution == UnitConverterUnitResolution.Resolved)
                    {
                        Assert.That(resolved, Is.EqualTo(unit.Unit), context);
                        Assert.That(family.GetUnit(resolved), Is.SameAs(unit), context);
                    }
                }
            }
        }

        [Test]
        public void ExactDecimalRoute_RoundTripsEveryRepresentableUnitThroughItsBase()
        {
            MethodInfo convertDefinition =
                typeof(UnitConverterExact)
                    .GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Single(method =>
                        method.Name == "Convert" &&
                        method.IsGenericMethodDefinition &&
                        method.GetParameters().Length == 3);

            const decimal sample = 1.25m;
            int representable = 0;

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                UnitConverterUnitDescriptor baseUnit =
                    family.Units.Single(unit => unit.Name == family.BaseUnitName);
                MethodInfo convert = convertDefinition.MakeGenericMethod(family.UnitType);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    string context = family.Name + "." + unit.Name;
                    try
                    {
                        decimal baseValue = (decimal)convert.Invoke(
                            null,
                            new object[] { sample, unit.Unit, baseUnit.Unit });
                        decimal magnitude = Math.Abs(baseValue);
                        if ((baseValue == 0m && sample != 0m) ||
                            (magnitude != 0m &&
                             (magnitude < 0.000000000000000001m ||
                              magnitude > 1000000000000000000m)))
                        {
                            continue;
                        }

                        decimal restored = (decimal)convert.Invoke(
                            null,
                            new object[] { baseValue, baseUnit.Unit, unit.Unit });

                        decimal tolerance = 0.000000000001m;
                        Assert.That(
                            Math.Abs(restored - sample),
                            Is.LessThanOrEqualTo(tolerance),
                            context);
                        representable++;
                    }
                    catch (TargetInvocationException exception)
                        when (exception.InnerException is OverflowException ||
                              exception.InnerException is DivideByZeroException)
                    {
                        // Extreme scale ratios can legitimately exceed decimal's finite range.
                    }
                    catch (TargetInvocationException exception)
                    {
                        Assert.Fail(
                            context + " exact route failed unexpectedly: " +
                            exception.InnerException);
                    }
                }
            }

            Assert.That(representable, Is.GreaterThan(1000),
                "Most catalog units should be representable in the decimal conformance sample.");
        }
    }
}
