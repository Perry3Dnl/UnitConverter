namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MagneticField;

    public sealed class UnitToolsKnownValueMagneticFieldTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticField_ToBaseUnit_ReturnsExpectedValue(UnitToolsMagneticFieldUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticField.ToTesla(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MagneticField_FromBaseUnit_ReturnsExpectedValue(UnitToolsMagneticFieldUnit unit, double input, double expected)
        {
            double result = UnitToolsMagneticField.FromTesla(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MagneticField_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMagneticFieldUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMagneticField.ToTesla(input, unit);
            double result = UnitToolsMagneticField.FromTesla(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Nanotesla, 1d, 1.0000000000000001e-09d).SetName("MagneticField_ToBase_Nanotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Microtesla, 1d, 9.9999999999999995e-07d).SetName("MagneticField_ToBase_Microtesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Millitesla, 1d, 0.001d).SetName("MagneticField_ToBase_Millitesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Tesla, 1d, 1.0d).SetName("MagneticField_ToBase_Tesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Gauss, 1d, 0.0001d).SetName("MagneticField_ToBase_Gauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Picotesla, 1d, 9.9999999999999998e-13d).SetName("MagneticField_ToBase_Picotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Kilotesla, 1d, 1000.0d).SetName("MagneticField_ToBase_Kilotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Megatesla, 1d, 1000000.0d).SetName("MagneticField_ToBase_Megatesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Gamma, 1d, 1.0000000000000001e-09d).SetName("MagneticField_ToBase_Gamma");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.LinePerSquareCentimeter, 1d, 0.0001d).SetName("MagneticField_ToBase_LinePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Microgauss, 1d, 1e-10d).SetName("MagneticField_ToBase_Microgauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Milligauss, 1d, 9.9999999999999995e-08d).SetName("MagneticField_ToBase_Milligauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Kilogauss, 1d, 0.10000000000000001d).SetName("MagneticField_ToBase_Kilogauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Megagauss, 1d, 100.0d).SetName("MagneticField_ToBase_Megagauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent, 1d, 0.0001d).SetName("MagneticField_ToBase_OerstedVacuumEquivalent");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Nanotesla, 1d, 999999999.99999988d).SetName("MagneticField_FromBase_Nanotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Microtesla, 1d, 1000000.0d).SetName("MagneticField_FromBase_Microtesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Millitesla, 1d, 1000.0d).SetName("MagneticField_FromBase_Millitesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Tesla, 1d, 1.0d).SetName("MagneticField_FromBase_Tesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Gauss, 1d, 10000.0d).SetName("MagneticField_FromBase_Gauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Picotesla, 1d, 1000000000000.0d).SetName("MagneticField_FromBase_Picotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Kilotesla, 1d, 0.001d).SetName("MagneticField_FromBase_Kilotesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Megatesla, 1d, 9.9999999999999995e-07d).SetName("MagneticField_FromBase_Megatesla");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Gamma, 1d, 999999999.99999988d).SetName("MagneticField_FromBase_Gamma");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.LinePerSquareCentimeter, 1d, 10000.0d).SetName("MagneticField_FromBase_LinePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Microgauss, 1d, 10000000000.0d).SetName("MagneticField_FromBase_Microgauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Milligauss, 1d, 10000000.0d).SetName("MagneticField_FromBase_Milligauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Kilogauss, 1d, 10.0d).SetName("MagneticField_FromBase_Kilogauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.Megagauss, 1d, 0.01d).SetName("MagneticField_FromBase_Megagauss");
            yield return new TestCaseData(UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent, 1d, 10000.0d).SetName("MagneticField_FromBase_OerstedVacuumEquivalent");
        }
    }
}
