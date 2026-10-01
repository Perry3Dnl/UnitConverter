namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.ParticleFluence;

    public sealed class UnitConverterKnownValueParticleFluenceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFluence_ToBaseUnit_ReturnsExpectedValue(UnitConverterParticleFluenceUnit unit, double input, double expected)
        {
            double result = UnitConverterParticleFluence.ToParticlePerSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ParticleFluence_FromBaseUnit_ReturnsExpectedValue(UnitConverterParticleFluenceUnit unit, double input, double expected)
        {
            double result = UnitConverterParticleFluence.FromParticlePerSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFluence_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterParticleFluenceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterParticleFluence.ToParticlePerSquareMeter(input, unit);
            double result = UnitConverterParticleFluence.FromParticlePerSquareMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter, 1d, 1000000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMillimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareFoot, 1d, 10.763910416709722d).SetName("ParticleFluence_ToBase_ParticlePerSquareFoot");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareInch, 1d, 1550.0031000062002d).SetName("ParticleFluence_ToBase_ParticlePerSquareInch");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_NeutronPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_PhotonPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerBarn, 1d, 9.9999999999999996e+27d).SetName("ParticleFluence_ToBase_ParticlePerBarn");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ProtonPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter, 1d, 10000.0d).SetName("ParticleFluence_ToBase_ElectronPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.NeutronPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_NeutronPerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.PhotonPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_ToBase_PhotonPerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer, 1d, 1000000000000.0d).SetName("ParticleFluence_ToBase_ParticlePerSquareMicrometer");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_ParticlePerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ParticlePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("ParticleFluence_FromBase_ParticlePerSquareMillimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareFoot, 1d, 0.092903040000000006d).SetName("ParticleFluence_FromBase_ParticlePerSquareFoot");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareInch, 1d, 0.00064515999999999998d).SetName("ParticleFluence_FromBase_ParticlePerSquareInch");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_NeutronPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_PhotonPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerBarn, 1d, 1.0000000000000001e-28d).SetName("ParticleFluence_FromBase_ParticlePerBarn");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ProtonPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter, 1d, 0.0001d).SetName("ParticleFluence_FromBase_ElectronPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.NeutronPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_NeutronPerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.PhotonPerSquareMeter, 1d, 1.0d).SetName("ParticleFluence_FromBase_PhotonPerSquareMeter");
            yield return new TestCaseData(UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("ParticleFluence_FromBase_ParticlePerSquareMicrometer");
        }
    }
}
