namespace RealisticPhysics.UnitConversion.LuminousEnergy
{
    using RealisticPhysics.UnitConversion.LuminousEnergy.Metric;
    using RealisticPhysics.UnitConversion.LuminousEnergy.Historical;

    public enum UnitConverterLuminousEnergyUnit
    {
        LumenSecond = 0,
        LumenMinute = 1,
        LumenHour = 2,
        Talbot = 3,
        Lumerg = 4,
        LumenDay = 5,
        KilolumenHour = 6,
        MegalumenSecond = 7,
        LumenWeek = 8,
        LumenYear = 9,
    }

    public static class UnitConverterLuminousEnergy
    {
        public static double Convert(double value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            double baseValue = ToLumenSecond(value, from);
            return FromLumenSecond(baseValue, to);
        }

        public static double ToLumenSecond(double value, UnitConverterLuminousEnergyUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminousEnergyUnit.LumenSecond:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.LumenMinute:
                    return UnitConverterMetricLuminousEnergy.LumenMinuteToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.LumenHour:
                    return UnitConverterMetricLuminousEnergy.LumenHourToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.Talbot:
                    return UnitConverterHistoricalLuminousEnergy.TalbotToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.Lumerg:
                    return UnitConverterHistoricalLuminousEnergy.LumergToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.LumenDay:
                    return UnitConverterMetricLuminousEnergy.LumenDayToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.KilolumenHour:
                    return UnitConverterMetricLuminousEnergy.KilolumenHourToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.MegalumenSecond:
                    return UnitConverterMetricLuminousEnergy.MegalumenSecondToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.LumenWeek:
                    return UnitConverterMetricLuminousEnergy.LumenWeekToLumenSecond(value);
                case UnitConverterLuminousEnergyUnit.LumenYear:
                    return UnitConverterMetricLuminousEnergy.LumenYearToLumenSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous energy unit.");
            }
        }

        public static double FromLumenSecond(double baseValue, UnitConverterLuminousEnergyUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminousEnergyUnit.LumenSecond:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenSecond(baseValue);
                case UnitConverterLuminousEnergyUnit.LumenMinute:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenMinute(baseValue);
                case UnitConverterLuminousEnergyUnit.LumenHour:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenHour(baseValue);
                case UnitConverterLuminousEnergyUnit.Talbot:
                    return UnitConverterHistoricalLuminousEnergy.LumenSecondToTalbot(baseValue);
                case UnitConverterLuminousEnergyUnit.Lumerg:
                    return UnitConverterHistoricalLuminousEnergy.LumenSecondToLumerg(baseValue);
                case UnitConverterLuminousEnergyUnit.LumenDay:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenDay(baseValue);
                case UnitConverterLuminousEnergyUnit.KilolumenHour:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToKilolumenHour(baseValue);
                case UnitConverterLuminousEnergyUnit.MegalumenSecond:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToMegalumenSecond(baseValue);
                case UnitConverterLuminousEnergyUnit.LumenWeek:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenWeek(baseValue);
                case UnitConverterLuminousEnergyUnit.LumenYear:
                    return UnitConverterMetricLuminousEnergy.LumenSecondToLumenYear(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous energy unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEnergyUnit.LumenSecond:
                    return "lm·s";
                case UnitConverterLuminousEnergyUnit.LumenMinute:
                    return "lm·min";
                case UnitConverterLuminousEnergyUnit.LumenHour:
                    return "lm·h";
                case UnitConverterLuminousEnergyUnit.Talbot:
                    return "talbot";
                case UnitConverterLuminousEnergyUnit.Lumerg:
                    return "lumerg";
                case UnitConverterLuminousEnergyUnit.LumenDay:
                    return "lm·d";
                case UnitConverterLuminousEnergyUnit.KilolumenHour:
                    return "klm·h";
                case UnitConverterLuminousEnergyUnit.MegalumenSecond:
                    return "Mlm·s";
                case UnitConverterLuminousEnergyUnit.LumenWeek:
                    return "lm·wk";
                case UnitConverterLuminousEnergyUnit.LumenYear:
                    return "lm·yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEnergyUnit.LumenSecond:
                    return "Lumen Second";
                case UnitConverterLuminousEnergyUnit.LumenMinute:
                    return "Lumen Minute";
                case UnitConverterLuminousEnergyUnit.LumenHour:
                    return "Lumen Hour";
                case UnitConverterLuminousEnergyUnit.Talbot:
                    return "Talbot";
                case UnitConverterLuminousEnergyUnit.Lumerg:
                    return "Lumerg";
                case UnitConverterLuminousEnergyUnit.LumenDay:
                    return "Lumen Day";
                case UnitConverterLuminousEnergyUnit.KilolumenHour:
                    return "Kilolumen Hour";
                case UnitConverterLuminousEnergyUnit.MegalumenSecond:
                    return "Megalumen Second";
                case UnitConverterLuminousEnergyUnit.LumenWeek:
                    return "Lumen Week";
                case UnitConverterLuminousEnergyUnit.LumenYear:
                    return "Lumen Year";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEnergyUnit.LumenSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.LumenMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.LumenHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.Talbot:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousEnergyUnit.Lumerg:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousEnergyUnit.LumenDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.KilolumenHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.MegalumenSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.LumenWeek:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEnergyUnit.LumenYear:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminousEnergyUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminousEnergyUnit.LumenSecond, UnitConverterLuminousEnergyUnit.LumenMinute, UnitConverterLuminousEnergyUnit.LumenHour, UnitConverterLuminousEnergyUnit.LumenDay, UnitConverterLuminousEnergyUnit.KilolumenHour, UnitConverterLuminousEnergyUnit.MegalumenSecond, UnitConverterLuminousEnergyUnit.LumenWeek, UnitConverterLuminousEnergyUnit.LumenYear };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterLuminousEnergyUnit.Talbot, UnitConverterLuminousEnergyUnit.Lumerg };
                default:
                    return new[] { UnitConverterLuminousEnergyUnit.LumenSecond, UnitConverterLuminousEnergyUnit.LumenMinute, UnitConverterLuminousEnergyUnit.LumenHour, UnitConverterLuminousEnergyUnit.Talbot, UnitConverterLuminousEnergyUnit.Lumerg, UnitConverterLuminousEnergyUnit.LumenDay, UnitConverterLuminousEnergyUnit.KilolumenHour, UnitConverterLuminousEnergyUnit.MegalumenSecond, UnitConverterLuminousEnergyUnit.LumenWeek, UnitConverterLuminousEnergyUnit.LumenYear };
            }
        }
    }
}
