namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.ElectricFieldStrength;

    public sealed class UnitConverterKnownValueElectricFieldStrengthTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFieldStrength_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFieldStrength.ToVoltPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricFieldStrength_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFieldStrength.FromVoltPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFieldStrength_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricFieldStrengthUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricFieldStrength.ToVoltPerMeter(input, unit);
            double result = UnitConverterElectricFieldStrength.FromVoltPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerMeter, 1d, 1.0d).SetName("ElectricFieldStrength_ToBase_VoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter, 1d, 0.001d).SetName("ElectricFieldStrength_ToBase_MillivoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter, 1d, 1000.0d).SetName("ElectricFieldStrength_ToBase_KilovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter, 1d, 100.0d).SetName("ElectricFieldStrength_ToBase_VoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter, 1d, 1000.0d).SetName("ElectricFieldStrength_ToBase_VoltPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter, 1d, 29979.245800000001d).SetName("ElectricFieldStrength_ToBase_StatvoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFieldStrength_ToBase_MicrovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter, 1d, 1000000.0d).SetName("ElectricFieldStrength_ToBase_MegavoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter, 1d, 100000.0d).SetName("ElectricFieldStrength_ToBase_KilovoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerInch, 1d, 39.370078740157481d).SetName("ElectricFieldStrength_ToBase_VoltPerInch");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerFoot, 1d, 3.280839895013123d).SetName("ElectricFieldStrength_ToBase_VoltPerFoot");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricFieldStrength_ToBase_NanovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter, 1d, 1000000000.0d).SetName("ElectricFieldStrength_ToBase_GigavoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter, 1d, 299.79245800000001d).SetName("ElectricFieldStrength_ToBase_StatvoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFieldStrength_ToBase_AbvoltPerCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerMeter, 1d, 1.0d).SetName("ElectricFieldStrength_FromBase_VoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter, 1d, 1000.0d).SetName("ElectricFieldStrength_FromBase_MillivoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter, 1d, 0.001d).SetName("ElectricFieldStrength_FromBase_KilovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter, 1d, 0.01d).SetName("ElectricFieldStrength_FromBase_VoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter, 1d, 0.001d).SetName("ElectricFieldStrength_FromBase_VoltPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter, 1d, 3.3356409519815205e-05d).SetName("ElectricFieldStrength_FromBase_StatvoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter, 1d, 1000000.0d).SetName("ElectricFieldStrength_FromBase_MicrovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFieldStrength_FromBase_MegavoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter, 1d, 1.0000000000000001e-05d).SetName("ElectricFieldStrength_FromBase_KilovoltPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerInch, 1d, 0.025399999999999999d).SetName("ElectricFieldStrength_FromBase_VoltPerInch");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.VoltPerFoot, 1d, 0.30480000000000002d).SetName("ElectricFieldStrength_FromBase_VoltPerFoot");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter, 1d, 999999999.99999988d).SetName("ElectricFieldStrength_FromBase_NanovoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricFieldStrength_FromBase_GigavoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter, 1d, 0.0033356409519815205d).SetName("ElectricFieldStrength_FromBase_StatvoltPerMeter");
            yield return new TestCaseData(UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter, 1d, 1000000.0d).SetName("ElectricFieldStrength_FromBase_AbvoltPerCentimeter");
        }
    }
}
