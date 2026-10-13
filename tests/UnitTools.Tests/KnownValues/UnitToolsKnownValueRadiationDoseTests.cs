namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.RadiationDose;

    public sealed class UnitToolsKnownValueRadiationDoseTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationDose_ToBaseUnit_ReturnsExpectedValue(UnitToolsRadiationDoseUnit unit, double input, double expected)
        {
            double result = UnitToolsRadiationDose.ToGray(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void RadiationDose_FromBaseUnit_ReturnsExpectedValue(UnitToolsRadiationDoseUnit unit, double input, double expected)
        {
            double result = UnitToolsRadiationDose.FromGray(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationDose_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsRadiationDoseUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsRadiationDose.ToGray(input, unit);
            double result = UnitToolsRadiationDose.FromGray(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Nanogray, 1d, 1.0000000000000001e-09d).SetName("RadiationDose_ToBase_Nanogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Microgray, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_ToBase_Microgray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Milligray, 1d, 0.001d).SetName("RadiationDose_ToBase_Milligray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Gray, 1d, 1.0d).SetName("RadiationDose_ToBase_Gray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Rad, 1d, 0.01d).SetName("RadiationDose_ToBase_Rad");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Sievert, 1d, 1.0d).SetName("RadiationDose_ToBase_Sievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Millisievert, 1d, 0.001d).SetName("RadiationDose_ToBase_Millisievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Microsievert, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_ToBase_Microsievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Rem, 1d, 0.01d).SetName("RadiationDose_ToBase_Rem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Millirem, 1d, 1.0000000000000001e-05d).SetName("RadiationDose_ToBase_Millirem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Picogray, 1d, 9.9999999999999998e-13d).SetName("RadiationDose_ToBase_Picogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Centigray, 1d, 0.01d).SetName("RadiationDose_ToBase_Centigray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Kilogray, 1d, 1000.0d).SetName("RadiationDose_ToBase_Kilogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Megagray, 1d, 1000000.0d).SetName("RadiationDose_ToBase_Megagray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.RoentgenApprox, 1d, 0.00877d).SetName("RadiationDose_ToBase_RoentgenApprox");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.MilliroentgenApprox, 1d, 8.7700000000000007e-06d).SetName("RadiationDose_ToBase_MilliroentgenApprox");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Kilorem, 1d, 10.0d).SetName("RadiationDose_ToBase_Kilorem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.SievertPerGray, 1d, 1.0d).SetName("RadiationDose_ToBase_SievertPerGray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Decigray, 1d, 0.10000000000000001d).SetName("RadiationDose_ToBase_Decigray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Dekagray, 1d, 10.0d).SetName("RadiationDose_ToBase_Dekagray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Hectogray, 1d, 100.0d).SetName("RadiationDose_ToBase_Hectogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Nanosievert, 1d, 1.0000000000000001e-09d).SetName("RadiationDose_ToBase_Nanosievert");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Nanogray, 1d, 999999999.99999988d).SetName("RadiationDose_FromBase_Nanogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Microgray, 1d, 1000000.0d).SetName("RadiationDose_FromBase_Microgray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Milligray, 1d, 1000.0d).SetName("RadiationDose_FromBase_Milligray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Gray, 1d, 1.0d).SetName("RadiationDose_FromBase_Gray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Rad, 1d, 100.0d).SetName("RadiationDose_FromBase_Rad");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Sievert, 1d, 1.0d).SetName("RadiationDose_FromBase_Sievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Millisievert, 1d, 1000.0d).SetName("RadiationDose_FromBase_Millisievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Microsievert, 1d, 1000000.0d).SetName("RadiationDose_FromBase_Microsievert");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Rem, 1d, 100.0d).SetName("RadiationDose_FromBase_Rem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Millirem, 1d, 99999.999999999985d).SetName("RadiationDose_FromBase_Millirem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Picogray, 1d, 1000000000000.0d).SetName("RadiationDose_FromBase_Picogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Centigray, 1d, 100.0d).SetName("RadiationDose_FromBase_Centigray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Kilogray, 1d, 0.001d).SetName("RadiationDose_FromBase_Kilogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Megagray, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_FromBase_Megagray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.RoentgenApprox, 1d, 114.02508551881414d).SetName("RadiationDose_FromBase_RoentgenApprox");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.MilliroentgenApprox, 1d, 114025.08551881413d).SetName("RadiationDose_FromBase_MilliroentgenApprox");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Kilorem, 1d, 0.10000000000000001d).SetName("RadiationDose_FromBase_Kilorem");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.SievertPerGray, 1d, 1.0d).SetName("RadiationDose_FromBase_SievertPerGray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Decigray, 1d, 10.0d).SetName("RadiationDose_FromBase_Decigray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Dekagray, 1d, 0.10000000000000001d).SetName("RadiationDose_FromBase_Dekagray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Hectogray, 1d, 0.01d).SetName("RadiationDose_FromBase_Hectogray");
            yield return new TestCaseData(UnitToolsRadiationDoseUnit.Nanosievert, 1d, 999999999.99999988d).SetName("RadiationDose_FromBase_Nanosievert");
        }
    }
}
