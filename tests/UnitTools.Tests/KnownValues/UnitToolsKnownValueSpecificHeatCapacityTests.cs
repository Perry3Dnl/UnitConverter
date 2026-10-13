namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.SpecificHeatCapacity;

    public sealed class UnitToolsKnownValueSpecificHeatCapacityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificHeatCapacity_ToBaseUnit_ReturnsExpectedValue(UnitToolsSpecificHeatCapacityUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificHeatCapacity.ToJoulePerKilogramKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificHeatCapacity_FromBaseUnit_ReturnsExpectedValue(UnitToolsSpecificHeatCapacityUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificHeatCapacity.FromJoulePerKilogramKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificHeatCapacity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsSpecificHeatCapacityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsSpecificHeatCapacity.ToJoulePerKilogramKelvin(input, unit);
            double result = UnitToolsSpecificHeatCapacity.FromJoulePerKilogramKelvin(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin, 1d, 1.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerKilogramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_KilojoulePerKilogramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerGramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_CaloriePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_KilocaloriePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, 1d, 4186.7999999999993d).SetName("SpecificHeatCapacity_ToBase_BtuPerPoundFahrenheit");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius, 1d, 1.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_KilojoulePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_CaloriePerGramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, 1d, 4184000.0d).SetName("SpecificHeatCapacity_ToBase_KilocaloriePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine, 1d, 4186.7999999999993d).SetName("SpecificHeatCapacity_ToBase_BtuPerPoundRankine");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit, 1d, 130.12972215340773d).SetName("SpecificHeatCapacity_ToBase_BtuPerSlugFahrenheit");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin, 1d, 1.0d).SetName("SpecificHeatCapacity_FromBase_JoulePerKilogramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_KilojoulePerKilogramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_JoulePerGramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_CaloriePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_KilocaloriePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, 1d, 0.00023884589662749597d).SetName("SpecificHeatCapacity_FromBase_BtuPerPoundFahrenheit");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius, 1d, 1.0d).SetName("SpecificHeatCapacity_FromBase_JoulePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_KilojoulePerKilogramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_JoulePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_CaloriePerGramKelvin");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, 1d, 2.3900573613766732e-07d).SetName("SpecificHeatCapacity_FromBase_KilocaloriePerGramCelsius");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine, 1d, 0.00023884589662749597d).SetName("SpecificHeatCapacity_FromBase_BtuPerPoundRankine");
            yield return new TestCaseData(UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit, 1d, 0.0076846394770682513d).SetName("SpecificHeatCapacity_FromBase_BtuPerSlugFahrenheit");
        }
    }
}
