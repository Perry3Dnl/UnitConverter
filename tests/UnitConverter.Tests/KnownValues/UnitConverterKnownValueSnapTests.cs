namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Snap;

    public sealed class UnitConverterKnownValueSnapTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Snap_ToBaseUnit_ReturnsExpectedValue(UnitConverterSnapUnit unit, double input, double expected)
        {
            double result = UnitConverterSnap.ToMeterPerSecondFourth(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Snap_FromBaseUnit_ReturnsExpectedValue(UnitConverterSnapUnit unit, double input, double expected)
        {
            double result = UnitConverterSnap.FromMeterPerSecondFourth(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Snap_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSnapUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSnap.ToMeterPerSecondFourth(input, unit);
            double result = UnitConverterSnap.FromMeterPerSecondFourth(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSnapUnit.MeterPerSecondFourth, 1d, 1.0d).SetName("Snap_ToBase_MeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.CentimeterPerSecondFourth, 1d, 0.01d).SetName("Snap_ToBase_CentimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.MillimeterPerSecondFourth, 1d, 0.001d).SetName("Snap_ToBase_MillimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.FootPerSecondFourth, 1d, 0.30480000000000002d).SetName("Snap_ToBase_FootPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.KilometerPerSecondFourth, 1d, 1000.0d).SetName("Snap_ToBase_KilometerPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.DecimeterPerSecondFourth, 1d, 0.10000000000000001d).SetName("Snap_ToBase_DecimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.MicrometerPerSecondFourth, 1d, 9.9999999999999995e-07d).SetName("Snap_ToBase_MicrometerPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.InchPerSecondFourth, 1d, 0.025399999999999999d).SetName("Snap_ToBase_InchPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.YardPerSecondFourth, 1d, 0.91439999999999999d).SetName("Snap_ToBase_YardPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.StandardGravityPerSecondSquared, 1d, 9.8066499999999994d).SetName("Snap_ToBase_StandardGravityPerSecondSquared");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSnapUnit.MeterPerSecondFourth, 1d, 1.0d).SetName("Snap_FromBase_MeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.CentimeterPerSecondFourth, 1d, 100.0d).SetName("Snap_FromBase_CentimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.MillimeterPerSecondFourth, 1d, 1000.0d).SetName("Snap_FromBase_MillimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.FootPerSecondFourth, 1d, 3.280839895013123d).SetName("Snap_FromBase_FootPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.KilometerPerSecondFourth, 1d, 0.001d).SetName("Snap_FromBase_KilometerPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.DecimeterPerSecondFourth, 1d, 10.0d).SetName("Snap_FromBase_DecimeterPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.MicrometerPerSecondFourth, 1d, 1000000.0d).SetName("Snap_FromBase_MicrometerPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.InchPerSecondFourth, 1d, 39.370078740157481d).SetName("Snap_FromBase_InchPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.YardPerSecondFourth, 1d, 1.0936132983377078d).SetName("Snap_FromBase_YardPerSecondFourth");
            yield return new TestCaseData(UnitConverterSnapUnit.StandardGravityPerSecondSquared, 1d, 0.10197162129779283d).SetName("Snap_FromBase_StandardGravityPerSecondSquared");
        }
    }
}
