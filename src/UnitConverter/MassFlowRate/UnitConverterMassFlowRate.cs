namespace UnitConverter.MassFlowRate
{
    using UnitConverter.MassFlowRate.Metric;
    using UnitConverter.MassFlowRate.Imperial;
    using UnitConverter.MassFlowRate.ImperialUS;
    using UnitConverter.MassFlowRate.ImperialUK;

    public enum UnitConverterMassFlowRateUnit
    {
        KilogramPerSecond = 0,
        KilogramPerMinute = 1,
        KilogramPerHour = 2,
        GramPerSecond = 3,
        GramPerMinute = 4,
        MetricTonPerHour = 5,
        PoundPerSecond = 6,
        PoundPerMinute = 7,
        PoundPerHour = 8,
        OuncePerSecond = 9,
        KilogramPerDay = 10,
        GramPerHour = 11,
        GramPerDay = 12,
        MilligramPerSecond = 13,
        MilligramPerMinute = 14,
        MilligramPerHour = 15,
        MetricTonPerSecond = 16,
        MetricTonPerDay = 17,
        PoundPerDay = 18,
        OuncePerMinute = 19,
        ShortTonPerHour = 20,
        LongTonPerHour = 21,
        SlugPerSecond = 22,
        SlugPerMinute = 23,
        KilogramPerMillisecond = 24,
        GramPerMillisecond = 25,
        MicrogramPerSecond = 26,
        NanogramPerSecond = 27,
        ShortTonPerSecond = 28,
        ShortTonPerDay = 29,
        LongTonPerSecond = 30,
        LongTonPerDay = 31,
    }

    public static class UnitConverterMassFlowRate
    {
        public static double Convert(double value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            double baseValue = ToKilogramPerSecond(value, from);
            return FromKilogramPerSecond(baseValue, to);
        }

        public static double ToKilogramPerSecond(double value, UnitConverterMassFlowRateUnit from)
        {
            switch (from)
            {
                case UnitConverterMassFlowRateUnit.KilogramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.KilogramPerMinute:
                    return UnitConverterMetricMassFlowRate.KilogramPerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.KilogramPerHour:
                    return UnitConverterMetricMassFlowRate.KilogramPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.GramPerSecond:
                    return UnitConverterMetricMassFlowRate.GramPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.GramPerMinute:
                    return UnitConverterMetricMassFlowRate.GramPerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MetricTonPerHour:
                    return UnitConverterMetricMassFlowRate.MetricTonPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.PoundPerSecond:
                    return UnitConverterImperialMassFlowRate.PoundPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.PoundPerMinute:
                    return UnitConverterImperialMassFlowRate.PoundPerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.PoundPerHour:
                    return UnitConverterImperialMassFlowRate.PoundPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.OuncePerSecond:
                    return UnitConverterImperialMassFlowRate.OuncePerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.KilogramPerDay:
                    return UnitConverterMetricMassFlowRate.KilogramPerDayToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.GramPerHour:
                    return UnitConverterMetricMassFlowRate.GramPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.GramPerDay:
                    return UnitConverterMetricMassFlowRate.GramPerDayToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MilligramPerSecond:
                    return UnitConverterMetricMassFlowRate.MilligramPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MilligramPerMinute:
                    return UnitConverterMetricMassFlowRate.MilligramPerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MilligramPerHour:
                    return UnitConverterMetricMassFlowRate.MilligramPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MetricTonPerSecond:
                    return UnitConverterMetricMassFlowRate.MetricTonPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MetricTonPerDay:
                    return UnitConverterMetricMassFlowRate.MetricTonPerDayToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.PoundPerDay:
                    return UnitConverterImperialMassFlowRate.PoundPerDayToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.OuncePerMinute:
                    return UnitConverterImperialMassFlowRate.OuncePerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.ShortTonPerHour:
                    return UnitConverterImperialUSMassFlowRate.ShortTonPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.LongTonPerHour:
                    return UnitConverterImperialUKMassFlowRate.LongTonPerHourToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.SlugPerSecond:
                    return UnitConverterImperialMassFlowRate.SlugPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.SlugPerMinute:
                    return UnitConverterImperialMassFlowRate.SlugPerMinuteToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerMillisecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.GramPerMillisecond:
                    return UnitConverterMetricMassFlowRate.GramPerMillisecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.MicrogramPerSecond:
                    return UnitConverterMetricMassFlowRate.MicrogramPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.NanogramPerSecond:
                    return UnitConverterMetricMassFlowRate.NanogramPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.ShortTonPerSecond:
                    return UnitConverterImperialUSMassFlowRate.ShortTonPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.ShortTonPerDay:
                    return UnitConverterImperialUSMassFlowRate.ShortTonPerDayToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.LongTonPerSecond:
                    return UnitConverterImperialUKMassFlowRate.LongTonPerSecondToKilogramPerSecond(value);
                case UnitConverterMassFlowRateUnit.LongTonPerDay:
                    return UnitConverterImperialUKMassFlowRate.LongTonPerDayToKilogramPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass flow rate unit.");
            }
        }

        public static double FromKilogramPerSecond(double baseValue, UnitConverterMassFlowRateUnit to)
        {
            switch (to)
            {
                case UnitConverterMassFlowRateUnit.KilogramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.KilogramPerMinute:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.KilogramPerHour:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.GramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToGramPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.GramPerMinute:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToGramPerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.MetricTonPerHour:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMetricTonPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.PoundPerSecond:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToPoundPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.PoundPerMinute:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToPoundPerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.PoundPerHour:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToPoundPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.OuncePerSecond:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToOuncePerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.KilogramPerDay:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerDay(baseValue);
                case UnitConverterMassFlowRateUnit.GramPerHour:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToGramPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.GramPerDay:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToGramPerDay(baseValue);
                case UnitConverterMassFlowRateUnit.MilligramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMilligramPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.MilligramPerMinute:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMilligramPerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.MilligramPerHour:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMilligramPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.MetricTonPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMetricTonPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.MetricTonPerDay:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMetricTonPerDay(baseValue);
                case UnitConverterMassFlowRateUnit.PoundPerDay:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToPoundPerDay(baseValue);
                case UnitConverterMassFlowRateUnit.OuncePerMinute:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToOuncePerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.ShortTonPerHour:
                    return UnitConverterImperialUSMassFlowRate.KilogramPerSecondToShortTonPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.LongTonPerHour:
                    return UnitConverterImperialUKMassFlowRate.KilogramPerSecondToLongTonPerHour(baseValue);
                case UnitConverterMassFlowRateUnit.SlugPerSecond:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToSlugPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.SlugPerMinute:
                    return UnitConverterImperialMassFlowRate.KilogramPerSecondToSlugPerMinute(baseValue);
                case UnitConverterMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToKilogramPerMillisecond(baseValue);
                case UnitConverterMassFlowRateUnit.GramPerMillisecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToGramPerMillisecond(baseValue);
                case UnitConverterMassFlowRateUnit.MicrogramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToMicrogramPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.NanogramPerSecond:
                    return UnitConverterMetricMassFlowRate.KilogramPerSecondToNanogramPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.ShortTonPerSecond:
                    return UnitConverterImperialUSMassFlowRate.KilogramPerSecondToShortTonPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.ShortTonPerDay:
                    return UnitConverterImperialUSMassFlowRate.KilogramPerSecondToShortTonPerDay(baseValue);
                case UnitConverterMassFlowRateUnit.LongTonPerSecond:
                    return UnitConverterImperialUKMassFlowRate.KilogramPerSecondToLongTonPerSecond(baseValue);
                case UnitConverterMassFlowRateUnit.LongTonPerDay:
                    return UnitConverterImperialUKMassFlowRate.KilogramPerSecondToLongTonPerDay(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass flow rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFlowRateUnit.KilogramPerSecond:
                    return "kg/s";
                case UnitConverterMassFlowRateUnit.KilogramPerMinute:
                    return "kg/min";
                case UnitConverterMassFlowRateUnit.KilogramPerHour:
                    return "kg/h";
                case UnitConverterMassFlowRateUnit.GramPerSecond:
                    return "g/s";
                case UnitConverterMassFlowRateUnit.GramPerMinute:
                    return "g/min";
                case UnitConverterMassFlowRateUnit.MetricTonPerHour:
                    return "t/h";
                case UnitConverterMassFlowRateUnit.PoundPerSecond:
                    return "lb/s";
                case UnitConverterMassFlowRateUnit.PoundPerMinute:
                    return "lb/min";
                case UnitConverterMassFlowRateUnit.PoundPerHour:
                    return "lb/h";
                case UnitConverterMassFlowRateUnit.OuncePerSecond:
                    return "oz/s";
                case UnitConverterMassFlowRateUnit.KilogramPerDay:
                    return "kg/d";
                case UnitConverterMassFlowRateUnit.GramPerHour:
                    return "g/h";
                case UnitConverterMassFlowRateUnit.GramPerDay:
                    return "g/d";
                case UnitConverterMassFlowRateUnit.MilligramPerSecond:
                    return "mg/s";
                case UnitConverterMassFlowRateUnit.MilligramPerMinute:
                    return "mg/min";
                case UnitConverterMassFlowRateUnit.MilligramPerHour:
                    return "mg/h";
                case UnitConverterMassFlowRateUnit.MetricTonPerSecond:
                    return "t/s";
                case UnitConverterMassFlowRateUnit.MetricTonPerDay:
                    return "t/d";
                case UnitConverterMassFlowRateUnit.PoundPerDay:
                    return "lb/d";
                case UnitConverterMassFlowRateUnit.OuncePerMinute:
                    return "oz/min";
                case UnitConverterMassFlowRateUnit.ShortTonPerHour:
                    return "ton US/h";
                case UnitConverterMassFlowRateUnit.LongTonPerHour:
                    return "ton UK/h";
                case UnitConverterMassFlowRateUnit.SlugPerSecond:
                    return "slug/s";
                case UnitConverterMassFlowRateUnit.SlugPerMinute:
                    return "slug/min";
                case UnitConverterMassFlowRateUnit.KilogramPerMillisecond:
                    return "kg/ms";
                case UnitConverterMassFlowRateUnit.GramPerMillisecond:
                    return "g/ms";
                case UnitConverterMassFlowRateUnit.MicrogramPerSecond:
                    return "µg/s";
                case UnitConverterMassFlowRateUnit.NanogramPerSecond:
                    return "ng/s";
                case UnitConverterMassFlowRateUnit.ShortTonPerSecond:
                    return "ton US/s";
                case UnitConverterMassFlowRateUnit.ShortTonPerDay:
                    return "ton US/d";
                case UnitConverterMassFlowRateUnit.LongTonPerSecond:
                    return "ton UK/s";
                case UnitConverterMassFlowRateUnit.LongTonPerDay:
                    return "ton UK/d";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFlowRateUnit.KilogramPerSecond:
                    return "kilogram per second";
                case UnitConverterMassFlowRateUnit.KilogramPerMinute:
                    return "kilogram per minute";
                case UnitConverterMassFlowRateUnit.KilogramPerHour:
                    return "kilogram per hour";
                case UnitConverterMassFlowRateUnit.GramPerSecond:
                    return "gram per second";
                case UnitConverterMassFlowRateUnit.GramPerMinute:
                    return "gram per minute";
                case UnitConverterMassFlowRateUnit.MetricTonPerHour:
                    return "metric ton per hour";
                case UnitConverterMassFlowRateUnit.PoundPerSecond:
                    return "pound per second";
                case UnitConverterMassFlowRateUnit.PoundPerMinute:
                    return "pound per minute";
                case UnitConverterMassFlowRateUnit.PoundPerHour:
                    return "pound per hour";
                case UnitConverterMassFlowRateUnit.OuncePerSecond:
                    return "ounce per second";
                case UnitConverterMassFlowRateUnit.KilogramPerDay:
                    return "Kilogram Per Day";
                case UnitConverterMassFlowRateUnit.GramPerHour:
                    return "Gram Per Hour";
                case UnitConverterMassFlowRateUnit.GramPerDay:
                    return "Gram Per Day";
                case UnitConverterMassFlowRateUnit.MilligramPerSecond:
                    return "Milligram Per Second";
                case UnitConverterMassFlowRateUnit.MilligramPerMinute:
                    return "Milligram Per Minute";
                case UnitConverterMassFlowRateUnit.MilligramPerHour:
                    return "Milligram Per Hour";
                case UnitConverterMassFlowRateUnit.MetricTonPerSecond:
                    return "Metric Ton Per Second";
                case UnitConverterMassFlowRateUnit.MetricTonPerDay:
                    return "Metric Ton Per Day";
                case UnitConverterMassFlowRateUnit.PoundPerDay:
                    return "Pound Per Day";
                case UnitConverterMassFlowRateUnit.OuncePerMinute:
                    return "Ounce Per Minute";
                case UnitConverterMassFlowRateUnit.ShortTonPerHour:
                    return "Short Ton Per Hour";
                case UnitConverterMassFlowRateUnit.LongTonPerHour:
                    return "Long Ton Per Hour";
                case UnitConverterMassFlowRateUnit.SlugPerSecond:
                    return "Slug Per Second";
                case UnitConverterMassFlowRateUnit.SlugPerMinute:
                    return "Slug Per Minute";
                case UnitConverterMassFlowRateUnit.KilogramPerMillisecond:
                    return "Kilogram Per Millisecond";
                case UnitConverterMassFlowRateUnit.GramPerMillisecond:
                    return "Gram Per Millisecond";
                case UnitConverterMassFlowRateUnit.MicrogramPerSecond:
                    return "Microgram Per Second";
                case UnitConverterMassFlowRateUnit.NanogramPerSecond:
                    return "Nanogram Per Second";
                case UnitConverterMassFlowRateUnit.ShortTonPerSecond:
                    return "Short Ton Per Second";
                case UnitConverterMassFlowRateUnit.ShortTonPerDay:
                    return "Short Ton Per Day";
                case UnitConverterMassFlowRateUnit.LongTonPerSecond:
                    return "Long Ton Per Second";
                case UnitConverterMassFlowRateUnit.LongTonPerDay:
                    return "Long Ton Per Day";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFlowRateUnit.KilogramPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.KilogramPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.KilogramPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.GramPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.GramPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MetricTonPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.PoundPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.PoundPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.PoundPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.OuncePerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.KilogramPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.GramPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.GramPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MilligramPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MilligramPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MilligramPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MetricTonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MetricTonPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.PoundPerDay:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.OuncePerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.ShortTonPerHour:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterMassFlowRateUnit.LongTonPerHour:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassFlowRateUnit.SlugPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.SlugPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.GramPerMillisecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.MicrogramPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.NanogramPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFlowRateUnit.ShortTonPerSecond:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterMassFlowRateUnit.ShortTonPerDay:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterMassFlowRateUnit.LongTonPerSecond:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassFlowRateUnit.LongTonPerDay:
                    return UnitConverterUnitSystem.ImperialUK;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMassFlowRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMassFlowRateUnit.KilogramPerSecond, UnitConverterMassFlowRateUnit.KilogramPerMinute, UnitConverterMassFlowRateUnit.KilogramPerHour, UnitConverterMassFlowRateUnit.GramPerSecond, UnitConverterMassFlowRateUnit.GramPerMinute, UnitConverterMassFlowRateUnit.MetricTonPerHour, UnitConverterMassFlowRateUnit.KilogramPerDay, UnitConverterMassFlowRateUnit.GramPerHour, UnitConverterMassFlowRateUnit.GramPerDay, UnitConverterMassFlowRateUnit.MilligramPerSecond, UnitConverterMassFlowRateUnit.MilligramPerMinute, UnitConverterMassFlowRateUnit.MilligramPerHour, UnitConverterMassFlowRateUnit.MetricTonPerSecond, UnitConverterMassFlowRateUnit.MetricTonPerDay, UnitConverterMassFlowRateUnit.KilogramPerMillisecond, UnitConverterMassFlowRateUnit.GramPerMillisecond, UnitConverterMassFlowRateUnit.MicrogramPerSecond, UnitConverterMassFlowRateUnit.NanogramPerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMassFlowRateUnit.PoundPerSecond, UnitConverterMassFlowRateUnit.PoundPerMinute, UnitConverterMassFlowRateUnit.PoundPerHour, UnitConverterMassFlowRateUnit.OuncePerSecond, UnitConverterMassFlowRateUnit.PoundPerDay, UnitConverterMassFlowRateUnit.OuncePerMinute, UnitConverterMassFlowRateUnit.SlugPerSecond, UnitConverterMassFlowRateUnit.SlugPerMinute };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterMassFlowRateUnit.ShortTonPerHour, UnitConverterMassFlowRateUnit.ShortTonPerSecond, UnitConverterMassFlowRateUnit.ShortTonPerDay };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterMassFlowRateUnit.LongTonPerHour, UnitConverterMassFlowRateUnit.LongTonPerSecond, UnitConverterMassFlowRateUnit.LongTonPerDay };
                default:
                    return new[] { UnitConverterMassFlowRateUnit.KilogramPerSecond, UnitConverterMassFlowRateUnit.KilogramPerMinute, UnitConverterMassFlowRateUnit.KilogramPerHour, UnitConverterMassFlowRateUnit.GramPerSecond, UnitConverterMassFlowRateUnit.GramPerMinute, UnitConverterMassFlowRateUnit.MetricTonPerHour, UnitConverterMassFlowRateUnit.PoundPerSecond, UnitConverterMassFlowRateUnit.PoundPerMinute, UnitConverterMassFlowRateUnit.PoundPerHour, UnitConverterMassFlowRateUnit.OuncePerSecond, UnitConverterMassFlowRateUnit.KilogramPerDay, UnitConverterMassFlowRateUnit.GramPerHour, UnitConverterMassFlowRateUnit.GramPerDay, UnitConverterMassFlowRateUnit.MilligramPerSecond, UnitConverterMassFlowRateUnit.MilligramPerMinute, UnitConverterMassFlowRateUnit.MilligramPerHour, UnitConverterMassFlowRateUnit.MetricTonPerSecond, UnitConverterMassFlowRateUnit.MetricTonPerDay, UnitConverterMassFlowRateUnit.PoundPerDay, UnitConverterMassFlowRateUnit.OuncePerMinute, UnitConverterMassFlowRateUnit.ShortTonPerHour, UnitConverterMassFlowRateUnit.LongTonPerHour, UnitConverterMassFlowRateUnit.SlugPerSecond, UnitConverterMassFlowRateUnit.SlugPerMinute, UnitConverterMassFlowRateUnit.KilogramPerMillisecond, UnitConverterMassFlowRateUnit.GramPerMillisecond, UnitConverterMassFlowRateUnit.MicrogramPerSecond, UnitConverterMassFlowRateUnit.NanogramPerSecond, UnitConverterMassFlowRateUnit.ShortTonPerSecond, UnitConverterMassFlowRateUnit.ShortTonPerDay, UnitConverterMassFlowRateUnit.LongTonPerSecond, UnitConverterMassFlowRateUnit.LongTonPerDay };
            }
        }
    }
}
