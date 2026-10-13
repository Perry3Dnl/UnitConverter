namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.SpecificGravity;

    public sealed class UnitToolsKnownValueSpecificGravityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificGravity_ToBaseUnit_ReturnsExpectedValue(UnitToolsSpecificGravityUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificGravity.ToRatio(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificGravity_FromBaseUnit_ReturnsExpectedValue(UnitToolsSpecificGravityUnit unit, double input, double expected)
        {
            double result = UnitToolsSpecificGravity.FromRatio(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificGravity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsSpecificGravityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsSpecificGravity.ToRatio(input, unit);
            double result = UnitToolsSpecificGravity.FromRatio(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ratio, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_Ratio");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.SpecificGravity, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_SpecificGravity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.RelativeDensity, 1.2d, 1.2d).SetName("SpecificGravity_ToBase_RelativeDensity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Percent, 125.0d, 1.25d).SetName("SpecificGravity_ToBase_Percent");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.PerMille, 1000.0d, 1.0d).SetName("SpecificGravity_ToBase_PerMille");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppm, 1000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppm");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppb, 1000000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppb");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppt, 1000000000000.0d, 1.0d).SetName("SpecificGravity_ToBase_Ppt");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BasisPoint, 10000.0d, 1.0d).SetName("SpecificGravity_ToBase_BasisPoint");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.PerTenThousand, 10000.0d, 1.0d).SetName("SpecificGravity_ToBase_PerTenThousand");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.APIGravity, 10.0d, 1.0d).SetName("SpecificGravity_ToBase_APIGravity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BaumeLight, 10.0d, 1.0d).SetName("SpecificGravity_ToBase_BaumeLight");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BaumeHeavy, 10.0d, 1.0740740740740742d).SetName("SpecificGravity_ToBase_BaumeHeavy");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Twaddell, 40.0d, 1.2d).SetName("SpecificGravity_ToBase_Twaddell");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ratio, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_Ratio");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.SpecificGravity, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_SpecificGravity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.RelativeDensity, 1.2d, 1.2d).SetName("SpecificGravity_FromBase_RelativeDensity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Percent, 1.2d, 120.0d).SetName("SpecificGravity_FromBase_Percent");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.PerMille, 1.2d, 1200.0d).SetName("SpecificGravity_FromBase_PerMille");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppm, 1.2d, 1200000.0d).SetName("SpecificGravity_FromBase_Ppm");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppb, 1.2d, 1200000000.0d).SetName("SpecificGravity_FromBase_Ppb");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Ppt, 1.2d, 1200000000000.0d).SetName("SpecificGravity_FromBase_Ppt");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BasisPoint, 1.2d, 11999.999999999998d).SetName("SpecificGravity_FromBase_BasisPoint");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.PerTenThousand, 1.2d, 11999.999999999998d).SetName("SpecificGravity_FromBase_PerTenThousand");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.APIGravity, 1.2d, -13.583333333333329d).SetName("SpecificGravity_FromBase_APIGravity");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BaumeLight, 1.2d, -13.333333333333329d).SetName("SpecificGravity_FromBase_BaumeLight");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.BaumeHeavy, 1.2d, 24.166666666666657d).SetName("SpecificGravity_FromBase_BaumeHeavy");
            yield return new TestCaseData(UnitToolsSpecificGravityUnit.Twaddell, 1.2d, 39.999999999999993d).SetName("SpecificGravity_FromBase_Twaddell");
        }
    }
}
