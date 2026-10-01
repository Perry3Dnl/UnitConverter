namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.AngularAcceleration;

    public sealed class UnitConverterKnownValueAngularAccelerationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularAcceleration_ToBaseUnit_ReturnsExpectedValue(UnitConverterAngularAccelerationUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularAcceleration.ToRadianPerSecondSquared(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AngularAcceleration_FromBaseUnit_ReturnsExpectedValue(UnitConverterAngularAccelerationUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularAcceleration.FromRadianPerSecondSquared(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularAcceleration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAngularAccelerationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAngularAcceleration.ToRadianPerSecondSquared(input, unit);
            double result = UnitConverterAngularAcceleration.FromRadianPerSecondSquared(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RadianPerSecondSquared, 1d, 1.0d).SetName("AngularAcceleration_ToBase_RadianPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.DegreePerSecondSquared, 1d, 0.017453292519943295d).SetName("AngularAcceleration_ToBase_DegreePerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared, 1d, 6.2831853071795862d).SetName("AngularAcceleration_ToBase_RevolutionPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond, 1d, 0.10471975511965977d).SetName("AngularAcceleration_ToBase_RevolutionPerMinutePerSecond");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared, 1d, 0.001d).SetName("AngularAcceleration_ToBase_MilliradianPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared, 1d, 0.00027777777777777778d).SetName("AngularAcceleration_ToBase_RadianPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared, 1d, 4.8481368110953598e-06d).SetName("AngularAcceleration_ToBase_DegreePerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared, 1d, 0.0017453292519943296d).SetName("AngularAcceleration_ToBase_RevolutionPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.TurnPerSecondSquared, 1d, 6.2831853071795862d).SetName("AngularAcceleration_ToBase_TurnPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared, 1d, 0.0017453292519943296d).SetName("AngularAcceleration_ToBase_TurnPerMinuteSquared");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RadianPerSecondSquared, 1d, 1.0d).SetName("AngularAcceleration_FromBase_RadianPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.DegreePerSecondSquared, 1d, 57.295779513082323d).SetName("AngularAcceleration_FromBase_DegreePerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared, 1d, 0.15915494309189535d).SetName("AngularAcceleration_FromBase_RevolutionPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond, 1d, 9.5492965855137211d).SetName("AngularAcceleration_FromBase_RevolutionPerMinutePerSecond");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared, 1d, 1000.0d).SetName("AngularAcceleration_FromBase_MilliradianPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared, 1d, 3600.0d).SetName("AngularAcceleration_FromBase_RadianPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared, 1d, 206264.80624709636d).SetName("AngularAcceleration_FromBase_DegreePerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared, 1d, 572.95779513082323d).SetName("AngularAcceleration_FromBase_RevolutionPerMinuteSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.TurnPerSecondSquared, 1d, 0.15915494309189535d).SetName("AngularAcceleration_FromBase_TurnPerSecondSquared");
            yield return new TestCaseData(UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared, 1d, 572.95779513082323d).SetName("AngularAcceleration_FromBase_TurnPerMinuteSquared");
        }
    }
}
