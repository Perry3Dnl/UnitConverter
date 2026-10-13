namespace UnitTools.LuminousEnergy
{
    using UnitTools.LuminousEnergy.Metric;
    using UnitTools.LuminousEnergy.Historical;

    public enum UnitToolsLuminousEnergyUnit
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

    public static class UnitToolsLuminousEnergy
    {
        public static double Convert(double value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            double baseValue = ToLumenSecond(value, from);
            return FromLumenSecond(baseValue, to);
        }

        public static double ToLumenSecond(double value, UnitToolsLuminousEnergyUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminousEnergyUnit.LumenSecond:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.LumenMinute:
                    return UnitToolsMetricLuminousEnergy.LumenMinuteToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.LumenHour:
                    return UnitToolsMetricLuminousEnergy.LumenHourToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.Talbot:
                    return UnitToolsHistoricalLuminousEnergy.TalbotToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.Lumerg:
                    return UnitToolsHistoricalLuminousEnergy.LumergToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.LumenDay:
                    return UnitToolsMetricLuminousEnergy.LumenDayToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.KilolumenHour:
                    return UnitToolsMetricLuminousEnergy.KilolumenHourToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.MegalumenSecond:
                    return UnitToolsMetricLuminousEnergy.MegalumenSecondToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.LumenWeek:
                    return UnitToolsMetricLuminousEnergy.LumenWeekToLumenSecond(value);
                case UnitToolsLuminousEnergyUnit.LumenYear:
                    return UnitToolsMetricLuminousEnergy.LumenYearToLumenSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous energy unit.");
            }
        }

        public static double FromLumenSecond(double baseValue, UnitToolsLuminousEnergyUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminousEnergyUnit.LumenSecond:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenSecond(baseValue);
                case UnitToolsLuminousEnergyUnit.LumenMinute:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenMinute(baseValue);
                case UnitToolsLuminousEnergyUnit.LumenHour:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenHour(baseValue);
                case UnitToolsLuminousEnergyUnit.Talbot:
                    return UnitToolsHistoricalLuminousEnergy.LumenSecondToTalbot(baseValue);
                case UnitToolsLuminousEnergyUnit.Lumerg:
                    return UnitToolsHistoricalLuminousEnergy.LumenSecondToLumerg(baseValue);
                case UnitToolsLuminousEnergyUnit.LumenDay:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenDay(baseValue);
                case UnitToolsLuminousEnergyUnit.KilolumenHour:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToKilolumenHour(baseValue);
                case UnitToolsLuminousEnergyUnit.MegalumenSecond:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToMegalumenSecond(baseValue);
                case UnitToolsLuminousEnergyUnit.LumenWeek:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenWeek(baseValue);
                case UnitToolsLuminousEnergyUnit.LumenYear:
                    return UnitToolsMetricLuminousEnergy.LumenSecondToLumenYear(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous energy unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEnergyUnit.LumenSecond:
                    return "lm·s";
                case UnitToolsLuminousEnergyUnit.LumenMinute:
                    return "lm·min";
                case UnitToolsLuminousEnergyUnit.LumenHour:
                    return "lm·h";
                case UnitToolsLuminousEnergyUnit.Talbot:
                    return "talbot";
                case UnitToolsLuminousEnergyUnit.Lumerg:
                    return "lumerg";
                case UnitToolsLuminousEnergyUnit.LumenDay:
                    return "lm·d";
                case UnitToolsLuminousEnergyUnit.KilolumenHour:
                    return "klm·h";
                case UnitToolsLuminousEnergyUnit.MegalumenSecond:
                    return "Mlm·s";
                case UnitToolsLuminousEnergyUnit.LumenWeek:
                    return "lm·wk";
                case UnitToolsLuminousEnergyUnit.LumenYear:
                    return "lm·yr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEnergyUnit.LumenSecond:
                    return "Lumen Second";
                case UnitToolsLuminousEnergyUnit.LumenMinute:
                    return "Lumen Minute";
                case UnitToolsLuminousEnergyUnit.LumenHour:
                    return "Lumen Hour";
                case UnitToolsLuminousEnergyUnit.Talbot:
                    return "Talbot";
                case UnitToolsLuminousEnergyUnit.Lumerg:
                    return "Lumerg";
                case UnitToolsLuminousEnergyUnit.LumenDay:
                    return "Lumen Day";
                case UnitToolsLuminousEnergyUnit.KilolumenHour:
                    return "Kilolumen Hour";
                case UnitToolsLuminousEnergyUnit.MegalumenSecond:
                    return "Megalumen Second";
                case UnitToolsLuminousEnergyUnit.LumenWeek:
                    return "Lumen Week";
                case UnitToolsLuminousEnergyUnit.LumenYear:
                    return "Lumen Year";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminousEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEnergyUnit.LumenSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.LumenMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.LumenHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.Talbot:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousEnergyUnit.Lumerg:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousEnergyUnit.LumenDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.KilolumenHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.MegalumenSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.LumenWeek:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEnergyUnit.LumenYear:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminousEnergyUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminousEnergyUnit.LumenSecond, UnitToolsLuminousEnergyUnit.LumenMinute, UnitToolsLuminousEnergyUnit.LumenHour, UnitToolsLuminousEnergyUnit.LumenDay, UnitToolsLuminousEnergyUnit.KilolumenHour, UnitToolsLuminousEnergyUnit.MegalumenSecond, UnitToolsLuminousEnergyUnit.LumenWeek, UnitToolsLuminousEnergyUnit.LumenYear };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsLuminousEnergyUnit.Talbot, UnitToolsLuminousEnergyUnit.Lumerg };
                default:
                    return new[] { UnitToolsLuminousEnergyUnit.LumenSecond, UnitToolsLuminousEnergyUnit.LumenMinute, UnitToolsLuminousEnergyUnit.LumenHour, UnitToolsLuminousEnergyUnit.Talbot, UnitToolsLuminousEnergyUnit.Lumerg, UnitToolsLuminousEnergyUnit.LumenDay, UnitToolsLuminousEnergyUnit.KilolumenHour, UnitToolsLuminousEnergyUnit.MegalumenSecond, UnitToolsLuminousEnergyUnit.LumenWeek, UnitToolsLuminousEnergyUnit.LumenYear };
            }
        }
    }
}
