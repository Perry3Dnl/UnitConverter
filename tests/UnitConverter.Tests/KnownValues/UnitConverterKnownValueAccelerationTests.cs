namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Acceleration;

    public sealed class UnitConverterKnownValueAccelerationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Acceleration_ToBaseUnit_ReturnsExpectedValue(UnitConverterAccelerationUnit unit, double input, double expected)
        {
            double result = UnitConverterAcceleration.ToMeterPerSecondSquared(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Acceleration_FromBaseUnit_ReturnsExpectedValue(UnitConverterAccelerationUnit unit, double input, double expected)
        {
            double result = UnitConverterAcceleration.FromMeterPerSecondSquared(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Acceleration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAccelerationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAcceleration.ToMeterPerSecondSquared(input, unit);
            double result = UnitConverterAcceleration.FromMeterPerSecondSquared(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAccelerationUnit.MeterPerSecondSquared, 1d, 1.0d).SetName("Acceleration_ToBase_MeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.FootPerSecondSquared, 1d, 0.30480000000000002d).SetName("Acceleration_ToBase_FootPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Galileo, 1d, 0.01d).SetName("Acceleration_ToBase_Galileo");
            yield return new TestCaseData(UnitConverterAccelerationUnit.StandardGravity, 1d, 9.8066499999999994d).SetName("Acceleration_ToBase_StandardGravity");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KilometerPerHourPerSecond, 1d, 0.27777777777777779d).SetName("Acceleration_ToBase_KilometerPerHourPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MilePerHourPerSecond, 1d, 0.44703999999999999d).SetName("Acceleration_ToBase_MilePerHourPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.InchPerSecondSquared, 1d, 0.025399999999999999d).SetName("Acceleration_ToBase_InchPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.YardPerSecondSquared, 1d, 0.91439999999999999d).SetName("Acceleration_ToBase_YardPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.CentimeterPerSecondSquared, 1d, 0.01d).SetName("Acceleration_ToBase_CentimeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MillimeterPerSecondSquared, 1d, 0.001d).SetName("Acceleration_ToBase_MillimeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KilometerPerSecondSquared, 1d, 1000.0d).SetName("Acceleration_ToBase_KilometerPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.FootPerMinuteSquared, 1d, 8.4666666666666674e-05d).SetName("Acceleration_ToBase_FootPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MeterPerMinuteSquared, 1d, 0.00027777777777777778d).SetName("Acceleration_ToBase_MeterPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KnotPerSecond, 1d, 0.51444444444444448d).SetName("Acceleration_ToBase_KnotPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Gal, 1d, 0.01d).SetName("Acceleration_ToBase_Gal");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Milligal, 1d, 1.0000000000000001e-05d).SetName("Acceleration_ToBase_Milligal");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Microgal, 1d, 1e-08d).SetName("Acceleration_ToBase_Microgal");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAccelerationUnit.MeterPerSecondSquared, 1d, 1.0d).SetName("Acceleration_FromBase_MeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.FootPerSecondSquared, 1d, 3.280839895013123d).SetName("Acceleration_FromBase_FootPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Galileo, 1d, 100.0d).SetName("Acceleration_FromBase_Galileo");
            yield return new TestCaseData(UnitConverterAccelerationUnit.StandardGravity, 1d, 0.10197162129779283d).SetName("Acceleration_FromBase_StandardGravity");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KilometerPerHourPerSecond, 1d, 3.5999999999999996d).SetName("Acceleration_FromBase_KilometerPerHourPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MilePerHourPerSecond, 1d, 2.2369362920544025d).SetName("Acceleration_FromBase_MilePerHourPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.InchPerSecondSquared, 1d, 39.370078740157481d).SetName("Acceleration_FromBase_InchPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.YardPerSecondSquared, 1d, 1.0936132983377078d).SetName("Acceleration_FromBase_YardPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.CentimeterPerSecondSquared, 1d, 100.0d).SetName("Acceleration_FromBase_CentimeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MillimeterPerSecondSquared, 1d, 1000.0d).SetName("Acceleration_FromBase_MillimeterPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KilometerPerSecondSquared, 1d, 0.001d).SetName("Acceleration_FromBase_KilometerPerSecondSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.FootPerMinuteSquared, 1d, 11811.023622047243d).SetName("Acceleration_FromBase_FootPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.MeterPerMinuteSquared, 1d, 3600.0d).SetName("Acceleration_FromBase_MeterPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAccelerationUnit.KnotPerSecond, 1d, 1.9438444924406046d).SetName("Acceleration_FromBase_KnotPerSecond");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Gal, 1d, 100.0d).SetName("Acceleration_FromBase_Gal");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Milligal, 1d, 99999.999999999985d).SetName("Acceleration_FromBase_Milligal");
            yield return new TestCaseData(UnitConverterAccelerationUnit.Microgal, 1d, 100000000.0d).SetName("Acceleration_FromBase_Microgal");
        }
    }
}
