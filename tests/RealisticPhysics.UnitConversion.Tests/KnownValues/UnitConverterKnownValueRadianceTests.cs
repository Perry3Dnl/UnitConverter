namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Radiance;

    public sealed class UnitConverterKnownValueRadianceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Radiance_ToBaseUnit_ReturnsExpectedValue(UnitConverterRadianceUnit unit, double input, double expected)
        {
            double result = UnitConverterRadiance.ToWattPerSteradianSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Radiance_FromBaseUnit_ReturnsExpectedValue(UnitConverterRadianceUnit unit, double input, double expected)
        {
            double result = UnitConverterRadiance.FromWattPerSteradianSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Radiance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterRadianceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterRadiance.ToWattPerSteradianSquareMeter(input, unit);
            double result = UnitConverterRadiance.FromWattPerSteradianSquareMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareMeter, 1d, 1.0d).SetName("Radiance_ToBase_WattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter, 1d, 1000.0d).SetName("Radiance_ToBase_KilowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter, 1d, 10000.0d).SetName("Radiance_ToBase_WattPerSteradianSquareCentimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter, 1d, 1000000.0d).SetName("Radiance_ToBase_WattPerSteradianSquareMillimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter, 1d, 0.001d).SetName("Radiance_ToBase_MilliwattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter, 1d, 1000000.0d).SetName("Radiance_ToBase_MegawattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareFoot, 1d, 10.763910416709722d).SetName("Radiance_ToBase_WattPerSteradianSquareFoot");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareInch, 1d, 1550.0031000062002d).SetName("Radiance_ToBase_WattPerSteradianSquareInch");
            yield return new TestCaseData(UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter, 1d, 0.001d).SetName("Radiance_ToBase_ErgPerSecondSteradianSquareCentimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter, 1d, 9.9999999999999995e-07d).SetName("Radiance_ToBase_MicrowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter, 1d, 1.0000000000000001e-09d).SetName("Radiance_ToBase_NanowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter, 1d, 41840.0d).SetName("Radiance_ToBase_CaloriePerSecondSteradianSquareCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareMeter, 1d, 1.0d).SetName("Radiance_FromBase_WattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter, 1d, 0.001d).SetName("Radiance_FromBase_KilowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter, 1d, 0.0001d).SetName("Radiance_FromBase_WattPerSteradianSquareCentimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("Radiance_FromBase_WattPerSteradianSquareMillimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter, 1d, 1000.0d).SetName("Radiance_FromBase_MilliwattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter, 1d, 9.9999999999999995e-07d).SetName("Radiance_FromBase_MegawattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareFoot, 1d, 0.092903040000000006d).SetName("Radiance_FromBase_WattPerSteradianSquareFoot");
            yield return new TestCaseData(UnitConverterRadianceUnit.WattPerSteradianSquareInch, 1d, 0.00064515999999999998d).SetName("Radiance_FromBase_WattPerSteradianSquareInch");
            yield return new TestCaseData(UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter, 1d, 1000.0d).SetName("Radiance_FromBase_ErgPerSecondSteradianSquareCentimeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter, 1d, 1000000.0d).SetName("Radiance_FromBase_MicrowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter, 1d, 999999999.99999988d).SetName("Radiance_FromBase_NanowattPerSteradianSquareMeter");
            yield return new TestCaseData(UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter, 1d, 2.390057361376673e-05d).SetName("Radiance_FromBase_CaloriePerSecondSteradianSquareCentimeter");
        }
    }
}
