namespace UnitConverter.DynamicViscosity
{
    using UnitConverter.DynamicViscosity.Metric;
    using UnitConverter.DynamicViscosity.Imperial;
    using UnitConverter.DynamicViscosity.Engineering;
    using UnitConverter.DynamicViscosity.Scientific;

    public enum UnitConverterDynamicViscosityUnit
    {
        PascalSecond = 0,
        MillipascalSecond = 1,
        MicropascalSecond = 2,
        Poise = 3,
        Centipoise = 4,
        PoundPerFootSecond = 5,
        PoundForceSecondPerSquareFoot = 6,
        PoundForceSecondPerSquareInch = 7,
        KilopascalSecond = 8,
        MegapascalSecond = 9,
        NewtonSecondPerSquareMeter = 10,
        KilogramPerMeterSecond = 11,
        GramPerCentimeterSecond = 12,
        DyneSecondPerSquareCentimeter = 13,
        Millipoise = 14,
        Micropoise = 15,
        Reyn = 16,
        PoundPerFootHour = 17,
        PascalHour = 18,
        PascalMinute = 19,
        KilogramPerMeterHour = 20,
        GramPerCentimeterMinute = 21,
        SlugPerFootSecond = 22,
        SlugPerFootHour = 23,
        PoundPerInchSecond = 24,
        PoundPerInchHour = 25,
    }

    public static class UnitConverterDynamicViscosity
    {
        public static double Convert(double value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            double baseValue = ToPascalSecond(value, from);
            return FromPascalSecond(baseValue, to);
        }

        public static double ToPascalSecond(double value, UnitConverterDynamicViscosityUnit from)
        {
            switch (from)
            {
                case UnitConverterDynamicViscosityUnit.PascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.MillipascalSecond:
                    return UnitConverterMetricDynamicViscosity.MillipascalSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.MicropascalSecond:
                    return UnitConverterMetricDynamicViscosity.MicropascalSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.Poise:
                    return UnitConverterMetricDynamicViscosity.PoiseToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.Centipoise:
                    return UnitConverterMetricDynamicViscosity.CentipoiseToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitConverterImperialDynamicViscosity.PoundPerFootSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitConverterImperialDynamicViscosity.PoundForceSecondPerSquareFootToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitConverterImperialDynamicViscosity.PoundForceSecondPerSquareInchToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.KilopascalSecond:
                    return UnitConverterMetricDynamicViscosity.KilopascalSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.MegapascalSecond:
                    return UnitConverterMetricDynamicViscosity.MegapascalSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitConverterEngineeringDynamicViscosity.NewtonSecondPerSquareMeterToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitConverterMetricDynamicViscosity.KilogramPerMeterSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitConverterMetricDynamicViscosity.GramPerCentimeterSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitConverterScientificDynamicViscosity.DyneSecondPerSquareCentimeterToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.Millipoise:
                    return UnitConverterMetricDynamicViscosity.MillipoiseToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.Micropoise:
                    return UnitConverterMetricDynamicViscosity.MicropoiseToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.Reyn:
                    return UnitConverterImperialDynamicViscosity.ReynToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundPerFootHour:
                    return UnitConverterImperialDynamicViscosity.PoundPerFootHourToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PascalHour:
                    return UnitConverterMetricDynamicViscosity.PascalHourToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PascalMinute:
                    return UnitConverterMetricDynamicViscosity.PascalMinuteToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitConverterMetricDynamicViscosity.KilogramPerMeterHourToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitConverterMetricDynamicViscosity.GramPerCentimeterMinuteToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitConverterImperialDynamicViscosity.SlugPerFootSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.SlugPerFootHour:
                    return UnitConverterImperialDynamicViscosity.SlugPerFootHourToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitConverterImperialDynamicViscosity.PoundPerInchSecondToPascalSecond(value);
                case UnitConverterDynamicViscosityUnit.PoundPerInchHour:
                    return UnitConverterImperialDynamicViscosity.PoundPerInchHourToPascalSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dynamic viscosity unit.");
            }
        }

