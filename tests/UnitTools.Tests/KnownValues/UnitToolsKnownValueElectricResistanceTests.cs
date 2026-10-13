namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ElectricResistance;

    public sealed class UnitToolsKnownValueElectricResistanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricResistance_ToBaseUnit_ReturnsExpectedValue(UnitToolsElectricResistanceUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricResistance.ToOhm(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricResistance_FromBaseUnit_ReturnsExpectedValue(UnitToolsElectricResistanceUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricResistance.FromOhm(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricResistance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsElectricResistanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsElectricResistance.ToOhm(input, unit);
            double result = UnitToolsElectricResistance.FromOhm(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Microohm, 1d, 9.9999999999999995e-07d).SetName("ElectricResistance_ToBase_Microohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Milliohm, 1d, 0.001d).SetName("ElectricResistance_ToBase_Milliohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Ohm, 1d, 1.0d).SetName("ElectricResistance_ToBase_Ohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Kiloohm, 1d, 1000.0d).SetName("ElectricResistance_ToBase_Kiloohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Megaohm, 1d, 1000000.0d).SetName("ElectricResistance_ToBase_Megaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Gigaohm, 1d, 1000000000.0d).SetName("ElectricResistance_ToBase_Gigaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Statohm, 1d, 898755178700.0d).SetName("ElectricResistance_ToBase_Statohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Picoohm, 1d, 9.9999999999999998e-13d).SetName("ElectricResistance_ToBase_Picoohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Nanoohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_ToBase_Nanoohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Teraohm, 1d, 1000000000000.0d).SetName("ElectricResistance_ToBase_Teraohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Petaohm, 1d, 1000000000000000.0d).SetName("ElectricResistance_ToBase_Petaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Abohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_ToBase_Abohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.QuantumHallResistance, 1d, 25812.80745d).SetName("ElectricResistance_ToBase_QuantumHallResistance");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Microohm, 1d, 1000000.0d).SetName("ElectricResistance_FromBase_Microohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Milliohm, 1d, 1000.0d).SetName("ElectricResistance_FromBase_Milliohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Ohm, 1d, 1.0d).SetName("ElectricResistance_FromBase_Ohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Kiloohm, 1d, 0.001d).SetName("ElectricResistance_FromBase_Kiloohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Megaohm, 1d, 9.9999999999999995e-07d).SetName("ElectricResistance_FromBase_Megaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Gigaohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_FromBase_Gigaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Statohm, 1d, 1.1126500560991982e-12d).SetName("ElectricResistance_FromBase_Statohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Picoohm, 1d, 1000000000000.0d).SetName("ElectricResistance_FromBase_Picoohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Nanoohm, 1d, 999999999.99999988d).SetName("ElectricResistance_FromBase_Nanoohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Teraohm, 1d, 9.9999999999999998e-13d).SetName("ElectricResistance_FromBase_Teraohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Petaohm, 1d, 1.0000000000000001e-15d).SetName("ElectricResistance_FromBase_Petaohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.Abohm, 1d, 999999999.99999988d).SetName("ElectricResistance_FromBase_Abohm");
            yield return new TestCaseData(UnitToolsElectricResistanceUnit.QuantumHallResistance, 1d, 3.8740458663282673e-05d).SetName("ElectricResistance_FromBase_QuantumHallResistance");
        }
    }
}
