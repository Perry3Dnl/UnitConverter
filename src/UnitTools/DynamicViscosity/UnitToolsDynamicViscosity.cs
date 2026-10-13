namespace UnitTools.DynamicViscosity
{
    using UnitTools.DynamicViscosity.Metric;
    using UnitTools.DynamicViscosity.Imperial;
    using UnitTools.DynamicViscosity.Engineering;
    using UnitTools.DynamicViscosity.Scientific;

    public enum UnitToolsDynamicViscosityUnit
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

    public static class UnitToolsDynamicViscosity
    {
        public static double Convert(double value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            double baseValue = ToPascalSecond(value, from);
            return FromPascalSecond(baseValue, to);
        }

        public static double ToPascalSecond(double value, UnitToolsDynamicViscosityUnit from)
        {
            switch (from)
            {
                case UnitToolsDynamicViscosityUnit.PascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.MillipascalSecond:
                    return UnitToolsMetricDynamicViscosity.MillipascalSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.MicropascalSecond:
                    return UnitToolsMetricDynamicViscosity.MicropascalSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.Poise:
                    return UnitToolsMetricDynamicViscosity.PoiseToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.Centipoise:
                    return UnitToolsMetricDynamicViscosity.CentipoiseToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitToolsImperialDynamicViscosity.PoundPerFootSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitToolsImperialDynamicViscosity.PoundForceSecondPerSquareFootToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitToolsImperialDynamicViscosity.PoundForceSecondPerSquareInchToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.KilopascalSecond:
                    return UnitToolsMetricDynamicViscosity.KilopascalSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.MegapascalSecond:
                    return UnitToolsMetricDynamicViscosity.MegapascalSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitToolsEngineeringDynamicViscosity.NewtonSecondPerSquareMeterToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitToolsMetricDynamicViscosity.KilogramPerMeterSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitToolsMetricDynamicViscosity.GramPerCentimeterSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitToolsScientificDynamicViscosity.DyneSecondPerSquareCentimeterToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.Millipoise:
                    return UnitToolsMetricDynamicViscosity.MillipoiseToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.Micropoise:
                    return UnitToolsMetricDynamicViscosity.MicropoiseToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.Reyn:
                    return UnitToolsImperialDynamicViscosity.ReynToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundPerFootHour:
                    return UnitToolsImperialDynamicViscosity.PoundPerFootHourToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PascalHour:
                    return UnitToolsMetricDynamicViscosity.PascalHourToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PascalMinute:
                    return UnitToolsMetricDynamicViscosity.PascalMinuteToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitToolsMetricDynamicViscosity.KilogramPerMeterHourToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitToolsMetricDynamicViscosity.GramPerCentimeterMinuteToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitToolsImperialDynamicViscosity.SlugPerFootSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.SlugPerFootHour:
                    return UnitToolsImperialDynamicViscosity.SlugPerFootHourToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitToolsImperialDynamicViscosity.PoundPerInchSecondToPascalSecond(value);
                case UnitToolsDynamicViscosityUnit.PoundPerInchHour:
                    return UnitToolsImperialDynamicViscosity.PoundPerInchHourToPascalSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dynamic viscosity unit.");
            }
        }

        public static double FromPascalSecond(double baseValue, UnitToolsDynamicViscosityUnit to)
        {
            switch (to)
            {
                case UnitToolsDynamicViscosityUnit.PascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToPascalSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.MillipascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToMillipascalSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.MicropascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToMicropascalSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.Poise:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToPoise(baseValue);
                case UnitToolsDynamicViscosityUnit.Centipoise:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToCentipoise(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundPerFootSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundForceSecondPerSquareFoot(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundForceSecondPerSquareInch(baseValue);
                case UnitToolsDynamicViscosityUnit.KilopascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToKilopascalSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.MegapascalSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToMegapascalSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitToolsEngineeringDynamicViscosity.PascalSecondToNewtonSecondPerSquareMeter(baseValue);
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToKilogramPerMeterSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToGramPerCentimeterSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitToolsScientificDynamicViscosity.PascalSecondToDyneSecondPerSquareCentimeter(baseValue);
                case UnitToolsDynamicViscosityUnit.Millipoise:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToMillipoise(baseValue);
                case UnitToolsDynamicViscosityUnit.Micropoise:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToMicropoise(baseValue);
                case UnitToolsDynamicViscosityUnit.Reyn:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToReyn(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundPerFootHour:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundPerFootHour(baseValue);
                case UnitToolsDynamicViscosityUnit.PascalHour:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToPascalHour(baseValue);
                case UnitToolsDynamicViscosityUnit.PascalMinute:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToPascalMinute(baseValue);
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToKilogramPerMeterHour(baseValue);
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitToolsMetricDynamicViscosity.PascalSecondToGramPerCentimeterMinute(baseValue);
                case UnitToolsDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToSlugPerFootSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.SlugPerFootHour:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToSlugPerFootHour(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundPerInchSecond(baseValue);
                case UnitToolsDynamicViscosityUnit.PoundPerInchHour:
                    return UnitToolsImperialDynamicViscosity.PascalSecondToPoundPerInchHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dynamic viscosity unit.");
            }
        }

        public static string GetSymbol(UnitToolsDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicViscosityUnit.PascalSecond:
                    return "Pa·s";
                case UnitToolsDynamicViscosityUnit.MillipascalSecond:
                    return "mPa·s";
                case UnitToolsDynamicViscosityUnit.MicropascalSecond:
                    return "µPa·s";
                case UnitToolsDynamicViscosityUnit.Poise:
                    return "P";
                case UnitToolsDynamicViscosityUnit.Centipoise:
                    return "cP";
                case UnitToolsDynamicViscosityUnit.PoundPerFootSecond:
                    return "lb/(ft·s)";
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return "lbf·s/ft²";
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return "lbf·s/in²";
                case UnitToolsDynamicViscosityUnit.KilopascalSecond:
                    return "kPa·s";
                case UnitToolsDynamicViscosityUnit.MegapascalSecond:
                    return "MPa·s";
                case UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return "N·s/m²";
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond:
                    return "kg/(m·s)";
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond:
                    return "g/(cm·s)";
                case UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return "dyn·s/cm²";
                case UnitToolsDynamicViscosityUnit.Millipoise:
                    return "mP";
                case UnitToolsDynamicViscosityUnit.Micropoise:
                    return "µP";
                case UnitToolsDynamicViscosityUnit.Reyn:
                    return "reyn";
                case UnitToolsDynamicViscosityUnit.PoundPerFootHour:
                    return "lb/(ft·h)";
                case UnitToolsDynamicViscosityUnit.PascalHour:
                    return "Pa·h";
                case UnitToolsDynamicViscosityUnit.PascalMinute:
                    return "Pa·min";
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterHour:
                    return "kg/(m·h)";
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute:
                    return "g/(cm·min)";
                case UnitToolsDynamicViscosityUnit.SlugPerFootSecond:
                    return "slug/(ft·s)";
                case UnitToolsDynamicViscosityUnit.SlugPerFootHour:
                    return "slug/(ft·h)";
                case UnitToolsDynamicViscosityUnit.PoundPerInchSecond:
                    return "lb/(in·s)";
                case UnitToolsDynamicViscosityUnit.PoundPerInchHour:
                    return "lb/(in·h)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicViscosityUnit.PascalSecond:
                    return "pascal second";
                case UnitToolsDynamicViscosityUnit.MillipascalSecond:
                    return "millipascal second";
                case UnitToolsDynamicViscosityUnit.MicropascalSecond:
                    return "micropascal second";
                case UnitToolsDynamicViscosityUnit.Poise:
                    return "poise";
                case UnitToolsDynamicViscosityUnit.Centipoise:
                    return "centipoise";
                case UnitToolsDynamicViscosityUnit.PoundPerFootSecond:
                    return "pound per foot second";
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return "pound-force second per square foot";
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return "pound-force second per square inch";
                case UnitToolsDynamicViscosityUnit.KilopascalSecond:
                    return "Kilopascal Second";
                case UnitToolsDynamicViscosityUnit.MegapascalSecond:
                    return "Megapascal Second";
                case UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return "Newton Second Per Square Meter";
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond:
                    return "Kilogram Per Meter Second";
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond:
                    return "Gram Per Centimeter Second";
                case UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return "Dyne Second Per Square Centimeter";
                case UnitToolsDynamicViscosityUnit.Millipoise:
                    return "Millipoise";
                case UnitToolsDynamicViscosityUnit.Micropoise:
                    return "Micropoise";
                case UnitToolsDynamicViscosityUnit.Reyn:
                    return "Reyn";
                case UnitToolsDynamicViscosityUnit.PoundPerFootHour:
                    return "Pound Per Foot Hour";
                case UnitToolsDynamicViscosityUnit.PascalHour:
                    return "Pascal Hour";
                case UnitToolsDynamicViscosityUnit.PascalMinute:
                    return "Pascal Minute";
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterHour:
                    return "Kilogram Per Meter Hour";
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute:
                    return "Gram Per Centimeter Minute";
                case UnitToolsDynamicViscosityUnit.SlugPerFootSecond:
                    return "Slug Per Foot Second";
                case UnitToolsDynamicViscosityUnit.SlugPerFootHour:
                    return "Slug Per Foot Hour";
                case UnitToolsDynamicViscosityUnit.PoundPerInchSecond:
                    return "Pound Per Inch Second";
                case UnitToolsDynamicViscosityUnit.PoundPerInchHour:
                    return "Pound Per Inch Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDynamicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicViscosityUnit.PascalSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.MillipascalSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.MicropascalSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.Poise:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.Centipoise:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.PoundPerFootSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.KilopascalSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.MegapascalSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsDynamicViscosityUnit.Millipoise:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.Micropoise:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.Reyn:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PoundPerFootHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PascalHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.PascalMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.KilogramPerMeterHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicViscosityUnit.SlugPerFootSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.SlugPerFootHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PoundPerInchSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicViscosityUnit.PoundPerInchHour:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDynamicViscosityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsDynamicViscosityUnit.PascalSecond, UnitToolsDynamicViscosityUnit.MillipascalSecond, UnitToolsDynamicViscosityUnit.MicropascalSecond, UnitToolsDynamicViscosityUnit.Poise, UnitToolsDynamicViscosityUnit.Centipoise, UnitToolsDynamicViscosityUnit.KilopascalSecond, UnitToolsDynamicViscosityUnit.MegapascalSecond, UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond, UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond, UnitToolsDynamicViscosityUnit.Millipoise, UnitToolsDynamicViscosityUnit.Micropoise, UnitToolsDynamicViscosityUnit.PascalHour, UnitToolsDynamicViscosityUnit.PascalMinute, UnitToolsDynamicViscosityUnit.KilogramPerMeterHour, UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsDynamicViscosityUnit.PoundPerFootSecond, UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot, UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch, UnitToolsDynamicViscosityUnit.Reyn, UnitToolsDynamicViscosityUnit.PoundPerFootHour, UnitToolsDynamicViscosityUnit.SlugPerFootSecond, UnitToolsDynamicViscosityUnit.SlugPerFootHour, UnitToolsDynamicViscosityUnit.PoundPerInchSecond, UnitToolsDynamicViscosityUnit.PoundPerInchHour };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter };
                default:
                    return new[] { UnitToolsDynamicViscosityUnit.PascalSecond, UnitToolsDynamicViscosityUnit.MillipascalSecond, UnitToolsDynamicViscosityUnit.MicropascalSecond, UnitToolsDynamicViscosityUnit.Poise, UnitToolsDynamicViscosityUnit.Centipoise, UnitToolsDynamicViscosityUnit.PoundPerFootSecond, UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareFoot, UnitToolsDynamicViscosityUnit.PoundForceSecondPerSquareInch, UnitToolsDynamicViscosityUnit.KilopascalSecond, UnitToolsDynamicViscosityUnit.MegapascalSecond, UnitToolsDynamicViscosityUnit.NewtonSecondPerSquareMeter, UnitToolsDynamicViscosityUnit.KilogramPerMeterSecond, UnitToolsDynamicViscosityUnit.GramPerCentimeterSecond, UnitToolsDynamicViscosityUnit.DyneSecondPerSquareCentimeter, UnitToolsDynamicViscosityUnit.Millipoise, UnitToolsDynamicViscosityUnit.Micropoise, UnitToolsDynamicViscosityUnit.Reyn, UnitToolsDynamicViscosityUnit.PoundPerFootHour, UnitToolsDynamicViscosityUnit.PascalHour, UnitToolsDynamicViscosityUnit.PascalMinute, UnitToolsDynamicViscosityUnit.KilogramPerMeterHour, UnitToolsDynamicViscosityUnit.GramPerCentimeterMinute, UnitToolsDynamicViscosityUnit.SlugPerFootSecond, UnitToolsDynamicViscosityUnit.SlugPerFootHour, UnitToolsDynamicViscosityUnit.PoundPerInchSecond, UnitToolsDynamicViscosityUnit.PoundPerInchHour };
            }
        }
    }
}
