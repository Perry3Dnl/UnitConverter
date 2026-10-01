namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.LuminousFlux;

    public sealed class UnitConverterKnownValueLuminousFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousFlux_ToBaseUnit_ReturnsExpectedValue(UnitConverterLuminousFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterLuminousFlux.ToLumen(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousFlux_FromBaseUnit_ReturnsExpectedValue(UnitConverterLuminousFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterLuminousFlux.FromLumen(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterLuminousFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterLuminousFlux.ToLumen(input, unit);
            double result = UnitConverterLuminousFlux.FromLumen(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Lumen, 1d, 1.0d).SetName("LuminousFlux_ToBase_Lumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Millilumen, 1d, 0.001d).SetName("LuminousFlux_ToBase_Millilumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Kilolumen, 1d, 1000.0d).SetName("LuminousFlux_ToBase_Kilolumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Megalumen, 1d, 1000000.0d).SetName("LuminousFlux_ToBase_Megalumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.CandelaSteradian, 1d, 1.0d).SetName("LuminousFlux_ToBase_CandelaSteradian");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Microlumen, 1d, 9.9999999999999995e-07d).SetName("LuminousFlux_ToBase_Microlumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Nanolumen, 1d, 1.0000000000000001e-09d).SetName("LuminousFlux_ToBase_Nanolumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian, 1d, 1.0d).SetName("LuminousFlux_ToBase_LumenPerSteradianSteradian");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.TalbotPerSecond, 1d, 1.0d).SetName("LuminousFlux_ToBase_TalbotPerSecond");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Gigalumen, 1d, 1000000000.0d).SetName("LuminousFlux_ToBase_Gigalumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias, 1d, 60.0d).SetName("LuminousFlux_ToBase_LumenMinutePerSecondAlias");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias, 1d, 3600.0d).SetName("LuminousFlux_ToBase_LumenHourPerSecondAlias");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Lumen, 1d, 1.0d).SetName("LuminousFlux_FromBase_Lumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Millilumen, 1d, 1000.0d).SetName("LuminousFlux_FromBase_Millilumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Kilolumen, 1d, 0.001d).SetName("LuminousFlux_FromBase_Kilolumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Megalumen, 1d, 9.9999999999999995e-07d).SetName("LuminousFlux_FromBase_Megalumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.CandelaSteradian, 1d, 1.0d).SetName("LuminousFlux_FromBase_CandelaSteradian");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Microlumen, 1d, 1000000.0d).SetName("LuminousFlux_FromBase_Microlumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Nanolumen, 1d, 999999999.99999988d).SetName("LuminousFlux_FromBase_Nanolumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian, 1d, 1.0d).SetName("LuminousFlux_FromBase_LumenPerSteradianSteradian");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.TalbotPerSecond, 1d, 1.0d).SetName("LuminousFlux_FromBase_TalbotPerSecond");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.Gigalumen, 1d, 1.0000000000000001e-09d).SetName("LuminousFlux_FromBase_Gigalumen");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias, 1d, 0.016666666666666666d).SetName("LuminousFlux_FromBase_LumenMinutePerSecondAlias");
            yield return new TestCaseData(UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias, 1d, 0.00027777777777777778d).SetName("LuminousFlux_FromBase_LumenHourPerSecondAlias");
        }
    }
}
