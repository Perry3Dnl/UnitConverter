namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.MagneticFlux;

    public sealed class UnitConverterKnownValueMagneticFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticFlux_ToBaseUnit_ReturnsExpectedValue(UnitConverterMagneticFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterMagneticFlux.ToWeber(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagneticFlux_FromBaseUnit_ReturnsExpectedValue(UnitConverterMagneticFluxUnit unit, double input, double expected)
        {
            double result = UnitConverterMagneticFlux.FromWeber(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMagneticFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMagneticFlux.ToWeber(input, unit);
            double result = UnitConverterMagneticFlux.FromWeber(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Nanoweber, 1d, 1.0000000000000001e-09d).SetName("MagneticFlux_ToBase_Nanoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Microweber, 1d, 9.9999999999999995e-07d).SetName("MagneticFlux_ToBase_Microweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Milliweber, 1d, 0.001d).SetName("MagneticFlux_ToBase_Milliweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Weber, 1d, 1.0d).SetName("MagneticFlux_ToBase_Weber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Maxwell, 1d, 1e-08d).SetName("MagneticFlux_ToBase_Maxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Picoweber, 1d, 9.9999999999999998e-13d).SetName("MagneticFlux_ToBase_Picoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Femtoweber, 1d, 1.0000000000000001e-15d).SetName("MagneticFlux_ToBase_Femtoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Kiloweber, 1d, 1000.0d).SetName("MagneticFlux_ToBase_Kiloweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Megaweber, 1d, 1000000.0d).SetName("MagneticFlux_ToBase_Megaweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.UnitPole, 1d, 1.2566370614359172e-07d).SetName("MagneticFlux_ToBase_UnitPole");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Attoweber, 1d, 1.0000000000000001e-18d).SetName("MagneticFlux_ToBase_Attoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Kilomaxwell, 1d, 1.0000000000000001e-05d).SetName("MagneticFlux_ToBase_Kilomaxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Megamaxwell, 1d, 0.01d).SetName("MagneticFlux_ToBase_Megamaxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Line, 1d, 1e-08d).SetName("MagneticFlux_ToBase_Line");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.VoltSecond, 1d, 1.0d).SetName("MagneticFlux_ToBase_VoltSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Nanoweber, 1d, 999999999.99999988d).SetName("MagneticFlux_FromBase_Nanoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Microweber, 1d, 1000000.0d).SetName("MagneticFlux_FromBase_Microweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Milliweber, 1d, 1000.0d).SetName("MagneticFlux_FromBase_Milliweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Weber, 1d, 1.0d).SetName("MagneticFlux_FromBase_Weber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Maxwell, 1d, 100000000.0d).SetName("MagneticFlux_FromBase_Maxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Picoweber, 1d, 1000000000000.0d).SetName("MagneticFlux_FromBase_Picoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Femtoweber, 1d, 999999999999999.88d).SetName("MagneticFlux_FromBase_Femtoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Kiloweber, 1d, 0.001d).SetName("MagneticFlux_FromBase_Kiloweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Megaweber, 1d, 9.9999999999999995e-07d).SetName("MagneticFlux_FromBase_Megaweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.UnitPole, 1d, 7957747.1545947669d).SetName("MagneticFlux_FromBase_UnitPole");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Attoweber, 1d, 9.9999999999999987e+17d).SetName("MagneticFlux_FromBase_Attoweber");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Kilomaxwell, 1d, 99999.999999999985d).SetName("MagneticFlux_FromBase_Kilomaxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Megamaxwell, 1d, 100.0d).SetName("MagneticFlux_FromBase_Megamaxwell");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.Line, 1d, 100000000.0d).SetName("MagneticFlux_FromBase_Line");
            yield return new TestCaseData(UnitConverterMagneticFluxUnit.VoltSecond, 1d, 1.0d).SetName("MagneticFlux_FromBase_VoltSecond");
        }
    }
}
