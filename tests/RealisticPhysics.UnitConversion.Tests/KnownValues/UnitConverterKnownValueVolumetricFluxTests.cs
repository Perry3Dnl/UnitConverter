namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.VolumetricFlux;

    public sealed class UnitConverterKnownValueVolumetricFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void VolumetricFlux_ToBaseUnit_ReturnsExpectedValue(UnitConverterVolumetricFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterVolumetricFlux.ToMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void VolumetricFlux_FromBaseUnit_ReturnsExpectedValue(UnitConverterVolumetricFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterVolumetricFlux.FromMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void VolumetricFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterVolumetricFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterVolumetricFlux.ToMeterPerSecond(input, unit);
            double result = UnitConverterVolumetricFlux.FromMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerSecond, 1d, 1.0d).SetName("VolumetricFlux_ToBase_MeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.CentimeterPerSecond, 1d, 0.01d).SetName("VolumetricFlux_ToBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MillimeterPerSecond, 1d, 0.001d).SetName("VolumetricFlux_ToBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerHour, 1d, 0.00027777777777777778d).SetName("VolumetricFlux_ToBase_MeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.FootPerSecond, 1d, 0.30480000000000002d).SetName("VolumetricFlux_ToBase_FootPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.FootPerMinute, 1d, 0.0050800000000000003d).SetName("VolumetricFlux_ToBase_FootPerMinute");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MicrometerPerSecond, 1d, 9.9999999999999995e-07d).SetName("VolumetricFlux_ToBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerDay, 1d, 1.1574074074074073e-05d).SetName("VolumetricFlux_ToBase_MeterPerDay");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MillimeterPerHour, 1d, 2.7777777777777776e-07d).SetName("VolumetricFlux_ToBase_MillimeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.CentimeterPerHour, 1d, 2.7777777777777779e-06d).SetName("VolumetricFlux_ToBase_CentimeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerSecond, 1d, 0.025399999999999999d).SetName("VolumetricFlux_ToBase_InchPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerMinute, 1d, 0.00042333333333333334d).SetName("VolumetricFlux_ToBase_InchPerMinute");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerHour, 1d, 7.055555555555555e-06d).SetName("VolumetricFlux_ToBase_InchPerHour");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerSecond, 1d, 1.0d).SetName("VolumetricFlux_FromBase_MeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.CentimeterPerSecond, 1d, 100.0d).SetName("VolumetricFlux_FromBase_CentimeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MillimeterPerSecond, 1d, 1000.0d).SetName("VolumetricFlux_FromBase_MillimeterPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerHour, 1d, 3600.0d).SetName("VolumetricFlux_FromBase_MeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.FootPerSecond, 1d, 3.280839895013123d).SetName("VolumetricFlux_FromBase_FootPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.FootPerMinute, 1d, 196.85039370078738d).SetName("VolumetricFlux_FromBase_FootPerMinute");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MicrometerPerSecond, 1d, 1000000.0d).SetName("VolumetricFlux_FromBase_MicrometerPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MeterPerDay, 1d, 86400.0d).SetName("VolumetricFlux_FromBase_MeterPerDay");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.MillimeterPerHour, 1d, 3600000.0000000005d).SetName("VolumetricFlux_FromBase_MillimeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.CentimeterPerHour, 1d, 360000.0d).SetName("VolumetricFlux_FromBase_CentimeterPerHour");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerSecond, 1d, 39.370078740157481d).SetName("VolumetricFlux_FromBase_InchPerSecond");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerMinute, 1d, 2362.2047244094488d).SetName("VolumetricFlux_FromBase_InchPerMinute");
            yield return new TestCaseData(UnitConverterVolumetricFluxUnit.InchPerHour, 1d, 141732.28346456695d).SetName("VolumetricFlux_FromBase_InchPerHour");
        }
    }
}
