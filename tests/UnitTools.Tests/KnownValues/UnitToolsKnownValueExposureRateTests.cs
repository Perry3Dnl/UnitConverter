namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ExposureRate;

    public sealed class UnitToolsKnownValueExposureRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ExposureRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsExposureRateUnit unit, double input, double expected)
        {
            double result = UnitToolsExposureRate.ToCoulombPerKilogramSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ExposureRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsExposureRateUnit unit, double input, double expected)
        {
            double result = UnitToolsExposureRate.FromCoulombPerKilogramSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ExposureRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsExposureRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsExposureRate.ToCoulombPerKilogramSecond(input, unit);
            double result = UnitToolsExposureRate.FromCoulombPerKilogramSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsExposureRateUnit.CoulombPerKilogramSecond, 1d, 1.0d).SetName("ExposureRate_ToBase_CoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond, 1d, 0.001d).SetName("ExposureRate_ToBase_MillicoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerSecond, 1d, 0.00025799999999999998d).SetName("ExposureRate_ToBase_RoentgenPerSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerHour, 1d, 7.166666666666666e-08d).SetName("ExposureRate_ToBase_RoentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MilliroentgenPerHour, 1d, 7.1666666666666665e-11d).SetName("ExposureRate_ToBase_MilliroentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond, 1d, 9.9999999999999995e-07d).SetName("ExposureRate_ToBase_MicrocoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.CoulombPerKilogramHour, 1d, 0.00027777777777777778d).SetName("ExposureRate_ToBase_CoulombPerKilogramHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour, 1d, 2.7777777777777777e-10d).SetName("ExposureRate_ToBase_MicrocoulombPerKilogramHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicroroentgenPerHour, 1d, 7.166666666666666e-14d).SetName("ExposureRate_ToBase_MicroroentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerMinute, 1d, 4.2999999999999995e-06d).SetName("ExposureRate_ToBase_RoentgenPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsExposureRateUnit.CoulombPerKilogramSecond, 1d, 1.0d).SetName("ExposureRate_FromBase_CoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond, 1d, 1000.0d).SetName("ExposureRate_FromBase_MillicoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerSecond, 1d, 3875.9689922480625d).SetName("ExposureRate_FromBase_RoentgenPerSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerHour, 1d, 13953488.372093024d).SetName("ExposureRate_FromBase_RoentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MilliroentgenPerHour, 1d, 13953488372.093023d).SetName("ExposureRate_FromBase_MilliroentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond, 1d, 1000000.0d).SetName("ExposureRate_FromBase_MicrocoulombPerKilogramSecond");
            yield return new TestCaseData(UnitToolsExposureRateUnit.CoulombPerKilogramHour, 1d, 3600.0d).SetName("ExposureRate_FromBase_CoulombPerKilogramHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour, 1d, 3600000000.0d).SetName("ExposureRate_FromBase_MicrocoulombPerKilogramHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.MicroroentgenPerHour, 1d, 13953488372093.025d).SetName("ExposureRate_FromBase_MicroroentgenPerHour");
            yield return new TestCaseData(UnitToolsExposureRateUnit.RoentgenPerMinute, 1d, 232558.13953488375d).SetName("ExposureRate_FromBase_RoentgenPerMinute");
        }
    }
}
