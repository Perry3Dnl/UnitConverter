namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.RadiationDose;

    public sealed class UnitConverterKnownValueRadiationDoseTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationDose_ToBaseUnit_ReturnsExpectedValue(UnitConverterRadiationDoseUnit unit, double input, double expected)
        {
            double result = UnitConverterRadiationDose.ToGray(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void RadiationDose_FromBaseUnit_ReturnsExpectedValue(UnitConverterRadiationDoseUnit unit, double input, double expected)
        {
            double result = UnitConverterRadiationDose.FromGray(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationDose_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterRadiationDoseUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterRadiationDose.ToGray(input, unit);
            double result = UnitConverterRadiationDose.FromGray(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Nanogray, 1d, 1.0000000000000001e-09d).SetName("RadiationDose_ToBase_Nanogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Microgray, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_ToBase_Microgray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Milligray, 1d, 0.001d).SetName("RadiationDose_ToBase_Milligray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Gray, 1d, 1.0d).SetName("RadiationDose_ToBase_Gray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Rad, 1d, 0.01d).SetName("RadiationDose_ToBase_Rad");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Sievert, 1d, 1.0d).SetName("RadiationDose_ToBase_Sievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Millisievert, 1d, 0.001d).SetName("RadiationDose_ToBase_Millisievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Microsievert, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_ToBase_Microsievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Rem, 1d, 0.01d).SetName("RadiationDose_ToBase_Rem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Millirem, 1d, 1.0000000000000001e-05d).SetName("RadiationDose_ToBase_Millirem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Picogray, 1d, 9.9999999999999998e-13d).SetName("RadiationDose_ToBase_Picogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Centigray, 1d, 0.01d).SetName("RadiationDose_ToBase_Centigray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Kilogray, 1d, 1000.0d).SetName("RadiationDose_ToBase_Kilogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Megagray, 1d, 1000000.0d).SetName("RadiationDose_ToBase_Megagray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.RoentgenApprox, 1d, 0.00877d).SetName("RadiationDose_ToBase_RoentgenApprox");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.MilliroentgenApprox, 1d, 8.7700000000000007e-06d).SetName("RadiationDose_ToBase_MilliroentgenApprox");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Kilorem, 1d, 10.0d).SetName("RadiationDose_ToBase_Kilorem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.SievertPerGray, 1d, 1.0d).SetName("RadiationDose_ToBase_SievertPerGray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Decigray, 1d, 0.10000000000000001d).SetName("RadiationDose_ToBase_Decigray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Dekagray, 1d, 10.0d).SetName("RadiationDose_ToBase_Dekagray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Hectogray, 1d, 100.0d).SetName("RadiationDose_ToBase_Hectogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Nanosievert, 1d, 1.0000000000000001e-09d).SetName("RadiationDose_ToBase_Nanosievert");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Nanogray, 1d, 999999999.99999988d).SetName("RadiationDose_FromBase_Nanogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Microgray, 1d, 1000000.0d).SetName("RadiationDose_FromBase_Microgray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Milligray, 1d, 1000.0d).SetName("RadiationDose_FromBase_Milligray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Gray, 1d, 1.0d).SetName("RadiationDose_FromBase_Gray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Rad, 1d, 100.0d).SetName("RadiationDose_FromBase_Rad");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Sievert, 1d, 1.0d).SetName("RadiationDose_FromBase_Sievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Millisievert, 1d, 1000.0d).SetName("RadiationDose_FromBase_Millisievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Microsievert, 1d, 1000000.0d).SetName("RadiationDose_FromBase_Microsievert");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Rem, 1d, 100.0d).SetName("RadiationDose_FromBase_Rem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Millirem, 1d, 99999.999999999985d).SetName("RadiationDose_FromBase_Millirem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Picogray, 1d, 1000000000000.0d).SetName("RadiationDose_FromBase_Picogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Centigray, 1d, 100.0d).SetName("RadiationDose_FromBase_Centigray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Kilogray, 1d, 0.001d).SetName("RadiationDose_FromBase_Kilogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Megagray, 1d, 9.9999999999999995e-07d).SetName("RadiationDose_FromBase_Megagray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.RoentgenApprox, 1d, 114.02508551881414d).SetName("RadiationDose_FromBase_RoentgenApprox");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.MilliroentgenApprox, 1d, 114025.08551881413d).SetName("RadiationDose_FromBase_MilliroentgenApprox");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Kilorem, 1d, 0.10000000000000001d).SetName("RadiationDose_FromBase_Kilorem");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.SievertPerGray, 1d, 1.0d).SetName("RadiationDose_FromBase_SievertPerGray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Decigray, 1d, 10.0d).SetName("RadiationDose_FromBase_Decigray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Dekagray, 1d, 0.10000000000000001d).SetName("RadiationDose_FromBase_Dekagray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Hectogray, 1d, 0.01d).SetName("RadiationDose_FromBase_Hectogray");
            yield return new TestCaseData(UnitConverterRadiationDoseUnit.Nanosievert, 1d, 999999999.99999988d).SetName("RadiationDose_FromBase_Nanosievert");
        }
    }
}
