namespace UnitTools.DoseRate
{
    using UnitTools.DoseRate.Metric;
    using UnitTools.DoseRate.Historical;

    public enum UnitToolsDoseRateUnit
    {
        GrayPerSecond = 0,
        MilligrayPerSecond = 1,
        MicrograyPerSecond = 2,
        GrayPerHour = 3,
        RadPerHour = 4,
        MillisievertPerHour = 5,
        GrayPerMinute = 6,
        MilligrayPerHour = 7,
        MicrograyPerHour = 8,
        SievertPerSecond = 9,
        MicrosievertPerHour = 10,
        RemPerSecond = 11,
        RemPerYear = 12,
        NanograyPerSecond = 13,
        PicograyPerSecond = 14,
        GrayPerYear = 15,
        SievertPerYear = 16,
        MicrosievertPerYear = 17,
    }

    public static class UnitToolsDoseRate
    {
        public static double Convert(double value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            double baseValue = ToGrayPerSecond(value, from);
            return FromGrayPerSecond(baseValue, to);
        }

        public static double ToGrayPerSecond(double value, UnitToolsDoseRateUnit from)
        {
            switch (from)
            {
                case UnitToolsDoseRateUnit.GrayPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MilligrayPerSecond:
                    return UnitToolsMetricDoseRate.MilligrayPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MicrograyPerSecond:
                    return UnitToolsMetricDoseRate.MicrograyPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.GrayPerHour:
                    return UnitToolsMetricDoseRate.GrayPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.RadPerHour:
                    return UnitToolsHistoricalDoseRate.RadPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MillisievertPerHour:
                    return UnitToolsMetricDoseRate.MillisievertPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.GrayPerMinute:
                    return UnitToolsMetricDoseRate.GrayPerMinuteToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MilligrayPerHour:
                    return UnitToolsMetricDoseRate.MilligrayPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MicrograyPerHour:
                    return UnitToolsMetricDoseRate.MicrograyPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.SievertPerSecond:
                    return UnitToolsMetricDoseRate.SievertPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MicrosievertPerHour:
                    return UnitToolsMetricDoseRate.MicrosievertPerHourToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.RemPerSecond:
                    return UnitToolsHistoricalDoseRate.RemPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.RemPerYear:
                    return UnitToolsHistoricalDoseRate.RemPerYearToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.NanograyPerSecond:
                    return UnitToolsMetricDoseRate.NanograyPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.PicograyPerSecond:
                    return UnitToolsMetricDoseRate.PicograyPerSecondToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.GrayPerYear:
                    return UnitToolsMetricDoseRate.GrayPerYearToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.SievertPerYear:
                    return UnitToolsMetricDoseRate.SievertPerYearToGrayPerSecond(value);
                case UnitToolsDoseRateUnit.MicrosievertPerYear:
                    return UnitToolsMetricDoseRate.MicrosievertPerYearToGrayPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dose rate unit.");
            }
        }

