namespace UnitTools.SpecificVolume
{
    using UnitTools.SpecificVolume.Metric;
    using UnitTools.SpecificVolume.Imperial;

    public enum UnitToolsSpecificVolumeUnit
    {
        CubicMeterPerKilogram = 0,
        LiterPerKilogram = 1,
        MilliliterPerGram = 2,
        CubicCentimeterPerGram = 3,
        CubicFootPerPound = 4,
        CubicInchPerPound = 5,
        CubicMeterPerGram = 6,
        CubicMeterPerTonne = 7,
        LiterPerGram = 8,
        CubicYardPerPound = 9,
        CubicFootPerSlug = 10,
    }

    public static class UnitToolsSpecificVolume
    {
        public static double Convert(double value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            double baseValue = ToCubicMeterPerKilogram(value, from);
            return FromCubicMeterPerKilogram(baseValue, to);
        }

        public static double ToCubicMeterPerKilogram(double value, UnitToolsSpecificVolumeUnit from)
        {
            switch (from)
            {
                case UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.LiterPerKilogram:
                    return UnitToolsMetricSpecificVolume.LiterPerKilogramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.MilliliterPerGram:
                    return UnitToolsMetricSpecificVolume.MilliliterPerGramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicCentimeterPerGramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicFootPerPound:
                    return UnitToolsImperialSpecificVolume.CubicFootPerPoundToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicInchPerPound:
                    return UnitToolsImperialSpecificVolume.CubicInchPerPoundToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerGramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerTonneToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.LiterPerGram:
                    return UnitToolsMetricSpecificVolume.LiterPerGramToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicYardPerPound:
                    return UnitToolsImperialSpecificVolume.CubicYardPerPoundToCubicMeterPerKilogram(value);
                case UnitToolsSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitToolsImperialSpecificVolume.CubicFootPerSlugToCubicMeterPerKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific volume unit.");
            }
        }

        public static double FromCubicMeterPerKilogram(double baseValue, UnitToolsSpecificVolumeUnit to)
        {
            switch (to)
            {
                case UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerKilogram(baseValue);
                case UnitToolsSpecificVolumeUnit.LiterPerKilogram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToLiterPerKilogram(baseValue);
                case UnitToolsSpecificVolumeUnit.MilliliterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToMilliliterPerGram(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToCubicCentimeterPerGram(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicFootPerPound:
                    return UnitToolsImperialSpecificVolume.CubicMeterPerKilogramToCubicFootPerPound(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicInchPerPound:
                    return UnitToolsImperialSpecificVolume.CubicMeterPerKilogramToCubicInchPerPound(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerGram(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerTonne(baseValue);
                case UnitToolsSpecificVolumeUnit.LiterPerGram:
                    return UnitToolsMetricSpecificVolume.CubicMeterPerKilogramToLiterPerGram(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicYardPerPound:
                    return UnitToolsImperialSpecificVolume.CubicMeterPerKilogramToCubicYardPerPound(baseValue);
                case UnitToolsSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitToolsImperialSpecificVolume.CubicMeterPerKilogramToCubicFootPerSlug(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific volume unit.");
            }
        }

        public static string GetSymbol(UnitToolsSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram:
                    return "m³/kg";
                case UnitToolsSpecificVolumeUnit.LiterPerKilogram:
                    return "L/kg";
                case UnitToolsSpecificVolumeUnit.MilliliterPerGram:
                    return "mL/g";
                case UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram:
                    return "cm³/g";
                case UnitToolsSpecificVolumeUnit.CubicFootPerPound:
                    return "ft³/lb";
                case UnitToolsSpecificVolumeUnit.CubicInchPerPound:
                    return "in³/lb";
                case UnitToolsSpecificVolumeUnit.CubicMeterPerGram:
                    return "m³/g";
                case UnitToolsSpecificVolumeUnit.CubicMeterPerTonne:
                    return "m³/t";
                case UnitToolsSpecificVolumeUnit.LiterPerGram:
                    return "L/g";
                case UnitToolsSpecificVolumeUnit.CubicYardPerPound:
                    return "yd³/lb";
                case UnitToolsSpecificVolumeUnit.CubicFootPerSlug:
                    return "ft³/slug";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram:
                    return "Cubic Meter Per Kilogram";
                case UnitToolsSpecificVolumeUnit.LiterPerKilogram:
                    return "Liter Per Kilogram";
                case UnitToolsSpecificVolumeUnit.MilliliterPerGram:
                    return "Milliliter Per Gram";
                case UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram:
                    return "Cubic Centimeter Per Gram";
                case UnitToolsSpecificVolumeUnit.CubicFootPerPound:
                    return "Cubic Foot Per Pound";
                case UnitToolsSpecificVolumeUnit.CubicInchPerPound:
                    return "Cubic Inch Per Pound";
                case UnitToolsSpecificVolumeUnit.CubicMeterPerGram:
                    return "Cubic Meter Per Gram";
                case UnitToolsSpecificVolumeUnit.CubicMeterPerTonne:
                    return "Cubic Meter Per Tonne";
                case UnitToolsSpecificVolumeUnit.LiterPerGram:
                    return "Liter Per Gram";
                case UnitToolsSpecificVolumeUnit.CubicYardPerPound:
                    return "Cubic Yard Per Pound";
                case UnitToolsSpecificVolumeUnit.CubicFootPerSlug:
                    return "Cubic Foot Per Slug";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.LiterPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.MilliliterPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.CubicFootPerPound:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificVolumeUnit.CubicInchPerPound:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.LiterPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificVolumeUnit.CubicYardPerPound:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSpecificVolumeUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram, UnitToolsSpecificVolumeUnit.LiterPerKilogram, UnitToolsSpecificVolumeUnit.MilliliterPerGram, UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram, UnitToolsSpecificVolumeUnit.CubicMeterPerGram, UnitToolsSpecificVolumeUnit.CubicMeterPerTonne, UnitToolsSpecificVolumeUnit.LiterPerGram };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSpecificVolumeUnit.CubicFootPerPound, UnitToolsSpecificVolumeUnit.CubicInchPerPound, UnitToolsSpecificVolumeUnit.CubicYardPerPound, UnitToolsSpecificVolumeUnit.CubicFootPerSlug };
                default:
                    return new[] { UnitToolsSpecificVolumeUnit.CubicMeterPerKilogram, UnitToolsSpecificVolumeUnit.LiterPerKilogram, UnitToolsSpecificVolumeUnit.MilliliterPerGram, UnitToolsSpecificVolumeUnit.CubicCentimeterPerGram, UnitToolsSpecificVolumeUnit.CubicFootPerPound, UnitToolsSpecificVolumeUnit.CubicInchPerPound, UnitToolsSpecificVolumeUnit.CubicMeterPerGram, UnitToolsSpecificVolumeUnit.CubicMeterPerTonne, UnitToolsSpecificVolumeUnit.LiterPerGram, UnitToolsSpecificVolumeUnit.CubicYardPerPound, UnitToolsSpecificVolumeUnit.CubicFootPerSlug };
            }
        }
    }
}
