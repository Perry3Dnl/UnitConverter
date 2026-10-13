namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Frequency;

    public sealed class UnitToolsKnownValueFrequencyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Frequency_ToBaseUnit_ReturnsExpectedValue(UnitToolsFrequencyUnit unit, double input, double expected)
        {
            double result = UnitToolsFrequency.ToHertz(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Frequency_FromBaseUnit_ReturnsExpectedValue(UnitToolsFrequencyUnit unit, double input, double expected)
        {
            double result = UnitToolsFrequency.FromHertz(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Frequency_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsFrequencyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsFrequency.ToHertz(input, unit);
            double result = UnitToolsFrequency.FromHertz(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsFrequencyUnit.Millihertz, 1d, 0.001d).SetName("Frequency_ToBase_Millihertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Hertz, 1d, 1.0d).SetName("Frequency_ToBase_Hertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Kilohertz, 1d, 1000.0d).SetName("Frequency_ToBase_Kilohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Megahertz, 1d, 1000000.0d).SetName("Frequency_ToBase_Megahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Gigahertz, 1d, 1000000000.0d).SetName("Frequency_ToBase_Gigahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Terahertz, 1d, 1000000000000.0d).SetName("Frequency_ToBase_Terahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.RevolutionsPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_RevolutionsPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.BeatsPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_BeatsPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Picohertz, 1d, 9.9999999999999998e-13d).SetName("Frequency_ToBase_Picohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Nanohertz, 1d, 1.0000000000000001e-09d).SetName("Frequency_ToBase_Nanohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Microhertz, 1d, 9.9999999999999995e-07d).SetName("Frequency_ToBase_Microhertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Petahertz, 1d, 1000000000000000.0d).SetName("Frequency_ToBase_Petahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Exahertz, 1d, 1e+18d).SetName("Frequency_ToBase_Exahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.FramesPerSecond, 1d, 1.0d).SetName("Frequency_ToBase_FramesPerSecond");
            yield return new TestCaseData(UnitToolsFrequencyUnit.CyclesPerMinute, 1d, 0.016666666666666666d).SetName("Frequency_ToBase_CyclesPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.RadianPerSecondAsFrequency, 1d, 0.15915494309189535d).SetName("Frequency_ToBase_RadianPerSecondAsFrequency");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsFrequencyUnit.Millihertz, 1d, 1000.0d).SetName("Frequency_FromBase_Millihertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Hertz, 1d, 1.0d).SetName("Frequency_FromBase_Hertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Kilohertz, 1d, 0.001d).SetName("Frequency_FromBase_Kilohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Megahertz, 1d, 9.9999999999999995e-07d).SetName("Frequency_FromBase_Megahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Gigahertz, 1d, 1.0000000000000001e-09d).SetName("Frequency_FromBase_Gigahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Terahertz, 1d, 9.9999999999999998e-13d).SetName("Frequency_FromBase_Terahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.RevolutionsPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_RevolutionsPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.BeatsPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_BeatsPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Picohertz, 1d, 1000000000000.0d).SetName("Frequency_FromBase_Picohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Nanohertz, 1d, 999999999.99999988d).SetName("Frequency_FromBase_Nanohertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Microhertz, 1d, 1000000.0d).SetName("Frequency_FromBase_Microhertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Petahertz, 1d, 1.0000000000000001e-15d).SetName("Frequency_FromBase_Petahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.Exahertz, 1d, 1.0000000000000001e-18d).SetName("Frequency_FromBase_Exahertz");
            yield return new TestCaseData(UnitToolsFrequencyUnit.FramesPerSecond, 1d, 1.0d).SetName("Frequency_FromBase_FramesPerSecond");
            yield return new TestCaseData(UnitToolsFrequencyUnit.CyclesPerMinute, 1d, 60.0d).SetName("Frequency_FromBase_CyclesPerMinute");
            yield return new TestCaseData(UnitToolsFrequencyUnit.RadianPerSecondAsFrequency, 1d, 6.2831853071795862d).SetName("Frequency_FromBase_RadianPerSecondAsFrequency");
        }
    }
}
