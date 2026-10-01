namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Density;

    public sealed class UnitConverterKnownValueDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Density_ToBaseUnit_ReturnsExpectedValue(UnitConverterDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterDensity.ToKilogramPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Density_FromBaseUnit_ReturnsExpectedValue(UnitConverterDensityUnit unit, double input, double expected)
        {
            double result = UnitConverterDensity.FromKilogramPerCubicMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Density_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterDensity.ToKilogramPerCubicMeter(input, unit);
            double result = UnitConverterDensity.FromKilogramPerCubicMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("Density_ToBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicMeter, 1d, 0.001d).SetName("Density_ToBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicCentimeter, 1d, 1000.0d).SetName("Density_ToBase_GramPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerMilliliter, 1d, 1000.0d).SetName("Density_ToBase_GramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerLiter, 1d, 1000.0d).SetName("Density_ToBase_KilogramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.MetricTonPerCubicMeter, 1d, 1000.0d).SetName("Density_ToBase_MetricTonPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerCubicFoot, 1d, 16.018463373960142d).SetName("Density_ToBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerCubicInch, 1d, 27679.904710191d).SetName("Density_ToBase_PoundPerCubicInch");
            yield return new TestCaseData(UnitConverterDensityUnit.SlugPerCubicFoot, 1d, 515.37881839320005d).SetName("Density_ToBase_SlugPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerCubicMeter, 1d, 1.0000000000000001e-09d).SetName("Density_ToBase_MicrogramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("Density_ToBase_MilligramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerLiter, 1d, 0.001d).SetName("Density_ToBase_MilligramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerLiter, 1d, 9.9999999999999995e-07d).SetName("Density_ToBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerLiter, 1d, 1.0d).SetName("Density_ToBase_GramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicMillimeter, 1d, 1000000.0d).SetName("Density_ToBase_GramPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicCentimeter, 1d, 1000000.0d).SetName("Density_ToBase_KilogramPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerCubicInch, 1d, 1729.994044d).SetName("Density_ToBase_OuncePerCubicInch");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerUSGallon, 1d, 7.4891517070000004d).SetName("Density_ToBase_OuncePerUSGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerUSGallon, 1d, 119.82642731689663d).SetName("Density_ToBase_PoundPerUSGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerImperialGallon, 1d, 99.776372663101654d).SetName("Density_ToBase_PoundPerImperialGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.TonUSPerCubicYard, 1d, 1186.5528425158584d).SetName("Density_ToBase_TonUSPerCubicYard");
            yield return new TestCaseData(UnitConverterDensityUnit.TonUKPerCubicYard, 1d, 1329.337246216744d).SetName("Density_ToBase_TonUKPerCubicYard");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("Density_ToBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerMilliliter, 1d, 0.001d).SetName("Density_ToBase_MicrogramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerCubicFoot, 1d, 1.0011539608725089d).SetName("Density_ToBase_OuncePerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.ShortTonPerCubicFoot, 1d, 32036.926747920279d).SetName("Density_ToBase_ShortTonPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.LongTonPerCubicFoot, 1d, 35881.357957670712d).SetName("Density_ToBase_LongTonPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicMillimeter, 1d, 1000000000.0d).SetName("Density_ToBase_KilogramPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.TonnesPerLiter, 1d, 1000000.0d).SetName("Density_ToBase_TonnesPerLiter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("Density_FromBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicMeter, 1d, 1000.0d).SetName("Density_FromBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicCentimeter, 1d, 0.001d).SetName("Density_FromBase_GramPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerMilliliter, 1d, 0.001d).SetName("Density_FromBase_GramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerLiter, 1d, 0.001d).SetName("Density_FromBase_KilogramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.MetricTonPerCubicMeter, 1d, 0.001d).SetName("Density_FromBase_MetricTonPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerCubicFoot, 1d, 0.062427960576144602d).SetName("Density_FromBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerCubicInch, 1d, 3.612729200009951e-05d).SetName("Density_FromBase_PoundPerCubicInch");
            yield return new TestCaseData(UnitConverterDensityUnit.SlugPerCubicFoot, 1d, 0.001940320331979701d).SetName("Density_FromBase_SlugPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerCubicMeter, 1d, 999999999.99999988d).SetName("Density_FromBase_MicrogramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerCubicMeter, 1d, 1000000.0d).SetName("Density_FromBase_MilligramPerCubicMeter");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerLiter, 1d, 1000.0d).SetName("Density_FromBase_MilligramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerLiter, 1d, 1000000.0d).SetName("Density_FromBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerLiter, 1d, 1.0d).SetName("Density_FromBase_GramPerLiter");
            yield return new TestCaseData(UnitConverterDensityUnit.GramPerCubicMillimeter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_GramPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_KilogramPerCubicCentimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerCubicInch, 1d, 0.00057803667213087817d).SetName("Density_FromBase_OuncePerCubicInch");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerUSGallon, 1d, 0.13352647123776576d).SetName("Density_FromBase_OuncePerUSGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerUSGallon, 1d, 0.0083454044520193324d).SetName("Density_FromBase_PoundPerUSGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.PoundPerImperialGallon, 1d, 0.010022412854960507d).SetName("Density_FromBase_PoundPerImperialGallon");
            yield return new TestCaseData(UnitConverterDensityUnit.TonUSPerCubicYard, 1d, 0.00084277746777774445d).SetName("Density_FromBase_TonUSPerCubicYard");
            yield return new TestCaseData(UnitConverterDensityUnit.TonUKPerCubicYard, 1d, 0.00075225455605488491d).SetName("Density_FromBase_TonUKPerCubicYard");
            yield return new TestCaseData(UnitConverterDensityUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("Density_FromBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.MicrogramPerMilliliter, 1d, 1000.0d).SetName("Density_FromBase_MicrogramPerMilliliter");
            yield return new TestCaseData(UnitConverterDensityUnit.OuncePerCubicFoot, 1d, 0.99884736921831363d).SetName("Density_FromBase_OuncePerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.ShortTonPerCubicFoot, 1d, 3.1213980288072309e-05d).SetName("Density_FromBase_ShortTonPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.LongTonPerCubicFoot, 1d, 2.7869625257207416e-05d).SetName("Density_FromBase_LongTonPerCubicFoot");
            yield return new TestCaseData(UnitConverterDensityUnit.KilogramPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("Density_FromBase_KilogramPerCubicMillimeter");
            yield return new TestCaseData(UnitConverterDensityUnit.TonnesPerLiter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_TonnesPerLiter");
        }
    }
}
