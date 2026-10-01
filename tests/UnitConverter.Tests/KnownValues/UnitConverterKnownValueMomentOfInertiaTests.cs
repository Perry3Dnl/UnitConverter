namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.MomentOfInertia;

    public sealed class UnitConverterKnownValueMomentOfInertiaTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MomentOfInertia_ToBaseUnit_ReturnsExpectedValue(UnitConverterMomentOfInertiaUnit unit, double input, double expected)
        {
            double result = UnitConverterMomentOfInertia.ToKilogramSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MomentOfInertia_FromBaseUnit_ReturnsExpectedValue(UnitConverterMomentOfInertiaUnit unit, double input, double expected)
        {
            double result = UnitConverterMomentOfInertia.FromKilogramSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MomentOfInertia_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMomentOfInertiaUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMomentOfInertia.ToKilogramSquareMeter(input, unit);
            double result = UnitConverterMomentOfInertia.FromKilogramSquareMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareMeter, 1d, 1.0d).SetName("MomentOfInertia_ToBase_KilogramSquareMeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareCentimeter, 1d, 9.9999999999999995e-08d).SetName("MomentOfInertia_ToBase_GramSquareCentimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter, 1d, 0.0001d).SetName("MomentOfInertia_ToBase_KilogramSquareCentimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.PoundSquareFoot, 1d, 0.042140110093804806d).SetName("MomentOfInertia_ToBase_PoundSquareFoot");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.SlugSquareFoot, 1d, 1.3558179485909376d).SetName("MomentOfInertia_ToBase_SlugSquareFoot");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareMeter, 1d, 0.001d).SetName("MomentOfInertia_ToBase_GramSquareMeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("MomentOfInertia_ToBase_KilogramSquareMillimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareMillimeter, 1d, 1.0000000000000001e-09d).SetName("MomentOfInertia_ToBase_GramSquareMillimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.PoundSquareInch, 1d, 0.00029263965342919999d).SetName("MomentOfInertia_ToBase_PoundSquareInch");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.SlugSquareInch, 1d, 0.0094154024207703992d).SetName("MomentOfInertia_ToBase_SlugSquareInch");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.TonneSquareMeter, 1d, 1000.0d).SetName("MomentOfInertia_ToBase_TonneSquareMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareMeter, 1d, 1.0d).SetName("MomentOfInertia_FromBase_KilogramSquareMeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareCentimeter, 1d, 10000000.0d).SetName("MomentOfInertia_FromBase_GramSquareCentimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter, 1d, 10000.0d).SetName("MomentOfInertia_FromBase_KilogramSquareCentimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.PoundSquareFoot, 1d, 23.730360404231934d).SetName("MomentOfInertia_FromBase_PoundSquareFoot");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.SlugSquareFoot, 1d, 0.73756214913607765d).SetName("MomentOfInertia_FromBase_SlugSquareFoot");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareMeter, 1d, 1000.0d).SetName("MomentOfInertia_FromBase_GramSquareMeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter, 1d, 1000000.0d).SetName("MomentOfInertia_FromBase_KilogramSquareMillimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.GramSquareMillimeter, 1d, 999999999.99999988d).SetName("MomentOfInertia_FromBase_GramSquareMillimeter");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.PoundSquareInch, 1d, 3417.1718982093989d).SetName("MomentOfInertia_FromBase_PoundSquareInch");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.SlugSquareInch, 1d, 106.20894947559519d).SetName("MomentOfInertia_FromBase_SlugSquareInch");
            yield return new TestCaseData(UnitConverterMomentOfInertiaUnit.TonneSquareMeter, 1d, 0.001d).SetName("MomentOfInertia_FromBase_TonneSquareMeter");
        }
    }
}
