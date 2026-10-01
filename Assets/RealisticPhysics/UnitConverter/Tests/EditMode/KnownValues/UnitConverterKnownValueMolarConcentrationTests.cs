namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.MolarConcentration;

    public sealed class UnitConverterKnownValueMolarConcentrationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarConcentration_ToBaseUnit_ReturnsExpectedValue(UnitConverterMolarConcentrationUnit unit, double input, double expected)
        {
            double result = UnitConverterMolarConcentration.ToMolePerCubicMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MolarConcentration_FromBaseUnit_ReturnsExpectedValue(UnitConverterMolarConcentrationUnit unit, double input, double expected)
        {
            double result = UnitConverterMolarConcentration.FromMolePerCubicMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarConcentration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMolarConcentrationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMolarConcentration.ToMolePerCubicMeter(input, unit);
            double result = UnitConverterMolarConcentration.FromMolePerCubicMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerCubicMeter, 1d, 1.0d).SetName("MolarConcentration_ToBase_MolePerCubicMeter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerLiter, 1d, 1000.0d).SetName("MolarConcentration_ToBase_MolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Molar, 1d, 1000.0d).SetName("MolarConcentration_ToBase_Molar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MillimolePerLiter, 1d, 1.0d).SetName("MolarConcentration_ToBase_MillimolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MicromolePerLiter, 1d, 0.001d).SetName("MolarConcentration_ToBase_MicromolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter, 1d, 1000000.0d).SetName("MolarConcentration_ToBase_MolePerCubicCentimeter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Millimolar, 1d, 1.0d).SetName("MolarConcentration_ToBase_Millimolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Micromolar, 1d, 0.001d).SetName("MolarConcentration_ToBase_Micromolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Nanomolar, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_ToBase_Nanomolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Picomolar, 1d, 1.0000000000000001e-09d).SetName("MolarConcentration_ToBase_Picomolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerMilliliter, 1d, 1000000.0d).SetName("MolarConcentration_ToBase_MolePerMilliliter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MillimolePerMilliliter, 1d, 1000.0d).SetName("MolarConcentration_ToBase_MillimolePerMilliliter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerCubicMeter, 1d, 1.0d).SetName("MolarConcentration_FromBase_MolePerCubicMeter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerLiter, 1d, 0.001d).SetName("MolarConcentration_FromBase_MolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Molar, 1d, 0.001d).SetName("MolarConcentration_FromBase_Molar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MillimolePerLiter, 1d, 1.0d).SetName("MolarConcentration_FromBase_MillimolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MicromolePerLiter, 1d, 1000.0d).SetName("MolarConcentration_FromBase_MicromolePerLiter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_FromBase_MolePerCubicCentimeter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Millimolar, 1d, 1.0d).SetName("MolarConcentration_FromBase_Millimolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Micromolar, 1d, 1000.0d).SetName("MolarConcentration_FromBase_Micromolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Nanomolar, 1d, 1000000.0d).SetName("MolarConcentration_FromBase_Nanomolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.Picomolar, 1d, 999999999.99999988d).SetName("MolarConcentration_FromBase_Picomolar");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MolePerMilliliter, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_FromBase_MolePerMilliliter");
            yield return new TestCaseData(UnitConverterMolarConcentrationUnit.MillimolePerMilliliter, 1d, 0.001d).SetName("MolarConcentration_FromBase_MillimolePerMilliliter");
        }
    }
}
