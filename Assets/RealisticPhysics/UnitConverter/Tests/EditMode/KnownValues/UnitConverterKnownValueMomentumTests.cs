namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Momentum;

    public sealed class UnitConverterKnownValueMomentumTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Momentum_ToBaseUnit_ReturnsExpectedValue(UnitConverterMomentumUnit unit, double input, double expected)
        {
            double result = UnitConverterMomentum.ToKilogramMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Momentum_FromBaseUnit_ReturnsExpectedValue(UnitConverterMomentumUnit unit, double input, double expected)
        {
            double result = UnitConverterMomentum.FromKilogramMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Momentum_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMomentumUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMomentum.ToKilogramMeterPerSecond(input, unit);
            double result = UnitConverterMomentum.FromKilogramMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMomentumUnit.KilogramMeterPerSecond, 1d, 1.0d).SetName("Momentum_ToBase_KilogramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.NewtonSecond, 1d, 1.0d).SetName("Momentum_ToBase_NewtonSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.GramCentimeterPerSecond, 1d, 1.0000000000000001e-05d).SetName("Momentum_ToBase_GramCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundFootPerSecond, 1d, 0.13825495437600002d).SetName("Momentum_ToBase_PoundFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.SlugFootPerSecond, 1d, 4.4482216161119998d).SetName("Momentum_ToBase_SlugFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.KilogramKilometerPerSecond, 1d, 1000.0d).SetName("Momentum_ToBase_KilogramKilometerPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.GramMeterPerSecond, 1d, 0.001d).SetName("Momentum_ToBase_GramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.MilligramMeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("Momentum_ToBase_MilligramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.TonneMeterPerSecond, 1d, 1000.0d).SetName("Momentum_ToBase_TonneMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundInchPerSecond, 1d, 0.011521246198000001d).SetName("Momentum_ToBase_PoundInchPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.OunceFootPerSecond, 1d, 0.0086409346485000014d).SetName("Momentum_ToBase_OunceFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.KilonewtonSecond, 1d, 1000.0d).SetName("Momentum_ToBase_KilonewtonSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundForceSecond, 1d, 4.4482216152604996d).SetName("Momentum_ToBase_PoundForceSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMomentumUnit.KilogramMeterPerSecond, 1d, 1.0d).SetName("Momentum_FromBase_KilogramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.NewtonSecond, 1d, 1.0d).SetName("Momentum_FromBase_NewtonSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.GramCentimeterPerSecond, 1d, 99999.999999999985d).SetName("Momentum_FromBase_GramCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundFootPerSecond, 1d, 7.2330138512098934d).SetName("Momentum_FromBase_PoundFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.SlugFootPerSecond, 1d, 0.22480894305667648d).SetName("Momentum_FromBase_SlugFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.KilogramKilometerPerSecond, 1d, 0.001d).SetName("Momentum_FromBase_KilogramKilometerPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.GramMeterPerSecond, 1d, 1000.0d).SetName("Momentum_FromBase_GramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.MilligramMeterPerSecond, 1d, 1000000.0d).SetName("Momentum_FromBase_MilligramMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.TonneMeterPerSecond, 1d, 0.001d).SetName("Momentum_FromBase_TonneMeterPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundInchPerSecond, 1d, 86.79616621451872d).SetName("Momentum_FromBase_PoundInchPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.OunceFootPerSecond, 1d, 115.72822161935829d).SetName("Momentum_FromBase_OunceFootPerSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.KilonewtonSecond, 1d, 0.001d).SetName("Momentum_FromBase_KilonewtonSecond");
            yield return new TestCaseData(UnitConverterMomentumUnit.PoundForceSecond, 1d, 0.2248089430997105d).SetName("Momentum_FromBase_PoundForceSecond");
        }
    }
}
