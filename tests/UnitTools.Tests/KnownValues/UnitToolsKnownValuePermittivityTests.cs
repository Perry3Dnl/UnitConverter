namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Permittivity;

    public sealed class UnitToolsKnownValuePermittivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Permittivity_ToBaseUnit_ReturnsExpectedValue(UnitToolsPermittivityUnit unit, double input, double expected)
        {
            double result = UnitToolsPermittivity.ToFaradPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Permittivity_FromBaseUnit_ReturnsExpectedValue(UnitToolsPermittivityUnit unit, double input, double expected)
        {
            double result = UnitToolsPermittivity.FromFaradPerMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Permittivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsPermittivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsPermittivity.ToFaradPerMeter(input, unit);
            double result = UnitToolsPermittivity.FromFaradPerMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerMeter, 1d, 1.0d).SetName("Permittivity_ToBase_FaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.PicofaradPerMeter, 1d, 9.9999999999999998e-13d).SetName("Permittivity_ToBase_PicofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.NanofaradPerMeter, 1d, 1.0000000000000001e-09d).SetName("Permittivity_ToBase_NanofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.MicrofaradPerMeter, 1d, 9.9999999999999995e-07d).SetName("Permittivity_ToBase_MicrofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.VacuumPermittivity, 1d, 8.8541878128000006e-12d).SetName("Permittivity_ToBase_VacuumPermittivity");
            yield return new TestCaseData(UnitToolsPermittivityUnit.MillifaradPerMeter, 1d, 0.001d).SetName("Permittivity_ToBase_MillifaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FemtofaradPerMeter, 1d, 1.0000000000000001e-15d).SetName("Permittivity_ToBase_FemtofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerMillimeter, 1d, 1000.0d).SetName("Permittivity_ToBase_FaradPerMillimeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerInch, 1d, 39.370078740157481d).SetName("Permittivity_ToBase_FaradPerInch");
            yield return new TestCaseData(UnitToolsPermittivityUnit.RelativePermittivity, 1d, 8.8541878128000006e-12d).SetName("Permittivity_ToBase_RelativePermittivity");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerMeter, 1d, 1.0d).SetName("Permittivity_FromBase_FaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.PicofaradPerMeter, 1d, 1000000000000.0d).SetName("Permittivity_FromBase_PicofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.NanofaradPerMeter, 1d, 999999999.99999988d).SetName("Permittivity_FromBase_NanofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.MicrofaradPerMeter, 1d, 1000000.0d).SetName("Permittivity_FromBase_MicrofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.VacuumPermittivity, 1d, 112940906737.30191d).SetName("Permittivity_FromBase_VacuumPermittivity");
            yield return new TestCaseData(UnitToolsPermittivityUnit.MillifaradPerMeter, 1d, 1000.0d).SetName("Permittivity_FromBase_MillifaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FemtofaradPerMeter, 1d, 999999999999999.88d).SetName("Permittivity_FromBase_FemtofaradPerMeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerMillimeter, 1d, 0.001d).SetName("Permittivity_FromBase_FaradPerMillimeter");
            yield return new TestCaseData(UnitToolsPermittivityUnit.FaradPerInch, 1d, 0.025399999999999999d).SetName("Permittivity_FromBase_FaradPerInch");
            yield return new TestCaseData(UnitToolsPermittivityUnit.RelativePermittivity, 1d, 112940906737.30191d).SetName("Permittivity_FromBase_RelativePermittivity");
        }
    }
}
