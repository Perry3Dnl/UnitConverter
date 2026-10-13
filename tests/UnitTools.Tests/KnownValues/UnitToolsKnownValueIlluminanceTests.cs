namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Illuminance;

    public sealed class UnitToolsKnownValueIlluminanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Illuminance_ToBaseUnit_ReturnsExpectedValue(UnitToolsIlluminanceUnit unit, double input, double expected)
        {
            double result = UnitToolsIlluminance.ToLux(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Illuminance_FromBaseUnit_ReturnsExpectedValue(UnitToolsIlluminanceUnit unit, double input, double expected)
        {
            double result = UnitToolsIlluminance.FromLux(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Illuminance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsIlluminanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsIlluminance.ToLux(input, unit);
            double result = UnitToolsIlluminance.FromLux(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Nox, 1d, 0.001d).SetName("Illuminance_ToBase_Nox");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Lux, 1d, 1.0d).SetName("Illuminance_ToBase_Lux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Kilolux, 1d, 1000.0d).SetName("Illuminance_ToBase_Kilolux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Phot, 1d, 10000.0d).SetName("Illuminance_ToBase_Phot");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.FootCandle, 1d, 10.763910416709722d).SetName("Illuminance_ToBase_FootCandle");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Microlux, 1d, 9.9999999999999995e-07d).SetName("Illuminance_ToBase_Microlux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Millilux, 1d, 0.001d).SetName("Illuminance_ToBase_Millilux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Megalux, 1d, 1000000.0d).SetName("Illuminance_ToBase_Megalux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareMeter, 1d, 1.0d).SetName("Illuminance_ToBase_LumenPerSquareMeter");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareFoot, 1d, 10.763910416709722d).SetName("Illuminance_ToBase_LumenPerSquareFoot");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareInch, 1d, 1550.0031000062002d).SetName("Illuminance_ToBase_LumenPerSquareInch");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Nox, 1d, 1000.0d).SetName("Illuminance_FromBase_Nox");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Lux, 1d, 1.0d).SetName("Illuminance_FromBase_Lux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Kilolux, 1d, 0.001d).SetName("Illuminance_FromBase_Kilolux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Phot, 1d, 0.0001d).SetName("Illuminance_FromBase_Phot");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.FootCandle, 1d, 0.092903040000000006d).SetName("Illuminance_FromBase_FootCandle");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Microlux, 1d, 1000000.0d).SetName("Illuminance_FromBase_Microlux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Millilux, 1d, 1000.0d).SetName("Illuminance_FromBase_Millilux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.Megalux, 1d, 9.9999999999999995e-07d).SetName("Illuminance_FromBase_Megalux");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareMeter, 1d, 1.0d).SetName("Illuminance_FromBase_LumenPerSquareMeter");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareFoot, 1d, 0.092903040000000006d).SetName("Illuminance_FromBase_LumenPerSquareFoot");
            yield return new TestCaseData(UnitToolsIlluminanceUnit.LumenPerSquareInch, 1d, 0.00064515999999999998d).SetName("Illuminance_FromBase_LumenPerSquareInch");
        }
    }
}
