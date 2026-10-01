namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.PixelDensity;

    public sealed class UnitConverterKnownValuePixelDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void PixelDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterPixelDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterPixelDensity.ToPixelPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void PixelDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterPixelDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterPixelDensity.FromPixelPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void PixelDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterPixelDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterPixelDensity.ToPixelPerMeter(input, unit);
            double result = UnitConverterPixelDensity.FromPixelPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMeter, 1d, 1.0d).SetName("PixelDensity_ToBase_PixelPerMeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerCentimeter, 1d, 100.0d).SetName("PixelDensity_ToBase_PixelPerCentimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMillimeter, 1d, 1000.0d).SetName("PixelDensity_ToBase_PixelPerMillimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerInch, 1d, 39.370078740157481d).SetName("PixelDensity_ToBase_PixelPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerFoot, 1d, 3.280839895013123d).SetName("PixelDensity_ToBase_PixelPerFoot");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerYard, 1d, 1.0936132983377078d).SetName("PixelDensity_ToBase_PixelPerYard");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerKilometer, 1d, 0.001d).SetName("PixelDensity_ToBase_PixelPerKilometer");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerInch, 1d, 39.370078740157481d).SetName("PixelDensity_ToBase_DotPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PointPerInch, 1d, 39.370078740157481d).SetName("PixelDensity_ToBase_PointPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMile, 1d, 0.00062137119223733392d).SetName("PixelDensity_ToBase_PixelPerMile");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerCentimeter, 1d, 100.0d).SetName("PixelDensity_ToBase_DotPerCentimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerMillimeter, 1d, 1000.0d).SetName("PixelDensity_ToBase_DotPerMillimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerMeter, 1d, 1.0d).SetName("PixelDensity_ToBase_DotPerMeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerUnityUnit, 1d, 1.0d).SetName("PixelDensity_ToBase_PixelPerUnityUnit");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMeter, 1d, 1.0d).SetName("PixelDensity_FromBase_PixelPerMeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerCentimeter, 1d, 0.01d).SetName("PixelDensity_FromBase_PixelPerCentimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMillimeter, 1d, 0.001d).SetName("PixelDensity_FromBase_PixelPerMillimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerInch, 1d, 0.025399999999999999d).SetName("PixelDensity_FromBase_PixelPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerFoot, 1d, 0.30480000000000002d).SetName("PixelDensity_FromBase_PixelPerFoot");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerYard, 1d, 0.91439999999999999d).SetName("PixelDensity_FromBase_PixelPerYard");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerKilometer, 1d, 1000.0d).SetName("PixelDensity_FromBase_PixelPerKilometer");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerInch, 1d, 0.025399999999999999d).SetName("PixelDensity_FromBase_DotPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PointPerInch, 1d, 0.025399999999999999d).SetName("PixelDensity_FromBase_PointPerInch");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerMile, 1d, 1609.3440000000001d).SetName("PixelDensity_FromBase_PixelPerMile");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerCentimeter, 1d, 0.01d).SetName("PixelDensity_FromBase_DotPerCentimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerMillimeter, 1d, 0.001d).SetName("PixelDensity_FromBase_DotPerMillimeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.DotPerMeter, 1d, 1.0d).SetName("PixelDensity_FromBase_DotPerMeter");
            yield return new TestCaseData(UnitConverterPixelDensityUnit.PixelPerUnityUnit, 1d, 1.0d).SetName("PixelDensity_FromBase_PixelPerUnityUnit");
        }
    }
}
