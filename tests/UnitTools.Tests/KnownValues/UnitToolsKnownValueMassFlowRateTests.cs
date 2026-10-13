namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MassFlowRate;

    public sealed class UnitToolsKnownValueMassFlowRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MassFlowRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsMassFlowRateUnit unit, double input, double expected)
        {
            double result = UnitToolsMassFlowRate.ToKilogramPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MassFlowRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsMassFlowRateUnit unit, double input, double expected)
        {
            double result = UnitToolsMassFlowRate.FromKilogramPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MassFlowRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMassFlowRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMassFlowRate.ToKilogramPerSecond(input, unit);
            double result = UnitToolsMassFlowRate.FromKilogramPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerSecond, 1d, 1.0d).SetName("MassFlowRate_ToBase_KilogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerMinute, 1d, 0.016666666666666666d).SetName("MassFlowRate_ToBase_KilogramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerHour, 1d, 0.00027777777777777778d).SetName("MassFlowRate_ToBase_KilogramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerSecond, 1d, 0.001d).SetName("MassFlowRate_ToBase_GramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerMinute, 1d, 1.6666666666666667e-05d).SetName("MassFlowRate_ToBase_GramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerHour, 1d, 0.27777777777777779d).SetName("MassFlowRate_ToBase_MetricTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerSecond, 1d, 0.45359237000000002d).SetName("MassFlowRate_ToBase_PoundPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerMinute, 1d, 0.0075598728333333334d).SetName("MassFlowRate_ToBase_PoundPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerHour, 1d, 0.00012599788055555556d).SetName("MassFlowRate_ToBase_PoundPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.OuncePerSecond, 1d, 0.028349523125000001d).SetName("MassFlowRate_ToBase_OuncePerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerDay, 1d, 1.1574074074074073e-05d).SetName("MassFlowRate_ToBase_KilogramPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerHour, 1d, 2.7777777777777776e-07d).SetName("MassFlowRate_ToBase_GramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerDay, 1d, 1.1574074074074074e-08d).SetName("MassFlowRate_ToBase_GramPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerSecond, 1d, 9.9999999999999995e-07d).SetName("MassFlowRate_ToBase_MilligramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerMinute, 1d, 1.6666666666666667e-08d).SetName("MassFlowRate_ToBase_MilligramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerHour, 1d, 2.7777777777777777e-10d).SetName("MassFlowRate_ToBase_MilligramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerSecond, 1d, 1000.0d).SetName("MassFlowRate_ToBase_MetricTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerDay, 1d, 0.011574074074074073d).SetName("MassFlowRate_ToBase_MetricTonPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerDay, 1d, 5.2499116898148151e-06d).SetName("MassFlowRate_ToBase_PoundPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.OuncePerMinute, 1d, 0.00047249205208333334d).SetName("MassFlowRate_ToBase_OuncePerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerHour, 1d, 0.25199576111111111d).SetName("MassFlowRate_ToBase_ShortTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerHour, 1d, 0.28223525244444442d).SetName("MassFlowRate_ToBase_LongTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.SlugPerSecond, 1d, 14.59390294d).SetName("MassFlowRate_ToBase_SlugPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.SlugPerMinute, 1d, 0.24323171566666665d).SetName("MassFlowRate_ToBase_SlugPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerMillisecond, 1d, 1000.0d).SetName("MassFlowRate_ToBase_KilogramPerMillisecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerMillisecond, 1d, 1.0d).SetName("MassFlowRate_ToBase_GramPerMillisecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MicrogramPerSecond, 1d, 1.0000000000000001e-09d).SetName("MassFlowRate_ToBase_MicrogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.NanogramPerSecond, 1d, 9.9999999999999998e-13d).SetName("MassFlowRate_ToBase_NanogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerSecond, 1d, 907.18474000000003d).SetName("MassFlowRate_ToBase_ShortTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerDay, 1d, 0.01049982337962963d).SetName("MassFlowRate_ToBase_ShortTonPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerSecond, 1d, 1016.0469088d).SetName("MassFlowRate_ToBase_LongTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerDay, 1d, 0.011759802185185185d).SetName("MassFlowRate_ToBase_LongTonPerDay");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerSecond, 1d, 1.0d).SetName("MassFlowRate_FromBase_KilogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerMinute, 1d, 60.0d).SetName("MassFlowRate_FromBase_KilogramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerHour, 1d, 3600.0d).SetName("MassFlowRate_FromBase_KilogramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerSecond, 1d, 1000.0d).SetName("MassFlowRate_FromBase_GramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerMinute, 1d, 60000.0d).SetName("MassFlowRate_FromBase_GramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerHour, 1d, 3.5999999999999996d).SetName("MassFlowRate_FromBase_MetricTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerSecond, 1d, 2.2046226218487757d).SetName("MassFlowRate_FromBase_PoundPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerMinute, 1d, 132.27735731092656d).SetName("MassFlowRate_FromBase_PoundPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerHour, 1d, 7936.6414386555925d).SetName("MassFlowRate_FromBase_PoundPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.OuncePerSecond, 1d, 35.273961949580411d).SetName("MassFlowRate_FromBase_OuncePerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerDay, 1d, 86400.0d).SetName("MassFlowRate_FromBase_KilogramPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerHour, 1d, 3600000.0000000005d).SetName("MassFlowRate_FromBase_GramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerDay, 1d, 86400000.0d).SetName("MassFlowRate_FromBase_GramPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerSecond, 1d, 1000000.0d).SetName("MassFlowRate_FromBase_MilligramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerMinute, 1d, 60000000.0d).SetName("MassFlowRate_FromBase_MilligramPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MilligramPerHour, 1d, 3600000000.0d).SetName("MassFlowRate_FromBase_MilligramPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerSecond, 1d, 0.001d).SetName("MassFlowRate_FromBase_MetricTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MetricTonPerDay, 1d, 86.400000000000006d).SetName("MassFlowRate_FromBase_MetricTonPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.PoundPerDay, 1d, 190479.39452773423d).SetName("MassFlowRate_FromBase_PoundPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.OuncePerMinute, 1d, 2116.437716974825d).SetName("MassFlowRate_FromBase_OuncePerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerHour, 1d, 3.9683207193277967d).SetName("MassFlowRate_FromBase_ShortTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerHour, 1d, 3.5431434993998185d).SetName("MassFlowRate_FromBase_LongTonPerHour");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.SlugPerSecond, 1d, 0.068521765843674989d).SetName("MassFlowRate_FromBase_SlugPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.SlugPerMinute, 1d, 4.1113059506204994d).SetName("MassFlowRate_FromBase_SlugPerMinute");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.KilogramPerMillisecond, 1d, 0.001d).SetName("MassFlowRate_FromBase_KilogramPerMillisecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.GramPerMillisecond, 1d, 1.0d).SetName("MassFlowRate_FromBase_GramPerMillisecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.MicrogramPerSecond, 1d, 999999999.99999988d).SetName("MassFlowRate_FromBase_MicrogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.NanogramPerSecond, 1d, 1000000000000.0d).SetName("MassFlowRate_FromBase_NanogramPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerSecond, 1d, 0.0011023113109243879d).SetName("MassFlowRate_FromBase_ShortTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.ShortTonPerDay, 1d, 95.239697263867114d).SetName("MassFlowRate_FromBase_ShortTonPerDay");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerSecond, 1d, 0.00098420652761106058d).SetName("MassFlowRate_FromBase_LongTonPerSecond");
            yield return new TestCaseData(UnitToolsMassFlowRateUnit.LongTonPerDay, 1d, 85.035443985595649d).SetName("MassFlowRate_FromBase_LongTonPerDay");
        }
    }
}
