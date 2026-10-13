namespace UnitTools.LuminousFlux
{
    using UnitTools.LuminousFlux.Metric;
    using UnitTools.LuminousFlux.Common;
    using UnitTools.LuminousFlux.Historical;

    public enum UnitToolsLuminousFluxUnit
    {
        Lumen = 0,
        Millilumen = 1,
        Kilolumen = 2,
        Megalumen = 3,
        CandelaSteradian = 4,
        Microlumen = 5,
        Nanolumen = 6,
        LumenPerSteradianSteradian = 7,
        TalbotPerSecond = 8,
        Gigalumen = 9,
        LumenMinutePerSecondAlias = 10,
        LumenHourPerSecondAlias = 11,
    }

    public static class UnitToolsLuminousFlux
    {
        public static double Convert(double value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            double baseValue = ToLumen(value, from);
            return FromLumen(baseValue, to);
        }

        public static double ToLumen(double value, UnitToolsLuminousFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminousFluxUnit.Lumen:
                    return UnitToolsMetricLuminousFlux.LumenToLumen(value);
                case UnitToolsLuminousFluxUnit.Millilumen:
                    return UnitToolsMetricLuminousFlux.MillilumenToLumen(value);
                case UnitToolsLuminousFluxUnit.Kilolumen:
                    return UnitToolsMetricLuminousFlux.KilolumenToLumen(value);
                case UnitToolsLuminousFluxUnit.Megalumen:
                    return UnitToolsMetricLuminousFlux.MegalumenToLumen(value);
                case UnitToolsLuminousFluxUnit.CandelaSteradian:
                    return UnitToolsMetricLuminousFlux.CandelaSteradianToLumen(value);
                case UnitToolsLuminousFluxUnit.Microlumen:
                    return UnitToolsMetricLuminousFlux.MicrolumenToLumen(value);
                case UnitToolsLuminousFluxUnit.Nanolumen:
                    return UnitToolsMetricLuminousFlux.NanolumenToLumen(value);
                case UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitToolsCommonLuminousFlux.LumenPerSteradianSteradianToLumen(value);
                case UnitToolsLuminousFluxUnit.TalbotPerSecond:
                    return UnitToolsHistoricalLuminousFlux.TalbotPerSecondToLumen(value);
                case UnitToolsLuminousFluxUnit.Gigalumen:
                    return UnitToolsMetricLuminousFlux.GigalumenToLumen(value);
                case UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitToolsCommonLuminousFlux.LumenMinutePerSecondAliasToLumen(value);
                case UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitToolsCommonLuminousFlux.LumenHourPerSecondAliasToLumen(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous flux unit.");
            }
        }

        public static double FromLumen(double baseValue, UnitToolsLuminousFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminousFluxUnit.Lumen:
                    return UnitToolsMetricLuminousFlux.LumenToLumen(baseValue);
                case UnitToolsLuminousFluxUnit.Millilumen:
                    return UnitToolsMetricLuminousFlux.LumenToMillilumen(baseValue);
                case UnitToolsLuminousFluxUnit.Kilolumen:
                    return UnitToolsMetricLuminousFlux.LumenToKilolumen(baseValue);
                case UnitToolsLuminousFluxUnit.Megalumen:
                    return UnitToolsMetricLuminousFlux.LumenToMegalumen(baseValue);
                case UnitToolsLuminousFluxUnit.CandelaSteradian:
                    return UnitToolsMetricLuminousFlux.LumenToCandelaSteradian(baseValue);
                case UnitToolsLuminousFluxUnit.Microlumen:
                    return UnitToolsMetricLuminousFlux.LumenToMicrolumen(baseValue);
                case UnitToolsLuminousFluxUnit.Nanolumen:
                    return UnitToolsMetricLuminousFlux.LumenToNanolumen(baseValue);
                case UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitToolsCommonLuminousFlux.LumenToLumenPerSteradianSteradian(baseValue);
                case UnitToolsLuminousFluxUnit.TalbotPerSecond:
                    return UnitToolsHistoricalLuminousFlux.LumenToTalbotPerSecond(baseValue);
                case UnitToolsLuminousFluxUnit.Gigalumen:
                    return UnitToolsMetricLuminousFlux.LumenToGigalumen(baseValue);
                case UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitToolsCommonLuminousFlux.LumenToLumenMinutePerSecondAlias(baseValue);
                case UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitToolsCommonLuminousFlux.LumenToLumenHourPerSecondAlias(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousFluxUnit.Lumen:
                    return "lm";
                case UnitToolsLuminousFluxUnit.Millilumen:
                    return "mlm";
                case UnitToolsLuminousFluxUnit.Kilolumen:
                    return "klm";
                case UnitToolsLuminousFluxUnit.Megalumen:
                    return "Mlm";
                case UnitToolsLuminousFluxUnit.CandelaSteradian:
                    return "cd·sr";
                case UnitToolsLuminousFluxUnit.Microlumen:
                    return "µlm";
                case UnitToolsLuminousFluxUnit.Nanolumen:
                    return "nlm";
                case UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian:
                    return "lm";
                case UnitToolsLuminousFluxUnit.TalbotPerSecond:
                    return "talbot/s";
                case UnitToolsLuminousFluxUnit.Gigalumen:
                    return "Glm";
                case UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return "lm·min/s";
                case UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias:
                    return "lm·h/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousFluxUnit.Lumen:
                    return "Lumen";
                case UnitToolsLuminousFluxUnit.Millilumen:
                    return "Millilumen";
                case UnitToolsLuminousFluxUnit.Kilolumen:
                    return "Kilolumen";
                case UnitToolsLuminousFluxUnit.Megalumen:
                    return "Megalumen";
                case UnitToolsLuminousFluxUnit.CandelaSteradian:
                    return "Candela Steradian";
                case UnitToolsLuminousFluxUnit.Microlumen:
                    return "Microlumen";
                case UnitToolsLuminousFluxUnit.Nanolumen:
                    return "Nanolumen";
                case UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian:
                    return "Lumen Per Steradian Steradian";
                case UnitToolsLuminousFluxUnit.TalbotPerSecond:
                    return "Talbot Per Second";
                case UnitToolsLuminousFluxUnit.Gigalumen:
                    return "Gigalumen";
                case UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return "Lumen Minute Per Second Alias";
                case UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias:
                    return "Lumen Hour Per Second Alias";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousFluxUnit.Lumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.Millilumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.Kilolumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.Megalumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.CandelaSteradian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.Microlumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.Nanolumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLuminousFluxUnit.TalbotPerSecond:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLuminousFluxUnit.Gigalumen:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitToolsUnitSystem.Common;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminousFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminousFluxUnit.Lumen, UnitToolsLuminousFluxUnit.Millilumen, UnitToolsLuminousFluxUnit.Kilolumen, UnitToolsLuminousFluxUnit.Megalumen, UnitToolsLuminousFluxUnit.CandelaSteradian, UnitToolsLuminousFluxUnit.Microlumen, UnitToolsLuminousFluxUnit.Nanolumen, UnitToolsLuminousFluxUnit.Gigalumen };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian, UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias, UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsLuminousFluxUnit.TalbotPerSecond };
                default:
                    return new[] { UnitToolsLuminousFluxUnit.Lumen, UnitToolsLuminousFluxUnit.Millilumen, UnitToolsLuminousFluxUnit.Kilolumen, UnitToolsLuminousFluxUnit.Megalumen, UnitToolsLuminousFluxUnit.CandelaSteradian, UnitToolsLuminousFluxUnit.Microlumen, UnitToolsLuminousFluxUnit.Nanolumen, UnitToolsLuminousFluxUnit.LumenPerSteradianSteradian, UnitToolsLuminousFluxUnit.TalbotPerSecond, UnitToolsLuminousFluxUnit.Gigalumen, UnitToolsLuminousFluxUnit.LumenMinutePerSecondAlias, UnitToolsLuminousFluxUnit.LumenHourPerSecondAlias };
            }
        }
    }
}
