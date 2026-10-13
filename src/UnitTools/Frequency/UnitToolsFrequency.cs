namespace UnitTools.Frequency
{
    using UnitTools.Frequency.Metric;
    using UnitTools.Frequency.Engineering;
    using UnitTools.Frequency.Common;
    using UnitTools.Frequency.Scientific;

    public enum UnitToolsFrequencyUnit
    {
        Millihertz = 0,
        Hertz = 1,
        Kilohertz = 2,
        Megahertz = 3,
        Gigahertz = 4,
        Terahertz = 5,
        RevolutionsPerMinute = 6,
        BeatsPerMinute = 7,
        Picohertz = 8,
        Nanohertz = 9,
        Microhertz = 10,
        Petahertz = 11,
        Exahertz = 12,
        FramesPerSecond = 13,
        CyclesPerMinute = 14,
        RadianPerSecondAsFrequency = 15,
    }

    public static class UnitToolsFrequency
    {
        public static double Convert(double value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            double baseValue = ToHertz(value, from);
            return FromHertz(baseValue, to);
        }

        public static double ToHertz(double value, UnitToolsFrequencyUnit from)
        {
            switch (from)
            {
                case UnitToolsFrequencyUnit.Millihertz:
                    return UnitToolsMetricFrequency.MillihertzToHertz(value);
                case UnitToolsFrequencyUnit.Hertz:
                    return UnitToolsMetricFrequency.HertzToHertz(value);
                case UnitToolsFrequencyUnit.Kilohertz:
                    return UnitToolsMetricFrequency.KilohertzToHertz(value);
                case UnitToolsFrequencyUnit.Megahertz:
                    return UnitToolsMetricFrequency.MegahertzToHertz(value);
                case UnitToolsFrequencyUnit.Gigahertz:
                    return UnitToolsMetricFrequency.GigahertzToHertz(value);
                case UnitToolsFrequencyUnit.Terahertz:
                    return UnitToolsMetricFrequency.TerahertzToHertz(value);
                case UnitToolsFrequencyUnit.RevolutionsPerMinute:
                    return UnitToolsEngineeringFrequency.RevolutionsPerMinuteToHertz(value);
                case UnitToolsFrequencyUnit.BeatsPerMinute:
                    return UnitToolsCommonFrequency.BeatsPerMinuteToHertz(value);
                case UnitToolsFrequencyUnit.Picohertz:
                    return UnitToolsMetricFrequency.PicohertzToHertz(value);
                case UnitToolsFrequencyUnit.Nanohertz:
                    return UnitToolsMetricFrequency.NanohertzToHertz(value);
                case UnitToolsFrequencyUnit.Microhertz:
                    return UnitToolsMetricFrequency.MicrohertzToHertz(value);
                case UnitToolsFrequencyUnit.Petahertz:
                    return UnitToolsMetricFrequency.PetahertzToHertz(value);
                case UnitToolsFrequencyUnit.Exahertz:
                    return UnitToolsMetricFrequency.ExahertzToHertz(value);
                case UnitToolsFrequencyUnit.FramesPerSecond:
                    return UnitToolsCommonFrequency.FramesPerSecondToHertz(value);
                case UnitToolsFrequencyUnit.CyclesPerMinute:
                    return UnitToolsCommonFrequency.CyclesPerMinuteToHertz(value);
                case UnitToolsFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitToolsScientificFrequency.RadianPerSecondAsFrequencyToHertz(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported frequency unit.");
            }
        }

        public static double FromHertz(double baseValue, UnitToolsFrequencyUnit to)
        {
            switch (to)
            {
                case UnitToolsFrequencyUnit.Millihertz:
                    return UnitToolsMetricFrequency.HertzToMillihertz(baseValue);
                case UnitToolsFrequencyUnit.Hertz:
                    return UnitToolsMetricFrequency.HertzToHertz(baseValue);
                case UnitToolsFrequencyUnit.Kilohertz:
                    return UnitToolsMetricFrequency.HertzToKilohertz(baseValue);
                case UnitToolsFrequencyUnit.Megahertz:
                    return UnitToolsMetricFrequency.HertzToMegahertz(baseValue);
                case UnitToolsFrequencyUnit.Gigahertz:
                    return UnitToolsMetricFrequency.HertzToGigahertz(baseValue);
                case UnitToolsFrequencyUnit.Terahertz:
                    return UnitToolsMetricFrequency.HertzToTerahertz(baseValue);
                case UnitToolsFrequencyUnit.RevolutionsPerMinute:
                    return UnitToolsEngineeringFrequency.HertzToRevolutionsPerMinute(baseValue);
                case UnitToolsFrequencyUnit.BeatsPerMinute:
                    return UnitToolsCommonFrequency.HertzToBeatsPerMinute(baseValue);
                case UnitToolsFrequencyUnit.Picohertz:
                    return UnitToolsMetricFrequency.HertzToPicohertz(baseValue);
                case UnitToolsFrequencyUnit.Nanohertz:
                    return UnitToolsMetricFrequency.HertzToNanohertz(baseValue);
                case UnitToolsFrequencyUnit.Microhertz:
                    return UnitToolsMetricFrequency.HertzToMicrohertz(baseValue);
                case UnitToolsFrequencyUnit.Petahertz:
                    return UnitToolsMetricFrequency.HertzToPetahertz(baseValue);
                case UnitToolsFrequencyUnit.Exahertz:
                    return UnitToolsMetricFrequency.HertzToExahertz(baseValue);
                case UnitToolsFrequencyUnit.FramesPerSecond:
                    return UnitToolsCommonFrequency.HertzToFramesPerSecond(baseValue);
                case UnitToolsFrequencyUnit.CyclesPerMinute:
                    return UnitToolsCommonFrequency.HertzToCyclesPerMinute(baseValue);
                case UnitToolsFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitToolsScientificFrequency.HertzToRadianPerSecondAsFrequency(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported frequency unit.");
            }
        }

        public static string GetSymbol(UnitToolsFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrequencyUnit.Millihertz:
                    return "mHz";
                case UnitToolsFrequencyUnit.Hertz:
                    return "Hz";
                case UnitToolsFrequencyUnit.Kilohertz:
                    return "kHz";
                case UnitToolsFrequencyUnit.Megahertz:
                    return "MHz";
                case UnitToolsFrequencyUnit.Gigahertz:
                    return "GHz";
                case UnitToolsFrequencyUnit.Terahertz:
                    return "THz";
                case UnitToolsFrequencyUnit.RevolutionsPerMinute:
                    return "rpm";
                case UnitToolsFrequencyUnit.BeatsPerMinute:
                    return "bpm";
                case UnitToolsFrequencyUnit.Picohertz:
                    return "pHz";
                case UnitToolsFrequencyUnit.Nanohertz:
                    return "nHz";
                case UnitToolsFrequencyUnit.Microhertz:
                    return "µHz";
                case UnitToolsFrequencyUnit.Petahertz:
                    return "PHz";
                case UnitToolsFrequencyUnit.Exahertz:
                    return "EHz";
                case UnitToolsFrequencyUnit.FramesPerSecond:
                    return "fps";
                case UnitToolsFrequencyUnit.CyclesPerMinute:
                    return "cpm";
                case UnitToolsFrequencyUnit.RadianPerSecondAsFrequency:
                    return "rad/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrequencyUnit.Millihertz:
                    return "millihertz";
                case UnitToolsFrequencyUnit.Hertz:
                    return "hertz";
                case UnitToolsFrequencyUnit.Kilohertz:
                    return "kilohertz";
                case UnitToolsFrequencyUnit.Megahertz:
                    return "megahertz";
                case UnitToolsFrequencyUnit.Gigahertz:
                    return "gigahertz";
                case UnitToolsFrequencyUnit.Terahertz:
                    return "terahertz";
                case UnitToolsFrequencyUnit.RevolutionsPerMinute:
                    return "revolutions per minute";
                case UnitToolsFrequencyUnit.BeatsPerMinute:
                    return "beats per minute";
                case UnitToolsFrequencyUnit.Picohertz:
                    return "Picohertz";
                case UnitToolsFrequencyUnit.Nanohertz:
                    return "Nanohertz";
                case UnitToolsFrequencyUnit.Microhertz:
                    return "Microhertz";
                case UnitToolsFrequencyUnit.Petahertz:
                    return "Petahertz";
                case UnitToolsFrequencyUnit.Exahertz:
                    return "Exahertz";
                case UnitToolsFrequencyUnit.FramesPerSecond:
                    return "Frames Per Second";
                case UnitToolsFrequencyUnit.CyclesPerMinute:
                    return "Cycles Per Minute";
                case UnitToolsFrequencyUnit.RadianPerSecondAsFrequency:
                    return "Radian Per Second As Frequency";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFrequencyUnit.Millihertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Hertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Kilohertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Megahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Gigahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Terahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.RevolutionsPerMinute:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsFrequencyUnit.BeatsPerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrequencyUnit.Picohertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Nanohertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Microhertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Petahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.Exahertz:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFrequencyUnit.FramesPerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrequencyUnit.CyclesPerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsFrequencyUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsFrequencyUnit.Millihertz, UnitToolsFrequencyUnit.Hertz, UnitToolsFrequencyUnit.Kilohertz, UnitToolsFrequencyUnit.Megahertz, UnitToolsFrequencyUnit.Gigahertz, UnitToolsFrequencyUnit.Terahertz, UnitToolsFrequencyUnit.Picohertz, UnitToolsFrequencyUnit.Nanohertz, UnitToolsFrequencyUnit.Microhertz, UnitToolsFrequencyUnit.Petahertz, UnitToolsFrequencyUnit.Exahertz };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsFrequencyUnit.RevolutionsPerMinute };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsFrequencyUnit.BeatsPerMinute, UnitToolsFrequencyUnit.FramesPerSecond, UnitToolsFrequencyUnit.CyclesPerMinute };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsFrequencyUnit.RadianPerSecondAsFrequency };
                default:
                    return new[] { UnitToolsFrequencyUnit.Millihertz, UnitToolsFrequencyUnit.Hertz, UnitToolsFrequencyUnit.Kilohertz, UnitToolsFrequencyUnit.Megahertz, UnitToolsFrequencyUnit.Gigahertz, UnitToolsFrequencyUnit.Terahertz, UnitToolsFrequencyUnit.RevolutionsPerMinute, UnitToolsFrequencyUnit.BeatsPerMinute, UnitToolsFrequencyUnit.Picohertz, UnitToolsFrequencyUnit.Nanohertz, UnitToolsFrequencyUnit.Microhertz, UnitToolsFrequencyUnit.Petahertz, UnitToolsFrequencyUnit.Exahertz, UnitToolsFrequencyUnit.FramesPerSecond, UnitToolsFrequencyUnit.CyclesPerMinute, UnitToolsFrequencyUnit.RadianPerSecondAsFrequency };
            }
        }
    }
}
