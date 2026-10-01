namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.DigitalStorage;

    public sealed class UnitConverterKnownValueDigitalStorageTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DigitalStorage_ToBaseUnit_ReturnsExpectedValue(UnitConverterDigitalStorageUnit unit, double input, double expected)
        {
            double result = UnitConverterDigitalStorage.ToByte(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DigitalStorage_FromBaseUnit_ReturnsExpectedValue(UnitConverterDigitalStorageUnit unit, double input, double expected)
        {
            double result = UnitConverterDigitalStorage.FromByte(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DigitalStorage_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterDigitalStorageUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterDigitalStorage.ToByte(input, unit);
            double result = UnitConverterDigitalStorage.FromByte(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Bit, 1d, 0.125d).SetName("DigitalStorage_ToBase_Bit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Nibble, 1d, 0.5d).SetName("DigitalStorage_ToBase_Nibble");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Byte, 1d, 1.0d).SetName("DigitalStorage_ToBase_Byte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kilobit, 1d, 125.0d).SetName("DigitalStorage_ToBase_Kilobit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kilobyte, 1d, 1000.0d).SetName("DigitalStorage_ToBase_Kilobyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Megabit, 1d, 125000.0d).SetName("DigitalStorage_ToBase_Megabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Megabyte, 1d, 1000000.0d).SetName("DigitalStorage_ToBase_Megabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gigabit, 1d, 125000000.0d).SetName("DigitalStorage_ToBase_Gigabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gigabyte, 1d, 1000000000.0d).SetName("DigitalStorage_ToBase_Gigabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Terabit, 1d, 125000000000.0d).SetName("DigitalStorage_ToBase_Terabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Terabyte, 1d, 1000000000000.0d).SetName("DigitalStorage_ToBase_Terabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Petabyte, 1d, 1000000000000000.0d).SetName("DigitalStorage_ToBase_Petabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kibibit, 1d, 128.0d).SetName("DigitalStorage_ToBase_Kibibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kibibyte, 1d, 1024.0d).SetName("DigitalStorage_ToBase_Kibibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Mebibit, 1d, 131072.0d).SetName("DigitalStorage_ToBase_Mebibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Mebibyte, 1d, 1048576.0d).SetName("DigitalStorage_ToBase_Mebibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gibibit, 1d, 134217728.0d).SetName("DigitalStorage_ToBase_Gibibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gibibyte, 1d, 1073741824.0d).SetName("DigitalStorage_ToBase_Gibibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Tebibyte, 1d, 1099511627776.0d).SetName("DigitalStorage_ToBase_Tebibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Pebibyte, 1d, 1125899906842624.0d).SetName("DigitalStorage_ToBase_Pebibyte");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Bit, 1d, 8.0d).SetName("DigitalStorage_FromBase_Bit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Nibble, 1d, 2.0d).SetName("DigitalStorage_FromBase_Nibble");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Byte, 1d, 1.0d).SetName("DigitalStorage_FromBase_Byte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kilobit, 1d, 0.0080000000000000002d).SetName("DigitalStorage_FromBase_Kilobit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kilobyte, 1d, 0.001d).SetName("DigitalStorage_FromBase_Kilobyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Megabit, 1d, 7.9999999999999996e-06d).SetName("DigitalStorage_FromBase_Megabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Megabyte, 1d, 9.9999999999999995e-07d).SetName("DigitalStorage_FromBase_Megabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gigabit, 1d, 8.0000000000000005e-09d).SetName("DigitalStorage_FromBase_Gigabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gigabyte, 1d, 1.0000000000000001e-09d).SetName("DigitalStorage_FromBase_Gigabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Terabit, 1d, 7.9999999999999998e-12d).SetName("DigitalStorage_FromBase_Terabit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Terabyte, 1d, 9.9999999999999998e-13d).SetName("DigitalStorage_FromBase_Terabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Petabyte, 1d, 1.0000000000000001e-15d).SetName("DigitalStorage_FromBase_Petabyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kibibit, 1d, 0.0078125d).SetName("DigitalStorage_FromBase_Kibibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Kibibyte, 1d, 0.0009765625d).SetName("DigitalStorage_FromBase_Kibibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Mebibit, 1d, 7.62939453125e-06d).SetName("DigitalStorage_FromBase_Mebibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Mebibyte, 1d, 9.5367431640625e-07d).SetName("DigitalStorage_FromBase_Mebibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gibibit, 1d, 7.4505805969238281e-09d).SetName("DigitalStorage_FromBase_Gibibit");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Gibibyte, 1d, 9.3132257461547852e-10d).SetName("DigitalStorage_FromBase_Gibibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Tebibyte, 1d, 9.0949470177292824e-13d).SetName("DigitalStorage_FromBase_Tebibyte");
            yield return new TestCaseData(UnitConverterDigitalStorageUnit.Pebibyte, 1d, 8.8817841970012523e-16d).SetName("DigitalStorage_FromBase_Pebibyte");
        }
    }
}
