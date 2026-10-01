namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.ForcePerLength;

    public sealed class UnitConverterKnownValueForcePerLengthTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ForcePerLength_ToBaseUnit_ReturnsExpectedValue(UnitConverterForcePerLengthUnit unit, double input, double expected)
        {
            double result = UnitConverterForcePerLength.ToNewtonPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ForcePerLength_FromBaseUnit_ReturnsExpectedValue(UnitConverterForcePerLengthUnit unit, double input, double expected)
        {
            double result = UnitConverterForcePerLength.FromNewtonPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ForcePerLength_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterForcePerLengthUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterForcePerLength.ToNewtonPerMeter(input, unit);
            double result = UnitConverterForcePerLength.FromNewtonPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerMeter, 1d, 1.0d).SetName("ForcePerLength_ToBase_NewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.KilonewtonPerMeter, 1d, 1000.0d).SetName("ForcePerLength_ToBase_KilonewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerMillimeter, 1d, 1000.0d).SetName("ForcePerLength_ToBase_NewtonPerMillimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.PoundForcePerFoot, 1d, 14.593902937206362d).SetName("ForcePerLength_ToBase_PoundForcePerFoot");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.PoundForcePerInch, 1d, 175.12683524647636d).SetName("ForcePerLength_ToBase_PoundForcePerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.MillinewtonPerMeter, 1d, 0.001d).SetName("ForcePerLength_ToBase_MillinewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerCentimeter, 1d, 100.0d).SetName("ForcePerLength_ToBase_NewtonPerCentimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerInch, 1d, 39.370078740157481d).SetName("ForcePerLength_ToBase_NewtonPerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.DynePerCentimeter, 1d, 0.001d).SetName("ForcePerLength_ToBase_DynePerCentimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.OunceForcePerInch, 1d, 10.945427202904773d).SetName("ForcePerLength_ToBase_OunceForcePerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter, 1d, 980.66499999999996d).SetName("ForcePerLength_ToBase_KilogramForcePerCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerMeter, 1d, 1.0d).SetName("ForcePerLength_FromBase_NewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.KilonewtonPerMeter, 1d, 0.001d).SetName("ForcePerLength_FromBase_KilonewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerMillimeter, 1d, 0.001d).SetName("ForcePerLength_FromBase_NewtonPerMillimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.PoundForcePerFoot, 1d, 0.068521765856791761d).SetName("ForcePerLength_FromBase_PoundForcePerFoot");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.PoundForcePerInch, 1d, 0.0057101471547326465d).SetName("ForcePerLength_FromBase_PoundForcePerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.MillinewtonPerMeter, 1d, 1000.0d).SetName("ForcePerLength_FromBase_MillinewtonPerMeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerCentimeter, 1d, 0.01d).SetName("ForcePerLength_FromBase_NewtonPerCentimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.NewtonPerInch, 1d, 0.025399999999999999d).SetName("ForcePerLength_FromBase_NewtonPerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.DynePerCentimeter, 1d, 1000.0d).SetName("ForcePerLength_FromBase_DynePerCentimeter");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.OunceForcePerInch, 1d, 0.091362354475722343d).SetName("ForcePerLength_FromBase_OunceForcePerInch");
            yield return new TestCaseData(UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter, 1d, 0.0010197162129779282d).SetName("ForcePerLength_FromBase_KilogramForcePerCentimeter");
        }
    }
}
