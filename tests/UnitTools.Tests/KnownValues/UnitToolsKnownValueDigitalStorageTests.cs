namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.DigitalStorage;

    public sealed class UnitToolsKnownValueDigitalStorageTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DigitalStorage_ToBaseUnit_ReturnsExpectedValue(UnitToolsDigitalStorageUnit unit, double input, double expected)
        {
            double result = UnitToolsDigitalStorage.ToByte(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DigitalStorage_FromBaseUnit_ReturnsExpectedValue(UnitToolsDigitalStorageUnit unit, double input, double expected)
        {
            double result = UnitToolsDigitalStorage.FromByte(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DigitalStorage_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsDigitalStorageUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsDigitalStorage.ToByte(input, unit);
            double result = UnitToolsDigitalStorage.FromByte(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Bit, 1d, 0.125d).SetName("DigitalStorage_ToBase_Bit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Nibble, 1d, 0.5d).SetName("DigitalStorage_ToBase_Nibble");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Byte, 1d, 1.0d).SetName("DigitalStorage_ToBase_Byte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kilobit, 1d, 125.0d).SetName("DigitalStorage_ToBase_Kilobit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kilobyte, 1d, 1000.0d).SetName("DigitalStorage_ToBase_Kilobyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Megabit, 1d, 125000.0d).SetName("DigitalStorage_ToBase_Megabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Megabyte, 1d, 1000000.0d).SetName("DigitalStorage_ToBase_Megabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gigabit, 1d, 125000000.0d).SetName("DigitalStorage_ToBase_Gigabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gigabyte, 1d, 1000000000.0d).SetName("DigitalStorage_ToBase_Gigabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Terabit, 1d, 125000000000.0d).SetName("DigitalStorage_ToBase_Terabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Terabyte, 1d, 1000000000000.0d).SetName("DigitalStorage_ToBase_Terabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Petabyte, 1d, 1000000000000000.0d).SetName("DigitalStorage_ToBase_Petabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kibibit, 1d, 128.0d).SetName("DigitalStorage_ToBase_Kibibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kibibyte, 1d, 1024.0d).SetName("DigitalStorage_ToBase_Kibibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Mebibit, 1d, 131072.0d).SetName("DigitalStorage_ToBase_Mebibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Mebibyte, 1d, 1048576.0d).SetName("DigitalStorage_ToBase_Mebibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gibibit, 1d, 134217728.0d).SetName("DigitalStorage_ToBase_Gibibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gibibyte, 1d, 1073741824.0d).SetName("DigitalStorage_ToBase_Gibibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Tebibyte, 1d, 1099511627776.0d).SetName("DigitalStorage_ToBase_Tebibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Pebibyte, 1d, 1125899906842624.0d).SetName("DigitalStorage_ToBase_Pebibyte");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Bit, 1d, 8.0d).SetName("DigitalStorage_FromBase_Bit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Nibble, 1d, 2.0d).SetName("DigitalStorage_FromBase_Nibble");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Byte, 1d, 1.0d).SetName("DigitalStorage_FromBase_Byte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kilobit, 1d, 0.0080000000000000002d).SetName("DigitalStorage_FromBase_Kilobit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kilobyte, 1d, 0.001d).SetName("DigitalStorage_FromBase_Kilobyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Megabit, 1d, 7.9999999999999996e-06d).SetName("DigitalStorage_FromBase_Megabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Megabyte, 1d, 9.9999999999999995e-07d).SetName("DigitalStorage_FromBase_Megabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gigabit, 1d, 8.0000000000000005e-09d).SetName("DigitalStorage_FromBase_Gigabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gigabyte, 1d, 1.0000000000000001e-09d).SetName("DigitalStorage_FromBase_Gigabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Terabit, 1d, 7.9999999999999998e-12d).SetName("DigitalStorage_FromBase_Terabit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Terabyte, 1d, 9.9999999999999998e-13d).SetName("DigitalStorage_FromBase_Terabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Petabyte, 1d, 1.0000000000000001e-15d).SetName("DigitalStorage_FromBase_Petabyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kibibit, 1d, 0.0078125d).SetName("DigitalStorage_FromBase_Kibibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Kibibyte, 1d, 0.0009765625d).SetName("DigitalStorage_FromBase_Kibibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Mebibit, 1d, 7.62939453125e-06d).SetName("DigitalStorage_FromBase_Mebibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Mebibyte, 1d, 9.5367431640625e-07d).SetName("DigitalStorage_FromBase_Mebibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gibibit, 1d, 7.4505805969238281e-09d).SetName("DigitalStorage_FromBase_Gibibit");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Gibibyte, 1d, 9.3132257461547852e-10d).SetName("DigitalStorage_FromBase_Gibibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Tebibyte, 1d, 9.0949470177292824e-13d).SetName("DigitalStorage_FromBase_Tebibyte");
            yield return new TestCaseData(UnitToolsDigitalStorageUnit.Pebibyte, 1d, 8.8817841970012523e-16d).SetName("DigitalStorage_FromBase_Pebibyte");
        }
    }
}
