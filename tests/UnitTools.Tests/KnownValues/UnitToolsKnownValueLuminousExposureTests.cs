namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.LuminousExposure;

    public sealed class UnitToolsKnownValueLuminousExposureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousExposure_ToBaseUnit_ReturnsExpectedValue(UnitToolsLuminousExposureUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousExposure.ToLuxSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousExposure_FromBaseUnit_ReturnsExpectedValue(UnitToolsLuminousExposureUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousExposure.FromLuxSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousExposure_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsLuminousExposureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsLuminousExposure.ToLuxSecond(input, unit);
            double result = UnitToolsLuminousExposure.FromLuxSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxSecond, 1d, 1.0d).SetName("LuminousExposure_ToBase_LuxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxHour, 1d, 3600.0d).SetName("LuminousExposure_ToBase_LuxHour");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleSecond, 1d, 10.763910416709722d).SetName("LuminousExposure_ToBase_FootCandleSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.PhotSecond, 1d, 10000.0d).SetName("LuminousExposure_ToBase_PhotSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxMinute, 1d, 60.0d).SetName("LuminousExposure_ToBase_LuxMinute");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.KiloluxSecond, 1d, 1000.0d).SetName("LuminousExposure_ToBase_KiloluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleMinute, 1d, 645.83462500258327d).SetName("LuminousExposure_ToBase_FootCandleMinute");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleHour, 1d, 38750.077500154999d).SetName("LuminousExposure_ToBase_FootCandleHour");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter, 1d, 1.0d).SetName("LuminousExposure_ToBase_LumenSecondPerSquareMeter");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.MilliluxSecond, 1d, 0.001d).SetName("LuminousExposure_ToBase_MilliluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.MegaluxSecond, 1d, 1000000.0d).SetName("LuminousExposure_ToBase_MegaluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter, 1d, 3600.0d).SetName("LuminousExposure_ToBase_LumenHourPerSquareMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxSecond, 1d, 1.0d).SetName("LuminousExposure_FromBase_LuxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxHour, 1d, 0.00027777777777777778d).SetName("LuminousExposure_FromBase_LuxHour");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleSecond, 1d, 0.092903040000000006d).SetName("LuminousExposure_FromBase_FootCandleSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.PhotSecond, 1d, 0.0001d).SetName("LuminousExposure_FromBase_PhotSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LuxMinute, 1d, 0.016666666666666666d).SetName("LuminousExposure_FromBase_LuxMinute");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.KiloluxSecond, 1d, 0.001d).SetName("LuminousExposure_FromBase_KiloluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleMinute, 1d, 0.0015483840000000001d).SetName("LuminousExposure_FromBase_FootCandleMinute");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.FootCandleHour, 1d, 2.5806400000000001e-05d).SetName("LuminousExposure_FromBase_FootCandleHour");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter, 1d, 1.0d).SetName("LuminousExposure_FromBase_LumenSecondPerSquareMeter");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.MilliluxSecond, 1d, 1000.0d).SetName("LuminousExposure_FromBase_MilliluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.MegaluxSecond, 1d, 9.9999999999999995e-07d).SetName("LuminousExposure_FromBase_MegaluxSecond");
            yield return new TestCaseData(UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter, 1d, 0.00027777777777777778d).SetName("LuminousExposure_FromBase_LumenHourPerSquareMeter");
        }
    }
}
