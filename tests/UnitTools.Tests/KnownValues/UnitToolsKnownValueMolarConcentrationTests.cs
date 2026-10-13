namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MolarConcentration;

    public sealed class UnitToolsKnownValueMolarConcentrationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarConcentration_ToBaseUnit_ReturnsExpectedValue(UnitToolsMolarConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsMolarConcentration.ToMolePerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MolarConcentration_FromBaseUnit_ReturnsExpectedValue(UnitToolsMolarConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsMolarConcentration.FromMolePerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarConcentration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMolarConcentrationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMolarConcentration.ToMolePerCubicMeter(input, unit);
            double result = UnitToolsMolarConcentration.FromMolePerCubicMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerCubicMeter, 1d, 1.0d).SetName("MolarConcentration_ToBase_MolePerCubicMeter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerLiter, 1d, 1000.0d).SetName("MolarConcentration_ToBase_MolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Molar, 1d, 1000.0d).SetName("MolarConcentration_ToBase_Molar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MillimolePerLiter, 1d, 1.0d).SetName("MolarConcentration_ToBase_MillimolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MicromolePerLiter, 1d, 0.001d).SetName("MolarConcentration_ToBase_MicromolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter, 1d, 1000000.0d).SetName("MolarConcentration_ToBase_MolePerCubicCentimeter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Millimolar, 1d, 1.0d).SetName("MolarConcentration_ToBase_Millimolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Micromolar, 1d, 0.001d).SetName("MolarConcentration_ToBase_Micromolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Nanomolar, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_ToBase_Nanomolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Picomolar, 1d, 1.0000000000000001e-09d).SetName("MolarConcentration_ToBase_Picomolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerMilliliter, 1d, 1000000.0d).SetName("MolarConcentration_ToBase_MolePerMilliliter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MillimolePerMilliliter, 1d, 1000.0d).SetName("MolarConcentration_ToBase_MillimolePerMilliliter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerCubicMeter, 1d, 1.0d).SetName("MolarConcentration_FromBase_MolePerCubicMeter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerLiter, 1d, 0.001d).SetName("MolarConcentration_FromBase_MolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Molar, 1d, 0.001d).SetName("MolarConcentration_FromBase_Molar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MillimolePerLiter, 1d, 1.0d).SetName("MolarConcentration_FromBase_MillimolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MicromolePerLiter, 1d, 1000.0d).SetName("MolarConcentration_FromBase_MicromolePerLiter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_FromBase_MolePerCubicCentimeter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Millimolar, 1d, 1.0d).SetName("MolarConcentration_FromBase_Millimolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Micromolar, 1d, 1000.0d).SetName("MolarConcentration_FromBase_Micromolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Nanomolar, 1d, 1000000.0d).SetName("MolarConcentration_FromBase_Nanomolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.Picomolar, 1d, 999999999.99999988d).SetName("MolarConcentration_FromBase_Picomolar");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MolePerMilliliter, 1d, 9.9999999999999995e-07d).SetName("MolarConcentration_FromBase_MolePerMilliliter");
            yield return new TestCaseData(UnitToolsMolarConcentrationUnit.MillimolePerMilliliter, 1d, 0.001d).SetName("MolarConcentration_FromBase_MillimolePerMilliliter");
        }
    }
}
