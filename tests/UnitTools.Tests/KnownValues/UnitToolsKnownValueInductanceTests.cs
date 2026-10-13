namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Inductance;

    public sealed class UnitToolsKnownValueInductanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Inductance_ToBaseUnit_ReturnsExpectedValue(UnitToolsInductanceUnit unit, double input, double expected)
        {
            double result = UnitToolsInductance.ToHenry(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Inductance_FromBaseUnit_ReturnsExpectedValue(UnitToolsInductanceUnit unit, double input, double expected)
        {
            double result = UnitToolsInductance.FromHenry(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Inductance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsInductanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsInductance.ToHenry(input, unit);
            double result = UnitToolsInductance.FromHenry(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsInductanceUnit.Nanohenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_ToBase_Nanohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Microhenry, 1d, 9.9999999999999995e-07d).SetName("Inductance_ToBase_Microhenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Millihenry, 1d, 0.001d).SetName("Inductance_ToBase_Millihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Henry, 1d, 1.0d).SetName("Inductance_ToBase_Henry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Kilohenry, 1d, 1000.0d).SetName("Inductance_ToBase_Kilohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Femtohenry, 1d, 1.0000000000000001e-15d).SetName("Inductance_ToBase_Femtohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Picohenry, 1d, 9.9999999999999998e-13d).SetName("Inductance_ToBase_Picohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Megahenry, 1d, 1000000.0d).SetName("Inductance_ToBase_Megahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Gigahenry, 1d, 1000000000.0d).SetName("Inductance_ToBase_Gigahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Abhenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_ToBase_Abhenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Centihenry, 1d, 0.01d).SetName("Inductance_ToBase_Centihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Decihenry, 1d, 0.10000000000000001d).SetName("Inductance_ToBase_Decihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Decahenry, 1d, 10.0d).SetName("Inductance_ToBase_Decahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Hectohenry, 1d, 100.0d).SetName("Inductance_ToBase_Hectohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Stathenry, 1d, 898755178700.0d).SetName("Inductance_ToBase_Stathenry");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsInductanceUnit.Nanohenry, 1d, 999999999.99999988d).SetName("Inductance_FromBase_Nanohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Microhenry, 1d, 1000000.0d).SetName("Inductance_FromBase_Microhenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Millihenry, 1d, 1000.0d).SetName("Inductance_FromBase_Millihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Henry, 1d, 1.0d).SetName("Inductance_FromBase_Henry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Kilohenry, 1d, 0.001d).SetName("Inductance_FromBase_Kilohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Femtohenry, 1d, 999999999999999.88d).SetName("Inductance_FromBase_Femtohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Picohenry, 1d, 1000000000000.0d).SetName("Inductance_FromBase_Picohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Megahenry, 1d, 9.9999999999999995e-07d).SetName("Inductance_FromBase_Megahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Gigahenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_FromBase_Gigahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Abhenry, 1d, 999999999.99999988d).SetName("Inductance_FromBase_Abhenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Centihenry, 1d, 100.0d).SetName("Inductance_FromBase_Centihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Decihenry, 1d, 10.0d).SetName("Inductance_FromBase_Decihenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Decahenry, 1d, 0.10000000000000001d).SetName("Inductance_FromBase_Decahenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Hectohenry, 1d, 0.01d).SetName("Inductance_FromBase_Hectohenry");
            yield return new TestCaseData(UnitToolsInductanceUnit.Stathenry, 1d, 1.1126500560991982e-12d).SetName("Inductance_FromBase_Stathenry");
        }
    }
}
