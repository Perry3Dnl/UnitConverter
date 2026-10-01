namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Speed;

    public sealed class UnitConverterKnownValueSpeedTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Speed_ToBaseUnit_ReturnsExpectedValue(UnitConverterSpeedUnit unit, double input, double expected)
        {
            double result = UnitConverterSpeed.ToMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Speed_FromBaseUnit_ReturnsExpectedValue(UnitConverterSpeedUnit unit, double input, double expected)
        {
            double result = UnitConverterSpeed.FromMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Speed_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSpeedUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSpeed.ToMeterPerSecond(input, unit);
            double result = UnitConverterSpeed.FromMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerSecond, 1d, 1.0d).SetName("Speed_ToBase_MeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.KilometerPerHour, 1d, 0.27777777777777779d).SetName("Speed_ToBase_KilometerPerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.FootPerSecond, 1d, 0.30480000000000002d).SetName("Speed_ToBase_FootPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MilePerHour, 1d, 0.44703999999999999d).SetName("Speed_ToBase_MilePerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.Knot, 1d, 0.51444444444444448d).SetName("Speed_ToBase_Knot");
            yield return new TestCaseData(UnitConverterSpeedUnit.MachAtSeaLevel, 1d, 340.29000000000002d).SetName("Speed_ToBase_MachAtSeaLevel");
            yield return new TestCaseData(UnitConverterSpeedUnit.SpeedOfLight, 1d, 299792458.0d).SetName("Speed_ToBase_SpeedOfLight");
            yield return new TestCaseData(UnitConverterSpeedUnit.MicrometerPerSecond, 1d, 9.9999999999999995e-07d).SetName("Speed_ToBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.CentimeterPerSecond, 1d, 0.01d).SetName("Speed_ToBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MillimeterPerSecond, 1d, 0.001d).SetName("Speed_ToBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerMinute, 1d, 0.016666666666666666d).SetName("Speed_ToBase_MeterPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerHour, 1d, 0.00027777777777777778d).SetName("Speed_ToBase_MeterPerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.KilometerPerSecond, 1d, 1000.0d).SetName("Speed_ToBase_KilometerPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.InchPerSecond, 1d, 0.025399999999999999d).SetName("Speed_ToBase_InchPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.InchPerMinute, 1d, 0.00042333333333333334d).SetName("Speed_ToBase_InchPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.FootPerMinute, 1d, 0.0050800000000000003d).SetName("Speed_ToBase_FootPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.YardPerSecond, 1d, 0.91439999999999999d).SetName("Speed_ToBase_YardPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MilePerSecond, 1d, 1609.3440000000001d).SetName("Speed_ToBase_MilePerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.SpeedOfSoundAirApprox, 1d, 343.0d).SetName("Speed_ToBase_SpeedOfSoundAirApprox");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerSecond, 1d, 1.0d).SetName("Speed_FromBase_MeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.KilometerPerHour, 1d, 3.5999999999999996d).SetName("Speed_FromBase_KilometerPerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.FootPerSecond, 1d, 3.280839895013123d).SetName("Speed_FromBase_FootPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MilePerHour, 1d, 2.2369362920544025d).SetName("Speed_FromBase_MilePerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.Knot, 1d, 1.9438444924406046d).SetName("Speed_FromBase_Knot");
            yield return new TestCaseData(UnitConverterSpeedUnit.MachAtSeaLevel, 1d, 0.0029386699579770194d).SetName("Speed_FromBase_MachAtSeaLevel");
            yield return new TestCaseData(UnitConverterSpeedUnit.SpeedOfLight, 1d, 3.3356409519815204e-09d).SetName("Speed_FromBase_SpeedOfLight");
            yield return new TestCaseData(UnitConverterSpeedUnit.MicrometerPerSecond, 1d, 1000000.0d).SetName("Speed_FromBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.CentimeterPerSecond, 1d, 100.0d).SetName("Speed_FromBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MillimeterPerSecond, 1d, 1000.0d).SetName("Speed_FromBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerMinute, 1d, 60.0d).SetName("Speed_FromBase_MeterPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.MeterPerHour, 1d, 3600.0d).SetName("Speed_FromBase_MeterPerHour");
            yield return new TestCaseData(UnitConverterSpeedUnit.KilometerPerSecond, 1d, 0.001d).SetName("Speed_FromBase_KilometerPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.InchPerSecond, 1d, 39.370078740157481d).SetName("Speed_FromBase_InchPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.InchPerMinute, 1d, 2362.2047244094488d).SetName("Speed_FromBase_InchPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.FootPerMinute, 1d, 196.85039370078738d).SetName("Speed_FromBase_FootPerMinute");
            yield return new TestCaseData(UnitConverterSpeedUnit.YardPerSecond, 1d, 1.0936132983377078d).SetName("Speed_FromBase_YardPerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.MilePerSecond, 1d, 0.00062137119223733392d).SetName("Speed_FromBase_MilePerSecond");
            yield return new TestCaseData(UnitConverterSpeedUnit.SpeedOfSoundAirApprox, 1d, 0.0029154518950437317d).SetName("Speed_FromBase_SpeedOfSoundAirApprox");
        }
    }
}
