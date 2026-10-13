namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Angle;

    public sealed class UnitToolsKnownValueAngleTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Angle_ToBaseUnit_ReturnsExpectedValue(UnitToolsAngleUnit unit, double input, double expected)
        {
            double result = UnitToolsAngle.ToDegree(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Angle_FromBaseUnit_ReturnsExpectedValue(UnitToolsAngleUnit unit, double input, double expected)
        {
            double result = UnitToolsAngle.FromDegree(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Angle_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsAngleUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsAngle.ToDegree(input, unit);
            double result = UnitToolsAngle.FromDegree(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsAngleUnit.Arcsecond, 1d, 0.00027777777777777778d).SetName("Angle_ToBase_Arcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.Arcminute, 1d, 0.016666666666666666d).SetName("Angle_ToBase_Arcminute");
            yield return new TestCaseData(UnitToolsAngleUnit.Degree, 1d, 1.0d).SetName("Angle_ToBase_Degree");
            yield return new TestCaseData(UnitToolsAngleUnit.Radian, 1d, 57.295779513082323d).SetName("Angle_ToBase_Radian");
            yield return new TestCaseData(UnitToolsAngleUnit.Milliradian, 1d, 0.057295779513082318d).SetName("Angle_ToBase_Milliradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Gradian, 1d, 0.90000000000000002d).SetName("Angle_ToBase_Gradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Turn, 1d, 360.0d).SetName("Angle_ToBase_Turn");
            yield return new TestCaseData(UnitToolsAngleUnit.Quadrant, 1d, 90.0d).SetName("Angle_ToBase_Quadrant");
            yield return new TestCaseData(UnitToolsAngleUnit.Microradian, 1d, 5.7295779513082317e-05d).SetName("Angle_ToBase_Microradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Nanoradian, 1d, 5.7295779513082331e-08d).SetName("Angle_ToBase_Nanoradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Milliarcsecond, 1d, 2.7777777777777776e-07d).SetName("Angle_ToBase_Milliarcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.Microarcsecond, 1d, 2.7777777777777777e-10d).SetName("Angle_ToBase_Microarcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.HourAngle, 1d, 15.0d).SetName("Angle_ToBase_HourAngle");
            yield return new TestCaseData(UnitToolsAngleUnit.MinuteOfTime, 1d, 0.25d).SetName("Angle_ToBase_MinuteOfTime");
            yield return new TestCaseData(UnitToolsAngleUnit.SecondOfTime, 1d, 0.0041666666666666666d).SetName("Angle_ToBase_SecondOfTime");
            yield return new TestCaseData(UnitToolsAngleUnit.NatoMil, 1d, 0.056250000000000001d).SetName("Angle_ToBase_NatoMil");
            yield return new TestCaseData(UnitToolsAngleUnit.ArtilleryMil, 1d, 0.059999999999999998d).SetName("Angle_ToBase_ArtilleryMil");
            yield return new TestCaseData(UnitToolsAngleUnit.BinaryDegree, 1d, 1.40625d).SetName("Angle_ToBase_BinaryDegree");
            yield return new TestCaseData(UnitToolsAngleUnit.Sextant, 1d, 60.0d).SetName("Angle_ToBase_Sextant");
            yield return new TestCaseData(UnitToolsAngleUnit.Sign, 1d, 30.0d).SetName("Angle_ToBase_Sign");
            yield return new TestCaseData(UnitToolsAngleUnit.CompassPoint, 1d, 11.25d).SetName("Angle_ToBase_CompassPoint");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsAngleUnit.Arcsecond, 1d, 3600.0d).SetName("Angle_FromBase_Arcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.Arcminute, 1d, 60.0d).SetName("Angle_FromBase_Arcminute");
            yield return new TestCaseData(UnitToolsAngleUnit.Degree, 1d, 1.0d).SetName("Angle_FromBase_Degree");
            yield return new TestCaseData(UnitToolsAngleUnit.Radian, 1d, 0.017453292519943295d).SetName("Angle_FromBase_Radian");
            yield return new TestCaseData(UnitToolsAngleUnit.Milliradian, 1d, 17.453292519943297d).SetName("Angle_FromBase_Milliradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Gradian, 1d, 1.1111111111111112d).SetName("Angle_FromBase_Gradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Turn, 1d, 0.0027777777777777779d).SetName("Angle_FromBase_Turn");
            yield return new TestCaseData(UnitToolsAngleUnit.Quadrant, 1d, 0.011111111111111112d).SetName("Angle_FromBase_Quadrant");
            yield return new TestCaseData(UnitToolsAngleUnit.Microradian, 1d, 17453.292519943298d).SetName("Angle_FromBase_Microradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Nanoradian, 1d, 17453292.519943293d).SetName("Angle_FromBase_Nanoradian");
            yield return new TestCaseData(UnitToolsAngleUnit.Milliarcsecond, 1d, 3600000.0000000005d).SetName("Angle_FromBase_Milliarcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.Microarcsecond, 1d, 3600000000.0d).SetName("Angle_FromBase_Microarcsecond");
            yield return new TestCaseData(UnitToolsAngleUnit.HourAngle, 1d, 0.066666666666666666d).SetName("Angle_FromBase_HourAngle");
            yield return new TestCaseData(UnitToolsAngleUnit.MinuteOfTime, 1d, 4.0d).SetName("Angle_FromBase_MinuteOfTime");
            yield return new TestCaseData(UnitToolsAngleUnit.SecondOfTime, 1d, 240.0d).SetName("Angle_FromBase_SecondOfTime");
            yield return new TestCaseData(UnitToolsAngleUnit.NatoMil, 1d, 17.777777777777779d).SetName("Angle_FromBase_NatoMil");
            yield return new TestCaseData(UnitToolsAngleUnit.ArtilleryMil, 1d, 16.666666666666668d).SetName("Angle_FromBase_ArtilleryMil");
            yield return new TestCaseData(UnitToolsAngleUnit.BinaryDegree, 1d, 0.71111111111111114d).SetName("Angle_FromBase_BinaryDegree");
            yield return new TestCaseData(UnitToolsAngleUnit.Sextant, 1d, 0.016666666666666666d).SetName("Angle_FromBase_Sextant");
            yield return new TestCaseData(UnitToolsAngleUnit.Sign, 1d, 0.033333333333333333d).SetName("Angle_FromBase_Sign");
            yield return new TestCaseData(UnitToolsAngleUnit.CompassPoint, 1d, 0.088888888888888892d).SetName("Angle_FromBase_CompassPoint");
        }
    }
}
