namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.DoseRate;

    public sealed class UnitToolsKnownValueDoseRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DoseRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsDoseRateUnit unit, double input, double expected)
        {
            double result = UnitToolsDoseRate.ToGrayPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DoseRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsDoseRateUnit unit, double input, double expected)
        {
            double result = UnitToolsDoseRate.FromGrayPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DoseRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsDoseRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsDoseRate.ToGrayPerSecond(input, unit);
            double result = UnitToolsDoseRate.FromGrayPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerSecond, 1d, 1.0d).SetName("DoseRate_ToBase_GrayPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MilligrayPerSecond, 1d, 0.001d).SetName("DoseRate_ToBase_MilligrayPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrograyPerSecond, 1d, 9.9999999999999995e-07d).SetName("DoseRate_ToBase_MicrograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerHour, 1d, 0.00027777777777777778d).SetName("DoseRate_ToBase_GrayPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RadPerHour, 1d, 2.7777777777777779e-06d).SetName("DoseRate_ToBase_RadPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MillisievertPerHour, 1d, 2.7777777777777776e-07d).SetName("DoseRate_ToBase_MillisievertPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerMinute, 1d, 0.016666666666666666d).SetName("DoseRate_ToBase_GrayPerMinute");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MilligrayPerHour, 1d, 2.7777777777777776e-07d).SetName("DoseRate_ToBase_MilligrayPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrograyPerHour, 1d, 2.7777777777777777e-10d).SetName("DoseRate_ToBase_MicrograyPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.SievertPerSecond, 1d, 1.0d).SetName("DoseRate_ToBase_SievertPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrosievertPerHour, 1d, 2.7777777777777777e-10d).SetName("DoseRate_ToBase_MicrosievertPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RemPerSecond, 1d, 0.01d).SetName("DoseRate_ToBase_RemPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RemPerYear, 1d, 3.1688087814028952e-10d).SetName("DoseRate_ToBase_RemPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.NanograyPerSecond, 1d, 1.0000000000000001e-09d).SetName("DoseRate_ToBase_NanograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.PicograyPerSecond, 1d, 9.9999999999999998e-13d).SetName("DoseRate_ToBase_PicograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerYear, 1d, 3.1688087814028947e-08d).SetName("DoseRate_ToBase_GrayPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.SievertPerYear, 1d, 3.1688087814028947e-08d).SetName("DoseRate_ToBase_SievertPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrosievertPerYear, 1d, 3.168808781402895e-14d).SetName("DoseRate_ToBase_MicrosievertPerYear");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerSecond, 1d, 1.0d).SetName("DoseRate_FromBase_GrayPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MilligrayPerSecond, 1d, 1000.0d).SetName("DoseRate_FromBase_MilligrayPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrograyPerSecond, 1d, 1000000.0d).SetName("DoseRate_FromBase_MicrograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerHour, 1d, 3600.0d).SetName("DoseRate_FromBase_GrayPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RadPerHour, 1d, 360000.0d).SetName("DoseRate_FromBase_RadPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MillisievertPerHour, 1d, 3600000.0000000005d).SetName("DoseRate_FromBase_MillisievertPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerMinute, 1d, 60.0d).SetName("DoseRate_FromBase_GrayPerMinute");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MilligrayPerHour, 1d, 3600000.0000000005d).SetName("DoseRate_FromBase_MilligrayPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrograyPerHour, 1d, 3600000000.0d).SetName("DoseRate_FromBase_MicrograyPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.SievertPerSecond, 1d, 1.0d).SetName("DoseRate_FromBase_SievertPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrosievertPerHour, 1d, 3600000000.0d).SetName("DoseRate_FromBase_MicrosievertPerHour");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RemPerSecond, 1d, 100.0d).SetName("DoseRate_FromBase_RemPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.RemPerYear, 1d, 3155760000.0d).SetName("DoseRate_FromBase_RemPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.NanograyPerSecond, 1d, 999999999.99999988d).SetName("DoseRate_FromBase_NanograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.PicograyPerSecond, 1d, 1000000000000.0d).SetName("DoseRate_FromBase_PicograyPerSecond");
            yield return new TestCaseData(UnitToolsDoseRateUnit.GrayPerYear, 1d, 31557600.000000004d).SetName("DoseRate_FromBase_GrayPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.SievertPerYear, 1d, 31557600.000000004d).SetName("DoseRate_FromBase_SievertPerYear");
            yield return new TestCaseData(UnitToolsDoseRateUnit.MicrosievertPerYear, 1d, 31557600000000.0d).SetName("DoseRate_FromBase_MicrosievertPerYear");
        }
    }
}
