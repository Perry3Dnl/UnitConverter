namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.DiffusionCoefficient;

    public sealed class UnitConverterKnownValueDiffusionCoefficientTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DiffusionCoefficient_ToBaseUnit_ReturnsExpectedValue(UnitConverterDiffusionCoefficientUnit unit, double input, double expected)
        {
            double result = UnitConverterDiffusionCoefficient.ToSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DiffusionCoefficient_FromBaseUnit_ReturnsExpectedValue(UnitConverterDiffusionCoefficientUnit unit, double input, double expected)
        {
            double result = UnitConverterDiffusionCoefficient.FromSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DiffusionCoefficient_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterDiffusionCoefficientUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterDiffusionCoefficient.ToSquareMeterPerSecond(input, unit);
            double result = UnitConverterDiffusionCoefficient.FromSquareMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond, 1d, 0.0001d).SetName("DiffusionCoefficient_ToBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("DiffusionCoefficient_ToBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond, 1d, 0.092903040000000006d).SetName("DiffusionCoefficient_ToBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond, 1d, 0.00064515999999999998d).SetName("DiffusionCoefficient_ToBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("DiffusionCoefficient_ToBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute, 1d, 1.6666666666666667e-06d).SetName("DiffusionCoefficient_ToBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("DiffusionCoefficient_ToBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute, 1d, 0.0015483840000000001d).SetName("DiffusionCoefficient_ToBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute, 1d, 1.0752666666666666e-05d).SetName("DiffusionCoefficient_ToBase_SquareInchPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond, 1d, 10000.0d).SetName("DiffusionCoefficient_FromBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond, 1d, 1000000.0d).SetName("DiffusionCoefficient_FromBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond, 1d, 10.763910416709722d).SetName("DiffusionCoefficient_FromBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond, 1d, 1550.0031000062002d).SetName("DiffusionCoefficient_FromBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute, 1d, 60.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay, 1d, 86400.0d).SetName("DiffusionCoefficient_FromBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute, 1d, 600000.0d).SetName("DiffusionCoefficient_FromBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute, 1d, 60000000.0d).SetName("DiffusionCoefficient_FromBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute, 1d, 645.83462500258327d).SetName("DiffusionCoefficient_FromBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute, 1d, 93000.186000372007d).SetName("DiffusionCoefficient_FromBase_SquareInchPerMinute");
        }
    }
}
