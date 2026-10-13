namespace UnitTools.MassFlowRate
{
    using UnitTools.MassFlowRate.Metric;
    using UnitTools.MassFlowRate.Imperial;
    using UnitTools.MassFlowRate.ImperialUS;
    using UnitTools.MassFlowRate.ImperialUK;

    public enum UnitToolsMassFlowRateUnit
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

    public static class UnitToolsMassFlowRate
    {
        public static double Convert(double value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            double baseValue = ToKilogramPerSecond(value, from);
            return FromKilogramPerSecond(baseValue, to);
        }

        public static double ToKilogramPerSecond(double value, UnitToolsMassFlowRateUnit from)
        {
            switch (from)
            {
                case UnitToolsMassFlowRateUnit.KilogramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.KilogramPerMinute:
                    return UnitToolsMetricMassFlowRate.KilogramPerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.KilogramPerHour:
                    return UnitToolsMetricMassFlowRate.KilogramPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.GramPerSecond:
                    return UnitToolsMetricMassFlowRate.GramPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.GramPerMinute:
                    return UnitToolsMetricMassFlowRate.GramPerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MetricTonPerHour:
                    return UnitToolsMetricMassFlowRate.MetricTonPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.PoundPerSecond:
                    return UnitToolsImperialMassFlowRate.PoundPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.PoundPerMinute:
                    return UnitToolsImperialMassFlowRate.PoundPerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.PoundPerHour:
                    return UnitToolsImperialMassFlowRate.PoundPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.OuncePerSecond:
                    return UnitToolsImperialMassFlowRate.OuncePerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.KilogramPerDay:
                    return UnitToolsMetricMassFlowRate.KilogramPerDayToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.GramPerHour:
                    return UnitToolsMetricMassFlowRate.GramPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.GramPerDay:
                    return UnitToolsMetricMassFlowRate.GramPerDayToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MilligramPerSecond:
                    return UnitToolsMetricMassFlowRate.MilligramPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MilligramPerMinute:
                    return UnitToolsMetricMassFlowRate.MilligramPerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MilligramPerHour:
                    return UnitToolsMetricMassFlowRate.MilligramPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MetricTonPerSecond:
                    return UnitToolsMetricMassFlowRate.MetricTonPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MetricTonPerDay:
                    return UnitToolsMetricMassFlowRate.MetricTonPerDayToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.PoundPerDay:
                    return UnitToolsImperialMassFlowRate.PoundPerDayToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.OuncePerMinute:
                    return UnitToolsImperialMassFlowRate.OuncePerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.ShortTonPerHour:
                    return UnitToolsImperialUSMassFlowRate.ShortTonPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.LongTonPerHour:
                    return UnitToolsImperialUKMassFlowRate.LongTonPerHourToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.SlugPerSecond:
                    return UnitToolsImperialMassFlowRate.SlugPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.SlugPerMinute:
                    return UnitToolsImperialMassFlowRate.SlugPerMinuteToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerMillisecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.GramPerMillisecond:
                    return UnitToolsMetricMassFlowRate.GramPerMillisecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.MicrogramPerSecond:
                    return UnitToolsMetricMassFlowRate.MicrogramPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.NanogramPerSecond:
                    return UnitToolsMetricMassFlowRate.NanogramPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.ShortTonPerSecond:
                    return UnitToolsImperialUSMassFlowRate.ShortTonPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.ShortTonPerDay:
                    return UnitToolsImperialUSMassFlowRate.ShortTonPerDayToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.LongTonPerSecond:
                    return UnitToolsImperialUKMassFlowRate.LongTonPerSecondToKilogramPerSecond(value);
                case UnitToolsMassFlowRateUnit.LongTonPerDay:
                    return UnitToolsImperialUKMassFlowRate.LongTonPerDayToKilogramPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass flow rate unit.");
            }
        }

        public static double FromKilogramPerSecond(double baseValue, UnitToolsMassFlowRateUnit to)
        {
            switch (to)
            {
                case UnitToolsMassFlowRateUnit.KilogramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.KilogramPerMinute:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.KilogramPerHour:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.GramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToGramPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.GramPerMinute:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToGramPerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.MetricTonPerHour:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMetricTonPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.PoundPerSecond:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToPoundPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.PoundPerMinute:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToPoundPerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.PoundPerHour:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToPoundPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.OuncePerSecond:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToOuncePerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.KilogramPerDay:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerDay(baseValue);
                case UnitToolsMassFlowRateUnit.GramPerHour:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToGramPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.GramPerDay:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToGramPerDay(baseValue);
                case UnitToolsMassFlowRateUnit.MilligramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMilligramPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.MilligramPerMinute:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMilligramPerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.MilligramPerHour:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMilligramPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.MetricTonPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMetricTonPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.MetricTonPerDay:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMetricTonPerDay(baseValue);
                case UnitToolsMassFlowRateUnit.PoundPerDay:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToPoundPerDay(baseValue);
                case UnitToolsMassFlowRateUnit.OuncePerMinute:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToOuncePerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.ShortTonPerHour:
                    return UnitToolsImperialUSMassFlowRate.KilogramPerSecondToShortTonPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.LongTonPerHour:
                    return UnitToolsImperialUKMassFlowRate.KilogramPerSecondToLongTonPerHour(baseValue);
                case UnitToolsMassFlowRateUnit.SlugPerSecond:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToSlugPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.SlugPerMinute:
                    return UnitToolsImperialMassFlowRate.KilogramPerSecondToSlugPerMinute(baseValue);
                case UnitToolsMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToKilogramPerMillisecond(baseValue);
                case UnitToolsMassFlowRateUnit.GramPerMillisecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToGramPerMillisecond(baseValue);
                case UnitToolsMassFlowRateUnit.MicrogramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToMicrogramPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.NanogramPerSecond:
                    return UnitToolsMetricMassFlowRate.KilogramPerSecondToNanogramPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.ShortTonPerSecond:
                    return UnitToolsImperialUSMassFlowRate.KilogramPerSecondToShortTonPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.ShortTonPerDay:
                    return UnitToolsImperialUSMassFlowRate.KilogramPerSecondToShortTonPerDay(baseValue);
                case UnitToolsMassFlowRateUnit.LongTonPerSecond:
                    return UnitToolsImperialUKMassFlowRate.KilogramPerSecondToLongTonPerSecond(baseValue);
                case UnitToolsMassFlowRateUnit.LongTonPerDay:
                    return UnitToolsImperialUKMassFlowRate.KilogramPerSecondToLongTonPerDay(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass flow rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFlowRateUnit.KilogramPerSecond:
                    return "kg/s";
                case UnitToolsMassFlowRateUnit.KilogramPerMinute:
                    return "kg/min";
                case UnitToolsMassFlowRateUnit.KilogramPerHour:
                    return "kg/h";
                case UnitToolsMassFlowRateUnit.GramPerSecond:
                    return "g/s";
                case UnitToolsMassFlowRateUnit.GramPerMinute:
                    return "g/min";
                case UnitToolsMassFlowRateUnit.MetricTonPerHour:
                    return "t/h";
                case UnitToolsMassFlowRateUnit.PoundPerSecond:
                    return "lb/s";
                case UnitToolsMassFlowRateUnit.PoundPerMinute:
                    return "lb/min";
                case UnitToolsMassFlowRateUnit.PoundPerHour:
                    return "lb/h";
                case UnitToolsMassFlowRateUnit.OuncePerSecond:
                    return "oz/s";
                case UnitToolsMassFlowRateUnit.KilogramPerDay:
                    return "kg/d";
                case UnitToolsMassFlowRateUnit.GramPerHour:
                    return "g/h";
                case UnitToolsMassFlowRateUnit.GramPerDay:
                    return "g/d";
                case UnitToolsMassFlowRateUnit.MilligramPerSecond:
                    return "mg/s";
                case UnitToolsMassFlowRateUnit.MilligramPerMinute:
                    return "mg/min";
                case UnitToolsMassFlowRateUnit.MilligramPerHour:
                    return "mg/h";
                case UnitToolsMassFlowRateUnit.MetricTonPerSecond:
                    return "t/s";
                case UnitToolsMassFlowRateUnit.MetricTonPerDay:
                    return "t/d";
                case UnitToolsMassFlowRateUnit.PoundPerDay:
                    return "lb/d";
                case UnitToolsMassFlowRateUnit.OuncePerMinute:
                    return "oz/min";
                case UnitToolsMassFlowRateUnit.ShortTonPerHour:
                    return "ton US/h";
                case UnitToolsMassFlowRateUnit.LongTonPerHour:
                    return "ton UK/h";
                case UnitToolsMassFlowRateUnit.SlugPerSecond:
                    return "slug/s";
                case UnitToolsMassFlowRateUnit.SlugPerMinute:
                    return "slug/min";
                case UnitToolsMassFlowRateUnit.KilogramPerMillisecond:
                    return "kg/ms";
                case UnitToolsMassFlowRateUnit.GramPerMillisecond:
                    return "g/ms";
                case UnitToolsMassFlowRateUnit.MicrogramPerSecond:
                    return "µg/s";
                case UnitToolsMassFlowRateUnit.NanogramPerSecond:
                    return "ng/s";
                case UnitToolsMassFlowRateUnit.ShortTonPerSecond:
                    return "ton US/s";
                case UnitToolsMassFlowRateUnit.ShortTonPerDay:
                    return "ton US/d";
                case UnitToolsMassFlowRateUnit.LongTonPerSecond:
                    return "ton UK/s";
                case UnitToolsMassFlowRateUnit.LongTonPerDay:
                    return "ton UK/d";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFlowRateUnit.KilogramPerSecond:
                    return "kilogram per second";
                case UnitToolsMassFlowRateUnit.KilogramPerMinute:
                    return "kilogram per minute";
                case UnitToolsMassFlowRateUnit.KilogramPerHour:
                    return "kilogram per hour";
                case UnitToolsMassFlowRateUnit.GramPerSecond:
                    return "gram per second";
                case UnitToolsMassFlowRateUnit.GramPerMinute:
                    return "gram per minute";
                case UnitToolsMassFlowRateUnit.MetricTonPerHour:
                    return "metric ton per hour";
                case UnitToolsMassFlowRateUnit.PoundPerSecond:
                    return "pound per second";
                case UnitToolsMassFlowRateUnit.PoundPerMinute:
                    return "pound per minute";
                case UnitToolsMassFlowRateUnit.PoundPerHour:
                    return "pound per hour";
                case UnitToolsMassFlowRateUnit.OuncePerSecond:
                    return "ounce per second";
                case UnitToolsMassFlowRateUnit.KilogramPerDay:
                    return "Kilogram Per Day";
                case UnitToolsMassFlowRateUnit.GramPerHour:
                    return "Gram Per Hour";
                case UnitToolsMassFlowRateUnit.GramPerDay:
                    return "Gram Per Day";
                case UnitToolsMassFlowRateUnit.MilligramPerSecond:
                    return "Milligram Per Second";
                case UnitToolsMassFlowRateUnit.MilligramPerMinute:
                    return "Milligram Per Minute";
                case UnitToolsMassFlowRateUnit.MilligramPerHour:
                    return "Milligram Per Hour";
                case UnitToolsMassFlowRateUnit.MetricTonPerSecond:
                    return "Metric Ton Per Second";
                case UnitToolsMassFlowRateUnit.MetricTonPerDay:
                    return "Metric Ton Per Day";
                case UnitToolsMassFlowRateUnit.PoundPerDay:
                    return "Pound Per Day";
                case UnitToolsMassFlowRateUnit.OuncePerMinute:
                    return "Ounce Per Minute";
                case UnitToolsMassFlowRateUnit.ShortTonPerHour:
                    return "Short Ton Per Hour";
                case UnitToolsMassFlowRateUnit.LongTonPerHour:
                    return "Long Ton Per Hour";
                case UnitToolsMassFlowRateUnit.SlugPerSecond:
                    return "Slug Per Second";
                case UnitToolsMassFlowRateUnit.SlugPerMinute:
                    return "Slug Per Minute";
                case UnitToolsMassFlowRateUnit.KilogramPerMillisecond:
                    return "Kilogram Per Millisecond";
                case UnitToolsMassFlowRateUnit.GramPerMillisecond:
                    return "Gram Per Millisecond";
                case UnitToolsMassFlowRateUnit.MicrogramPerSecond:
                    return "Microgram Per Second";
                case UnitToolsMassFlowRateUnit.NanogramPerSecond:
                    return "Nanogram Per Second";
                case UnitToolsMassFlowRateUnit.ShortTonPerSecond:
                    return "Short Ton Per Second";
                case UnitToolsMassFlowRateUnit.ShortTonPerDay:
                    return "Short Ton Per Day";
                case UnitToolsMassFlowRateUnit.LongTonPerSecond:
                    return "Long Ton Per Second";
                case UnitToolsMassFlowRateUnit.LongTonPerDay:
                    return "Long Ton Per Day";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMassFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFlowRateUnit.KilogramPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.KilogramPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.KilogramPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.GramPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.GramPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MetricTonPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.PoundPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.PoundPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.PoundPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.OuncePerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.KilogramPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.GramPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.GramPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MilligramPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MilligramPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MilligramPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MetricTonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MetricTonPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.PoundPerDay:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.OuncePerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.ShortTonPerHour:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsMassFlowRateUnit.LongTonPerHour:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassFlowRateUnit.SlugPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.SlugPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFlowRateUnit.KilogramPerMillisecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.GramPerMillisecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.MicrogramPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.NanogramPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFlowRateUnit.ShortTonPerSecond:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsMassFlowRateUnit.ShortTonPerDay:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsMassFlowRateUnit.LongTonPerSecond:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassFlowRateUnit.LongTonPerDay:
                    return UnitToolsUnitSystem.ImperialUK;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMassFlowRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMassFlowRateUnit.KilogramPerSecond, UnitToolsMassFlowRateUnit.KilogramPerMinute, UnitToolsMassFlowRateUnit.KilogramPerHour, UnitToolsMassFlowRateUnit.GramPerSecond, UnitToolsMassFlowRateUnit.GramPerMinute, UnitToolsMassFlowRateUnit.MetricTonPerHour, UnitToolsMassFlowRateUnit.KilogramPerDay, UnitToolsMassFlowRateUnit.GramPerHour, UnitToolsMassFlowRateUnit.GramPerDay, UnitToolsMassFlowRateUnit.MilligramPerSecond, UnitToolsMassFlowRateUnit.MilligramPerMinute, UnitToolsMassFlowRateUnit.MilligramPerHour, UnitToolsMassFlowRateUnit.MetricTonPerSecond, UnitToolsMassFlowRateUnit.MetricTonPerDay, UnitToolsMassFlowRateUnit.KilogramPerMillisecond, UnitToolsMassFlowRateUnit.GramPerMillisecond, UnitToolsMassFlowRateUnit.MicrogramPerSecond, UnitToolsMassFlowRateUnit.NanogramPerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMassFlowRateUnit.PoundPerSecond, UnitToolsMassFlowRateUnit.PoundPerMinute, UnitToolsMassFlowRateUnit.PoundPerHour, UnitToolsMassFlowRateUnit.OuncePerSecond, UnitToolsMassFlowRateUnit.PoundPerDay, UnitToolsMassFlowRateUnit.OuncePerMinute, UnitToolsMassFlowRateUnit.SlugPerSecond, UnitToolsMassFlowRateUnit.SlugPerMinute };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsMassFlowRateUnit.ShortTonPerHour, UnitToolsMassFlowRateUnit.ShortTonPerSecond, UnitToolsMassFlowRateUnit.ShortTonPerDay };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsMassFlowRateUnit.LongTonPerHour, UnitToolsMassFlowRateUnit.LongTonPerSecond, UnitToolsMassFlowRateUnit.LongTonPerDay };
                default:
                    return new[] { UnitToolsMassFlowRateUnit.KilogramPerSecond, UnitToolsMassFlowRateUnit.KilogramPerMinute, UnitToolsMassFlowRateUnit.KilogramPerHour, UnitToolsMassFlowRateUnit.GramPerSecond, UnitToolsMassFlowRateUnit.GramPerMinute, UnitToolsMassFlowRateUnit.MetricTonPerHour, UnitToolsMassFlowRateUnit.PoundPerSecond, UnitToolsMassFlowRateUnit.PoundPerMinute, UnitToolsMassFlowRateUnit.PoundPerHour, UnitToolsMassFlowRateUnit.OuncePerSecond, UnitToolsMassFlowRateUnit.KilogramPerDay, UnitToolsMassFlowRateUnit.GramPerHour, UnitToolsMassFlowRateUnit.GramPerDay, UnitToolsMassFlowRateUnit.MilligramPerSecond, UnitToolsMassFlowRateUnit.MilligramPerMinute, UnitToolsMassFlowRateUnit.MilligramPerHour, UnitToolsMassFlowRateUnit.MetricTonPerSecond, UnitToolsMassFlowRateUnit.MetricTonPerDay, UnitToolsMassFlowRateUnit.PoundPerDay, UnitToolsMassFlowRateUnit.OuncePerMinute, UnitToolsMassFlowRateUnit.ShortTonPerHour, UnitToolsMassFlowRateUnit.LongTonPerHour, UnitToolsMassFlowRateUnit.SlugPerSecond, UnitToolsMassFlowRateUnit.SlugPerMinute, UnitToolsMassFlowRateUnit.KilogramPerMillisecond, UnitToolsMassFlowRateUnit.GramPerMillisecond, UnitToolsMassFlowRateUnit.MicrogramPerSecond, UnitToolsMassFlowRateUnit.NanogramPerSecond, UnitToolsMassFlowRateUnit.ShortTonPerSecond, UnitToolsMassFlowRateUnit.ShortTonPerDay, UnitToolsMassFlowRateUnit.LongTonPerSecond, UnitToolsMassFlowRateUnit.LongTonPerDay };
            }
        }
    }
}
