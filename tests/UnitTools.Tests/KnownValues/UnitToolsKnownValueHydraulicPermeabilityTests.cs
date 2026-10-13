namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.HydraulicPermeability;

    public sealed class UnitToolsKnownValueHydraulicPermeabilityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void HydraulicPermeability_ToBaseUnit_ReturnsExpectedValue(UnitToolsHydraulicPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitToolsHydraulicPermeability.ToSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void HydraulicPermeability_FromBaseUnit_ReturnsExpectedValue(UnitToolsHydraulicPermeabilityUnit unit, double input, double expected)
        {
            double result = UnitToolsHydraulicPermeability.FromSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void HydraulicPermeability_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsHydraulicPermeabilityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsHydraulicPermeability.ToSquareMeter(input, unit);
            double result = UnitToolsHydraulicPermeability.FromSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMeter, 1d, 1.0d).SetName("HydraulicPermeability_ToBase_SquareMeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareCentimeter, 1d, 0.0001d).SetName("HydraulicPermeability_ToBase_SquareCentimeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("HydraulicPermeability_ToBase_SquareMillimeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Darcy, 1d, 9.8692330000000009e-13d).SetName("HydraulicPermeability_ToBase_Darcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Millidarcy, 1d, 9.8692330000000007e-16d).SetName("HydraulicPermeability_ToBase_Millidarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Microdarcy, 1d, 9.8692329999999995e-19d).SetName("HydraulicPermeability_ToBase_Microdarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Nanodarcy, 1d, 9.8692329999999999e-22d).SetName("HydraulicPermeability_ToBase_Nanodarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Kilodarcy, 1d, 9.8692329999999996e-10d).SetName("HydraulicPermeability_ToBase_Kilodarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("HydraulicPermeability_ToBase_SquareMicrometer");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareNanometer, 1d, 1.0000000000000001e-18d).SetName("HydraulicPermeability_ToBase_SquareNanometer");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareInch, 1d, 0.00064515999999999998d).SetName("HydraulicPermeability_ToBase_SquareInch");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMeter, 1d, 1.0d).SetName("HydraulicPermeability_FromBase_SquareMeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareCentimeter, 1d, 10000.0d).SetName("HydraulicPermeability_FromBase_SquareCentimeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMillimeter, 1d, 1000000.0d).SetName("HydraulicPermeability_FromBase_SquareMillimeter");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Darcy, 1d, 1013249965828.1448d).SetName("HydraulicPermeability_FromBase_Darcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Millidarcy, 1d, 1013249965828144.9d).SetName("HydraulicPermeability_FromBase_Millidarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Microdarcy, 1d, 1.0132499658281449e+18d).SetName("HydraulicPermeability_FromBase_Microdarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Nanodarcy, 1d, 1.0132499658281449e+21d).SetName("HydraulicPermeability_FromBase_Nanodarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.Kilodarcy, 1d, 1013249965.8281449d).SetName("HydraulicPermeability_FromBase_Kilodarcy");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareMicrometer, 1d, 1000000000000.0d).SetName("HydraulicPermeability_FromBase_SquareMicrometer");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareNanometer, 1d, 9.9999999999999987e+17d).SetName("HydraulicPermeability_FromBase_SquareNanometer");
            yield return new TestCaseData(UnitToolsHydraulicPermeabilityUnit.SquareInch, 1d, 1550.0031000062002d).SetName("HydraulicPermeability_FromBase_SquareInch");
        }
    }
}
