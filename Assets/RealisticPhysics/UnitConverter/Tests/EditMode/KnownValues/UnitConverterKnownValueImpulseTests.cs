namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Impulse;

    public sealed class UnitConverterKnownValueImpulseTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Impulse_ToBaseUnit_ReturnsExpectedValue(UnitConverterImpulseUnit unit, double input, double expected)
        {
            double result = UnitConverterImpulse.ToNewtonSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Impulse_FromBaseUnit_ReturnsExpectedValue(UnitConverterImpulseUnit unit, double input, double expected)
        {
            double result = UnitConverterImpulse.FromNewtonSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Impulse_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterImpulseUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterImpulse.ToNewtonSecond(input, unit);
            double result = UnitConverterImpulse.FromNewtonSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterImpulseUnit.NewtonSecond, 1d, 1.0d).SetName("Impulse_ToBase_NewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilonewtonSecond, 1d, 1000.0d).SetName("Impulse_ToBase_KilonewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.DyneSecond, 1d, 1.0000000000000001e-05d).SetName("Impulse_ToBase_DyneSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.PoundForceSecond, 1d, 4.4482216152604996d).SetName("Impulse_ToBase_PoundForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilogramForceSecond, 1d, 9.8066499999999994d).SetName("Impulse_ToBase_KilogramForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.MillinewtonSecond, 1d, 0.001d).SetName("Impulse_ToBase_MillinewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.MeganewtonSecond, 1d, 1000000.0d).SetName("Impulse_ToBase_MeganewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.NewtonMinute, 1d, 60.0d).SetName("Impulse_ToBase_NewtonMinute");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilogramMeterPerSecond, 1d, 1.0d).SetName("Impulse_ToBase_KilogramMeterPerSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.GramCentimeterPerSecond, 1d, 1.0000000000000001e-05d).SetName("Impulse_ToBase_GramCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.OunceForceSecond, 1d, 0.27801385095378123d).SetName("Impulse_ToBase_OunceForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.PoundForceMinute, 1d, 266.89329691563d).SetName("Impulse_ToBase_PoundForceMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterImpulseUnit.NewtonSecond, 1d, 1.0d).SetName("Impulse_FromBase_NewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilonewtonSecond, 1d, 0.001d).SetName("Impulse_FromBase_KilonewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.DyneSecond, 1d, 99999.999999999985d).SetName("Impulse_FromBase_DyneSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.PoundForceSecond, 1d, 0.2248089430997105d).SetName("Impulse_FromBase_PoundForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilogramForceSecond, 1d, 0.10197162129779283d).SetName("Impulse_FromBase_KilogramForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.MillinewtonSecond, 1d, 1000.0d).SetName("Impulse_FromBase_MillinewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.MeganewtonSecond, 1d, 9.9999999999999995e-07d).SetName("Impulse_FromBase_MeganewtonSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.NewtonMinute, 1d, 0.016666666666666666d).SetName("Impulse_FromBase_NewtonMinute");
            yield return new TestCaseData(UnitConverterImpulseUnit.KilogramMeterPerSecond, 1d, 1.0d).SetName("Impulse_FromBase_KilogramMeterPerSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.GramCentimeterPerSecond, 1d, 99999.999999999985d).SetName("Impulse_FromBase_GramCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.OunceForceSecond, 1d, 3.596943089595368d).SetName("Impulse_FromBase_OunceForceSecond");
            yield return new TestCaseData(UnitConverterImpulseUnit.PoundForceMinute, 1d, 0.0037468157183285079d).SetName("Impulse_FromBase_PoundForceMinute");
        }
    }
}
