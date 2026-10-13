namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Power;

    public sealed class UnitToolsKnownValuePowerTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Power_ToBaseUnit_ReturnsExpectedValue(UnitToolsPowerUnit unit, double input, double expected)
        {
            double result = UnitToolsPower.ToWatt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Power_FromBaseUnit_ReturnsExpectedValue(UnitToolsPowerUnit unit, double input, double expected)
        {
            double result = UnitToolsPower.FromWatt(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Power_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsPowerUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsPower.ToWatt(input, unit);
            double result = UnitToolsPower.FromWatt(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsPowerUnit.Microwatt, 1d, 9.9999999999999995e-07d).SetName("Power_ToBase_Microwatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Milliwatt, 1d, 0.001d).SetName("Power_ToBase_Milliwatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Watt, 1d, 1.0d).SetName("Power_ToBase_Watt");
            yield return new TestCaseData(UnitToolsPowerUnit.Kilowatt, 1d, 1000.0d).SetName("Power_ToBase_Kilowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Megawatt, 1d, 1000000.0d).SetName("Power_ToBase_Megawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Gigawatt, 1d, 1000000000.0d).SetName("Power_ToBase_Gigawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerMechanical, 1d, 745.69987158227025d).SetName("Power_ToBase_HorsepowerMechanical");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerMetric, 1d, 735.49874999999997d).SetName("Power_ToBase_HorsepowerMetric");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerElectrical, 1d, 746.0d).SetName("Power_ToBase_HorsepowerElectrical");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerBoiler, 1d, 9809.5d).SetName("Power_ToBase_HorsepowerBoiler");
            yield return new TestCaseData(UnitToolsPowerUnit.BtuPerHour, 1d, 0.29307107017222223d).SetName("Power_ToBase_BtuPerHour");
            yield return new TestCaseData(UnitToolsPowerUnit.FootPoundPerSecond, 1d, 1.3558179483314003d).SetName("Power_ToBase_FootPoundPerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.Picowatt, 1d, 9.9999999999999998e-13d).SetName("Power_ToBase_Picowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Nanowatt, 1d, 1.0000000000000001e-09d).SetName("Power_ToBase_Nanowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Terawatt, 1d, 1000000000000.0d).SetName("Power_ToBase_Terawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Petawatt, 1d, 1000000000000000.0d).SetName("Power_ToBase_Petawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.ErgPerSecond, 1d, 9.9999999999999995e-08d).SetName("Power_ToBase_ErgPerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.CaloriePerSecond, 1d, 4.1840000000000002d).SetName("Power_ToBase_CaloriePerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.KilocaloriePerHour, 1d, 1.1622222222222223d).SetName("Power_ToBase_KilocaloriePerHour");
            yield return new TestCaseData(UnitToolsPowerUnit.TonOfRefrigeration, 1d, 3516.8528420666998d).SetName("Power_ToBase_TonOfRefrigeration");
            yield return new TestCaseData(UnitToolsPowerUnit.VoltAmpere, 1d, 1.0d).SetName("Power_ToBase_VoltAmpere");
            yield return new TestCaseData(UnitToolsPowerUnit.KilovoltAmpere, 1d, 1000.0d).SetName("Power_ToBase_KilovoltAmpere");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsPowerUnit.Microwatt, 1d, 1000000.0d).SetName("Power_FromBase_Microwatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Milliwatt, 1d, 1000.0d).SetName("Power_FromBase_Milliwatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Watt, 1d, 1.0d).SetName("Power_FromBase_Watt");
            yield return new TestCaseData(UnitToolsPowerUnit.Kilowatt, 1d, 0.001d).SetName("Power_FromBase_Kilowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Megawatt, 1d, 9.9999999999999995e-07d).SetName("Power_FromBase_Megawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Gigawatt, 1d, 1.0000000000000001e-09d).SetName("Power_FromBase_Gigawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerMechanical, 1d, 0.0013410220895950279d).SetName("Power_FromBase_HorsepowerMechanical");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerMetric, 1d, 0.0013596216173039043d).SetName("Power_FromBase_HorsepowerMetric");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerElectrical, 1d, 0.0013404825737265416d).SetName("Power_FromBase_HorsepowerElectrical");
            yield return new TestCaseData(UnitToolsPowerUnit.HorsepowerBoiler, 1d, 0.00010194199500484225d).SetName("Power_FromBase_HorsepowerBoiler");
            yield return new TestCaseData(UnitToolsPowerUnit.BtuPerHour, 1d, 3.4121416331279417d).SetName("Power_FromBase_BtuPerHour");
            yield return new TestCaseData(UnitToolsPowerUnit.FootPoundPerSecond, 1d, 0.73756214927726538d).SetName("Power_FromBase_FootPoundPerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.Picowatt, 1d, 1000000000000.0d).SetName("Power_FromBase_Picowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Nanowatt, 1d, 999999999.99999988d).SetName("Power_FromBase_Nanowatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Terawatt, 1d, 9.9999999999999998e-13d).SetName("Power_FromBase_Terawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.Petawatt, 1d, 1.0000000000000001e-15d).SetName("Power_FromBase_Petawatt");
            yield return new TestCaseData(UnitToolsPowerUnit.ErgPerSecond, 1d, 10000000.0d).SetName("Power_FromBase_ErgPerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.CaloriePerSecond, 1d, 0.23900573613766729d).SetName("Power_FromBase_CaloriePerSecond");
            yield return new TestCaseData(UnitToolsPowerUnit.KilocaloriePerHour, 1d, 0.86042065009560231d).SetName("Power_FromBase_KilocaloriePerHour");
            yield return new TestCaseData(UnitToolsPowerUnit.TonOfRefrigeration, 1d, 0.0002843451360939925d).SetName("Power_FromBase_TonOfRefrigeration");
            yield return new TestCaseData(UnitToolsPowerUnit.VoltAmpere, 1d, 1.0d).SetName("Power_FromBase_VoltAmpere");
            yield return new TestCaseData(UnitToolsPowerUnit.KilovoltAmpere, 1d, 0.001d).SetName("Power_FromBase_KilovoltAmpere");
        }
    }
}
