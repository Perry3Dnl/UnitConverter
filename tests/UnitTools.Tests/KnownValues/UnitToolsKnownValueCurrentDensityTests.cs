namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.CurrentDensity;

    public sealed class UnitToolsKnownValueCurrentDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void CurrentDensity_ToBaseUnit_ReturnsExpectedValue(UnitToolsCurrentDensityUnit unit, double input, double expected)
        {
            double result = UnitToolsCurrentDensity.ToAmperePerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void CurrentDensity_FromBaseUnit_ReturnsExpectedValue(UnitToolsCurrentDensityUnit unit, double input, double expected)
        {
            double result = UnitToolsCurrentDensity.FromAmperePerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void CurrentDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsCurrentDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsCurrentDensity.ToAmperePerSquareMeter(input, unit);
            double result = UnitToolsCurrentDensity.FromAmperePerSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareMeter, 1d, 1.0d).SetName("CurrentDensity_ToBase_AmperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter, 1d, 0.001d).SetName("CurrentDensity_ToBase_MilliamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter, 1d, 10000.0d).SetName("CurrentDensity_ToBase_AmperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter, 1d, 1000000.0d).SetName("CurrentDensity_ToBase_AmperePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareInch, 1d, 1550.0031000062002d).SetName("CurrentDensity_ToBase_AmperePerSquareInch");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter, 1d, 1000.0d).SetName("CurrentDensity_ToBase_KiloamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter, 1d, 1000000.0d).SetName("CurrentDensity_ToBase_MegaamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter, 1d, 10.0d).SetName("CurrentDensity_ToBase_MilliamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter, 1d, 0.01d).SetName("CurrentDensity_ToBase_MicroamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareFoot, 1d, 10.763910416709722d).SetName("CurrentDensity_ToBase_AmperePerSquareFoot");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter, 1d, 1.0000000000000001e-09d).SetName("CurrentDensity_ToBase_NanoamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter, 1d, 10000000.0d).SetName("CurrentDensity_ToBase_KiloamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter, 1d, 1000000000000.0d).SetName("CurrentDensity_ToBase_MegaamperePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareInch, 1d, 1.5500031000062d).SetName("CurrentDensity_ToBase_MilliamperePerSquareInch");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareMeter, 1d, 1.0d).SetName("CurrentDensity_FromBase_AmperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter, 1d, 1000.0d).SetName("CurrentDensity_FromBase_MilliamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter, 1d, 0.0001d).SetName("CurrentDensity_FromBase_AmperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("CurrentDensity_FromBase_AmperePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareInch, 1d, 0.00064515999999999998d).SetName("CurrentDensity_FromBase_AmperePerSquareInch");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter, 1d, 0.001d).SetName("CurrentDensity_FromBase_KiloamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("CurrentDensity_FromBase_MegaamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter, 1d, 0.10000000000000001d).SetName("CurrentDensity_FromBase_MilliamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter, 1d, 100.0d).SetName("CurrentDensity_FromBase_MicroamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.AmperePerSquareFoot, 1d, 0.092903040000000006d).SetName("CurrentDensity_FromBase_AmperePerSquareFoot");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter, 1d, 999999999.99999988d).SetName("CurrentDensity_FromBase_NanoamperePerSquareMeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter, 1d, 9.9999999999999995e-08d).SetName("CurrentDensity_FromBase_KiloamperePerSquareCentimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter, 1d, 9.9999999999999998e-13d).SetName("CurrentDensity_FromBase_MegaamperePerSquareMillimeter");
            yield return new TestCaseData(UnitToolsCurrentDensityUnit.MilliamperePerSquareInch, 1d, 0.64515999999999996d).SetName("CurrentDensity_FromBase_MilliamperePerSquareInch");
        }
    }
}
