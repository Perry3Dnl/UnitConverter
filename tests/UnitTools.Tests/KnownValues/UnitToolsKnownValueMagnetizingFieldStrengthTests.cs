namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MagnetizingFieldStrength;

    public sealed class UnitToolsKnownValueMagnetizingFieldStrengthTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagnetizingFieldStrength_ToBaseUnit_ReturnsExpectedValue(UnitToolsMagnetizingFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitToolsMagnetizingFieldStrength.ToAmperePerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagnetizingFieldStrength_FromBaseUnit_ReturnsExpectedValue(UnitToolsMagnetizingFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitToolsMagnetizingFieldStrength.FromAmperePerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagnetizingFieldStrength_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMagnetizingFieldStrengthUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMagnetizingFieldStrength.ToAmperePerMeter(input, unit);
            double result = UnitToolsMagnetizingFieldStrength.FromAmperePerMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter, 1d, 100.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerCentimeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerMillimeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_ToBase_AmpereTurnPerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.Oersted, 1d, 79.577471545947674d).SetName("MagnetizingFieldStrength_ToBase_Oersted");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_ToBase_KiloamperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_ToBase_MilliamperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch, 1d, 39.370078740157481d).SetName("MagnetizingFieldStrength_ToBase_AmperePerInch");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch, 1d, 39.370078740157481d).SetName("MagnetizingFieldStrength_ToBase_AmpereTurnPerInch");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter, 1d, 79.577471545947674d).SetName("MagnetizingFieldStrength_ToBase_GilbertPerCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_FromBase_AmperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter, 1d, 0.01d).SetName("MagnetizingFieldStrength_FromBase_AmperePerCentimeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_FromBase_AmperePerMillimeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_FromBase_AmpereTurnPerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.Oersted, 1d, 0.012566370614359171d).SetName("MagnetizingFieldStrength_FromBase_Oersted");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_FromBase_KiloamperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_FromBase_MilliamperePerMeter");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch, 1d, 0.025399999999999999d).SetName("MagnetizingFieldStrength_FromBase_AmperePerInch");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch, 1d, 0.025399999999999999d).SetName("MagnetizingFieldStrength_FromBase_AmpereTurnPerInch");
            yield return new TestCaseData(UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter, 1d, 0.012566370614359171d).SetName("MagnetizingFieldStrength_FromBase_GilbertPerCentimeter");
        }
    }
}
