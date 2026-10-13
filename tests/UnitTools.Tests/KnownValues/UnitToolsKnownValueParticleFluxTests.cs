namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ParticleFlux;

    public sealed class UnitToolsKnownValueParticleFluxTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFlux_ToBaseUnit_ReturnsExpectedValue(UnitToolsParticleFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsParticleFlux.ToParticlePerSquareMeterSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ParticleFlux_FromBaseUnit_ReturnsExpectedValue(UnitToolsParticleFluxUnit unit, double input, double expected)
        {
            double result = UnitToolsParticleFlux.FromParticlePerSquareMeterSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ParticleFlux_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsParticleFluxUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsParticleFlux.ToParticlePerSquareMeterSecond(input, unit);
            double result = UnitToolsParticleFlux.FromParticlePerSquareMeterSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_ToBase_ParticlePerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond, 1d, 10000.0d).SetName("ParticleFlux_ToBase_ParticlePerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond, 1d, 1000000.0d).SetName("ParticleFlux_ToBase_ParticlePerSquareMillimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute, 1d, 0.016666666666666666d).SetName("ParticleFlux_ToBase_ParticlePerSquareMeterMinute");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour, 1d, 0.00027777777777777778d).SetName("ParticleFlux_ToBase_ParticlePerSquareMeterHour");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond, 1d, 10.763910416709722d).SetName("ParticleFlux_ToBase_ParticlePerSquareFootSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond, 1d, 1550.0031000062002d).SetName("ParticleFlux_ToBase_ParticlePerSquareInchSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond, 1d, 10000.0d).SetName("ParticleFlux_ToBase_NeutronPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond, 1d, 10000.0d).SetName("ParticleFlux_ToBase_PhotonPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond, 1d, 10000.0d).SetName("ParticleFlux_ToBase_ProtonPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond, 1d, 10000.0d).SetName("ParticleFlux_ToBase_ElectronPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_ToBase_NeutronPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_ToBase_PhotonPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute, 1d, 166.66666666666666d).SetName("ParticleFlux_ToBase_ParticlePerSquareCentimeterMinute");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour, 1d, 2.7777777777777777d).SetName("ParticleFlux_ToBase_ParticlePerSquareCentimeterHour");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_FromBase_ParticlePerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond, 1d, 0.0001d).SetName("ParticleFlux_FromBase_ParticlePerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond, 1d, 9.9999999999999995e-07d).SetName("ParticleFlux_FromBase_ParticlePerSquareMillimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute, 1d, 60.0d).SetName("ParticleFlux_FromBase_ParticlePerSquareMeterMinute");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour, 1d, 3600.0d).SetName("ParticleFlux_FromBase_ParticlePerSquareMeterHour");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond, 1d, 0.092903040000000006d).SetName("ParticleFlux_FromBase_ParticlePerSquareFootSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond, 1d, 0.00064515999999999998d).SetName("ParticleFlux_FromBase_ParticlePerSquareInchSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond, 1d, 0.0001d).SetName("ParticleFlux_FromBase_NeutronPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond, 1d, 0.0001d).SetName("ParticleFlux_FromBase_PhotonPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond, 1d, 0.0001d).SetName("ParticleFlux_FromBase_ProtonPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond, 1d, 0.0001d).SetName("ParticleFlux_FromBase_ElectronPerSquareCentimeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_FromBase_NeutronPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond, 1d, 1.0d).SetName("ParticleFlux_FromBase_PhotonPerSquareMeterSecond");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute, 1d, 0.0060000000000000001d).SetName("ParticleFlux_FromBase_ParticlePerSquareCentimeterMinute");
            yield return new TestCaseData(UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour, 1d, 0.35999999999999999d).SetName("ParticleFlux_FromBase_ParticlePerSquareCentimeterHour");
        }
    }
}
