namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Speed;

    public sealed class UnitToolsKnownValueSpeedTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Speed_ToBaseUnit_ReturnsExpectedValue(UnitToolsSpeedUnit unit, double input, double expected)
        {
            double result = UnitToolsSpeed.ToMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Speed_FromBaseUnit_ReturnsExpectedValue(UnitToolsSpeedUnit unit, double input, double expected)
        {
            double result = UnitToolsSpeed.FromMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Speed_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsSpeedUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsSpeed.ToMeterPerSecond(input, unit);
            double result = UnitToolsSpeed.FromMeterPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerSecond, 1d, 1.0d).SetName("Speed_ToBase_MeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.KilometerPerHour, 1d, 0.27777777777777779d).SetName("Speed_ToBase_KilometerPerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.FootPerSecond, 1d, 0.30480000000000002d).SetName("Speed_ToBase_FootPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MilePerHour, 1d, 0.44703999999999999d).SetName("Speed_ToBase_MilePerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.Knot, 1d, 0.51444444444444448d).SetName("Speed_ToBase_Knot");
            yield return new TestCaseData(UnitToolsSpeedUnit.MachAtSeaLevel, 1d, 340.29000000000002d).SetName("Speed_ToBase_MachAtSeaLevel");
            yield return new TestCaseData(UnitToolsSpeedUnit.SpeedOfLight, 1d, 299792458.0d).SetName("Speed_ToBase_SpeedOfLight");
            yield return new TestCaseData(UnitToolsSpeedUnit.MicrometerPerSecond, 1d, 9.9999999999999995e-07d).SetName("Speed_ToBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.CentimeterPerSecond, 1d, 0.01d).SetName("Speed_ToBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MillimeterPerSecond, 1d, 0.001d).SetName("Speed_ToBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerMinute, 1d, 0.016666666666666666d).SetName("Speed_ToBase_MeterPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerHour, 1d, 0.00027777777777777778d).SetName("Speed_ToBase_MeterPerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.KilometerPerSecond, 1d, 1000.0d).SetName("Speed_ToBase_KilometerPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.InchPerSecond, 1d, 0.025399999999999999d).SetName("Speed_ToBase_InchPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.InchPerMinute, 1d, 0.00042333333333333334d).SetName("Speed_ToBase_InchPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.FootPerMinute, 1d, 0.0050800000000000003d).SetName("Speed_ToBase_FootPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.YardPerSecond, 1d, 0.91439999999999999d).SetName("Speed_ToBase_YardPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MilePerSecond, 1d, 1609.3440000000001d).SetName("Speed_ToBase_MilePerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.SpeedOfSoundAirApprox, 1d, 343.0d).SetName("Speed_ToBase_SpeedOfSoundAirApprox");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerSecond, 1d, 1.0d).SetName("Speed_FromBase_MeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.KilometerPerHour, 1d, 3.5999999999999996d).SetName("Speed_FromBase_KilometerPerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.FootPerSecond, 1d, 3.280839895013123d).SetName("Speed_FromBase_FootPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MilePerHour, 1d, 2.2369362920544025d).SetName("Speed_FromBase_MilePerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.Knot, 1d, 1.9438444924406046d).SetName("Speed_FromBase_Knot");
            yield return new TestCaseData(UnitToolsSpeedUnit.MachAtSeaLevel, 1d, 0.0029386699579770194d).SetName("Speed_FromBase_MachAtSeaLevel");
            yield return new TestCaseData(UnitToolsSpeedUnit.SpeedOfLight, 1d, 3.3356409519815204e-09d).SetName("Speed_FromBase_SpeedOfLight");
            yield return new TestCaseData(UnitToolsSpeedUnit.MicrometerPerSecond, 1d, 1000000.0d).SetName("Speed_FromBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.CentimeterPerSecond, 1d, 100.0d).SetName("Speed_FromBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MillimeterPerSecond, 1d, 1000.0d).SetName("Speed_FromBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerMinute, 1d, 60.0d).SetName("Speed_FromBase_MeterPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.MeterPerHour, 1d, 3600.0d).SetName("Speed_FromBase_MeterPerHour");
            yield return new TestCaseData(UnitToolsSpeedUnit.KilometerPerSecond, 1d, 0.001d).SetName("Speed_FromBase_KilometerPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.InchPerSecond, 1d, 39.370078740157481d).SetName("Speed_FromBase_InchPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.InchPerMinute, 1d, 2362.2047244094488d).SetName("Speed_FromBase_InchPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.FootPerMinute, 1d, 196.85039370078738d).SetName("Speed_FromBase_FootPerMinute");
            yield return new TestCaseData(UnitToolsSpeedUnit.YardPerSecond, 1d, 1.0936132983377078d).SetName("Speed_FromBase_YardPerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.MilePerSecond, 1d, 0.00062137119223733392d).SetName("Speed_FromBase_MilePerSecond");
            yield return new TestCaseData(UnitToolsSpeedUnit.SpeedOfSoundAirApprox, 1d, 0.0029154518950437317d).SetName("Speed_FromBase_SpeedOfSoundAirApprox");
        }
    }
}
