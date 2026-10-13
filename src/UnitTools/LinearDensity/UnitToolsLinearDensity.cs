namespace UnitTools.LinearDensity
{
    using UnitTools.LinearDensity.Metric;
    using UnitTools.LinearDensity.Imperial;
    using UnitTools.LinearDensity.Engineering;

    public enum UnitToolsLinearDensityUnit
    {
        KilogramPerMeter = 0,
        GramPerMeter = 1,
        MilligramPerMeter = 2,
        KilogramPerKilometer = 3,
        PoundPerFoot = 4,
        PoundPerInch = 5,
        Tex = 6,
        Denier = 7,
        KilogramPerCentimeter = 8,
        KilogramPerMillimeter = 9,
        GramPerMillimeter = 10,
        OuncePerFoot = 11,
        OuncePerInch = 12,
        PoundPerYard = 13,
    }

    public static class UnitToolsLinearDensity
    {
        public static double Convert(double value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            double baseValue = ToKilogramPerMeter(value, from);
            return FromKilogramPerMeter(baseValue, to);
        }

        public static double ToKilogramPerMeter(double value, UnitToolsLinearDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsLinearDensityUnit.KilogramPerMeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.GramPerMeter:
                    return UnitToolsMetricLinearDensity.GramPerMeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.MilligramPerMeter:
                    return UnitToolsMetricLinearDensity.MilligramPerMeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.KilogramPerKilometer:
                    return UnitToolsMetricLinearDensity.KilogramPerKilometerToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.PoundPerFoot:
                    return UnitToolsImperialLinearDensity.PoundPerFootToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.PoundPerInch:
                    return UnitToolsImperialLinearDensity.PoundPerInchToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.Tex:
                    return UnitToolsEngineeringLinearDensity.TexToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.Denier:
                    return UnitToolsEngineeringLinearDensity.DenierToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.KilogramPerCentimeter:
                    return UnitToolsMetricLinearDensity.KilogramPerCentimeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.KilogramPerMillimeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMillimeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.GramPerMillimeter:
                    return UnitToolsMetricLinearDensity.GramPerMillimeterToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.OuncePerFoot:
                    return UnitToolsImperialLinearDensity.OuncePerFootToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.OuncePerInch:
                    return UnitToolsImperialLinearDensity.OuncePerInchToKilogramPerMeter(value);
                case UnitToolsLinearDensityUnit.PoundPerYard:
                    return UnitToolsImperialLinearDensity.PoundPerYardToKilogramPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported linear density unit.");
            }
        }

        public static double FromKilogramPerMeter(double baseValue, UnitToolsLinearDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsLinearDensityUnit.KilogramPerMeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToKilogramPerMeter(baseValue);
                case UnitToolsLinearDensityUnit.GramPerMeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToGramPerMeter(baseValue);
                case UnitToolsLinearDensityUnit.MilligramPerMeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToMilligramPerMeter(baseValue);
                case UnitToolsLinearDensityUnit.KilogramPerKilometer:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToKilogramPerKilometer(baseValue);
                case UnitToolsLinearDensityUnit.PoundPerFoot:
                    return UnitToolsImperialLinearDensity.KilogramPerMeterToPoundPerFoot(baseValue);
                case UnitToolsLinearDensityUnit.PoundPerInch:
                    return UnitToolsImperialLinearDensity.KilogramPerMeterToPoundPerInch(baseValue);
                case UnitToolsLinearDensityUnit.Tex:
                    return UnitToolsEngineeringLinearDensity.KilogramPerMeterToTex(baseValue);
                case UnitToolsLinearDensityUnit.Denier:
                    return UnitToolsEngineeringLinearDensity.KilogramPerMeterToDenier(baseValue);
                case UnitToolsLinearDensityUnit.KilogramPerCentimeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToKilogramPerCentimeter(baseValue);
                case UnitToolsLinearDensityUnit.KilogramPerMillimeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToKilogramPerMillimeter(baseValue);
                case UnitToolsLinearDensityUnit.GramPerMillimeter:
                    return UnitToolsMetricLinearDensity.KilogramPerMeterToGramPerMillimeter(baseValue);
                case UnitToolsLinearDensityUnit.OuncePerFoot:
                    return UnitToolsImperialLinearDensity.KilogramPerMeterToOuncePerFoot(baseValue);
                case UnitToolsLinearDensityUnit.OuncePerInch:
                    return UnitToolsImperialLinearDensity.KilogramPerMeterToOuncePerInch(baseValue);
                case UnitToolsLinearDensityUnit.PoundPerYard:
                    return UnitToolsImperialLinearDensity.KilogramPerMeterToPoundPerYard(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported linear density unit.");
            }
        }

        public static string GetSymbol(UnitToolsLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLinearDensityUnit.KilogramPerMeter:
                    return "kg/m";
                case UnitToolsLinearDensityUnit.GramPerMeter:
                    return "g/m";
                case UnitToolsLinearDensityUnit.MilligramPerMeter:
                    return "mg/m";
                case UnitToolsLinearDensityUnit.KilogramPerKilometer:
                    return "kg/km";
                case UnitToolsLinearDensityUnit.PoundPerFoot:
                    return "lb/ft";
                case UnitToolsLinearDensityUnit.PoundPerInch:
                    return "lb/in";
                case UnitToolsLinearDensityUnit.Tex:
                    return "tex";
                case UnitToolsLinearDensityUnit.Denier:
                    return "den";
                case UnitToolsLinearDensityUnit.KilogramPerCentimeter:
                    return "kg/cm";
                case UnitToolsLinearDensityUnit.KilogramPerMillimeter:
                    return "kg/mm";
                case UnitToolsLinearDensityUnit.GramPerMillimeter:
                    return "g/mm";
                case UnitToolsLinearDensityUnit.OuncePerFoot:
                    return "oz/ft";
                case UnitToolsLinearDensityUnit.OuncePerInch:
                    return "oz/in";
                case UnitToolsLinearDensityUnit.PoundPerYard:
                    return "lb/yd";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLinearDensityUnit.KilogramPerMeter:
                    return "Kilogram Per Meter";
                case UnitToolsLinearDensityUnit.GramPerMeter:
                    return "Gram Per Meter";
                case UnitToolsLinearDensityUnit.MilligramPerMeter:
                    return "Milligram Per Meter";
                case UnitToolsLinearDensityUnit.KilogramPerKilometer:
                    return "Kilogram Per Kilometer";
                case UnitToolsLinearDensityUnit.PoundPerFoot:
                    return "Pound Per Foot";
                case UnitToolsLinearDensityUnit.PoundPerInch:
                    return "Pound Per Inch";
                case UnitToolsLinearDensityUnit.Tex:
                    return "Tex";
                case UnitToolsLinearDensityUnit.Denier:
                    return "Denier";
                case UnitToolsLinearDensityUnit.KilogramPerCentimeter:
                    return "Kilogram Per Centimeter";
                case UnitToolsLinearDensityUnit.KilogramPerMillimeter:
                    return "Kilogram Per Millimeter";
                case UnitToolsLinearDensityUnit.GramPerMillimeter:
                    return "Gram Per Millimeter";
                case UnitToolsLinearDensityUnit.OuncePerFoot:
                    return "Ounce Per Foot";
                case UnitToolsLinearDensityUnit.OuncePerInch:
                    return "Ounce Per Inch";
                case UnitToolsLinearDensityUnit.PoundPerYard:
                    return "Pound Per Yard";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLinearDensityUnit.KilogramPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.GramPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.MilligramPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.KilogramPerKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.PoundPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLinearDensityUnit.PoundPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLinearDensityUnit.Tex:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsLinearDensityUnit.Denier:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsLinearDensityUnit.KilogramPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.KilogramPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.GramPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLinearDensityUnit.OuncePerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLinearDensityUnit.OuncePerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLinearDensityUnit.PoundPerYard:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLinearDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLinearDensityUnit.KilogramPerMeter, UnitToolsLinearDensityUnit.GramPerMeter, UnitToolsLinearDensityUnit.MilligramPerMeter, UnitToolsLinearDensityUnit.KilogramPerKilometer, UnitToolsLinearDensityUnit.KilogramPerCentimeter, UnitToolsLinearDensityUnit.KilogramPerMillimeter, UnitToolsLinearDensityUnit.GramPerMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsLinearDensityUnit.PoundPerFoot, UnitToolsLinearDensityUnit.PoundPerInch, UnitToolsLinearDensityUnit.OuncePerFoot, UnitToolsLinearDensityUnit.OuncePerInch, UnitToolsLinearDensityUnit.PoundPerYard };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsLinearDensityUnit.Tex, UnitToolsLinearDensityUnit.Denier };
                default:
                    return new[] { UnitToolsLinearDensityUnit.KilogramPerMeter, UnitToolsLinearDensityUnit.GramPerMeter, UnitToolsLinearDensityUnit.MilligramPerMeter, UnitToolsLinearDensityUnit.KilogramPerKilometer, UnitToolsLinearDensityUnit.PoundPerFoot, UnitToolsLinearDensityUnit.PoundPerInch, UnitToolsLinearDensityUnit.Tex, UnitToolsLinearDensityUnit.Denier, UnitToolsLinearDensityUnit.KilogramPerCentimeter, UnitToolsLinearDensityUnit.KilogramPerMillimeter, UnitToolsLinearDensityUnit.GramPerMillimeter, UnitToolsLinearDensityUnit.OuncePerFoot, UnitToolsLinearDensityUnit.OuncePerInch, UnitToolsLinearDensityUnit.PoundPerYard };
            }
        }
    }
}
