namespace UnitTools.LuminousEfficacy
{
    using UnitTools.LuminousEfficacy.Metric;
    using UnitTools.LuminousEfficacy.Scientific;

    public enum UnitToolsLuminousEfficacyUnit
    {
        LumenPerWatt = 0,
        LumenPerKilowatt = 1,
        KilolumenPerWatt = 2,
        CandelaSteradianPerWatt = 3,
        LumenPerMilliwatt = 4,
        LumenPerMegawatt = 5,
        KilolumenPerKilowatt = 6,
        CandelaSteradianPerKilowatt = 7,
        PhotopicMaximum = 8,
        LumenPerMicrowatt = 9,
        LumenPerNanowatt = 10,
        MegalumenPerWatt = 11,
        PhotopicScotopicRatioApprox = 12,
    }

    public static class UnitToolsLuminousEfficacy
    {
        public static double Convert(double value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            double baseValue = ToLumenPerWatt(value, from);
            return FromLumenPerWatt(baseValue, to);
        }

        public static double ToLumenPerWatt(double value, UnitToolsLuminousEfficacyUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminousEfficacyUnit.LumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerKilowattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.KilolumenPerWattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitToolsMetricLuminousEfficacy.CandelaSteradianPerWattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerMilliwattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerMegawattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.KilolumenPerKilowattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.CandelaSteradianPerKilowattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitToolsScientificLuminousEfficacy.PhotopicMaximumToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerMicrowattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerNanowattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.MegalumenPerWattToLumenPerWatt(value);
                case UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitToolsScientificLuminousEfficacy.PhotopicScotopicRatioApproxToLumenPerWatt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous efficacy unit.");
            }
        }

        public static double FromLumenPerWatt(double baseValue, UnitToolsLuminousEfficacyUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminousEfficacyUnit.LumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerWatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerKilowatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToKilolumenPerWatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToCandelaSteradianPerWatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerMilliwatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerMegawatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToKilolumenPerKilowatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToCandelaSteradianPerKilowatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitToolsScientificLuminousEfficacy.LumenPerWattToPhotopicMaximum(baseValue);
                case UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerMicrowatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToLumenPerNanowatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitToolsMetricLuminousEfficacy.LumenPerWattToMegalumenPerWatt(baseValue);
                case UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitToolsScientificLuminousEfficacy.LumenPerWattToPhotopicScotopicRatioApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous efficacy unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEfficacyUnit.LumenPerWatt:
                    return "lm/W";
                case UnitToolsLuminousEfficacyUnit.LumenPerKilowatt:
                    return "lm/kW";
                case UnitToolsLuminousEfficacyUnit.KilolumenPerWatt:
                    return "klm/W";
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return "cd·sr/W";
                case UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt:
                    return "lm/mW";
                case UnitToolsLuminousEfficacyUnit.LumenPerMegawatt:
                    return "lm/MW";
                case UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return "klm/kW";
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return "cd·sr/kW";
                case UnitToolsLuminousEfficacyUnit.PhotopicMaximum:
                    return "Kcd";
                case UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt:
                    return "lm/µW";
                case UnitToolsLuminousEfficacyUnit.LumenPerNanowatt:
                    return "lm/nW";
                case UnitToolsLuminousEfficacyUnit.MegalumenPerWatt:
                    return "Mlm/W";
                case UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return "scotopic max";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEfficacyUnit.LumenPerWatt:
                    return "Lumen Per Watt";
                case UnitToolsLuminousEfficacyUnit.LumenPerKilowatt:
                    return "Lumen Per Kilowatt";
                case UnitToolsLuminousEfficacyUnit.KilolumenPerWatt:
                    return "Kilolumen Per Watt";
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return "Candela Steradian Per Watt";
                case UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt:
                    return "Lumen Per Milliwatt";
                case UnitToolsLuminousEfficacyUnit.LumenPerMegawatt:
                    return "Lumen Per Megawatt";
                case UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return "Kilolumen Per Kilowatt";
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return "Candela Steradian Per Kilowatt";
                case UnitToolsLuminousEfficacyUnit.PhotopicMaximum:
                    return "Photopic Maximum";
                case UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt:
                    return "Lumen Per Microwatt";
                case UnitToolsLuminousEfficacyUnit.LumenPerNanowatt:
                    return "Lumen Per Nanowatt";
                case UnitToolsLuminousEfficacyUnit.MegalumenPerWatt:
                    return "Megalumen Per Watt";
                case UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return "Photopic Scotopic Ratio Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousEfficacyUnit.LumenPerWatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminousEfficacyUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminousEfficacyUnit.LumenPerWatt, UnitToolsLuminousEfficacyUnit.LumenPerKilowatt, UnitToolsLuminousEfficacyUnit.KilolumenPerWatt, UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt, UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt, UnitToolsLuminousEfficacyUnit.LumenPerMegawatt, UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt, UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt, UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt, UnitToolsLuminousEfficacyUnit.LumenPerNanowatt, UnitToolsLuminousEfficacyUnit.MegalumenPerWatt };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsLuminousEfficacyUnit.PhotopicMaximum, UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox };
                default:
                    return new[] { UnitToolsLuminousEfficacyUnit.LumenPerWatt, UnitToolsLuminousEfficacyUnit.LumenPerKilowatt, UnitToolsLuminousEfficacyUnit.KilolumenPerWatt, UnitToolsLuminousEfficacyUnit.CandelaSteradianPerWatt, UnitToolsLuminousEfficacyUnit.LumenPerMilliwatt, UnitToolsLuminousEfficacyUnit.LumenPerMegawatt, UnitToolsLuminousEfficacyUnit.KilolumenPerKilowatt, UnitToolsLuminousEfficacyUnit.CandelaSteradianPerKilowatt, UnitToolsLuminousEfficacyUnit.PhotopicMaximum, UnitToolsLuminousEfficacyUnit.LumenPerMicrowatt, UnitToolsLuminousEfficacyUnit.LumenPerNanowatt, UnitToolsLuminousEfficacyUnit.MegalumenPerWatt, UnitToolsLuminousEfficacyUnit.PhotopicScotopicRatioApprox };
            }
        }
    }
}
