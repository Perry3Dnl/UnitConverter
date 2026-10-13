namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MagneticPermeability;

    public sealed class UnitToolsKnownValueMagneticPermeabilityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticPermeability_ToBaseUnit_ReturnsExpectedValue(UnitToolsMagneticPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticPermeability.ToHenryPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagneticPermeability_FromBaseUnit_ReturnsExpectedValue(UnitToolsMagneticPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticPermeability.FromHenryPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticPermeability_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMagneticPermeabilityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMagneticPermeability.ToHenryPerMeter(input, unit);
            double result = UnitToolsMagneticPermeability.FromHenryPerMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerMeter, 1d, 1.0d).SetName("MagneticPermeability_ToBase_HenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter, 1d, 0.001d).SetName("MagneticPermeability_ToBase_MillihenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter, 1d, 9.9999999999999995e-07d).SetName("MagneticPermeability_ToBase_MicrohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter, 1d, 1.0000000000000001e-09d).SetName("MagneticPermeability_ToBase_NanohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.VacuumPermeability, 1d, 1.2566370621199999e-06d).SetName("MagneticPermeability_ToBase_VacuumPermeability");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter, 1d, 9.9999999999999998e-13d).SetName("MagneticPermeability_ToBase_PicohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter, 1d, 1000.0d).SetName("MagneticPermeability_ToBase_HenryPerMillimeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerInch, 1d, 39.370078740157481d).SetName("MagneticPermeability_ToBase_HenryPerInch");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.RelativePermeability, 1d, 1.2566370621199999e-06d).SetName("MagneticPermeability_ToBase_RelativePermeability");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.GaussPerOersted, 1d, 1.2566370621199999e-06d).SetName("MagneticPermeability_ToBase_GaussPerOersted");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerMeter, 1d, 1.0d).SetName("MagneticPermeability_FromBase_HenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter, 1d, 1000.0d).SetName("MagneticPermeability_FromBase_MillihenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter, 1d, 1000000.0d).SetName("MagneticPermeability_FromBase_MicrohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter, 1d, 999999999.99999988d).SetName("MagneticPermeability_FromBase_NanohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.VacuumPermeability, 1d, 795774.7150262763d).SetName("MagneticPermeability_FromBase_VacuumPermeability");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter, 1d, 1000000000000.0d).SetName("MagneticPermeability_FromBase_PicohenryPerMeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter, 1d, 0.001d).SetName("MagneticPermeability_FromBase_HenryPerMillimeter");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.HenryPerInch, 1d, 0.025399999999999999d).SetName("MagneticPermeability_FromBase_HenryPerInch");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.RelativePermeability, 1d, 795774.7150262763d).SetName("MagneticPermeability_FromBase_RelativePermeability");
            yield return new TestCaseData(UnitToolsMagneticPermeabilityUnit.GaussPerOersted, 1d, 795774.7150262763d).SetName("MagneticPermeability_FromBase_GaussPerOersted");
        }
    }
}
