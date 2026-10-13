namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Voltage;

    public sealed class UnitToolsKnownValueVoltageTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Voltage_ToBaseUnit_ReturnsExpectedValue(UnitToolsVoltageUnit unit, double input, double expected)
        {
            double result = UnitToolsVoltage.ToVolt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Voltage_FromBaseUnit_ReturnsExpectedValue(UnitToolsVoltageUnit unit, double input, double expected)
        {
            double result = UnitToolsVoltage.FromVolt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Voltage_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsVoltageUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsVoltage.ToVolt(input, unit);
            double result = UnitToolsVoltage.FromVolt(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsVoltageUnit.Nanovolt, 1d, 1.0000000000000001e-09d).SetName("Voltage_ToBase_Nanovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Microvolt, 1d, 9.9999999999999995e-07d).SetName("Voltage_ToBase_Microvolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Millivolt, 1d, 0.001d).SetName("Voltage_ToBase_Millivolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Volt, 1d, 1.0d).SetName("Voltage_ToBase_Volt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Kilovolt, 1d, 1000.0d).SetName("Voltage_ToBase_Kilovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Megavolt, 1d, 1000000.0d).SetName("Voltage_ToBase_Megavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Gigavolt, 1d, 1000000000.0d).SetName("Voltage_ToBase_Gigavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Statvolt, 1d, 299.79245800000001d).SetName("Voltage_ToBase_Statvolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Femtovolt, 1d, 1.0000000000000001e-15d).SetName("Voltage_ToBase_Femtovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Picovolt, 1d, 9.9999999999999998e-13d).SetName("Voltage_ToBase_Picovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Teravolt, 1d, 1000000000000.0d).SetName("Voltage_ToBase_Teravolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Petavolt, 1d, 1000000000000000.0d).SetName("Voltage_ToBase_Petavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Abvolt, 1d, 1e-08d).SetName("Voltage_ToBase_Abvolt");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsVoltageUnit.Nanovolt, 1d, 999999999.99999988d).SetName("Voltage_FromBase_Nanovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Microvolt, 1d, 1000000.0d).SetName("Voltage_FromBase_Microvolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Millivolt, 1d, 1000.0d).SetName("Voltage_FromBase_Millivolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Volt, 1d, 1.0d).SetName("Voltage_FromBase_Volt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Kilovolt, 1d, 0.001d).SetName("Voltage_FromBase_Kilovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Megavolt, 1d, 9.9999999999999995e-07d).SetName("Voltage_FromBase_Megavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Gigavolt, 1d, 1.0000000000000001e-09d).SetName("Voltage_FromBase_Gigavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Statvolt, 1d, 0.0033356409519815205d).SetName("Voltage_FromBase_Statvolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Femtovolt, 1d, 999999999999999.88d).SetName("Voltage_FromBase_Femtovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Picovolt, 1d, 1000000000000.0d).SetName("Voltage_FromBase_Picovolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Teravolt, 1d, 9.9999999999999998e-13d).SetName("Voltage_FromBase_Teravolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Petavolt, 1d, 1.0000000000000001e-15d).SetName("Voltage_FromBase_Petavolt");
            yield return new TestCaseData(UnitToolsVoltageUnit.Abvolt, 1d, 100000000.0d).SetName("Voltage_FromBase_Abvolt");
        }
    }
}
