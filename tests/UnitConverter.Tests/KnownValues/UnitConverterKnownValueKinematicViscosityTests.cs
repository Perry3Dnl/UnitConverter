namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.KinematicViscosity;

    public sealed class UnitConverterKnownValueKinematicViscosityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void KinematicViscosity_ToBaseUnit_ReturnsExpectedValue(UnitConverterKinematicViscosityUnit unit, double input, double expected)
        {
            double result = UnitConverterKinematicViscosity.ToSquareMeterPerSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void KinematicViscosity_FromBaseUnit_ReturnsExpectedValue(UnitConverterKinematicViscosityUnit unit, double input, double expected)
        {
            double result = UnitConverterKinematicViscosity.FromSquareMeterPerSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void KinematicViscosity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterKinematicViscosityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterKinematicViscosity.ToSquareMeterPerSecond(input, unit);
            double result = UnitConverterKinematicViscosity.FromSquareMeterPerSecond(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("KinematicViscosity_ToBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond, 1d, 0.0001d).SetName("KinematicViscosity_ToBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("KinematicViscosity_ToBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Stokes, 1d, 0.0001d).SetName("KinematicViscosity_ToBase_Stokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Centistokes, 1d, 9.9999999999999995e-07d).SetName("KinematicViscosity_ToBase_Centistokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerSecond, 1d, 0.092903040000000006d).SetName("KinematicViscosity_ToBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerSecond, 1d, 0.00064515999999999998d).SetName("KinematicViscosity_ToBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerMinute, 1d, 0.016666666666666666d).SetName("KinematicViscosity_ToBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerHour, 1d, 0.00027777777777777778d).SetName("KinematicViscosity_ToBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute, 1d, 1.6666666666666667e-06d).SetName("KinematicViscosity_ToBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("KinematicViscosity_ToBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Millistokes, 1d, 9.9999999999999995e-08d).SetName("KinematicViscosity_ToBase_Millistokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Microstokes, 1d, 1e-10d).SetName("KinematicViscosity_ToBase_Microstokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerMinute, 1d, 0.0015483840000000001d).SetName("KinematicViscosity_ToBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerHour, 1d, 2.5806400000000001e-05d).SetName("KinematicViscosity_ToBase_SquareFootPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerMinute, 1d, 1.0752666666666666e-05d).SetName("KinematicViscosity_ToBase_SquareInchPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("KinematicViscosity_ToBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour, 1d, 2.7777777777777781e-08d).SetName("KinematicViscosity_ToBase_SquareCentimeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour, 1d, 2.7777777777777777e-10d).SetName("KinematicViscosity_ToBase_SquareMillimeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerHour, 1d, 1.7921111111111112e-07d).SetName("KinematicViscosity_ToBase_SquareInchPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareYardPerSecond, 1d, 0.83612735999999999d).SetName("KinematicViscosity_ToBase_SquareYardPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareYardPerMinute, 1d, 0.013935456000000001d).SetName("KinematicViscosity_ToBase_SquareYardPerMinute");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerSecond, 1d, 1.0d).SetName("KinematicViscosity_FromBase_SquareMeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond, 1d, 10000.0d).SetName("KinematicViscosity_FromBase_SquareCentimeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond, 1d, 1000000.0d).SetName("KinematicViscosity_FromBase_SquareMillimeterPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Stokes, 1d, 10000.0d).SetName("KinematicViscosity_FromBase_Stokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Centistokes, 1d, 1000000.0d).SetName("KinematicViscosity_FromBase_Centistokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerSecond, 1d, 10.763910416709722d).SetName("KinematicViscosity_FromBase_SquareFootPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerSecond, 1d, 1550.0031000062002d).SetName("KinematicViscosity_FromBase_SquareInchPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerMinute, 1d, 60.0d).SetName("KinematicViscosity_FromBase_SquareMeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerHour, 1d, 3600.0d).SetName("KinematicViscosity_FromBase_SquareMeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute, 1d, 600000.0d).SetName("KinematicViscosity_FromBase_SquareCentimeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute, 1d, 60000000.0d).SetName("KinematicViscosity_FromBase_SquareMillimeterPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Millistokes, 1d, 10000000.0d).SetName("KinematicViscosity_FromBase_Millistokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.Microstokes, 1d, 10000000000.0d).SetName("KinematicViscosity_FromBase_Microstokes");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerMinute, 1d, 645.83462500258327d).SetName("KinematicViscosity_FromBase_SquareFootPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareFootPerHour, 1d, 38750.077500154999d).SetName("KinematicViscosity_FromBase_SquareFootPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerMinute, 1d, 93000.186000372007d).SetName("KinematicViscosity_FromBase_SquareInchPerMinute");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMeterPerDay, 1d, 86400.0d).SetName("KinematicViscosity_FromBase_SquareMeterPerDay");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour, 1d, 36000000.0d).SetName("KinematicViscosity_FromBase_SquareCentimeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour, 1d, 3600000000.0d).SetName("KinematicViscosity_FromBase_SquareMillimeterPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareInchPerHour, 1d, 5580011.1600223202d).SetName("KinematicViscosity_FromBase_SquareInchPerHour");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareYardPerSecond, 1d, 1.1959900463010802d).SetName("KinematicViscosity_FromBase_SquareYardPerSecond");
            yield return new TestCaseData(UnitConverterKinematicViscosityUnit.SquareYardPerMinute, 1d, 71.75940277806481d).SetName("KinematicViscosity_FromBase_SquareYardPerMinute");
        }
    }
}
