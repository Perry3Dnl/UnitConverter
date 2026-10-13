namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.DiffusionCoefficient;

    public sealed class UnitToolsKnownValueDiffusionCoefficientTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DiffusionCoefficient_ToBaseUnit_ReturnsExpectedValue(UnitToolsDiffusionCoefficientUnit unit, double input, double expected)
        {
            double result = UnitToolsDiffusionCoefficient.ToSquareMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DiffusionCoefficient_FromBaseUnit_ReturnsExpectedValue(UnitToolsDiffusionCoefficientUnit unit, double input, double expected)
        {
            double result = UnitToolsDiffusionCoefficient.FromSquareMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DiffusionCoefficient_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsDiffusionCoefficientUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsDiffusionCoefficient.ToSquareMeterPerSecond(input, unit);
            double result = UnitToolsDiffusionCoefficient.FromSquareMeterPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond, 1d, 0.0001d).SetName("DiffusionCoefficient_ToBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("DiffusionCoefficient_ToBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond, 1d, 0.092903040000000006d).SetName("DiffusionCoefficient_ToBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond, 1d, 0.00064515999999999998d).SetName("DiffusionCoefficient_ToBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute, 1d, 1.6666666666666667e-06d).SetName("DiffusionCoefficient_ToBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("DiffusionCoefficient_ToBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute, 1d, 0.0015483840000000001d).SetName("DiffusionCoefficient_ToBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute, 1d, 1.0752666666666666e-05d).SetName("DiffusionCoefficient_ToBase_SquareInchPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond, 1d, 10000.0d).SetName("DiffusionCoefficient_FromBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond, 1d, 1000000.0d).SetName("DiffusionCoefficient_FromBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond, 1d, 10.763910416709722d).SetName("DiffusionCoefficient_FromBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond, 1d, 1550.0031000062002d).SetName("DiffusionCoefficient_FromBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute, 1d, 60.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay, 1d, 86400.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute, 1d, 600000.0d).SetName("DiffusionCoefficient_FromBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute, 1d, 60000000.0d).SetName("DiffusionCoefficient_FromBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute, 1d, 645.83462500258327d).SetName("DiffusionCoefficient_FromBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute, 1d, 93000.186000372007d).SetName("DiffusionCoefficient_FromBase_SquareInchPerMinute");
        }
    }
}
