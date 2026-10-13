namespace UnitTools.Radioactivity
{
    using UnitTools.Radioactivity.Metric;
    using UnitTools.Radioactivity.Common;
    using UnitTools.Radioactivity.Historical;

    public enum UnitToolsRadioactivityUnit
    {
        Becquerel = 0,
        Kilobecquerel = 1,
        Megabecquerel = 2,
        Gigabecquerel = 3,
        Terabecquerel = 4,
        Curie = 5,
        Millicurie = 6,
        Microcurie = 7,
        Rutherford = 8,
        Microbecquerel = 9,
        Millibecquerel = 10,
        Petabecquerel = 11,
        DisintegrationsPerSecond = 12,
        DisintegrationsPerMinute = 13,
        DisintegrationsPerHour = 14,
        Nanobecquerel = 15,
        Exabecquerel = 16,
        Picocurie = 17,
        Nanocurie = 18,
        Kilocurie = 19,
        Megacurie = 20,
    }

    public static class UnitToolsRadioactivity
    {
        public static double Convert(double value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            double baseValue = ToBecquerel(value, from);
            return FromBecquerel(baseValue, to);
        }

        public static double ToBecquerel(double value, UnitToolsRadioactivityUnit from)
        {
            switch (from)
            {
                case UnitToolsRadioactivityUnit.Becquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Kilobecquerel:
                    return UnitToolsMetricRadioactivity.KilobecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Megabecquerel:
                    return UnitToolsMetricRadioactivity.MegabecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Gigabecquerel:
                    return UnitToolsMetricRadioactivity.GigabecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Terabecquerel:
                    return UnitToolsMetricRadioactivity.TerabecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Curie:
                    return UnitToolsCommonRadioactivity.CurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Millicurie:
                    return UnitToolsCommonRadioactivity.MillicurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Microcurie:
                    return UnitToolsCommonRadioactivity.MicrocurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Rutherford:
                    return UnitToolsHistoricalRadioactivity.RutherfordToBecquerel(value);
                case UnitToolsRadioactivityUnit.Microbecquerel:
                    return UnitToolsMetricRadioactivity.MicrobecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Millibecquerel:
                    return UnitToolsMetricRadioactivity.MillibecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Petabecquerel:
                    return UnitToolsMetricRadioactivity.PetabecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitToolsCommonRadioactivity.DisintegrationsPerSecondToBecquerel(value);
                case UnitToolsRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitToolsCommonRadioactivity.DisintegrationsPerMinuteToBecquerel(value);
                case UnitToolsRadioactivityUnit.DisintegrationsPerHour:
                    return UnitToolsCommonRadioactivity.DisintegrationsPerHourToBecquerel(value);
                case UnitToolsRadioactivityUnit.Nanobecquerel:
                    return UnitToolsMetricRadioactivity.NanobecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Exabecquerel:
                    return UnitToolsMetricRadioactivity.ExabecquerelToBecquerel(value);
                case UnitToolsRadioactivityUnit.Picocurie:
                    return UnitToolsHistoricalRadioactivity.PicocurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Nanocurie:
                    return UnitToolsHistoricalRadioactivity.NanocurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Kilocurie:
                    return UnitToolsHistoricalRadioactivity.KilocurieToBecquerel(value);
                case UnitToolsRadioactivityUnit.Megacurie:
                    return UnitToolsHistoricalRadioactivity.MegacurieToBecquerel(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radioactivity unit.");
            }
        }

        public static double FromBecquerel(double baseValue, UnitToolsRadioactivityUnit to)
        {
            switch (to)
            {
                case UnitToolsRadioactivityUnit.Becquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToBecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Kilobecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToKilobecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Megabecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToMegabecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Gigabecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToGigabecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Terabecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToTerabecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Curie:
                    return UnitToolsCommonRadioactivity.BecquerelToCurie(baseValue);
                case UnitToolsRadioactivityUnit.Millicurie:
                    return UnitToolsCommonRadioactivity.BecquerelToMillicurie(baseValue);
                case UnitToolsRadioactivityUnit.Microcurie:
                    return UnitToolsCommonRadioactivity.BecquerelToMicrocurie(baseValue);
                case UnitToolsRadioactivityUnit.Rutherford:
                    return UnitToolsHistoricalRadioactivity.BecquerelToRutherford(baseValue);
                case UnitToolsRadioactivityUnit.Microbecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToMicrobecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Millibecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToMillibecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Petabecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToPetabecquerel(baseValue);
                case UnitToolsRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitToolsCommonRadioactivity.BecquerelToDisintegrationsPerSecond(baseValue);
                case UnitToolsRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitToolsCommonRadioactivity.BecquerelToDisintegrationsPerMinute(baseValue);
                case UnitToolsRadioactivityUnit.DisintegrationsPerHour:
                    return UnitToolsCommonRadioactivity.BecquerelToDisintegrationsPerHour(baseValue);
                case UnitToolsRadioactivityUnit.Nanobecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToNanobecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Exabecquerel:
                    return UnitToolsMetricRadioactivity.BecquerelToExabecquerel(baseValue);
                case UnitToolsRadioactivityUnit.Picocurie:
                    return UnitToolsHistoricalRadioactivity.BecquerelToPicocurie(baseValue);
                case UnitToolsRadioactivityUnit.Nanocurie:
                    return UnitToolsHistoricalRadioactivity.BecquerelToNanocurie(baseValue);
                case UnitToolsRadioactivityUnit.Kilocurie:
                    return UnitToolsHistoricalRadioactivity.BecquerelToKilocurie(baseValue);
                case UnitToolsRadioactivityUnit.Megacurie:
                    return UnitToolsHistoricalRadioactivity.BecquerelToMegacurie(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radioactivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadioactivityUnit.Becquerel:
                    return "Bq";
                case UnitToolsRadioactivityUnit.Kilobecquerel:
                    return "kBq";
                case UnitToolsRadioactivityUnit.Megabecquerel:
                    return "MBq";
                case UnitToolsRadioactivityUnit.Gigabecquerel:
                    return "GBq";
                case UnitToolsRadioactivityUnit.Terabecquerel:
                    return "TBq";
                case UnitToolsRadioactivityUnit.Curie:
                    return "Ci";
                case UnitToolsRadioactivityUnit.Millicurie:
                    return "mCi";
                case UnitToolsRadioactivityUnit.Microcurie:
                    return "µCi";
                case UnitToolsRadioactivityUnit.Rutherford:
                    return "Rd";
                case UnitToolsRadioactivityUnit.Microbecquerel:
                    return "µBq";
                case UnitToolsRadioactivityUnit.Millibecquerel:
                    return "mBq";
                case UnitToolsRadioactivityUnit.Petabecquerel:
                    return "PBq";
                case UnitToolsRadioactivityUnit.DisintegrationsPerSecond:
                    return "dps";
                case UnitToolsRadioactivityUnit.DisintegrationsPerMinute:
                    return "dpm";
                case UnitToolsRadioactivityUnit.DisintegrationsPerHour:
                    return "dph";
                case UnitToolsRadioactivityUnit.Nanobecquerel:
                    return "nBq";
                case UnitToolsRadioactivityUnit.Exabecquerel:
                    return "EBq";
                case UnitToolsRadioactivityUnit.Picocurie:
                    return "pCi";
                case UnitToolsRadioactivityUnit.Nanocurie:
                    return "nCi";
                case UnitToolsRadioactivityUnit.Kilocurie:
                    return "kCi";
                case UnitToolsRadioactivityUnit.Megacurie:
                    return "MCi";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadioactivityUnit.Becquerel:
                    return "becquerel";
                case UnitToolsRadioactivityUnit.Kilobecquerel:
                    return "kilobecquerel";
                case UnitToolsRadioactivityUnit.Megabecquerel:
                    return "megabecquerel";
                case UnitToolsRadioactivityUnit.Gigabecquerel:
                    return "gigabecquerel";
                case UnitToolsRadioactivityUnit.Terabecquerel:
                    return "terabecquerel";
                case UnitToolsRadioactivityUnit.Curie:
                    return "curie";
                case UnitToolsRadioactivityUnit.Millicurie:
                    return "millicurie";
                case UnitToolsRadioactivityUnit.Microcurie:
                    return "microcurie";
                case UnitToolsRadioactivityUnit.Rutherford:
                    return "rutherford";
                case UnitToolsRadioactivityUnit.Microbecquerel:
                    return "Microbecquerel";
                case UnitToolsRadioactivityUnit.Millibecquerel:
                    return "Millibecquerel";
                case UnitToolsRadioactivityUnit.Petabecquerel:
                    return "Petabecquerel";
                case UnitToolsRadioactivityUnit.DisintegrationsPerSecond:
                    return "Disintegrations Per Second";
                case UnitToolsRadioactivityUnit.DisintegrationsPerMinute:
                    return "Disintegrations Per Minute";
                case UnitToolsRadioactivityUnit.DisintegrationsPerHour:
                    return "Disintegrations Per Hour";
                case UnitToolsRadioactivityUnit.Nanobecquerel:
                    return "Nanobecquerel";
                case UnitToolsRadioactivityUnit.Exabecquerel:
                    return "Exabecquerel";
                case UnitToolsRadioactivityUnit.Picocurie:
                    return "Picocurie";
                case UnitToolsRadioactivityUnit.Nanocurie:
                    return "Nanocurie";
                case UnitToolsRadioactivityUnit.Kilocurie:
                    return "Kilocurie";
                case UnitToolsRadioactivityUnit.Megacurie:
                    return "Megacurie";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadioactivityUnit.Becquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Kilobecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Megabecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Gigabecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Terabecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Curie:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.Millicurie:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.Microcurie:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.Rutherford:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadioactivityUnit.Microbecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Millibecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Petabecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.DisintegrationsPerHour:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadioactivityUnit.Nanobecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Exabecquerel:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadioactivityUnit.Picocurie:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadioactivityUnit.Nanocurie:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadioactivityUnit.Kilocurie:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadioactivityUnit.Megacurie:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsRadioactivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsRadioactivityUnit.Becquerel, UnitToolsRadioactivityUnit.Kilobecquerel, UnitToolsRadioactivityUnit.Megabecquerel, UnitToolsRadioactivityUnit.Gigabecquerel, UnitToolsRadioactivityUnit.Terabecquerel, UnitToolsRadioactivityUnit.Microbecquerel, UnitToolsRadioactivityUnit.Millibecquerel, UnitToolsRadioactivityUnit.Petabecquerel, UnitToolsRadioactivityUnit.Nanobecquerel, UnitToolsRadioactivityUnit.Exabecquerel };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsRadioactivityUnit.Curie, UnitToolsRadioactivityUnit.Millicurie, UnitToolsRadioactivityUnit.Microcurie, UnitToolsRadioactivityUnit.DisintegrationsPerSecond, UnitToolsRadioactivityUnit.DisintegrationsPerMinute, UnitToolsRadioactivityUnit.DisintegrationsPerHour };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsRadioactivityUnit.Rutherford, UnitToolsRadioactivityUnit.Picocurie, UnitToolsRadioactivityUnit.Nanocurie, UnitToolsRadioactivityUnit.Kilocurie, UnitToolsRadioactivityUnit.Megacurie };
                default:
                    return new[] { UnitToolsRadioactivityUnit.Becquerel, UnitToolsRadioactivityUnit.Kilobecquerel, UnitToolsRadioactivityUnit.Megabecquerel, UnitToolsRadioactivityUnit.Gigabecquerel, UnitToolsRadioactivityUnit.Terabecquerel, UnitToolsRadioactivityUnit.Curie, UnitToolsRadioactivityUnit.Millicurie, UnitToolsRadioactivityUnit.Microcurie, UnitToolsRadioactivityUnit.Rutherford, UnitToolsRadioactivityUnit.Microbecquerel, UnitToolsRadioactivityUnit.Millibecquerel, UnitToolsRadioactivityUnit.Petabecquerel, UnitToolsRadioactivityUnit.DisintegrationsPerSecond, UnitToolsRadioactivityUnit.DisintegrationsPerMinute, UnitToolsRadioactivityUnit.DisintegrationsPerHour, UnitToolsRadioactivityUnit.Nanobecquerel, UnitToolsRadioactivityUnit.Exabecquerel, UnitToolsRadioactivityUnit.Picocurie, UnitToolsRadioactivityUnit.Nanocurie, UnitToolsRadioactivityUnit.Kilocurie, UnitToolsRadioactivityUnit.Megacurie };
            }
        }
    }
}
