namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Luminance;

    public sealed class UnitToolsKnownValueLuminanceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Luminance_ToBaseUnit_ReturnsExpectedValue(UnitToolsLuminanceUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminance.ToCandelaPerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Luminance_FromBaseUnit_ReturnsExpectedValue(UnitToolsLuminanceUnit unit, double input, double expected)
        {
            double result = UnitToolsLuminance.FromCandelaPerSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Luminance_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsLuminanceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsLuminance.ToCandelaPerSquareMeter(input, unit);
            double result = UnitToolsLuminance.FromCandelaPerSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareMeter, 1d, 1.0d).SetName("Luminance_ToBase_CandelaPerSquareMeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Nit, 1d, 1.0d).SetName("Luminance_ToBase_Nit");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Stilb, 1d, 10000.0d).SetName("Luminance_ToBase_Stilb");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Lambert, 1d, 3183.098861837907d).SetName("Luminance_ToBase_Lambert");
            yield return new TestCaseData(UnitToolsLuminanceUnit.FootLambert, 1d, 3.4262590999999998d).SetName("Luminance_ToBase_FootLambert");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Apostilb, 1d, 0.31830988618379069d).SetName("Luminance_ToBase_Apostilb");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareCentimeter, 1d, 10000.0d).SetName("Luminance_ToBase_CandelaPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareMillimeter, 1d, 1000000.0d).SetName("Luminance_ToBase_CandelaPerSquareMillimeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareFoot, 1d, 10.763910416709722d).SetName("Luminance_ToBase_CandelaPerSquareFoot");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareInch, 1d, 1550.0031000062002d).SetName("Luminance_ToBase_CandelaPerSquareInch");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Skot, 1d, 0.0003183098861837907d).SetName("Luminance_ToBase_Skot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareMeter, 1d, 1.0d).SetName("Luminance_FromBase_CandelaPerSquareMeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Nit, 1d, 1.0d).SetName("Luminance_FromBase_Nit");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Stilb, 1d, 0.0001d).SetName("Luminance_FromBase_Stilb");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Lambert, 1d, 0.00031415926535897931d).SetName("Luminance_FromBase_Lambert");
            yield return new TestCaseData(UnitToolsLuminanceUnit.FootLambert, 1d, 0.29186350792909971d).SetName("Luminance_FromBase_FootLambert");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Apostilb, 1d, 3.1415926535897931d).SetName("Luminance_FromBase_Apostilb");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareCentimeter, 1d, 0.0001d).SetName("Luminance_FromBase_CandelaPerSquareCentimeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("Luminance_FromBase_CandelaPerSquareMillimeter");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareFoot, 1d, 0.092903040000000006d).SetName("Luminance_FromBase_CandelaPerSquareFoot");
            yield return new TestCaseData(UnitToolsLuminanceUnit.CandelaPerSquareInch, 1d, 0.00064515999999999998d).SetName("Luminance_FromBase_CandelaPerSquareInch");
            yield return new TestCaseData(UnitToolsLuminanceUnit.Skot, 1d, 3141.5926535897929d).SetName("Luminance_FromBase_Skot");
        }
    }
}
