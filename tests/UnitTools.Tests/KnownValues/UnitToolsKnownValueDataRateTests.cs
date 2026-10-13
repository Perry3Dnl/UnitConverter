namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.DataRate;

    public sealed class UnitToolsKnownValueDataRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DataRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsDataRateUnit unit, double input, double expected)
        {
            double result = UnitToolsDataRate.ToBitPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DataRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsDataRateUnit unit, double input, double expected)
        {
            double result = UnitToolsDataRate.FromBitPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DataRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsDataRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsDataRate.ToBitPerSecond(input, unit);
            double result = UnitToolsDataRate.FromBitPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsDataRateUnit.BitPerSecond, 1d, 1.0d).SetName("DataRate_ToBase_BitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.BytePerSecond, 1d, 8.0d).SetName("DataRate_ToBase_BytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KilobitPerSecond, 1d, 1000.0d).SetName("DataRate_ToBase_KilobitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KilobytePerSecond, 1d, 8000.0d).SetName("DataRate_ToBase_KilobytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MegabitPerSecond, 1d, 1000000.0d).SetName("DataRate_ToBase_MegabitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MegabytePerSecond, 1d, 8000000.0d).SetName("DataRate_ToBase_MegabytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GigabitPerSecond, 1d, 1000000000.0d).SetName("DataRate_ToBase_GigabitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GigabytePerSecond, 1d, 8000000000.0d).SetName("DataRate_ToBase_GigabytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KibibitPerSecond, 1d, 1024.0d).SetName("DataRate_ToBase_KibibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KibibytePerSecond, 1d, 8192.0d).SetName("DataRate_ToBase_KibibytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MebibitPerSecond, 1d, 1048576.0d).SetName("DataRate_ToBase_MebibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MebibytePerSecond, 1d, 8388608.0d).SetName("DataRate_ToBase_MebibytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GibibitPerSecond, 1d, 1073741824.0d).SetName("DataRate_ToBase_GibibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GibibytePerSecond, 1d, 8589934592.0d).SetName("DataRate_ToBase_GibibytePerSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsDataRateUnit.BitPerSecond, 1d, 1.0d).SetName("DataRate_FromBase_BitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.BytePerSecond, 1d, 0.125d).SetName("DataRate_FromBase_BytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KilobitPerSecond, 1d, 0.001d).SetName("DataRate_FromBase_KilobitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KilobytePerSecond, 1d, 0.000125d).SetName("DataRate_FromBase_KilobytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MegabitPerSecond, 1d, 9.9999999999999995e-07d).SetName("DataRate_FromBase_MegabitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MegabytePerSecond, 1d, 1.2499999999999999e-07d).SetName("DataRate_FromBase_MegabytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GigabitPerSecond, 1d, 1.0000000000000001e-09d).SetName("DataRate_FromBase_GigabitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GigabytePerSecond, 1d, 1.2500000000000001e-10d).SetName("DataRate_FromBase_GigabytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KibibitPerSecond, 1d, 0.0009765625d).SetName("DataRate_FromBase_KibibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.KibibytePerSecond, 1d, 0.0001220703125d).SetName("DataRate_FromBase_KibibytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MebibitPerSecond, 1d, 9.5367431640625e-07d).SetName("DataRate_FromBase_MebibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.MebibytePerSecond, 1d, 1.1920928955078125e-07d).SetName("DataRate_FromBase_MebibytePerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GibibitPerSecond, 1d, 9.3132257461547852e-10d).SetName("DataRate_FromBase_GibibitPerSecond");
            yield return new TestCaseData(UnitToolsDataRateUnit.GibibytePerSecond, 1d, 1.1641532182693481e-10d).SetName("DataRate_FromBase_GibibytePerSecond");
        }
    }
}
