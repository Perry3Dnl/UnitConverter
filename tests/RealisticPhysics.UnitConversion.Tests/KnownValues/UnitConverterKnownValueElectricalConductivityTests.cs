namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.ElectricalConductivity;

    public sealed class UnitConverterKnownValueElectricalConductivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalConductivity_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricalConductivityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricalConductivity.ToSiemensPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricalConductivity_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricalConductivityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricalConductivity.FromSiemensPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalConductivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricalConductivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricalConductivity.ToSiemensPerMeter(input, unit);
            double result = UnitConverterElectricalConductivity.FromSiemensPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerMeter, 1d, 1.0d).SetName("ElectricalConductivity_ToBase_SiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MillisiemensPerMeter, 1d, 0.001d).SetName("ElectricalConductivity_ToBase_MillisiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalConductivity_ToBase_MicrosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerCentimeter, 1d, 100.0d).SetName("ElectricalConductivity_ToBase_SiemensPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter, 1d, 0.10000000000000001d).SetName("ElectricalConductivity_ToBase_MillisiemensPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MegasiemensPerMeter, 1d, 1000000.0d).SetName("ElectricalConductivity_ToBase_MegasiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.NanosiemensPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricalConductivity_ToBase_NanosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.KilosiemensPerMeter, 1d, 1000.0d).SetName("ElectricalConductivity_ToBase_KilosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerMillimeter, 1d, 1000.0d).SetName("ElectricalConductivity_ToBase_SiemensPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter, 1d, 100000000000.0d).SetName("ElectricalConductivity_ToBase_AbmhoPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter, 1d, 1.11265e-10d).SetName("ElectricalConductivity_ToBase_StatmhoPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.PicosiemensPerMeter, 1d, 9.9999999999999998e-13d).SetName("ElectricalConductivity_ToBase_PicosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.GigasiemensPerMeter, 1d, 1000000000.0d).SetName("ElectricalConductivity_ToBase_GigasiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter, 1d, 0.001d).SetName("ElectricalConductivity_ToBase_MicrosiemensPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.StatmhoPerMeter, 1d, 1.1126500559999999e-12d).SetName("ElectricalConductivity_ToBase_StatmhoPerMeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerMeter, 1d, 1.0d).SetName("ElectricalConductivity_FromBase_SiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MillisiemensPerMeter, 1d, 1000.0d).SetName("ElectricalConductivity_FromBase_MillisiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter, 1d, 1000000.0d).SetName("ElectricalConductivity_FromBase_MicrosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerCentimeter, 1d, 0.01d).SetName("ElectricalConductivity_FromBase_SiemensPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter, 1d, 10.0d).SetName("ElectricalConductivity_FromBase_MillisiemensPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MegasiemensPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalConductivity_FromBase_MegasiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.NanosiemensPerMeter, 1d, 999999999.99999988d).SetName("ElectricalConductivity_FromBase_NanosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.KilosiemensPerMeter, 1d, 0.001d).SetName("ElectricalConductivity_FromBase_KilosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.SiemensPerMillimeter, 1d, 0.001d).SetName("ElectricalConductivity_FromBase_SiemensPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter, 1d, 9.9999999999999994e-12d).SetName("ElectricalConductivity_FromBase_AbmhoPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter, 1d, 8987552240.1473961d).SetName("ElectricalConductivity_FromBase_StatmhoPerCentimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.PicosiemensPerMeter, 1d, 1000000000000.0d).SetName("ElectricalConductivity_FromBase_PicosiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.GigasiemensPerMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricalConductivity_FromBase_GigasiemensPerMeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter, 1d, 1000.0d).SetName("ElectricalConductivity_FromBase_MicrosiemensPerMillimeter");
            yield return new TestCaseData(UnitConverterElectricalConductivityUnit.StatmhoPerMeter, 1d, 898755178780.12854d).SetName("ElectricalConductivity_FromBase_StatmhoPerMeter");
        }
    }
}
