namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.ThermalDiffusivity;

    public sealed class UnitConverterKnownValueThermalDiffusivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalDiffusivity_ToBaseUnit_ReturnsExpectedValue(UnitConverterThermalDiffusivityUnit unit, double input, double expected)
        {
            double result = UnitConverterThermalDiffusivity.ToSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ThermalDiffusivity_FromBaseUnit_ReturnsExpectedValue(UnitConverterThermalDiffusivityUnit unit, double input, double expected)
        {
            double result = UnitConverterThermalDiffusivity.FromSquareMeterPerSecond(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalDiffusivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterThermalDiffusivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterThermalDiffusivity.ToSquareMeterPerSecond(input, unit);
            double result = UnitConverterThermalDiffusivity.FromSquareMeterPerSecond(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond, 1d, 0.0001d).SetName("ThermalDiffusivity_ToBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("ThermalDiffusivity_ToBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerHour, 1d, 0.00027777777777777778d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareFootPerSecond, 1d, 0.092903040000000006d).SetName("ThermalDiffusivity_ToBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute, 1d, 1.6666666666666667e-06d).SetName("ThermalDiffusivity_ToBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("ThermalDiffusivity_ToBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareFootPerMinute, 1d, 0.0015483840000000001d).SetName("ThermalDiffusivity_ToBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareInchPerMinute, 1d, 1.0752666666666666e-05d).SetName("ThermalDiffusivity_ToBase_SquareInchPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond, 1d, 10000.0d).SetName("ThermalDiffusivity_FromBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond, 1d, 1000000.0d).SetName("ThermalDiffusivity_FromBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerHour, 1d, 3600.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareFootPerSecond, 1d, 10.763910416709722d).SetName("ThermalDiffusivity_FromBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute, 1d, 60.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMeterPerDay, 1d, 86400.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute, 1d, 600000.0d).SetName("ThermalDiffusivity_FromBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute, 1d, 60000000.0d).SetName("ThermalDiffusivity_FromBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareFootPerMinute, 1d, 645.83462500258327d).SetName("ThermalDiffusivity_FromBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterThermalDiffusivityUnit.SquareInchPerMinute, 1d, 93000.186000372007d).SetName("ThermalDiffusivity_FromBase_SquareInchPerMinute");
        }
    }
}
