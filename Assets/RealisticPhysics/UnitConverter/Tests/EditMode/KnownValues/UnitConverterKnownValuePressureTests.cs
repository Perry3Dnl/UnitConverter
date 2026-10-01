namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Pressure;

    public sealed class UnitConverterKnownValuePressureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Pressure_ToBaseUnit_ReturnsExpectedValue(UnitConverterPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterPressure.ToPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Pressure_FromBaseUnit_ReturnsExpectedValue(UnitConverterPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterPressure.FromPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Pressure_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterPressureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterPressure.ToPascal(input, unit);
            double result = UnitConverterPressure.FromPascal(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterPressureUnit.Pascal, 1d, 1.0d).SetName("Pressure_ToBase_Pascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Hectopascal, 1d, 100.0d).SetName("Pressure_ToBase_Hectopascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Kilopascal, 1d, 1000.0d).SetName("Pressure_ToBase_Kilopascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Megapascal, 1d, 1000000.0d).SetName("Pressure_ToBase_Megapascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Bar, 1d, 100000.0d).SetName("Pressure_ToBase_Bar");
            yield return new TestCaseData(UnitConverterPressureUnit.Millibar, 1d, 100.0d).SetName("Pressure_ToBase_Millibar");
            yield return new TestCaseData(UnitConverterPressureUnit.Atmosphere, 1d, 101325.0d).SetName("Pressure_ToBase_Atmosphere");
            yield return new TestCaseData(UnitConverterPressureUnit.Torr, 1d, 133.32236842105263d).SetName("Pressure_ToBase_Torr");
            yield return new TestCaseData(UnitConverterPressureUnit.MillimeterMercury, 1d, 133.32238741500001d).SetName("Pressure_ToBase_MillimeterMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.InchMercury, 1d, 3386.38815789d).SetName("Pressure_ToBase_InchMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.Psi, 1d, 6894.7572931679997d).SetName("Pressure_ToBase_Psi");
            yield return new TestCaseData(UnitConverterPressureUnit.Psf, 1d, 47.880258980335839d).SetName("Pressure_ToBase_Psf");
            yield return new TestCaseData(UnitConverterPressureUnit.Barye, 1d, 0.10000000000000001d).SetName("Pressure_ToBase_Barye");
            yield return new TestCaseData(UnitConverterPressureUnit.Micropascal, 1d, 9.9999999999999995e-07d).SetName("Pressure_ToBase_Micropascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Millipascal, 1d, 0.001d).SetName("Pressure_ToBase_Millipascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Gigapascal, 1d, 1000000000.0d).SetName("Pressure_ToBase_Gigapascal");
            yield return new TestCaseData(UnitConverterPressureUnit.TechnicalAtmosphere, 1d, 98066.5d).SetName("Pressure_ToBase_TechnicalAtmosphere");
            yield return new TestCaseData(UnitConverterPressureUnit.KilogramForcePerSquareCentimeter, 1d, 98066.5d).SetName("Pressure_ToBase_KilogramForcePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterPressureUnit.MillimeterWater, 1d, 9.8066499999999994d).SetName("Pressure_ToBase_MillimeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.CentimeterWater, 1d, 98.066500000000005d).SetName("Pressure_ToBase_CentimeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.InchWater, 1d, 249.08891d).SetName("Pressure_ToBase_InchWater");
            yield return new TestCaseData(UnitConverterPressureUnit.FootWater, 1d, 2989.0669200000002d).SetName("Pressure_ToBase_FootWater");
            yield return new TestCaseData(UnitConverterPressureUnit.MeterWater, 1d, 9806.6499999999996d).SetName("Pressure_ToBase_MeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.DynePerSquareCentimeter, 1d, 0.10000000000000001d).SetName("Pressure_ToBase_DynePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterPressureUnit.KilopoundPerSquareInch, 1d, 6894757.2931679999d).SetName("Pressure_ToBase_KilopoundPerSquareInch");
            yield return new TestCaseData(UnitConverterPressureUnit.TonForceUSPerSquareFoot, 1d, 95760.517960678219d).SetName("Pressure_ToBase_TonForceUSPerSquareFoot");
            yield return new TestCaseData(UnitConverterPressureUnit.MicronMercury, 1d, 0.13332238741499999d).SetName("Pressure_ToBase_MicronMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.CentimeterMercury, 1d, 1333.22387415d).SetName("Pressure_ToBase_CentimeterMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.PoundForcePerSquareYard, 1d, 5.3200287755928715d).SetName("Pressure_ToBase_PoundForcePerSquareYard");
            yield return new TestCaseData(UnitConverterPressureUnit.OunceForcePerSquareInch, 1d, 430.92233082302255d).SetName("Pressure_ToBase_OunceForcePerSquareInch");
            yield return new TestCaseData(UnitConverterPressureUnit.GramForcePerSquareCentimeter, 1d, 98.066500000000005d).SetName("Pressure_ToBase_GramForcePerSquareCentimeter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterPressureUnit.Pascal, 1d, 1.0d).SetName("Pressure_FromBase_Pascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Hectopascal, 1d, 0.01d).SetName("Pressure_FromBase_Hectopascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Kilopascal, 1d, 0.001d).SetName("Pressure_FromBase_Kilopascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Megapascal, 1d, 9.9999999999999995e-07d).SetName("Pressure_FromBase_Megapascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Bar, 1d, 1.0000000000000001e-05d).SetName("Pressure_FromBase_Bar");
            yield return new TestCaseData(UnitConverterPressureUnit.Millibar, 1d, 0.01d).SetName("Pressure_FromBase_Millibar");
            yield return new TestCaseData(UnitConverterPressureUnit.Atmosphere, 1d, 9.8692326671601285e-06d).SetName("Pressure_FromBase_Atmosphere");
            yield return new TestCaseData(UnitConverterPressureUnit.Torr, 1d, 0.0075006168270416972d).SetName("Pressure_FromBase_Torr");
            yield return new TestCaseData(UnitConverterPressureUnit.MillimeterMercury, 1d, 0.0075006157584565627d).SetName("Pressure_FromBase_MillimeterMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.InchMercury, 1d, 0.00029529987508079483d).SetName("Pressure_FromBase_InchMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.Psi, 1d, 0.00014503773773021683d).SetName("Pressure_FromBase_Psi");
            yield return new TestCaseData(UnitConverterPressureUnit.Psf, 1d, 0.020885434233150129d).SetName("Pressure_FromBase_Psf");
            yield return new TestCaseData(UnitConverterPressureUnit.Barye, 1d, 10.0d).SetName("Pressure_FromBase_Barye");
            yield return new TestCaseData(UnitConverterPressureUnit.Micropascal, 1d, 1000000.0d).SetName("Pressure_FromBase_Micropascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Millipascal, 1d, 1000.0d).SetName("Pressure_FromBase_Millipascal");
            yield return new TestCaseData(UnitConverterPressureUnit.Gigapascal, 1d, 1.0000000000000001e-09d).SetName("Pressure_FromBase_Gigapascal");
            yield return new TestCaseData(UnitConverterPressureUnit.TechnicalAtmosphere, 1d, 1.0197162129779282e-05d).SetName("Pressure_FromBase_TechnicalAtmosphere");
            yield return new TestCaseData(UnitConverterPressureUnit.KilogramForcePerSquareCentimeter, 1d, 1.0197162129779282e-05d).SetName("Pressure_FromBase_KilogramForcePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterPressureUnit.MillimeterWater, 1d, 0.10197162129779283d).SetName("Pressure_FromBase_MillimeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.CentimeterWater, 1d, 0.010197162129779282d).SetName("Pressure_FromBase_CentimeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.InchWater, 1d, 0.0040146307597556229d).SetName("Pressure_FromBase_InchWater");
            yield return new TestCaseData(UnitConverterPressureUnit.FootWater, 1d, 0.00033455256331296854d).SetName("Pressure_FromBase_FootWater");
            yield return new TestCaseData(UnitConverterPressureUnit.MeterWater, 1d, 0.00010197162129779283d).SetName("Pressure_FromBase_MeterWater");
            yield return new TestCaseData(UnitConverterPressureUnit.DynePerSquareCentimeter, 1d, 10.0d).SetName("Pressure_FromBase_DynePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterPressureUnit.KilopoundPerSquareInch, 1d, 1.4503773773021681e-07d).SetName("Pressure_FromBase_KilopoundPerSquareInch");
            yield return new TestCaseData(UnitConverterPressureUnit.TonForceUSPerSquareFoot, 1d, 1.0442717116574352e-05d).SetName("Pressure_FromBase_TonForceUSPerSquareFoot");
            yield return new TestCaseData(UnitConverterPressureUnit.MicronMercury, 1d, 7.500615758456564d).SetName("Pressure_FromBase_MicronMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.CentimeterMercury, 1d, 0.00075006157584565632d).SetName("Pressure_FromBase_CentimeterMercury");
            yield return new TestCaseData(UnitConverterPressureUnit.PoundForcePerSquareYard, 1d, 0.18796890809835115d).SetName("Pressure_FromBase_PoundForcePerSquareYard");
            yield return new TestCaseData(UnitConverterPressureUnit.OunceForcePerSquareInch, 1d, 0.0023206038036833478d).SetName("Pressure_FromBase_OunceForcePerSquareInch");
            yield return new TestCaseData(UnitConverterPressureUnit.GramForcePerSquareCentimeter, 1d, 0.010197162129779282d).SetName("Pressure_FromBase_GramForcePerSquareCentimeter");
        }
    }
}
