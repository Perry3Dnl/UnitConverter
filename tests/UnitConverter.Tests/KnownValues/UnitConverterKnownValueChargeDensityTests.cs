namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.ChargeDensity;

    public sealed class UnitConverterKnownValueChargeDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ChargeDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterChargeDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterChargeDensity.ToCoulombPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ChargeDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterChargeDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterChargeDensity.FromCoulombPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ChargeDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterChargeDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterChargeDensity.ToCoulombPerCubicMeter(input, unit);
            double result = UnitConverterChargeDensity.FromCoulombPerCubicMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicMeter, 1d, 1.0d).SetName("ChargeDensity_ToBase_CoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter, 1d, 0.001d).SetName("ChargeDensity_ToBase_MillicoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("ChargeDensity_ToBase_MicrocoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerLiter, 1d, 1000.0d).SetName("ChargeDensity_ToBase_CoulombPerLiter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter, 1d, 1000000.0d).SetName("ChargeDensity_ToBase_CoulombPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter, 1d, 0.00033356409519815205d).SetName("ChargeDensity_ToBase_StatcoulombPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter, 1d, 1.0000000000000001e-09d).SetName("ChargeDensity_ToBase_NanocoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter, 1d, 1000000000.0d).SetName("ChargeDensity_ToBase_CoulombPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicInch, 1d, 61023.74409473229d).SetName("ChargeDensity_ToBase_CoulombPerCubicInch");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MicrocoulombPerLiter, 1d, 0.001d).SetName("ChargeDensity_ToBase_MicrocoulombPerLiter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.NanocoulombPerLiter, 1d, 9.9999999999999995e-07d).SetName("ChargeDensity_ToBase_NanocoulombPerLiter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicMeter, 1d, 1.0d).SetName("ChargeDensity_FromBase_CoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter, 1d, 1000.0d).SetName("ChargeDensity_FromBase_MillicoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter, 1d, 1000000.0d).SetName("ChargeDensity_FromBase_MicrocoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerLiter, 1d, 0.001d).SetName("ChargeDensity_FromBase_CoulombPerLiter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("ChargeDensity_FromBase_CoulombPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter, 1d, 2997.9245799999999d).SetName("ChargeDensity_FromBase_StatcoulombPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter, 1d, 999999999.99999988d).SetName("ChargeDensity_FromBase_NanocoulombPerCubicMeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("ChargeDensity_FromBase_CoulombPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.CoulombPerCubicInch, 1d, 1.6387063999999999e-05d).SetName("ChargeDensity_FromBase_CoulombPerCubicInch");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.MicrocoulombPerLiter, 1d, 1000.0d).SetName("ChargeDensity_FromBase_MicrocoulombPerLiter");
            yield return new TestCaseData(UnitConverterChargeDensityUnit.NanocoulombPerLiter, 1d, 1000000.0d).SetName("ChargeDensity_FromBase_NanocoulombPerLiter");
        }
    }
}
