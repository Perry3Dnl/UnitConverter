namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.ElectricFluxDensity;

    public sealed class UnitConverterKnownValueElectricFluxDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFluxDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricFluxDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFluxDensity.ToCoulombPerSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricFluxDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricFluxDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricFluxDensity.FromCoulombPerSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricFluxDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricFluxDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricFluxDensity.ToCoulombPerSquareMeter(input, unit);
            double result = UnitConverterElectricFluxDensity.FromCoulombPerSquareMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter, 1d, 1.0d).SetName("ElectricFluxDensity_ToBase_CoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter, 1d, 0.001d).SetName("ElectricFluxDensity_ToBase_MillicoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricFluxDensity_ToBase_MicrocoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter, 1d, 10000.0d).SetName("ElectricFluxDensity_ToBase_CoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter, 1d, 3.3356409519815205e-06d).SetName("ElectricFluxDensity_ToBase_StatcoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricFluxDensity_ToBase_NanocoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch, 1d, 1550.0031000062002d).SetName("ElectricFluxDensity_ToBase_CoulombPerSquareInch");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot, 1d, 10.763910416709722d).SetName("ElectricFluxDensity_ToBase_CoulombPerSquareFoot");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, 1d, 0.0099999999999999985d).SetName("ElectricFluxDensity_ToBase_MicrocoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter, 1d, 1.0000000000000001e-05d).SetName("ElectricFluxDensity_ToBase_NanocoulombPerSquareCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter, 1d, 1.0d).SetName("ElectricFluxDensity_FromBase_CoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter, 1d, 1000.0d).SetName("ElectricFluxDensity_FromBase_MillicoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter, 1d, 1000000.0d).SetName("ElectricFluxDensity_FromBase_MicrocoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter, 1d, 0.0001d).SetName("ElectricFluxDensity_FromBase_CoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter, 1d, 299792.45799999998d).SetName("ElectricFluxDensity_FromBase_StatcoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter, 1d, 999999999.99999988d).SetName("ElectricFluxDensity_FromBase_NanocoulombPerSquareMeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch, 1d, 0.00064515999999999998d).SetName("ElectricFluxDensity_FromBase_CoulombPerSquareInch");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot, 1d, 0.092903040000000006d).SetName("ElectricFluxDensity_FromBase_CoulombPerSquareFoot");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, 1d, 100.00000000000001d).SetName("ElectricFluxDensity_FromBase_MicrocoulombPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter, 1d, 99999.999999999985d).SetName("ElectricFluxDensity_FromBase_NanocoulombPerSquareCentimeter");
        }
    }
}
