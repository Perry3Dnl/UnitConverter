namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.ElectricalResistivity;

    public sealed class UnitConverterKnownValueElectricalResistivityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalResistivity_ToBaseUnit_ReturnsExpectedValue(UnitConverterElectricalResistivityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricalResistivity.ToOhmMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricalResistivity_FromBaseUnit_ReturnsExpectedValue(UnitConverterElectricalResistivityUnit unit, double input, double expected)
        {
            double result = UnitConverterElectricalResistivity.FromOhmMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricalResistivity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterElectricalResistivityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterElectricalResistivity.ToOhmMeter(input, unit);
            double result = UnitConverterElectricalResistivity.FromOhmMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMeter, 1d, 1.0d).SetName("ElectricalResistivity_ToBase_OhmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmCentimeter, 1d, 0.01d).SetName("ElectricalResistivity_ToBase_OhmCentimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMillimeter, 1d, 0.001d).SetName("ElectricalResistivity_ToBase_OhmMillimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalResistivity_ToBase_MicroohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmInch, 1d, 0.025399999999999999d).SetName("ElectricalResistivity_ToBase_OhmInch");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot, 1d, 1.662426e-09d).SetName("ElectricalResistivity_ToBase_CircularMilOhmPerFoot");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.NanoohmMeter, 1d, 1.0000000000000001e-09d).SetName("ElectricalResistivity_ToBase_NanoohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MilliohmMeter, 1d, 0.001d).SetName("ElectricalResistivity_ToBase_MilliohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.KiloohmMeter, 1d, 1000.0d).SetName("ElectricalResistivity_ToBase_KiloohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmFoot, 1d, 0.30480000000000002d).SetName("ElectricalResistivity_ToBase_OhmFoot");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmCentimeter, 1d, 1e-08d).SetName("ElectricalResistivity_ToBase_MicroohmCentimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.PicoohmMeter, 1d, 9.9999999999999998e-13d).SetName("ElectricalResistivity_ToBase_PicoohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MegaohmMeter, 1d, 1000000.0d).SetName("ElectricalResistivity_ToBase_MegaohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalResistivity_ToBase_OhmMillimeterSquaredPerMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmInch, 1d, 2.5399999999999999e-08d).SetName("ElectricalResistivity_ToBase_MicroohmInch");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMeter, 1d, 1.0d).SetName("ElectricalResistivity_FromBase_OhmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmCentimeter, 1d, 100.0d).SetName("ElectricalResistivity_FromBase_OhmCentimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMillimeter, 1d, 1000.0d).SetName("ElectricalResistivity_FromBase_OhmMillimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmMeter, 1d, 1000000.0d).SetName("ElectricalResistivity_FromBase_MicroohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmInch, 1d, 39.370078740157481d).SetName("ElectricalResistivity_FromBase_OhmInch");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot, 1d, 601530534.29145122d).SetName("ElectricalResistivity_FromBase_CircularMilOhmPerFoot");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.NanoohmMeter, 1d, 999999999.99999988d).SetName("ElectricalResistivity_FromBase_NanoohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MilliohmMeter, 1d, 1000.0d).SetName("ElectricalResistivity_FromBase_MilliohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.KiloohmMeter, 1d, 0.001d).SetName("ElectricalResistivity_FromBase_KiloohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmFoot, 1d, 3.280839895013123d).SetName("ElectricalResistivity_FromBase_OhmFoot");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmCentimeter, 1d, 100000000.0d).SetName("ElectricalResistivity_FromBase_MicroohmCentimeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.PicoohmMeter, 1d, 1000000000000.0d).SetName("ElectricalResistivity_FromBase_PicoohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MegaohmMeter, 1d, 9.9999999999999995e-07d).SetName("ElectricalResistivity_FromBase_MegaohmMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter, 1d, 1000000.0d).SetName("ElectricalResistivity_FromBase_OhmMillimeterSquaredPerMeter");
            yield return new TestCaseData(UnitConverterElectricalResistivityUnit.MicroohmInch, 1d, 39370078.740157485d).SetName("ElectricalResistivity_FromBase_MicroohmInch");
        }
    }
}
