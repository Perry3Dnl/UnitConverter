namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Jerk;

    public sealed class UnitToolsKnownValueJerkTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Jerk_ToBaseUnit_ReturnsExpectedValue(UnitToolsJerkUnit unit, double input, double expected)
        {
            double result = UnitToolsJerk.ToMeterPerSecondCubed(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Jerk_FromBaseUnit_ReturnsExpectedValue(UnitToolsJerkUnit unit, double input, double expected)
        {
            double result = UnitToolsJerk.FromMeterPerSecondCubed(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Jerk_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsJerkUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsJerk.ToMeterPerSecondCubed(input, unit);
            double result = UnitToolsJerk.FromMeterPerSecondCubed(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsJerkUnit.MeterPerSecondCubed, 1d, 1.0d).SetName("Jerk_ToBase_MeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.CentimeterPerSecondCubed, 1d, 0.01d).SetName("Jerk_ToBase_CentimeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.MillimeterPerSecondCubed, 1d, 0.001d).SetName("Jerk_ToBase_MillimeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.FootPerSecondCubed, 1d, 0.30480000000000002d).SetName("Jerk_ToBase_FootPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.StandardGravityPerSecond, 1d, 9.8066499999999994d).SetName("Jerk_ToBase_StandardGravityPerSecond");
            yield return new TestCaseData(UnitToolsJerkUnit.KilometerPerHourPerSecondSquared, 1d, 0.27777777777777779d).SetName("Jerk_ToBase_KilometerPerHourPerSecondSquared");
            yield return new TestCaseData(UnitToolsJerkUnit.MilePerHourPerSecondSquared, 1d, 0.44703999999999999d).SetName("Jerk_ToBase_MilePerHourPerSecondSquared");
            yield return new TestCaseData(UnitToolsJerkUnit.InchPerSecondCubed, 1d, 0.025399999999999999d).SetName("Jerk_ToBase_InchPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.YardPerSecondCubed, 1d, 0.91439999999999999d).SetName("Jerk_ToBase_YardPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.GalPerSecond, 1d, 0.01d).SetName("Jerk_ToBase_GalPerSecond");
            yield return new TestCaseData(UnitToolsJerkUnit.StandardGravityPerMinute, 1d, 0.16344416666666667d).SetName("Jerk_ToBase_StandardGravityPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsJerkUnit.MeterPerSecondCubed, 1d, 1.0d).SetName("Jerk_FromBase_MeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.CentimeterPerSecondCubed, 1d, 100.0d).SetName("Jerk_FromBase_CentimeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.MillimeterPerSecondCubed, 1d, 1000.0d).SetName("Jerk_FromBase_MillimeterPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.FootPerSecondCubed, 1d, 3.280839895013123d).SetName("Jerk_FromBase_FootPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.StandardGravityPerSecond, 1d, 0.10197162129779283d).SetName("Jerk_FromBase_StandardGravityPerSecond");
            yield return new TestCaseData(UnitToolsJerkUnit.KilometerPerHourPerSecondSquared, 1d, 3.5999999999999996d).SetName("Jerk_FromBase_KilometerPerHourPerSecondSquared");
            yield return new TestCaseData(UnitToolsJerkUnit.MilePerHourPerSecondSquared, 1d, 2.2369362920544025d).SetName("Jerk_FromBase_MilePerHourPerSecondSquared");
            yield return new TestCaseData(UnitToolsJerkUnit.InchPerSecondCubed, 1d, 39.370078740157481d).SetName("Jerk_FromBase_InchPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.YardPerSecondCubed, 1d, 1.0936132983377078d).SetName("Jerk_FromBase_YardPerSecondCubed");
            yield return new TestCaseData(UnitToolsJerkUnit.GalPerSecond, 1d, 100.0d).SetName("Jerk_FromBase_GalPerSecond");
            yield return new TestCaseData(UnitToolsJerkUnit.StandardGravityPerMinute, 1d, 6.1182972778675691d).SetName("Jerk_FromBase_StandardGravityPerMinute");
        }
    }
}
