namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ThermalConductivity;

    public sealed class UnitToolsKnownValueThermalConductivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalConductivity_ToBaseUnit_ReturnsExpectedValue(UnitToolsThermalConductivityUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalConductivity.ToWattPerMeterKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ThermalConductivity_FromBaseUnit_ReturnsExpectedValue(UnitToolsThermalConductivityUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalConductivity.FromWattPerMeterKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalConductivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsThermalConductivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsThermalConductivity.ToWattPerMeterKelvin(input, unit);
            double result = UnitToolsThermalConductivity.FromWattPerMeterKelvin(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerMeterKelvin, 1d, 1.0d).SetName("ThermalConductivity_ToBase_WattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin, 1d, 0.001d).SetName("ThermalConductivity_ToBase_MilliwattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin, 1d, 1000.0d).SetName("ThermalConductivity_ToBase_KilowattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, 1d, 418.39999999999998d).SetName("ThermalConductivity_ToBase_CaloriePerSecondCentimeterCelsius");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit, 1d, 1.7307349999999999d).SetName("ThermalConductivity_ToBase_BtuPerHourFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, 1d, 0.14422789999999999d).SetName("ThermalConductivity_ToBase_BtuInchPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin, 1d, 1000.0d).SetName("ThermalConductivity_ToBase_WattPerMillimeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerInchFahrenheit, 1d, 70.866141732283467d).SetName("ThermalConductivity_ToBase_WattPerInchFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit, 1d, 1.7307349999999999d).SetName("ThermalConductivity_ToBase_BtuFootPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius, 1d, 4.1840000000000002d).SetName("ThermalConductivity_ToBase_CaloriePerSecondMeterCelsius");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius, 1d, 4184.0d).SetName("ThermalConductivity_ToBase_KilocaloriePerSecondMeterCelsius");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerMeterKelvin, 1d, 1.0d).SetName("ThermalConductivity_FromBase_WattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin, 1d, 1000.0d).SetName("ThermalConductivity_FromBase_MilliwattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin, 1d, 0.001d).SetName("ThermalConductivity_FromBase_KilowattPerMeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, 1d, 0.0023900573613766731d).SetName("ThermalConductivity_FromBase_CaloriePerSecondCentimeterCelsius");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit, 1d, 0.5777892051642799d).SetName("ThermalConductivity_FromBase_BtuPerHourFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, 1d, 6.9334712631883297d).SetName("ThermalConductivity_FromBase_BtuInchPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin, 1d, 0.001d).SetName("ThermalConductivity_FromBase_WattPerMillimeterKelvin");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.WattPerInchFahrenheit, 1d, 0.014111111111111111d).SetName("ThermalConductivity_FromBase_WattPerInchFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit, 1d, 0.5777892051642799d).SetName("ThermalConductivity_FromBase_BtuFootPerHourSquareFootFahrenheit");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius, 1d, 0.23900573613766729d).SetName("ThermalConductivity_FromBase_CaloriePerSecondMeterCelsius");
            yield return new TestCaseData(UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius, 1d, 0.0002390057361376673d).SetName("ThermalConductivity_FromBase_KilocaloriePerSecondMeterCelsius");
        }
    }
}
