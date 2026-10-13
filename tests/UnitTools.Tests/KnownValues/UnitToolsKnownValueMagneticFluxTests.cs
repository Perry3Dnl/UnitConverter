namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MagneticFlux;

    public sealed class UnitToolsKnownValueMagneticFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticFlux_ToBaseUnit_ReturnsExpectedValue(UnitToolsMagneticFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticFlux.ToWeber(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagneticFlux_FromBaseUnit_ReturnsExpectedValue(UnitToolsMagneticFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticFlux.FromWeber(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMagneticFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMagneticFlux.ToWeber(input, unit);
            double result = UnitToolsMagneticFlux.FromWeber(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Nanoweber, 1d, 1.0000000000000001e-09d).SetName("MagneticFlux_ToBase_Nanoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Microweber, 1d, 9.9999999999999995e-07d).SetName("MagneticFlux_ToBase_Microweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Milliweber, 1d, 0.001d).SetName("MagneticFlux_ToBase_Milliweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Weber, 1d, 1.0d).SetName("MagneticFlux_ToBase_Weber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Maxwell, 1d, 1e-08d).SetName("MagneticFlux_ToBase_Maxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Picoweber, 1d, 9.9999999999999998e-13d).SetName("MagneticFlux_ToBase_Picoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Femtoweber, 1d, 1.0000000000000001e-15d).SetName("MagneticFlux_ToBase_Femtoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Kiloweber, 1d, 1000.0d).SetName("MagneticFlux_ToBase_Kiloweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Megaweber, 1d, 1000000.0d).SetName("MagneticFlux_ToBase_Megaweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.UnitPole, 1d, 1.2566370614359172e-07d).SetName("MagneticFlux_ToBase_UnitPole");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Attoweber, 1d, 1.0000000000000001e-18d).SetName("MagneticFlux_ToBase_Attoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Kilomaxwell, 1d, 1.0000000000000001e-05d).SetName("MagneticFlux_ToBase_Kilomaxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Megamaxwell, 1d, 0.01d).SetName("MagneticFlux_ToBase_Megamaxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Line, 1d, 1e-08d).SetName("MagneticFlux_ToBase_Line");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.VoltSecond, 1d, 1.0d).SetName("MagneticFlux_ToBase_VoltSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Nanoweber, 1d, 999999999.99999988d).SetName("MagneticFlux_FromBase_Nanoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Microweber, 1d, 1000000.0d).SetName("MagneticFlux_FromBase_Microweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Milliweber, 1d, 1000.0d).SetName("MagneticFlux_FromBase_Milliweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Weber, 1d, 1.0d).SetName("MagneticFlux_FromBase_Weber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Maxwell, 1d, 100000000.0d).SetName("MagneticFlux_FromBase_Maxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Picoweber, 1d, 1000000000000.0d).SetName("MagneticFlux_FromBase_Picoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Femtoweber, 1d, 999999999999999.88d).SetName("MagneticFlux_FromBase_Femtoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Kiloweber, 1d, 0.001d).SetName("MagneticFlux_FromBase_Kiloweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Megaweber, 1d, 9.9999999999999995e-07d).SetName("MagneticFlux_FromBase_Megaweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.UnitPole, 1d, 7957747.1545947669d).SetName("MagneticFlux_FromBase_UnitPole");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Attoweber, 1d, 9.9999999999999987e+17d).SetName("MagneticFlux_FromBase_Attoweber");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Kilomaxwell, 1d, 99999.999999999985d).SetName("MagneticFlux_FromBase_Kilomaxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Megamaxwell, 1d, 100.0d).SetName("MagneticFlux_FromBase_Megamaxwell");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.Line, 1d, 100000000.0d).SetName("MagneticFlux_FromBase_Line");
            yield return new TestCaseData(UnitToolsMagneticFluxUnit.VoltSecond, 1d, 1.0d).SetName("MagneticFlux_FromBase_VoltSecond");
        }
    }
}
