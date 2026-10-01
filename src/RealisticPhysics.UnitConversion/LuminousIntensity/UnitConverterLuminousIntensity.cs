namespace RealisticPhysics.UnitConversion.LuminousIntensity
{
    using RealisticPhysics.UnitConversion.LuminousIntensity.Metric;
    using RealisticPhysics.UnitConversion.LuminousIntensity.Historical;

    public enum UnitConverterLuminousIntensityUnit
    {
        Candela = 0,
        Millicandela = 1,
        Kilocandela = 2,
        Candlepower = 3,
        Hefnerkerze = 4,
        Microcandela = 5,
        Nanocandela = 6,
        Megacandela = 7,
        SphericalCandlepower = 8,
        Violle = 9,
    }

    public static class UnitConverterLuminousIntensity
    {
        public static double Convert(double value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            double baseValue = ToCandela(value, from);
            return FromCandela(baseValue, to);
        }

        public static double ToCandela(double value, UnitConverterLuminousIntensityUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminousIntensityUnit.Candela:
                    return UnitConverterMetricLuminousIntensity.CandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.Millicandela:
                    return UnitConverterMetricLuminousIntensity.MillicandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.Kilocandela:
                    return UnitConverterMetricLuminousIntensity.KilocandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.Candlepower:
                    return UnitConverterHistoricalLuminousIntensity.CandlepowerToCandela(value);
                case UnitConverterLuminousIntensityUnit.Hefnerkerze:
                    return UnitConverterHistoricalLuminousIntensity.HefnerkerzeToCandela(value);
                case UnitConverterLuminousIntensityUnit.Microcandela:
                    return UnitConverterMetricLuminousIntensity.MicrocandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.Nanocandela:
                    return UnitConverterMetricLuminousIntensity.NanocandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.Megacandela:
                    return UnitConverterMetricLuminousIntensity.MegacandelaToCandela(value);
                case UnitConverterLuminousIntensityUnit.SphericalCandlepower:
                    return UnitConverterHistoricalLuminousIntensity.SphericalCandlepowerToCandela(value);
                case UnitConverterLuminousIntensityUnit.Violle:
                    return UnitConverterHistoricalLuminousIntensity.ViolleToCandela(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous intensity unit.");
            }
        }

        public static double FromCandela(double baseValue, UnitConverterLuminousIntensityUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminousIntensityUnit.Candela:
                    return UnitConverterMetricLuminousIntensity.CandelaToCandela(baseValue);
                case UnitConverterLuminousIntensityUnit.Millicandela:
                    return UnitConverterMetricLuminousIntensity.CandelaToMillicandela(baseValue);
                case UnitConverterLuminousIntensityUnit.Kilocandela:
                    return UnitConverterMetricLuminousIntensity.CandelaToKilocandela(baseValue);
                case UnitConverterLuminousIntensityUnit.Candlepower:
                    return UnitConverterHistoricalLuminousIntensity.CandelaToCandlepower(baseValue);
                case UnitConverterLuminousIntensityUnit.Hefnerkerze:
                    return UnitConverterHistoricalLuminousIntensity.CandelaToHefnerkerze(baseValue);
                case UnitConverterLuminousIntensityUnit.Microcandela:
                    return UnitConverterMetricLuminousIntensity.CandelaToMicrocandela(baseValue);
                case UnitConverterLuminousIntensityUnit.Nanocandela:
                    return UnitConverterMetricLuminousIntensity.CandelaToNanocandela(baseValue);
                case UnitConverterLuminousIntensityUnit.Megacandela:
                    return UnitConverterMetricLuminousIntensity.CandelaToMegacandela(baseValue);
                case UnitConverterLuminousIntensityUnit.SphericalCandlepower:
                    return UnitConverterHistoricalLuminousIntensity.CandelaToSphericalCandlepower(baseValue);
                case UnitConverterLuminousIntensityUnit.Violle:
                    return UnitConverterHistoricalLuminousIntensity.CandelaToViolle(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous intensity unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousIntensityUnit.Candela:
                    return "cd";
                case UnitConverterLuminousIntensityUnit.Millicandela:
                    return "mcd";
                case UnitConverterLuminousIntensityUnit.Kilocandela:
                    return "kcd";
                case UnitConverterLuminousIntensityUnit.Candlepower:
                    return "cp";
                case UnitConverterLuminousIntensityUnit.Hefnerkerze:
                    return "HK";
                case UnitConverterLuminousIntensityUnit.Microcandela:
                    return "µcd";
                case UnitConverterLuminousIntensityUnit.Nanocandela:
                    return "ncd";
                case UnitConverterLuminousIntensityUnit.Megacandela:
                    return "Mcd";
                case UnitConverterLuminousIntensityUnit.SphericalCandlepower:
                    return "scp";
                case UnitConverterLuminousIntensityUnit.Violle:
                    return "violle";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousIntensityUnit.Candela:
                    return "Candela";
                case UnitConverterLuminousIntensityUnit.Millicandela:
                    return "Millicandela";
                case UnitConverterLuminousIntensityUnit.Kilocandela:
                    return "Kilocandela";
                case UnitConverterLuminousIntensityUnit.Candlepower:
                    return "Candlepower";
                case UnitConverterLuminousIntensityUnit.Hefnerkerze:
                    return "Hefnerkerze";
                case UnitConverterLuminousIntensityUnit.Microcandela:
                    return "Microcandela";
                case UnitConverterLuminousIntensityUnit.Nanocandela:
                    return "Nanocandela";
                case UnitConverterLuminousIntensityUnit.Megacandela:
                    return "Megacandela";
                case UnitConverterLuminousIntensityUnit.SphericalCandlepower:
                    return "Spherical Candlepower";
                case UnitConverterLuminousIntensityUnit.Violle:
                    return "Violle";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousIntensityUnit.Candela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.Millicandela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.Kilocandela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.Candlepower:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousIntensityUnit.Hefnerkerze:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousIntensityUnit.Microcandela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.Nanocandela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.Megacandela:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousIntensityUnit.SphericalCandlepower:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousIntensityUnit.Violle:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminousIntensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminousIntensityUnit.Candela, UnitConverterLuminousIntensityUnit.Millicandela, UnitConverterLuminousIntensityUnit.Kilocandela, UnitConverterLuminousIntensityUnit.Microcandela, UnitConverterLuminousIntensityUnit.Nanocandela, UnitConverterLuminousIntensityUnit.Megacandela };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterLuminousIntensityUnit.Candlepower, UnitConverterLuminousIntensityUnit.Hefnerkerze, UnitConverterLuminousIntensityUnit.SphericalCandlepower, UnitConverterLuminousIntensityUnit.Violle };
                default:
                    return new[] { UnitConverterLuminousIntensityUnit.Candela, UnitConverterLuminousIntensityUnit.Millicandela, UnitConverterLuminousIntensityUnit.Kilocandela, UnitConverterLuminousIntensityUnit.Candlepower, UnitConverterLuminousIntensityUnit.Hefnerkerze, UnitConverterLuminousIntensityUnit.Microcandela, UnitConverterLuminousIntensityUnit.Nanocandela, UnitConverterLuminousIntensityUnit.Megacandela, UnitConverterLuminousIntensityUnit.SphericalCandlepower, UnitConverterLuminousIntensityUnit.Violle };
            }
        }
    }
}
