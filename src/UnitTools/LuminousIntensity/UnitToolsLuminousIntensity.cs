namespace UnitTools.LuminousIntensity
{
    using UnitTools.LuminousIntensity.Metric;
    using UnitTools.LuminousIntensity.Historical;

    public enum UnitToolsLuminousIntensityUnit
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

    public static class UnitToolsLuminousIntensity
    {
        public static double Convert(double value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            double baseValue = ToCandela(value, from);
            return FromCandela(baseValue, to);
        }

        public static double ToCandela(double value, UnitToolsLuminousIntensityUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminousIntensityUnit.Candela:
                    return UnitToolsMetricLuminousIntensity.CandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.Millicandela:
                    return UnitToolsMetricLuminousIntensity.MillicandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.Kilocandela:
                    return UnitToolsMetricLuminousIntensity.KilocandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.Candlepower:
                    return UnitToolsHistoricalLuminousIntensity.CandlepowerToCandela(value);
                case UnitToolsLuminousIntensityUnit.Hefnerkerze:
                    return UnitToolsHistoricalLuminousIntensity.HefnerkerzeToCandela(value);
                case UnitToolsLuminousIntensityUnit.Microcandela:
                    return UnitToolsMetricLuminousIntensity.MicrocandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.Nanocandela:
                    return UnitToolsMetricLuminousIntensity.NanocandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.Megacandela:
                    return UnitToolsMetricLuminousIntensity.MegacandelaToCandela(value);
                case UnitToolsLuminousIntensityUnit.SphericalCandlepower:
                    return UnitToolsHistoricalLuminousIntensity.SphericalCandlepowerToCandela(value);
                case UnitToolsLuminousIntensityUnit.Violle:
                    return UnitToolsHistoricalLuminousIntensity.ViolleToCandela(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous intensity unit.");
            }
        }

        public static double FromCandela(double baseValue, UnitToolsLuminousIntensityUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminousIntensityUnit.Candela:
                    return UnitToolsMetricLuminousIntensity.CandelaToCandela(baseValue);
                case UnitToolsLuminousIntensityUnit.Millicandela:
                    return UnitToolsMetricLuminousIntensity.CandelaToMillicandela(baseValue);
                case UnitToolsLuminousIntensityUnit.Kilocandela:
                    return UnitToolsMetricLuminousIntensity.CandelaToKilocandela(baseValue);
                case UnitToolsLuminousIntensityUnit.Candlepower:
                    return UnitToolsHistoricalLuminousIntensity.CandelaToCandlepower(baseValue);
                case UnitToolsLuminousIntensityUnit.Hefnerkerze:
                    return UnitToolsHistoricalLuminousIntensity.CandelaToHefnerkerze(baseValue);
                case UnitToolsLuminousIntensityUnit.Microcandela:
                    return UnitToolsMetricLuminousIntensity.CandelaToMicrocandela(baseValue);
                case UnitToolsLuminousIntensityUnit.Nanocandela:
                    return UnitToolsMetricLuminousIntensity.CandelaToNanocandela(baseValue);
                case UnitToolsLuminousIntensityUnit.Megacandela:
                    return UnitToolsMetricLuminousIntensity.CandelaToMegacandela(baseValue);
                case UnitToolsLuminousIntensityUnit.SphericalCandlepower:
                    return UnitToolsHistoricalLuminousIntensity.CandelaToSphericalCandlepower(baseValue);
                case UnitToolsLuminousIntensityUnit.Violle:
                    return UnitToolsHistoricalLuminousIntensity.CandelaToViolle(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous intensity unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousIntensityUnit.Candela:
                    return "cd";
                case UnitToolsLuminousIntensityUnit.Millicandela:
                    return "mcd";
                case UnitToolsLuminousIntensityUnit.Kilocandela:
                    return "kcd";
                case UnitToolsLuminousIntensityUnit.Candlepower:
                    return "cp";
                case UnitToolsLuminousIntensityUnit.Hefnerkerze:
                    return "HK";
                case UnitToolsLuminousIntensityUnit.Microcandela:
                    return "µcd";
                case UnitToolsLuminousIntensityUnit.Nanocandela:
                    return "ncd";
                case UnitToolsLuminousIntensityUnit.Megacandela:
                    return "Mcd";
                case UnitToolsLuminousIntensityUnit.SphericalCandlepower:
                    return "scp";
                case UnitToolsLuminousIntensityUnit.Violle:
                    return "violle";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousIntensityUnit.Candela:
                    return "Candela";
                case UnitToolsLuminousIntensityUnit.Millicandela:
                    return "Millicandela";
                case UnitToolsLuminousIntensityUnit.Kilocandela:
                    return "Kilocandela";
                case UnitToolsLuminousIntensityUnit.Candlepower:
                    return "Candlepower";
                case UnitToolsLuminousIntensityUnit.Hefnerkerze:
                    return "Hefnerkerze";
                case UnitToolsLuminousIntensityUnit.Microcandela:
                    return "Microcandela";
                case UnitToolsLuminousIntensityUnit.Nanocandela:
                    return "Nanocandela";
                case UnitToolsLuminousIntensityUnit.Megacandela:
                    return "Megacandela";
                case UnitToolsLuminousIntensityUnit.SphericalCandlepower:
                    return "Spherical Candlepower";
                case UnitToolsLuminousIntensityUnit.Violle:
                    return "Violle";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminousIntensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousIntensityUnit.Candela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.Millicandela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.Kilocandela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.Candlepower:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousIntensityUnit.Hefnerkerze:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousIntensityUnit.Microcandela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.Nanocandela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.Megacandela:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousIntensityUnit.SphericalCandlepower:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousIntensityUnit.Violle:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminousIntensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminousIntensityUnit.Candela, UnitToolsLuminousIntensityUnit.Millicandela, UnitToolsLuminousIntensityUnit.Kilocandela, UnitToolsLuminousIntensityUnit.Microcandela, UnitToolsLuminousIntensityUnit.Nanocandela, UnitToolsLuminousIntensityUnit.Megacandela };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsLuminousIntensityUnit.Candlepower, UnitToolsLuminousIntensityUnit.Hefnerkerze, UnitToolsLuminousIntensityUnit.SphericalCandlepower, UnitToolsLuminousIntensityUnit.Violle };
                default:
                    return new[] { UnitToolsLuminousIntensityUnit.Candela, UnitToolsLuminousIntensityUnit.Millicandela, UnitToolsLuminousIntensityUnit.Kilocandela, UnitToolsLuminousIntensityUnit.Candlepower, UnitToolsLuminousIntensityUnit.Hefnerkerze, UnitToolsLuminousIntensityUnit.Microcandela, UnitToolsLuminousIntensityUnit.Nanocandela, UnitToolsLuminousIntensityUnit.Megacandela, UnitToolsLuminousIntensityUnit.SphericalCandlepower, UnitToolsLuminousIntensityUnit.Violle };
            }
        }
    }
}
