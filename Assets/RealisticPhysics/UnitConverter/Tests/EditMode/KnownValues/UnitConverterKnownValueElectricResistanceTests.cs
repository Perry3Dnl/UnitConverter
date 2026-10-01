namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.ElectricResistance;

    public sealed class UnitConverterKnownValueElectricResistanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricResistance_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricResistanceUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricResistance.ToOhm(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricResistance_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricResistanceUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricResistance.FromOhm(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricResistance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricResistanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricResistance.ToOhm(input, unit);
            double result = UnitConverterElectricResistance.FromOhm(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Microohm, 1d, 9.9999999999999995e-07d).SetName("ElectricResistance_ToBase_Microohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Milliohm, 1d, 0.001d).SetName("ElectricResistance_ToBase_Milliohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Ohm, 1d, 1.0d).SetName("ElectricResistance_ToBase_Ohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Kiloohm, 1d, 1000.0d).SetName("ElectricResistance_ToBase_Kiloohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Megaohm, 1d, 1000000.0d).SetName("ElectricResistance_ToBase_Megaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Gigaohm, 1d, 1000000000.0d).SetName("ElectricResistance_ToBase_Gigaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Statohm, 1d, 898755178700.0d).SetName("ElectricResistance_ToBase_Statohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Picoohm, 1d, 9.9999999999999998e-13d).SetName("ElectricResistance_ToBase_Picoohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Nanoohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_ToBase_Nanoohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Teraohm, 1d, 1000000000000.0d).SetName("ElectricResistance_ToBase_Teraohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Petaohm, 1d, 1000000000000000.0d).SetName("ElectricResistance_ToBase_Petaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Abohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_ToBase_Abohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.QuantumHallResistance, 1d, 25812.80745d).SetName("ElectricResistance_ToBase_QuantumHallResistance");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Microohm, 1d, 1000000.0d).SetName("ElectricResistance_FromBase_Microohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Milliohm, 1d, 1000.0d).SetName("ElectricResistance_FromBase_Milliohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Ohm, 1d, 1.0d).SetName("ElectricResistance_FromBase_Ohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Kiloohm, 1d, 0.001d).SetName("ElectricResistance_FromBase_Kiloohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Megaohm, 1d, 9.9999999999999995e-07d).SetName("ElectricResistance_FromBase_Megaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Gigaohm, 1d, 1.0000000000000001e-09d).SetName("ElectricResistance_FromBase_Gigaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Statohm, 1d, 1.1126500560991982e-12d).SetName("ElectricResistance_FromBase_Statohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Picoohm, 1d, 1000000000000.0d).SetName("ElectricResistance_FromBase_Picoohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Nanoohm, 1d, 999999999.99999988d).SetName("ElectricResistance_FromBase_Nanoohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Teraohm, 1d, 9.9999999999999998e-13d).SetName("ElectricResistance_FromBase_Teraohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Petaohm, 1d, 1.0000000000000001e-15d).SetName("ElectricResistance_FromBase_Petaohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.Abohm, 1d, 999999999.99999988d).SetName("ElectricResistance_FromBase_Abohm");
            yield return new TestCaseData(UnitConverterElectricResistanceUnit.QuantumHallResistance, 1d, 3.8740458663282673e-05d).SetName("ElectricResistance_FromBase_QuantumHallResistance");
        }
    }
}
