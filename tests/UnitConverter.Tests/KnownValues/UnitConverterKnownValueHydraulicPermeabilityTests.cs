namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.HydraulicPermeability;

    public sealed class UnitConverterKnownValueHydraulicPermeabilityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void HydraulicPermeability_ToBaseUnit_ReturnsExpectedValue(UnitConverterHydraulicPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitConverterHydraulicPermeability.ToSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void HydraulicPermeability_FromBaseUnit_ReturnsExpectedValue(UnitConverterHydraulicPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitConverterHydraulicPermeability.FromSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void HydraulicPermeability_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterHydraulicPermeabilityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterHydraulicPermeability.ToSquareMeter(input, unit);
            double result = UnitConverterHydraulicPermeability.FromSquareMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMeter, 1d, 1.0d).SetName("HydraulicPermeability_ToBase_SquareMeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareCentimeter, 1d, 0.0001d).SetName("HydraulicPermeability_ToBase_SquareCentimeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("HydraulicPermeability_ToBase_SquareMillimeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Darcy, 1d, 9.8692330000000009e-13d).SetName("HydraulicPermeability_ToBase_Darcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Millidarcy, 1d, 9.8692330000000007e-16d).SetName("HydraulicPermeability_ToBase_Millidarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Microdarcy, 1d, 9.8692329999999995e-19d).SetName("HydraulicPermeability_ToBase_Microdarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Nanodarcy, 1d, 9.8692329999999999e-22d).SetName("HydraulicPermeability_ToBase_Nanodarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Kilodarcy, 1d, 9.8692329999999996e-10d).SetName("HydraulicPermeability_ToBase_Kilodarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("HydraulicPermeability_ToBase_SquareMicrometer");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareNanometer, 1d, 1.0000000000000001e-18d).SetName("HydraulicPermeability_ToBase_SquareNanometer");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareInch, 1d, 0.00064515999999999998d).SetName("HydraulicPermeability_ToBase_SquareInch");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMeter, 1d, 1.0d).SetName("HydraulicPermeability_FromBase_SquareMeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareCentimeter, 1d, 10000.0d).SetName("HydraulicPermeability_FromBase_SquareCentimeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMillimeter, 1d, 1000000.0d).SetName("HydraulicPermeability_FromBase_SquareMillimeter");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Darcy, 1d, 1013249965828.1448d).SetName("HydraulicPermeability_FromBase_Darcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Millidarcy, 1d, 1013249965828144.9d).SetName("HydraulicPermeability_FromBase_Millidarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Microdarcy, 1d, 1.0132499658281449e+18d).SetName("HydraulicPermeability_FromBase_Microdarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Nanodarcy, 1d, 1.0132499658281449e+21d).SetName("HydraulicPermeability_FromBase_Nanodarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.Kilodarcy, 1d, 1013249965.8281449d).SetName("HydraulicPermeability_FromBase_Kilodarcy");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareMicrometer, 1d, 1000000000000.0d).SetName("HydraulicPermeability_FromBase_SquareMicrometer");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareNanometer, 1d, 9.9999999999999987e+17d).SetName("HydraulicPermeability_FromBase_SquareNanometer");
            yield return new TestCaseData(UnitConverterHydraulicPermeabilityUnit.SquareInch, 1d, 1550.0031000062002d).SetName("HydraulicPermeability_FromBase_SquareInch");
        }
    }
}
