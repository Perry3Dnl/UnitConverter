namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.EnergyDensity;

    public sealed class UnitConverterKnownValueEnergyDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void EnergyDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterEnergyDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterEnergyDensity.ToJoulePerCubicMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void EnergyDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterEnergyDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterEnergyDensity.FromJoulePerCubicMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void EnergyDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterEnergyDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterEnergyDensity.ToJoulePerCubicMeter(input, unit);
            double result = UnitConverterEnergyDensity.FromJoulePerCubicMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.JoulePerCubicMeter, 1d, 1.0d).SetName("EnergyDensity_ToBase_JoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter, 1d, 1000.0d).SetName("EnergyDensity_ToBase_KilojoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter, 1d, 1000000.0d).SetName("EnergyDensity_ToBase_MegajoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.JoulePerLiter, 1d, 1000.0d).SetName("EnergyDensity_ToBase_JoulePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.WattHourPerLiter, 1d, 3600000.0d).SetName("EnergyDensity_ToBase_WattHourPerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.BtuPerCubicFoot, 1d, 37258.945807831282d).SetName("EnergyDensity_ToBase_BtuPerCubicFoot");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer, 1d, 160217663.40000001d).SetName("EnergyDensity_ToBase_ElectronVoltPerCubicNanometer");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.MegajoulePerLiter, 1d, 1000000000.0d).SetName("EnergyDensity_ToBase_MegajoulePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilowattHourPerLiter, 1d, 3600000000.0d).SetName("EnergyDensity_ToBase_KilowattHourPerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.CaloriePerLiter, 1d, 4184.0d).SetName("EnergyDensity_ToBase_CaloriePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilocaloriePerLiter, 1d, 4184000.0d).SetName("EnergyDensity_ToBase_KilocaloriePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot, 1d, 47.880258980335839d).SetName("EnergyDensity_ToBase_FootPoundPerCubicFoot");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.ThermPerCubicFoot, 1d, 3725894580.6188445d).SetName("EnergyDensity_ToBase_ThermPerCubicFoot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.JoulePerCubicMeter, 1d, 1.0d).SetName("EnergyDensity_FromBase_JoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter, 1d, 0.001d).SetName("EnergyDensity_FromBase_KilojoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("EnergyDensity_FromBase_MegajoulePerCubicMeter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.JoulePerLiter, 1d, 0.001d).SetName("EnergyDensity_FromBase_JoulePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.WattHourPerLiter, 1d, 2.7777777777777776e-07d).SetName("EnergyDensity_FromBase_WattHourPerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.BtuPerCubicFoot, 1d, 2.6839191993183411e-05d).SetName("EnergyDensity_FromBase_BtuPerCubicFoot");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer, 1d, 6.2415090744607626e-09d).SetName("EnergyDensity_FromBase_ElectronVoltPerCubicNanometer");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.MegajoulePerLiter, 1d, 1.0000000000000001e-09d).SetName("EnergyDensity_FromBase_MegajoulePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilowattHourPerLiter, 1d, 2.7777777777777777e-10d).SetName("EnergyDensity_FromBase_KilowattHourPerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.CaloriePerLiter, 1d, 0.0002390057361376673d).SetName("EnergyDensity_FromBase_CaloriePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.KilocaloriePerLiter, 1d, 2.3900573613766732e-07d).SetName("EnergyDensity_FromBase_KilocaloriePerLiter");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot, 1d, 0.020885434233150129d).SetName("EnergyDensity_FromBase_FootPoundPerCubicFoot");
            yield return new TestCaseData(UnitConverterEnergyDensityUnit.ThermPerCubicFoot, 1d, 2.6839191994366819e-10d).SetName("EnergyDensity_FromBase_ThermPerCubicFoot");
        }
    }
}
