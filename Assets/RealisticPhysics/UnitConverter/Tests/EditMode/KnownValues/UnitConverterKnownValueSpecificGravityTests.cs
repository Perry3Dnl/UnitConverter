namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.SpecificGravity;

    public sealed class UnitConverterKnownValueSpecificGravityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificGravity_ToBaseUnit_ReturnsExpectedValue(UnitConverterSpecificGravityUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificGravity.ToRatio(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificGravity_FromBaseUnit_ReturnsExpectedValue(UnitConverterSpecificGravityUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificGravity.FromRatio(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificGravity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSpecificGravityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSpecificGravity.ToRatio(input, unit);
            double result = UnitConverterSpecificGravity.FromRatio(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ratio, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_Ratio");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.SpecificGravity, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_SpecificGravity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.RelativeDensity, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_RelativeDensity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Percent, 125.0d, 1.25d).SetName("SpecificGravity_ToBase_Percent");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.PerMille, 1000.0d, 1.0d).SetName("SpecificGravity_ToBase_PerMille");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppm, 1000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppm");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppb, 1000000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppb");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppt, 1000000000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppt");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BasisPoint, 10000.0d, 1.0d).SetName("SpecificGravity_ToBase_BasisPoint");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.PerTenThousand, 10000.0d, 1.0d).SetName("SpecificGravity_ToBase_PerTenThousand");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.APIGravity, 10.0d, 1.0d).SetName("SpecificGravity_ToBase_APIGravity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BaumeLight, 10.0d, 1.0d).SetName("SpecificGravity_ToBase_BaumeLight");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BaumeHeavy, 10.0d, 1.0740740740740742d).SetName("SpecificGravity_ToBase_BaumeHeavy");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Twaddell, 40.0d, 1.2d).SetName("SpecificGravity_ToBase_Twaddell");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ratio, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_Ratio");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.SpecificGravity, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_SpecificGravity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.RelativeDensity, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_RelativeDensity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Percent, 1.2d, 120.0d).SetName("SpecificGravity_FromBase_Percent");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.PerMille, 1.2d, 1200.0d).SetName("SpecificGravity_FromBase_PerMille");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppm, 1.2d, 1200000.0d).SetName("SpecificGravity_FromBase_Ppm");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppb, 1.2d, 1200000000.0d).SetName("SpecificGravity_FromBase_Ppb");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Ppt, 1.2d, 1200000000000.0d).SetName("SpecificGravity_FromBase_Ppt");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BasisPoint, 1.2d, 11999.999999999998d).SetName("SpecificGravity_FromBase_BasisPoint");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.PerTenThousand, 1.2d, 11999.999999999998d).SetName("SpecificGravity_FromBase_PerTenThousand");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.APIGravity, 1.2d, -13.583333333333329d).SetName("SpecificGravity_FromBase_APIGravity");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BaumeLight, 1.2d, -13.333333333333329d).SetName("SpecificGravity_FromBase_BaumeLight");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.BaumeHeavy, 1.2d, 24.166666666666657d).SetName("SpecificGravity_FromBase_BaumeHeavy");
            yield return new TestCaseData(UnitConverterSpecificGravityUnit.Twaddell, 1.2d, 39.999999999999993d).SetName("SpecificGravity_FromBase_Twaddell");
        }
    }
}
