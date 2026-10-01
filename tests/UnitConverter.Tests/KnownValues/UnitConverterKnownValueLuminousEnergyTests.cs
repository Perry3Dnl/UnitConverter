namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.LuminousEnergy;

    public sealed class UnitConverterKnownValueLuminousEnergyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousEnergy_ToBaseUnit_ReturnsExpectedValue(UnitConverterLuminousEnergyUnit unit, double input, double expected)
        {
            double result = UnitConverterLuminousEnergy.ToLumenSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void LuminousEnergy_FromBaseUnit_ReturnsExpectedValue(UnitConverterLuminousEnergyUnit unit, double input, double expected)
        {
            double result = UnitConverterLuminousEnergy.FromLumenSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void LuminousEnergy_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterLuminousEnergyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterLuminousEnergy.ToLumenSecond(input, unit);
            double result = UnitConverterLuminousEnergy.FromLumenSecond(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenSecond, 1d, 1.0d).SetName("LuminousEnergy_ToBase_LumenSecond");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenMinute, 1d, 60.0d).SetName("LuminousEnergy_ToBase_LumenMinute");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenHour, 1d, 3600.0d).SetName("LuminousEnergy_ToBase_LumenHour");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.Talbot, 1d, 1.0d).SetName("LuminousEnergy_ToBase_Talbot");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.Lumerg, 1d, 9.9999999999999995e-08d).SetName("LuminousEnergy_ToBase_Lumerg");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenDay, 1d, 86400.0d).SetName("LuminousEnergy_ToBase_LumenDay");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.KilolumenHour, 1d, 3600000.0d).SetName("LuminousEnergy_ToBase_KilolumenHour");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.MegalumenSecond, 1d, 1000000.0d).SetName("LuminousEnergy_ToBase_MegalumenSecond");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenWeek, 1d, 604800.0d).SetName("LuminousEnergy_ToBase_LumenWeek");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenYear, 1d, 31557600.0d).SetName("LuminousEnergy_ToBase_LumenYear");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenSecond, 1d, 1.0d).SetName("LuminousEnergy_FromBase_LumenSecond");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenMinute, 1d, 0.016666666666666666d).SetName("LuminousEnergy_FromBase_LumenMinute");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenHour, 1d, 0.00027777777777777778d).SetName("LuminousEnergy_FromBase_LumenHour");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.Talbot, 1d, 1.0d).SetName("LuminousEnergy_FromBase_Talbot");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.Lumerg, 1d, 10000000.0d).SetName("LuminousEnergy_FromBase_Lumerg");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenDay, 1d, 1.1574074074074073e-05d).SetName("LuminousEnergy_FromBase_LumenDay");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.KilolumenHour, 1d, 2.7777777777777776e-07d).SetName("LuminousEnergy_FromBase_KilolumenHour");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.MegalumenSecond, 1d, 9.9999999999999995e-07d).SetName("LuminousEnergy_FromBase_MegalumenSecond");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenWeek, 1d, 1.6534391534391535e-06d).SetName("LuminousEnergy_FromBase_LumenWeek");
            yield return new TestCaseData(UnitConverterLuminousEnergyUnit.LumenYear, 1d, 3.1688087814028947e-08d).SetName("LuminousEnergy_FromBase_LumenYear");
        }
    }
}
