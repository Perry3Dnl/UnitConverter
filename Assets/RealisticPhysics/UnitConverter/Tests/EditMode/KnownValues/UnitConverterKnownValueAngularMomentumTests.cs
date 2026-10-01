namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.AngularMomentum;

    public sealed class UnitConverterKnownValueAngularMomentumTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularMomentum_ToBaseUnit_ReturnsExpectedValue(UnitConverterAngularMomentumUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularMomentum.ToKilogramSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AngularMomentum_FromBaseUnit_ReturnsExpectedValue(UnitConverterAngularMomentumUnit unit, double input, double expected)
        {
            double result = UnitConverterAngularMomentum.FromKilogramSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AngularMomentum_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAngularMomentumUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAngularMomentum.ToKilogramSquareMeterPerSecond(input, unit);
            double result = UnitConverterAngularMomentum.FromKilogramSquareMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond, 1d, 1.0d).SetName("AngularMomentum_ToBase_KilogramSquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.NewtonMeterSecond, 1d, 1.0d).SetName("AngularMomentum_ToBase_NewtonMeterSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.JouleSecond, 1d, 1.0d).SetName("AngularMomentum_ToBase_JouleSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond, 1d, 9.9999999999999995e-08d).SetName("AngularMomentum_ToBase_GramSquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond, 1d, 0.042140110093804806d).SetName("AngularMomentum_ToBase_PoundSquareFootPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond, 1d, 1.3558179485909376d).SetName("AngularMomentum_ToBase_SlugSquareFootPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("AngularMomentum_ToBase_KilogramSquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond, 1d, 0.001d).SetName("AngularMomentum_ToBase_GramSquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond, 1d, 0.0001d).SetName("AngularMomentum_ToBase_KilogramSquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond, 1d, 0.00029263965342919999d).SetName("AngularMomentum_ToBase_PoundSquareInchPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond, 1d, 0.0094154024207703992d).SetName("AngularMomentum_ToBase_SlugSquareInchPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PlanckConstant, 1d, 6.6260701499999998e-34d).SetName("AngularMomentum_ToBase_PlanckConstant");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.ReducedPlanckConstant, 1d, 1.054571817e-34d).SetName("AngularMomentum_ToBase_ReducedPlanckConstant");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond, 1d, 1.0d).SetName("AngularMomentum_FromBase_KilogramSquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.NewtonMeterSecond, 1d, 1.0d).SetName("AngularMomentum_FromBase_NewtonMeterSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.JouleSecond, 1d, 1.0d).SetName("AngularMomentum_FromBase_JouleSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond, 1d, 10000000.0d).SetName("AngularMomentum_FromBase_GramSquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond, 1d, 23.730360404231934d).SetName("AngularMomentum_FromBase_PoundSquareFootPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond, 1d, 0.73756214913607765d).SetName("AngularMomentum_FromBase_SlugSquareFootPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute, 1d, 60.0d).SetName("AngularMomentum_FromBase_KilogramSquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond, 1d, 1000.0d).SetName("AngularMomentum_FromBase_GramSquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond, 1d, 10000.0d).SetName("AngularMomentum_FromBase_KilogramSquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond, 1d, 3417.1718982093989d).SetName("AngularMomentum_FromBase_PoundSquareInchPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond, 1d, 106.20894947559519d).SetName("AngularMomentum_FromBase_SlugSquareInchPerSecond");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.PlanckConstant, 1d, 1.5091901796421518e+33d).SetName("AngularMomentum_FromBase_PlanckConstant");
            yield return new TestCaseData(UnitConverterAngularMomentumUnit.ReducedPlanckConstant, 1d, 9.4825215682774119e+33d).SetName("AngularMomentum_FromBase_ReducedPlanckConstant");
        }
    }
}
