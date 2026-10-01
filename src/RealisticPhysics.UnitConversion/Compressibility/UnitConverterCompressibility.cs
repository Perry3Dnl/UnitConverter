namespace RealisticPhysics.UnitConversion.Compressibility
{
    using RealisticPhysics.UnitConversion.Compressibility.Metric;
    using RealisticPhysics.UnitConversion.Compressibility.Imperial;

    public enum UnitConverterCompressibilityUnit
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

    public static class UnitConverterCompressibility
    {
        public static double Convert(double value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            double baseValue = ToPerPascal(value, from);
            return FromPerPascal(baseValue, to);
        }

        public static double ToPerPascal(double value, UnitConverterCompressibilityUnit from)
        {
            switch (from)
            {
                case UnitConverterCompressibilityUnit.PerPascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerKilopascal:
                    return UnitConverterMetricCompressibility.PerKilopascalToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerMegapascal:
                    return UnitConverterMetricCompressibility.PerMegapascalToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerBar:
                    return UnitConverterMetricCompressibility.PerBarToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerAtmosphere:
                    return UnitConverterMetricCompressibility.PerAtmosphereToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerPsi:
                    return UnitConverterImperialCompressibility.PerPsiToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerMillibar:
                    return UnitConverterMetricCompressibility.PerMillibarToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerHectopascal:
                    return UnitConverterMetricCompressibility.PerHectopascalToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerGigapascal:
                    return UnitConverterMetricCompressibility.PerGigapascalToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerTorr:
                    return UnitConverterMetricCompressibility.PerTorrToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerMillimeterMercury:
                    return UnitConverterMetricCompressibility.PerMillimeterMercuryToPerPascal(value);
                case UnitConverterCompressibilityUnit.PerInchMercury:
                    return UnitConverterImperialCompressibility.PerInchMercuryToPerPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported compressibility unit.");
            }
        }

        public static double FromPerPascal(double baseValue, UnitConverterCompressibilityUnit to)
        {
            switch (to)
            {
                case UnitConverterCompressibilityUnit.PerPascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerPascal(baseValue);
                case UnitConverterCompressibilityUnit.PerKilopascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerKilopascal(baseValue);
                case UnitConverterCompressibilityUnit.PerMegapascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerMegapascal(baseValue);
                case UnitConverterCompressibilityUnit.PerBar:
                    return UnitConverterMetricCompressibility.PerPascalToPerBar(baseValue);
                case UnitConverterCompressibilityUnit.PerAtmosphere:
                    return UnitConverterMetricCompressibility.PerPascalToPerAtmosphere(baseValue);
                case UnitConverterCompressibilityUnit.PerPsi:
                    return UnitConverterImperialCompressibility.PerPascalToPerPsi(baseValue);
                case UnitConverterCompressibilityUnit.PerMillibar:
                    return UnitConverterMetricCompressibility.PerPascalToPerMillibar(baseValue);
                case UnitConverterCompressibilityUnit.PerHectopascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerHectopascal(baseValue);
                case UnitConverterCompressibilityUnit.PerGigapascal:
                    return UnitConverterMetricCompressibility.PerPascalToPerGigapascal(baseValue);
                case UnitConverterCompressibilityUnit.PerTorr:
                    return UnitConverterMetricCompressibility.PerPascalToPerTorr(baseValue);
                case UnitConverterCompressibilityUnit.PerMillimeterMercury:
                    return UnitConverterMetricCompressibility.PerPascalToPerMillimeterMercury(baseValue);
                case UnitConverterCompressibilityUnit.PerInchMercury:
                    return UnitConverterImperialCompressibility.PerPascalToPerInchMercury(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported compressibility unit.");
            }
        }

        public static string GetSymbol(UnitConverterCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCompressibilityUnit.PerPascal:
                    return "1/Pa";
                case UnitConverterCompressibilityUnit.PerKilopascal:
                    return "1/kPa";
                case UnitConverterCompressibilityUnit.PerMegapascal:
                    return "1/MPa";
                case UnitConverterCompressibilityUnit.PerBar:
                    return "1/bar";
                case UnitConverterCompressibilityUnit.PerAtmosphere:
                    return "1/atm";
                case UnitConverterCompressibilityUnit.PerPsi:
                    return "1/psi";
                case UnitConverterCompressibilityUnit.PerMillibar:
                    return "1/mbar";
                case UnitConverterCompressibilityUnit.PerHectopascal:
                    return "1/hPa";
                case UnitConverterCompressibilityUnit.PerGigapascal:
                    return "1/GPa";
                case UnitConverterCompressibilityUnit.PerTorr:
                    return "1/Torr";
                case UnitConverterCompressibilityUnit.PerMillimeterMercury:
                    return "1/mmHg";
                case UnitConverterCompressibilityUnit.PerInchMercury:
                    return "1/inHg";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCompressibilityUnit.PerPascal:
                    return "Per Pascal";
                case UnitConverterCompressibilityUnit.PerKilopascal:
                    return "Per Kilopascal";
                case UnitConverterCompressibilityUnit.PerMegapascal:
                    return "Per Megapascal";
                case UnitConverterCompressibilityUnit.PerBar:
                    return "Per Bar";
                case UnitConverterCompressibilityUnit.PerAtmosphere:
                    return "Per Atmosphere";
                case UnitConverterCompressibilityUnit.PerPsi:
                    return "Per Psi";
                case UnitConverterCompressibilityUnit.PerMillibar:
                    return "Per Millibar";
                case UnitConverterCompressibilityUnit.PerHectopascal:
                    return "Per Hectopascal";
                case UnitConverterCompressibilityUnit.PerGigapascal:
                    return "Per Gigapascal";
                case UnitConverterCompressibilityUnit.PerTorr:
                    return "Per Torr";
                case UnitConverterCompressibilityUnit.PerMillimeterMercury:
                    return "Per Millimeter Mercury";
                case UnitConverterCompressibilityUnit.PerInchMercury:
                    return "Per Inch Mercury";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterCompressibilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCompressibilityUnit.PerPascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerKilopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerMegapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerBar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerAtmosphere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerPsi:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterCompressibilityUnit.PerMillibar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerHectopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerGigapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerTorr:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerMillimeterMercury:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCompressibilityUnit.PerInchMercury:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterCompressibilityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterCompressibilityUnit.PerPascal, UnitConverterCompressibilityUnit.PerKilopascal, UnitConverterCompressibilityUnit.PerMegapascal, UnitConverterCompressibilityUnit.PerBar, UnitConverterCompressibilityUnit.PerAtmosphere, UnitConverterCompressibilityUnit.PerMillibar, UnitConverterCompressibilityUnit.PerHectopascal, UnitConverterCompressibilityUnit.PerGigapascal, UnitConverterCompressibilityUnit.PerTorr, UnitConverterCompressibilityUnit.PerMillimeterMercury };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterCompressibilityUnit.PerPsi, UnitConverterCompressibilityUnit.PerInchMercury };
                default:
                    return new[] { UnitConverterCompressibilityUnit.PerPascal, UnitConverterCompressibilityUnit.PerKilopascal, UnitConverterCompressibilityUnit.PerMegapascal, UnitConverterCompressibilityUnit.PerBar, UnitConverterCompressibilityUnit.PerAtmosphere, UnitConverterCompressibilityUnit.PerPsi, UnitConverterCompressibilityUnit.PerMillibar, UnitConverterCompressibilityUnit.PerHectopascal, UnitConverterCompressibilityUnit.PerGigapascal, UnitConverterCompressibilityUnit.PerTorr, UnitConverterCompressibilityUnit.PerMillimeterMercury, UnitConverterCompressibilityUnit.PerInchMercury };
            }
        }
    }
}
