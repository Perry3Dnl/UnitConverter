namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.AreaDensity;

    public sealed class UnitConverterKnownValueAreaDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void AreaDensity_ToBaseUnit_ReturnsExpectedValue(UnitConverterAreaDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterAreaDensity.ToKilogramPerSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void AreaDensity_FromBaseUnit_ReturnsExpectedValue(UnitConverterAreaDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterAreaDensity.FromKilogramPerSquareMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void AreaDensity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAreaDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterAreaDensity.ToKilogramPerSquareMeter(input, unit);
            double result = UnitConverterAreaDensity.FromKilogramPerSquareMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAreaDensityUnit.KilogramPerSquareMeter, 1d, 1.0d).SetName("AreaDensity_ToBase_KilogramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.GramPerSquareMeter, 1d, 0.001d).SetName("AreaDensity_ToBase_GramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.MilligramPerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("AreaDensity_ToBase_MilligramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareFoot, 1d, 4.8824276363830501d).SetName("AreaDensity_ToBase_PoundPerSquareFoot");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareInch, 1d, 703.06957963915931d).SetName("AreaDensity_ToBase_PoundPerSquareInch");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareYard, 1d, 0.0339057474748823d).SetName("AreaDensity_ToBase_OuncePerSquareYard");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.MicrogramPerSquareMeter, 1d, 1.0000000000000001e-09d).SetName("AreaDensity_ToBase_MicrogramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.GramPerSquareCentimeter, 1d, 10.0d).SetName("AreaDensity_ToBase_GramPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter, 1d, 1000000.0d).SetName("AreaDensity_ToBase_KilogramPerSquareMillimeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareFoot, 1d, 0.30515172727394063d).SetName("AreaDensity_ToBase_OuncePerSquareFoot");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareInch, 1d, 43.941848727447457d).SetName("AreaDensity_ToBase_OuncePerSquareInch");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareYard, 1d, 0.5424919595981168d).SetName("AreaDensity_ToBase_PoundPerSquareYard");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAreaDensityUnit.KilogramPerSquareMeter, 1d, 1.0d).SetName("AreaDensity_FromBase_KilogramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.GramPerSquareMeter, 1d, 1000.0d).SetName("AreaDensity_FromBase_GramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.MilligramPerSquareMeter, 1d, 1000000.0d).SetName("AreaDensity_FromBase_MilligramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareFoot, 1d, 0.20481614362252171d).SetName("AreaDensity_FromBase_PoundPerSquareFoot");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareInch, 1d, 0.0014223343307119562d).SetName("AreaDensity_FromBase_PoundPerSquareInch");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareYard, 1d, 29.49352468164312d).SetName("AreaDensity_FromBase_OuncePerSquareYard");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.MicrogramPerSquareMeter, 1d, 999999999.99999988d).SetName("AreaDensity_FromBase_MicrogramPerSquareMeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.GramPerSquareCentimeter, 1d, 0.10000000000000001d).SetName("AreaDensity_FromBase_GramPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("AreaDensity_FromBase_KilogramPerSquareMillimeter");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareFoot, 1d, 3.2770582979603473d).SetName("AreaDensity_FromBase_OuncePerSquareFoot");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.OuncePerSquareInch, 1d, 0.0227573492913913d).SetName("AreaDensity_FromBase_OuncePerSquareInch");
            yield return new TestCaseData(UnitConverterAreaDensityUnit.PoundPerSquareYard, 1d, 1.843345292602695d).SetName("AreaDensity_FromBase_PoundPerSquareYard");
        }
    }
}
