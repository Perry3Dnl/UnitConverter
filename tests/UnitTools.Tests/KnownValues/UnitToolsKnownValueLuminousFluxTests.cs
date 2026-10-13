namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.LuminousFlux;

    public sealed class UnitToolsKnownValueLuminousFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousFlux_ToBaseUnit_ReturnsExpectedValue(UnitToolsLuminousFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousFlux.ToLumen(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousFlux_FromBaseUnit_ReturnsExpectedValue(UnitToolsLuminousFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminousFlux.FromLumen(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsLuminousFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsLuminousFlux.ToLumen(input, unit);
            double result = UnitToolsLuminousFlux.FromLumen(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Lumen, 1d, 1.0d).SetName("LuminousFlux_ToBase_Lumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Millilumen, 1d, 0.001d).SetName("LuminousFlux_ToBase_Millilumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Kilolumen, 1d, 1000.0d).SetName("LuminousFlux_ToBase_Kilolumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Megalumen, 1d, 1000000.0d).SetName("LuminousFlux_ToBase_Megalumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.CandelaSteradian, 1d, 1.0d).SetName("LuminousFlux_ToBase_CandelaSteradian");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Microlumen, 1d, 9.9999999999999995e-07d).SetName("LuminousFlux_ToBase_Microlumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Nanolumen, 1d, 1.0000000000000001e-09d).SetName("LuminousFlux_ToBase_Nanolumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian, 1d, 1.0d).SetName("LuminousFlux_ToBase_LumenPerSteradianSteradian");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.TalbotPerSecond, 1d, 1.0d).SetName("LuminousFlux_ToBase_TalbotPerSecond");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Gigalumen, 1d, 1000000000.0d).SetName("LuminousFlux_ToBase_Gigalumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias, 1d, 60.0d).SetName("LuminousFlux_ToBase_LumenMinutePerSecondAlias");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias, 1d, 3600.0d).SetName("LuminousFlux_ToBase_LumenHourPerSecondAlias");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Lumen, 1d, 1.0d).SetName("LuminousFlux_FromBase_Lumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Millilumen, 1d, 1000.0d).SetName("LuminousFlux_FromBase_Millilumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Kilolumen, 1d, 0.001d).SetName("LuminousFlux_FromBase_Kilolumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Megalumen, 1d, 9.9999999999999995e-07d).SetName("LuminousFlux_FromBase_Megalumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.CandelaSteradian, 1d, 1.0d).SetName("LuminousFlux_FromBase_CandelaSteradian");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Microlumen, 1d, 1000000.0d).SetName("LuminousFlux_FromBase_Microlumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Nanolumen, 1d, 999999999.99999988d).SetName("LuminousFlux_FromBase_Nanolumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian, 1d, 1.0d).SetName("LuminousFlux_FromBase_LumenPerSteradianSteradian");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.TalbotPerSecond, 1d, 1.0d).SetName("LuminousFlux_FromBase_TalbotPerSecond");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.Gigalumen, 1d, 1.0000000000000001e-09d).SetName("LuminousFlux_FromBase_Gigalumen");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias, 1d, 0.016666666666666666d).SetName("LuminousFlux_FromBase_LumenMinutePerSecondAlias");
            yield return new TestCaseData(UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias, 1d, 0.00027777777777777778d).SetName("LuminousFlux_FromBase_LumenHourPerSecondAlias");
        }
    }
}
