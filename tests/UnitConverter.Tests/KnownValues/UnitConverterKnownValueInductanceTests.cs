namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Inductance;

    public sealed class UnitConverterKnownValueInductanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Inductance_ToBaseUnit_ReturnsExpectedValue(UnitConverterInductanceUnit unit, double input, double expected)
        {
            double result = UnitConverterInductance.ToHenry(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Inductance_FromBaseUnit_ReturnsExpectedValue(UnitConverterInductanceUnit unit, double input, double expected)
        {
            double result = UnitConverterInductance.FromHenry(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Inductance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterInductanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterInductance.ToHenry(input, unit);
            double result = UnitConverterInductance.FromHenry(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterInductanceUnit.Nanohenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_ToBase_Nanohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Microhenry, 1d, 9.9999999999999995e-07d).SetName("Inductance_ToBase_Microhenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Millihenry, 1d, 0.001d).SetName("Inductance_ToBase_Millihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Henry, 1d, 1.0d).SetName("Inductance_ToBase_Henry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Kilohenry, 1d, 1000.0d).SetName("Inductance_ToBase_Kilohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Femtohenry, 1d, 1.0000000000000001e-15d).SetName("Inductance_ToBase_Femtohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Picohenry, 1d, 9.9999999999999998e-13d).SetName("Inductance_ToBase_Picohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Megahenry, 1d, 1000000.0d).SetName("Inductance_ToBase_Megahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Gigahenry, 1d, 1000000000.0d).SetName("Inductance_ToBase_Gigahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Abhenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_ToBase_Abhenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Centihenry, 1d, 0.01d).SetName("Inductance_ToBase_Centihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Decihenry, 1d, 0.10000000000000001d).SetName("Inductance_ToBase_Decihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Decahenry, 1d, 10.0d).SetName("Inductance_ToBase_Decahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Hectohenry, 1d, 100.0d).SetName("Inductance_ToBase_Hectohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Stathenry, 1d, 898755178700.0d).SetName("Inductance_ToBase_Stathenry");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterInductanceUnit.Nanohenry, 1d, 999999999.99999988d).SetName("Inductance_FromBase_Nanohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Microhenry, 1d, 1000000.0d).SetName("Inductance_FromBase_Microhenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Millihenry, 1d, 1000.0d).SetName("Inductance_FromBase_Millihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Henry, 1d, 1.0d).SetName("Inductance_FromBase_Henry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Kilohenry, 1d, 0.001d).SetName("Inductance_FromBase_Kilohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Femtohenry, 1d, 999999999999999.88d).SetName("Inductance_FromBase_Femtohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Picohenry, 1d, 1000000000000.0d).SetName("Inductance_FromBase_Picohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Megahenry, 1d, 9.9999999999999995e-07d).SetName("Inductance_FromBase_Megahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Gigahenry, 1d, 1.0000000000000001e-09d).SetName("Inductance_FromBase_Gigahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Abhenry, 1d, 999999999.99999988d).SetName("Inductance_FromBase_Abhenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Centihenry, 1d, 100.0d).SetName("Inductance_FromBase_Centihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Decihenry, 1d, 10.0d).SetName("Inductance_FromBase_Decihenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Decahenry, 1d, 0.10000000000000001d).SetName("Inductance_FromBase_Decahenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Hectohenry, 1d, 0.01d).SetName("Inductance_FromBase_Hectohenry");
            yield return new TestCaseData(UnitConverterInductanceUnit.Stathenry, 1d, 1.1126500560991982e-12d).SetName("Inductance_FromBase_Stathenry");
        }
    }
}
