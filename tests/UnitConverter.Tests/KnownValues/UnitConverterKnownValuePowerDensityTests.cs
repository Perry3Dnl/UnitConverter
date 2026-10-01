namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.PowerDensity;

    public sealed class UnitConverterKnownValuePowerDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void PowerDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterPowerDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterPowerDensity.ToWattPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void PowerDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterPowerDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterPowerDensity.FromWattPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void PowerDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterPowerDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterPowerDensity.ToWattPerCubicMeter(input, unit);
            double result = UnitConverterPowerDensity.FromWattPerCubicMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicMeter, 1d, 1.0d).SetName("PowerDensity_ToBase_WattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.KilowattPerCubicMeter, 1d, 1000.0d).SetName("PowerDensity_ToBase_KilowattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.MegawattPerCubicMeter, 1d, 1000000.0d).SetName("PowerDensity_ToBase_MegawattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerLiter, 1d, 1000.0d).SetName("PowerDensity_ToBase_WattPerLiter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot, 1d, 26334.1424539367d).SetName("PowerDensity_ToBase_HorsepowerPerCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.BtuPerHourCubicFoot, 1d, 10.349707168842023d).SetName("PowerDensity_ToBase_BtuPerHourCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.MilliwattPerCubicMeter, 1d, 0.001d).SetName("PowerDensity_ToBase_MilliwattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicCentimeter, 1d, 1000000.0d).SetName("PowerDensity_ToBase_WattPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicMillimeter, 1d, 1000000000.0d).SetName("PowerDensity_ToBase_WattPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.KilowattPerCubicFoot, 1d, 35314.666721488589d).SetName("PowerDensity_ToBase_KilowattPerCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot, 1d, 37258.945807831282d).SetName("PowerDensity_ToBase_BtuPerSecondCubicFoot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicMeter, 1d, 1.0d).SetName("PowerDensity_FromBase_WattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.KilowattPerCubicMeter, 1d, 0.001d).SetName("PowerDensity_FromBase_KilowattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.MegawattPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("PowerDensity_FromBase_MegawattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerLiter, 1d, 0.001d).SetName("PowerDensity_FromBase_WattPerLiter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot, 1d, 3.7973516766273501e-05d).SetName("PowerDensity_FromBase_HorsepowerPerCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.BtuPerHourCubicFoot, 1d, 0.096621091175460277d).SetName("PowerDensity_FromBase_BtuPerHourCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.MilliwattPerCubicMeter, 1d, 1000.0d).SetName("PowerDensity_FromBase_MilliwattPerCubicMeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("PowerDensity_FromBase_WattPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.WattPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("PowerDensity_FromBase_WattPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.KilowattPerCubicFoot, 1d, 2.8316846591999999e-05d).SetName("PowerDensity_FromBase_KilowattPerCubicFoot");
            yield return new TestCaseData(UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot, 1d, 2.6839191993183411e-05d).SetName("PowerDensity_FromBase_BtuPerSecondCubicFoot");
        }
    }
}
