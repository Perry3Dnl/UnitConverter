namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Irradiance;

    public sealed class UnitToolsKnownValueIrradianceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Irradiance_ToBaseUnit_ReturnsExpectedValue(UnitToolsIrradianceUnit unit, double input, double expected)
        {
            double result = UnitToolsIrradiance.ToWattPerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Irradiance_FromBaseUnit_ReturnsExpectedValue(UnitToolsIrradianceUnit unit, double input, double expected)
        {
            double result = UnitToolsIrradiance.FromWattPerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Irradiance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsIrradianceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsIrradiance.ToWattPerSquareMeter(input, unit);
            double result = UnitToolsIrradiance.FromWattPerSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareMeter, 1d, 1.0d).SetName("Irradiance_ToBase_WattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.KilowattPerSquareMeter, 1d, 1000.0d).SetName("Irradiance_ToBase_KilowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter, 1d, 10.0d).SetName("Irradiance_ToBase_MilliwattPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareCentimeter, 1d, 10000.0d).SetName("Irradiance_ToBase_WattPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerMinute, 1d, 697.33333333333337d).SetName("Irradiance_ToBase_LangleyPerMinute");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MilliwattPerSquareMeter, 1d, 0.001d).SetName("Irradiance_ToBase_MilliwattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MicrowattPerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("Irradiance_ToBase_MicrowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareFoot, 1d, 10.763910416709722d).SetName("Irradiance_ToBase_WattPerSquareFoot");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareInch, 1d, 1550.0031000062002d).SetName("Irradiance_ToBase_WattPerSquareInch");
            yield return new TestCaseData(UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute, 1d, 697.33333333333337d).SetName("Irradiance_ToBase_CaloriePerSquareCentimeterMinute");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerHour, 1d, 11.622222222222222d).SetName("Irradiance_ToBase_LangleyPerHour");
            yield return new TestCaseData(UnitToolsIrradianceUnit.NanowattPerSquareMeter, 1d, 1.0000000000000001e-09d).SetName("Irradiance_ToBase_NanowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MegawattPerSquareMeter, 1d, 1000000.0d).SetName("Irradiance_ToBase_MegawattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond, 1d, 41840.0d).SetName("Irradiance_ToBase_CaloriePerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerSecond, 1d, 41840.0d).SetName("Irradiance_ToBase_LangleyPerSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareMeter, 1d, 1.0d).SetName("Irradiance_FromBase_WattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.KilowattPerSquareMeter, 1d, 0.001d).SetName("Irradiance_FromBase_KilowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter, 1d, 0.10000000000000001d).SetName("Irradiance_FromBase_MilliwattPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareCentimeter, 1d, 0.0001d).SetName("Irradiance_FromBase_WattPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerMinute, 1d, 0.0014340344168260037d).SetName("Irradiance_FromBase_LangleyPerMinute");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MilliwattPerSquareMeter, 1d, 1000.0d).SetName("Irradiance_FromBase_MilliwattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MicrowattPerSquareMeter, 1d, 1000000.0d).SetName("Irradiance_FromBase_MicrowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareFoot, 1d, 0.092903040000000006d).SetName("Irradiance_FromBase_WattPerSquareFoot");
            yield return new TestCaseData(UnitToolsIrradianceUnit.WattPerSquareInch, 1d, 0.00064515999999999998d).SetName("Irradiance_FromBase_WattPerSquareInch");
            yield return new TestCaseData(UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute, 1d, 0.0014340344168260037d).SetName("Irradiance_FromBase_CaloriePerSquareCentimeterMinute");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerHour, 1d, 0.086042065009560229d).SetName("Irradiance_FromBase_LangleyPerHour");
            yield return new TestCaseData(UnitToolsIrradianceUnit.NanowattPerSquareMeter, 1d, 999999999.99999988d).SetName("Irradiance_FromBase_NanowattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.MegawattPerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("Irradiance_FromBase_MegawattPerSquareMeter");
            yield return new TestCaseData(UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond, 1d, 2.390057361376673e-05d).SetName("Irradiance_FromBase_CaloriePerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsIrradianceUnit.LangleyPerSecond, 1d, 2.390057361376673e-05d).SetName("Irradiance_FromBase_LangleyPerSecond");
        }
    }
}
