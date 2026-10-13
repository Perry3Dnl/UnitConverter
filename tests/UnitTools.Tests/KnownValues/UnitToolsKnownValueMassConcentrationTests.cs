namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MassConcentration;

    public sealed class UnitToolsKnownValueMassConcentrationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MassConcentration_ToBaseUnit_ReturnsExpectedValue(UnitToolsMassConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsMassConcentration.ToKilogramPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MassConcentration_FromBaseUnit_ReturnsExpectedValue(UnitToolsMassConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsMassConcentration.FromKilogramPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MassConcentration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMassConcentrationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMassConcentration.ToKilogramPerCubicMeter(input, unit);
            double result = UnitToolsMassConcentration.FromKilogramPerCubicMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("MassConcentration_ToBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerLiter, 1d, 1.0d).SetName("MassConcentration_ToBase_GramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MilligramPerLiter, 1d, 0.001d).SetName("MassConcentration_ToBase_MilligramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MicrogramPerLiter, 1d, 9.9999999999999995e-07d).SetName("MassConcentration_ToBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerCubicMeter, 1d, 0.001d).SetName("MassConcentration_ToBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PartPerMillionWater, 1d, 0.001d).SetName("MassConcentration_ToBase_PartPerMillionWater");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.NanogramPerLiter, 1d, 1.0000000000000001e-09d).SetName("MassConcentration_ToBase_NanogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("MassConcentration_ToBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerMilliliter, 1d, 1000.0d).SetName("MassConcentration_ToBase_GramPerMilliliter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.KilogramPerLiter, 1d, 1000.0d).SetName("MassConcentration_ToBase_KilogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PoundPerCubicFoot, 1d, 16.018463373960142d).SetName("MassConcentration_ToBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PoundPerUSGallon, 1d, 119.82642731689663d).SetName("MassConcentration_ToBase_PoundPerUSGallon");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("MassConcentration_FromBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerLiter, 1d, 1.0d).SetName("MassConcentration_FromBase_GramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MilligramPerLiter, 1d, 1000.0d).SetName("MassConcentration_FromBase_MilligramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MicrogramPerLiter, 1d, 1000000.0d).SetName("MassConcentration_FromBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerCubicMeter, 1d, 1000.0d).SetName("MassConcentration_FromBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PartPerMillionWater, 1d, 1000.0d).SetName("MassConcentration_FromBase_PartPerMillionWater");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.NanogramPerLiter, 1d, 999999999.99999988d).SetName("MassConcentration_FromBase_NanogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("MassConcentration_FromBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.GramPerMilliliter, 1d, 0.001d).SetName("MassConcentration_FromBase_GramPerMilliliter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.KilogramPerLiter, 1d, 0.001d).SetName("MassConcentration_FromBase_KilogramPerLiter");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PoundPerCubicFoot, 1d, 0.062427960576144602d).SetName("MassConcentration_FromBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitToolsMassConcentrationUnit.PoundPerUSGallon, 1d, 0.0083454044520193324d).SetName("MassConcentration_FromBase_PoundPerUSGallon");
        }
    }
}
