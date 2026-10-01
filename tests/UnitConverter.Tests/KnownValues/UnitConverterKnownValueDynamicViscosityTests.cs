namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.DynamicViscosity;

    public sealed class UnitConverterKnownValueDynamicViscosityTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void DynamicViscosity_ToBaseUnit_ReturnsExpectedValue(UnitConverterDynamicViscosityUnit unit, double input, double expected)
        {
            double result = UnitConverterDynamicViscosity.ToPascalSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void DynamicViscosity_FromBaseUnit_ReturnsExpectedValue(UnitConverterDynamicViscosityUnit unit, double input, double expected)
        {
            double result = UnitConverterDynamicViscosity.FromPascalSecond(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void DynamicViscosity_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterDynamicViscosityUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterDynamicViscosity.ToPascalSecond(input, unit);
            double result = UnitConverterDynamicViscosity.FromPascalSecond(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalSecond, 1d, 1.0d).SetName("DynamicViscosity_ToBase_PascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MillipascalSecond, 1d, 0.001d).SetName("DynamicViscosity_ToBase_MillipascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MicropascalSecond, 1d, 9.9999999999999995e-07d).SetName("DynamicViscosity_ToBase_MicropascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Poise, 1d, 0.10000000000000001d).SetName("DynamicViscosity_ToBase_Poise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Centipoise, 1d, 0.001d).SetName("DynamicViscosity_ToBase_Centipoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerFootSecond, 1d, 1.48816394357d).SetName("DynamicViscosity_ToBase_PoundPerFootSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot, 1d, 47.880258980000001d).SetName("DynamicViscosity_ToBase_PoundForceSecondPerSquareFoot");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch, 1d, 6894.7572931679997d).SetName("DynamicViscosity_ToBase_PoundForceSecondPerSquareInch");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilopascalSecond, 1d, 1000.0d).SetName("DynamicViscosity_ToBase_KilopascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MegapascalSecond, 1d, 1000000.0d).SetName("DynamicViscosity_ToBase_MegapascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter, 1d, 1.0d).SetName("DynamicViscosity_ToBase_NewtonSecondPerSquareMeter");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond, 1d, 1.0d).SetName("DynamicViscosity_ToBase_KilogramPerMeterSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond, 1d, 0.10000000000000001d).SetName("DynamicViscosity_ToBase_GramPerCentimeterSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter, 1d, 0.10000000000000001d).SetName("DynamicViscosity_ToBase_DyneSecondPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Millipoise, 1d, 0.0001d).SetName("DynamicViscosity_ToBase_Millipoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Micropoise, 1d, 9.9999999999999995e-08d).SetName("DynamicViscosity_ToBase_Micropoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Reyn, 1d, 6894.7572931683608d).SetName("DynamicViscosity_ToBase_Reyn");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerFootHour, 1d, 0.00041337887321327783d).SetName("DynamicViscosity_ToBase_PoundPerFootHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalHour, 1d, 3600.0d).SetName("DynamicViscosity_ToBase_PascalHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalMinute, 1d, 60.0d).SetName("DynamicViscosity_ToBase_PascalMinute");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilogramPerMeterHour, 1d, 0.00027777777777777778d).SetName("DynamicViscosity_ToBase_KilogramPerMeterHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute, 1d, 0.0016666666666666668d).SetName("DynamicViscosity_ToBase_GramPerCentimeterMinute");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.SlugPerFootSecond, 1d, 47.880258989501307d).SetName("DynamicViscosity_ToBase_SlugPerFootSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.SlugPerFootHour, 1d, 0.013300071941528142d).SetName("DynamicViscosity_ToBase_SlugPerFootHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerInchSecond, 1d, 17.857967322834646d).SetName("DynamicViscosity_ToBase_PoundPerInchSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerInchHour, 1d, 0.0049605464785651794d).SetName("DynamicViscosity_ToBase_PoundPerInchHour");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalSecond, 1d, 1.0d).SetName("DynamicViscosity_FromBase_PascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MillipascalSecond, 1d, 1000.0d).SetName("DynamicViscosity_FromBase_MillipascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MicropascalSecond, 1d, 1000000.0d).SetName("DynamicViscosity_FromBase_MicropascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Poise, 1d, 10.0d).SetName("DynamicViscosity_FromBase_Poise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Centipoise, 1d, 1000.0d).SetName("DynamicViscosity_FromBase_Centipoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerFootSecond, 1d, 0.67196897513930542d).SetName("DynamicViscosity_FromBase_PoundPerFootSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot, 1d, 0.020885434233296623d).SetName("DynamicViscosity_FromBase_PoundForceSecondPerSquareFoot");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch, 1d, 0.00014503773773021683d).SetName("DynamicViscosity_FromBase_PoundForceSecondPerSquareInch");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilopascalSecond, 1d, 0.001d).SetName("DynamicViscosity_FromBase_KilopascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.MegapascalSecond, 1d, 9.9999999999999995e-07d).SetName("DynamicViscosity_FromBase_MegapascalSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter, 1d, 1.0d).SetName("DynamicViscosity_FromBase_NewtonSecondPerSquareMeter");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond, 1d, 1.0d).SetName("DynamicViscosity_FromBase_KilogramPerMeterSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond, 1d, 10.0d).SetName("DynamicViscosity_FromBase_GramPerCentimeterSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter, 1d, 10.0d).SetName("DynamicViscosity_FromBase_DyneSecondPerSquareCentimeter");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Millipoise, 1d, 10000.0d).SetName("DynamicViscosity_FromBase_Millipoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Micropoise, 1d, 10000000.0d).SetName("DynamicViscosity_FromBase_Micropoise");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.Reyn, 1d, 0.00014503773773020924d).SetName("DynamicViscosity_FromBase_Reyn");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerFootHour, 1d, 2419.0883105050752d).SetName("DynamicViscosity_FromBase_PoundPerFootHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalHour, 1d, 0.00027777777777777778d).SetName("DynamicViscosity_FromBase_PascalHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PascalMinute, 1d, 0.016666666666666666d).SetName("DynamicViscosity_FromBase_PascalMinute");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.KilogramPerMeterHour, 1d, 3600.0d).SetName("DynamicViscosity_FromBase_KilogramPerMeterHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute, 1d, 600.0d).SetName("DynamicViscosity_FromBase_GramPerCentimeterMinute");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.SlugPerFootSecond, 1d, 0.02088543422915214d).SetName("DynamicViscosity_FromBase_SlugPerFootSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.SlugPerFootHour, 1d, 75.187563224947695d).SetName("DynamicViscosity_FromBase_SlugPerFootHour");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerInchSecond, 1d, 0.055997414594958904d).SetName("DynamicViscosity_FromBase_PoundPerInchSecond");
            yield return new TestCaseData(UnitConverterDynamicViscosityUnit.PoundPerInchHour, 1d, 201.59069254185206d).SetName("DynamicViscosity_FromBase_PoundPerInchHour");
        }
    }
}
