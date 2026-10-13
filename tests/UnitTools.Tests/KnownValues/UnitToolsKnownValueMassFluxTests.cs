namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MassFlux;

    public sealed class UnitToolsKnownValueMassFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MassFlux_ToBaseUnit_ReturnsExpectedValue(UnitToolsMassFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsMassFlux.ToKilogramPerSquareMeterSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MassFlux_FromBaseUnit_ReturnsExpectedValue(UnitToolsMassFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsMassFlux.FromKilogramPerSquareMeterSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MassFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMassFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMassFlux.ToKilogramPerSquareMeterSecond(input, unit);
            double result = UnitToolsMassFlux.FromKilogramPerSquareMeterSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond, 1d, 1.0d).SetName("MassFlux_ToBase_KilogramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.GramPerSquareMeterSecond, 1d, 0.001d).SetName("MassFlux_ToBase_GramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMeterHour, 1d, 0.00027777777777777778d).SetName("MassFlux_ToBase_KilogramPerSquareMeterHour");
            yield return new TestCaseData(UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond, 1d, 10.0d).SetName("MassFlux_ToBase_GramPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.PoundPerSquareFootSecond, 1d, 4.8824276363830501d).SetName("MassFlux_ToBase_PoundPerSquareFootSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond, 1d, 9.9999999999999995e-07d).SetName("MassFlux_ToBase_MilligramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond, 1d, 1.0000000000000001e-09d).SetName("MassFlux_ToBase_MicrogramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond, 1d, 10000.0d).SetName("MassFlux_ToBase_KilogramPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond, 1d, 1000000.0d).SetName("MassFlux_ToBase_KilogramPerSquareMillimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.OuncePerSquareFootSecond, 1d, 0.30515172727394063d).SetName("MassFlux_ToBase_OuncePerSquareFootSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.PoundPerSquareInchSecond, 1d, 703.06957963915931d).SetName("MassFlux_ToBase_PoundPerSquareInchSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond, 1d, 1.0d).SetName("MassFlux_FromBase_KilogramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.GramPerSquareMeterSecond, 1d, 1000.0d).SetName("MassFlux_FromBase_GramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMeterHour, 1d, 3600.0d).SetName("MassFlux_FromBase_KilogramPerSquareMeterHour");
            yield return new TestCaseData(UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond, 1d, 0.10000000000000001d).SetName("MassFlux_FromBase_GramPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.PoundPerSquareFootSecond, 1d, 0.20481614362252171d).SetName("MassFlux_FromBase_PoundPerSquareFootSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond, 1d, 1000000.0d).SetName("MassFlux_FromBase_MilligramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond, 1d, 999999999.99999988d).SetName("MassFlux_FromBase_MicrogramPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond, 1d, 0.0001d).SetName("MassFlux_FromBase_KilogramPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond, 1d, 9.9999999999999995e-07d).SetName("MassFlux_FromBase_KilogramPerSquareMillimeterSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.OuncePerSquareFootSecond, 1d, 3.2770582979603473d).SetName("MassFlux_FromBase_OuncePerSquareFootSecond");
            yield return new TestCaseData(UnitToolsMassFluxUnit.PoundPerSquareInchSecond, 1d, 0.0014223343307119562d).SetName("MassFlux_FromBase_PoundPerSquareInchSecond");
        }
    }
}
