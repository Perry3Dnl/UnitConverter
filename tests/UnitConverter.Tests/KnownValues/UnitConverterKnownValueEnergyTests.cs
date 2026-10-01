namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Energy;

    public sealed class UnitConverterKnownValueEnergyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Energy_ToBaseUnit_ReturnsExpectedValue(UnitConverterEnergyUnit unit, double input, double expected)
        {
            double result = UnitConverterEnergy.ToJoule(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Energy_FromBaseUnit_ReturnsExpectedValue(UnitConverterEnergyUnit unit, double input, double expected)
        {
            double result = UnitConverterEnergy.FromJoule(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Energy_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterEnergyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterEnergy.ToJoule(input, unit);
            double result = UnitConverterEnergy.FromJoule(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterEnergyUnit.ElectronVolt, 1d, 1.6021766339999999e-19d).SetName("Energy_ToBase_ElectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.Joule, 1d, 1.0d).SetName("Energy_ToBase_Joule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Kilojoule, 1d, 1000.0d).SetName("Energy_ToBase_Kilojoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Megajoule, 1d, 1000000.0d).SetName("Energy_ToBase_Megajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.WattHour, 1d, 3600.0d).SetName("Energy_ToBase_WattHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.KilowattHour, 1d, 3600000.0d).SetName("Energy_ToBase_KilowattHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.Calorie, 1d, 4.1840000000000002d).SetName("Energy_ToBase_Calorie");
            yield return new TestCaseData(UnitConverterEnergyUnit.Kilocalorie, 1d, 4184.0d).SetName("Energy_ToBase_Kilocalorie");
            yield return new TestCaseData(UnitConverterEnergyUnit.BtuInternational, 1d, 1055.05585262d).SetName("Energy_ToBase_BtuInternational");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermUS, 1d, 105480400.0d).SetName("Energy_ToBase_ThermUS");
            yield return new TestCaseData(UnitConverterEnergyUnit.FootPound, 1d, 1.3558179483314003d).SetName("Energy_ToBase_FootPound");
            yield return new TestCaseData(UnitConverterEnergyUnit.Erg, 1d, 9.9999999999999995e-08d).SetName("Energy_ToBase_Erg");
            yield return new TestCaseData(UnitConverterEnergyUnit.TonTNT, 1d, 4184000000.0d).SetName("Energy_ToBase_TonTNT");
            yield return new TestCaseData(UnitConverterEnergyUnit.Nanojoule, 1d, 1.0000000000000001e-09d).SetName("Energy_ToBase_Nanojoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Microjoule, 1d, 9.9999999999999995e-07d).SetName("Energy_ToBase_Microjoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Millijoule, 1d, 0.001d).SetName("Energy_ToBase_Millijoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Gigajoule, 1d, 1000000000.0d).SetName("Energy_ToBase_Gigajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Terajoule, 1d, 1000000000000.0d).SetName("Energy_ToBase_Terajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.WattSecond, 1d, 1.0d).SetName("Energy_ToBase_WattSecond");
            yield return new TestCaseData(UnitConverterEnergyUnit.KiloelectronVolt, 1d, 1.6021766339999999e-16d).SetName("Energy_ToBase_KiloelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.MegaelectronVolt, 1d, 1.6021766340000001e-13d).SetName("Energy_ToBase_MegaelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.GigaelectronVolt, 1d, 1.6021766340000001e-10d).SetName("Energy_ToBase_GigaelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.TeraelectronVolt, 1d, 1.6021766339999999e-07d).SetName("Energy_ToBase_TeraelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.HorsepowerHour, 1d, 2684519.5376961725d).SetName("Energy_ToBase_HorsepowerHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.KilogramForceMeter, 1d, 9.8066499999999994d).SetName("Energy_ToBase_KilogramForceMeter");
            yield return new TestCaseData(UnitConverterEnergyUnit.Quad, 1d, 1.05505585262e+18d).SetName("Energy_ToBase_Quad");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermEC, 1d, 105506000.0d).SetName("Energy_ToBase_ThermEC");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermUK, 1d, 105505585.257348d).SetName("Energy_ToBase_ThermUK");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterEnergyUnit.ElectronVolt, 1d, 6.2415090744607631e+18d).SetName("Energy_FromBase_ElectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.Joule, 1d, 1.0d).SetName("Energy_FromBase_Joule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Kilojoule, 1d, 0.001d).SetName("Energy_FromBase_Kilojoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Megajoule, 1d, 9.9999999999999995e-07d).SetName("Energy_FromBase_Megajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.WattHour, 1d, 0.00027777777777777778d).SetName("Energy_FromBase_WattHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.KilowattHour, 1d, 2.7777777777777776e-07d).SetName("Energy_FromBase_KilowattHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.Calorie, 1d, 0.23900573613766729d).SetName("Energy_FromBase_Calorie");
            yield return new TestCaseData(UnitConverterEnergyUnit.Kilocalorie, 1d, 0.0002390057361376673d).SetName("Energy_FromBase_Kilocalorie");
            yield return new TestCaseData(UnitConverterEnergyUnit.BtuInternational, 1d, 0.00094781712031331725d).SetName("Energy_FromBase_BtuInternational");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermUS, 1d, 9.4804342797334867e-09d).SetName("Energy_FromBase_ThermUS");
            yield return new TestCaseData(UnitConverterEnergyUnit.FootPound, 1d, 0.73756214927726538d).SetName("Energy_FromBase_FootPound");
            yield return new TestCaseData(UnitConverterEnergyUnit.Erg, 1d, 10000000.0d).SetName("Energy_FromBase_Erg");
            yield return new TestCaseData(UnitConverterEnergyUnit.TonTNT, 1d, 2.3900573613766731e-10d).SetName("Energy_FromBase_TonTNT");
            yield return new TestCaseData(UnitConverterEnergyUnit.Nanojoule, 1d, 999999999.99999988d).SetName("Energy_FromBase_Nanojoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Microjoule, 1d, 1000000.0d).SetName("Energy_FromBase_Microjoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Millijoule, 1d, 1000.0d).SetName("Energy_FromBase_Millijoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Gigajoule, 1d, 1.0000000000000001e-09d).SetName("Energy_FromBase_Gigajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.Terajoule, 1d, 9.9999999999999998e-13d).SetName("Energy_FromBase_Terajoule");
            yield return new TestCaseData(UnitConverterEnergyUnit.WattSecond, 1d, 1.0d).SetName("Energy_FromBase_WattSecond");
            yield return new TestCaseData(UnitConverterEnergyUnit.KiloelectronVolt, 1d, 6241509074460763.0d).SetName("Energy_FromBase_KiloelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.MegaelectronVolt, 1d, 6241509074460.7627d).SetName("Energy_FromBase_MegaelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.GigaelectronVolt, 1d, 6241509074.460762d).SetName("Energy_FromBase_GigaelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.TeraelectronVolt, 1d, 6241509.0744607635d).SetName("Energy_FromBase_TeraelectronVolt");
            yield return new TestCaseData(UnitConverterEnergyUnit.HorsepowerHour, 1d, 3.7250613599861892e-07d).SetName("Energy_FromBase_HorsepowerHour");
            yield return new TestCaseData(UnitConverterEnergyUnit.KilogramForceMeter, 1d, 0.10197162129779283d).SetName("Energy_FromBase_KilogramForceMeter");
            yield return new TestCaseData(UnitConverterEnergyUnit.Quad, 1d, 9.4781712031331727e-19d).SetName("Energy_FromBase_Quad");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermEC, 1d, 9.4781339449889111e-09d).SetName("Energy_FromBase_ThermEC");
            yield return new TestCaseData(UnitConverterEnergyUnit.ThermUK, 1d, 9.4781712035510869e-09d).SetName("Energy_FromBase_ThermUK");
        }
    }
}
