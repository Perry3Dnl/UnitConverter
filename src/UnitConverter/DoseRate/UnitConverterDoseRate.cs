namespace UnitConverter.DoseRate
{
    using UnitConverter.DoseRate.Metric;
    using UnitConverter.DoseRate.Historical;

    public enum UnitConverterDoseRateUnit
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

    public static class UnitConverterDoseRate
    {
        public static double Convert(double value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            double baseValue = ToGrayPerSecond(value, from);
            return FromGrayPerSecond(baseValue, to);
        }

        public static double ToGrayPerSecond(double value, UnitConverterDoseRateUnit from)
        {
            switch (from)
            {
                case UnitConverterDoseRateUnit.GrayPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MilligrayPerSecond:
                    return UnitConverterMetricDoseRate.MilligrayPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MicrograyPerSecond:
                    return UnitConverterMetricDoseRate.MicrograyPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.GrayPerHour:
                    return UnitConverterMetricDoseRate.GrayPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.RadPerHour:
                    return UnitConverterHistoricalDoseRate.RadPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MillisievertPerHour:
                    return UnitConverterMetricDoseRate.MillisievertPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.GrayPerMinute:
                    return UnitConverterMetricDoseRate.GrayPerMinuteToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MilligrayPerHour:
                    return UnitConverterMetricDoseRate.MilligrayPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MicrograyPerHour:
                    return UnitConverterMetricDoseRate.MicrograyPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.SievertPerSecond:
                    return UnitConverterMetricDoseRate.SievertPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MicrosievertPerHour:
                    return UnitConverterMetricDoseRate.MicrosievertPerHourToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.RemPerSecond:
                    return UnitConverterHistoricalDoseRate.RemPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.RemPerYear:
                    return UnitConverterHistoricalDoseRate.RemPerYearToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.NanograyPerSecond:
                    return UnitConverterMetricDoseRate.NanograyPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.PicograyPerSecond:
                    return UnitConverterMetricDoseRate.PicograyPerSecondToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.GrayPerYear:
                    return UnitConverterMetricDoseRate.GrayPerYearToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.SievertPerYear:
                    return UnitConverterMetricDoseRate.SievertPerYearToGrayPerSecond(value);
                case UnitConverterDoseRateUnit.MicrosievertPerYear:
                    return UnitConverterMetricDoseRate.MicrosievertPerYearToGrayPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dose rate unit.");
            }
        }

        public static double FromGrayPerSecond(double baseValue, UnitConverterDoseRateUnit to)
        {
            switch (to)
            {
                case UnitConverterDoseRateUnit.GrayPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToGrayPerSecond(baseValue);
                case UnitConverterDoseRateUnit.MilligrayPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMilligrayPerSecond(baseValue);
                case UnitConverterDoseRateUnit.MicrograyPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMicrograyPerSecond(baseValue);
                case UnitConverterDoseRateUnit.GrayPerHour:
                    return UnitConverterMetricDoseRate.GrayPerSecondToGrayPerHour(baseValue);
                case UnitConverterDoseRateUnit.RadPerHour:
                    return UnitConverterHistoricalDoseRate.GrayPerSecondToRadPerHour(baseValue);
                case UnitConverterDoseRateUnit.MillisievertPerHour:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMillisievertPerHour(baseValue);
                case UnitConverterDoseRateUnit.GrayPerMinute:
                    return UnitConverterMetricDoseRate.GrayPerSecondToGrayPerMinute(baseValue);
                case UnitConverterDoseRateUnit.MilligrayPerHour:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMilligrayPerHour(baseValue);
                case UnitConverterDoseRateUnit.MicrograyPerHour:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMicrograyPerHour(baseValue);
                case UnitConverterDoseRateUnit.SievertPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToSievertPerSecond(baseValue);
                case UnitConverterDoseRateUnit.MicrosievertPerHour:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMicrosievertPerHour(baseValue);
                case UnitConverterDoseRateUnit.RemPerSecond:
                    return UnitConverterHistoricalDoseRate.GrayPerSecondToRemPerSecond(baseValue);
                case UnitConverterDoseRateUnit.RemPerYear:
                    return UnitConverterHistoricalDoseRate.GrayPerSecondToRemPerYear(baseValue);
                case UnitConverterDoseRateUnit.NanograyPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToNanograyPerSecond(baseValue);
                case UnitConverterDoseRateUnit.PicograyPerSecond:
                    return UnitConverterMetricDoseRate.GrayPerSecondToPicograyPerSecond(baseValue);
                case UnitConverterDoseRateUnit.GrayPerYear:
                    return UnitConverterMetricDoseRate.GrayPerSecondToGrayPerYear(baseValue);
                case UnitConverterDoseRateUnit.SievertPerYear:
                    return UnitConverterMetricDoseRate.GrayPerSecondToSievertPerYear(baseValue);
                case UnitConverterDoseRateUnit.MicrosievertPerYear:
                    return UnitConverterMetricDoseRate.GrayPerSecondToMicrosievertPerYear(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dose rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDoseRateUnit.GrayPerSecond:
                    return "Gy/s";
                case UnitConverterDoseRateUnit.MilligrayPerSecond:
                    return "mGy/s";
                case UnitConverterDoseRateUnit.MicrograyPerSecond:
                    return "µGy/s";
                case UnitConverterDoseRateUnit.GrayPerHour:
                    return "Gy/h";
                case UnitConverterDoseRateUnit.RadPerHour:
                    return "rad/h";
                case UnitConverterDoseRateUnit.MillisievertPerHour:
                    return "mSv/h";
                case UnitConverterDoseRateUnit.GrayPerMinute:
                    return "Gy/min";
                case UnitConverterDoseRateUnit.MilligrayPerHour:
                    return "mGy/h";
                case UnitConverterDoseRateUnit.MicrograyPerHour:
                    return "µGy/h";
                case UnitConverterDoseRateUnit.SievertPerSecond:
                    return "Sv/s";
                case UnitConverterDoseRateUnit.MicrosievertPerHour:
                    return "µSv/h";
                case UnitConverterDoseRateUnit.RemPerSecond:
                    return "rem/s";
                case UnitConverterDoseRateUnit.RemPerYear:
                    return "rem/yr";
                case UnitConverterDoseRateUnit.NanograyPerSecond:
                    return "nGy/s";
                case UnitConverterDoseRateUnit.PicograyPerSecond:
                    return "pGy/s";
                case UnitConverterDoseRateUnit.GrayPerYear:
                    return "Gy/yr";
                case UnitConverterDoseRateUnit.SievertPerYear:
                    return "Sv/yr";
                case UnitConverterDoseRateUnit.MicrosievertPerYear:
                    return "µSv/yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDoseRateUnit.GrayPerSecond:
                    return "Gray Per Second";
                case UnitConverterDoseRateUnit.MilligrayPerSecond:
                    return "Milligray Per Second";
                case UnitConverterDoseRateUnit.MicrograyPerSecond:
                    return "Microgray Per Second";
                case UnitConverterDoseRateUnit.GrayPerHour:
                    return "Gray Per Hour";
                case UnitConverterDoseRateUnit.RadPerHour:
                    return "Rad Per Hour";
                case UnitConverterDoseRateUnit.MillisievertPerHour:
                    return "Millisievert Per Hour";
                case UnitConverterDoseRateUnit.GrayPerMinute:
                    return "Gray Per Minute";
                case UnitConverterDoseRateUnit.MilligrayPerHour:
                    return "Milligray Per Hour";
                case UnitConverterDoseRateUnit.MicrograyPerHour:
                    return "Microgray Per Hour";
                case UnitConverterDoseRateUnit.SievertPerSecond:
                    return "Sievert Per Second";
                case UnitConverterDoseRateUnit.MicrosievertPerHour:
                    return "Microsievert Per Hour";
                case UnitConverterDoseRateUnit.RemPerSecond:
                    return "Rem Per Second";
                case UnitConverterDoseRateUnit.RemPerYear:
                    return "Rem Per Year";
                case UnitConverterDoseRateUnit.NanograyPerSecond:
                    return "Nanogray Per Second";
                case UnitConverterDoseRateUnit.PicograyPerSecond:
                    return "Picogray Per Second";
                case UnitConverterDoseRateUnit.GrayPerYear:
                    return "Gray Per Year";
                case UnitConverterDoseRateUnit.SievertPerYear:
                    return "Sievert Per Year";
                case UnitConverterDoseRateUnit.MicrosievertPerYear:
                    return "Microsievert Per Year";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDoseRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDoseRateUnit.GrayPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MilligrayPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MicrograyPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.GrayPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.RadPerHour:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterDoseRateUnit.MillisievertPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.GrayPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MilligrayPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MicrograyPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.SievertPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MicrosievertPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.RemPerSecond:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterDoseRateUnit.RemPerYear:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterDoseRateUnit.NanograyPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.PicograyPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.GrayPerYear:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.SievertPerYear:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDoseRateUnit.MicrosievertPerYear:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDoseRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterDoseRateUnit.GrayPerSecond, UnitConverterDoseRateUnit.MilligrayPerSecond, UnitConverterDoseRateUnit.MicrograyPerSecond, UnitConverterDoseRateUnit.GrayPerHour, UnitConverterDoseRateUnit.MillisievertPerHour, UnitConverterDoseRateUnit.GrayPerMinute, UnitConverterDoseRateUnit.MilligrayPerHour, UnitConverterDoseRateUnit.MicrograyPerHour, UnitConverterDoseRateUnit.SievertPerSecond, UnitConverterDoseRateUnit.MicrosievertPerHour, UnitConverterDoseRateUnit.NanograyPerSecond, UnitConverterDoseRateUnit.PicograyPerSecond, UnitConverterDoseRateUnit.GrayPerYear, UnitConverterDoseRateUnit.SievertPerYear, UnitConverterDoseRateUnit.MicrosievertPerYear };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterDoseRateUnit.RadPerHour, UnitConverterDoseRateUnit.RemPerSecond, UnitConverterDoseRateUnit.RemPerYear };
                default:
                    return new[] { UnitConverterDoseRateUnit.GrayPerSecond, UnitConverterDoseRateUnit.MilligrayPerSecond, UnitConverterDoseRateUnit.MicrograyPerSecond, UnitConverterDoseRateUnit.GrayPerHour, UnitConverterDoseRateUnit.RadPerHour, UnitConverterDoseRateUnit.MillisievertPerHour, UnitConverterDoseRateUnit.GrayPerMinute, UnitConverterDoseRateUnit.MilligrayPerHour, UnitConverterDoseRateUnit.MicrograyPerHour, UnitConverterDoseRateUnit.SievertPerSecond, UnitConverterDoseRateUnit.MicrosievertPerHour, UnitConverterDoseRateUnit.RemPerSecond, UnitConverterDoseRateUnit.RemPerYear, UnitConverterDoseRateUnit.NanograyPerSecond, UnitConverterDoseRateUnit.PicograyPerSecond, UnitConverterDoseRateUnit.GrayPerYear, UnitConverterDoseRateUnit.SievertPerYear, UnitConverterDoseRateUnit.MicrosievertPerYear };
            }
        }
    }
}
