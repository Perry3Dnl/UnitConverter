namespace UnitTools.Compressibility
{
    using UnitTools.Compressibility.Metric;
    using UnitTools.Compressibility.Imperial;

    public enum UnitToolsCompressibilityUnit
    {
        PerPascal = 0,
        PerKilopascal = 1,
        PerMegapascal = 2,
        PerBar = 3,
        PerAtmosphere = 4,
        PerPsi = 5,
        PerMillibar = 6,
        PerHectopascal = 7,
        PerGigapascal = 8,
        PerTorr = 9,
        PerMillimeterMercury = 10,
        PerInchMercury = 11,
    }

    public static class UnitToolsCompressibility
    {
        public static double Convert(double value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            double baseValue = ToPerPascal(value, from);
            return FromPerPascal(baseValue, to);
        }

        public static double ToPerPascal(double value, UnitToolsCompressibilityUnit from)
        {
            switch (from)
            {
                case UnitToolsCompressibilityUnit.PerPascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerKilopascal:
                    return UnitToolsMetricCompressibility.PerKilopascalToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerMegapascal:
                    return UnitToolsMetricCompressibility.PerMegapascalToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerBar:
                    return UnitToolsMetricCompressibility.PerBarToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerAtmosphere:
                    return UnitToolsMetricCompressibility.PerAtmosphereToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerPsi:
                    return UnitToolsImperialCompressibility.PerPsiToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerMillibar:
                    return UnitToolsMetricCompressibility.PerMillibarToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerHectopascal:
                    return UnitToolsMetricCompressibility.PerHectopascalToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerGigapascal:
                    return UnitToolsMetricCompressibility.PerGigapascalToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerTorr:
                    return UnitToolsMetricCompressibility.PerTorrToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerMillimeterMercury:
                    return UnitToolsMetricCompressibility.PerMillimeterMercuryToPerPascal(value);
                case UnitToolsCompressibilityUnit.PerInchMercury:
                    return UnitToolsImperialCompressibility.PerInchMercuryToPerPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported compressibility unit.");
            }
        }

        public static double FromPerPascal(double baseValue, UnitToolsCompressibilityUnit to)
        {
            switch (to)
            {
                case UnitToolsCompressibilityUnit.PerPascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerPascal(baseValue);
                case UnitToolsCompressibilityUnit.PerKilopascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerKilopascal(baseValue);
                case UnitToolsCompressibilityUnit.PerMegapascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerMegapascal(baseValue);
                case UnitToolsCompressibilityUnit.PerBar:
                    return UnitToolsMetricCompressibility.PerPascalToPerBar(baseValue);
                case UnitToolsCompressibilityUnit.PerAtmosphere:
                    return UnitToolsMetricCompressibility.PerPascalToPerAtmosphere(baseValue);
                case UnitToolsCompressibilityUnit.PerPsi:
                    return UnitToolsImperialCompressibility.PerPascalToPerPsi(baseValue);
                case UnitToolsCompressibilityUnit.PerMillibar:
                    return UnitToolsMetricCompressibility.PerPascalToPerMillibar(baseValue);
                case UnitToolsCompressibilityUnit.PerHectopascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerHectopascal(baseValue);
                case UnitToolsCompressibilityUnit.PerGigapascal:
                    return UnitToolsMetricCompressibility.PerPascalToPerGigapascal(baseValue);
                case UnitToolsCompressibilityUnit.PerTorr:
                    return UnitToolsMetricCompressibility.PerPascalToPerTorr(baseValue);
                case UnitToolsCompressibilityUnit.PerMillimeterMercury:
                    return UnitToolsMetricCompressibility.PerPascalToPerMillimeterMercury(baseValue);
                case UnitToolsCompressibilityUnit.PerInchMercury:
                    return UnitToolsImperialCompressibility.PerPascalToPerInchMercury(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported compressibility unit.");
            }
        }

        public static string GetSymbol(UnitToolsCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCompressibilityUnit.PerPascal:
                    return "1/Pa";
                case UnitToolsCompressibilityUnit.PerKilopascal:
                    return "1/kPa";
                case UnitToolsCompressibilityUnit.PerMegapascal:
                    return "1/MPa";
                case UnitToolsCompressibilityUnit.PerBar:
                    return "1/bar";
                case UnitToolsCompressibilityUnit.PerAtmosphere:
                    return "1/atm";
                case UnitToolsCompressibilityUnit.PerPsi:
                    return "1/psi";
                case UnitToolsCompressibilityUnit.PerMillibar:
                    return "1/mbar";
                case UnitToolsCompressibilityUnit.PerHectopascal:
                    return "1/hPa";
                case UnitToolsCompressibilityUnit.PerGigapascal:
                    return "1/GPa";
                case UnitToolsCompressibilityUnit.PerTorr:
                    return "1/Torr";
                case UnitToolsCompressibilityUnit.PerMillimeterMercury:
                    return "1/mmHg";
                case UnitToolsCompressibilityUnit.PerInchMercury:
                    return "1/inHg";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCompressibilityUnit.PerPascal:
                    return "Per Pascal";
                case UnitToolsCompressibilityUnit.PerKilopascal:
                    return "Per Kilopascal";
                case UnitToolsCompressibilityUnit.PerMegapascal:
                    return "Per Megapascal";
                case UnitToolsCompressibilityUnit.PerBar:
                    return "Per Bar";
                case UnitToolsCompressibilityUnit.PerAtmosphere:
                    return "Per Atmosphere";
                case UnitToolsCompressibilityUnit.PerPsi:
                    return "Per Psi";
                case UnitToolsCompressibilityUnit.PerMillibar:
                    return "Per Millibar";
                case UnitToolsCompressibilityUnit.PerHectopascal:
                    return "Per Hectopascal";
                case UnitToolsCompressibilityUnit.PerGigapascal:
                    return "Per Gigapascal";
                case UnitToolsCompressibilityUnit.PerTorr:
                    return "Per Torr";
                case UnitToolsCompressibilityUnit.PerMillimeterMercury:
                    return "Per Millimeter Mercury";
                case UnitToolsCompressibilityUnit.PerInchMercury:
                    return "Per Inch Mercury";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCompressibilityUnit.PerPascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerKilopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerMegapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerBar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerAtmosphere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerPsi:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsCompressibilityUnit.PerMillibar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerHectopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerGigapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerTorr:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerMillimeterMercury:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCompressibilityUnit.PerInchMercury:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsCompressibilityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsCompressibilityUnit.PerPascal, UnitToolsCompressibilityUnit.PerKilopascal, UnitToolsCompressibilityUnit.PerMegapascal, UnitToolsCompressibilityUnit.PerBar, UnitToolsCompressibilityUnit.PerAtmosphere, UnitToolsCompressibilityUnit.PerMillibar, UnitToolsCompressibilityUnit.PerHectopascal, UnitToolsCompressibilityUnit.PerGigapascal, UnitToolsCompressibilityUnit.PerTorr, UnitToolsCompressibilityUnit.PerMillimeterMercury };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsCompressibilityUnit.PerPsi, UnitToolsCompressibilityUnit.PerInchMercury };
                default:
                    return new[] { UnitToolsCompressibilityUnit.PerPascal, UnitToolsCompressibilityUnit.PerKilopascal, UnitToolsCompressibilityUnit.PerMegapascal, UnitToolsCompressibilityUnit.PerBar, UnitToolsCompressibilityUnit.PerAtmosphere, UnitToolsCompressibilityUnit.PerPsi, UnitToolsCompressibilityUnit.PerMillibar, UnitToolsCompressibilityUnit.PerHectopascal, UnitToolsCompressibilityUnit.PerGigapascal, UnitToolsCompressibilityUnit.PerTorr, UnitToolsCompressibilityUnit.PerMillimeterMercury, UnitToolsCompressibilityUnit.PerInchMercury };
            }
        }
    }
}
