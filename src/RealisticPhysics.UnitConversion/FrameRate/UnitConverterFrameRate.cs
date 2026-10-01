namespace RealisticPhysics.UnitConversion.FrameRate
{
    using RealisticPhysics.UnitConversion.FrameRate.Common;
    using RealisticPhysics.UnitConversion.FrameRate.Metric;

    public enum UnitConverterFrameRateUnit
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

    public static class UnitConverterFrameRate
    {
        public static double Convert(double value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            double baseValue = ToFramePerSecond(value, from);
            return FromFramePerSecond(baseValue, to);
        }

        public static double ToFramePerSecond(double value, UnitConverterFrameRateUnit from)
        {
            switch (from)
            {
                case UnitConverterFrameRateUnit.FramePerSecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.Hertz:
                    return UnitConverterMetricFrameRate.HertzToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerMinute:
                    return UnitConverterCommonFrameRate.FramePerMinuteToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerHour:
                    return UnitConverterCommonFrameRate.FramePerHourToFramePerSecond(value);
                case UnitConverterFrameRateUnit.KiloframePerSecond:
                    return UnitConverterCommonFrameRate.KiloframePerSecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.MegaframePerSecond:
                    return UnitConverterCommonFrameRate.MegaframePerSecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerMillisecond:
                    return UnitConverterCommonFrameRate.FramePerMillisecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerDay:
                    return UnitConverterCommonFrameRate.FramePerDayToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerWeek:
                    return UnitConverterCommonFrameRate.FramePerWeekToFramePerSecond(value);
                case UnitConverterFrameRateUnit.Kilohertz:
                    return UnitConverterMetricFrameRate.KilohertzToFramePerSecond(value);
                case UnitConverterFrameRateUnit.Megahertz:
                    return UnitConverterMetricFrameRate.MegahertzToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerMicrosecond:
                    return UnitConverterCommonFrameRate.FramePerMicrosecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerNanosecond:
                    return UnitConverterCommonFrameRate.FramePerNanosecondToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerMonthJulian:
                    return UnitConverterCommonFrameRate.FramePerMonthJulianToFramePerSecond(value);
                case UnitConverterFrameRateUnit.FramePerYearJulian:
                    return UnitConverterCommonFrameRate.FramePerYearJulianToFramePerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported frame rate unit.");
            }
        }

        public static double FromFramePerSecond(double baseValue, UnitConverterFrameRateUnit to)
        {
            switch (to)
            {
                case UnitConverterFrameRateUnit.FramePerSecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerSecond(baseValue);
                case UnitConverterFrameRateUnit.Hertz:
                    return UnitConverterMetricFrameRate.FramePerSecondToHertz(baseValue);
                case UnitConverterFrameRateUnit.FramePerMinute:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerMinute(baseValue);
                case UnitConverterFrameRateUnit.FramePerHour:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerHour(baseValue);
                case UnitConverterFrameRateUnit.KiloframePerSecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToKiloframePerSecond(baseValue);
                case UnitConverterFrameRateUnit.MegaframePerSecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToMegaframePerSecond(baseValue);
                case UnitConverterFrameRateUnit.FramePerMillisecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerMillisecond(baseValue);
                case UnitConverterFrameRateUnit.FramePerDay:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerDay(baseValue);
                case UnitConverterFrameRateUnit.FramePerWeek:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerWeek(baseValue);
                case UnitConverterFrameRateUnit.Kilohertz:
                    return UnitConverterMetricFrameRate.FramePerSecondToKilohertz(baseValue);
                case UnitConverterFrameRateUnit.Megahertz:
                    return UnitConverterMetricFrameRate.FramePerSecondToMegahertz(baseValue);
                case UnitConverterFrameRateUnit.FramePerMicrosecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerMicrosecond(baseValue);
                case UnitConverterFrameRateUnit.FramePerNanosecond:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerNanosecond(baseValue);
                case UnitConverterFrameRateUnit.FramePerMonthJulian:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerMonthJulian(baseValue);
                case UnitConverterFrameRateUnit.FramePerYearJulian:
                    return UnitConverterCommonFrameRate.FramePerSecondToFramePerYearJulian(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported frame rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrameRateUnit.FramePerSecond:
                    return "fps";
                case UnitConverterFrameRateUnit.Hertz:
                    return "Hz";
                case UnitConverterFrameRateUnit.FramePerMinute:
                    return "frame/min";
                case UnitConverterFrameRateUnit.FramePerHour:
                    return "frame/h";
                case UnitConverterFrameRateUnit.KiloframePerSecond:
                    return "kfps";
                case UnitConverterFrameRateUnit.MegaframePerSecond:
                    return "Mfps";
                case UnitConverterFrameRateUnit.FramePerMillisecond:
                    return "frame/ms";
                case UnitConverterFrameRateUnit.FramePerDay:
                    return "frame/d";
                case UnitConverterFrameRateUnit.FramePerWeek:
                    return "frame/wk";
                case UnitConverterFrameRateUnit.Kilohertz:
                    return "kHz";
                case UnitConverterFrameRateUnit.Megahertz:
                    return "MHz";
                case UnitConverterFrameRateUnit.FramePerMicrosecond:
                    return "frame/µs";
                case UnitConverterFrameRateUnit.FramePerNanosecond:
                    return "frame/ns";
                case UnitConverterFrameRateUnit.FramePerMonthJulian:
                    return "frame/mo";
                case UnitConverterFrameRateUnit.FramePerYearJulian:
                    return "frame/yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrameRateUnit.FramePerSecond:
                    return "Frame Per Second";
                case UnitConverterFrameRateUnit.Hertz:
                    return "Hertz";
                case UnitConverterFrameRateUnit.FramePerMinute:
                    return "Frame Per Minute";
                case UnitConverterFrameRateUnit.FramePerHour:
                    return "Frame Per Hour";
                case UnitConverterFrameRateUnit.KiloframePerSecond:
                    return "Kiloframe Per Second";
                case UnitConverterFrameRateUnit.MegaframePerSecond:
                    return "Megaframe Per Second";
                case UnitConverterFrameRateUnit.FramePerMillisecond:
                    return "Frame Per Millisecond";
                case UnitConverterFrameRateUnit.FramePerDay:
                    return "Frame Per Day";
                case UnitConverterFrameRateUnit.FramePerWeek:
                    return "Frame Per Week";
                case UnitConverterFrameRateUnit.Kilohertz:
                    return "Kilohertz";
                case UnitConverterFrameRateUnit.Megahertz:
                    return "Megahertz";
                case UnitConverterFrameRateUnit.FramePerMicrosecond:
                    return "Frame Per Microsecond";
                case UnitConverterFrameRateUnit.FramePerNanosecond:
                    return "Frame Per Nanosecond";
                case UnitConverterFrameRateUnit.FramePerMonthJulian:
                    return "Frame Per Month Julian";
                case UnitConverterFrameRateUnit.FramePerYearJulian:
                    return "Frame Per Year Julian";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterFrameRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrameRateUnit.FramePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.Hertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrameRateUnit.FramePerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerHour:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.KiloframePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.MegaframePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerMillisecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerDay:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerWeek:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.Kilohertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrameRateUnit.Megahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrameRateUnit.FramePerMicrosecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerNanosecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerMonthJulian:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrameRateUnit.FramePerYearJulian:
                    return UnitConverterUnitSystem.Common;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterFrameRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterFrameRateUnit.FramePerSecond, UnitConverterFrameRateUnit.FramePerMinute, UnitConverterFrameRateUnit.FramePerHour, UnitConverterFrameRateUnit.KiloframePerSecond, UnitConverterFrameRateUnit.MegaframePerSecond, UnitConverterFrameRateUnit.FramePerMillisecond, UnitConverterFrameRateUnit.FramePerDay, UnitConverterFrameRateUnit.FramePerWeek, UnitConverterFrameRateUnit.FramePerMicrosecond, UnitConverterFrameRateUnit.FramePerNanosecond, UnitConverterFrameRateUnit.FramePerMonthJulian, UnitConverterFrameRateUnit.FramePerYearJulian };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterFrameRateUnit.Hertz, UnitConverterFrameRateUnit.Kilohertz, UnitConverterFrameRateUnit.Megahertz };
                default:
                    return new[] { UnitConverterFrameRateUnit.FramePerSecond, UnitConverterFrameRateUnit.Hertz, UnitConverterFrameRateUnit.FramePerMinute, UnitConverterFrameRateUnit.FramePerHour, UnitConverterFrameRateUnit.KiloframePerSecond, UnitConverterFrameRateUnit.MegaframePerSecond, UnitConverterFrameRateUnit.FramePerMillisecond, UnitConverterFrameRateUnit.FramePerDay, UnitConverterFrameRateUnit.FramePerWeek, UnitConverterFrameRateUnit.Kilohertz, UnitConverterFrameRateUnit.Megahertz, UnitConverterFrameRateUnit.FramePerMicrosecond, UnitConverterFrameRateUnit.FramePerNanosecond, UnitConverterFrameRateUnit.FramePerMonthJulian, UnitConverterFrameRateUnit.FramePerYearJulian };
            }
        }
    }
}
