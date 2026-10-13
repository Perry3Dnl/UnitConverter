namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.SpecificWeight;

    public sealed class UnitToolsKnownValueSpecificWeightTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificWeight_ToBaseUnit_ReturnsExpectedValue(UnitToolsSpecificWeightUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificWeight.ToNewtonPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificWeight_FromBaseUnit_ReturnsExpectedValue(UnitToolsSpecificWeightUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificWeight.FromNewtonPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificWeight_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsSpecificWeightUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsSpecificWeight.ToNewtonPerCubicMeter(input, unit);
            double result = UnitToolsSpecificWeight.FromNewtonPerCubicMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicMeter, 1d, 1.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter, 1d, 1000.0d).SetName("SpecificWeight_ToBase_KilonewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerLiter, 1d, 1000.0d).SetName("SpecificWeight_ToBase_NewtonPerLiter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot, 1d, 157.08746384624618d).SetName("SpecificWeight_ToBase_PoundForcePerCubicFoot");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter, 1d, 9.8066499999999994d).SetName("SpecificWeight_ToBase_KilogramForcePerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter, 1d, 0.001d).SetName("SpecificWeight_ToBase_MillinewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter, 1d, 1000000.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter, 1d, 1000000000.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot, 1d, 9.8179664903903863d).SetName("SpecificWeight_ToBase_OunceForcePerCubicFoot");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerUSGallon, 1d, 1175.0958334472441d).SetName("SpecificWeight_ToBase_PoundForcePerUSGallon");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon, 1d, 978.47196497660616d).SetName("SpecificWeight_ToBase_PoundForcePerImperialGallon");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicMeter, 1d, 1.0d).SetName("SpecificWeight_FromBase_NewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter, 1d, 0.001d).SetName("SpecificWeight_FromBase_KilonewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerLiter, 1d, 0.001d).SetName("SpecificWeight_FromBase_NewtonPerLiter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot, 1d, 0.0063658803542641597d).SetName("SpecificWeight_FromBase_PoundForcePerCubicFoot");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter, 1d, 0.10197162129779283d).SetName("SpecificWeight_FromBase_KilogramForcePerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter, 1d, 1000.0d).SetName("SpecificWeight_FromBase_MillinewtonPerCubicMeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("SpecificWeight_FromBase_NewtonPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("SpecificWeight_FromBase_NewtonPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot, 1d, 0.10185408566822655d).SetName("SpecificWeight_FromBase_OunceForcePerCubicFoot");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerUSGallon, 1d, 0.00085099442235822976d).SetName("SpecificWeight_FromBase_PoundForcePerUSGallon");
            yield return new TestCaseData(UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon, 1d, 0.0010220016881361629d).SetName("SpecificWeight_FromBase_PoundForcePerImperialGallon");
        }
    }
}