        public static double FromPascalSecond(double baseValue, UnitConverterDynamicViscosityUnit to)
        {
            switch (to)
            {
                case UnitConverterDynamicViscosityUnit.PascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToPascalSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.MillipascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToMillipascalSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.MicropascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToMicropascalSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.Poise:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToPoise(baseValue);
                case UnitConverterDynamicViscosityUnit.Centipoise:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToCentipoise(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundPerFootSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundForceSecondPerSquareFoot(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundForceSecondPerSquareInch(baseValue);
                case UnitConverterDynamicViscosityUnit.KilopascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToKilopascalSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.MegapascalSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToMegapascalSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitConverterEngineeringDynamicViscosity.PascalSecondToNewtonSecondPerSquareMeter(baseValue);
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToKilogramPerMeterSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToGramPerCentimeterSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitConverterScientificDynamicViscosity.PascalSecondToDyneSecondPerSquareCentimeter(baseValue);
                case UnitConverterDynamicViscosityUnit.Millipoise:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToMillipoise(baseValue);
                case UnitConverterDynamicViscosityUnit.Micropoise:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToMicropoise(baseValue);
                case UnitConverterDynamicViscosityUnit.Reyn:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToReyn(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundPerFootHour:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundPerFootHour(baseValue);
                case UnitConverterDynamicViscosityUnit.PascalHour:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToPascalHour(baseValue);
                case UnitConverterDynamicViscosityUnit.PascalMinute:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToPascalMinute(baseValue);
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToKilogramPerMeterHour(baseValue);
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitConverterMetricDynamicViscosity.PascalSecondToGramPerCentimeterMinute(baseValue);
                case UnitConverterDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToSlugPerFootSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.SlugPerFootHour:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToSlugPerFootHour(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundPerInchSecond(baseValue);
                case UnitConverterDynamicViscosityUnit.PoundPerInchHour:
                    return UnitConverterImperialDynamicViscosity.PascalSecondToPoundPerInchHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dynamic viscosity unit.");
            }
        }

        public static string GetSymbol(UnitConverterDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicViscosityUnit.PascalSecond:
                    return "Pa·s";
                case UnitConverterDynamicViscosityUnit.MillipascalSecond:
                    return "mPa·s";
                case UnitConverterDynamicViscosityUnit.MicropascalSecond:
                    return "µPa·s";
                case UnitConverterDynamicViscosityUnit.Poise:
                    return "P";
                case UnitConverterDynamicViscosityUnit.Centipoise:
                    return "cP";
                case UnitConverterDynamicViscosityUnit.PoundPerFootSecond:
                    return "lb/(ft·s)";
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return "lbf·s/ft²";
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return "lbf·s/in²";
                case UnitConverterDynamicViscosityUnit.KilopascalSecond:
                    return "kPa·s";
                case UnitConverterDynamicViscosityUnit.MegapascalSecond:
                    return "MPa·s";
                case UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return "N·s/m²";
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond:
                    return "kg/(m·s)";
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond:
                    return "g/(cm·s)";
                case UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return "dyn·s/cm²";
                case UnitConverterDynamicViscosityUnit.Millipoise:
                    return "mP";
                case UnitConverterDynamicViscosityUnit.Micropoise:
                    return "µP";
                case UnitConverterDynamicViscosityUnit.Reyn:
                    return "reyn";
                case UnitConverterDynamicViscosityUnit.PoundPerFootHour:
                    return "lb/(ft·h)";
                case UnitConverterDynamicViscosityUnit.PascalHour:
                    return "Pa·h";
                case UnitConverterDynamicViscosityUnit.PascalMinute:
                    return "Pa·min";
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterHour:
                    return "kg/(m·h)";
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute:
                    return "g/(cm·min)";
                case UnitConverterDynamicViscosityUnit.SlugPerFootSecond:
                    return "slug/(ft·s)";
                case UnitConverterDynamicViscosityUnit.SlugPerFootHour:
                    return "slug/(ft·h)";
                case UnitConverterDynamicViscosityUnit.PoundPerInchSecond:
                    return "lb/(in·s)";
                case UnitConverterDynamicViscosityUnit.PoundPerInchHour:
                    return "lb/(in·h)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicViscosityUnit.PascalSecond:
                    return "pascal second";
                case UnitConverterDynamicViscosityUnit.MillipascalSecond:
                    return "millipascal second";
                case UnitConverterDynamicViscosityUnit.MicropascalSecond:
                    return "micropascal second";
                case UnitConverterDynamicViscosityUnit.Poise:
                    return "poise";
                case UnitConverterDynamicViscosityUnit.Centipoise:
                    return "centipoise";
                case UnitConverterDynamicViscosityUnit.PoundPerFootSecond:
                    return "pound per foot second";
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return "pound-force second per square foot";
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return "pound-force second per square inch";
                case UnitConverterDynamicViscosityUnit.KilopascalSecond:
                    return "Kilopascal Second";
                case UnitConverterDynamicViscosityUnit.MegapascalSecond:
                    return "Megapascal Second";
                case UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return "Newton Second Per Square Meter";
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond:
                    return "Kilogram Per Meter Second";
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond:
                    return "Gram Per Centimeter Second";
                case UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return "Dyne Second Per Square Centimeter";
                case UnitConverterDynamicViscosityUnit.Millipoise:
                    return "Millipoise";
                case UnitConverterDynamicViscosityUnit.Micropoise:
                    return "Micropoise";
                case UnitConverterDynamicViscosityUnit.Reyn:
                    return "Reyn";
                case UnitConverterDynamicViscosityUnit.PoundPerFootHour:
                    return "Pound Per Foot Hour";
                case UnitConverterDynamicViscosityUnit.PascalHour:
                    return "Pascal Hour";
                case UnitConverterDynamicViscosityUnit.PascalMinute:
                    return "Pascal Minute";
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterHour:
                    return "Kilogram Per Meter Hour";
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute:
                    return "Gram Per Centimeter Minute";
                case UnitConverterDynamicViscosityUnit.SlugPerFootSecond:
                    return "Slug Per Foot Second";
                case UnitConverterDynamicViscosityUnit.SlugPerFootHour:
                    return "Slug Per Foot Hour";
                case UnitConverterDynamicViscosityUnit.PoundPerInchSecond:
                    return "Pound Per Inch Second";
                case UnitConverterDynamicViscosityUnit.PoundPerInchHour:
                    return "Pound Per Inch Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicViscosityUnit.PascalSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.MillipascalSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.MicropascalSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.Poise:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.Centipoise:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.KilopascalSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.MegapascalSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterDynamicViscosityUnit.Millipoise:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.Micropoise:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.Reyn:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PoundPerFootHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PascalHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.PascalMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.SlugPerFootHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicViscosityUnit.PoundPerInchHour:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDynamicViscosityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterDynamicViscosityUnit.PascalSecond, UnitConverterDynamicViscosityUnit.MillipascalSecond, UnitConverterDynamicViscosityUnit.MicropascalSecond, UnitConverterDynamicViscosityUnit.Poise, UnitConverterDynamicViscosityUnit.Centipoise, UnitConverterDynamicViscosityUnit.KilopascalSecond, UnitConverterDynamicViscosityUnit.MegapascalSecond, UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond, UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond, UnitConverterDynamicViscosityUnit.Millipoise, UnitConverterDynamicViscosityUnit.Micropoise, UnitConverterDynamicViscosityUnit.PascalHour, UnitConverterDynamicViscosityUnit.PascalMinute, UnitConverterDynamicViscosityUnit.KilogramPerMeterHour, UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterDynamicViscosityUnit.PoundPerFootSecond, UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot, UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch, UnitConverterDynamicViscosityUnit.Reyn, UnitConverterDynamicViscosityUnit.PoundPerFootHour, UnitConverterDynamicViscosityUnit.SlugPerFootSecond, UnitConverterDynamicViscosityUnit.SlugPerFootHour, UnitConverterDynamicViscosityUnit.PoundPerInchSecond, UnitConverterDynamicViscosityUnit.PoundPerInchHour };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter };
                default:
                    return new[] { UnitConverterDynamicViscosityUnit.PascalSecond, UnitConverterDynamicViscosityUnit.MillipascalSecond, UnitConverterDynamicViscosityUnit.MicropascalSecond, UnitConverterDynamicViscosityUnit.Poise, UnitConverterDynamicViscosityUnit.Centipoise, UnitConverterDynamicViscosityUnit.PoundPerFootSecond, UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareFoot, UnitConverterDynamicViscosityUnit.PoundForceSecondPerSquareInch, UnitConverterDynamicViscosityUnit.KilopascalSecond, UnitConverterDynamicViscosityUnit.MegapascalSecond, UnitConverterDynamicViscosityUnit.NewtonSecondPerSquareMeter, UnitConverterDynamicViscosityUnit.KilogramPerMeterSecond, UnitConverterDynamicViscosityUnit.GramPerCentimeterSecond, UnitConverterDynamicViscosityUnit.DyneSecondPerSquareCentimeter, UnitConverterDynamicViscosityUnit.Millipoise, UnitConverterDynamicViscosityUnit.Micropoise, UnitConverterDynamicViscosityUnit.Reyn, UnitConverterDynamicViscosityUnit.PoundPerFootHour, UnitConverterDynamicViscosityUnit.PascalHour, UnitConverterDynamicViscosityUnit.PascalMinute, UnitConverterDynamicViscosityUnit.KilogramPerMeterHour, UnitConverterDynamicViscosityUnit.GramPerCentimeterMinute, UnitConverterDynamicViscosityUnit.SlugPerFootSecond, UnitConverterDynamicViscosityUnit.SlugPerFootHour, UnitConverterDynamicViscosityUnit.PoundPerInchSecond, UnitConverterDynamicViscosityUnit.PoundPerInchHour };
            }
        }
    }
}
