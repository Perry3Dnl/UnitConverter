namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.AmountOfSubstance;

    public sealed class UnitToolsKnownValueAmountOfSubstanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AmountOfSubstance_ToBaseUnit_ReturnsExpectedValue(UnitToolsAmountOfSubstanceUnit unit, double input, double expected)
        {
            double result = UnitToolsAmountOfSubstance.ToMole(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AmountOfSubstance_FromBaseUnit_ReturnsExpectedValue(UnitToolsAmountOfSubstanceUnit unit, double input, double expected)
        {
            double result = UnitToolsAmountOfSubstance.FromMole(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AmountOfSubstance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsAmountOfSubstanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsAmountOfSubstance.ToMole(input, unit);
            double result = UnitToolsAmountOfSubstance.FromMole(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Mole, 1d, 1.0d).SetName("AmountOfSubstance_ToBase_Mole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Millimole, 1d, 0.001d).SetName("AmountOfSubstance_ToBase_Millimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Micromole, 1d, 9.9999999999999995e-07d).SetName("AmountOfSubstance_ToBase_Micromole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Nanomole, 1d, 1.0000000000000001e-09d).SetName("AmountOfSubstance_ToBase_Nanomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Kilomole, 1d, 1000.0d).SetName("AmountOfSubstance_ToBase_Kilomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.PoundMole, 1d, 453.59237000000002d).SetName("AmountOfSubstance_ToBase_PoundMole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Particle, 1d, 1.6605390671738466e-24d).SetName("AmountOfSubstance_ToBase_Particle");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Molecule, 1d, 1.6605390671738466e-24d).SetName("AmountOfSubstance_ToBase_Molecule");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Centimole, 1d, 0.01d).SetName("AmountOfSubstance_ToBase_Centimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Decimole, 1d, 0.10000000000000001d).SetName("AmountOfSubstance_ToBase_Decimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Picomole, 1d, 9.9999999999999998e-13d).SetName("AmountOfSubstance_ToBase_Picomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Femtomole, 1d, 1.0000000000000001e-15d).SetName("AmountOfSubstance_ToBase_Femtomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox, 1d, 9.9999999999999995e-07d).SetName("AmountOfSubstance_ToBase_InternationalUnitMoleApprox");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Mole, 1d, 1.0d).SetName("AmountOfSubstance_FromBase_Mole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Millimole, 1d, 1000.0d).SetName("AmountOfSubstance_FromBase_Millimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Micromole, 1d, 1000000.0d).SetName("AmountOfSubstance_FromBase_Micromole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Nanomole, 1d, 999999999.99999988d).SetName("AmountOfSubstance_FromBase_Nanomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Kilomole, 1d, 0.001d).SetName("AmountOfSubstance_FromBase_Kilomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.PoundMole, 1d, 0.0022046226218487759d).SetName("AmountOfSubstance_FromBase_PoundMole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Particle, 1d, 6.0221407600000005e+23d).SetName("AmountOfSubstance_FromBase_Particle");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Molecule, 1d, 6.0221407600000005e+23d).SetName("AmountOfSubstance_FromBase_Molecule");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Centimole, 1d, 100.0d).SetName("AmountOfSubstance_FromBase_Centimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Decimole, 1d, 10.0d).SetName("AmountOfSubstance_FromBase_Decimole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Picomole, 1d, 1000000000000.0d).SetName("AmountOfSubstance_FromBase_Picomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.Femtomole, 1d, 999999999999999.88d).SetName("AmountOfSubstance_FromBase_Femtomole");
            yield return new TestCaseData(UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox, 1d, 1000000.0d).SetName("AmountOfSubstance_FromBase_InternationalUnitMoleApprox");
        }
    }
}
