namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.FrameRate;

    public sealed class UnitToolsKnownValueFrameRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void FrameRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsFrameRateUnit unit, double input, double expected)
        {
            double result = UnitToolsFrameRate.ToFramePerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void FrameRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsFrameRateUnit unit, double input, double expected)
        {
            double result = UnitToolsFrameRate.FromFramePerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void FrameRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsFrameRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsFrameRate.ToFramePerSecond(input, unit);
            double result = UnitToolsFrameRate.FromFramePerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerSecond, 1d, 1.0d).SetName("FrameRate_ToBase_FramePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Hertz, 1d, 1.0d).SetName("FrameRate_ToBase_Hertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMinute, 1d, 0.016666666666666666d).SetName("FrameRate_ToBase_FramePerMinute");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerHour, 1d, 0.00027777777777777778d).SetName("FrameRate_ToBase_FramePerHour");
            yield return new TestCaseData(UnitToolsFrameRateUnit.KiloframePerSecond, 1d, 1000.0d).SetName("FrameRate_ToBase_KiloframePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.MegaframePerSecond, 1d, 1000000.0d).SetName("FrameRate_ToBase_MegaframePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMillisecond, 1d, 1000.0d).SetName("FrameRate_ToBase_FramePerMillisecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerDay, 1d, 1.1574074074074073e-05d).SetName("FrameRate_ToBase_FramePerDay");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerWeek, 1d, 1.6534391534391535e-06d).SetName("FrameRate_ToBase_FramePerWeek");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Kilohertz, 1d, 1000.0d).SetName("FrameRate_ToBase_Kilohertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Megahertz, 1d, 1000000.0d).SetName("FrameRate_ToBase_Megahertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMicrosecond, 1d, 1000000.0d).SetName("FrameRate_ToBase_FramePerMicrosecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerNanosecond, 1d, 1000000000.0d).SetName("FrameRate_ToBase_FramePerNanosecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMonthJulian, 1d, 3.8025705376834739e-07d).SetName("FrameRate_ToBase_FramePerMonthJulian");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerYearJulian, 1d, 3.1688087814028947e-08d).SetName("FrameRate_ToBase_FramePerYearJulian");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerSecond, 1d, 1.0d).SetName("FrameRate_FromBase_FramePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Hertz, 1d, 1.0d).SetName("FrameRate_FromBase_Hertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMinute, 1d, 60.0d).SetName("FrameRate_FromBase_FramePerMinute");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerHour, 1d, 3600.0d).SetName("FrameRate_FromBase_FramePerHour");
            yield return new TestCaseData(UnitToolsFrameRateUnit.KiloframePerSecond, 1d, 0.001d).SetName("FrameRate_FromBase_KiloframePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.MegaframePerSecond, 1d, 9.9999999999999995e-07d).SetName("FrameRate_FromBase_MegaframePerSecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMillisecond, 1d, 0.001d).SetName("FrameRate_FromBase_FramePerMillisecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerDay, 1d, 86400.0d).SetName("FrameRate_FromBase_FramePerDay");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerWeek, 1d, 604800.0d).SetName("FrameRate_FromBase_FramePerWeek");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Kilohertz, 1d, 0.001d).SetName("FrameRate_FromBase_Kilohertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.Megahertz, 1d, 9.9999999999999995e-07d).SetName("FrameRate_FromBase_Megahertz");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMicrosecond, 1d, 9.9999999999999995e-07d).SetName("FrameRate_FromBase_FramePerMicrosecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerNanosecond, 1d, 1.0000000000000001e-09d).SetName("FrameRate_FromBase_FramePerNanosecond");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerMonthJulian, 1d, 2629800.0d).SetName("FrameRate_FromBase_FramePerMonthJulian");
            yield return new TestCaseData(UnitToolsFrameRateUnit.FramePerYearJulian, 1d, 31557600.000000004d).SetName("FrameRate_FromBase_FramePerYearJulian");
        }
    }
}
