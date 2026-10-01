namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.HeatTransferCoefficient;

    public sealed class UnitConverterKnownValueHeatTransferCoefficientTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void HeatTransferCoefficient_ToBaseUnit_ReturnsExpectedValue(UnitConverterHeatTransferCoefficientUnit unit, double input, double expected)
        {
            double result = UnitConverterHeatTransferCoefficient.ToWattPerSquareMeterKelvin(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void HeatTransferCoefficient_FromBaseUnit_ReturnsExpectedValue(UnitConverterHeatTransferCoefficientUnit unit, double input, double expected)
        {
            double result = UnitConverterHeatTransferCoefficient.FromWattPerSquareMeterKelvin(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void HeatTransferCoefficient_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterHeatTransferCoefficientUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterHeatTransferCoefficient.ToWattPerSquareMeterKelvin(input, unit);
            double result = UnitConverterHeatTransferCoefficient.FromWattPerSquareMeterKelvin(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, 1d, 1.0d).SetName("HeatTransferCoefficient_ToBase_WattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, 1d, 1000.0d).SetName("HeatTransferCoefficient_ToBase_KilowattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, 1d, 41868.0d).SetName("HeatTransferCoefficient_ToBase_CaloriePerSecondSquareCentimeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, 1d, 1.163d).SetName("HeatTransferCoefficient_ToBase_KilocaloriePerHourSquareMeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, 1d, 5.6782633369999997d).SetName("HeatTransferCoefficient_ToBase_BtuPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, 1d, 1000000.0d).SetName("HeatTransferCoefficient_ToBase_WattPerSquareMillimeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, 1d, 0.001d).SetName("HeatTransferCoefficient_ToBase_MilliwattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, 1d, 4.1840000000000002d).SetName("HeatTransferCoefficient_ToBase_CaloriePerSecondSquareMeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, 1d, 20441.748028008555d).SetName("HeatTransferCoefficient_ToBase_BtuPerSecondSquareFootFahrenheit");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit, 1d, 340.6958004668092d).SetName("HeatTransferCoefficient_ToBase_BtuPerMinuteSquareFootFahrenheit");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, 1d, 1.0d).SetName("HeatTransferCoefficient_FromBase_WattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, 1d, 0.001d).SetName("HeatTransferCoefficient_FromBase_KilowattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, 1d, 2.3884589662749594e-05d).SetName("HeatTransferCoefficient_FromBase_CaloriePerSecondSquareCentimeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, 1d, 0.85984522785898532d).SetName("HeatTransferCoefficient_FromBase_KilocaloriePerHourSquareMeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, 1d, 0.17611018380988483d).SetName("HeatTransferCoefficient_FromBase_BtuPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, 1d, 9.9999999999999995e-07d).SetName("HeatTransferCoefficient_FromBase_WattPerSquareMillimeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, 1d, 1000.0d).SetName("HeatTransferCoefficient_FromBase_MilliwattPerSquareMeterKelvin");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, 1d, 0.23900573613766729d).SetName("HeatTransferCoefficient_FromBase_CaloriePerSecondSquareMeterCelsius");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, 1d, 4.891949546730718e-05d).SetName("HeatTransferCoefficient_FromBase_BtuPerSecondSquareFootFahrenheit");
            yield return new TestCaseData(UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit, 1d, 0.0029351697280384312d).SetName("HeatTransferCoefficient_FromBase_BtuPerMinuteSquareFootFahrenheit");
        }
    }
}
