namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.SpecificVolume;

    public sealed class UnitConverterKnownValueSpecificVolumeTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificVolume_ToBaseUnit_ReturnsExpectedValue(UnitConverterSpecificVolumeUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificVolume.ToCubicMeterPerKilogram(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SpecificVolume_FromBaseUnit_ReturnsExpectedValue(UnitConverterSpecificVolumeUnit unit, double input, double expected)
        {
            double result = UnitConverterSpecificVolume.FromCubicMeterPerKilogram(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SpecificVolume_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSpecificVolumeUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSpecificVolume.ToCubicMeterPerKilogram(input, unit);
            double result = UnitConverterSpecificVolume.FromCubicMeterPerKilogram(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram, 1d, 1.0d).SetName("SpecificVolume_ToBase_CubicMeterPerKilogram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.LiterPerKilogram, 1d, 0.001d).SetName("SpecificVolume_ToBase_LiterPerKilogram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.MilliliterPerGram, 1d, 0.001d).SetName("SpecificVolume_ToBase_MilliliterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram, 1d, 0.001d).SetName("SpecificVolume_ToBase_CubicCentimeterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicFootPerPound, 1d, 0.062427960576144609d).SetName("SpecificVolume_ToBase_CubicFootPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicInchPerPound, 1d, 3.6127292000083687e-05d).SetName("SpecificVolume_ToBase_CubicInchPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerGram, 1d, 1000.0d).SetName("SpecificVolume_ToBase_CubicMeterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerTonne, 1d, 0.001d).SetName("SpecificVolume_ToBase_CubicMeterPerTonne");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.LiterPerGram, 1d, 1.0d).SetName("SpecificVolume_ToBase_LiterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicYardPerPound, 1d, 1.6855549355559045d).SetName("SpecificVolume_ToBase_CubicYardPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicFootPerSlug, 1d, 0.0019403203316082902d).SetName("SpecificVolume_ToBase_CubicFootPerSlug");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram, 1d, 1.0d).SetName("SpecificVolume_FromBase_CubicMeterPerKilogram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.LiterPerKilogram, 1d, 1000.0d).SetName("SpecificVolume_FromBase_LiterPerKilogram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.MilliliterPerGram, 1d, 1000.0d).SetName("SpecificVolume_FromBase_MilliliterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram, 1d, 1000.0d).SetName("SpecificVolume_FromBase_CubicCentimeterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicFootPerPound, 1d, 16.018463373960142d).SetName("SpecificVolume_FromBase_CubicFootPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicInchPerPound, 1d, 27679.904710203122d).SetName("SpecificVolume_FromBase_CubicInchPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerGram, 1d, 0.001d).SetName("SpecificVolume_FromBase_CubicMeterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicMeterPerTonne, 1d, 1000.0d).SetName("SpecificVolume_FromBase_CubicMeterPerTonne");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.LiterPerGram, 1d, 1.0d).SetName("SpecificVolume_FromBase_LiterPerGram");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicYardPerPound, 1d, 0.5932764212577829d).SetName("SpecificVolume_FromBase_CubicYardPerPound");
            yield return new TestCaseData(UnitConverterSpecificVolumeUnit.CubicFootPerSlug, 1d, 515.37881849185248d).SetName("SpecificVolume_FromBase_CubicFootPerSlug");
        }
    }
}
