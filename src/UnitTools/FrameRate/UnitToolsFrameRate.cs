namespace UnitTools.FrameRate
{
    using UnitTools.FrameRate.Common;
    using UnitTools.FrameRate.Metric;

    public enum UnitToolsFrameRateUnit
    {
        FramePerSecond = 0,
        Hertz = 1,
        FramePerMinute = 2,
        FramePerHour = 3,
        KiloframePerSecond = 4,
        MegaframePerSecond = 5,
        FramePerMillisecond = 6,
        FramePerDay = 7,
        FramePerWeek = 8,
        Kilohertz = 9,
        Megahertz = 10,
        FramePerMicrosecond = 11,
        FramePerNanosecond = 12,
        FramePerMonthJulian = 13,
        FramePerYearJulian = 14,
    }

    public static class UnitToolsFrameRate
    {
        public static double Convert(double value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            double baseValue = ToFramePerSecond(value, from);
            return FromFramePerSecond(baseValue, to);
        }

        public static double ToFramePerSecond(double value, UnitToolsFrameRateUnit from)
        {
            switch (from)
            {
                case UnitToolsFrameRateUnit.FramePerSecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.Hertz:
                    return UnitToolsMetricFrameRate.HertzToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerMinute:
                    return UnitToolsCommonFrameRate.FramePerMinuteToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerHour:
                    return UnitToolsCommonFrameRate.FramePerHourToFramePerSecond(value);
                case UnitToolsFrameRateUnit.KiloframePerSecond:
                    return UnitToolsCommonFrameRate.KiloframePerSecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.MegaframePerSecond:
                    return UnitToolsCommonFrameRate.MegaframePerSecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerMillisecond:
                    return UnitToolsCommonFrameRate.FramePerMillisecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerDay:
                    return UnitToolsCommonFrameRate.FramePerDayToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerWeek:
                    return UnitToolsCommonFrameRate.FramePerWeekToFramePerSecond(value);
                case UnitToolsFrameRateUnit.Kilohertz:
                    return UnitToolsMetricFrameRate.KilohertzToFramePerSecond(value);
                case UnitToolsFrameRateUnit.Megahertz:
                    return UnitToolsMetricFrameRate.MegahertzToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerMicrosecond:
                    return UnitToolsCommonFrameRate.FramePerMicrosecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerNanosecond:
                    return UnitToolsCommonFrameRate.FramePerNanosecondToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerMonthJulian:
                    return UnitToolsCommonFrameRate.FramePerMonthJulianToFramePerSecond(value);
                case UnitToolsFrameRateUnit.FramePerYearJulian:
                    return UnitToolsCommonFrameRate.FramePerYearJulianToFramePerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported frame rate unit.");
            }
        }

        public static double FromFramePerSecond(double baseValue, UnitToolsFrameRateUnit to)
        {
            switch (to)
            {
                case UnitToolsFrameRateUnit.FramePerSecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerSecond(baseValue);
                case UnitToolsFrameRateUnit.Hertz:
                    return UnitToolsMetricFrameRate.FramePerSecondToHertz(baseValue);
                case UnitToolsFrameRateUnit.FramePerMinute:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerMinute(baseValue);
                case UnitToolsFrameRateUnit.FramePerHour:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerHour(baseValue);
                case UnitToolsFrameRateUnit.KiloframePerSecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToKiloframePerSecond(baseValue);
                case UnitToolsFrameRateUnit.MegaframePerSecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToMegaframePerSecond(baseValue);
                case UnitToolsFrameRateUnit.FramePerMillisecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerMillisecond(baseValue);
                case UnitToolsFrameRateUnit.FramePerDay:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerDay(baseValue);
                case UnitToolsFrameRateUnit.FramePerWeek:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerWeek(baseValue);
                case UnitToolsFrameRateUnit.Kilohertz:
                    return UnitToolsMetricFrameRate.FramePerSecondToKilohertz(baseValue);
                case UnitToolsFrameRateUnit.Megahertz:
                    return UnitToolsMetricFrameRate.FramePerSecondToMegahertz(baseValue);
                case UnitToolsFrameRateUnit.FramePerMicrosecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerMicrosecond(baseValue);
                case UnitToolsFrameRateUnit.FramePerNanosecond:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerNanosecond(baseValue);
                case UnitToolsFrameRateUnit.FramePerMonthJulian:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerMonthJulian(baseValue);
                case UnitToolsFrameRateUnit.FramePerYearJulian:
                    return UnitToolsCommonFrameRate.FramePerSecondToFramePerYearJulian(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported frame rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrameRateUnit.FramePerSecond:
                    return "fps";
                case UnitToolsFrameRateUnit.Hertz:
                    return "Hz";
                case UnitToolsFrameRateUnit.FramePerMinute:
                    return "frame/min";
                case UnitToolsFrameRateUnit.FramePerHour:
                    return "frame/h";
                case UnitToolsFrameRateUnit.KiloframePerSecond:
                    return "kfps";
                case UnitToolsFrameRateUnit.MegaframePerSecond:
                    return "Mfps";
                case UnitToolsFrameRateUnit.FramePerMillisecond:
                    return "frame/ms";
                case UnitToolsFrameRateUnit.FramePerDay:
                    return "frame/d";
                case UnitToolsFrameRateUnit.FramePerWeek:
                    return "frame/wk";
                case UnitToolsFrameRateUnit.Kilohertz:
                    return "kHz";
                case UnitToolsFrameRateUnit.Megahertz:
                    return "MHz";
                case UnitToolsFrameRateUnit.FramePerMicrosecond:
                    return "frame/µs";
                case UnitToolsFrameRateUnit.FramePerNanosecond:
                    return "frame/ns";
                case UnitToolsFrameRateUnit.FramePerMonthJulian:
                    return "frame/mo";
                case UnitToolsFrameRateUnit.FramePerYearJulian:
                    return "frame/yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrameRateUnit.FramePerSecond:
                    return "Frame Per Second";
                case UnitToolsFrameRateUnit.Hertz:
                    return "Hertz";
                case UnitToolsFrameRateUnit.FramePerMinute:
                    return "Frame Per Minute";
                case UnitToolsFrameRateUnit.FramePerHour:
                    return "Frame Per Hour";
                case UnitToolsFrameRateUnit.KiloframePerSecond:
                    return "Kiloframe Per Second";
                case UnitToolsFrameRateUnit.MegaframePerSecond:
                    return "Megaframe Per Second";
                case UnitToolsFrameRateUnit.FramePerMillisecond:
                    return "Frame Per Millisecond";
                case UnitToolsFrameRateUnit.FramePerDay:
                    return "Frame Per Day";
                case UnitToolsFrameRateUnit.FramePerWeek:
                    return "Frame Per Week";
                case UnitToolsFrameRateUnit.Kilohertz:
                    return "Kilohertz";
                case UnitToolsFrameRateUnit.Megahertz:
                    return "Megahertz";
                case UnitToolsFrameRateUnit.FramePerMicrosecond:
                    return "Frame Per Microsecond";
                case UnitToolsFrameRateUnit.FramePerNanosecond:
                    return "Frame Per Nanosecond";
                case UnitToolsFrameRateUnit.FramePerMonthJulian:
                    return "Frame Per Month Julian";
                case UnitToolsFrameRateUnit.FramePerYearJulian:
                    return "Frame Per Year Julian";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrameRateUnit.FramePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.Hertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrameRateUnit.FramePerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerHour:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.KiloframePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.MegaframePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerMillisecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerDay:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerWeek:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.Kilohertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrameRateUnit.Megahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrameRateUnit.FramePerMicrosecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerNanosecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerMonthJulian:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrameRateUnit.FramePerYearJulian:
                    return UnitToolsUnitSystem.Common;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsFrameRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsFrameRateUnit.FramePerSecond, UnitToolsFrameRateUnit.FramePerMinute, UnitToolsFrameRateUnit.FramePerHour, UnitToolsFrameRateUnit.KiloframePerSecond, UnitToolsFrameRateUnit.MegaframePerSecond, UnitToolsFrameRateUnit.FramePerMillisecond, UnitToolsFrameRateUnit.FramePerDay, UnitToolsFrameRateUnit.FramePerWeek, UnitToolsFrameRateUnit.FramePerMicrosecond, UnitToolsFrameRateUnit.FramePerNanosecond, UnitToolsFrameRateUnit.FramePerMonthJulian, UnitToolsFrameRateUnit.FramePerYearJulian };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsFrameRateUnit.Hertz, UnitToolsFrameRateUnit.Kilohertz, UnitToolsFrameRateUnit.Megahertz };
                default:
                    return new[] { UnitToolsFrameRateUnit.FramePerSecond, UnitToolsFrameRateUnit.Hertz, UnitToolsFrameRateUnit.FramePerMinute, UnitToolsFrameRateUnit.FramePerHour, UnitToolsFrameRateUnit.KiloframePerSecond, UnitToolsFrameRateUnit.MegaframePerSecond, UnitToolsFrameRateUnit.FramePerMillisecond, UnitToolsFrameRateUnit.FramePerDay, UnitToolsFrameRateUnit.FramePerWeek, UnitToolsFrameRateUnit.Kilohertz, UnitToolsFrameRateUnit.Megahertz, UnitToolsFrameRateUnit.FramePerMicrosecond, UnitToolsFrameRateUnit.FramePerNanosecond, UnitToolsFrameRateUnit.FramePerMonthJulian, UnitToolsFrameRateUnit.FramePerYearJulian };
            }
        }
    }
}
