namespace UnitConverter.Radioactivity
{
    using UnitConverter.Radioactivity.Metric;
    using UnitConverter.Radioactivity.Common;
    using UnitConverter.Radioactivity.Historical;

    public enum UnitConverterRadioactivityUnit
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

    public static class UnitConverterRadioactivity
    {
        public static double Convert(double value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            double baseValue = ToBecquerel(value, from);
            return FromBecquerel(baseValue, to);
        }

        public static double ToBecquerel(double value, UnitConverterRadioactivityUnit from)
        {
            switch (from)
            {
                case UnitConverterRadioactivityUnit.Becquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Kilobecquerel:
                    return UnitConverterMetricRadioactivity.KilobecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Megabecquerel:
                    return UnitConverterMetricRadioactivity.MegabecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Gigabecquerel:
                    return UnitConverterMetricRadioactivity.GigabecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Terabecquerel:
                    return UnitConverterMetricRadioactivity.TerabecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Curie:
                    return UnitConverterCommonRadioactivity.CurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Millicurie:
                    return UnitConverterCommonRadioactivity.MillicurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Microcurie:
                    return UnitConverterCommonRadioactivity.MicrocurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Rutherford:
                    return UnitConverterHistoricalRadioactivity.RutherfordToBecquerel(value);
                case UnitConverterRadioactivityUnit.Microbecquerel:
                    return UnitConverterMetricRadioactivity.MicrobecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Millibecquerel:
                    return UnitConverterMetricRadioactivity.MillibecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Petabecquerel:
                    return UnitConverterMetricRadioactivity.PetabecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitConverterCommonRadioactivity.DisintegrationsPerSecondToBecquerel(value);
                case UnitConverterRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitConverterCommonRadioactivity.DisintegrationsPerMinuteToBecquerel(value);
                case UnitConverterRadioactivityUnit.DisintegrationsPerHour:
                    return UnitConverterCommonRadioactivity.DisintegrationsPerHourToBecquerel(value);
                case UnitConverterRadioactivityUnit.Nanobecquerel:
                    return UnitConverterMetricRadioactivity.NanobecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Exabecquerel:
                    return UnitConverterMetricRadioactivity.ExabecquerelToBecquerel(value);
                case UnitConverterRadioactivityUnit.Picocurie:
                    return UnitConverterHistoricalRadioactivity.PicocurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Nanocurie:
                    return UnitConverterHistoricalRadioactivity.NanocurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Kilocurie:
                    return UnitConverterHistoricalRadioactivity.KilocurieToBecquerel(value);
                case UnitConverterRadioactivityUnit.Megacurie:
                    return UnitConverterHistoricalRadioactivity.MegacurieToBecquerel(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radioactivity unit.");
            }
        }

        public static double FromBecquerel(double baseValue, UnitConverterRadioactivityUnit to)
        {
            switch (to)
            {
                case UnitConverterRadioactivityUnit.Becquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToBecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Kilobecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToKilobecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Megabecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToMegabecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Gigabecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToGigabecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Terabecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToTerabecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Curie:
                    return UnitConverterCommonRadioactivity.BecquerelToCurie(baseValue);
                case UnitConverterRadioactivityUnit.Millicurie:
                    return UnitConverterCommonRadioactivity.BecquerelToMillicurie(baseValue);
                case UnitConverterRadioactivityUnit.Microcurie:
                    return UnitConverterCommonRadioactivity.BecquerelToMicrocurie(baseValue);
                case UnitConverterRadioactivityUnit.Rutherford:
                    return UnitConverterHistoricalRadioactivity.BecquerelToRutherford(baseValue);
                case UnitConverterRadioactivityUnit.Microbecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToMicrobecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Millibecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToMillibecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Petabecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToPetabecquerel(baseValue);
                case UnitConverterRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitConverterCommonRadioactivity.BecquerelToDisintegrationsPerSecond(baseValue);
                case UnitConverterRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitConverterCommonRadioactivity.BecquerelToDisintegrationsPerMinute(baseValue);
                case UnitConverterRadioactivityUnit.DisintegrationsPerHour:
                    return UnitConverterCommonRadioactivity.BecquerelToDisintegrationsPerHour(baseValue);
                case UnitConverterRadioactivityUnit.Nanobecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToNanobecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Exabecquerel:
                    return UnitConverterMetricRadioactivity.BecquerelToExabecquerel(baseValue);
                case UnitConverterRadioactivityUnit.Picocurie:
                    return UnitConverterHistoricalRadioactivity.BecquerelToPicocurie(baseValue);
                case UnitConverterRadioactivityUnit.Nanocurie:
                    return UnitConverterHistoricalRadioactivity.BecquerelToNanocurie(baseValue);
                case UnitConverterRadioactivityUnit.Kilocurie:
                    return UnitConverterHistoricalRadioactivity.BecquerelToKilocurie(baseValue);
                case UnitConverterRadioactivityUnit.Megacurie:
                    return UnitConverterHistoricalRadioactivity.BecquerelToMegacurie(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radioactivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadioactivityUnit.Becquerel:
                    return "Bq";
                case UnitConverterRadioactivityUnit.Kilobecquerel:
                    return "kBq";
                case UnitConverterRadioactivityUnit.Megabecquerel:
                    return "MBq";
                case UnitConverterRadioactivityUnit.Gigabecquerel:
                    return "GBq";
                case UnitConverterRadioactivityUnit.Terabecquerel:
                    return "TBq";
                case UnitConverterRadioactivityUnit.Curie:
                    return "Ci";
                case UnitConverterRadioactivityUnit.Millicurie:
                    return "mCi";
                case UnitConverterRadioactivityUnit.Microcurie:
                    return "µCi";
                case UnitConverterRadioactivityUnit.Rutherford:
                    return "Rd";
                case UnitConverterRadioactivityUnit.Microbecquerel:
                    return "µBq";
                case UnitConverterRadioactivityUnit.Millibecquerel:
                    return "mBq";
                case UnitConverterRadioactivityUnit.Petabecquerel:
                    return "PBq";
                case UnitConverterRadioactivityUnit.DisintegrationsPerSecond:
                    return "dps";
                case UnitConverterRadioactivityUnit.DisintegrationsPerMinute:
                    return "dpm";
                case UnitConverterRadioactivityUnit.DisintegrationsPerHour:
                    return "dph";
                case UnitConverterRadioactivityUnit.Nanobecquerel:
                    return "nBq";
                case UnitConverterRadioactivityUnit.Exabecquerel:
                    return "EBq";
                case UnitConverterRadioactivityUnit.Picocurie:
                    return "pCi";
                case UnitConverterRadioactivityUnit.Nanocurie:
                    return "nCi";
                case UnitConverterRadioactivityUnit.Kilocurie:
                    return "kCi";
                case UnitConverterRadioactivityUnit.Megacurie:
                    return "MCi";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadioactivityUnit.Becquerel:
                    return "becquerel";
                case UnitConverterRadioactivityUnit.Kilobecquerel:
                    return "kilobecquerel";
                case UnitConverterRadioactivityUnit.Megabecquerel:
                    return "megabecquerel";
                case UnitConverterRadioactivityUnit.Gigabecquerel:
                    return "gigabecquerel";
                case UnitConverterRadioactivityUnit.Terabecquerel:
                    return "terabecquerel";
                case UnitConverterRadioactivityUnit.Curie:
                    return "curie";
                case UnitConverterRadioactivityUnit.Millicurie:
                    return "millicurie";
                case UnitConverterRadioactivityUnit.Microcurie:
                    return "microcurie";
                case UnitConverterRadioactivityUnit.Rutherford:
                    return "rutherford";
                case UnitConverterRadioactivityUnit.Microbecquerel:
                    return "Microbecquerel";
                case UnitConverterRadioactivityUnit.Millibecquerel:
                    return "Millibecquerel";
                case UnitConverterRadioactivityUnit.Petabecquerel:
                    return "Petabecquerel";
                case UnitConverterRadioactivityUnit.DisintegrationsPerSecond:
                    return "Disintegrations Per Second";
                case UnitConverterRadioactivityUnit.DisintegrationsPerMinute:
                    return "Disintegrations Per Minute";
                case UnitConverterRadioactivityUnit.DisintegrationsPerHour:
                    return "Disintegrations Per Hour";
                case UnitConverterRadioactivityUnit.Nanobecquerel:
                    return "Nanobecquerel";
                case UnitConverterRadioactivityUnit.Exabecquerel:
                    return "Exabecquerel";
                case UnitConverterRadioactivityUnit.Picocurie:
                    return "Picocurie";
                case UnitConverterRadioactivityUnit.Nanocurie:
                    return "Nanocurie";
                case UnitConverterRadioactivityUnit.Kilocurie:
                    return "Kilocurie";
                case UnitConverterRadioactivityUnit.Megacurie:
                    return "Megacurie";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterRadioactivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadioactivityUnit.Becquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Kilobecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Megabecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Gigabecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Terabecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Curie:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.Millicurie:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.Microcurie:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.Rutherford:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadioactivityUnit.Microbecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Millibecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Petabecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.DisintegrationsPerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.DisintegrationsPerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.DisintegrationsPerHour:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadioactivityUnit.Nanobecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Exabecquerel:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadioactivityUnit.Picocurie:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadioactivityUnit.Nanocurie:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadioactivityUnit.Kilocurie:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadioactivityUnit.Megacurie:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterRadioactivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterRadioactivityUnit.Becquerel, UnitConverterRadioactivityUnit.Kilobecquerel, UnitConverterRadioactivityUnit.Megabecquerel, UnitConverterRadioactivityUnit.Gigabecquerel, UnitConverterRadioactivityUnit.Terabecquerel, UnitConverterRadioactivityUnit.Microbecquerel, UnitConverterRadioactivityUnit.Millibecquerel, UnitConverterRadioactivityUnit.Petabecquerel, UnitConverterRadioactivityUnit.Nanobecquerel, UnitConverterRadioactivityUnit.Exabecquerel };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterRadioactivityUnit.Curie, UnitConverterRadioactivityUnit.Millicurie, UnitConverterRadioactivityUnit.Microcurie, UnitConverterRadioactivityUnit.DisintegrationsPerSecond, UnitConverterRadioactivityUnit.DisintegrationsPerMinute, UnitConverterRadioactivityUnit.DisintegrationsPerHour };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterRadioactivityUnit.Rutherford, UnitConverterRadioactivityUnit.Picocurie, UnitConverterRadioactivityUnit.Nanocurie, UnitConverterRadioactivityUnit.Kilocurie, UnitConverterRadioactivityUnit.Megacurie };
                default:
                    return new[] { UnitConverterRadioactivityUnit.Becquerel, UnitConverterRadioactivityUnit.Kilobecquerel, UnitConverterRadioactivityUnit.Megabecquerel, UnitConverterRadioactivityUnit.Gigabecquerel, UnitConverterRadioactivityUnit.Terabecquerel, UnitConverterRadioactivityUnit.Curie, UnitConverterRadioactivityUnit.Millicurie, UnitConverterRadioactivityUnit.Microcurie, UnitConverterRadioactivityUnit.Rutherford, UnitConverterRadioactivityUnit.Microbecquerel, UnitConverterRadioactivityUnit.Millibecquerel, UnitConverterRadioactivityUnit.Petabecquerel, UnitConverterRadioactivityUnit.DisintegrationsPerSecond, UnitConverterRadioactivityUnit.DisintegrationsPerMinute, UnitConverterRadioactivityUnit.DisintegrationsPerHour, UnitConverterRadioactivityUnit.Nanobecquerel, UnitConverterRadioactivityUnit.Exabecquerel, UnitConverterRadioactivityUnit.Picocurie, UnitConverterRadioactivityUnit.Nanocurie, UnitConverterRadioactivityUnit.Kilocurie, UnitConverterRadioactivityUnit.Megacurie };
            }
        }
    }
}
