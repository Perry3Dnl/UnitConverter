namespace UnitConverter.LuminousEfficacy
{
    using UnitConverter.LuminousEfficacy.Metric;
    using UnitConverter.LuminousEfficacy.Scientific;

    public enum UnitConverterLuminousEfficacyUnit
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

    public static class UnitConverterLuminousEfficacy
    {
        public static double Convert(double value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            double baseValue = ToLumenPerWatt(value, from);
            return FromLumenPerWatt(baseValue, to);
        }

        public static double ToLumenPerWatt(double value, UnitConverterLuminousEfficacyUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminousEfficacyUnit.LumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerKilowattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.KilolumenPerWattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitConverterMetricLuminousEfficacy.CandelaSteradianPerWattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerMilliwattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerMegawattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.KilolumenPerKilowattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.CandelaSteradianPerKilowattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitConverterScientificLuminousEfficacy.PhotopicMaximumToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerMicrowattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerNanowattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.MegalumenPerWattToLumenPerWatt(value);
                case UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitConverterScientificLuminousEfficacy.PhotopicScotopicRatioApproxToLumenPerWatt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous efficacy unit.");
            }
        }

        public static double FromLumenPerWatt(double baseValue, UnitConverterLuminousEfficacyUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminousEfficacyUnit.LumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerWatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerKilowatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToKilolumenPerWatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToCandelaSteradianPerWatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerMilliwatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerMegawatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToKilolumenPerKilowatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToCandelaSteradianPerKilowatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitConverterScientificLuminousEfficacy.LumenPerWattToPhotopicMaximum(baseValue);
                case UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerMicrowatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToLumenPerNanowatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitConverterMetricLuminousEfficacy.LumenPerWattToMegalumenPerWatt(baseValue);
                case UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitConverterScientificLuminousEfficacy.LumenPerWattToPhotopicScotopicRatioApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous efficacy unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEfficacyUnit.LumenPerWatt:
                    return "lm/W";
                case UnitConverterLuminousEfficacyUnit.LumenPerKilowatt:
                    return "lm/kW";
                case UnitConverterLuminousEfficacyUnit.KilolumenPerWatt:
                    return "klm/W";
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return "cd·sr/W";
                case UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt:
                    return "lm/mW";
                case UnitConverterLuminousEfficacyUnit.LumenPerMegawatt:
                    return "lm/MW";
                case UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return "klm/kW";
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return "cd·sr/kW";
                case UnitConverterLuminousEfficacyUnit.PhotopicMaximum:
                    return "Kcd";
                case UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt:
                    return "lm/µW";
                case UnitConverterLuminousEfficacyUnit.LumenPerNanowatt:
                    return "lm/nW";
                case UnitConverterLuminousEfficacyUnit.MegalumenPerWatt:
                    return "Mlm/W";
                case UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return "scotopic max";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEfficacyUnit.LumenPerWatt:
                    return "Lumen Per Watt";
                case UnitConverterLuminousEfficacyUnit.LumenPerKilowatt:
                    return "Lumen Per Kilowatt";
                case UnitConverterLuminousEfficacyUnit.KilolumenPerWatt:
                    return "Kilolumen Per Watt";
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return "Candela Steradian Per Watt";
                case UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt:
                    return "Lumen Per Milliwatt";
                case UnitConverterLuminousEfficacyUnit.LumenPerMegawatt:
                    return "Lumen Per Megawatt";
                case UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return "Kilolumen Per Kilowatt";
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return "Candela Steradian Per Kilowatt";
                case UnitConverterLuminousEfficacyUnit.PhotopicMaximum:
                    return "Photopic Maximum";
                case UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt:
                    return "Lumen Per Microwatt";
                case UnitConverterLuminousEfficacyUnit.LumenPerNanowatt:
                    return "Lumen Per Nanowatt";
                case UnitConverterLuminousEfficacyUnit.MegalumenPerWatt:
                    return "Megalumen Per Watt";
                case UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return "Photopic Scotopic Ratio Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminousEfficacyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousEfficacyUnit.LumenPerWatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.LumenPerKilowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.KilolumenPerWatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.LumenPerMegawatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.PhotopicMaximum:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.LumenPerNanowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.MegalumenPerWatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminousEfficacyUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminousEfficacyUnit.LumenPerWatt, UnitConverterLuminousEfficacyUnit.LumenPerKilowatt, UnitConverterLuminousEfficacyUnit.KilolumenPerWatt, UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt, UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt, UnitConverterLuminousEfficacyUnit.LumenPerMegawatt, UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt, UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt, UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt, UnitConverterLuminousEfficacyUnit.LumenPerNanowatt, UnitConverterLuminousEfficacyUnit.MegalumenPerWatt };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterLuminousEfficacyUnit.PhotopicMaximum, UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox };
                default:
                    return new[] { UnitConverterLuminousEfficacyUnit.LumenPerWatt, UnitConverterLuminousEfficacyUnit.LumenPerKilowatt, UnitConverterLuminousEfficacyUnit.KilolumenPerWatt, UnitConverterLuminousEfficacyUnit.CandelaSteradianPerWatt, UnitConverterLuminousEfficacyUnit.LumenPerMilliwatt, UnitConverterLuminousEfficacyUnit.LumenPerMegawatt, UnitConverterLuminousEfficacyUnit.KilolumenPerKilowatt, UnitConverterLuminousEfficacyUnit.CandelaSteradianPerKilowatt, UnitConverterLuminousEfficacyUnit.PhotopicMaximum, UnitConverterLuminousEfficacyUnit.LumenPerMicrowatt, UnitConverterLuminousEfficacyUnit.LumenPerNanowatt, UnitConverterLuminousEfficacyUnit.MegalumenPerWatt, UnitConverterLuminousEfficacyUnit.PhotopicScotopicRatioApprox };
            }
        }
    }
}
