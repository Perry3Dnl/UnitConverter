namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Density;

    public sealed class UnitToolsKnownValueDensityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Density_ToBaseUnit_ReturnsExpectedValue(UnitToolsDensityUnit unit, double input, double expected)
        {
            double result = UnitToolsDensity.ToKilogramPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Density_FromBaseUnit_ReturnsExpectedValue(UnitToolsDensityUnit unit, double input, double expected)
        {
            double result = UnitToolsDensity.FromKilogramPerCubicMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Density_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsDensityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsDensity.ToKilogramPerCubicMeter(input, unit);
            double result = UnitToolsDensity.FromKilogramPerCubicMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("Density_ToBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicMeter, 1d, 0.001d).SetName("Density_ToBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicCentimeter, 1d, 1000.0d).SetName("Density_ToBase_GramPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerMilliliter, 1d, 1000.0d).SetName("Density_ToBase_GramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerLiter, 1d, 1000.0d).SetName("Density_ToBase_KilogramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.MetricTonPerCubicMeter, 1d, 1000.0d).SetName("Density_ToBase_MetricTonPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerCubicFoot, 1d, 16.018463373960142d).SetName("Density_ToBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerCubicInch, 1d, 27679.904710191d).SetName("Density_ToBase_PoundPerCubicInch");
            yield return new TestCaseData(UnitToolsDensityUnit.SlugPerCubicFoot, 1d, 515.37881839320005d).SetName("Density_ToBase_SlugPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerCubicMeter, 1d, 1.0000000000000001e-09d).SetName("Density_ToBase_MicrogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerCubicMeter, 1d, 9.9999999999999995e-07d).SetName("Density_ToBase_MilligramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerLiter, 1d, 0.001d).SetName("Density_ToBase_MilligramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerLiter, 1d, 9.9999999999999995e-07d).SetName("Density_ToBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerLiter, 1d, 1.0d).SetName("Density_ToBase_GramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicMillimeter, 1d, 1000000.0d).SetName("Density_ToBase_GramPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicCentimeter, 1d, 1000000.0d).SetName("Density_ToBase_KilogramPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerCubicInch, 1d, 1729.994044d).SetName("Density_ToBase_OuncePerCubicInch");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerUSGallon, 1d, 7.4891517070000004d).SetName("Density_ToBase_OuncePerUSGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerUSGallon, 1d, 119.82642731689663d).SetName("Density_ToBase_PoundPerUSGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerImperialGallon, 1d, 99.776372663101654d).SetName("Density_ToBase_PoundPerImperialGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.TonUSPerCubicYard, 1d, 1186.5528425158584d).SetName("Density_ToBase_TonUSPerCubicYard");
            yield return new TestCaseData(UnitToolsDensityUnit.TonUKPerCubicYard, 1d, 1329.337246216744d).SetName("Density_ToBase_TonUKPerCubicYard");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("Density_ToBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerMilliliter, 1d, 0.001d).SetName("Density_ToBase_MicrogramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerCubicFoot, 1d, 1.0011539608725089d).SetName("Density_ToBase_OuncePerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.ShortTonPerCubicFoot, 1d, 32036.926747920279d).SetName("Density_ToBase_ShortTonPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.LongTonPerCubicFoot, 1d, 35881.357957670712d).SetName("Density_ToBase_LongTonPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicMillimeter, 1d, 1000000000.0d).SetName("Density_ToBase_KilogramPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.TonnesPerLiter, 1d, 1000000.0d).SetName("Density_ToBase_TonnesPerLiter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicMeter, 1d, 1.0d).SetName("Density_FromBase_KilogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicMeter, 1d, 1000.0d).SetName("Density_FromBase_GramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicCentimeter, 1d, 0.001d).SetName("Density_FromBase_GramPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerMilliliter, 1d, 0.001d).SetName("Density_FromBase_GramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerLiter, 1d, 0.001d).SetName("Density_FromBase_KilogramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.MetricTonPerCubicMeter, 1d, 0.001d).SetName("Density_FromBase_MetricTonPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerCubicFoot, 1d, 0.062427960576144602d).SetName("Density_FromBase_PoundPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerCubicInch, 1d, 3.612729200009951e-05d).SetName("Density_FromBase_PoundPerCubicInch");
            yield return new TestCaseData(UnitToolsDensityUnit.SlugPerCubicFoot, 1d, 0.001940320331979701d).SetName("Density_FromBase_SlugPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerCubicMeter, 1d, 999999999.99999988d).SetName("Density_FromBase_MicrogramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerCubicMeter, 1d, 1000000.0d).SetName("Density_FromBase_MilligramPerCubicMeter");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerLiter, 1d, 1000.0d).SetName("Density_FromBase_MilligramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerLiter, 1d, 1000000.0d).SetName("Density_FromBase_MicrogramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerLiter, 1d, 1.0d).SetName("Density_FromBase_GramPerLiter");
            yield return new TestCaseData(UnitToolsDensityUnit.GramPerCubicMillimeter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_GramPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicCentimeter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_KilogramPerCubicCentimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerCubicInch, 1d, 0.00057803667213087817d).SetName("Density_FromBase_OuncePerCubicInch");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerUSGallon, 1d, 0.13352647123776576d).SetName("Density_FromBase_OuncePerUSGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerUSGallon, 1d, 0.0083454044520193324d).SetName("Density_FromBase_PoundPerUSGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.PoundPerImperialGallon, 1d, 0.010022412854960507d).SetName("Density_FromBase_PoundPerImperialGallon");
            yield return new TestCaseData(UnitToolsDensityUnit.TonUSPerCubicYard, 1d, 0.00084277746777774445d).SetName("Density_FromBase_TonUSPerCubicYard");
            yield return new TestCaseData(UnitToolsDensityUnit.TonUKPerCubicYard, 1d, 0.00075225455605488491d).SetName("Density_FromBase_TonUKPerCubicYard");
            yield return new TestCaseData(UnitToolsDensityUnit.MilligramPerMilliliter, 1d, 1.0d).SetName("Density_FromBase_MilligramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.MicrogramPerMilliliter, 1d, 1000.0d).SetName("Density_FromBase_MicrogramPerMilliliter");
            yield return new TestCaseData(UnitToolsDensityUnit.OuncePerCubicFoot, 1d, 0.99884736921831363d).SetName("Density_FromBase_OuncePerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.ShortTonPerCubicFoot, 1d, 3.1213980288072309e-05d).SetName("Density_FromBase_ShortTonPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.LongTonPerCubicFoot, 1d, 2.7869625257207416e-05d).SetName("Density_FromBase_LongTonPerCubicFoot");
            yield return new TestCaseData(UnitToolsDensityUnit.KilogramPerCubicMillimeter, 1d, 1.0000000000000001e-09d).SetName("Density_FromBase_KilogramPerCubicMillimeter");
            yield return new TestCaseData(UnitToolsDensityUnit.TonnesPerLiter, 1d, 9.9999999999999995e-07d).SetName("Density_FromBase_TonnesPerLiter");
        }
    }
}
