namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.LuminousEfficacy;

    public sealed class UnitToolsKnownValueLuminousEfficacyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousEfficacy_ToBaseUnit_ReturnsExpectedValue(UnitToolsLuminousEfficacyUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousEfficacy.ToLumenPerWatt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousEfficacy_FromBaseUnit_ReturnsExpectedValue(UnitToolsLuminousEfficacyUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousEfficacy.FromLumenPerWatt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousEfficacy_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsLuminousEfficacyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsLuminousEfficacy.ToLumenPerWatt(input, unit);
            double result = UnitToolsLuminousEfficacy.FromLumenPerWatt(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerWatt, 1d, 1.0d).SetName("LuminousEfficacy_ToBase_LumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerKilowatt, 1d, 0.001d).SetName("LuminousEfficacy_ToBase_LumenPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.KilolumenPerWatt, 1d, 1000.0d).SetName("LuminousEfficacy_ToBase_KilolumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt, 1d, 1.0d).SetName("LuminousEfficacy_ToBase_CandelaSteradianPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt, 1d, 1000.0d).SetName("LuminousEfficacy_ToBase_LumenPerMilliwatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMegawatt, 1d, 9.9999999999999995e-07d).SetName("LuminousEfficacy_ToBase_LumenPerMegawatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt, 1d, 1.0d).SetName("LuminousEfficacy_ToBase_KilolumenPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt, 1d, 0.001d).SetName("LuminousEfficacy_ToBase_CandelaSteradianPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.PhotopicMaximum, 1d, 683.0d).SetName("LuminousEfficacy_ToBase_PhotopicMaximum");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt, 1d, 1000000.0d).SetName("LuminousEfficacy_ToBase_LumenPerMicrowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerNanowatt, 1d, 1000000000.0d).SetName("LuminousEfficacy_ToBase_LumenPerNanowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.MegalumenPerWatt, 1d, 1000000.0d).SetName("LuminousEfficacy_ToBase_MegalumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox, 1d, 1700.0d).SetName("LuminousEfficacy_ToBase_PhotopicScotopicRatioApprox");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerWatt, 1d, 1.0d).SetName("LuminousEfficacy_FromBase_LumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerKilowatt, 1d, 1000.0d).SetName("LuminousEfficacy_FromBase_LumenPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.KilolumenPerWatt, 1d, 0.001d).SetName("LuminousEfficacy_FromBase_KilolumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt, 1d, 1.0d).SetName("LuminousEfficacy_FromBase_CandelaSteradianPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt, 1d, 0.001d).SetName("LuminousEfficacy_FromBase_LumenPerMilliwatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMegawatt, 1d, 1000000.0d).SetName("LuminousEfficacy_FromBase_LumenPerMegawatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt, 1d, 1.0d).SetName("LuminousEfficacy_FromBase_KilolumenPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt, 1d, 1000.0d).SetName("LuminousEfficacy_FromBase_CandelaSteradianPerKilowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.PhotopicMaximum, 1d, 0.0014641288433382138d).SetName("LuminousEfficacy_FromBase_PhotopicMaximum");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt, 1d, 9.9999999999999995e-07d).SetName("LuminousEfficacy_FromBase_LumenPerMicrowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.LumenPerNanowatt, 1d, 1.0000000000000001e-09d).SetName("LuminousEfficacy_FromBase_LumenPerNanowatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.MegalumenPerWatt, 1d, 9.9999999999999995e-07d).SetName("LuminousEfficacy_FromBase_MegalumenPerWatt");
            yield return new TestCaseData(UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox, 1d, 0.00058823529411764701d).SetName("LuminousEfficacy_FromBase_PhotopicScotopicRatioApprox");
        }
    }
}
