namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.AngularVelocity;

    public sealed class UnitConverterKnownValueAngularVelocityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularVelocity_ToBaseUnit_ReturnsExpectedValue(UnitConverterAngularVelocityUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularVelocity.ToRadianPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AngularVelocity_FromBaseUnit_ReturnsExpectedValue(UnitConverterAngularVelocityUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularVelocity.FromRadianPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularVelocity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAngularVelocityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAngularVelocity.ToRadianPerSecond(input, unit);
            double result = UnitConverterAngularVelocity.FromRadianPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerSecond, 1d, 1.0d).SetName("AngularVelocity_ToBase_RadianPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerSecond, 1d, 0.017453292519943295d).SetName("AngularVelocity_ToBase_DegreePerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerMinute, 1d, 0.00029088820866572158d).SetName("AngularVelocity_ToBase_DegreePerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerSecond, 1d, 6.2831853071795862d).SetName("AngularVelocity_ToBase_RevolutionPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerMinute, 1d, 0.10471975511965977d).SetName("AngularVelocity_ToBase_RevolutionPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerHour, 1d, 0.0017453292519943296d).SetName("AngularVelocity_ToBase_RevolutionPerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerMinute, 1d, 0.016666666666666666d).SetName("AngularVelocity_ToBase_RadianPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerHour, 1d, 0.00027777777777777778d).SetName("AngularVelocity_ToBase_RadianPerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerHour, 1d, 4.8481368110953598e-06d).SetName("AngularVelocity_ToBase_DegreePerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerDay, 1d, 7.2722052166430395e-05d).SetName("AngularVelocity_ToBase_RevolutionPerDay");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.TurnPerSecond, 1d, 6.2831853071795862d).SetName("AngularVelocity_ToBase_TurnPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.TurnPerMinute, 1d, 0.10471975511965977d).SetName("AngularVelocity_ToBase_TurnPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.CyclePerSecond, 1d, 6.2831853071795862d).SetName("AngularVelocity_ToBase_CyclePerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.MilliradianPerSecond, 1d, 0.001d).SetName("AngularVelocity_ToBase_MilliradianPerSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerSecond, 1d, 1.0d).SetName("AngularVelocity_FromBase_RadianPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerSecond, 1d, 57.295779513082323d).SetName("AngularVelocity_FromBase_DegreePerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerMinute, 1d, 3437.7467707849396d).SetName("AngularVelocity_FromBase_DegreePerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerSecond, 1d, 0.15915494309189535d).SetName("AngularVelocity_FromBase_RevolutionPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerMinute, 1d, 9.5492965855137211d).SetName("AngularVelocity_FromBase_RevolutionPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerHour, 1d, 572.95779513082323d).SetName("AngularVelocity_FromBase_RevolutionPerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerMinute, 1d, 60.0d).SetName("AngularVelocity_FromBase_RadianPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RadianPerHour, 1d, 3600.0d).SetName("AngularVelocity_FromBase_RadianPerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.DegreePerHour, 1d, 206264.80624709636d).SetName("AngularVelocity_FromBase_DegreePerHour");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.RevolutionPerDay, 1d, 13750.987083139758d).SetName("AngularVelocity_FromBase_RevolutionPerDay");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.TurnPerSecond, 1d, 0.15915494309189535d).SetName("AngularVelocity_FromBase_TurnPerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.TurnPerMinute, 1d, 9.5492965855137211d).SetName("AngularVelocity_FromBase_TurnPerMinute");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.CyclePerSecond, 1d, 0.15915494309189535d).SetName("AngularVelocity_FromBase_CyclePerSecond");
            yield return new TestCaseData(UnitConverterAngularVelocityUnit.MilliradianPerSecond, 1d, 1000.0d).SetName("AngularVelocity_FromBase_MilliradianPerSecond");
        }
    }
}
