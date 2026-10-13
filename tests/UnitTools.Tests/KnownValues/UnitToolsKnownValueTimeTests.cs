namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Time;

    public sealed class UnitToolsKnownValueTimeTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Time_ToBaseUnit_ReturnsExpectedValue(UnitToolsTimeUnit unit, double input, double expected)
        {
            double result = UnitToolsTime.ToSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Time_FromBaseUnit_ReturnsExpectedValue(UnitToolsTimeUnit unit, double input, double expected)
        {
            double result = UnitToolsTime.FromSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Time_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsTimeUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsTime.ToSecond(input, unit);
            double result = UnitToolsTime.FromSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsTimeUnit.Nanosecond, 1d, 1.0000000000000001e-09d).SetName("Time_ToBase_Nanosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Microsecond, 1d, 9.9999999999999995e-07d).SetName("Time_ToBase_Microsecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Millisecond, 1d, 0.001d).SetName("Time_ToBase_Millisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Second, 1d, 1.0d).SetName("Time_ToBase_Second");
            yield return new TestCaseData(UnitToolsTimeUnit.Minute, 1d, 60.0d).SetName("Time_ToBase_Minute");
            yield return new TestCaseData(UnitToolsTimeUnit.Hour, 1d, 3600.0d).SetName("Time_ToBase_Hour");
            yield return new TestCaseData(UnitToolsTimeUnit.Day, 1d, 86400.0d).SetName("Time_ToBase_Day");
            yield return new TestCaseData(UnitToolsTimeUnit.Week, 1d, 604800.0d).SetName("Time_ToBase_Week");
            yield return new TestCaseData(UnitToolsTimeUnit.Fortnight, 1d, 1209600.0d).SetName("Time_ToBase_Fortnight");
            yield return new TestCaseData(UnitToolsTimeUnit.JulianYear, 1d, 31557600.0d).SetName("Time_ToBase_JulianYear");
            yield return new TestCaseData(UnitToolsTimeUnit.CommonYear, 1d, 31536000.0d).SetName("Time_ToBase_CommonYear");
            yield return new TestCaseData(UnitToolsTimeUnit.Femtosecond, 1d, 1.0000000000000001e-15d).SetName("Time_ToBase_Femtosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Picosecond, 1d, 9.9999999999999998e-13d).SetName("Time_ToBase_Picosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Decisecond, 1d, 0.10000000000000001d).SetName("Time_ToBase_Decisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Centisecond, 1d, 0.01d).SetName("Time_ToBase_Centisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Shake, 1d, 1e-08d).SetName("Time_ToBase_Shake");
            yield return new TestCaseData(UnitToolsTimeUnit.Svedberg, 1d, 1e-13d).SetName("Time_ToBase_Svedberg");
            yield return new TestCaseData(UnitToolsTimeUnit.SiderealDay, 1d, 86164.090500000006d).SetName("Time_ToBase_SiderealDay");
            yield return new TestCaseData(UnitToolsTimeUnit.TropicalYear, 1d, 31556925.215999998d).SetName("Time_ToBase_TropicalYear");
            yield return new TestCaseData(UnitToolsTimeUnit.SiderealYear, 1d, 31558149.763545599d).SetName("Time_ToBase_SiderealYear");
            yield return new TestCaseData(UnitToolsTimeUnit.JulianMonth, 1d, 2629800.0d).SetName("Time_ToBase_JulianMonth");
            yield return new TestCaseData(UnitToolsTimeUnit.ThirtyDayMonth, 1d, 2592000.0d).SetName("Time_ToBase_ThirtyDayMonth");
            yield return new TestCaseData(UnitToolsTimeUnit.Decade, 1d, 315576000.0d).SetName("Time_ToBase_Decade");
            yield return new TestCaseData(UnitToolsTimeUnit.Century, 1d, 3155760000.0d).SetName("Time_ToBase_Century");
            yield return new TestCaseData(UnitToolsTimeUnit.Millennium, 1d, 31557600000.0d).SetName("Time_ToBase_Millennium");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsTimeUnit.Nanosecond, 1d, 999999999.99999988d).SetName("Time_FromBase_Nanosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Microsecond, 1d, 1000000.0d).SetName("Time_FromBase_Microsecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Millisecond, 1d, 1000.0d).SetName("Time_FromBase_Millisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Second, 1d, 1.0d).SetName("Time_FromBase_Second");
            yield return new TestCaseData(UnitToolsTimeUnit.Minute, 1d, 0.016666666666666666d).SetName("Time_FromBase_Minute");
            yield return new TestCaseData(UnitToolsTimeUnit.Hour, 1d, 0.00027777777777777778d).SetName("Time_FromBase_Hour");
            yield return new TestCaseData(UnitToolsTimeUnit.Day, 1d, 1.1574074074074073e-05d).SetName("Time_FromBase_Day");
            yield return new TestCaseData(UnitToolsTimeUnit.Week, 1d, 1.6534391534391535e-06d).SetName("Time_FromBase_Week");
            yield return new TestCaseData(UnitToolsTimeUnit.Fortnight, 1d, 8.2671957671957675e-07d).SetName("Time_FromBase_Fortnight");
            yield return new TestCaseData(UnitToolsTimeUnit.JulianYear, 1d, 3.1688087814028947e-08d).SetName("Time_FromBase_JulianYear");
            yield return new TestCaseData(UnitToolsTimeUnit.CommonYear, 1d, 3.1709791983764586e-08d).SetName("Time_FromBase_CommonYear");
            yield return new TestCaseData(UnitToolsTimeUnit.Femtosecond, 1d, 999999999999999.88d).SetName("Time_FromBase_Femtosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Picosecond, 1d, 1000000000000.0d).SetName("Time_FromBase_Picosecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Decisecond, 1d, 10.0d).SetName("Time_FromBase_Decisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Centisecond, 1d, 100.0d).SetName("Time_FromBase_Centisecond");
            yield return new TestCaseData(UnitToolsTimeUnit.Shake, 1d, 100000000.0d).SetName("Time_FromBase_Shake");
            yield return new TestCaseData(UnitToolsTimeUnit.Svedberg, 1d, 10000000000000.0d).SetName("Time_FromBase_Svedberg");
            yield return new TestCaseData(UnitToolsTimeUnit.SiderealDay, 1d, 1.1605762843861271e-05d).SetName("Time_FromBase_SiderealDay");
            yield return new TestCaseData(UnitToolsTimeUnit.TropicalYear, 1d, 3.1688765402688213e-08d).SetName("Time_FromBase_TropicalYear");
            yield return new TestCaseData(UnitToolsTimeUnit.SiderealYear, 1d, 3.1687535786877792e-08d).SetName("Time_FromBase_SiderealYear");
            yield return new TestCaseData(UnitToolsTimeUnit.JulianMonth, 1d, 3.8025705376834739e-07d).SetName("Time_FromBase_JulianMonth");
            yield return new TestCaseData(UnitToolsTimeUnit.ThirtyDayMonth, 1d, 3.8580246913580245e-07d).SetName("Time_FromBase_ThirtyDayMonth");
            yield return new TestCaseData(UnitToolsTimeUnit.Decade, 1d, 3.1688087814028949e-09d).SetName("Time_FromBase_Decade");
            yield return new TestCaseData(UnitToolsTimeUnit.Century, 1d, 3.1688087814028952e-10d).SetName("Time_FromBase_Century");
            yield return new TestCaseData(UnitToolsTimeUnit.Millennium, 1d, 3.1688087814028948e-11d).SetName("Time_FromBase_Millennium");
        }
    }
}
