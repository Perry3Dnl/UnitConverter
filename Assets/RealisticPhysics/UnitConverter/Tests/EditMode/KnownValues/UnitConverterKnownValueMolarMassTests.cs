namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.MolarMass;

    public sealed class UnitConverterKnownValueMolarMassTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarMass_ToBaseUnit_ReturnsExpectedValue(UnitConverterMolarMassUnit unit, double input, double expected)
        {
            double result = UnitConverterMolarMass.ToKilogramPerMole(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void MolarMass_FromBaseUnit_ReturnsExpectedValue(UnitConverterMolarMassUnit unit, double input, double expected)
        {
            double result = UnitConverterMolarMass.FromKilogramPerMole(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void MolarMass_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMolarMassUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMolarMass.ToKilogramPerMole(input, unit);
            double result = UnitConverterMolarMass.FromKilogramPerMole(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerMole, 1d, 1.0d).SetName("MolarMass_ToBase_KilogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.GramPerMole, 1d, 0.001d).SetName("MolarMass_ToBase_GramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.MilligramPerMole, 1d, 9.9999999999999995e-07d).SetName("MolarMass_ToBase_MilligramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerKilomole, 1d, 0.001d).SetName("MolarMass_ToBase_KilogramPerKilomole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.PoundPerPoundMole, 1d, 0.001d).SetName("MolarMass_ToBase_PoundPerPoundMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.MicrogramPerMole, 1d, 1.0000000000000001e-09d).SetName("MolarMass_ToBase_MicrogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.NanogramPerMole, 1d, 9.9999999999999998e-13d).SetName("MolarMass_ToBase_NanogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerMillimole, 1d, 1000.0d).SetName("MolarMass_ToBase_KilogramPerMillimole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.GramPerKilomole, 1d, 9.9999999999999995e-07d).SetName("MolarMass_ToBase_GramPerKilomole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.OuncePerMole, 1d, 0.028349523125000001d).SetName("MolarMass_ToBase_OuncePerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.PoundPerMole, 1d, 0.45359237000000002d).SetName("MolarMass_ToBase_PoundPerMole");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerMole, 1d, 1.0d).SetName("MolarMass_FromBase_KilogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.GramPerMole, 1d, 1000.0d).SetName("MolarMass_FromBase_GramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.MilligramPerMole, 1d, 1000000.0d).SetName("MolarMass_FromBase_MilligramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerKilomole, 1d, 1000.0d).SetName("MolarMass_FromBase_KilogramPerKilomole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.PoundPerPoundMole, 1d, 1000.0d).SetName("MolarMass_FromBase_PoundPerPoundMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.MicrogramPerMole, 1d, 999999999.99999988d).SetName("MolarMass_FromBase_MicrogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.NanogramPerMole, 1d, 1000000000000.0d).SetName("MolarMass_FromBase_NanogramPerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.KilogramPerMillimole, 1d, 0.001d).SetName("MolarMass_FromBase_KilogramPerMillimole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.GramPerKilomole, 1d, 1000000.0d).SetName("MolarMass_FromBase_GramPerKilomole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.OuncePerMole, 1d, 35.273961949580411d).SetName("MolarMass_FromBase_OuncePerMole");
            yield return new TestCaseData(UnitConverterMolarMassUnit.PoundPerMole, 1d, 2.2046226218487757d).SetName("MolarMass_FromBase_PoundPerMole");
        }
    }
}
