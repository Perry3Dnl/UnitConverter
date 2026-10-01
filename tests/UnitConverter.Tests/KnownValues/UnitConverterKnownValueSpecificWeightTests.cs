namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.SpecificWeight;

    public sealed class UnitConverterKnownValueSpecificWeightTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificWeight_ToBaseUnit_ReturnsExpectedValue(UnitConverterSpecificWeightUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificWeight.ToNewtonPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificWeight_FromBaseUnit_ReturnsExpectedValue(UnitConverterSpecificWeightUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificWeight.FromNewtonPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificWeight_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSpecificWeightUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSpecificWeight.ToNewtonPerCubicMeter(input, unit);
            double result = UnitConverterSpecificWeight.FromNewtonPerCubicMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicMeter, 1d, 1.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter, 1d, 1000.0d).SetName("SpecificWeight_ToBase_KilonewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerLiter, 1d, 1000.0d).SetName("SpecificWeight_ToBase_NewtonPerLiter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot, 1d, 157.08746384624618d).SetName("SpecificWeight_ToBase_PoundForcePerCubicFoot");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter, 1d, 9.8066499999999994d).SetName("SpecificWeight_ToBase_KilogramForcePerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter, 1d, 0.001d).SetName("SpecificWeight_ToBase_MillinewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter, 1d, 1000000.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter, 1d, 1000000000.0d).SetName("SpecificWeight_ToBase_NewtonPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot, 1d, 9.8179664903903863d).SetName("SpecificWeight_ToBase_OunceForcePerCubicFoot");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerUSGallon, 1d, 1175.0958334472441d).SetName("SpecificWeight_ToBase_PoundForcePerUSGallon");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon, 1d, 978.47196497660616d).SetName("SpecificWeight_ToBase_PoundForcePerImperialGallon");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicMeter, 1d, 1.0d).SetName("SpecificWeight_FromBase_NewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter, 1d, 0.001d).SetName("SpecificWeight_FromBase_KilonewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerLiter, 1d, 0.001d).SetName("SpecificWeight_FromBase_NewtonPerLiter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot, 1d, 0.0063658803542641597d).SetName("SpecificWeight_FromBase_PoundForcePerCubicFoot");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter, 1d, 0.10197162129779283d).SetName("SpecificWeight_FromBase_KilogramForcePerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter, 1d, 1000.0d).SetName("SpecificWeight_FromBase_MillinewtonPerCubicMeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("SpecificWeight_FromBase_NewtonPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("SpecificWeight_FromBase_NewtonPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot, 1d, 0.10185408566822655d).SetName("SpecificWeight_FromBase_OunceForcePerCubicFoot");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerUSGallon, 1d, 0.00085099442235822976d).SetName("SpecificWeight_FromBase_PoundForcePerUSGallon");
            yield return new TestCaseData(UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon, 1d, 0.0010220016881361629d).SetName("SpecificWeight_FromBase_PoundForcePerImperialGallon");
        }
    }
}
