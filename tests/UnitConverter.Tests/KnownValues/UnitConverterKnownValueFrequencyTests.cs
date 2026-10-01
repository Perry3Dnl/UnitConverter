namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Frequency;

    public sealed class UnitConverterKnownValueFrequencyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Frequency_ToBaseUnit_ReturnsExpectedValue(UnitConverterFrequencyUnit unit, double input, double expected)
        {
            double result = UnitConverterFrequency.ToHertz(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Frequency_FromBaseUnit_ReturnsExpectedValue(UnitConverterFrequencyUnit unit, double input, double expected)
        {
            double result = UnitConverterFrequency.FromHertz(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Frequency_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterFrequencyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterFrequency.ToHertz(input, unit);
            double result = UnitConverterFrequency.FromHertz(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterFrequencyUnit.Millihertz, 1d, 0.001d).SetName("Frequency_ToBase_Millihertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Hertz, 1d, 1.0d).SetName("Frequency_ToBase_Hertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Kilohertz, 1d, 1000.0d).SetName("Frequency_ToBase_Kilohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Megahertz, 1d, 1000000.0d).SetName("Frequency_ToBase_Megahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Gigahertz, 1d, 1000000000.0d).SetName("Frequency_ToBase_Gigahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Terahertz, 1d, 1000000000000.0d).SetName("Frequency_ToBase_Terahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.RevolutionsPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_RevolutionsPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.BeatsPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_BeatsPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Picohertz, 1d, 9.9999999999999998e-13d).SetName("Frequency_ToBase_Picohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Nanohertz, 1d, 1.0000000000000001e-09d).SetName("Frequency_ToBase_Nanohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Microhertz, 1d, 9.9999999999999995e-07d).SetName("Frequency_ToBase_Microhertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Petahertz, 1d, 1000000000000000.0d).SetName("Frequency_ToBase_Petahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Exahertz, 1d, 1e+18d).SetName("Frequency_ToBase_Exahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.FramesPerSecond, 1d, 1.0d).SetName("Frequency_ToBase_FramesPerSecond");
            yield return new TestCaseData(UnitConverterFrequencyUnit.CyclesPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_CyclesPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.RadianPerSecondAsFrequency, 1d, 0.15915494309189535d).SetName("Frequency_ToBase_RadianPerSecondAsFrequency");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterFrequencyUnit.Millihertz, 1d, 1000.0d).SetName("Frequency_FromBase_Millihertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Hertz, 1d, 1.0d).SetName("Frequency_FromBase_Hertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Kilohertz, 1d, 0.001d).SetName("Frequency_FromBase_Kilohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Megahertz, 1d, 9.9999999999999995e-07d).SetName("Frequency_FromBase_Megahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Gigahertz, 1d, 1.0000000000000001e-09d).SetName("Frequency_FromBase_Gigahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Terahertz, 1d, 9.9999999999999998e-13d).SetName("Frequency_FromBase_Terahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.RevolutionsPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_RevolutionsPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.BeatsPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_BeatsPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Picohertz, 1d, 1000000000000.0d).SetName("Frequency_FromBase_Picohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Nanohertz, 1d, 999999999.99999988d).SetName("Frequency_FromBase_Nanohertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Microhertz, 1d, 1000000.0d).SetName("Frequency_FromBase_Microhertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Petahertz, 1d, 1.0000000000000001e-15d).SetName("Frequency_FromBase_Petahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.Exahertz, 1d, 1.0000000000000001e-18d).SetName("Frequency_FromBase_Exahertz");
            yield return new TestCaseData(UnitConverterFrequencyUnit.FramesPerSecond, 1d, 1.0d).SetName("Frequency_FromBase_FramesPerSecond");
            yield return new TestCaseData(UnitConverterFrequencyUnit.CyclesPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_CyclesPerMinute");
            yield return new TestCaseData(UnitConverterFrequencyUnit.RadianPerSecondAsFrequency, 1d, 6.2831853071795862d).SetName("Frequency_FromBase_RadianPerSecondAsFrequency");
        }
    }
}
