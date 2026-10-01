namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.DynamicPressure;

    public sealed class UnitConverterKnownValueDynamicPressureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DynamicPressure_ToBaseUnit_ReturnsExpectedValue(UnitConverterDynamicPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterDynamicPressure.ToPascal(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DynamicPressure_FromBaseUnit_ReturnsExpectedValue(UnitConverterDynamicPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterDynamicPressure.FromPascal(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DynamicPressure_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterDynamicPressureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterDynamicPressure.ToPascal(input, unit);
            double result = UnitConverterDynamicPressure.FromPascal(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Pascal, 1d, 1.0d).SetName("DynamicPressure_ToBase_Pascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Kilopascal, 1d, 1000.0d).SetName("DynamicPressure_ToBase_Kilopascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Megapascal, 1d, 1000000.0d).SetName("DynamicPressure_ToBase_Megapascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Bar, 1d, 100000.0d).SetName("DynamicPressure_ToBase_Bar");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Atmosphere, 1d, 101325.0d).SetName("DynamicPressure_ToBase_Atmosphere");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Psi, 1d, 6894.7572931679997d).SetName("DynamicPressure_ToBase_Psi");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Psf, 1d, 47.880258980335839d).SetName("DynamicPressure_ToBase_Psf");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Hectopascal, 1d, 100.0d).SetName("DynamicPressure_ToBase_Hectopascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Millibar, 1d, 100.0d).SetName("DynamicPressure_ToBase_Millibar");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Torr, 1d, 133.32236842105263d).SetName("DynamicPressure_ToBase_Torr");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.MillimeterMercury, 1d, 133.32238741500001d).SetName("DynamicPressure_ToBase_MillimeterMercury");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.InchMercury, 1d, 3386.38815789d).SetName("DynamicPressure_ToBase_InchMercury");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.InchWater, 1d, 249.08891d).SetName("DynamicPressure_ToBase_InchWater");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.FootWater, 1d, 2989.0669200000002d).SetName("DynamicPressure_ToBase_FootWater");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter, 1d, 98066.5d).SetName("DynamicPressure_ToBase_KilogramForcePerSquareCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Pascal, 1d, 1.0d).SetName("DynamicPressure_FromBase_Pascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Kilopascal, 1d, 0.001d).SetName("DynamicPressure_FromBase_Kilopascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Megapascal, 1d, 9.9999999999999995e-07d).SetName("DynamicPressure_FromBase_Megapascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Bar, 1d, 1.0000000000000001e-05d).SetName("DynamicPressure_FromBase_Bar");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Atmosphere, 1d, 9.8692326671601285e-06d).SetName("DynamicPressure_FromBase_Atmosphere");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Psi, 1d, 0.00014503773773021683d).SetName("DynamicPressure_FromBase_Psi");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Psf, 1d, 0.020885434233150129d).SetName("DynamicPressure_FromBase_Psf");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Hectopascal, 1d, 0.01d).SetName("DynamicPressure_FromBase_Hectopascal");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Millibar, 1d, 0.01d).SetName("DynamicPressure_FromBase_Millibar");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.Torr, 1d, 0.0075006168270416972d).SetName("DynamicPressure_FromBase_Torr");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.MillimeterMercury, 1d, 0.0075006157584565627d).SetName("DynamicPressure_FromBase_MillimeterMercury");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.InchMercury, 1d, 0.00029529987508079483d).SetName("DynamicPressure_FromBase_InchMercury");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.InchWater, 1d, 0.0040146307597556229d).SetName("DynamicPressure_FromBase_InchWater");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.FootWater, 1d, 0.00033455256331296854d).SetName("DynamicPressure_FromBase_FootWater");
            yield return new TestCaseData(UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter, 1d, 1.0197162129779282e-05d).SetName("DynamicPressure_FromBase_KilogramForcePerSquareCentimeter");
        }
    }
}
