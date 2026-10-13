namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ElectricalConductivity;

    public sealed class UnitToolsKnownValueElectricalConductivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalConductivity_ToBaseUnit_ReturnsExpectedValue(UnitToolsElectricalConductivityUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricalConductivity.ToSiemensPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricalConductivity_FromBaseUnit_ReturnsExpectedValue(UnitToolsElectricalConductivityUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricalConductivity.FromSiemensPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalConductivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsElectricalConductivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsElectricalConductivity.ToSiemensPerMeter(input, unit);
            double result = UnitToolsElectricalConductivity.FromSiemensPerMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerMeter, 1d, 1.0d).SetName("ElectricalConductivity_ToBase_SiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MillisiemensPerMeter, 1d, 0.001d).SetName("ElectricalConductivity_ToBase_MillisiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalConductivity_ToBase_MicrosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerCentimeter, 1d, 100.0d).SetName("ElectricalConductivity_ToBase_SiemensPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter, 1d, 0.10000000000000001d).SetName("ElectricalConductivity_ToBase_MillisiemensPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MegasiemensPerMeter, 1d, 1000000.0d).SetName("ElectricalConductivity_ToBase_MegasiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.NanosiemensPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricalConductivity_ToBase_NanosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.KilosiemensPerMeter, 1d, 1000.0d).SetName("ElectricalConductivity_ToBase_KilosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerMillimeter, 1d, 1000.0d).SetName("ElectricalConductivity_ToBase_SiemensPerMillimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter, 1d, 100000000000.0d).SetName("ElectricalConductivity_ToBase_AbmhoPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter, 1d, 1.11265e-10d).SetName("ElectricalConductivity_ToBase_StatmhoPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.PicosiemensPerMeter, 1d, 9.9999999999999998e-13d).SetName("ElectricalConductivity_ToBase_PicosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.GigasiemensPerMeter, 1d, 1000000000.0d).SetName("ElectricalConductivity_ToBase_GigasiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter, 1d, 0.001d).SetName("ElectricalConductivity_ToBase_MicrosiemensPerMillimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.StatmhoPerMeter, 1d, 1.1126500559999999e-12d).SetName("ElectricalConductivity_ToBase_StatmhoPerMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerMeter, 1d, 1.0d).SetName("ElectricalConductivity_FromBase_SiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MillisiemensPerMeter, 1d, 1000.0d).SetName("ElectricalConductivity_FromBase_MillisiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter, 1d, 1000000.0d).SetName("ElectricalConductivity_FromBase_MicrosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerCentimeter, 1d, 0.01d).SetName("ElectricalConductivity_FromBase_SiemensPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter, 1d, 10.0d).SetName("ElectricalConductivity_FromBase_MillisiemensPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MegasiemensPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalConductivity_FromBase_MegasiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.NanosiemensPerMeter, 1d, 999999999.99999988d).SetName("ElectricalConductivity_FromBase_NanosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.KilosiemensPerMeter, 1d, 0.001d).SetName("ElectricalConductivity_FromBase_KilosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.SiemensPerMillimeter, 1d, 0.001d).SetName("ElectricalConductivity_FromBase_SiemensPerMillimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter, 1d, 9.9999999999999994e-12d).SetName("ElectricalConductivity_FromBase_AbmhoPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter, 1d, 8987552240.1473961d).SetName("ElectricalConductivity_FromBase_StatmhoPerCentimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.PicosiemensPerMeter, 1d, 1000000000000.0d).SetName("ElectricalConductivity_FromBase_PicosiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.GigasiemensPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricalConductivity_FromBase_GigasiemensPerMeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter, 1d, 1000.0d).SetName("ElectricalConductivity_FromBase_MicrosiemensPerMillimeter");
            yield return new TestCaseData(UnitToolsElectricalConductivityUnit.StatmhoPerMeter, 1d, 898755178780.12854d).SetName("ElectricalConductivity_FromBase_StatmhoPerMeter");
        }
    }
}
