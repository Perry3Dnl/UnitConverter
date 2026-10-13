namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Snap;

    public sealed class UnitToolsKnownValueSnapTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Snap_ToBaseUnit_ReturnsExpectedValue(UnitToolsSnapUnit unit, double input, double expected)
        {
            double result = UnitToolsSnap.ToMeterPerSecondFourth(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Snap_FromBaseUnit_ReturnsExpectedValue(UnitToolsSnapUnit unit, double input, double expected)
        {
            double result = UnitToolsSnap.FromMeterPerSecondFourth(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Snap_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsSnapUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsSnap.ToMeterPerSecondFourth(input, unit);
            double result = UnitToolsSnap.FromMeterPerSecondFourth(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsSnapUnit.MeterPerSecondFourth, 1d, 1.0d).SetName("Snap_ToBase_MeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.CentimeterPerSecondFourth, 1d, 0.01d).SetName("Snap_ToBase_CentimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.MillimeterPerSecondFourth, 1d, 0.001d).SetName("Snap_ToBase_MillimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.FootPerSecondFourth, 1d, 0.30480000000000002d).SetName("Snap_ToBase_FootPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.KilometerPerSecondFourth, 1d, 1000.0d).SetName("Snap_ToBase_KilometerPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.DecimeterPerSecondFourth, 1d, 0.10000000000000001d).SetName("Snap_ToBase_DecimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.MicrometerPerSecondFourth, 1d, 9.9999999999999995e-07d).SetName("Snap_ToBase_MicrometerPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.InchPerSecondFourth, 1d, 0.025399999999999999d).SetName("Snap_ToBase_InchPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.YardPerSecondFourth, 1d, 0.91439999999999999d).SetName("Snap_ToBase_YardPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.StandardGravityPerSecondSquared, 1d, 9.8066499999999994d).SetName("Snap_ToBase_StandardGravityPerSecondSquared");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsSnapUnit.MeterPerSecondFourth, 1d, 1.0d).SetName("Snap_FromBase_MeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.CentimeterPerSecondFourth, 1d, 100.0d).SetName("Snap_FromBase_CentimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.MillimeterPerSecondFourth, 1d, 1000.0d).SetName("Snap_FromBase_MillimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.FootPerSecondFourth, 1d, 3.280839895013123d).SetName("Snap_FromBase_FootPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.KilometerPerSecondFourth, 1d, 0.001d).SetName("Snap_FromBase_KilometerPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.DecimeterPerSecondFourth, 1d, 10.0d).SetName("Snap_FromBase_DecimeterPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.MicrometerPerSecondFourth, 1d, 1000000.0d).SetName("Snap_FromBase_MicrometerPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.InchPerSecondFourth, 1d, 39.370078740157481d).SetName("Snap_FromBase_InchPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.YardPerSecondFourth, 1d, 1.0936132983377078d).SetName("Snap_FromBase_YardPerSecondFourth");
            yield return new TestCaseData(UnitToolsSnapUnit.StandardGravityPerSecondSquared, 1d, 0.10197162129779283d).SetName("Snap_FromBase_StandardGravityPerSecondSquared");
        }
    }
}
