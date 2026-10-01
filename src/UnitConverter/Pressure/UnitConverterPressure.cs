namespace UnitConverter.Pressure
{
    using UnitConverter.Pressure.Metric;
    using UnitConverter.Pressure.Scientific;
    using UnitConverter.Pressure.Imperial;
    using UnitConverter.Pressure.Engineering;
    using UnitConverter.Pressure.ImperialUS;

    public enum UnitConverterPressureUnit
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

    public static class UnitConverterPressure
    {
        public static double Convert(double value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitConverterPressureUnit from)
        {
            switch (from)
            {
                case UnitConverterPressureUnit.Pascal:
                    return UnitConverterMetricPressure.PascalToPascal(value);
                case UnitConverterPressureUnit.Hectopascal:
                    return UnitConverterMetricPressure.HectopascalToPascal(value);
                case UnitConverterPressureUnit.Kilopascal:
                    return UnitConverterMetricPressure.KilopascalToPascal(value);
                case UnitConverterPressureUnit.Megapascal:
                    return UnitConverterMetricPressure.MegapascalToPascal(value);
                case UnitConverterPressureUnit.Bar:
                    return UnitConverterMetricPressure.BarToPascal(value);
                case UnitConverterPressureUnit.Millibar:
                    return UnitConverterMetricPressure.MillibarToPascal(value);
                case UnitConverterPressureUnit.Atmosphere:
                    return UnitConverterScientificPressure.AtmosphereToPascal(value);
                case UnitConverterPressureUnit.Torr:
                    return UnitConverterScientificPressure.TorrToPascal(value);
                case UnitConverterPressureUnit.MillimeterMercury:
                    return UnitConverterScientificPressure.MillimeterMercuryToPascal(value);
                case UnitConverterPressureUnit.InchMercury:
                    return UnitConverterImperialPressure.InchMercuryToPascal(value);
                case UnitConverterPressureUnit.Psi:
                    return UnitConverterImperialPressure.PsiToPascal(value);
                case UnitConverterPressureUnit.Psf:
                    return UnitConverterImperialPressure.PsfToPascal(value);
                case UnitConverterPressureUnit.Barye:
                    return UnitConverterScientificPressure.BaryeToPascal(value);
                case UnitConverterPressureUnit.Micropascal:
                    return UnitConverterMetricPressure.MicropascalToPascal(value);
                case UnitConverterPressureUnit.Millipascal:
                    return UnitConverterMetricPressure.MillipascalToPascal(value);
                case UnitConverterPressureUnit.Gigapascal:
                    return UnitConverterMetricPressure.GigapascalToPascal(value);
                case UnitConverterPressureUnit.TechnicalAtmosphere:
                    return UnitConverterEngineeringPressure.TechnicalAtmosphereToPascal(value);
                case UnitConverterPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringPressure.KilogramForcePerSquareCentimeterToPascal(value);
                case UnitConverterPressureUnit.MillimeterWater:
                    return UnitConverterEngineeringPressure.MillimeterWaterToPascal(value);
                case UnitConverterPressureUnit.CentimeterWater:
                    return UnitConverterEngineeringPressure.CentimeterWaterToPascal(value);
                case UnitConverterPressureUnit.InchWater:
                    return UnitConverterImperialPressure.InchWaterToPascal(value);
                case UnitConverterPressureUnit.FootWater:
                    return UnitConverterImperialPressure.FootWaterToPascal(value);
                case UnitConverterPressureUnit.MeterWater:
                    return UnitConverterEngineeringPressure.MeterWaterToPascal(value);
                case UnitConverterPressureUnit.DynePerSquareCentimeter:
                    return UnitConverterScientificPressure.DynePerSquareCentimeterToPascal(value);
                case UnitConverterPressureUnit.KilopoundPerSquareInch:
                    return UnitConverterImperialPressure.KilopoundPerSquareInchToPascal(value);
                case UnitConverterPressureUnit.TonForceUSPerSquareFoot:
                    return UnitConverterImperialUSPressure.TonForceUSPerSquareFootToPascal(value);
                case UnitConverterPressureUnit.MicronMercury:
                    return UnitConverterMetricPressure.MicronMercuryToPascal(value);
                case UnitConverterPressureUnit.CentimeterMercury:
                    return UnitConverterMetricPressure.CentimeterMercuryToPascal(value);
                case UnitConverterPressureUnit.PoundForcePerSquareYard:
                    return UnitConverterImperialPressure.PoundForcePerSquareYardToPascal(value);
                case UnitConverterPressureUnit.OunceForcePerSquareInch:
                    return UnitConverterImperialPressure.OunceForcePerSquareInchToPascal(value);
                case UnitConverterPressureUnit.GramForcePerSquareCentimeter:
                    return UnitConverterMetricPressure.GramForcePerSquareCentimeterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitConverterPressureUnit to)
        {
            switch (to)
            {
                case UnitConverterPressureUnit.Pascal:
                    return UnitConverterMetricPressure.PascalToPascal(baseValue);
                case UnitConverterPressureUnit.Hectopascal:
                    return UnitConverterMetricPressure.PascalToHectopascal(baseValue);
                case UnitConverterPressureUnit.Kilopascal:
                    return UnitConverterMetricPressure.PascalToKilopascal(baseValue);
                case UnitConverterPressureUnit.Megapascal:
                    return UnitConverterMetricPressure.PascalToMegapascal(baseValue);
                case UnitConverterPressureUnit.Bar:
                    return UnitConverterMetricPressure.PascalToBar(baseValue);
                case UnitConverterPressureUnit.Millibar:
                    return UnitConverterMetricPressure.PascalToMillibar(baseValue);
                case UnitConverterPressureUnit.Atmosphere:
                    return UnitConverterScientificPressure.PascalToAtmosphere(baseValue);
                case UnitConverterPressureUnit.Torr:
                    return UnitConverterScientificPressure.PascalToTorr(baseValue);
                case UnitConverterPressureUnit.MillimeterMercury:
                    return UnitConverterScientificPressure.PascalToMillimeterMercury(baseValue);
                case UnitConverterPressureUnit.InchMercury:
                    return UnitConverterImperialPressure.PascalToInchMercury(baseValue);
                case UnitConverterPressureUnit.Psi:
                    return UnitConverterImperialPressure.PascalToPsi(baseValue);
                case UnitConverterPressureUnit.Psf:
                    return UnitConverterImperialPressure.PascalToPsf(baseValue);
                case UnitConverterPressureUnit.Barye:
                    return UnitConverterScientificPressure.PascalToBarye(baseValue);
                case UnitConverterPressureUnit.Micropascal:
                    return UnitConverterMetricPressure.PascalToMicropascal(baseValue);
                case UnitConverterPressureUnit.Millipascal:
                    return UnitConverterMetricPressure.PascalToMillipascal(baseValue);
                case UnitConverterPressureUnit.Gigapascal:
                    return UnitConverterMetricPressure.PascalToGigapascal(baseValue);
                case UnitConverterPressureUnit.TechnicalAtmosphere:
                    return UnitConverterEngineeringPressure.PascalToTechnicalAtmosphere(baseValue);
                case UnitConverterPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                case UnitConverterPressureUnit.MillimeterWater:
                    return UnitConverterEngineeringPressure.PascalToMillimeterWater(baseValue);
                case UnitConverterPressureUnit.CentimeterWater:
                    return UnitConverterEngineeringPressure.PascalToCentimeterWater(baseValue);
                case UnitConverterPressureUnit.InchWater:
                    return UnitConverterImperialPressure.PascalToInchWater(baseValue);
                case UnitConverterPressureUnit.FootWater:
                    return UnitConverterImperialPressure.PascalToFootWater(baseValue);
                case UnitConverterPressureUnit.MeterWater:
                    return UnitConverterEngineeringPressure.PascalToMeterWater(baseValue);
                case UnitConverterPressureUnit.DynePerSquareCentimeter:
                    return UnitConverterScientificPressure.PascalToDynePerSquareCentimeter(baseValue);
                case UnitConverterPressureUnit.KilopoundPerSquareInch:
                    return UnitConverterImperialPressure.PascalToKilopoundPerSquareInch(baseValue);
                case UnitConverterPressureUnit.TonForceUSPerSquareFoot:
                    return UnitConverterImperialUSPressure.PascalToTonForceUSPerSquareFoot(baseValue);
                case UnitConverterPressureUnit.MicronMercury:
                    return UnitConverterMetricPressure.PascalToMicronMercury(baseValue);
                case UnitConverterPressureUnit.CentimeterMercury:
                    return UnitConverterMetricPressure.PascalToCentimeterMercury(baseValue);
                case UnitConverterPressureUnit.PoundForcePerSquareYard:
                    return UnitConverterImperialPressure.PascalToPoundForcePerSquareYard(baseValue);
                case UnitConverterPressureUnit.OunceForcePerSquareInch:
                    return UnitConverterImperialPressure.PascalToOunceForcePerSquareInch(baseValue);
                case UnitConverterPressureUnit.GramForcePerSquareCentimeter:
                    return UnitConverterMetricPressure.PascalToGramForcePerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pressure unit.");
            }
        }

        public static string GetSymbol(UnitConverterPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureUnit.Pascal:
                    return "Pa";
                case UnitConverterPressureUnit.Hectopascal:
                    return "hPa";
                case UnitConverterPressureUnit.Kilopascal:
                    return "kPa";
                case UnitConverterPressureUnit.Megapascal:
                    return "MPa";
                case UnitConverterPressureUnit.Bar:
                    return "bar";
                case UnitConverterPressureUnit.Millibar:
                    return "mbar";
                case UnitConverterPressureUnit.Atmosphere:
                    return "atm";
                case UnitConverterPressureUnit.Torr:
                    return "Torr";
                case UnitConverterPressureUnit.MillimeterMercury:
                    return "mmHg";
                case UnitConverterPressureUnit.InchMercury:
                    return "inHg";
                case UnitConverterPressureUnit.Psi:
                    return "psi";
                case UnitConverterPressureUnit.Psf:
                    return "psf";
                case UnitConverterPressureUnit.Barye:
                    return "Ba";
                case UnitConverterPressureUnit.Micropascal:
                    return "µPa";
                case UnitConverterPressureUnit.Millipascal:
                    return "mPa";
                case UnitConverterPressureUnit.Gigapascal:
                    return "GPa";
                case UnitConverterPressureUnit.TechnicalAtmosphere:
                    return "at";
                case UnitConverterPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                case UnitConverterPressureUnit.MillimeterWater:
                    return "mmH₂O";
                case UnitConverterPressureUnit.CentimeterWater:
                    return "cmH₂O";
                case UnitConverterPressureUnit.InchWater:
                    return "inH₂O";
                case UnitConverterPressureUnit.FootWater:
                    return "ftH₂O";
                case UnitConverterPressureUnit.MeterWater:
                    return "mH₂O";
                case UnitConverterPressureUnit.DynePerSquareCentimeter:
                    return "dyn/cm²";
                case UnitConverterPressureUnit.KilopoundPerSquareInch:
                    return "ksi";
                case UnitConverterPressureUnit.TonForceUSPerSquareFoot:
                    return "tonf/ft² US";
                case UnitConverterPressureUnit.MicronMercury:
                    return "µmHg";
                case UnitConverterPressureUnit.CentimeterMercury:
                    return "cmHg";
                case UnitConverterPressureUnit.PoundForcePerSquareYard:
                    return "lbf/yd²";
                case UnitConverterPressureUnit.OunceForcePerSquareInch:
                    return "ozf/in²";
                case UnitConverterPressureUnit.GramForcePerSquareCentimeter:
                    return "gf/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureUnit.Pascal:
                    return "pascal";
                case UnitConverterPressureUnit.Hectopascal:
                    return "hectopascal";
                case UnitConverterPressureUnit.Kilopascal:
                    return "kilopascal";
                case UnitConverterPressureUnit.Megapascal:
                    return "megapascal";
                case UnitConverterPressureUnit.Bar:
                    return "bar";
                case UnitConverterPressureUnit.Millibar:
                    return "millibar";
                case UnitConverterPressureUnit.Atmosphere:
                    return "standard atmosphere";
                case UnitConverterPressureUnit.Torr:
                    return "torr";
                case UnitConverterPressureUnit.MillimeterMercury:
                    return "millimeter mercury";
                case UnitConverterPressureUnit.InchMercury:
                    return "inch mercury";
                case UnitConverterPressureUnit.Psi:
                    return "pound per square inch";
                case UnitConverterPressureUnit.Psf:
                    return "pound per square foot";
                case UnitConverterPressureUnit.Barye:
                    return "barye";
                case UnitConverterPressureUnit.Micropascal:
                    return "Micropascal";
                case UnitConverterPressureUnit.Millipascal:
                    return "Millipascal";
                case UnitConverterPressureUnit.Gigapascal:
                    return "Gigapascal";
                case UnitConverterPressureUnit.TechnicalAtmosphere:
                    return "Technical Atmosphere";
                case UnitConverterPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                case UnitConverterPressureUnit.MillimeterWater:
                    return "Millimeter Water";
                case UnitConverterPressureUnit.CentimeterWater:
                    return "Centimeter Water";
                case UnitConverterPressureUnit.InchWater:
                    return "Inch Water";
                case UnitConverterPressureUnit.FootWater:
                    return "Foot Water";
                case UnitConverterPressureUnit.MeterWater:
                    return "Meter Water";
                case UnitConverterPressureUnit.DynePerSquareCentimeter:
                    return "Dyne Per Square Centimeter";
                case UnitConverterPressureUnit.KilopoundPerSquareInch:
                    return "Kilopound Per Square Inch";
                case UnitConverterPressureUnit.TonForceUSPerSquareFoot:
                    return "Ton Force US Per Square Foot";
                case UnitConverterPressureUnit.MicronMercury:
                    return "Micron Mercury";
                case UnitConverterPressureUnit.CentimeterMercury:
                    return "Centimeter Mercury";
                case UnitConverterPressureUnit.PoundForcePerSquareYard:
                    return "Pound Force Per Square Yard";
                case UnitConverterPressureUnit.OunceForcePerSquareInch:
                    return "Ounce Force Per Square Inch";
                case UnitConverterPressureUnit.GramForcePerSquareCentimeter:
                    return "Gram Force Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureUnit.Pascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Hectopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Kilopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Megapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Bar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Millibar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Atmosphere:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPressureUnit.Torr:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPressureUnit.MillimeterMercury:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPressureUnit.InchMercury:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.Psi:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.Psf:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.Barye:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPressureUnit.Micropascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Millipascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.Gigapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.TechnicalAtmosphere:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPressureUnit.MillimeterWater:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPressureUnit.CentimeterWater:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPressureUnit.InchWater:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.FootWater:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.MeterWater:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPressureUnit.DynePerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPressureUnit.KilopoundPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.TonForceUSPerSquareFoot:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterPressureUnit.MicronMercury:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.CentimeterMercury:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureUnit.PoundForcePerSquareYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.OunceForcePerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureUnit.GramForcePerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPressureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPressureUnit.Pascal, UnitConverterPressureUnit.Hectopascal, UnitConverterPressureUnit.Kilopascal, UnitConverterPressureUnit.Megapascal, UnitConverterPressureUnit.Bar, UnitConverterPressureUnit.Millibar, UnitConverterPressureUnit.Micropascal, UnitConverterPressureUnit.Millipascal, UnitConverterPressureUnit.Gigapascal, UnitConverterPressureUnit.MicronMercury, UnitConverterPressureUnit.CentimeterMercury, UnitConverterPressureUnit.GramForcePerSquareCentimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterPressureUnit.Atmosphere, UnitConverterPressureUnit.Torr, UnitConverterPressureUnit.MillimeterMercury, UnitConverterPressureUnit.Barye, UnitConverterPressureUnit.DynePerSquareCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPressureUnit.InchMercury, UnitConverterPressureUnit.Psi, UnitConverterPressureUnit.Psf, UnitConverterPressureUnit.InchWater, UnitConverterPressureUnit.FootWater, UnitConverterPressureUnit.KilopoundPerSquareInch, UnitConverterPressureUnit.PoundForcePerSquareYard, UnitConverterPressureUnit.OunceForcePerSquareInch };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterPressureUnit.TechnicalAtmosphere, UnitConverterPressureUnit.KilogramForcePerSquareCentimeter, UnitConverterPressureUnit.MillimeterWater, UnitConverterPressureUnit.CentimeterWater, UnitConverterPressureUnit.MeterWater };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterPressureUnit.TonForceUSPerSquareFoot };
                default:
                    return new[] { UnitConverterPressureUnit.Pascal, UnitConverterPressureUnit.Hectopascal, UnitConverterPressureUnit.Kilopascal, UnitConverterPressureUnit.Megapascal, UnitConverterPressureUnit.Bar, UnitConverterPressureUnit.Millibar, UnitConverterPressureUnit.Atmosphere, UnitConverterPressureUnit.Torr, UnitConverterPressureUnit.MillimeterMercury, UnitConverterPressureUnit.InchMercury, UnitConverterPressureUnit.Psi, UnitConverterPressureUnit.Psf, UnitConverterPressureUnit.Barye, UnitConverterPressureUnit.Micropascal, UnitConverterPressureUnit.Millipascal, UnitConverterPressureUnit.Gigapascal, UnitConverterPressureUnit.TechnicalAtmosphere, UnitConverterPressureUnit.KilogramForcePerSquareCentimeter, UnitConverterPressureUnit.MillimeterWater, UnitConverterPressureUnit.CentimeterWater, UnitConverterPressureUnit.InchWater, UnitConverterPressureUnit.FootWater, UnitConverterPressureUnit.MeterWater, UnitConverterPressureUnit.DynePerSquareCentimeter, UnitConverterPressureUnit.KilopoundPerSquareInch, UnitConverterPressureUnit.TonForceUSPerSquareFoot, UnitConverterPressureUnit.MicronMercury, UnitConverterPressureUnit.CentimeterMercury, UnitConverterPressureUnit.PoundForcePerSquareYard, UnitConverterPressureUnit.OunceForcePerSquareInch, UnitConverterPressureUnit.GramForcePerSquareCentimeter };
            }
        }
    }
}
