namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Permittivity;

    public sealed class UnitConverterKnownValuePermittivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Permittivity_ToBaseUnit_ReturnsExpectedValue(UnitConverterPermittivityUnit unit, double input, double expected)
        {
            double result = UnitConverterPermittivity.ToFaradPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Permittivity_FromBaseUnit_ReturnsExpectedValue(UnitConverterPermittivityUnit unit, double input, double expected)
        {
            double result = UnitConverterPermittivity.FromFaradPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Permittivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterPermittivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterPermittivity.ToFaradPerMeter(input, unit);
            double result = UnitConverterPermittivity.FromFaradPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerMeter, 1d, 1.0d).SetName("Permittivity_ToBase_FaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.PicofaradPerMeter, 1d, 9.9999999999999998e-13d).SetName("Permittivity_ToBase_PicofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.NanofaradPerMeter, 1d, 1.0000000000000001e-09d).SetName("Permittivity_ToBase_NanofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.MicrofaradPerMeter, 1d, 9.9999999999999995e-07d).SetName("Permittivity_ToBase_MicrofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.VacuumPermittivity, 1d, 8.8541878128000006e-12d).SetName("Permittivity_ToBase_VacuumPermittivity");
            yield return new TestCaseData(UnitConverterPermittivityUnit.MillifaradPerMeter, 1d, 0.001d).SetName("Permittivity_ToBase_MillifaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FemtofaradPerMeter, 1d, 1.0000000000000001e-15d).SetName("Permittivity_ToBase_FemtofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerMillimeter, 1d, 1000.0d).SetName("Permittivity_ToBase_FaradPerMillimeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerInch, 1d, 39.370078740157481d).SetName("Permittivity_ToBase_FaradPerInch");
            yield return new TestCaseData(UnitConverterPermittivityUnit.RelativePermittivity, 1d, 8.8541878128000006e-12d).SetName("Permittivity_ToBase_RelativePermittivity");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerMeter, 1d, 1.0d).SetName("Permittivity_FromBase_FaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.PicofaradPerMeter, 1d, 1000000000000.0d).SetName("Permittivity_FromBase_PicofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.NanofaradPerMeter, 1d, 999999999.99999988d).SetName("Permittivity_FromBase_NanofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.MicrofaradPerMeter, 1d, 1000000.0d).SetName("Permittivity_FromBase_MicrofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.VacuumPermittivity, 1d, 112940906737.30191d).SetName("Permittivity_FromBase_VacuumPermittivity");
            yield return new TestCaseData(UnitConverterPermittivityUnit.MillifaradPerMeter, 1d, 1000.0d).SetName("Permittivity_FromBase_MillifaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FemtofaradPerMeter, 1d, 999999999999999.88d).SetName("Permittivity_FromBase_FemtofaradPerMeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerMillimeter, 1d, 0.001d).SetName("Permittivity_FromBase_FaradPerMillimeter");
            yield return new TestCaseData(UnitConverterPermittivityUnit.FaradPerInch, 1d, 0.025399999999999999d).SetName("Permittivity_FromBase_FaradPerInch");
            yield return new TestCaseData(UnitConverterPermittivityUnit.RelativePermittivity, 1d, 112940906737.30191d).SetName("Permittivity_FromBase_RelativePermittivity");
        }
    }
}
