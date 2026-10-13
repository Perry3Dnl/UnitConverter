namespace UnitTools.Pressure
{
    using UnitTools.Pressure.Metric;
    using UnitTools.Pressure.Scientific;
    using UnitTools.Pressure.Imperial;
    using UnitTools.Pressure.Engineering;
    using UnitTools.Pressure.ImperialUS;

    public enum UnitToolsPressureUnit
    {
        Pascal = 0,
        Hectopascal = 1,
        Kilopascal = 2,
        Megapascal = 3,
        Bar = 4,
        Millibar = 5,
        Atmosphere = 6,
        Torr = 7,
        MillimeterMercury = 8,
        InchMercury = 9,
        Psi = 10,
        Psf = 11,
        Barye = 12,
        Micropascal = 13,
        Millipascal = 14,
        Gigapascal = 15,
        TechnicalAtmosphere = 16,
        KilogramForcePerSquareCentimeter = 17,
        MillimeterWater = 18,
        CentimeterWater = 19,
        InchWater = 20,
        FootWater = 21,
        MeterWater = 22,
        DynePerSquareCentimeter = 23,
        KilopoundPerSquareInch = 24,
        TonForceUSPerSquareFoot = 25,
        MicronMercury = 26,
        CentimeterMercury = 27,
        PoundForcePerSquareYard = 28,
        OunceForcePerSquareInch = 29,
        GramForcePerSquareCentimeter = 30,
    }

    public static class UnitToolsPressure
    {
        public static double Convert(double value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitToolsPressureUnit from)
        {
            switch (from)
            {
                case UnitToolsPressureUnit.Pascal:
                    return UnitToolsMetricPressure.PascalToPascal(value);
                case UnitToolsPressureUnit.Hectopascal:
                    return UnitToolsMetricPressure.HectopascalToPascal(value);
                case UnitToolsPressureUnit.Kilopascal:
                    return UnitToolsMetricPressure.KilopascalToPascal(value);
                case UnitToolsPressureUnit.Megapascal:
                    return UnitToolsMetricPressure.MegapascalToPascal(value);
                case UnitToolsPressureUnit.Bar:
                    return UnitToolsMetricPressure.BarToPascal(value);
                case UnitToolsPressureUnit.Millibar:
                    return UnitToolsMetricPressure.MillibarToPascal(value);
                case UnitToolsPressureUnit.Atmosphere:
                    return UnitToolsScientificPressure.AtmosphereToPascal(value);
                case UnitToolsPressureUnit.Torr:
                    return UnitToolsScientificPressure.TorrToPascal(value);
                case UnitToolsPressureUnit.MillimeterMercury:
                    return UnitToolsScientificPressure.MillimeterMercuryToPascal(value);
                case UnitToolsPressureUnit.InchMercury:
                    return UnitToolsImperialPressure.InchMercuryToPascal(value);
                case UnitToolsPressureUnit.Psi:
                    return UnitToolsImperialPressure.PsiToPascal(value);
                case UnitToolsPressureUnit.Psf:
                    return UnitToolsImperialPressure.PsfToPascal(value);
                case UnitToolsPressureUnit.Barye:
                    return UnitToolsScientificPressure.BaryeToPascal(value);
                case UnitToolsPressureUnit.Micropascal:
                    return UnitToolsMetricPressure.MicropascalToPascal(value);
                case UnitToolsPressureUnit.Millipascal:
                    return UnitToolsMetricPressure.MillipascalToPascal(value);
                case UnitToolsPressureUnit.Gigapascal:
                    return UnitToolsMetricPressure.GigapascalToPascal(value);
                case UnitToolsPressureUnit.TechnicalAtmosphere:
                    return UnitToolsEngineeringPressure.TechnicalAtmosphereToPascal(value);
                case UnitToolsPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringPressure.KilogramForcePerSquareCentimeterToPascal(value);
                case UnitToolsPressureUnit.MillimeterWater:
                    return UnitToolsEngineeringPressure.MillimeterWaterToPascal(value);
                case UnitToolsPressureUnit.CentimeterWater:
                    return UnitToolsEngineeringPressure.CentimeterWaterToPascal(value);
                case UnitToolsPressureUnit.InchWater:
                    return UnitToolsImperialPressure.InchWaterToPascal(value);
                case UnitToolsPressureUnit.FootWater:
                    return UnitToolsImperialPressure.FootWaterToPascal(value);
                case UnitToolsPressureUnit.MeterWater:
                    return UnitToolsEngineeringPressure.MeterWaterToPascal(value);
                case UnitToolsPressureUnit.DynePerSquareCentimeter:
                    return UnitToolsScientificPressure.DynePerSquareCentimeterToPascal(value);
                case UnitToolsPressureUnit.KilopoundPerSquareInch:
                    return UnitToolsImperialPressure.KilopoundPerSquareInchToPascal(value);
                case UnitToolsPressureUnit.TonForceUSPerSquareFoot:
                    return UnitToolsImperialUSPressure.TonForceUSPerSquareFootToPascal(value);
                case UnitToolsPressureUnit.MicronMercury:
                    return UnitToolsMetricPressure.MicronMercuryToPascal(value);
                case UnitToolsPressureUnit.CentimeterMercury:
                    return UnitToolsMetricPressure.CentimeterMercuryToPascal(value);
                case UnitToolsPressureUnit.PoundForcePerSquareYard:
                    return UnitToolsImperialPressure.PoundForcePerSquareYardToPascal(value);
                case UnitToolsPressureUnit.OunceForcePerSquareInch:
                    return UnitToolsImperialPressure.OunceForcePerSquareInchToPascal(value);
                case UnitToolsPressureUnit.GramForcePerSquareCentimeter:
                    return UnitToolsMetricPressure.GramForcePerSquareCentimeterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitToolsPressureUnit to)
        {
            switch (to)
            {
                case UnitToolsPressureUnit.Pascal:
                    return UnitToolsMetricPressure.PascalToPascal(baseValue);
                case UnitToolsPressureUnit.Hectopascal:
                    return UnitToolsMetricPressure.PascalToHectopascal(baseValue);
                case UnitToolsPressureUnit.Kilopascal:
                    return UnitToolsMetricPressure.PascalToKilopascal(baseValue);
                case UnitToolsPressureUnit.Megapascal:
                    return UnitToolsMetricPressure.PascalToMegapascal(baseValue);
                case UnitToolsPressureUnit.Bar:
                    return UnitToolsMetricPressure.PascalToBar(baseValue);
                case UnitToolsPressureUnit.Millibar:
                    return UnitToolsMetricPressure.PascalToMillibar(baseValue);
                case UnitToolsPressureUnit.Atmosphere:
                    return UnitToolsScientificPressure.PascalToAtmosphere(baseValue);
                case UnitToolsPressureUnit.Torr:
                    return UnitToolsScientificPressure.PascalToTorr(baseValue);
                case UnitToolsPressureUnit.MillimeterMercury:
                    return UnitToolsScientificPressure.PascalToMillimeterMercury(baseValue);
                case UnitToolsPressureUnit.InchMercury:
                    return UnitToolsImperialPressure.PascalToInchMercury(baseValue);
                case UnitToolsPressureUnit.Psi:
                    return UnitToolsImperialPressure.PascalToPsi(baseValue);
                case UnitToolsPressureUnit.Psf:
                    return UnitToolsImperialPressure.PascalToPsf(baseValue);
                case UnitToolsPressureUnit.Barye:
                    return UnitToolsScientificPressure.PascalToBarye(baseValue);
                case UnitToolsPressureUnit.Micropascal:
                    return UnitToolsMetricPressure.PascalToMicropascal(baseValue);
                case UnitToolsPressureUnit.Millipascal:
                    return UnitToolsMetricPressure.PascalToMillipascal(baseValue);
                case UnitToolsPressureUnit.Gigapascal:
                    return UnitToolsMetricPressure.PascalToGigapascal(baseValue);
                case UnitToolsPressureUnit.TechnicalAtmosphere:
                    return UnitToolsEngineeringPressure.PascalToTechnicalAtmosphere(baseValue);
                case UnitToolsPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                case UnitToolsPressureUnit.MillimeterWater:
                    return UnitToolsEngineeringPressure.PascalToMillimeterWater(baseValue);
                case UnitToolsPressureUnit.CentimeterWater:
                    return UnitToolsEngineeringPressure.PascalToCentimeterWater(baseValue);
                case UnitToolsPressureUnit.InchWater:
                    return UnitToolsImperialPressure.PascalToInchWater(baseValue);
                case UnitToolsPressureUnit.FootWater:
                    return UnitToolsImperialPressure.PascalToFootWater(baseValue);
                case UnitToolsPressureUnit.MeterWater:
                    return UnitToolsEngineeringPressure.PascalToMeterWater(baseValue);
                case UnitToolsPressureUnit.DynePerSquareCentimeter:
                    return UnitToolsScientificPressure.PascalToDynePerSquareCentimeter(baseValue);
                case UnitToolsPressureUnit.KilopoundPerSquareInch:
                    return UnitToolsImperialPressure.PascalToKilopoundPerSquareInch(baseValue);
                case UnitToolsPressureUnit.TonForceUSPerSquareFoot:
                    return UnitToolsImperialUSPressure.PascalToTonForceUSPerSquareFoot(baseValue);
                case UnitToolsPressureUnit.MicronMercury:
                    return UnitToolsMetricPressure.PascalToMicronMercury(baseValue);
                case UnitToolsPressureUnit.CentimeterMercury:
                    return UnitToolsMetricPressure.PascalToCentimeterMercury(baseValue);
                case UnitToolsPressureUnit.PoundForcePerSquareYard:
                    return UnitToolsImperialPressure.PascalToPoundForcePerSquareYard(baseValue);
                case UnitToolsPressureUnit.OunceForcePerSquareInch:
                    return UnitToolsImperialPressure.PascalToOunceForcePerSquareInch(baseValue);
                case UnitToolsPressureUnit.GramForcePerSquareCentimeter:
                    return UnitToolsMetricPressure.PascalToGramForcePerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pressure unit.");
            }
        }

        public static string GetSymbol(UnitToolsPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureUnit.Pascal:
                    return "Pa";
                case UnitToolsPressureUnit.Hectopascal:
                    return "hPa";
                case UnitToolsPressureUnit.Kilopascal:
                    return "kPa";
                case UnitToolsPressureUnit.Megapascal:
                    return "MPa";
                case UnitToolsPressureUnit.Bar:
                    return "bar";
                case UnitToolsPressureUnit.Millibar:
                    return "mbar";
                case UnitToolsPressureUnit.Atmosphere:
                    return "atm";
                case UnitToolsPressureUnit.Torr:
                    return "Torr";
                case UnitToolsPressureUnit.MillimeterMercury:
                    return "mmHg";
                case UnitToolsPressureUnit.InchMercury:
                    return "inHg";
                case UnitToolsPressureUnit.Psi:
                    return "psi";
                case UnitToolsPressureUnit.Psf:
                    return "psf";
                case UnitToolsPressureUnit.Barye:
                    return "Ba";
                case UnitToolsPressureUnit.Micropascal:
                    return "µPa";
                case UnitToolsPressureUnit.Millipascal:
                    return "mPa";
                case UnitToolsPressureUnit.Gigapascal:
                    return "GPa";
                case UnitToolsPressureUnit.TechnicalAtmosphere:
                    return "at";
                case UnitToolsPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                case UnitToolsPressureUnit.MillimeterWater:
                    return "mmH₂O";
                case UnitToolsPressureUnit.CentimeterWater:
                    return "cmH₂O";
                case UnitToolsPressureUnit.InchWater:
                    return "inH₂O";
                case UnitToolsPressureUnit.FootWater:
                    return "ftH₂O";
                case UnitToolsPressureUnit.MeterWater:
                    return "mH₂O";
                case UnitToolsPressureUnit.DynePerSquareCentimeter:
                    return "dyn/cm²";
                case UnitToolsPressureUnit.KilopoundPerSquareInch:
                    return "ksi";
                case UnitToolsPressureUnit.TonForceUSPerSquareFoot:
                    return "tonf/ft² US";
                case UnitToolsPressureUnit.MicronMercury:
                    return "µmHg";
                case UnitToolsPressureUnit.CentimeterMercury:
                    return "cmHg";
                case UnitToolsPressureUnit.PoundForcePerSquareYard:
                    return "lbf/yd²";
                case UnitToolsPressureUnit.OunceForcePerSquareInch:
                    return "ozf/in²";
                case UnitToolsPressureUnit.GramForcePerSquareCentimeter:
                    return "gf/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureUnit.Pascal:
                    return "pascal";
                case UnitToolsPressureUnit.Hectopascal:
                    return "hectopascal";
                case UnitToolsPressureUnit.Kilopascal:
                    return "kilopascal";
                case UnitToolsPressureUnit.Megapascal:
                    return "megapascal";
                case UnitToolsPressureUnit.Bar:
                    return "bar";
                case UnitToolsPressureUnit.Millibar:
                    return "millibar";
                case UnitToolsPressureUnit.Atmosphere:
                    return "standard atmosphere";
                case UnitToolsPressureUnit.Torr:
                    return "torr";
                case UnitToolsPressureUnit.MillimeterMercury:
                    return "millimeter mercury";
                case UnitToolsPressureUnit.InchMercury:
                    return "inch mercury";
                case UnitToolsPressureUnit.Psi:
                    return "pound per square inch";
                case UnitToolsPressureUnit.Psf:
                    return "pound per square foot";
                case UnitToolsPressureUnit.Barye:
                    return "barye";
                case UnitToolsPressureUnit.Micropascal:
                    return "Micropascal";
                case UnitToolsPressureUnit.Millipascal:
                    return "Millipascal";
                case UnitToolsPressureUnit.Gigapascal:
                    return "Gigapascal";
                case UnitToolsPressureUnit.TechnicalAtmosphere:
                    return "Technical Atmosphere";
                case UnitToolsPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                case UnitToolsPressureUnit.MillimeterWater:
                    return "Millimeter Water";
                case UnitToolsPressureUnit.CentimeterWater:
                    return "Centimeter Water";
                case UnitToolsPressureUnit.InchWater:
                    return "Inch Water";
                case UnitToolsPressureUnit.FootWater:
                    return "Foot Water";
                case UnitToolsPressureUnit.MeterWater:
                    return "Meter Water";
                case UnitToolsPressureUnit.DynePerSquareCentimeter:
                    return "Dyne Per Square Centimeter";
                case UnitToolsPressureUnit.KilopoundPerSquareInch:
                    return "Kilopound Per Square Inch";
                case UnitToolsPressureUnit.TonForceUSPerSquareFoot:
                    return "Ton Force US Per Square Foot";
                case UnitToolsPressureUnit.MicronMercury:
                    return "Micron Mercury";
                case UnitToolsPressureUnit.CentimeterMercury:
                    return "Centimeter Mercury";
                case UnitToolsPressureUnit.PoundForcePerSquareYard:
                    return "Pound Force Per Square Yard";
                case UnitToolsPressureUnit.OunceForcePerSquareInch:
                    return "Ounce Force Per Square Inch";
                case UnitToolsPressureUnit.GramForcePerSquareCentimeter:
                    return "Gram Force Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureUnit.Pascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Hectopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Kilopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Megapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Bar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Millibar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Atmosphere:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPressureUnit.Torr:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPressureUnit.MillimeterMercury:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPressureUnit.InchMercury:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.Psi:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.Psf:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.Barye:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPressureUnit.Micropascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Millipascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.Gigapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.TechnicalAtmosphere:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPressureUnit.MillimeterWater:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPressureUnit.CentimeterWater:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPressureUnit.InchWater:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.FootWater:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.MeterWater:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPressureUnit.DynePerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPressureUnit.KilopoundPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.TonForceUSPerSquareFoot:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsPressureUnit.MicronMercury:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.CentimeterMercury:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureUnit.PoundForcePerSquareYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.OunceForcePerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureUnit.GramForcePerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPressureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPressureUnit.Pascal, UnitToolsPressureUnit.Hectopascal, UnitToolsPressureUnit.Kilopascal, UnitToolsPressureUnit.Megapascal, UnitToolsPressureUnit.Bar, UnitToolsPressureUnit.Millibar, UnitToolsPressureUnit.Micropascal, UnitToolsPressureUnit.Millipascal, UnitToolsPressureUnit.Gigapascal, UnitToolsPressureUnit.MicronMercury, UnitToolsPressureUnit.CentimeterMercury, UnitToolsPressureUnit.GramForcePerSquareCentimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsPressureUnit.Atmosphere, UnitToolsPressureUnit.Torr, UnitToolsPressureUnit.MillimeterMercury, UnitToolsPressureUnit.Barye, UnitToolsPressureUnit.DynePerSquareCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPressureUnit.InchMercury, UnitToolsPressureUnit.Psi, UnitToolsPressureUnit.Psf, UnitToolsPressureUnit.InchWater, UnitToolsPressureUnit.FootWater, UnitToolsPressureUnit.KilopoundPerSquareInch, UnitToolsPressureUnit.PoundForcePerSquareYard, UnitToolsPressureUnit.OunceForcePerSquareInch };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsPressureUnit.TechnicalAtmosphere, UnitToolsPressureUnit.KilogramForcePerSquareCentimeter, UnitToolsPressureUnit.MillimeterWater, UnitToolsPressureUnit.CentimeterWater, UnitToolsPressureUnit.MeterWater };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsPressureUnit.TonForceUSPerSquareFoot };
                default:
                    return new[] { UnitToolsPressureUnit.Pascal, UnitToolsPressureUnit.Hectopascal, UnitToolsPressureUnit.Kilopascal, UnitToolsPressureUnit.Megapascal, UnitToolsPressureUnit.Bar, UnitToolsPressureUnit.Millibar, UnitToolsPressureUnit.Atmosphere, UnitToolsPressureUnit.Torr, UnitToolsPressureUnit.MillimeterMercury, UnitToolsPressureUnit.InchMercury, UnitToolsPressureUnit.Psi, UnitToolsPressureUnit.Psf, UnitToolsPressureUnit.Barye, UnitToolsPressureUnit.Micropascal, UnitToolsPressureUnit.Millipascal, UnitToolsPressureUnit.Gigapascal, UnitToolsPressureUnit.TechnicalAtmosphere, UnitToolsPressureUnit.KilogramForcePerSquareCentimeter, UnitToolsPressureUnit.MillimeterWater, UnitToolsPressureUnit.CentimeterWater, UnitToolsPressureUnit.InchWater, UnitToolsPressureUnit.FootWater, UnitToolsPressureUnit.MeterWater, UnitToolsPressureUnit.DynePerSquareCentimeter, UnitToolsPressureUnit.KilopoundPerSquareInch, UnitToolsPressureUnit.TonForceUSPerSquareFoot, UnitToolsPressureUnit.MicronMercury, UnitToolsPressureUnit.CentimeterMercury, UnitToolsPressureUnit.PoundForcePerSquareYard, UnitToolsPressureUnit.OunceForcePerSquareInch, UnitToolsPressureUnit.GramForcePerSquareCentimeter };
            }
        }
    }
}
