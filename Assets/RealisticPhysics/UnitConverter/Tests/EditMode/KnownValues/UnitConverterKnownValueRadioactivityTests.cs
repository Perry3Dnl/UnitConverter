namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Radioactivity;

    public sealed class UnitConverterKnownValueRadioactivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Radioactivity_ToBaseUnit_ReturnsExpectedValue(UnitConverterRadioactivityUnit unit, double input, double expected)
        {
            double result = UnitConverterRadioactivity.ToBecquerel(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Radioactivity_FromBaseUnit_ReturnsExpectedValue(UnitConverterRadioactivityUnit unit, double input, double expected)
        {
            double result = UnitConverterRadioactivity.FromBecquerel(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Radioactivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterRadioactivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterRadioactivity.ToBecquerel(input, unit);
            double result = UnitConverterRadioactivity.FromBecquerel(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Becquerel, 1d, 1.0d).SetName("Radioactivity_ToBase_Becquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Kilobecquerel, 1d, 1000.0d).SetName("Radioactivity_ToBase_Kilobecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Megabecquerel, 1d, 1000000.0d).SetName("Radioactivity_ToBase_Megabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Gigabecquerel, 1d, 1000000000.0d).SetName("Radioactivity_ToBase_Gigabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Terabecquerel, 1d, 1000000000000.0d).SetName("Radioactivity_ToBase_Terabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Curie, 1d, 37000000000.0d).SetName("Radioactivity_ToBase_Curie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Millicurie, 1d, 37000000.0d).SetName("Radioactivity_ToBase_Millicurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Microcurie, 1d, 37000.0d).SetName("Radioactivity_ToBase_Microcurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Rutherford, 1d, 1000000.0d).SetName("Radioactivity_ToBase_Rutherford");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Microbecquerel, 1d, 9.9999999999999995e-07d).SetName("Radioactivity_ToBase_Microbecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Millibecquerel, 1d, 0.001d).SetName("Radioactivity_ToBase_Millibecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Petabecquerel, 1d, 1000000000000000.0d).SetName("Radioactivity_ToBase_Petabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerSecond, 1d, 1.0d).SetName("Radioactivity_ToBase_DisintegrationsPerSecond");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerMinute, 1d, 0.016666666666666666d).SetName("Radioactivity_ToBase_DisintegrationsPerMinute");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerHour, 1d, 0.00027777777777777778d).SetName("Radioactivity_ToBase_DisintegrationsPerHour");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Nanobecquerel, 1d, 1.0000000000000001e-09d).SetName("Radioactivity_ToBase_Nanobecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Exabecquerel, 1d, 1e+18d).SetName("Radioactivity_ToBase_Exabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Picocurie, 1d, 0.036999999999999998d).SetName("Radioactivity_ToBase_Picocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Nanocurie, 1d, 37.0d).SetName("Radioactivity_ToBase_Nanocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Kilocurie, 1d, 37000000000000.0d).SetName("Radioactivity_ToBase_Kilocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Megacurie, 1d, 37000000000000000.0d).SetName("Radioactivity_ToBase_Megacurie");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Becquerel, 1d, 1.0d).SetName("Radioactivity_FromBase_Becquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Kilobecquerel, 1d, 0.001d).SetName("Radioactivity_FromBase_Kilobecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Megabecquerel, 1d, 9.9999999999999995e-07d).SetName("Radioactivity_FromBase_Megabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Gigabecquerel, 1d, 1.0000000000000001e-09d).SetName("Radioactivity_FromBase_Gigabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Terabecquerel, 1d, 9.9999999999999998e-13d).SetName("Radioactivity_FromBase_Terabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Curie, 1d, 2.7027027027027027e-11d).SetName("Radioactivity_FromBase_Curie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Millicurie, 1d, 2.7027027027027028e-08d).SetName("Radioactivity_FromBase_Millicurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Microcurie, 1d, 2.7027027027027027e-05d).SetName("Radioactivity_FromBase_Microcurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Rutherford, 1d, 9.9999999999999995e-07d).SetName("Radioactivity_FromBase_Rutherford");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Microbecquerel, 1d, 1000000.0d).SetName("Radioactivity_FromBase_Microbecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Millibecquerel, 1d, 1000.0d).SetName("Radioactivity_FromBase_Millibecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Petabecquerel, 1d, 1.0000000000000001e-15d).SetName("Radioactivity_FromBase_Petabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerSecond, 1d, 1.0d).SetName("Radioactivity_FromBase_DisintegrationsPerSecond");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerMinute, 1d, 60.0d).SetName("Radioactivity_FromBase_DisintegrationsPerMinute");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.DisintegrationsPerHour, 1d, 3600.0d).SetName("Radioactivity_FromBase_DisintegrationsPerHour");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Nanobecquerel, 1d, 999999999.99999988d).SetName("Radioactivity_FromBase_Nanobecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Exabecquerel, 1d, 1.0000000000000001e-18d).SetName("Radioactivity_FromBase_Exabecquerel");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Picocurie, 1d, 27.027027027027028d).SetName("Radioactivity_FromBase_Picocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Nanocurie, 1d, 0.027027027027027029d).SetName("Radioactivity_FromBase_Nanocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Kilocurie, 1d, 2.7027027027027026e-14d).SetName("Radioactivity_FromBase_Kilocurie");
            yield return new TestCaseData(UnitConverterRadioactivityUnit.Megacurie, 1d, 2.7027027027027028e-17d).SetName("Radioactivity_FromBase_Megacurie");
        }
    }
}
