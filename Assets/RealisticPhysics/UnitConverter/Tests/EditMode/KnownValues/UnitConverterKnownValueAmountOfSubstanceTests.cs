namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.AmountOfSubstance;

    public sealed class UnitConverterKnownValueAmountOfSubstanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AmountOfSubstance_ToBaseUnit_ReturnsExpectedValue(UnitConverterAmountOfSubstanceUnit unit, double input, double expected)
        {
            double result = UnitConverterAmountOfSubstance.ToMole(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AmountOfSubstance_FromBaseUnit_ReturnsExpectedValue(UnitConverterAmountOfSubstanceUnit unit, double input, double expected)
        {
            double result = UnitConverterAmountOfSubstance.FromMole(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AmountOfSubstance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAmountOfSubstanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAmountOfSubstance.ToMole(input, unit);
            double result = UnitConverterAmountOfSubstance.FromMole(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Mole, 1d, 1.0d).SetName("AmountOfSubstance_ToBase_Mole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Millimole, 1d, 0.001d).SetName("AmountOfSubstance_ToBase_Millimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Micromole, 1d, 9.9999999999999995e-07d).SetName("AmountOfSubstance_ToBase_Micromole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Nanomole, 1d, 1.0000000000000001e-09d).SetName("AmountOfSubstance_ToBase_Nanomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Kilomole, 1d, 1000.0d).SetName("AmountOfSubstance_ToBase_Kilomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.PoundMole, 1d, 453.59237000000002d).SetName("AmountOfSubstance_ToBase_PoundMole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Particle, 1d, 1.6605390671738466e-24d).SetName("AmountOfSubstance_ToBase_Particle");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Molecule, 1d, 1.6605390671738466e-24d).SetName("AmountOfSubstance_ToBase_Molecule");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Centimole, 1d, 0.01d).SetName("AmountOfSubstance_ToBase_Centimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Decimole, 1d, 0.10000000000000001d).SetName("AmountOfSubstance_ToBase_Decimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Picomole, 1d, 9.9999999999999998e-13d).SetName("AmountOfSubstance_ToBase_Picomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Femtomole, 1d, 1.0000000000000001e-15d).SetName("AmountOfSubstance_ToBase_Femtomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox, 1d, 9.9999999999999995e-07d).SetName("AmountOfSubstance_ToBase_InternationalUnitMoleApprox");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Mole, 1d, 1.0d).SetName("AmountOfSubstance_FromBase_Mole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Millimole, 1d, 1000.0d).SetName("AmountOfSubstance_FromBase_Millimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Micromole, 1d, 1000000.0d).SetName("AmountOfSubstance_FromBase_Micromole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Nanomole, 1d, 999999999.99999988d).SetName("AmountOfSubstance_FromBase_Nanomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Kilomole, 1d, 0.001d).SetName("AmountOfSubstance_FromBase_Kilomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.PoundMole, 1d, 0.0022046226218487759d).SetName("AmountOfSubstance_FromBase_PoundMole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Particle, 1d, 6.0221407600000005e+23d).SetName("AmountOfSubstance_FromBase_Particle");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Molecule, 1d, 6.0221407600000005e+23d).SetName("AmountOfSubstance_FromBase_Molecule");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Centimole, 1d, 100.0d).SetName("AmountOfSubstance_FromBase_Centimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Decimole, 1d, 10.0d).SetName("AmountOfSubstance_FromBase_Decimole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Picomole, 1d, 1000000000000.0d).SetName("AmountOfSubstance_FromBase_Picomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.Femtomole, 1d, 999999999999999.88d).SetName("AmountOfSubstance_FromBase_Femtomole");
            yield return new TestCaseData(UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox, 1d, 1000000.0d).SetName("AmountOfSubstance_FromBase_InternationalUnitMoleApprox");
        }
    }
}
