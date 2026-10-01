namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.MagneticField;

    public sealed class UnitConverterKnownValueMagneticFieldTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticField_ToBaseUnit_ReturnsExpectedValue(UnitConverterMagneticFieldUnit unit, double input, double expected)
        {
            double result = UnitConverterMagneticField.ToTesla(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagneticField_FromBaseUnit_ReturnsExpectedValue(UnitConverterMagneticFieldUnit unit, double input, double expected)
        {
            double result = UnitConverterMagneticField.FromTesla(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticField_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMagneticFieldUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMagneticField.ToTesla(input, unit);
            double result = UnitConverterMagneticField.FromTesla(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Nanotesla, 1d, 1.0000000000000001e-09d).SetName("MagneticField_ToBase_Nanotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Microtesla, 1d, 9.9999999999999995e-07d).SetName("MagneticField_ToBase_Microtesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Millitesla, 1d, 0.001d).SetName("MagneticField_ToBase_Millitesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Tesla, 1d, 1.0d).SetName("MagneticField_ToBase_Tesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Gauss, 1d, 0.0001d).SetName("MagneticField_ToBase_Gauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Picotesla, 1d, 9.9999999999999998e-13d).SetName("MagneticField_ToBase_Picotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Kilotesla, 1d, 1000.0d).SetName("MagneticField_ToBase_Kilotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Megatesla, 1d, 1000000.0d).SetName("MagneticField_ToBase_Megatesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Gamma, 1d, 1.0000000000000001e-09d).SetName("MagneticField_ToBase_Gamma");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.LinePerSquareCentimeter, 1d, 0.0001d).SetName("MagneticField_ToBase_LinePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Microgauss, 1d, 1e-10d).SetName("MagneticField_ToBase_Microgauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Milligauss, 1d, 9.9999999999999995e-08d).SetName("MagneticField_ToBase_Milligauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Kilogauss, 1d, 0.10000000000000001d).SetName("MagneticField_ToBase_Kilogauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Megagauss, 1d, 100.0d).SetName("MagneticField_ToBase_Megagauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent, 1d, 0.0001d).SetName("MagneticField_ToBase_OerstedVacuumEquivalent");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Nanotesla, 1d, 999999999.99999988d).SetName("MagneticField_FromBase_Nanotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Microtesla, 1d, 1000000.0d).SetName("MagneticField_FromBase_Microtesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Millitesla, 1d, 1000.0d).SetName("MagneticField_FromBase_Millitesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Tesla, 1d, 1.0d).SetName("MagneticField_FromBase_Tesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Gauss, 1d, 10000.0d).SetName("MagneticField_FromBase_Gauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Picotesla, 1d, 1000000000000.0d).SetName("MagneticField_FromBase_Picotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Kilotesla, 1d, 0.001d).SetName("MagneticField_FromBase_Kilotesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Megatesla, 1d, 9.9999999999999995e-07d).SetName("MagneticField_FromBase_Megatesla");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Gamma, 1d, 999999999.99999988d).SetName("MagneticField_FromBase_Gamma");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.LinePerSquareCentimeter, 1d, 10000.0d).SetName("MagneticField_FromBase_LinePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Microgauss, 1d, 10000000000.0d).SetName("MagneticField_FromBase_Microgauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Milligauss, 1d, 10000000.0d).SetName("MagneticField_FromBase_Milligauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Kilogauss, 1d, 10.0d).SetName("MagneticField_FromBase_Kilogauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.Megagauss, 1d, 0.01d).SetName("MagneticField_FromBase_Megagauss");
            yield return new TestCaseData(UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent, 1d, 10000.0d).SetName("MagneticField_FromBase_OerstedVacuumEquivalent");
        }
    }
}
