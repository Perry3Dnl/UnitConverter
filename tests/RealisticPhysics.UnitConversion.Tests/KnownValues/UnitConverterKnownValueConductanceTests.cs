namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Conductance;

    public sealed class UnitConverterKnownValueConductanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Conductance_ToBaseUnit_ReturnsExpectedValue(UnitConverterConductanceUnit unit, double input, double expected)
        {
            double result = UnitConverterConductance.ToSiemens(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Conductance_FromBaseUnit_ReturnsExpectedValue(UnitConverterConductanceUnit unit, double input, double expected)
        {
            double result = UnitConverterConductance.FromSiemens(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Conductance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterConductanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterConductance.ToSiemens(input, unit);
            double result = UnitConverterConductance.FromSiemens(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterConductanceUnit.Nanosiemens, 1d, 1.0000000000000001e-09d).SetName("Conductance_ToBase_Nanosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Microsiemens, 1d, 9.9999999999999995e-07d).SetName("Conductance_ToBase_Microsiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Millisiemens, 1d, 0.001d).SetName("Conductance_ToBase_Millisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Siemens, 1d, 1.0d).SetName("Conductance_ToBase_Siemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Kilosiemens, 1d, 1000.0d).SetName("Conductance_ToBase_Kilosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Mho, 1d, 1.0d).SetName("Conductance_ToBase_Mho");
            yield return new TestCaseData(UnitConverterConductanceUnit.Femtosiemens, 1d, 1.0000000000000001e-15d).SetName("Conductance_ToBase_Femtosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Picosiemens, 1d, 9.9999999999999998e-13d).SetName("Conductance_ToBase_Picosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Megasiemens, 1d, 1000000.0d).SetName("Conductance_ToBase_Megasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Gigasiemens, 1d, 1000000000.0d).SetName("Conductance_ToBase_Gigasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Abmho, 1d, 1000000000.0d).SetName("Conductance_ToBase_Abmho");
            yield return new TestCaseData(UnitConverterConductanceUnit.Centisiemens, 1d, 0.01d).SetName("Conductance_ToBase_Centisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Decisiemens, 1d, 0.10000000000000001d).SetName("Conductance_ToBase_Decisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Decasiemens, 1d, 10.0d).SetName("Conductance_ToBase_Decasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Hectosiemens, 1d, 100.0d).SetName("Conductance_ToBase_Hectosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Statmho, 1d, 1.1126500559999999e-12d).SetName("Conductance_ToBase_Statmho");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterConductanceUnit.Nanosiemens, 1d, 999999999.99999988d).SetName("Conductance_FromBase_Nanosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Microsiemens, 1d, 1000000.0d).SetName("Conductance_FromBase_Microsiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Millisiemens, 1d, 1000.0d).SetName("Conductance_FromBase_Millisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Siemens, 1d, 1.0d).SetName("Conductance_FromBase_Siemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Kilosiemens, 1d, 0.001d).SetName("Conductance_FromBase_Kilosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Mho, 1d, 1.0d).SetName("Conductance_FromBase_Mho");
            yield return new TestCaseData(UnitConverterConductanceUnit.Femtosiemens, 1d, 999999999999999.88d).SetName("Conductance_FromBase_Femtosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Picosiemens, 1d, 1000000000000.0d).SetName("Conductance_FromBase_Picosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Megasiemens, 1d, 9.9999999999999995e-07d).SetName("Conductance_FromBase_Megasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Gigasiemens, 1d, 1.0000000000000001e-09d).SetName("Conductance_FromBase_Gigasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Abmho, 1d, 1.0000000000000001e-09d).SetName("Conductance_FromBase_Abmho");
            yield return new TestCaseData(UnitConverterConductanceUnit.Centisiemens, 1d, 100.0d).SetName("Conductance_FromBase_Centisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Decisiemens, 1d, 10.0d).SetName("Conductance_FromBase_Decisiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Decasiemens, 1d, 0.10000000000000001d).SetName("Conductance_FromBase_Decasiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Hectosiemens, 1d, 0.01d).SetName("Conductance_FromBase_Hectosiemens");
            yield return new TestCaseData(UnitConverterConductanceUnit.Statmho, 1d, 898755178780.12854d).SetName("Conductance_FromBase_Statmho");
        }
    }
}
