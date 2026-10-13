namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Capacitance;

    public sealed class UnitToolsKnownValueCapacitanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Capacitance_ToBaseUnit_ReturnsExpectedValue(UnitToolsCapacitanceUnit unit, double input, double expected)
        {
            double result = UnitToolsCapacitance.ToFarad(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Capacitance_FromBaseUnit_ReturnsExpectedValue(UnitToolsCapacitanceUnit unit, double input, double expected)
        {
            double result = UnitToolsCapacitance.FromFarad(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Capacitance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsCapacitanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsCapacitance.ToFarad(input, unit);
            double result = UnitToolsCapacitance.FromFarad(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Picofarad, 1d, 9.9999999999999998e-13d).SetName("Capacitance_ToBase_Picofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Nanofarad, 1d, 1.0000000000000001e-09d).SetName("Capacitance_ToBase_Nanofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Microfarad, 1d, 9.9999999999999995e-07d).SetName("Capacitance_ToBase_Microfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Millifarad, 1d, 0.001d).SetName("Capacitance_ToBase_Millifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Farad, 1d, 1.0d).SetName("Capacitance_ToBase_Farad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Kilofarad, 1d, 1000.0d).SetName("Capacitance_ToBase_Kilofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Attofarad, 1d, 1.0000000000000001e-18d).SetName("Capacitance_ToBase_Attofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Femtofarad, 1d, 1.0000000000000001e-15d).SetName("Capacitance_ToBase_Femtofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Megafarad, 1d, 1000000.0d).SetName("Capacitance_ToBase_Megafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Gigafarad, 1d, 1000000000.0d).SetName("Capacitance_ToBase_Gigafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Abfarad, 1d, 1000000000.0d).SetName("Capacitance_ToBase_Abfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Statfarad, 1d, 1.1126500559999999e-12d).SetName("Capacitance_ToBase_Statfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent, 1d, 9.9999999999999995e-07d).SetName("Capacitance_ToBase_MicrofaradPerVoltEquivalent");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Centifarad, 1d, 0.01d).SetName("Capacitance_ToBase_Centifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Decifarad, 1d, 0.10000000000000001d).SetName("Capacitance_ToBase_Decifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Decafarad, 1d, 10.0d).SetName("Capacitance_ToBase_Decafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Hectofarad, 1d, 100.0d).SetName("Capacitance_ToBase_Hectofarad");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Picofarad, 1d, 1000000000000.0d).SetName("Capacitance_FromBase_Picofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Nanofarad, 1d, 999999999.99999988d).SetName("Capacitance_FromBase_Nanofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Microfarad, 1d, 1000000.0d).SetName("Capacitance_FromBase_Microfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Millifarad, 1d, 1000.0d).SetName("Capacitance_FromBase_Millifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Farad, 1d, 1.0d).SetName("Capacitance_FromBase_Farad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Kilofarad, 1d, 0.001d).SetName("Capacitance_FromBase_Kilofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Attofarad, 1d, 9.9999999999999987e+17d).SetName("Capacitance_FromBase_Attofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Femtofarad, 1d, 999999999999999.88d).SetName("Capacitance_FromBase_Femtofarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Megafarad, 1d, 9.9999999999999995e-07d).SetName("Capacitance_FromBase_Megafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Gigafarad, 1d, 1.0000000000000001e-09d).SetName("Capacitance_FromBase_Gigafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Abfarad, 1d, 1.0000000000000001e-09d).SetName("Capacitance_FromBase_Abfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Statfarad, 1d, 898755178780.12854d).SetName("Capacitance_FromBase_Statfarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent, 1d, 1000000.0d).SetName("Capacitance_FromBase_MicrofaradPerVoltEquivalent");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Centifarad, 1d, 100.0d).SetName("Capacitance_FromBase_Centifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Decifarad, 1d, 10.0d).SetName("Capacitance_FromBase_Decifarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Decafarad, 1d, 0.10000000000000001d).SetName("Capacitance_FromBase_Decafarad");
            yield return new TestCaseData(UnitToolsCapacitanceUnit.Hectofarad, 1d, 0.01d).SetName("Capacitance_FromBase_Hectofarad");
        }
    }
}
