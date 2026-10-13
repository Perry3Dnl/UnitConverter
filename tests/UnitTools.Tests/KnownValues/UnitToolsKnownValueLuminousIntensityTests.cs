namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.LuminousIntensity;

    public sealed class UnitToolsKnownValueLuminousIntensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousIntensity_ToBaseUnit_ReturnsExpectedValue(UnitToolsLuminousIntensityUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousIntensity.ToCandela(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousIntensity_FromBaseUnit_ReturnsExpectedValue(UnitToolsLuminousIntensityUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousIntensity.FromCandela(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousIntensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsLuminousIntensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsLuminousIntensity.ToCandela(input, unit);
            double result = UnitToolsLuminousIntensity.FromCandela(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Candela, 1d, 1.0d).SetName("LuminousIntensity_ToBase_Candela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Millicandela, 1d, 0.001d).SetName("LuminousIntensity_ToBase_Millicandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Kilocandela, 1d, 1000.0d).SetName("LuminousIntensity_ToBase_Kilocandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Candlepower, 1d, 1.0d).SetName("LuminousIntensity_ToBase_Candlepower");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Hefnerkerze, 1d, 0.90300000000000002d).SetName("LuminousIntensity_ToBase_Hefnerkerze");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Microcandela, 1d, 9.9999999999999995e-07d).SetName("LuminousIntensity_ToBase_Microcandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Nanocandela, 1d, 1.0000000000000001e-09d).SetName("LuminousIntensity_ToBase_Nanocandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Megacandela, 1d, 1000000.0d).SetName("LuminousIntensity_ToBase_Megacandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.SphericalCandlepower, 1d, 1.0d).SetName("LuminousIntensity_ToBase_SphericalCandlepower");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Violle, 1d, 20.170000000000002d).SetName("LuminousIntensity_ToBase_Violle");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Candela, 1d, 1.0d).SetName("LuminousIntensity_FromBase_Candela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Millicandela, 1d, 1000.0d).SetName("LuminousIntensity_FromBase_Millicandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Kilocandela, 1d, 0.001d).SetName("LuminousIntensity_FromBase_Kilocandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Candlepower, 1d, 1.0d).SetName("LuminousIntensity_FromBase_Candlepower");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Hefnerkerze, 1d, 1.1074197120708749d).SetName("LuminousIntensity_FromBase_Hefnerkerze");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Microcandela, 1d, 1000000.0d).SetName("LuminousIntensity_FromBase_Microcandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Nanocandela, 1d, 999999999.99999988d).SetName("LuminousIntensity_FromBase_Nanocandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Megacandela, 1d, 9.9999999999999995e-07d).SetName("LuminousIntensity_FromBase_Megacandela");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.SphericalCandlepower, 1d, 1.0d).SetName("LuminousIntensity_FromBase_SphericalCandlepower");
            yield return new TestCaseData(UnitToolsLuminousIntensityUnit.Violle, 1d, 0.049578582052553291d).SetName("LuminousIntensity_FromBase_Violle");
        }
    }
}
