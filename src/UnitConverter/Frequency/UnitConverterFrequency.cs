namespace UnitConverter.Frequency
{
    using UnitConverter.Frequency.Metric;
    using UnitConverter.Frequency.Engineering;
    using UnitConverter.Frequency.Common;
    using UnitConverter.Frequency.Scientific;

    public enum UnitConverterFrequencyUnit
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

    public static class UnitConverterFrequency
    {
        public static double Convert(double value, UnitConverterFrequencyUnit from, UnitConverterFrequencyUnit to)
        {
            double baseValue = ToHertz(value, from);
            return FromHertz(baseValue, to);
        }

        public static double ToHertz(double value, UnitConverterFrequencyUnit from)
        {
            switch (from)
            {
                case UnitConverterFrequencyUnit.Millihertz:
                    return UnitConverterMetricFrequency.MillihertzToHertz(value);
                case UnitConverterFrequencyUnit.Hertz:
                    return UnitConverterMetricFrequency.HertzToHertz(value);
                case UnitConverterFrequencyUnit.Kilohertz:
                    return UnitConverterMetricFrequency.KilohertzToHertz(value);
                case UnitConverterFrequencyUnit.Megahertz:
                    return UnitConverterMetricFrequency.MegahertzToHertz(value);
                case UnitConverterFrequencyUnit.Gigahertz:
                    return UnitConverterMetricFrequency.GigahertzToHertz(value);
                case UnitConverterFrequencyUnit.Terahertz:
                    return UnitConverterMetricFrequency.TerahertzToHertz(value);
                case UnitConverterFrequencyUnit.RevolutionsPerMinute:
                    return UnitConverterEngineeringFrequency.RevolutionsPerMinuteToHertz(value);
                case UnitConverterFrequencyUnit.BeatsPerMinute:
                    return UnitConverterCommonFrequency.BeatsPerMinuteToHertz(value);
                case UnitConverterFrequencyUnit.Picohertz:
                    return UnitConverterMetricFrequency.PicohertzToHertz(value);
                case UnitConverterFrequencyUnit.Nanohertz:
                    return UnitConverterMetricFrequency.NanohertzToHertz(value);
                case UnitConverterFrequencyUnit.Microhertz:
                    return UnitConverterMetricFrequency.MicrohertzToHertz(value);
                case UnitConverterFrequencyUnit.Petahertz:
                    return UnitConverterMetricFrequency.PetahertzToHertz(value);
                case UnitConverterFrequencyUnit.Exahertz:
                    return UnitConverterMetricFrequency.ExahertzToHertz(value);
                case UnitConverterFrequencyUnit.FramesPerSecond:
                    return UnitConverterCommonFrequency.FramesPerSecondToHertz(value);
                case UnitConverterFrequencyUnit.CyclesPerMinute:
                    return UnitConverterCommonFrequency.CyclesPerMinuteToHertz(value);
                case UnitConverterFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitConverterScientificFrequency.RadianPerSecondAsFrequencyToHertz(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported frequency unit.");
            }
        }

        public static double FromHertz(double baseValue, UnitConverterFrequencyUnit to)
        {
            switch (to)
            {
                case UnitConverterFrequencyUnit.Millihertz:
                    return UnitConverterMetricFrequency.HertzToMillihertz(baseValue);
                case UnitConverterFrequencyUnit.Hertz:
                    return UnitConverterMetricFrequency.HertzToHertz(baseValue);
                case UnitConverterFrequencyUnit.Kilohertz:
                    return UnitConverterMetricFrequency.HertzToKilohertz(baseValue);
                case UnitConverterFrequencyUnit.Megahertz:
                    return UnitConverterMetricFrequency.HertzToMegahertz(baseValue);
                case UnitConverterFrequencyUnit.Gigahertz:
                    return UnitConverterMetricFrequency.HertzToGigahertz(baseValue);
                case UnitConverterFrequencyUnit.Terahertz:
                    return UnitConverterMetricFrequency.HertzToTerahertz(baseValue);
                case UnitConverterFrequencyUnit.RevolutionsPerMinute:
                    return UnitConverterEngineeringFrequency.HertzToRevolutionsPerMinute(baseValue);
                case UnitConverterFrequencyUnit.BeatsPerMinute:
                    return UnitConverterCommonFrequency.HertzToBeatsPerMinute(baseValue);
                case UnitConverterFrequencyUnit.Picohertz:
                    return UnitConverterMetricFrequency.HertzToPicohertz(baseValue);
                case UnitConverterFrequencyUnit.Nanohertz:
                    return UnitConverterMetricFrequency.HertzToNanohertz(baseValue);
                case UnitConverterFrequencyUnit.Microhertz:
                    return UnitConverterMetricFrequency.HertzToMicrohertz(baseValue);
                case UnitConverterFrequencyUnit.Petahertz:
                    return UnitConverterMetricFrequency.HertzToPetahertz(baseValue);
                case UnitConverterFrequencyUnit.Exahertz:
                    return UnitConverterMetricFrequency.HertzToExahertz(baseValue);
                case UnitConverterFrequencyUnit.FramesPerSecond:
                    return UnitConverterCommonFrequency.HertzToFramesPerSecond(baseValue);
                case UnitConverterFrequencyUnit.CyclesPerMinute:
                    return UnitConverterCommonFrequency.HertzToCyclesPerMinute(baseValue);
                case UnitConverterFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitConverterScientificFrequency.HertzToRadianPerSecondAsFrequency(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported frequency unit.");
            }
        }

        public static string GetSymbol(UnitConverterFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrequencyUnit.Millihertz:
                    return "mHz";
                case UnitConverterFrequencyUnit.Hertz:
                    return "Hz";
                case UnitConverterFrequencyUnit.Kilohertz:
                    return "kHz";
                case UnitConverterFrequencyUnit.Megahertz:
                    return "MHz";
                case UnitConverterFrequencyUnit.Gigahertz:
                    return "GHz";
                case UnitConverterFrequencyUnit.Terahertz:
                    return "THz";
                case UnitConverterFrequencyUnit.RevolutionsPerMinute:
                    return "rpm";
                case UnitConverterFrequencyUnit.BeatsPerMinute:
                    return "bpm";
                case UnitConverterFrequencyUnit.Picohertz:
                    return "pHz";
                case UnitConverterFrequencyUnit.Nanohertz:
                    return "nHz";
                case UnitConverterFrequencyUnit.Microhertz:
                    return "µHz";
                case UnitConverterFrequencyUnit.Petahertz:
                    return "PHz";
                case UnitConverterFrequencyUnit.Exahertz:
                    return "EHz";
                case UnitConverterFrequencyUnit.FramesPerSecond:
                    return "fps";
                case UnitConverterFrequencyUnit.CyclesPerMinute:
                    return "cpm";
                case UnitConverterFrequencyUnit.RadianPerSecondAsFrequency:
                    return "rad/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrequencyUnit.Millihertz:
                    return "millihertz";
                case UnitConverterFrequencyUnit.Hertz:
                    return "hertz";
                case UnitConverterFrequencyUnit.Kilohertz:
                    return "kilohertz";
                case UnitConverterFrequencyUnit.Megahertz:
                    return "megahertz";
                case UnitConverterFrequencyUnit.Gigahertz:
                    return "gigahertz";
                case UnitConverterFrequencyUnit.Terahertz:
                    return "terahertz";
                case UnitConverterFrequencyUnit.RevolutionsPerMinute:
                    return "revolutions per minute";
                case UnitConverterFrequencyUnit.BeatsPerMinute:
                    return "beats per minute";
                case UnitConverterFrequencyUnit.Picohertz:
                    return "Picohertz";
                case UnitConverterFrequencyUnit.Nanohertz:
                    return "Nanohertz";
                case UnitConverterFrequencyUnit.Microhertz:
                    return "Microhertz";
                case UnitConverterFrequencyUnit.Petahertz:
                    return "Petahertz";
                case UnitConverterFrequencyUnit.Exahertz:
                    return "Exahertz";
                case UnitConverterFrequencyUnit.FramesPerSecond:
                    return "Frames Per Second";
                case UnitConverterFrequencyUnit.CyclesPerMinute:
                    return "Cycles Per Minute";
                case UnitConverterFrequencyUnit.RadianPerSecondAsFrequency:
                    return "Radian Per Second As Frequency";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterFrequencyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFrequencyUnit.Millihertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Hertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Kilohertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Megahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Gigahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Terahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.RevolutionsPerMinute:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterFrequencyUnit.BeatsPerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrequencyUnit.Picohertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Nanohertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Microhertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Petahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.Exahertz:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFrequencyUnit.FramesPerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrequencyUnit.CyclesPerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFrequencyUnit.RadianPerSecondAsFrequency:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterFrequencyUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterFrequencyUnit.Millihertz, UnitConverterFrequencyUnit.Hertz, UnitConverterFrequencyUnit.Kilohertz, UnitConverterFrequencyUnit.Megahertz, UnitConverterFrequencyUnit.Gigahertz, UnitConverterFrequencyUnit.Terahertz, UnitConverterFrequencyUnit.Picohertz, UnitConverterFrequencyUnit.Nanohertz, UnitConverterFrequencyUnit.Microhertz, UnitConverterFrequencyUnit.Petahertz, UnitConverterFrequencyUnit.Exahertz };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterFrequencyUnit.RevolutionsPerMinute };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterFrequencyUnit.BeatsPerMinute, UnitConverterFrequencyUnit.FramesPerSecond, UnitConverterFrequencyUnit.CyclesPerMinute };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterFrequencyUnit.RadianPerSecondAsFrequency };
                default:
                    return new[] { UnitConverterFrequencyUnit.Millihertz, UnitConverterFrequencyUnit.Hertz, UnitConverterFrequencyUnit.Kilohertz, UnitConverterFrequencyUnit.Megahertz, UnitConverterFrequencyUnit.Gigahertz, UnitConverterFrequencyUnit.Terahertz, UnitConverterFrequencyUnit.RevolutionsPerMinute, UnitConverterFrequencyUnit.BeatsPerMinute, UnitConverterFrequencyUnit.Picohertz, UnitConverterFrequencyUnit.Nanohertz, UnitConverterFrequencyUnit.Microhertz, UnitConverterFrequencyUnit.Petahertz, UnitConverterFrequencyUnit.Exahertz, UnitConverterFrequencyUnit.FramesPerSecond, UnitConverterFrequencyUnit.CyclesPerMinute, UnitConverterFrequencyUnit.RadianPerSecondAsFrequency };
            }
        }
    }
}
