namespace RealisticPhysics.UnitConversion.SpecificVolume
{
    using RealisticPhysics.UnitConversion.SpecificVolume.Metric;
    using RealisticPhysics.UnitConversion.SpecificVolume.Imperial;

    public enum UnitConverterSpecificVolumeUnit
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

    public static class UnitConverterSpecificVolume
    {
        public static double Convert(double value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            double baseValue = ToCubicMeterPerKilogram(value, from);
            return FromCubicMeterPerKilogram(baseValue, to);
        }

        public static double ToCubicMeterPerKilogram(double value, UnitConverterSpecificVolumeUnit from)
        {
            switch (from)
            {
                case UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.LiterPerKilogram:
                    return UnitConverterMetricSpecificVolume.LiterPerKilogramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.MilliliterPerGram:
                    return UnitConverterMetricSpecificVolume.MilliliterPerGramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicCentimeterPerGramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicFootPerPound:
                    return UnitConverterImperialSpecificVolume.CubicFootPerPoundToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicInchPerPound:
                    return UnitConverterImperialSpecificVolume.CubicInchPerPoundToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerGramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerTonneToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.LiterPerGram:
                    return UnitConverterMetricSpecificVolume.LiterPerGramToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicYardPerPound:
                    return UnitConverterImperialSpecificVolume.CubicYardPerPoundToCubicMeterPerKilogram(value);
                case UnitConverterSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitConverterImperialSpecificVolume.CubicFootPerSlugToCubicMeterPerKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific volume unit.");
            }
        }

        public static double FromCubicMeterPerKilogram(double baseValue, UnitConverterSpecificVolumeUnit to)
        {
            switch (to)
            {
                case UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerKilogram(baseValue);
                case UnitConverterSpecificVolumeUnit.LiterPerKilogram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToLiterPerKilogram(baseValue);
                case UnitConverterSpecificVolumeUnit.MilliliterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToMilliliterPerGram(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToCubicCentimeterPerGram(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicFootPerPound:
                    return UnitConverterImperialSpecificVolume.CubicMeterPerKilogramToCubicFootPerPound(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicInchPerPound:
                    return UnitConverterImperialSpecificVolume.CubicMeterPerKilogramToCubicInchPerPound(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerGram(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToCubicMeterPerTonne(baseValue);
                case UnitConverterSpecificVolumeUnit.LiterPerGram:
                    return UnitConverterMetricSpecificVolume.CubicMeterPerKilogramToLiterPerGram(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicYardPerPound:
                    return UnitConverterImperialSpecificVolume.CubicMeterPerKilogramToCubicYardPerPound(baseValue);
                case UnitConverterSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitConverterImperialSpecificVolume.CubicMeterPerKilogramToCubicFootPerSlug(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific volume unit.");
            }
        }

        public static string GetSymbol(UnitConverterSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram:
                    return "m³/kg";
                case UnitConverterSpecificVolumeUnit.LiterPerKilogram:
                    return "L/kg";
                case UnitConverterSpecificVolumeUnit.MilliliterPerGram:
                    return "mL/g";
                case UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram:
                    return "cm³/g";
                case UnitConverterSpecificVolumeUnit.CubicFootPerPound:
                    return "ft³/lb";
                case UnitConverterSpecificVolumeUnit.CubicInchPerPound:
                    return "in³/lb";
                case UnitConverterSpecificVolumeUnit.CubicMeterPerGram:
                    return "m³/g";
                case UnitConverterSpecificVolumeUnit.CubicMeterPerTonne:
                    return "m³/t";
                case UnitConverterSpecificVolumeUnit.LiterPerGram:
                    return "L/g";
                case UnitConverterSpecificVolumeUnit.CubicYardPerPound:
                    return "yd³/lb";
                case UnitConverterSpecificVolumeUnit.CubicFootPerSlug:
                    return "ft³/slug";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram:
                    return "Cubic Meter Per Kilogram";
                case UnitConverterSpecificVolumeUnit.LiterPerKilogram:
                    return "Liter Per Kilogram";
                case UnitConverterSpecificVolumeUnit.MilliliterPerGram:
                    return "Milliliter Per Gram";
                case UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram:
                    return "Cubic Centimeter Per Gram";
                case UnitConverterSpecificVolumeUnit.CubicFootPerPound:
                    return "Cubic Foot Per Pound";
                case UnitConverterSpecificVolumeUnit.CubicInchPerPound:
                    return "Cubic Inch Per Pound";
                case UnitConverterSpecificVolumeUnit.CubicMeterPerGram:
                    return "Cubic Meter Per Gram";
                case UnitConverterSpecificVolumeUnit.CubicMeterPerTonne:
                    return "Cubic Meter Per Tonne";
                case UnitConverterSpecificVolumeUnit.LiterPerGram:
                    return "Liter Per Gram";
                case UnitConverterSpecificVolumeUnit.CubicYardPerPound:
                    return "Cubic Yard Per Pound";
                case UnitConverterSpecificVolumeUnit.CubicFootPerSlug:
                    return "Cubic Foot Per Slug";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSpecificVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.LiterPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.MilliliterPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.CubicFootPerPound:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificVolumeUnit.CubicInchPerPound:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificVolumeUnit.CubicMeterPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.CubicMeterPerTonne:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.LiterPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificVolumeUnit.CubicYardPerPound:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificVolumeUnit.CubicFootPerSlug:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSpecificVolumeUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram, UnitConverterSpecificVolumeUnit.LiterPerKilogram, UnitConverterSpecificVolumeUnit.MilliliterPerGram, UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram, UnitConverterSpecificVolumeUnit.CubicMeterPerGram, UnitConverterSpecificVolumeUnit.CubicMeterPerTonne, UnitConverterSpecificVolumeUnit.LiterPerGram };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSpecificVolumeUnit.CubicFootPerPound, UnitConverterSpecificVolumeUnit.CubicInchPerPound, UnitConverterSpecificVolumeUnit.CubicYardPerPound, UnitConverterSpecificVolumeUnit.CubicFootPerSlug };
                default:
                    return new[] { UnitConverterSpecificVolumeUnit.CubicMeterPerKilogram, UnitConverterSpecificVolumeUnit.LiterPerKilogram, UnitConverterSpecificVolumeUnit.MilliliterPerGram, UnitConverterSpecificVolumeUnit.CubicCentimeterPerGram, UnitConverterSpecificVolumeUnit.CubicFootPerPound, UnitConverterSpecificVolumeUnit.CubicInchPerPound, UnitConverterSpecificVolumeUnit.CubicMeterPerGram, UnitConverterSpecificVolumeUnit.CubicMeterPerTonne, UnitConverterSpecificVolumeUnit.LiterPerGram, UnitConverterSpecificVolumeUnit.CubicYardPerPound, UnitConverterSpecificVolumeUnit.CubicFootPerSlug };
            }
        }
    }
}
