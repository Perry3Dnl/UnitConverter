namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.MolarMass;

    public sealed class UnitToolsKnownValueMolarMassTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarMass_ToBaseUnit_ReturnsExpectedValue(UnitToolsMolarMassUnit unit, double input, double expected)
        {
            double result = UnitToolsMolarMass.ToKilogramPerMole(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MolarMass_FromBaseUnit_ReturnsExpectedValue(UnitToolsMolarMassUnit unit, double input, double expected)
        {
            double result = UnitToolsMolarMass.FromKilogramPerMole(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarMass_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsMolarMassUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsMolarMass.ToKilogramPerMole(input, unit);
            double result = UnitToolsMolarMass.FromKilogramPerMole(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerMole, 1d, 1.0d).SetName("MolarMass_ToBase_KilogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.GramPerMole, 1d, 0.001d).SetName("MolarMass_ToBase_GramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.MilligramPerMole, 1d, 9.9999999999999995e-07d).SetName("MolarMass_ToBase_MilligramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerKilomole, 1d, 0.001d).SetName("MolarMass_ToBase_KilogramPerKilomole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.PoundPerPoundMole, 1d, 0.001d).SetName("MolarMass_ToBase_PoundPerPoundMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.MicrogramPerMole, 1d, 1.0000000000000001e-09d).SetName("MolarMass_ToBase_MicrogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.NanogramPerMole, 1d, 9.9999999999999998e-13d).SetName("MolarMass_ToBase_NanogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerMillimole, 1d, 1000.0d).SetName("MolarMass_ToBase_KilogramPerMillimole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.GramPerKilomole, 1d, 9.9999999999999995e-07d).SetName("MolarMass_ToBase_GramPerKilomole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.OuncePerMole, 1d, 0.028349523125000001d).SetName("MolarMass_ToBase_OuncePerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.PoundPerMole, 1d, 0.45359237000000002d).SetName("MolarMass_ToBase_PoundPerMole");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerMole, 1d, 1.0d).SetName("MolarMass_FromBase_KilogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.GramPerMole, 1d, 1000.0d).SetName("MolarMass_FromBase_GramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.MilligramPerMole, 1d, 1000000.0d).SetName("MolarMass_FromBase_MilligramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerKilomole, 1d, 1000.0d).SetName("MolarMass_FromBase_KilogramPerKilomole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.PoundPerPoundMole, 1d, 1000.0d).SetName("MolarMass_FromBase_PoundPerPoundMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.MicrogramPerMole, 1d, 999999999.99999988d).SetName("MolarMass_FromBase_MicrogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.NanogramPerMole, 1d, 1000000000000.0d).SetName("MolarMass_FromBase_NanogramPerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.KilogramPerMillimole, 1d, 0.001d).SetName("MolarMass_FromBase_KilogramPerMillimole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.GramPerKilomole, 1d, 1000000.0d).SetName("MolarMass_FromBase_GramPerKilomole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.OuncePerMole, 1d, 35.273961949580411d).SetName("MolarMass_FromBase_OuncePerMole");
            yield return new TestCaseData(UnitToolsMolarMassUnit.PoundPerMole, 1d, 2.2046226218487757d).SetName("MolarMass_FromBase_PoundPerMole");
        }
    }
}
