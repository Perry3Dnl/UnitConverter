namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Energy;

    public sealed class UnitToolsKnownValueEnergyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Energy_ToBaseUnit_ReturnsExpectedValue(UnitToolsEnergyUnit unit, double input, double expected)
        {
            double result = UnitToolsEnergy.ToJoule(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Energy_FromBaseUnit_ReturnsExpectedValue(UnitToolsEnergyUnit unit, double input, double expected)
        {
            double result = UnitToolsEnergy.FromJoule(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Energy_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsEnergyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsEnergy.ToJoule(input, unit);
            double result = UnitToolsEnergy.FromJoule(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsEnergyUnit.ElectronVolt, 1d, 1.6021766339999999e-19d).SetName("Energy_ToBase_ElectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.Joule, 1d, 1.0d).SetName("Energy_ToBase_Joule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Kilojoule, 1d, 1000.0d).SetName("Energy_ToBase_Kilojoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Megajoule, 1d, 1000000.0d).SetName("Energy_ToBase_Megajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.WattHour, 1d, 3600.0d).SetName("Energy_ToBase_WattHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.KilowattHour, 1d, 3600000.0d).SetName("Energy_ToBase_KilowattHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.Calorie, 1d, 4.1840000000000002d).SetName("Energy_ToBase_Calorie");
            yield return new TestCaseData(UnitToolsEnergyUnit.Kilocalorie, 1d, 4184.0d).SetName("Energy_ToBase_Kilocalorie");
            yield return new TestCaseData(UnitToolsEnergyUnit.BtuInternational, 1d, 1055.05585262d).SetName("Energy_ToBase_BtuInternational");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermUS, 1d, 105480400.0d).SetName("Energy_ToBase_ThermUS");
            yield return new TestCaseData(UnitToolsEnergyUnit.FootPound, 1d, 1.3558179483314003d).SetName("Energy_ToBase_FootPound");
            yield return new TestCaseData(UnitToolsEnergyUnit.Erg, 1d, 9.9999999999999995e-08d).SetName("Energy_ToBase_Erg");
            yield return new TestCaseData(UnitToolsEnergyUnit.TonTNT, 1d, 4184000000.0d).SetName("Energy_ToBase_TonTNT");
            yield return new TestCaseData(UnitToolsEnergyUnit.Nanojoule, 1d, 1.0000000000000001e-09d).SetName("Energy_ToBase_Nanojoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Microjoule, 1d, 9.9999999999999995e-07d).SetName("Energy_ToBase_Microjoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Millijoule, 1d, 0.001d).SetName("Energy_ToBase_Millijoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Gigajoule, 1d, 1000000000.0d).SetName("Energy_ToBase_Gigajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Terajoule, 1d, 1000000000000.0d).SetName("Energy_ToBase_Terajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.WattSecond, 1d, 1.0d).SetName("Energy_ToBase_WattSecond");
            yield return new TestCaseData(UnitToolsEnergyUnit.KiloelectronVolt, 1d, 1.6021766339999999e-16d).SetName("Energy_ToBase_KiloelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.MegaelectronVolt, 1d, 1.6021766340000001e-13d).SetName("Energy_ToBase_MegaelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.GigaelectronVolt, 1d, 1.6021766340000001e-10d).SetName("Energy_ToBase_GigaelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.TeraelectronVolt, 1d, 1.6021766339999999e-07d).SetName("Energy_ToBase_TeraelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.HorsepowerHour, 1d, 2684519.5376961725d).SetName("Energy_ToBase_HorsepowerHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.KilogramForceMeter, 1d, 9.8066499999999994d).SetName("Energy_ToBase_KilogramForceMeter");
            yield return new TestCaseData(UnitToolsEnergyUnit.Quad, 1d, 1.05505585262e+18d).SetName("Energy_ToBase_Quad");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermEC, 1d, 105506000.0d).SetName("Energy_ToBase_ThermEC");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermUK, 1d, 105505585.257348d).SetName("Energy_ToBase_ThermUK");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsEnergyUnit.ElectronVolt, 1d, 6.2415090744607631e+18d).SetName("Energy_FromBase_ElectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.Joule, 1d, 1.0d).SetName("Energy_FromBase_Joule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Kilojoule, 1d, 0.001d).SetName("Energy_FromBase_Kilojoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Megajoule, 1d, 9.9999999999999995e-07d).SetName("Energy_FromBase_Megajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.WattHour, 1d, 0.00027777777777777778d).SetName("Energy_FromBase_WattHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.KilowattHour, 1d, 2.7777777777777776e-07d).SetName("Energy_FromBase_KilowattHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.Calorie, 1d, 0.23900573613766729d).SetName("Energy_FromBase_Calorie");
            yield return new TestCaseData(UnitToolsEnergyUnit.Kilocalorie, 1d, 0.0002390057361376673d).SetName("Energy_FromBase_Kilocalorie");
            yield return new TestCaseData(UnitToolsEnergyUnit.BtuInternational, 1d, 0.00094781712031331725d).SetName("Energy_FromBase_BtuInternational");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermUS, 1d, 9.4804342797334867e-09d).SetName("Energy_FromBase_ThermUS");
            yield return new TestCaseData(UnitToolsEnergyUnit.FootPound, 1d, 0.73756214927726538d).SetName("Energy_FromBase_FootPound");
            yield return new TestCaseData(UnitToolsEnergyUnit.Erg, 1d, 10000000.0d).SetName("Energy_FromBase_Erg");
            yield return new TestCaseData(UnitToolsEnergyUnit.TonTNT, 1d, 2.3900573613766731e-10d).SetName("Energy_FromBase_TonTNT");
            yield return new TestCaseData(UnitToolsEnergyUnit.Nanojoule, 1d, 999999999.99999988d).SetName("Energy_FromBase_Nanojoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Microjoule, 1d, 1000000.0d).SetName("Energy_FromBase_Microjoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Millijoule, 1d, 1000.0d).SetName("Energy_FromBase_Millijoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Gigajoule, 1d, 1.0000000000000001e-09d).SetName("Energy_FromBase_Gigajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.Terajoule, 1d, 9.9999999999999998e-13d).SetName("Energy_FromBase_Terajoule");
            yield return new TestCaseData(UnitToolsEnergyUnit.WattSecond, 1d, 1.0d).SetName("Energy_FromBase_WattSecond");
            yield return new TestCaseData(UnitToolsEnergyUnit.KiloelectronVolt, 1d, 6241509074460763.0d).SetName("Energy_FromBase_KiloelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.MegaelectronVolt, 1d, 6241509074460.7627d).SetName("Energy_FromBase_MegaelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.GigaelectronVolt, 1d, 6241509074.460762d).SetName("Energy_FromBase_GigaelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.TeraelectronVolt, 1d, 6241509.0744607635d).SetName("Energy_FromBase_TeraelectronVolt");
            yield return new TestCaseData(UnitToolsEnergyUnit.HorsepowerHour, 1d, 3.7250613599861892e-07d).SetName("Energy_FromBase_HorsepowerHour");
            yield return new TestCaseData(UnitToolsEnergyUnit.KilogramForceMeter, 1d, 0.10197162129779283d).SetName("Energy_FromBase_KilogramForceMeter");
            yield return new TestCaseData(UnitToolsEnergyUnit.Quad, 1d, 9.4781712031331727e-19d).SetName("Energy_FromBase_Quad");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermEC, 1d, 9.4781339449889111e-09d).SetName("Energy_FromBase_ThermEC");
            yield return new TestCaseData(UnitToolsEnergyUnit.ThermUK, 1d, 9.4781712035510869e-09d).SetName("Energy_FromBase_ThermUK");
        }
    }
}
