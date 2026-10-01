namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.MagnetizingFieldStrength;

    public sealed class UnitConverterKnownValueMagnetizingFieldStrengthTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagnetizingFieldStrength_ToBaseUnit_ReturnsExpectedValue(UnitConverterMagnetizingFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitConverterMagnetizingFieldStrength.ToAmperePerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagnetizingFieldStrength_FromBaseUnit_ReturnsExpectedValue(UnitConverterMagnetizingFieldStrengthUnit unit, double input, double expected)
        {
            double result = UnitConverterMagnetizingFieldStrength.FromAmperePerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagnetizingFieldStrength_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMagnetizingFieldStrengthUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMagnetizingFieldStrength.ToAmperePerMeter(input, unit);
            double result = UnitConverterMagnetizingFieldStrength.FromAmperePerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter, 1d, 100.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerCentimeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_ToBase_AmperePerMillimeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_ToBase_AmpereTurnPerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.Oersted, 1d, 79.577471545947674d).SetName("MagnetizingFieldStrength_ToBase_Oersted");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_ToBase_KiloamperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_ToBase_MilliamperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch, 1d, 39.370078740157481d).SetName("MagnetizingFieldStrength_ToBase_AmperePerInch");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch, 1d, 39.370078740157481d).SetName("MagnetizingFieldStrength_ToBase_AmpereTurnPerInch");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter, 1d, 79.577471545947674d).SetName("MagnetizingFieldStrength_ToBase_GilbertPerCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_FromBase_AmperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter, 1d, 0.01d).SetName("MagnetizingFieldStrength_FromBase_AmperePerCentimeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_FromBase_AmperePerMillimeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, 1d, 1.0d).SetName("MagnetizingFieldStrength_FromBase_AmpereTurnPerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.Oersted, 1d, 0.012566370614359171d).SetName("MagnetizingFieldStrength_FromBase_Oersted");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter, 1d, 0.001d).SetName("MagnetizingFieldStrength_FromBase_KiloamperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter, 1d, 1000.0d).SetName("MagnetizingFieldStrength_FromBase_MilliamperePerMeter");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch, 1d, 0.025399999999999999d).SetName("MagnetizingFieldStrength_FromBase_AmperePerInch");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch, 1d, 0.025399999999999999d).SetName("MagnetizingFieldStrength_FromBase_AmpereTurnPerInch");
            yield return new TestCaseData(UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter, 1d, 0.012566370614359171d).SetName("MagnetizingFieldStrength_FromBase_GilbertPerCentimeter");
        }
    }
}
