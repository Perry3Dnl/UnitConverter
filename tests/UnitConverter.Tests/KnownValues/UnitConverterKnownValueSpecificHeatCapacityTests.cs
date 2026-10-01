namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.SpecificHeatCapacity;

    public sealed class UnitConverterKnownValueSpecificHeatCapacityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificHeatCapacity_ToBaseUnit_ReturnsExpectedValue(UnitConverterSpecificHeatCapacityUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificHeatCapacity.ToJoulePerKilogramKelvin(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificHeatCapacity_FromBaseUnit_ReturnsExpectedValue(UnitConverterSpecificHeatCapacityUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificHeatCapacity.FromJoulePerKilogramKelvin(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificHeatCapacity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSpecificHeatCapacityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSpecificHeatCapacity.ToJoulePerKilogramKelvin(input, unit);
            double result = UnitConverterSpecificHeatCapacity.FromJoulePerKilogramKelvin(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin, 1d, 1.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerKilogramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_KilojoulePerKilogramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerGramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_CaloriePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_KilocaloriePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, 1d, 4186.7999999999993d).SetName("SpecificHeatCapacity_ToBase_BtuPerPoundFahrenheit");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius, 1d, 1.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_KilojoulePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius, 1d, 1000.0d).SetName("SpecificHeatCapacity_ToBase_JoulePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin, 1d, 4184.0d).SetName("SpecificHeatCapacity_ToBase_CaloriePerGramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, 1d, 4184000.0d).SetName("SpecificHeatCapacity_ToBase_KilocaloriePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine, 1d, 4186.7999999999993d).SetName("SpecificHeatCapacity_ToBase_BtuPerPoundRankine");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit, 1d, 130.12972215340773d).SetName("SpecificHeatCapacity_ToBase_BtuPerSlugFahrenheit");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin, 1d, 1.0d).SetName("SpecificHeatCapacity_FromBase_JoulePerKilogramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_KilojoulePerKilogramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_JoulePerGramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_CaloriePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_KilocaloriePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, 1d, 0.00023884589662749597d).SetName("SpecificHeatCapacity_FromBase_BtuPerPoundFahrenheit");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius, 1d, 1.0d).SetName("SpecificHeatCapacity_FromBase_JoulePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_KilojoulePerKilogramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius, 1d, 0.001d).SetName("SpecificHeatCapacity_FromBase_JoulePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin, 1d, 0.0002390057361376673d).SetName("SpecificHeatCapacity_FromBase_CaloriePerGramKelvin");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, 1d, 2.3900573613766732e-07d).SetName("SpecificHeatCapacity_FromBase_KilocaloriePerGramCelsius");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine, 1d, 0.00023884589662749597d).SetName("SpecificHeatCapacity_FromBase_BtuPerPoundRankine");
            yield return new TestCaseData(UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit, 1d, 0.0076846394770682513d).SetName("SpecificHeatCapacity_FromBase_BtuPerSlugFahrenheit");
        }
    }
}
