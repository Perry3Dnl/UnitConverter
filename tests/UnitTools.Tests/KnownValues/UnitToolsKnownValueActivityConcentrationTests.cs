namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ActivityConcentration;

    public sealed class UnitToolsKnownValueActivityConcentrationTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ActivityConcentration_ToBaseUnit_ReturnsExpectedValue(UnitToolsActivityConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsActivityConcentration.ToBecquerelPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ActivityConcentration_FromBaseUnit_ReturnsExpectedValue(UnitToolsActivityConcentrationUnit unit, double input, double expected)
        {
            double result = UnitToolsActivityConcentration.FromBecquerelPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ActivityConcentration_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsActivityConcentrationUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsActivityConcentration.ToBecquerelPerCubicMeter(input, unit);
            double result = UnitToolsActivityConcentration.FromBecquerelPerCubicMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter, 1d, 1.0d).SetName("ActivityConcentration_ToBase_BecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter, 1d, 1000.0d).SetName("ActivityConcentration_ToBase_KilobecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter, 1d, 1000000.0d).SetName("ActivityConcentration_ToBase_MegabecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerLiter, 1d, 1000.0d).SetName("ActivityConcentration_ToBase_BecquerelPerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.CuriePerCubicMeter, 1d, 37000000000.0d).SetName("ActivityConcentration_ToBase_CuriePerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter, 1d, 0.001d).SetName("ActivityConcentration_ToBase_MillibecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("ActivityConcentration_ToBase_MicrobecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter, 1d, 1000000.0d).SetName("ActivityConcentration_ToBase_BecquerelPerMilliliter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter, 1d, 1000000.0d).SetName("ActivityConcentration_ToBase_KilobecquerelPerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MicrocuriePerLiter, 1d, 37000000.0d).SetName("ActivityConcentration_ToBase_MicrocuriePerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter, 1d, 1000000.0d).SetName("ActivityConcentration_ToBase_BecquerelPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon, 1d, 264.17205235814839d).SetName("ActivityConcentration_ToBase_BecquerelPerUSGallon");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.PicocuriePerLiter, 1d, 37.0d).SetName("ActivityConcentration_ToBase_PicocuriePerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.NanocuriePerLiter, 1d, 37000.0d).SetName("ActivityConcentration_ToBase_NanocuriePerLiter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter, 1d, 1.0d).SetName("ActivityConcentration_FromBase_BecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter, 1d, 0.001d).SetName("ActivityConcentration_FromBase_KilobecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("ActivityConcentration_FromBase_MegabecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerLiter, 1d, 0.001d).SetName("ActivityConcentration_FromBase_BecquerelPerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.CuriePerCubicMeter, 1d, 2.7027027027027027e-11d).SetName("ActivityConcentration_FromBase_CuriePerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter, 1d, 1000.0d).SetName("ActivityConcentration_FromBase_MillibecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter, 1d, 1000000.0d).SetName("ActivityConcentration_FromBase_MicrobecquerelPerCubicMeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter, 1d, 9.9999999999999995e-07d).SetName("ActivityConcentration_FromBase_BecquerelPerMilliliter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter, 1d, 9.9999999999999995e-07d).SetName("ActivityConcentration_FromBase_KilobecquerelPerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.MicrocuriePerLiter, 1d, 2.7027027027027028e-08d).SetName("ActivityConcentration_FromBase_MicrocuriePerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("ActivityConcentration_FromBase_BecquerelPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon, 1d, 0.0037854117840000001d).SetName("ActivityConcentration_FromBase_BecquerelPerUSGallon");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.PicocuriePerLiter, 1d, 0.027027027027027029d).SetName("ActivityConcentration_FromBase_PicocuriePerLiter");
            yield return new TestCaseData(UnitToolsActivityConcentrationUnit.NanocuriePerLiter, 1d, 2.7027027027027027e-05d).SetName("ActivityConcentration_FromBase_NanocuriePerLiter");
        }
    }
}
