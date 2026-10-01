namespace UnitConverter.Time
{
    using UnitConverter.Time.Scientific;
    using UnitConverter.Time.Metric;
    using UnitConverter.Time.Common;
    using UnitConverter.Time.Astronomical;

    public enum UnitConverterTimeUnit
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

    public static class UnitConverterTime
    {
        public static double Convert(double value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            double baseValue = ToSecond(value, from);
            return FromSecond(baseValue, to);
        }

        public static double ToSecond(double value, UnitConverterTimeUnit from)
        {
            switch (from)
            {
                case UnitConverterTimeUnit.Nanosecond:
                    return UnitConverterScientificTime.NanosecondToSecond(value);
                case UnitConverterTimeUnit.Microsecond:
                    return UnitConverterScientificTime.MicrosecondToSecond(value);
                case UnitConverterTimeUnit.Millisecond:
                    return UnitConverterMetricTime.MillisecondToSecond(value);
                case UnitConverterTimeUnit.Second:
                    return UnitConverterMetricTime.SecondToSecond(value);
                case UnitConverterTimeUnit.Minute:
                    return UnitConverterCommonTime.MinuteToSecond(value);
                case UnitConverterTimeUnit.Hour:
                    return UnitConverterCommonTime.HourToSecond(value);
                case UnitConverterTimeUnit.Day:
                    return UnitConverterCommonTime.DayToSecond(value);
                case UnitConverterTimeUnit.Week:
                    return UnitConverterCommonTime.WeekToSecond(value);
                case UnitConverterTimeUnit.Fortnight:
                    return UnitConverterCommonTime.FortnightToSecond(value);
                case UnitConverterTimeUnit.JulianYear:
                    return UnitConverterScientificTime.JulianYearToSecond(value);
                case UnitConverterTimeUnit.CommonYear:
                    return UnitConverterCommonTime.CommonYearToSecond(value);
                case UnitConverterTimeUnit.Femtosecond:
                    return UnitConverterMetricTime.FemtosecondToSecond(value);
                case UnitConverterTimeUnit.Picosecond:
                    return UnitConverterMetricTime.PicosecondToSecond(value);
                case UnitConverterTimeUnit.Decisecond:
                    return UnitConverterMetricTime.DecisecondToSecond(value);
                case UnitConverterTimeUnit.Centisecond:
                    return UnitConverterMetricTime.CentisecondToSecond(value);
                case UnitConverterTimeUnit.Shake:
                    return UnitConverterScientificTime.ShakeToSecond(value);
                case UnitConverterTimeUnit.Svedberg:
                    return UnitConverterScientificTime.SvedbergToSecond(value);
                case UnitConverterTimeUnit.SiderealDay:
                    return UnitConverterAstronomicalTime.SiderealDayToSecond(value);
                case UnitConverterTimeUnit.TropicalYear:
                    return UnitConverterAstronomicalTime.TropicalYearToSecond(value);
                case UnitConverterTimeUnit.SiderealYear:
                    return UnitConverterAstronomicalTime.SiderealYearToSecond(value);
                case UnitConverterTimeUnit.JulianMonth:
                    return UnitConverterCommonTime.JulianMonthToSecond(value);
                case UnitConverterTimeUnit.ThirtyDayMonth:
                    return UnitConverterCommonTime.ThirtyDayMonthToSecond(value);
                case UnitConverterTimeUnit.Decade:
                    return UnitConverterCommonTime.DecadeToSecond(value);
                case UnitConverterTimeUnit.Century:
                    return UnitConverterCommonTime.CenturyToSecond(value);
                case UnitConverterTimeUnit.Millennium:
                    return UnitConverterCommonTime.MillenniumToSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported time unit.");
            }
        }

        public static double FromSecond(double baseValue, UnitConverterTimeUnit to)
        {
            switch (to)
            {
                case UnitConverterTimeUnit.Nanosecond:
                    return UnitConverterScientificTime.SecondToNanosecond(baseValue);
                case UnitConverterTimeUnit.Microsecond:
                    return UnitConverterScientificTime.SecondToMicrosecond(baseValue);
                case UnitConverterTimeUnit.Millisecond:
                    return UnitConverterMetricTime.SecondToMillisecond(baseValue);
                case UnitConverterTimeUnit.Second:
                    return UnitConverterMetricTime.SecondToSecond(baseValue);
                case UnitConverterTimeUnit.Minute:
                    return UnitConverterCommonTime.SecondToMinute(baseValue);
                case UnitConverterTimeUnit.Hour:
                    return UnitConverterCommonTime.SecondToHour(baseValue);
                case UnitConverterTimeUnit.Day:
                    return UnitConverterCommonTime.SecondToDay(baseValue);
                case UnitConverterTimeUnit.Week:
                    return UnitConverterCommonTime.SecondToWeek(baseValue);
                case UnitConverterTimeUnit.Fortnight:
                    return UnitConverterCommonTime.SecondToFortnight(baseValue);
                case UnitConverterTimeUnit.JulianYear:
                    return UnitConverterScientificTime.SecondToJulianYear(baseValue);
                case UnitConverterTimeUnit.CommonYear:
                    return UnitConverterCommonTime.SecondToCommonYear(baseValue);
                case UnitConverterTimeUnit.Femtosecond:
                    return UnitConverterMetricTime.SecondToFemtosecond(baseValue);
                case UnitConverterTimeUnit.Picosecond:
                    return UnitConverterMetricTime.SecondToPicosecond(baseValue);
                case UnitConverterTimeUnit.Decisecond:
                    return UnitConverterMetricTime.SecondToDecisecond(baseValue);
                case UnitConverterTimeUnit.Centisecond:
                    return UnitConverterMetricTime.SecondToCentisecond(baseValue);
                case UnitConverterTimeUnit.Shake:
                    return UnitConverterScientificTime.SecondToShake(baseValue);
                case UnitConverterTimeUnit.Svedberg:
                    return UnitConverterScientificTime.SecondToSvedberg(baseValue);
                case UnitConverterTimeUnit.SiderealDay:
                    return UnitConverterAstronomicalTime.SecondToSiderealDay(baseValue);
                case UnitConverterTimeUnit.TropicalYear:
                    return UnitConverterAstronomicalTime.SecondToTropicalYear(baseValue);
                case UnitConverterTimeUnit.SiderealYear:
                    return UnitConverterAstronomicalTime.SecondToSiderealYear(baseValue);
                case UnitConverterTimeUnit.JulianMonth:
                    return UnitConverterCommonTime.SecondToJulianMonth(baseValue);
                case UnitConverterTimeUnit.ThirtyDayMonth:
                    return UnitConverterCommonTime.SecondToThirtyDayMonth(baseValue);
                case UnitConverterTimeUnit.Decade:
                    return UnitConverterCommonTime.SecondToDecade(baseValue);
                case UnitConverterTimeUnit.Century:
                    return UnitConverterCommonTime.SecondToCentury(baseValue);
                case UnitConverterTimeUnit.Millennium:
                    return UnitConverterCommonTime.SecondToMillennium(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported time unit.");
            }
        }

        public static string GetSymbol(UnitConverterTimeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTimeUnit.Nanosecond:
                    return "ns";
                case UnitConverterTimeUnit.Microsecond:
                    return "µs";
                case UnitConverterTimeUnit.Millisecond:
                    return "ms";
                case UnitConverterTimeUnit.Second:
                    return "s";
                case UnitConverterTimeUnit.Minute:
                    return "min";
                case UnitConverterTimeUnit.Hour:
                    return "h";
                case UnitConverterTimeUnit.Day:
                    return "d";
                case UnitConverterTimeUnit.Week:
                    return "wk";
                case UnitConverterTimeUnit.Fortnight:
                    return "fortnight";
                case UnitConverterTimeUnit.JulianYear:
                    return "a";
                case UnitConverterTimeUnit.CommonYear:
                    return "yr";
                case UnitConverterTimeUnit.Femtosecond:
                    return "fs";
                case UnitConverterTimeUnit.Picosecond:
                    return "ps";
                case UnitConverterTimeUnit.Decisecond:
                    return "ds";
                case UnitConverterTimeUnit.Centisecond:
                    return "cs";
                case UnitConverterTimeUnit.Shake:
                    return "shake";
                case UnitConverterTimeUnit.Svedberg:
                    return "S";
                case UnitConverterTimeUnit.SiderealDay:
                    return "sidereal d";
                case UnitConverterTimeUnit.TropicalYear:
                    return "tropical yr";
                case UnitConverterTimeUnit.SiderealYear:
                    return "sidereal yr";
                case UnitConverterTimeUnit.JulianMonth:
                    return "Julian mo";
                case UnitConverterTimeUnit.ThirtyDayMonth:
                    return "30 d mo";
                case UnitConverterTimeUnit.Decade:
                    return "decade";
                case UnitConverterTimeUnit.Century:
                    return "century";
                case UnitConverterTimeUnit.Millennium:
                    return "millennium";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterTimeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTimeUnit.Nanosecond:
                    return "nanosecond";
                case UnitConverterTimeUnit.Microsecond:
                    return "microsecond";
                case UnitConverterTimeUnit.Millisecond:
                    return "millisecond";
                case UnitConverterTimeUnit.Second:
                    return "second";
                case UnitConverterTimeUnit.Minute:
                    return "minute";
                case UnitConverterTimeUnit.Hour:
                    return "hour";
                case UnitConverterTimeUnit.Day:
                    return "day";
                case UnitConverterTimeUnit.Week:
                    return "week";
                case UnitConverterTimeUnit.Fortnight:
                    return "fortnight";
                case UnitConverterTimeUnit.JulianYear:
                    return "Julian year";
                case UnitConverterTimeUnit.CommonYear:
                    return "common year";
                case UnitConverterTimeUnit.Femtosecond:
                    return "Femtosecond";
                case UnitConverterTimeUnit.Picosecond:
                    return "Picosecond";
                case UnitConverterTimeUnit.Decisecond:
                    return "Decisecond";
                case UnitConverterTimeUnit.Centisecond:
                    return "Centisecond";
                case UnitConverterTimeUnit.Shake:
                    return "Shake";
                case UnitConverterTimeUnit.Svedberg:
                    return "Svedberg";
                case UnitConverterTimeUnit.SiderealDay:
                    return "Sidereal Day";
                case UnitConverterTimeUnit.TropicalYear:
                    return "Tropical Year";
                case UnitConverterTimeUnit.SiderealYear:
                    return "Sidereal Year";
                case UnitConverterTimeUnit.JulianMonth:
                    return "Julian Month";
                case UnitConverterTimeUnit.ThirtyDayMonth:
                    return "Thirty Day Month";
                case UnitConverterTimeUnit.Decade:
                    return "Decade";
                case UnitConverterTimeUnit.Century:
                    return "Century";
                case UnitConverterTimeUnit.Millennium:
                    return "Millennium";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterTimeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTimeUnit.Nanosecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTimeUnit.Microsecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTimeUnit.Millisecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Second:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Minute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Hour:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Day:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Week:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Fortnight:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.JulianYear:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTimeUnit.CommonYear:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Femtosecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Picosecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Decisecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Centisecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTimeUnit.Shake:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTimeUnit.Svedberg:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTimeUnit.SiderealDay:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterTimeUnit.TropicalYear:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterTimeUnit.SiderealYear:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterTimeUnit.JulianMonth:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.ThirtyDayMonth:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Decade:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Century:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterTimeUnit.Millennium:
                    return UnitConverterUnitSystem.Common;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterTimeUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterTimeUnit.Nanosecond, UnitConverterTimeUnit.Microsecond, UnitConverterTimeUnit.JulianYear, UnitConverterTimeUnit.Shake, UnitConverterTimeUnit.Svedberg };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterTimeUnit.Millisecond, UnitConverterTimeUnit.Second, UnitConverterTimeUnit.Femtosecond, UnitConverterTimeUnit.Picosecond, UnitConverterTimeUnit.Decisecond, UnitConverterTimeUnit.Centisecond };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterTimeUnit.Minute, UnitConverterTimeUnit.Hour, UnitConverterTimeUnit.Day, UnitConverterTimeUnit.Week, UnitConverterTimeUnit.Fortnight, UnitConverterTimeUnit.CommonYear, UnitConverterTimeUnit.JulianMonth, UnitConverterTimeUnit.ThirtyDayMonth, UnitConverterTimeUnit.Decade, UnitConverterTimeUnit.Century, UnitConverterTimeUnit.Millennium };
                case UnitConverterUnitSystem.Astronomical:
                    return new[] { UnitConverterTimeUnit.SiderealDay, UnitConverterTimeUnit.TropicalYear, UnitConverterTimeUnit.SiderealYear };
                default:
                    return new[] { UnitConverterTimeUnit.Nanosecond, UnitConverterTimeUnit.Microsecond, UnitConverterTimeUnit.Millisecond, UnitConverterTimeUnit.Second, UnitConverterTimeUnit.Minute, UnitConverterTimeUnit.Hour, UnitConverterTimeUnit.Day, UnitConverterTimeUnit.Week, UnitConverterTimeUnit.Fortnight, UnitConverterTimeUnit.JulianYear, UnitConverterTimeUnit.CommonYear, UnitConverterTimeUnit.Femtosecond, UnitConverterTimeUnit.Picosecond, UnitConverterTimeUnit.Decisecond, UnitConverterTimeUnit.Centisecond, UnitConverterTimeUnit.Shake, UnitConverterTimeUnit.Svedberg, UnitConverterTimeUnit.SiderealDay, UnitConverterTimeUnit.TropicalYear, UnitConverterTimeUnit.SiderealYear, UnitConverterTimeUnit.JulianMonth, UnitConverterTimeUnit.ThirtyDayMonth, UnitConverterTimeUnit.Decade, UnitConverterTimeUnit.Century, UnitConverterTimeUnit.Millennium };
            }
        }
    }
}
