namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Conductance;

    public sealed class UnitToolsKnownValueConductanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Conductance_ToBaseUnit_ReturnsExpectedValue(UnitToolsConductanceUnit unit, double input, double expected)
        {
            double result = UnitToolsConductance.ToSiemens(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Conductance_FromBaseUnit_ReturnsExpectedValue(UnitToolsConductanceUnit unit, double input, double expected)
        {
            double result = UnitToolsConductance.FromSiemens(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Conductance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsConductanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsConductance.ToSiemens(input, unit);
            double result = UnitToolsConductance.FromSiemens(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsConductanceUnit.Nanosiemens, 1d, 1.0000000000000001e-09d).SetName("Conductance_ToBase_Nanosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Microsiemens, 1d, 9.9999999999999995e-07d).SetName("Conductance_ToBase_Microsiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Millisiemens, 1d, 0.001d).SetName("Conductance_ToBase_Millisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Siemens, 1d, 1.0d).SetName("Conductance_ToBase_Siemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Kilosiemens, 1d, 1000.0d).SetName("Conductance_ToBase_Kilosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Mho, 1d, 1.0d).SetName("Conductance_ToBase_Mho");
            yield return new TestCaseData(UnitToolsConductanceUnit.Femtosiemens, 1d, 1.0000000000000001e-15d).SetName("Conductance_ToBase_Femtosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Picosiemens, 1d, 9.9999999999999998e-13d).SetName("Conductance_ToBase_Picosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Megasiemens, 1d, 1000000.0d).SetName("Conductance_ToBase_Megasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Gigasiemens, 1d, 1000000000.0d).SetName("Conductance_ToBase_Gigasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Abmho, 1d, 1000000000.0d).SetName("Conductance_ToBase_Abmho");
            yield return new TestCaseData(UnitToolsConductanceUnit.Centisiemens, 1d, 0.01d).SetName("Conductance_ToBase_Centisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Decisiemens, 1d, 0.10000000000000001d).SetName("Conductance_ToBase_Decisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Decasiemens, 1d, 10.0d).SetName("Conductance_ToBase_Decasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Hectosiemens, 1d, 100.0d).SetName("Conductance_ToBase_Hectosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Statmho, 1d, 1.1126500559999999e-12d).SetName("Conductance_ToBase_Statmho");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsConductanceUnit.Nanosiemens, 1d, 999999999.99999988d).SetName("Conductance_FromBase_Nanosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Microsiemens, 1d, 1000000.0d).SetName("Conductance_FromBase_Microsiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Millisiemens, 1d, 1000.0d).SetName("Conductance_FromBase_Millisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Siemens, 1d, 1.0d).SetName("Conductance_FromBase_Siemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Kilosiemens, 1d, 0.001d).SetName("Conductance_FromBase_Kilosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Mho, 1d, 1.0d).SetName("Conductance_FromBase_Mho");
            yield return new TestCaseData(UnitToolsConductanceUnit.Femtosiemens, 1d, 999999999999999.88d).SetName("Conductance_FromBase_Femtosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Picosiemens, 1d, 1000000000000.0d).SetName("Conductance_FromBase_Picosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Megasiemens, 1d, 9.9999999999999995e-07d).SetName("Conductance_FromBase_Megasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Gigasiemens, 1d, 1.0000000000000001e-09d).SetName("Conductance_FromBase_Gigasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Abmho, 1d, 1.0000000000000001e-09d).SetName("Conductance_FromBase_Abmho");
            yield return new TestCaseData(UnitToolsConductanceUnit.Centisiemens, 1d, 100.0d).SetName("Conductance_FromBase_Centisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Decisiemens, 1d, 10.0d).SetName("Conductance_FromBase_Decisiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Decasiemens, 1d, 0.10000000000000001d).SetName("Conductance_FromBase_Decasiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Hectosiemens, 1d, 0.01d).SetName("Conductance_FromBase_Hectosiemens");
            yield return new TestCaseData(UnitToolsConductanceUnit.Statmho, 1d, 898755178780.12854d).SetName("Conductance_FromBase_Statmho");
        }
    }
}
