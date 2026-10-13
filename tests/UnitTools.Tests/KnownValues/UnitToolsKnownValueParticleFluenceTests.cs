namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ParticleFluence;

    public sealed class UnitToolsKnownValueParticleFluenceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFluence_ToBaseUnit_ReturnsExpectedValue(UnitToolsParticleFluenceUnit unit, double input, double expected)
        {
            double result = UnitToolsParticleFluence.ToParticlePerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ParticleFluence_FromBaseUnit_ReturnsExpectedValue(UnitToolsParticleFluenceUnit unit, double input, double expected)
        {
            double result = UnitToolsParticleFluence.FromParticlePerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFluence_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsParticleFluenceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsParticleFluence.ToParticlePerSquareMeter(input, unit);
            double result = UnitToolsParticleFluence.FromParticlePerSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter, 1d, 1000000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareFoot, 1d, 10.763910416709722d).SetName("ParticleFluence_ToBase_ParticlePerSquareFoot");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareInch, 1d, 1550.0031000062002d).SetName("ParticleFluence_ToBase_ParticlePerSquareInch");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_NeutronPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_PhotonPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerBarn, 1d, 9.9999999999999996e+27d).SetName("ParticleFluence_ToBase_ParticlePerBarn");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ProtonPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ElectronPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.NeutronPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_NeutronPerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.PhotonPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_PhotonPerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer, 1d, 1000000000000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMicrometer");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_ParticlePerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ParticlePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("ParticleFluence_FromBase_ParticlePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareFoot, 1d, 0.092903040000000006d).SetName("ParticleFluence_FromBase_ParticlePerSquareFoot");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareInch, 1d, 0.00064515999999999998d).SetName("ParticleFluence_FromBase_ParticlePerSquareInch");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_NeutronPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_PhotonPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerBarn, 1d, 1.0000000000000001e-28d).SetName("ParticleFluence_FromBase_ParticlePerBarn");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ProtonPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ElectronPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.NeutronPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_NeutronPerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.PhotonPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_PhotonPerSquareMeter");
            yield return new TestCaseData(UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("ParticleFluence_FromBase_ParticlePerSquareMicrometer");
        }
    }
}
