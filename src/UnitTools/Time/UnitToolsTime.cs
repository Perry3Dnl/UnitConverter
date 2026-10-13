namespace UnitTools.Time
{
    using UnitTools.Time.Scientific;
    using UnitTools.Time.Metric;
    using UnitTools.Time.Common;
    using UnitTools.Time.Astronomical;

    public enum UnitToolsTimeUnit
    {
        Nanosecond = 0,
        Microsecond = 1,
        Millisecond = 2,
        Second = 3,
        Minute = 4,
        Hour = 5,
        Day = 6,
        Week = 7,
        Fortnight = 8,
        JulianYear = 9,
        CommonYear = 10,
        Femtosecond = 11,
        Picosecond = 12,
        Decisecond = 13,
        Centisecond = 14,
        Shake = 15,
        Svedberg = 16,
        SiderealDay = 17,
        TropicalYear = 18,
        SiderealYear = 19,
        JulianMonth = 20,
        ThirtyDayMonth = 21,
        Decade = 22,
        Century = 23,
        Millennium = 24,
    }

    public static class UnitToolsTime
    {
        public static double Convert(double value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            double baseValue = ToSecond(value, from);
            return FromSecond(baseValue, to);
        }

        public static double ToSecond(double value, UnitToolsTimeUnit from)
        {
            switch (from)
            {
                case UnitToolsTimeUnit.Nanosecond:
                    return UnitToolsScientificTime.NanosecondToSecond(value);
                case UnitToolsTimeUnit.Microsecond:
                    return UnitToolsScientificTime.MicrosecondToSecond(value);
                case UnitToolsTimeUnit.Millisecond:
                    return UnitToolsMetricTime.MillisecondToSecond(value);
                case UnitToolsTimeUnit.Second:
                    return UnitToolsMetricTime.SecondToSecond(value);
                case UnitToolsTimeUnit.Minute:
                    return UnitToolsCommonTime.MinuteToSecond(value);
                case UnitToolsTimeUnit.Hour:
                    return UnitToolsCommonTime.HourToSecond(value);
                case UnitToolsTimeUnit.Day:
                    return UnitToolsCommonTime.DayToSecond(value);
                case UnitToolsTimeUnit.Week:
                    return UnitToolsCommonTime.WeekToSecond(value);
                case UnitToolsTimeUnit.Fortnight:
                    return UnitToolsCommonTime.FortnightToSecond(value);
                case UnitToolsTimeUnit.JulianYear:
                    return UnitToolsScientificTime.JulianYearToSecond(value);
                case UnitToolsTimeUnit.CommonYear:
                    return UnitToolsCommonTime.CommonYearToSecond(value);
                case UnitToolsTimeUnit.Femtosecond:
                    return UnitToolsMetricTime.FemtosecondToSecond(value);
                case UnitToolsTimeUnit.Picosecond:
                    return UnitToolsMetricTime.PicosecondToSecond(value);
                case UnitToolsTimeUnit.Decisecond:
                    return UnitToolsMetricTime.DecisecondToSecond(value);
                case UnitToolsTimeUnit.Centisecond:
                    return UnitToolsMetricTime.CentisecondToSecond(value);
                case UnitToolsTimeUnit.Shake:
                    return UnitToolsScientificTime.ShakeToSecond(value);
                case UnitToolsTimeUnit.Svedberg:
                    return UnitToolsScientificTime.SvedbergToSecond(value);
                case UnitToolsTimeUnit.SiderealDay:
                    return UnitToolsAstronomicalTime.SiderealDayToSecond(value);
                case UnitToolsTimeUnit.TropicalYear:
                    return UnitToolsAstronomicalTime.TropicalYearToSecond(value);
                case UnitToolsTimeUnit.SiderealYear:
                    return UnitToolsAstronomicalTime.SiderealYearToSecond(value);
                case UnitToolsTimeUnit.JulianMonth:
                    return UnitToolsCommonTime.JulianMonthToSecond(value);
                case UnitToolsTimeUnit.ThirtyDayMonth:
                    return UnitToolsCommonTime.ThirtyDayMonthToSecond(value);
                case UnitToolsTimeUnit.Decade:
                    return UnitToolsCommonTime.DecadeToSecond(value);
                case UnitToolsTimeUnit.Century:
                    return UnitToolsCommonTime.CenturyToSecond(value);
                case UnitToolsTimeUnit.Millennium:
                    return UnitToolsCommonTime.MillenniumToSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported time unit.");
            }
        }

        public static double FromSecond(double baseValue, UnitToolsTimeUnit to)
        {
            switch (to)
            {
                case UnitToolsTimeUnit.Nanosecond:
                    return UnitToolsScientificTime.SecondToNanosecond(baseValue);
                case UnitToolsTimeUnit.Microsecond:
                    return UnitToolsScientificTime.SecondToMicrosecond(baseValue);
                case UnitToolsTimeUnit.Millisecond:
                    return UnitToolsMetricTime.SecondToMillisecond(baseValue);
                case UnitToolsTimeUnit.Second:
                    return UnitToolsMetricTime.SecondToSecond(baseValue);
                case UnitToolsTimeUnit.Minute:
                    return UnitToolsCommonTime.SecondToMinute(baseValue);
                case UnitToolsTimeUnit.Hour:
                    return UnitToolsCommonTime.SecondToHour(baseValue);
                case UnitToolsTimeUnit.Day:
                    return UnitToolsCommonTime.SecondToDay(baseValue);
                case UnitToolsTimeUnit.Week:
                    return UnitToolsCommonTime.SecondToWeek(baseValue);
                case UnitToolsTimeUnit.Fortnight:
                    return UnitToolsCommonTime.SecondToFortnight(baseValue);
                case UnitToolsTimeUnit.JulianYear:
                    return UnitToolsScientificTime.SecondToJulianYear(baseValue);
                case UnitToolsTimeUnit.CommonYear:
                    return UnitToolsCommonTime.SecondToCommonYear(baseValue);
                case UnitToolsTimeUnit.Femtosecond:
                    return UnitToolsMetricTime.SecondToFemtosecond(baseValue);
                case UnitToolsTimeUnit.Picosecond:
                    return UnitToolsMetricTime.SecondToPicosecond(baseValue);
                case UnitToolsTimeUnit.Decisecond:
                    return UnitToolsMetricTime.SecondToDecisecond(baseValue);
                case UnitToolsTimeUnit.Centisecond:
                    return UnitToolsMetricTime.SecondToCentisecond(baseValue);
                case UnitToolsTimeUnit.Shake:
                    return UnitToolsScientificTime.SecondToShake(baseValue);
                case UnitToolsTimeUnit.Svedberg:
                    return UnitToolsScientificTime.SecondToSvedberg(baseValue);
                case UnitToolsTimeUnit.SiderealDay:
                    return UnitToolsAstronomicalTime.SecondToSiderealDay(baseValue);
                case UnitToolsTimeUnit.TropicalYear:
                    return UnitToolsAstronomicalTime.SecondToTropicalYear(baseValue);
                case UnitToolsTimeUnit.SiderealYear:
                    return UnitToolsAstronomicalTime.SecondToSiderealYear(baseValue);
                case UnitToolsTimeUnit.JulianMonth:
                    return UnitToolsCommonTime.SecondToJulianMonth(baseValue);
                case UnitToolsTimeUnit.ThirtyDayMonth:
                    return UnitToolsCommonTime.SecondToThirtyDayMonth(baseValue);
                case UnitToolsTimeUnit.Decade:
                    return UnitToolsCommonTime.SecondToDecade(baseValue);
                case UnitToolsTimeUnit.Century:
                    return UnitToolsCommonTime.SecondToCentury(baseValue);
                case UnitToolsTimeUnit.Millennium:
                    return UnitToolsCommonTime.SecondToMillennium(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported time unit.");
            }
        }

        public static string GetSymbol(UnitToolsTimeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTimeUnit.Nanosecond:
                    return "ns";
                case UnitToolsTimeUnit.Microsecond:
                    return "µs";
                case UnitToolsTimeUnit.Millisecond:
                    return "ms";
                case UnitToolsTimeUnit.Second:
                    return "s";
                case UnitToolsTimeUnit.Minute:
                    return "min";
                case UnitToolsTimeUnit.Hour:
                    return "h";
                case UnitToolsTimeUnit.Day:
                    return "d";
                case UnitToolsTimeUnit.Week:
                    return "wk";
                case UnitToolsTimeUnit.Fortnight:
                    return "fortnight";
                case UnitToolsTimeUnit.JulianYear:
                    return "a";
                case UnitToolsTimeUnit.CommonYear:
                    return "yr";
                case UnitToolsTimeUnit.Femtosecond:
                    return "fs";
                case UnitToolsTimeUnit.Picosecond:
                    return "ps";
                case UnitToolsTimeUnit.Decisecond:
                    return "ds";
                case UnitToolsTimeUnit.Centisecond:
                    return "cs";
                case UnitToolsTimeUnit.Shake:
                    return "shake";
                case UnitToolsTimeUnit.Svedberg:
                    return "S";
                case UnitToolsTimeUnit.SiderealDay:
                    return "sidereal d";
                case UnitToolsTimeUnit.TropicalYear:
                    return "tropical yr";
                case UnitToolsTimeUnit.SiderealYear:
                    return "sidereal yr";
                case UnitToolsTimeUnit.JulianMonth:
                    return "Julian mo";
                case UnitToolsTimeUnit.ThirtyDayMonth:
                    return "30 d mo";
                case UnitToolsTimeUnit.Decade:
                    return "decade";
                case UnitToolsTimeUnit.Century:
                    return "century";
                case UnitToolsTimeUnit.Millennium:
                    return "millennium";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsTimeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTimeUnit.Nanosecond:
                    return "nanosecond";
                case UnitToolsTimeUnit.Microsecond:
                    return "microsecond";
                case UnitToolsTimeUnit.Millisecond:
                    return "millisecond";
                case UnitToolsTimeUnit.Second:
                    return "second";
                case UnitToolsTimeUnit.Minute:
                    return "minute";
                case UnitToolsTimeUnit.Hour:
                    return "hour";
                case UnitToolsTimeUnit.Day:
                    return "day";
                case UnitToolsTimeUnit.Week:
                    return "week";
                case UnitToolsTimeUnit.Fortnight:
                    return "fortnight";
                case UnitToolsTimeUnit.JulianYear:
                    return "Julian year";
                case UnitToolsTimeUnit.CommonYear:
                    return "common year";
                case UnitToolsTimeUnit.Femtosecond:
                    return "Femtosecond";
                case UnitToolsTimeUnit.Picosecond:
                    return "Picosecond";
                case UnitToolsTimeUnit.Decisecond:
                    return "Decisecond";
                case UnitToolsTimeUnit.Centisecond:
                    return "Centisecond";
                case UnitToolsTimeUnit.Shake:
                    return "Shake";
                case UnitToolsTimeUnit.Svedberg:
                    return "Svedberg";
                case UnitToolsTimeUnit.SiderealDay:
                    return "Sidereal Day";
                case UnitToolsTimeUnit.TropicalYear:
                    return "Tropical Year";
                case UnitToolsTimeUnit.SiderealYear:
                    return "Sidereal Year";
                case UnitToolsTimeUnit.JulianMonth:
                    return "Julian Month";
                case UnitToolsTimeUnit.ThirtyDayMonth:
                    return "Thirty Day Month";
                case UnitToolsTimeUnit.Decade:
                    return "Decade";
                case UnitToolsTimeUnit.Century:
                    return "Century";
                case UnitToolsTimeUnit.Millennium:
                    return "Millennium";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsTimeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTimeUnit.Nanosecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTimeUnit.Microsecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTimeUnit.Millisecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Second:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Minute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Hour:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Day:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Week:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Fortnight:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.JulianYear:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTimeUnit.CommonYear:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Femtosecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Picosecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Decisecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Centisecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTimeUnit.Shake:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTimeUnit.Svedberg:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTimeUnit.SiderealDay:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsTimeUnit.TropicalYear:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsTimeUnit.SiderealYear:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsTimeUnit.JulianMonth:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.ThirtyDayMonth:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Decade:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Century:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsTimeUnit.Millennium:
                    return UnitToolsUnitSystem.Common;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsTimeUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsTimeUnit.Nanosecond, UnitToolsTimeUnit.Microsecond, UnitToolsTimeUnit.JulianYear, UnitToolsTimeUnit.Shake, UnitToolsTimeUnit.Svedberg };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsTimeUnit.Millisecond, UnitToolsTimeUnit.Second, UnitToolsTimeUnit.Femtosecond, UnitToolsTimeUnit.Picosecond, UnitToolsTimeUnit.Decisecond, UnitToolsTimeUnit.Centisecond };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsTimeUnit.Minute, UnitToolsTimeUnit.Hour, UnitToolsTimeUnit.Day, UnitToolsTimeUnit.Week, UnitToolsTimeUnit.Fortnight, UnitToolsTimeUnit.CommonYear, UnitToolsTimeUnit.JulianMonth, UnitToolsTimeUnit.ThirtyDayMonth, UnitToolsTimeUnit.Decade, UnitToolsTimeUnit.Century, UnitToolsTimeUnit.Millennium };
                case UnitToolsUnitSystem.Astronomical:
                    return new[] { UnitToolsTimeUnit.SiderealDay, UnitToolsTimeUnit.TropicalYear, UnitToolsTimeUnit.SiderealYear };
                default:
                    return new[] { UnitToolsTimeUnit.Nanosecond, UnitToolsTimeUnit.Microsecond, UnitToolsTimeUnit.Millisecond, UnitToolsTimeUnit.Second, UnitToolsTimeUnit.Minute, UnitToolsTimeUnit.Hour, UnitToolsTimeUnit.Day, UnitToolsTimeUnit.Week, UnitToolsTimeUnit.Fortnight, UnitToolsTimeUnit.JulianYear, UnitToolsTimeUnit.CommonYear, UnitToolsTimeUnit.Femtosecond, UnitToolsTimeUnit.Picosecond, UnitToolsTimeUnit.Decisecond, UnitToolsTimeUnit.Centisecond, UnitToolsTimeUnit.Shake, UnitToolsTimeUnit.Svedberg, UnitToolsTimeUnit.SiderealDay, UnitToolsTimeUnit.TropicalYear, UnitToolsTimeUnit.SiderealYear, UnitToolsTimeUnit.JulianMonth, UnitToolsTimeUnit.ThirtyDayMonth, UnitToolsTimeUnit.Decade, UnitToolsTimeUnit.Century, UnitToolsTimeUnit.Millennium };
            }
        }
    }
}
