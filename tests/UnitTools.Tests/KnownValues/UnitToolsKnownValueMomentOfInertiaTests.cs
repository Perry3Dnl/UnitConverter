namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MomentOfInertia;

    public sealed class UnitToolsKnownValueMomentOfInertiaTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MomentOfInertia_ToBaseUnit_ReturnsExpectedValue(UnitToolsMomentOfInertiaUnit unit, double input, double expected)
        {
            double result = UnitToolsMomentOfInertia.ToKilogramSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MomentOfInertia_FromBaseUnit_ReturnsExpectedValue(UnitToolsMomentOfInertiaUnit unit, double input, double expected)
        {
            double result = UnitToolsMomentOfInertia.FromKilogramSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MomentOfInertia_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMomentOfInertiaUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMomentOfInertia.ToKilogramSquareMeter(input, unit);
            double result = UnitToolsMomentOfInertia.FromKilogramSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareMeter, 1d, 1.0d).SetName("MomentOfInertia_ToBase_KilogramSquareMeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareCentimeter, 1d, 9.9999999999999995e-08d).SetName("MomentOfInertia_ToBase_GramSquareCentimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter, 1d, 0.0001d).SetName("MomentOfInertia_ToBase_KilogramSquareCentimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.PoundSquareFoot, 1d, 0.042140110093804806d).SetName("MomentOfInertia_ToBase_PoundSquareFoot");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.SlugSquareFoot, 1d, 1.3558179485909376d).SetName("MomentOfInertia_ToBase_SlugSquareFoot");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareMeter, 1d, 0.001d).SetName("MomentOfInertia_ToBase_GramSquareMeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("MomentOfInertia_ToBase_KilogramSquareMillimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareMillimeter, 1d, 1.0000000000000001e-09d).SetName("MomentOfInertia_ToBase_GramSquareMillimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.PoundSquareInch, 1d, 0.00029263965342919999d).SetName("MomentOfInertia_ToBase_PoundSquareInch");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.SlugSquareInch, 1d, 0.0094154024207703992d).SetName("MomentOfInertia_ToBase_SlugSquareInch");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.TonneSquareMeter, 1d, 1000.0d).SetName("MomentOfInertia_ToBase_TonneSquareMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareMeter, 1d, 1.0d).SetName("MomentOfInertia_FromBase_KilogramSquareMeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareCentimeter, 1d, 10000000.0d).SetName("MomentOfInertia_FromBase_GramSquareCentimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter, 1d, 10000.0d).SetName("MomentOfInertia_FromBase_KilogramSquareCentimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.PoundSquareFoot, 1d, 23.730360404231934d).SetName("MomentOfInertia_FromBase_PoundSquareFoot");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.SlugSquareFoot, 1d, 0.73756214913607765d).SetName("MomentOfInertia_FromBase_SlugSquareFoot");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareMeter, 1d, 1000.0d).SetName("MomentOfInertia_FromBase_GramSquareMeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter, 1d, 1000000.0d).SetName("MomentOfInertia_FromBase_KilogramSquareMillimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.GramSquareMillimeter, 1d, 999999999.99999988d).SetName("MomentOfInertia_FromBase_GramSquareMillimeter");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.PoundSquareInch, 1d, 3417.1718982093989d).SetName("MomentOfInertia_FromBase_PoundSquareInch");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.SlugSquareInch, 1d, 106.20894947559519d).SetName("MomentOfInertia_FromBase_SlugSquareInch");
            yield return new TestCaseData(UnitToolsMomentOfInertiaUnit.TonneSquareMeter, 1d, 0.001d).SetName("MomentOfInertia_FromBase_TonneSquareMeter");
        }
    }
}
