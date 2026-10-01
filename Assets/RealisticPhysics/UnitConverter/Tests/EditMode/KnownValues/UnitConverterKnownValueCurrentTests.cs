namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Current;

    public sealed class UnitConverterKnownValueCurrentTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Current_ToBaseUnit_ReturnsExpectedValue(UnitConverterCurrentUnit unit, double input, double expected)
        {
            double result = UnitConverterCurrent.ToAmpere(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Current_FromBaseUnit_ReturnsExpectedValue(UnitConverterCurrentUnit unit, double input, double expected)
        {
            double result = UnitConverterCurrent.FromAmpere(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Current_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterCurrentUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterCurrent.ToAmpere(input, unit);
            double result = UnitConverterCurrent.FromAmpere(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterCurrentUnit.Nanoampere, 1d, 1.0000000000000001e-09d).SetName("Current_ToBase_Nanoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Microampere, 1d, 9.9999999999999995e-07d).SetName("Current_ToBase_Microampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Milliampere, 1d, 0.001d).SetName("Current_ToBase_Milliampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Ampere, 1d, 1.0d).SetName("Current_ToBase_Ampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Kiloampere, 1d, 1000.0d).SetName("Current_ToBase_Kiloampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Megaampere, 1d, 1000000.0d).SetName("Current_ToBase_Megaampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Statampere, 1d, 3.335641e-10d).SetName("Current_ToBase_Statampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Femtoampere, 1d, 1.0000000000000001e-15d).SetName("Current_ToBase_Femtoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Picoampere, 1d, 9.9999999999999998e-13d).SetName("Current_ToBase_Picoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Teraampere, 1d, 1000000000000.0d).SetName("Current_ToBase_Teraampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Petaampere, 1d, 1000000000000000.0d).SetName("Current_ToBase_Petaampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Abampere, 1d, 10.0d).SetName("Current_ToBase_Abampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Biot, 1d, 10.0d).SetName("Current_ToBase_Biot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterCurrentUnit.Nanoampere, 1d, 999999999.99999988d).SetName("Current_FromBase_Nanoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Microampere, 1d, 1000000.0d).SetName("Current_FromBase_Microampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Milliampere, 1d, 1000.0d).SetName("Current_FromBase_Milliampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Ampere, 1d, 1.0d).SetName("Current_FromBase_Ampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Kiloampere, 1d, 0.001d).SetName("Current_FromBase_Kiloampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Megaampere, 1d, 9.9999999999999995e-07d).SetName("Current_FromBase_Megaampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Statampere, 1d, 2997924536.8431435d).SetName("Current_FromBase_Statampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Femtoampere, 1d, 999999999999999.88d).SetName("Current_FromBase_Femtoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Picoampere, 1d, 1000000000000.0d).SetName("Current_FromBase_Picoampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Teraampere, 1d, 9.9999999999999998e-13d).SetName("Current_FromBase_Teraampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Petaampere, 1d, 1.0000000000000001e-15d).SetName("Current_FromBase_Petaampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Abampere, 1d, 0.10000000000000001d).SetName("Current_FromBase_Abampere");
            yield return new TestCaseData(UnitConverterCurrentUnit.Biot, 1d, 0.10000000000000001d).SetName("Current_FromBase_Biot");
        }
    }
}
