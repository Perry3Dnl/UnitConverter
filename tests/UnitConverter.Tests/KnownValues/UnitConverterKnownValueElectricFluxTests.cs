namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.ElectricFlux;

    public sealed class UnitConverterKnownValueElectricFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFlux_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFlux.ToVoltMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricFlux_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFlux.FromVoltMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricFlux.ToVoltMeter(input, unit);
            double result = UnitConverterElectricFlux.FromVoltMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltMeter, 1d, 1.0d).SetName("ElectricFlux_ToBase_VoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.KilovoltMeter, 1d, 1000.0d).SetName("ElectricFlux_ToBase_KilovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltCentimeter, 1d, 0.01d).SetName("ElectricFlux_ToBase_VoltCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.StatvoltCentimeter, 1d, 2.9979245799999998d).SetName("ElectricFlux_ToBase_StatvoltCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MillivoltMeter, 1d, 0.001d).SetName("ElectricFlux_ToBase_MillivoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MicrovoltMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFlux_ToBase_MicrovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltMillimeter, 1d, 0.001d).SetName("ElectricFlux_ToBase_VoltMillimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltInch, 1d, 0.025399999999999999d).SetName("ElectricFlux_ToBase_VoltInch");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltFoot, 1d, 0.30480000000000002d).SetName("ElectricFlux_ToBase_VoltFoot");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.NanovoltMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricFlux_ToBase_NanovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.PicovoltMeter, 1d, 9.9999999999999998e-13d).SetName("ElectricFlux_ToBase_PicovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MegavoltMeter, 1d, 1000000.0d).SetName("ElectricFlux_ToBase_MegavoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.GigavoltMeter, 1d, 1000000000.0d).SetName("ElectricFlux_ToBase_GigavoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltKilometer, 1d, 1000.0d).SetName("ElectricFlux_ToBase_VoltKilometer");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.StatvoltMeter, 1d, 299.79245800000001d).SetName("ElectricFlux_ToBase_StatvoltMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltMeter, 1d, 1.0d).SetName("ElectricFlux_FromBase_VoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.KilovoltMeter, 1d, 0.001d).SetName("ElectricFlux_FromBase_KilovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltCentimeter, 1d, 100.0d).SetName("ElectricFlux_FromBase_VoltCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.StatvoltCentimeter, 1d, 0.33356409519815206d).SetName("ElectricFlux_FromBase_StatvoltCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MillivoltMeter, 1d, 1000.0d).SetName("ElectricFlux_FromBase_MillivoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MicrovoltMeter, 1d, 1000000.0d).SetName("ElectricFlux_FromBase_MicrovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltMillimeter, 1d, 1000.0d).SetName("ElectricFlux_FromBase_VoltMillimeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltInch, 1d, 39.370078740157481d).SetName("ElectricFlux_FromBase_VoltInch");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltFoot, 1d, 3.280839895013123d).SetName("ElectricFlux_FromBase_VoltFoot");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.NanovoltMeter, 1d, 999999999.99999988d).SetName("ElectricFlux_FromBase_NanovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.PicovoltMeter, 1d, 1000000000000.0d).SetName("ElectricFlux_FromBase_PicovoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.MegavoltMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFlux_FromBase_MegavoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.GigavoltMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricFlux_FromBase_GigavoltMeter");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.VoltKilometer, 1d, 0.001d).SetName("ElectricFlux_FromBase_VoltKilometer");
            yield return new TestCaseData(UnitConverterElectricFluxUnit.StatvoltMeter, 1d, 0.0033356409519815205d).SetName("ElectricFlux_FromBase_StatvoltMeter");
        }
    }
}
