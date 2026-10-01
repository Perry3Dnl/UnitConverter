namespace RealisticPhysics.UnitConversion.LuminousFlux
{
    using RealisticPhysics.UnitConversion.LuminousFlux.Metric;
    using RealisticPhysics.UnitConversion.LuminousFlux.Common;
    using RealisticPhysics.UnitConversion.LuminousFlux.Historical;

    public enum UnitConverterLuminousFluxUnit
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

    public static class UnitConverterLuminousFlux
    {
        public static double Convert(double value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            double baseValue = ToLumen(value, from);
            return FromLumen(baseValue, to);
        }

        public static double ToLumen(double value, UnitConverterLuminousFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminousFluxUnit.Lumen:
                    return UnitConverterMetricLuminousFlux.LumenToLumen(value);
                case UnitConverterLuminousFluxUnit.Millilumen:
                    return UnitConverterMetricLuminousFlux.MillilumenToLumen(value);
                case UnitConverterLuminousFluxUnit.Kilolumen:
                    return UnitConverterMetricLuminousFlux.KilolumenToLumen(value);
                case UnitConverterLuminousFluxUnit.Megalumen:
                    return UnitConverterMetricLuminousFlux.MegalumenToLumen(value);
                case UnitConverterLuminousFluxUnit.CandelaSteradian:
                    return UnitConverterMetricLuminousFlux.CandelaSteradianToLumen(value);
                case UnitConverterLuminousFluxUnit.Microlumen:
                    return UnitConverterMetricLuminousFlux.MicrolumenToLumen(value);
                case UnitConverterLuminousFluxUnit.Nanolumen:
                    return UnitConverterMetricLuminousFlux.NanolumenToLumen(value);
                case UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitConverterCommonLuminousFlux.LumenPerSteradianSteradianToLumen(value);
                case UnitConverterLuminousFluxUnit.TalbotPerSecond:
                    return UnitConverterHistoricalLuminousFlux.TalbotPerSecondToLumen(value);
                case UnitConverterLuminousFluxUnit.Gigalumen:
                    return UnitConverterMetricLuminousFlux.GigalumenToLumen(value);
                case UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitConverterCommonLuminousFlux.LumenMinutePerSecondAliasToLumen(value);
                case UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitConverterCommonLuminousFlux.LumenHourPerSecondAliasToLumen(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous flux unit.");
            }
        }

        public static double FromLumen(double baseValue, UnitConverterLuminousFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminousFluxUnit.Lumen:
                    return UnitConverterMetricLuminousFlux.LumenToLumen(baseValue);
                case UnitConverterLuminousFluxUnit.Millilumen:
                    return UnitConverterMetricLuminousFlux.LumenToMillilumen(baseValue);
                case UnitConverterLuminousFluxUnit.Kilolumen:
                    return UnitConverterMetricLuminousFlux.LumenToKilolumen(baseValue);
                case UnitConverterLuminousFluxUnit.Megalumen:
                    return UnitConverterMetricLuminousFlux.LumenToMegalumen(baseValue);
                case UnitConverterLuminousFluxUnit.CandelaSteradian:
                    return UnitConverterMetricLuminousFlux.LumenToCandelaSteradian(baseValue);
                case UnitConverterLuminousFluxUnit.Microlumen:
                    return UnitConverterMetricLuminousFlux.LumenToMicrolumen(baseValue);
                case UnitConverterLuminousFluxUnit.Nanolumen:
                    return UnitConverterMetricLuminousFlux.LumenToNanolumen(baseValue);
                case UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitConverterCommonLuminousFlux.LumenToLumenPerSteradianSteradian(baseValue);
                case UnitConverterLuminousFluxUnit.TalbotPerSecond:
                    return UnitConverterHistoricalLuminousFlux.LumenToTalbotPerSecond(baseValue);
                case UnitConverterLuminousFluxUnit.Gigalumen:
                    return UnitConverterMetricLuminousFlux.LumenToGigalumen(baseValue);
                case UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitConverterCommonLuminousFlux.LumenToLumenMinutePerSecondAlias(baseValue);
                case UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitConverterCommonLuminousFlux.LumenToLumenHourPerSecondAlias(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousFluxUnit.Lumen:
                    return "lm";
                case UnitConverterLuminousFluxUnit.Millilumen:
                    return "mlm";
                case UnitConverterLuminousFluxUnit.Kilolumen:
                    return "klm";
                case UnitConverterLuminousFluxUnit.Megalumen:
                    return "Mlm";
                case UnitConverterLuminousFluxUnit.CandelaSteradian:
                    return "cd·sr";
                case UnitConverterLuminousFluxUnit.Microlumen:
                    return "µlm";
                case UnitConverterLuminousFluxUnit.Nanolumen:
                    return "nlm";
                case UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian:
                    return "lm";
                case UnitConverterLuminousFluxUnit.TalbotPerSecond:
                    return "talbot/s";
                case UnitConverterLuminousFluxUnit.Gigalumen:
                    return "Glm";
                case UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return "lm·min/s";
                case UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias:
                    return "lm·h/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousFluxUnit.Lumen:
                    return "Lumen";
                case UnitConverterLuminousFluxUnit.Millilumen:
                    return "Millilumen";
                case UnitConverterLuminousFluxUnit.Kilolumen:
                    return "Kilolumen";
                case UnitConverterLuminousFluxUnit.Megalumen:
                    return "Megalumen";
                case UnitConverterLuminousFluxUnit.CandelaSteradian:
                    return "Candela Steradian";
                case UnitConverterLuminousFluxUnit.Microlumen:
                    return "Microlumen";
                case UnitConverterLuminousFluxUnit.Nanolumen:
                    return "Nanolumen";
                case UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian:
                    return "Lumen Per Steradian Steradian";
                case UnitConverterLuminousFluxUnit.TalbotPerSecond:
                    return "Talbot Per Second";
                case UnitConverterLuminousFluxUnit.Gigalumen:
                    return "Gigalumen";
                case UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return "Lumen Minute Per Second Alias";
                case UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias:
                    return "Lumen Hour Per Second Alias";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminousFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousFluxUnit.Lumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.Millilumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.Kilolumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.Megalumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.CandelaSteradian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.Microlumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.Nanolumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLuminousFluxUnit.TalbotPerSecond:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLuminousFluxUnit.Gigalumen:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias:
                    return UnitConverterUnitSystem.Common;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminousFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminousFluxUnit.Lumen, UnitConverterLuminousFluxUnit.Millilumen, UnitConverterLuminousFluxUnit.Kilolumen, UnitConverterLuminousFluxUnit.Megalumen, UnitConverterLuminousFluxUnit.CandelaSteradian, UnitConverterLuminousFluxUnit.Microlumen, UnitConverterLuminousFluxUnit.Nanolumen, UnitConverterLuminousFluxUnit.Gigalumen };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian, UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias, UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterLuminousFluxUnit.TalbotPerSecond };
                default:
                    return new[] { UnitConverterLuminousFluxUnit.Lumen, UnitConverterLuminousFluxUnit.Millilumen, UnitConverterLuminousFluxUnit.Kilolumen, UnitConverterLuminousFluxUnit.Megalumen, UnitConverterLuminousFluxUnit.CandelaSteradian, UnitConverterLuminousFluxUnit.Microlumen, UnitConverterLuminousFluxUnit.Nanolumen, UnitConverterLuminousFluxUnit.LumenPerSteradianSteradian, UnitConverterLuminousFluxUnit.TalbotPerSecond, UnitConverterLuminousFluxUnit.Gigalumen, UnitConverterLuminousFluxUnit.LumenMinutePerSecondAlias, UnitConverterLuminousFluxUnit.LumenHourPerSecondAlias };
            }
        }
    }
}