        public static double FromGrayPerSecond(double baseValue, UnitToolsDoseRateUnit to)
        {
            switch (to)
            {
                case UnitToolsDoseRateUnit.GrayPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToGrayPerSecond(baseValue);
                case UnitToolsDoseRateUnit.MilligrayPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMilligrayPerSecond(baseValue);
                case UnitToolsDoseRateUnit.MicrograyPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMicrograyPerSecond(baseValue);
                case UnitToolsDoseRateUnit.GrayPerHour:
                    return UnitToolsMetricDoseRate.GrayPerSecondToGrayPerHour(baseValue);
                case UnitToolsDoseRateUnit.RadPerHour:
                    return UnitToolsHistoricalDoseRate.GrayPerSecondToRadPerHour(baseValue);
                case UnitToolsDoseRateUnit.MillisievertPerHour:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMillisievertPerHour(baseValue);
                case UnitToolsDoseRateUnit.GrayPerMinute:
                    return UnitToolsMetricDoseRate.GrayPerSecondToGrayPerMinute(baseValue);
                case UnitToolsDoseRateUnit.MilligrayPerHour:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMilligrayPerHour(baseValue);
                case UnitToolsDoseRateUnit.MicrograyPerHour:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMicrograyPerHour(baseValue);
                case UnitToolsDoseRateUnit.SievertPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToSievertPerSecond(baseValue);
                case UnitToolsDoseRateUnit.MicrosievertPerHour:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMicrosievertPerHour(baseValue);
                case UnitToolsDoseRateUnit.RemPerSecond:
                    return UnitToolsHistoricalDoseRate.GrayPerSecondToRemPerSecond(baseValue);
                case UnitToolsDoseRateUnit.RemPerYear:
                    return UnitToolsHistoricalDoseRate.GrayPerSecondToRemPerYear(baseValue);
                case UnitToolsDoseRateUnit.NanograyPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToNanograyPerSecond(baseValue);
                case UnitToolsDoseRateUnit.PicograyPerSecond:
                    return UnitToolsMetricDoseRate.GrayPerSecondToPicograyPerSecond(baseValue);
                case UnitToolsDoseRateUnit.GrayPerYear:
                    return UnitToolsMetricDoseRate.GrayPerSecondToGrayPerYear(baseValue);
                case UnitToolsDoseRateUnit.SievertPerYear:
                    return UnitToolsMetricDoseRate.GrayPerSecondToSievertPerYear(baseValue);
                case UnitToolsDoseRateUnit.MicrosievertPerYear:
                    return UnitToolsMetricDoseRate.GrayPerSecondToMicrosievertPerYear(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dose rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDoseRateUnit.GrayPerSecond:
                    return "Gy/s";
                case UnitToolsDoseRateUnit.MilligrayPerSecond:
                    return "mGy/s";
                case UnitToolsDoseRateUnit.MicrograyPerSecond:
                    return "µGy/s";
                case UnitToolsDoseRateUnit.GrayPerHour:
                    return "Gy/h";
                case UnitToolsDoseRateUnit.RadPerHour:
                    return "rad/h";
                case UnitToolsDoseRateUnit.MillisievertPerHour:
                    return "mSv/h";
                case UnitToolsDoseRateUnit.GrayPerMinute:
                    return "Gy/min";
                case UnitToolsDoseRateUnit.MilligrayPerHour:
                    return "mGy/h";
                case UnitToolsDoseRateUnit.MicrograyPerHour:
                    return "µGy/h";
                case UnitToolsDoseRateUnit.SievertPerSecond:
                    return "Sv/s";
                case UnitToolsDoseRateUnit.MicrosievertPerHour:
                    return "µSv/h";
                case UnitToolsDoseRateUnit.RemPerSecond:
                    return "rem/s";
                case UnitToolsDoseRateUnit.RemPerYear:
                    return "rem/yr";
                case UnitToolsDoseRateUnit.NanograyPerSecond:
                    return "nGy/s";
                case UnitToolsDoseRateUnit.PicograyPerSecond:
                    return "pGy/s";
                case UnitToolsDoseRateUnit.GrayPerYear:
                    return "Gy/yr";
                case UnitToolsDoseRateUnit.SievertPerYear:
                    return "Sv/yr";
                case UnitToolsDoseRateUnit.MicrosievertPerYear:
                    return "µSv/yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDoseRateUnit.GrayPerSecond:
                    return "Gray Per Second";
                case UnitToolsDoseRateUnit.MilligrayPerSecond:
                    return "Milligray Per Second";
                case UnitToolsDoseRateUnit.MicrograyPerSecond:
                    return "Microgray Per Second";
                case UnitToolsDoseRateUnit.GrayPerHour:
                    return "Gray Per Hour";
                case UnitToolsDoseRateUnit.RadPerHour:
                    return "Rad Per Hour";
                case UnitToolsDoseRateUnit.MillisievertPerHour:
                    return "Millisievert Per Hour";
                case UnitToolsDoseRateUnit.GrayPerMinute:
                    return "Gray Per Minute";
                case UnitToolsDoseRateUnit.MilligrayPerHour:
                    return "Milligray Per Hour";
                case UnitToolsDoseRateUnit.MicrograyPerHour:
                    return "Microgray Per Hour";
                case UnitToolsDoseRateUnit.SievertPerSecond:
                    return "Sievert Per Second";
                case UnitToolsDoseRateUnit.MicrosievertPerHour:
                    return "Microsievert Per Hour";
                case UnitToolsDoseRateUnit.RemPerSecond:
                    return "Rem Per Second";
                case UnitToolsDoseRateUnit.RemPerYear:
                    return "Rem Per Year";
                case UnitToolsDoseRateUnit.NanograyPerSecond:
                    return "Nanogray Per Second";
                case UnitToolsDoseRateUnit.PicograyPerSecond:
                    return "Picogray Per Second";
                case UnitToolsDoseRateUnit.GrayPerYear:
                    return "Gray Per Year";
                case UnitToolsDoseRateUnit.SievertPerYear:
                    return "Sievert Per Year";
                case UnitToolsDoseRateUnit.MicrosievertPerYear:
                    return "Microsievert Per Year";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDoseRateUnit.GrayPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MilligrayPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MicrograyPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.GrayPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.RadPerHour:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsDoseRateUnit.MillisievertPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.GrayPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MilligrayPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MicrograyPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.SievertPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MicrosievertPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.RemPerSecond:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsDoseRateUnit.RemPerYear:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsDoseRateUnit.NanograyPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.PicograyPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.GrayPerYear:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.SievertPerYear:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDoseRateUnit.MicrosievertPerYear:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDoseRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsDoseRateUnit.GrayPerSecond, UnitToolsDoseRateUnit.MilligrayPerSecond, UnitToolsDoseRateUnit.MicrograyPerSecond, UnitToolsDoseRateUnit.GrayPerHour, UnitToolsDoseRateUnit.MillisievertPerHour, UnitToolsDoseRateUnit.GrayPerMinute, UnitToolsDoseRateUnit.MilligrayPerHour, UnitToolsDoseRateUnit.MicrograyPerHour, UnitToolsDoseRateUnit.SievertPerSecond, UnitToolsDoseRateUnit.MicrosievertPerHour, UnitToolsDoseRateUnit.NanograyPerSecond, UnitToolsDoseRateUnit.PicograyPerSecond, UnitToolsDoseRateUnit.GrayPerYear, UnitToolsDoseRateUnit.SievertPerYear, UnitToolsDoseRateUnit.MicrosievertPerYear };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsDoseRateUnit.RadPerHour, UnitToolsDoseRateUnit.RemPerSecond, UnitToolsDoseRateUnit.RemPerYear };
                default:
                    return new[] { UnitToolsDoseRateUnit.GrayPerSecond, UnitToolsDoseRateUnit.MilligrayPerSecond, UnitToolsDoseRateUnit.MicrograyPerSecond, UnitToolsDoseRateUnit.GrayPerHour, UnitToolsDoseRateUnit.RadPerHour, UnitToolsDoseRateUnit.MillisievertPerHour, UnitToolsDoseRateUnit.GrayPerMinute, UnitToolsDoseRateUnit.MilligrayPerHour, UnitToolsDoseRateUnit.MicrograyPerHour, UnitToolsDoseRateUnit.SievertPerSecond, UnitToolsDoseRateUnit.MicrosievertPerHour, UnitToolsDoseRateUnit.RemPerSecond, UnitToolsDoseRateUnit.RemPerYear, UnitToolsDoseRateUnit.NanograyPerSecond, UnitToolsDoseRateUnit.PicograyPerSecond, UnitToolsDoseRateUnit.GrayPerYear, UnitToolsDoseRateUnit.SievertPerYear, UnitToolsDoseRateUnit.MicrosievertPerYear };
            }
        }
    }
}
