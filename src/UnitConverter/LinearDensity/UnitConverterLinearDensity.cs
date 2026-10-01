namespace UnitConverter.LinearDensity
{
    using UnitConverter.LinearDensity.Metric;
    using UnitConverter.LinearDensity.Imperial;
    using UnitConverter.LinearDensity.Engineering;

    public enum UnitConverterLinearDensityUnit
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

    public static class UnitConverterLinearDensity
    {
        public static double Convert(double value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            double baseValue = ToKilogramPerMeter(value, from);
            return FromKilogramPerMeter(baseValue, to);
        }

        public static double ToKilogramPerMeter(double value, UnitConverterLinearDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterLinearDensityUnit.KilogramPerMeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.GramPerMeter:
                    return UnitConverterMetricLinearDensity.GramPerMeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.MilligramPerMeter:
                    return UnitConverterMetricLinearDensity.MilligramPerMeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.KilogramPerKilometer:
                    return UnitConverterMetricLinearDensity.KilogramPerKilometerToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.PoundPerFoot:
                    return UnitConverterImperialLinearDensity.PoundPerFootToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.PoundPerInch:
                    return UnitConverterImperialLinearDensity.PoundPerInchToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.Tex:
                    return UnitConverterEngineeringLinearDensity.TexToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.Denier:
                    return UnitConverterEngineeringLinearDensity.DenierToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.KilogramPerCentimeter:
                    return UnitConverterMetricLinearDensity.KilogramPerCentimeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.KilogramPerMillimeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMillimeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.GramPerMillimeter:
                    return UnitConverterMetricLinearDensity.GramPerMillimeterToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.OuncePerFoot:
                    return UnitConverterImperialLinearDensity.OuncePerFootToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.OuncePerInch:
                    return UnitConverterImperialLinearDensity.OuncePerInchToKilogramPerMeter(value);
                case UnitConverterLinearDensityUnit.PoundPerYard:
                    return UnitConverterImperialLinearDensity.PoundPerYardToKilogramPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported linear density unit.");
            }
        }

        public static double FromKilogramPerMeter(double baseValue, UnitConverterLinearDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterLinearDensityUnit.KilogramPerMeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToKilogramPerMeter(baseValue);
                case UnitConverterLinearDensityUnit.GramPerMeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToGramPerMeter(baseValue);
                case UnitConverterLinearDensityUnit.MilligramPerMeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToMilligramPerMeter(baseValue);
                case UnitConverterLinearDensityUnit.KilogramPerKilometer:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToKilogramPerKilometer(baseValue);
                case UnitConverterLinearDensityUnit.PoundPerFoot:
                    return UnitConverterImperialLinearDensity.KilogramPerMeterToPoundPerFoot(baseValue);
                case UnitConverterLinearDensityUnit.PoundPerInch:
                    return UnitConverterImperialLinearDensity.KilogramPerMeterToPoundPerInch(baseValue);
                case UnitConverterLinearDensityUnit.Tex:
                    return UnitConverterEngineeringLinearDensity.KilogramPerMeterToTex(baseValue);
                case UnitConverterLinearDensityUnit.Denier:
                    return UnitConverterEngineeringLinearDensity.KilogramPerMeterToDenier(baseValue);
                case UnitConverterLinearDensityUnit.KilogramPerCentimeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToKilogramPerCentimeter(baseValue);
                case UnitConverterLinearDensityUnit.KilogramPerMillimeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToKilogramPerMillimeter(baseValue);
                case UnitConverterLinearDensityUnit.GramPerMillimeter:
                    return UnitConverterMetricLinearDensity.KilogramPerMeterToGramPerMillimeter(baseValue);
                case UnitConverterLinearDensityUnit.OuncePerFoot:
                    return UnitConverterImperialLinearDensity.KilogramPerMeterToOuncePerFoot(baseValue);
                case UnitConverterLinearDensityUnit.OuncePerInch:
                    return UnitConverterImperialLinearDensity.KilogramPerMeterToOuncePerInch(baseValue);
                case UnitConverterLinearDensityUnit.PoundPerYard:
                    return UnitConverterImperialLinearDensity.KilogramPerMeterToPoundPerYard(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported linear density unit.");
            }
        }

        public static string GetSymbol(UnitConverterLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLinearDensityUnit.KilogramPerMeter:
                    return "kg/m";
                case UnitConverterLinearDensityUnit.GramPerMeter:
                    return "g/m";
                case UnitConverterLinearDensityUnit.MilligramPerMeter:
                    return "mg/m";
                case UnitConverterLinearDensityUnit.KilogramPerKilometer:
                    return "kg/km";
                case UnitConverterLinearDensityUnit.PoundPerFoot:
                    return "lb/ft";
                case UnitConverterLinearDensityUnit.PoundPerInch:
                    return "lb/in";
                case UnitConverterLinearDensityUnit.Tex:
                    return "tex";
                case UnitConverterLinearDensityUnit.Denier:
                    return "den";
                case UnitConverterLinearDensityUnit.KilogramPerCentimeter:
                    return "kg/cm";
                case UnitConverterLinearDensityUnit.KilogramPerMillimeter:
                    return "kg/mm";
                case UnitConverterLinearDensityUnit.GramPerMillimeter:
                    return "g/mm";
                case UnitConverterLinearDensityUnit.OuncePerFoot:
                    return "oz/ft";
                case UnitConverterLinearDensityUnit.OuncePerInch:
                    return "oz/in";
                case UnitConverterLinearDensityUnit.PoundPerYard:
                    return "lb/yd";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLinearDensityUnit.KilogramPerMeter:
                    return "Kilogram Per Meter";
                case UnitConverterLinearDensityUnit.GramPerMeter:
                    return "Gram Per Meter";
                case UnitConverterLinearDensityUnit.MilligramPerMeter:
                    return "Milligram Per Meter";
                case UnitConverterLinearDensityUnit.KilogramPerKilometer:
                    return "Kilogram Per Kilometer";
                case UnitConverterLinearDensityUnit.PoundPerFoot:
                    return "Pound Per Foot";
                case UnitConverterLinearDensityUnit.PoundPerInch:
                    return "Pound Per Inch";
                case UnitConverterLinearDensityUnit.Tex:
                    return "Tex";
                case UnitConverterLinearDensityUnit.Denier:
                    return "Denier";
                case UnitConverterLinearDensityUnit.KilogramPerCentimeter:
                    return "Kilogram Per Centimeter";
                case UnitConverterLinearDensityUnit.KilogramPerMillimeter:
                    return "Kilogram Per Millimeter";
                case UnitConverterLinearDensityUnit.GramPerMillimeter:
                    return "Gram Per Millimeter";
                case UnitConverterLinearDensityUnit.OuncePerFoot:
                    return "Ounce Per Foot";
                case UnitConverterLinearDensityUnit.OuncePerInch:
                    return "Ounce Per Inch";
                case UnitConverterLinearDensityUnit.PoundPerYard:
                    return "Pound Per Yard";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLinearDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLinearDensityUnit.KilogramPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.GramPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.MilligramPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.KilogramPerKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.PoundPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLinearDensityUnit.PoundPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLinearDensityUnit.Tex:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterLinearDensityUnit.Denier:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterLinearDensityUnit.KilogramPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.KilogramPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.GramPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLinearDensityUnit.OuncePerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLinearDensityUnit.OuncePerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLinearDensityUnit.PoundPerYard:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLinearDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLinearDensityUnit.KilogramPerMeter, UnitConverterLinearDensityUnit.GramPerMeter, UnitConverterLinearDensityUnit.MilligramPerMeter, UnitConverterLinearDensityUnit.KilogramPerKilometer, UnitConverterLinearDensityUnit.KilogramPerCentimeter, UnitConverterLinearDensityUnit.KilogramPerMillimeter, UnitConverterLinearDensityUnit.GramPerMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterLinearDensityUnit.PoundPerFoot, UnitConverterLinearDensityUnit.PoundPerInch, UnitConverterLinearDensityUnit.OuncePerFoot, UnitConverterLinearDensityUnit.OuncePerInch, UnitConverterLinearDensityUnit.PoundPerYard };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterLinearDensityUnit.Tex, UnitConverterLinearDensityUnit.Denier };
                default:
                    return new[] { UnitConverterLinearDensityUnit.KilogramPerMeter, UnitConverterLinearDensityUnit.GramPerMeter, UnitConverterLinearDensityUnit.MilligramPerMeter, UnitConverterLinearDensityUnit.KilogramPerKilometer, UnitConverterLinearDensityUnit.PoundPerFoot, UnitConverterLinearDensityUnit.PoundPerInch, UnitConverterLinearDensityUnit.Tex, UnitConverterLinearDensityUnit.Denier, UnitConverterLinearDensityUnit.KilogramPerCentimeter, UnitConverterLinearDensityUnit.KilogramPerMillimeter, UnitConverterLinearDensityUnit.GramPerMillimeter, UnitConverterLinearDensityUnit.OuncePerFoot, UnitConverterLinearDensityUnit.OuncePerInch, UnitConverterLinearDensityUnit.PoundPerYard };
            }
        }
    }
}
