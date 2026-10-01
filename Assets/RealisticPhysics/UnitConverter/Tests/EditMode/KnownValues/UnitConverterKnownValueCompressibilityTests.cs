namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Compressibility;

    public sealed class UnitConverterKnownValueCompressibilityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Compressibility_ToBaseUnit_ReturnsExpectedValue(UnitConverterCompressibilityUnit unit, double input, double expected)
        {
            double result = UnitConverterCompressibility.ToPerPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Compressibility_FromBaseUnit_ReturnsExpectedValue(UnitConverterCompressibilityUnit unit, double input, double expected)
        {
            double result = UnitConverterCompressibility.FromPerPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Compressibility_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterCompressibilityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterCompressibility.ToPerPascal(input, unit);
            double result = UnitConverterCompressibility.FromPerPascal(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerPascal, 1d, 1.0d).SetName("Compressibility_ToBase_PerPascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerKilopascal, 1d, 0.001d).SetName("Compressibility_ToBase_PerKilopascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMegapascal, 1d, 9.9999999999999995e-07d).SetName("Compressibility_ToBase_PerMegapascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerBar, 1d, 1.0000000000000001e-05d).SetName("Compressibility_ToBase_PerBar");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerAtmosphere, 1d, 9.8692326671601285e-06d).SetName("Compressibility_ToBase_PerAtmosphere");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerPsi, 1d, 0.00014503773773021683d).SetName("Compressibility_ToBase_PerPsi");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMillibar, 1d, 0.01d).SetName("Compressibility_ToBase_PerMillibar");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerHectopascal, 1d, 0.01d).SetName("Compressibility_ToBase_PerHectopascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerGigapascal, 1d, 1.0000000000000001e-09d).SetName("Compressibility_ToBase_PerGigapascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerTorr, 1d, 0.0075006168270416972d).SetName("Compressibility_ToBase_PerTorr");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMillimeterMercury, 1d, 0.0075006157584565627d).SetName("Compressibility_ToBase_PerMillimeterMercury");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerInchMercury, 1d, 0.00029529987508079483d).SetName("Compressibility_ToBase_PerInchMercury");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerPascal, 1d, 1.0d).SetName("Compressibility_FromBase_PerPascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerKilopascal, 1d, 1000.0d).SetName("Compressibility_FromBase_PerKilopascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMegapascal, 1d, 1000000.0d).SetName("Compressibility_FromBase_PerMegapascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerBar, 1d, 99999.999999999985d).SetName("Compressibility_FromBase_PerBar");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerAtmosphere, 1d, 101325.0d).SetName("Compressibility_FromBase_PerAtmosphere");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerPsi, 1d, 6894.7572931679997d).SetName("Compressibility_FromBase_PerPsi");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMillibar, 1d, 100.0d).SetName("Compressibility_FromBase_PerMillibar");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerHectopascal, 1d, 100.0d).SetName("Compressibility_FromBase_PerHectopascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerGigapascal, 1d, 999999999.99999988d).SetName("Compressibility_FromBase_PerGigapascal");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerTorr, 1d, 133.32236842105263d).SetName("Compressibility_FromBase_PerTorr");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerMillimeterMercury, 1d, 133.32238741500001d).SetName("Compressibility_FromBase_PerMillimeterMercury");
            yield return new TestCaseData(UnitConverterCompressibilityUnit.PerInchMercury, 1d, 3386.3881578900005d).SetName("Compressibility_FromBase_PerInchMercury");
        }
    }
}
