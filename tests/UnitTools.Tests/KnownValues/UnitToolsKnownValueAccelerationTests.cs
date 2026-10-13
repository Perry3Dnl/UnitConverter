namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Acceleration;

    public sealed class UnitToolsKnownValueAccelerationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Acceleration_ToBaseUnit_ReturnsExpectedValue(UnitToolsAccelerationUnit unit, double input, double expected)
        {
            double result = UnitToolsAcceleration.ToMeterPerSecondSquared(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Acceleration_FromBaseUnit_ReturnsExpectedValue(UnitToolsAccelerationUnit unit, double input, double expected)
        {
            double result = UnitToolsAcceleration.FromMeterPerSecondSquared(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Acceleration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsAccelerationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsAcceleration.ToMeterPerSecondSquared(input, unit);
            double result = UnitToolsAcceleration.FromMeterPerSecondSquared(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsAccelerationUnit.MeterPerSecondSquared, 1d, 1.0d).SetName("Acceleration_ToBase_MeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.FootPerSecondSquared, 1d, 0.30480000000000002d).SetName("Acceleration_ToBase_FootPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Galileo, 1d, 0.01d).SetName("Acceleration_ToBase_Galileo");
            yield return new TestCaseData(UnitToolsAccelerationUnit.StandardGravity, 1d, 9.8066499999999994d).SetName("Acceleration_ToBase_StandardGravity");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KilometerPerHourPerSecond, 1d, 0.27777777777777779d).SetName("Acceleration_ToBase_KilometerPerHourPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MilePerHourPerSecond, 1d, 0.44703999999999999d).SetName("Acceleration_ToBase_MilePerHourPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.InchPerSecondSquared, 1d, 0.025399999999999999d).SetName("Acceleration_ToBase_InchPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.YardPerSecondSquared, 1d, 0.91439999999999999d).SetName("Acceleration_ToBase_YardPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.CentimeterPerSecondSquared, 1d, 0.01d).SetName("Acceleration_ToBase_CentimeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MillimeterPerSecondSquared, 1d, 0.001d).SetName("Acceleration_ToBase_MillimeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KilometerPerSecondSquared, 1d, 1000.0d).SetName("Acceleration_ToBase_KilometerPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.FootPerMinuteSquared, 1d, 8.4666666666666674e-05d).SetName("Acceleration_ToBase_FootPerMinuteSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MeterPerMinuteSquared, 1d, 0.00027777777777777778d).SetName("Acceleration_ToBase_MeterPerMinuteSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KnotPerSecond, 1d, 0.51444444444444448d).SetName("Acceleration_ToBase_KnotPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Gal, 1d, 0.01d).SetName("Acceleration_ToBase_Gal");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Milligal, 1d, 1.0000000000000001e-05d).SetName("Acceleration_ToBase_Milligal");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Microgal, 1d, 1e-08d).SetName("Acceleration_ToBase_Microgal");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsAccelerationUnit.MeterPerSecondSquared, 1d, 1.0d).SetName("Acceleration_FromBase_MeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.FootPerSecondSquared, 1d, 3.280839895013123d).SetName("Acceleration_FromBase_FootPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Galileo, 1d, 100.0d).SetName("Acceleration_FromBase_Galileo");
            yield return new TestCaseData(UnitToolsAccelerationUnit.StandardGravity, 1d, 0.10197162129779283d).SetName("Acceleration_FromBase_StandardGravity");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KilometerPerHourPerSecond, 1d, 3.5999999999999996d).SetName("Acceleration_FromBase_KilometerPerHourPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MilePerHourPerSecond, 1d, 2.2369362920544025d).SetName("Acceleration_FromBase_MilePerHourPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.InchPerSecondSquared, 1d, 39.370078740157481d).SetName("Acceleration_FromBase_InchPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.YardPerSecondSquared, 1d, 1.0936132983377078d).SetName("Acceleration_FromBase_YardPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.CentimeterPerSecondSquared, 1d, 100.0d).SetName("Acceleration_FromBase_CentimeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MillimeterPerSecondSquared, 1d, 1000.0d).SetName("Acceleration_FromBase_MillimeterPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KilometerPerSecondSquared, 1d, 0.001d).SetName("Acceleration_FromBase_KilometerPerSecondSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.FootPerMinuteSquared, 1d, 11811.023622047243d).SetName("Acceleration_FromBase_FootPerMinuteSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.MeterPerMinuteSquared, 1d, 3600.0d).SetName("Acceleration_FromBase_MeterPerMinuteSquared");
            yield return new TestCaseData(UnitToolsAccelerationUnit.KnotPerSecond, 1d, 1.9438444924406046d).SetName("Acceleration_FromBase_KnotPerSecond");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Gal, 1d, 100.0d).SetName("Acceleration_FromBase_Gal");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Milligal, 1d, 99999.999999999985d).SetName("Acceleration_FromBase_Milligal");
            yield return new TestCaseData(UnitToolsAccelerationUnit.Microgal, 1d, 100000000.0d).SetName("Acceleration_FromBase_Microgal");
        }
    }
}
