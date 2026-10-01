namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.TorquePerAngle;

    public sealed class UnitConverterKnownValueTorquePerAngleTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void TorquePerAngle_ToBaseUnit_ReturnsExpectedValue(UnitConverterTorquePerAngleUnit unit, double input, double expected)
        {
            double result = UnitConverterTorquePerAngle.ToNewtonMeterPerRadian(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void TorquePerAngle_FromBaseUnit_ReturnsExpectedValue(UnitConverterTorquePerAngleUnit unit, double input, double expected)
        {
            double result = UnitConverterTorquePerAngle.FromNewtonMeterPerRadian(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void TorquePerAngle_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterTorquePerAngleUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterTorquePerAngle.ToNewtonMeterPerRadian(input, unit);
            double result = UnitConverterTorquePerAngle.FromNewtonMeterPerRadian(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian, 1d, 1.0d).SetName("TorquePerAngle_ToBase_NewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree, 1d, 57.295779513082323d).SetName("TorquePerAngle_ToBase_NewtonMeterPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn, 1d, 0.15915494309189535d).SetName("TorquePerAngle_ToBase_NewtonMeterPerTurn");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian, 1d, 1.3558179483314003d).SetName("TorquePerAngle_ToBase_PoundForceFootPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian, 1d, 0.001d).SetName("TorquePerAngle_ToBase_MillinewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian, 1d, 1000.0d).SetName("TorquePerAngle_ToBase_KilonewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian, 1d, 0.001d).SetName("TorquePerAngle_ToBase_NewtonMillimeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree, 1d, 6.473553852289629d).SetName("TorquePerAngle_ToBase_PoundForceInchPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree, 1d, 77.682646227475558d).SetName("TorquePerAngle_ToBase_PoundForceFootPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian, 1d, 9.8066499999999994d).SetName("TorquePerAngle_ToBase_KilogramForceMeterPerRadian");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian, 1d, 1.0d).SetName("TorquePerAngle_FromBase_NewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree, 1d, 0.017453292519943295d).SetName("TorquePerAngle_FromBase_NewtonMeterPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn, 1d, 6.2831853071795862d).SetName("TorquePerAngle_FromBase_NewtonMeterPerTurn");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian, 1d, 0.73756214927726538d).SetName("TorquePerAngle_FromBase_PoundForceFootPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian, 1d, 1000.0d).SetName("TorquePerAngle_FromBase_MillinewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian, 1d, 0.001d).SetName("TorquePerAngle_FromBase_KilonewtonMeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian, 1d, 1000.0d).SetName("TorquePerAngle_FromBase_NewtonMillimeterPerRadian");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree, 1d, 0.15447465531569038d).SetName("TorquePerAngle_FromBase_PoundForceInchPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree, 1d, 0.012872887942974195d).SetName("TorquePerAngle_FromBase_PoundForceFootPerDegree");
            yield return new TestCaseData(UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian, 1d, 0.10197162129779283d).SetName("TorquePerAngle_FromBase_KilogramForceMeterPerRadian");
        }
    }
}
