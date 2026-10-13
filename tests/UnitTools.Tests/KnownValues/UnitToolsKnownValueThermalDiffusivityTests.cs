namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ThermalDiffusivity;

    public sealed class UnitToolsKnownValueThermalDiffusivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalDiffusivity_ToBaseUnit_ReturnsExpectedValue(UnitToolsThermalDiffusivityUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalDiffusivity.ToSquareMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ThermalDiffusivity_FromBaseUnit_ReturnsExpectedValue(UnitToolsThermalDiffusivityUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalDiffusivity.FromSquareMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalDiffusivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsThermalDiffusivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsThermalDiffusivity.ToSquareMeterPerSecond(input, unit);
            double result = UnitToolsThermalDiffusivity.FromSquareMeterPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond, 1d, 0.0001d).SetName("ThermalDiffusivity_ToBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("ThermalDiffusivity_ToBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerHour, 1d, 0.00027777777777777778d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareFootPerSecond, 1d, 0.092903040000000006d).SetName("ThermalDiffusivity_ToBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("ThermalDiffusivity_ToBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute, 1d, 1.6666666666666667e-06d).SetName("ThermalDiffusivity_ToBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("ThermalDiffusivity_ToBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareFootPerMinute, 1d, 0.0015483840000000001d).SetName("ThermalDiffusivity_ToBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareInchPerMinute, 1d, 1.0752666666666666e-05d).SetName("ThermalDiffusivity_ToBase_SquareInchPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond, 1d, 10000.0d).SetName("ThermalDiffusivity_FromBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond, 1d, 1000000.0d).SetName("ThermalDiffusivity_FromBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerHour, 1d, 3600.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareFootPerSecond, 1d, 10.763910416709722d).SetName("ThermalDiffusivity_FromBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute, 1d, 60.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMeterPerDay, 1d, 86400.0d).SetName("ThermalDiffusivity_FromBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute, 1d, 600000.0d).SetName("ThermalDiffusivity_FromBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute, 1d, 60000000.0d).SetName("ThermalDiffusivity_FromBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareFootPerMinute, 1d, 645.83462500258327d).SetName("ThermalDiffusivity_FromBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitToolsThermalDiffusivityUnit.SquareInchPerMinute, 1d, 93000.186000372007d).SetName("ThermalDiffusivity_FromBase_SquareInchPerMinute");
        }
    }
}
