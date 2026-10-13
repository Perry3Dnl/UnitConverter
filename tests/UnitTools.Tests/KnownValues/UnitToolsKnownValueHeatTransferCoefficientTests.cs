namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.HeatTransferCoefficient;

    public sealed class UnitToolsKnownValueHeatTransferCoefficientTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void HeatTransferCoefficient_ToBaseUnit_ReturnsExpectedValue(UnitToolsHeatTransferCoefficientUnit unit, double input, double expected)
        {
            double result = UnitToolsHeatTransferCoefficient.ToWattPerSquareMeterKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void HeatTransferCoefficient_FromBaseUnit_ReturnsExpectedValue(UnitToolsHeatTransferCoefficientUnit unit, double input, double expected)
        {
            double result = UnitToolsHeatTransferCoefficient.FromWattPerSquareMeterKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void HeatTransferCoefficient_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsHeatTransferCoefficientUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsHeatTransferCoefficient.ToWattPerSquareMeterKelvin(input, unit);
            double result = UnitToolsHeatTransferCoefficient.FromWattPerSquareMeterKelvin(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, 1d, 1.0d).SetName("HeatTransferCoefficient_ToBase_WattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, 1d, 1000.0d).SetName("HeatTransferCoefficient_ToBase_KilowattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, 1d, 41868.0d).SetName("HeatTransferCoefficient_ToBase_CaloriePerSecondSquareCentimeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, 1d, 1.163d).SetName("HeatTransferCoefficient_ToBase_KilocaloriePerHourSquareMeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, 1d, 5.6782633369999997d).SetName("HeatTransferCoefficient_ToBase_BtuPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, 1d, 1000000.0d).SetName("HeatTransferCoefficient_ToBase_WattPerSquareMillimeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, 1d, 0.001d).SetName("HeatTransferCoefficient_ToBase_MilliwattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, 1d, 4.1840000000000002d).SetName("HeatTransferCoefficient_ToBase_CaloriePerSecondSquareMeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, 1d, 20441.748028008555d).SetName("HeatTransferCoefficient_ToBase_BtuPerSecondSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit, 1d, 340.6958004668092d).SetName("HeatTransferCoefficient_ToBase_BtuPerMinuteSquareFootFahrenheit");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, 1d, 1.0d).SetName("HeatTransferCoefficient_FromBase_WattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, 1d, 0.001d).SetName("HeatTransferCoefficient_FromBase_KilowattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, 1d, 2.3884589662749594e-05d).SetName("HeatTransferCoefficient_FromBase_CaloriePerSecondSquareCentimeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, 1d, 0.85984522785898532d).SetName("HeatTransferCoefficient_FromBase_KilocaloriePerHourSquareMeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, 1d, 0.17611018380988483d).SetName("HeatTransferCoefficient_FromBase_BtuPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, 1d, 9.9999999999999995e-07d).SetName("HeatTransferCoefficient_FromBase_WattPerSquareMillimeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, 1d, 1000.0d).SetName("HeatTransferCoefficient_FromBase_MilliwattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, 1d, 0.23900573613766729d).SetName("HeatTransferCoefficient_FromBase_CaloriePerSecondSquareMeterCelsius");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, 1d, 4.891949546730718e-05d).SetName("HeatTransferCoefficient_FromBase_BtuPerSecondSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit, 1d, 0.0029351697280384312d).SetName("HeatTransferCoefficient_FromBase_BtuPerMinuteSquareFootFahrenheit");
        }
    }
}
