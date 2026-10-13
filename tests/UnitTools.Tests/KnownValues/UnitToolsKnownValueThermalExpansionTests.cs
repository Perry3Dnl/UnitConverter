namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ThermalExpansion;

    public sealed class UnitToolsKnownValueThermalExpansionTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalExpansion_ToBaseUnit_ReturnsExpectedValue(UnitToolsThermalExpansionUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalExpansion.ToPerKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ThermalExpansion_FromBaseUnit_ReturnsExpectedValue(UnitToolsThermalExpansionUnit unit, double input, double expected)
        {
            double result = UnitToolsThermalExpansion.FromPerKelvin(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ThermalExpansion_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsThermalExpansionUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsThermalExpansion.ToPerKelvin(input, unit);
            double result = UnitToolsThermalExpansion.FromPerKelvin(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerKelvin, 1d, 1.0d).SetName("ThermalExpansion_ToBase_PerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerCelsius, 1d, 1.0d).SetName("ThermalExpansion_ToBase_PerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerFahrenheit, 1d, 1.8d).SetName("ThermalExpansion_ToBase_PerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerKelvin, 1d, 9.9999999999999995e-07d).SetName("ThermalExpansion_ToBase_MicrostrainPerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerKelvin, 1d, 9.9999999999999995e-07d).SetName("ThermalExpansion_ToBase_PpmPerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerCelsius, 1d, 9.9999999999999995e-07d).SetName("ThermalExpansion_ToBase_MicrostrainPerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit, 1d, 1.7999999999999999e-06d).SetName("ThermalExpansion_ToBase_MicrostrainPerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerCelsius, 1d, 9.9999999999999995e-07d).SetName("ThermalExpansion_ToBase_PpmPerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerFahrenheit, 1d, 1.7999999999999999e-06d).SetName("ThermalExpansion_ToBase_PpmPerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerRankine, 1d, 1.8d).SetName("ThermalExpansion_ToBase_PerRankine");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerKelvin, 1d, 1.0d).SetName("ThermalExpansion_FromBase_PerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerCelsius, 1d, 1.0d).SetName("ThermalExpansion_FromBase_PerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerFahrenheit, 1d, 0.55555555555555558d).SetName("ThermalExpansion_FromBase_PerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerKelvin, 1d, 1000000.0d).SetName("ThermalExpansion_FromBase_MicrostrainPerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerKelvin, 1d, 1000000.0d).SetName("ThermalExpansion_FromBase_PpmPerKelvin");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerCelsius, 1d, 1000000.0d).SetName("ThermalExpansion_FromBase_MicrostrainPerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit, 1d, 555555.55555555562d).SetName("ThermalExpansion_FromBase_MicrostrainPerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerCelsius, 1d, 1000000.0d).SetName("ThermalExpansion_FromBase_PpmPerCelsius");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PpmPerFahrenheit, 1d, 555555.55555555562d).SetName("ThermalExpansion_FromBase_PpmPerFahrenheit");
            yield return new TestCaseData(UnitToolsThermalExpansionUnit.PerRankine, 1d, 0.55555555555555558d).SetName("ThermalExpansion_FromBase_PerRankine");
        }
    }
}
