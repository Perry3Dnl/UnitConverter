namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.VolumetricFlowRate;

    public sealed class UnitToolsKnownValueVolumetricFlowRateTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void VolumetricFlowRate_ToBaseUnit_ReturnsExpectedValue(UnitToolsVolumetricFlowRateUnit unit, double input, double expected)
        {
            double result = UnitToolsVolumetricFlowRate.ToCubicMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void VolumetricFlowRate_FromBaseUnit_ReturnsExpectedValue(UnitToolsVolumetricFlowRateUnit unit, double input, double expected)
        {
            double result = UnitToolsVolumetricFlowRate.FromCubicMeterPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void VolumetricFlowRate_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsVolumetricFlowRateUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsVolumetricFlowRate.ToCubicMeterPerSecond(input, unit);
            double result = UnitToolsVolumetricFlowRate.FromCubicMeterPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond, 1d, 1.0d).SetName("VolumetricFlowRate_ToBase_CubicMeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute, 1d, 0.016666666666666666d).SetName("VolumetricFlowRate_ToBase_CubicMeterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour, 1d, 0.00027777777777777778d).SetName("VolumetricFlowRate_ToBase_CubicMeterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerSecond, 1d, 0.001d).SetName("VolumetricFlowRate_ToBase_LiterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerMinute, 1d, 1.6666666666666667e-05d).SetName("VolumetricFlowRate_ToBase_LiterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerHour, 1d, 2.7777777777777776e-07d).SetName("VolumetricFlowRate_ToBase_LiterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond, 1d, 9.9999999999999995e-07d).SetName("VolumetricFlowRate_ToBase_MilliliterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerMinute, 1d, 6.3090196400000003e-05d).SetName("VolumetricFlowRate_ToBase_USGallonPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerHour, 1d, 1.0515032733333334e-06d).SetName("VolumetricFlowRate_ToBase_USGallonPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute, 1d, 7.5768166666666671e-05d).SetName("VolumetricFlowRate_ToBase_ImperialGallonPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond, 1d, 0.028316846592000001d).SetName("VolumetricFlowRate_ToBase_CubicFootPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute, 1d, 0.00047194744319999999d).SetName("VolumetricFlowRate_ToBase_CubicFootPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond, 1d, 9.9999999999999995e-07d).SetName("VolumetricFlowRate_ToBase_CubicCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute, 1d, 1.6666666666666667e-08d).SetName("VolumetricFlowRate_ToBase_CubicCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute, 1d, 1.6666666666666667e-08d).SetName("VolumetricFlowRate_ToBase_MilliliterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerHour, 1d, 2.7777777777777777e-10d).SetName("VolumetricFlowRate_ToBase_MilliliterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerDay, 1d, 1.1574074074074074e-08d).SetName("VolumetricFlowRate_ToBase_LiterPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerHour, 1d, 7.8657907200000004e-06d).SetName("VolumetricFlowRate_ToBase_CubicFootPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond, 1d, 1.6387063999999999e-05d).SetName("VolumetricFlowRate_ToBase_CubicInchPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute, 1d, 2.7311773333333333e-07d).SetName("VolumetricFlowRate_ToBase_CubicInchPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerSecond, 1d, 0.0037854117840000001d).SetName("VolumetricFlowRate_ToBase_USGallonPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerDay, 1d, 4.3812636388888893e-08d).SetName("VolumetricFlowRate_ToBase_USGallonPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond, 1d, 0.00454609d).SetName("VolumetricFlowRate_ToBase_ImperialGallonPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour, 1d, 1.2628027777777779e-06d).SetName("VolumetricFlowRate_ToBase_ImperialGallonPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay, 1d, 1.8401307283333336e-06d).SetName("VolumetricFlowRate_ToBase_OilBarrelPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour, 1d, 4.4163137480000004e-05d).SetName("VolumetricFlowRate_ToBase_OilBarrelPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.AcreFootPerDay, 1d, 0.0142764101568d).SetName("VolumetricFlowRate_ToBase_AcreFootPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay, 1d, 0.043812636388888888d).SetName("VolumetricFlowRate_ToBase_MillionUSGallonsPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay, 1d, 1.1574074074074073e-05d).SetName("VolumetricFlowRate_ToBase_CubicMeterPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour, 1d, 2.7777777777777777e-10d).SetName("VolumetricFlowRate_ToBase_CubicCentimeterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond, 1d, 1.0000000000000001e-09d).SetName("VolumetricFlowRate_ToBase_CubicMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond, 1d, 0.76455485798400002d).SetName("VolumetricFlowRate_ToBase_CubicYardPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute, 1d, 0.0127425809664d).SetName("VolumetricFlowRate_ToBase_CubicYardPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerHour, 1d, 0.00021237634944000001d).SetName("VolumetricFlowRate_ToBase_CubicYardPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond, 1d, 2.9573529562500001e-05d).SetName("VolumetricFlowRate_ToBase_USFluidOuncePerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond, 1d, 2.8413062500000002e-05d).SetName("VolumetricFlowRate_ToBase_ImperialFluidOuncePerSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond, 1d, 1.0d).SetName("VolumetricFlowRate_FromBase_CubicMeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute, 1d, 60.0d).SetName("VolumetricFlowRate_FromBase_CubicMeterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour, 1d, 3600.0d).SetName("VolumetricFlowRate_FromBase_CubicMeterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerSecond, 1d, 1000.0d).SetName("VolumetricFlowRate_FromBase_LiterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerMinute, 1d, 60000.0d).SetName("VolumetricFlowRate_FromBase_LiterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerHour, 1d, 3600000.0000000005d).SetName("VolumetricFlowRate_FromBase_LiterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond, 1d, 1000000.0d).SetName("VolumetricFlowRate_FromBase_MilliliterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerMinute, 1d, 15850.323141488903d).SetName("VolumetricFlowRate_FromBase_USGallonPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerHour, 1d, 951019.38848933426d).SetName("VolumetricFlowRate_FromBase_USGallonPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute, 1d, 13198.154897945267d).SetName("VolumetricFlowRate_FromBase_ImperialGallonPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond, 1d, 35.314666721488592d).SetName("VolumetricFlowRate_FromBase_CubicFootPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute, 1d, 2118.8800032893155d).SetName("VolumetricFlowRate_FromBase_CubicFootPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond, 1d, 1000000.0d).SetName("VolumetricFlowRate_FromBase_CubicCentimeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute, 1d, 60000000.0d).SetName("VolumetricFlowRate_FromBase_CubicCentimeterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute, 1d, 60000000.0d).SetName("VolumetricFlowRate_FromBase_MilliliterPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MilliliterPerHour, 1d, 3600000000.0d).SetName("VolumetricFlowRate_FromBase_MilliliterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.LiterPerDay, 1d, 86400000.0d).SetName("VolumetricFlowRate_FromBase_LiterPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicFootPerHour, 1d, 127132.80019735891d).SetName("VolumetricFlowRate_FromBase_CubicFootPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond, 1d, 61023.74409473229d).SetName("VolumetricFlowRate_FromBase_CubicInchPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute, 1d, 3661424.6456839372d).SetName("VolumetricFlowRate_FromBase_CubicInchPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerSecond, 1d, 264.17205235814839d).SetName("VolumetricFlowRate_FromBase_USGallonPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USGallonPerDay, 1d, 22824465.323744021d).SetName("VolumetricFlowRate_FromBase_USGallonPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond, 1d, 219.96924829908778d).SetName("VolumetricFlowRate_FromBase_ImperialGallonPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour, 1d, 791889.29387671594d).SetName("VolumetricFlowRate_FromBase_ImperialGallonPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay, 1d, 543439.65056533378d).SetName("VolumetricFlowRate_FromBase_OilBarrelPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour, 1d, 22643.318773555577d).SetName("VolumetricFlowRate_FromBase_OilBarrelPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.AcreFootPerDay, 1d, 70.045619943448443d).SetName("VolumetricFlowRate_FromBase_AcreFootPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay, 1d, 22.824465323744022d).SetName("VolumetricFlowRate_FromBase_MillionUSGallonsPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay, 1d, 86400.0d).SetName("VolumetricFlowRate_FromBase_CubicMeterPerDay");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour, 1d, 3600000000.0d).SetName("VolumetricFlowRate_FromBase_CubicCentimeterPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond, 1d, 999999999.99999988d).SetName("VolumetricFlowRate_FromBase_CubicMillimeterPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond, 1d, 1.3079506193143922d).SetName("VolumetricFlowRate_FromBase_CubicYardPerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute, 1d, 78.477037158863538d).SetName("VolumetricFlowRate_FromBase_CubicYardPerMinute");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.CubicYardPerHour, 1d, 4708.6222295318121d).SetName("VolumetricFlowRate_FromBase_CubicYardPerHour");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond, 1d, 33814.022701842994d).SetName("VolumetricFlowRate_FromBase_USFluidOuncePerSecond");
            yield return new TestCaseData(UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond, 1d, 35195.079727854041d).SetName("VolumetricFlowRate_FromBase_ImperialFluidOuncePerSecond");
        }
    }
}
