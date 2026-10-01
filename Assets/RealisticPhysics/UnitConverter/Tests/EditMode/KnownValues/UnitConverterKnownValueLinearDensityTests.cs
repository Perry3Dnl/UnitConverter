namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.LinearDensity;

    public sealed class UnitConverterKnownValueLinearDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LinearDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterLinearDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterLinearDensity.ToKilogramPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LinearDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterLinearDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterLinearDensity.FromKilogramPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LinearDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterLinearDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterLinearDensity.ToKilogramPerMeter(input, unit);
            double result = UnitConverterLinearDensity.FromKilogramPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerMeter, 1d, 1.0d).SetName("LinearDensity_ToBase_KilogramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.GramPerMeter, 1d, 0.001d).SetName("LinearDensity_ToBase_GramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.MilligramPerMeter, 1d, 9.9999999999999995e-07d).SetName("LinearDensity_ToBase_MilligramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerKilometer, 1d, 0.001d).SetName("LinearDensity_ToBase_KilogramPerKilometer");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerFoot, 1d, 1.4881639435695537d).SetName("LinearDensity_ToBase_PoundPerFoot");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerInch, 1d, 17.857967322834646d).SetName("LinearDensity_ToBase_PoundPerInch");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.Tex, 1d, 9.9999999999999995e-07d).SetName("LinearDensity_ToBase_Tex");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.Denier, 1d, 1.1111111111111111e-07d).SetName("LinearDensity_ToBase_Denier");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerCentimeter, 1d, 100.0d).SetName("LinearDensity_ToBase_KilogramPerCentimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerMillimeter, 1d, 1000.0d).SetName("LinearDensity_ToBase_KilogramPerMillimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.GramPerMillimeter, 1d, 1.0d).SetName("LinearDensity_ToBase_GramPerMillimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.OuncePerFoot, 1d, 0.093010246473097108d).SetName("LinearDensity_ToBase_OuncePerFoot");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.OuncePerInch, 1d, 1.1161229576771654d).SetName("LinearDensity_ToBase_OuncePerInch");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerYard, 1d, 0.49605464785651798d).SetName("LinearDensity_ToBase_PoundPerYard");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerMeter, 1d, 1.0d).SetName("LinearDensity_FromBase_KilogramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.GramPerMeter, 1d, 1000.0d).SetName("LinearDensity_FromBase_GramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.MilligramPerMeter, 1d, 1000000.0d).SetName("LinearDensity_FromBase_MilligramPerMeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerKilometer, 1d, 1000.0d).SetName("LinearDensity_FromBase_KilogramPerKilometer");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerFoot, 1d, 0.67196897513950693d).SetName("LinearDensity_FromBase_PoundPerFoot");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerInch, 1d, 0.055997414594958904d).SetName("LinearDensity_FromBase_PoundPerInch");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.Tex, 1d, 1000000.0d).SetName("LinearDensity_FromBase_Tex");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.Denier, 1d, 9000000.0d).SetName("LinearDensity_FromBase_Denier");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerCentimeter, 1d, 0.01d).SetName("LinearDensity_FromBase_KilogramPerCentimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.KilogramPerMillimeter, 1d, 0.001d).SetName("LinearDensity_FromBase_KilogramPerMillimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.GramPerMillimeter, 1d, 1.0d).SetName("LinearDensity_FromBase_GramPerMillimeter");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.OuncePerFoot, 1d, 10.751503602232111d).SetName("LinearDensity_FromBase_OuncePerFoot");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.OuncePerInch, 1d, 0.89595863351934246d).SetName("LinearDensity_FromBase_OuncePerInch");
            yield return new TestCaseData(UnitConverterLinearDensityUnit.PoundPerYard, 1d, 2.0159069254185202d).SetName("LinearDensity_FromBase_PoundPerYard");
        }
    }
}
