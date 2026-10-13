namespace UnitTools.Voltage
{
    using UnitTools.Voltage.Metric;
    using UnitTools.Voltage.Scientific;

    public enum UnitToolsVoltageUnit
    {
        Nanovolt = 0,
        Microvolt = 1,
        Millivolt = 2,
        Volt = 3,
        Kilovolt = 4,
        Megavolt = 5,
        Gigavolt = 6,
        Statvolt = 7,
        Femtovolt = 8,
        Picovolt = 9,
        Teravolt = 10,
        Petavolt = 11,
        Abvolt = 12,
    }

    public static class UnitToolsVoltage
    {
        public static double Convert(double value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            double baseValue = ToVolt(value, from);
            return FromVolt(baseValue, to);
        }

        public static double ToVolt(double value, UnitToolsVoltageUnit from)
        {
            switch (from)
            {
                case UnitToolsVoltageUnit.Nanovolt:
                    return UnitToolsMetricVoltage.NanovoltToVolt(value);
                case UnitToolsVoltageUnit.Microvolt:
                    return UnitToolsMetricVoltage.MicrovoltToVolt(value);
                case UnitToolsVoltageUnit.Millivolt:
                    return UnitToolsMetricVoltage.MillivoltToVolt(value);
                case UnitToolsVoltageUnit.Volt:
                    return UnitToolsMetricVoltage.VoltToVolt(value);
                case UnitToolsVoltageUnit.Kilovolt:
                    return UnitToolsMetricVoltage.KilovoltToVolt(value);
                case UnitToolsVoltageUnit.Megavolt:
                    return UnitToolsMetricVoltage.MegavoltToVolt(value);
                case UnitToolsVoltageUnit.Gigavolt:
                    return UnitToolsMetricVoltage.GigavoltToVolt(value);
                case UnitToolsVoltageUnit.Statvolt:
                    return UnitToolsScientificVoltage.StatvoltToVolt(value);
                case UnitToolsVoltageUnit.Femtovolt:
                    return UnitToolsMetricVoltage.FemtovoltToVolt(value);
                case UnitToolsVoltageUnit.Picovolt:
                    return UnitToolsMetricVoltage.PicovoltToVolt(value);
                case UnitToolsVoltageUnit.Teravolt:
                    return UnitToolsMetricVoltage.TeravoltToVolt(value);
                case UnitToolsVoltageUnit.Petavolt:
                    return UnitToolsMetricVoltage.PetavoltToVolt(value);
                case UnitToolsVoltageUnit.Abvolt:
                    return UnitToolsScientificVoltage.AbvoltToVolt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported voltage unit.");
            }
        }

        public static double FromVolt(double baseValue, UnitToolsVoltageUnit to)
        {
            switch (to)
            {
                case UnitToolsVoltageUnit.Nanovolt:
                    return UnitToolsMetricVoltage.VoltToNanovolt(baseValue);
                case UnitToolsVoltageUnit.Microvolt:
                    return UnitToolsMetricVoltage.VoltToMicrovolt(baseValue);
                case UnitToolsVoltageUnit.Millivolt:
                    return UnitToolsMetricVoltage.VoltToMillivolt(baseValue);
                case UnitToolsVoltageUnit.Volt:
                    return UnitToolsMetricVoltage.VoltToVolt(baseValue);
                case UnitToolsVoltageUnit.Kilovolt:
                    return UnitToolsMetricVoltage.VoltToKilovolt(baseValue);
                case UnitToolsVoltageUnit.Megavolt:
                    return UnitToolsMetricVoltage.VoltToMegavolt(baseValue);
                case UnitToolsVoltageUnit.Gigavolt:
                    return UnitToolsMetricVoltage.VoltToGigavolt(baseValue);
                case UnitToolsVoltageUnit.Statvolt:
                    return UnitToolsScientificVoltage.VoltToStatvolt(baseValue);
                case UnitToolsVoltageUnit.Femtovolt:
                    return UnitToolsMetricVoltage.VoltToFemtovolt(baseValue);
                case UnitToolsVoltageUnit.Picovolt:
                    return UnitToolsMetricVoltage.VoltToPicovolt(baseValue);
                case UnitToolsVoltageUnit.Teravolt:
                    return UnitToolsMetricVoltage.VoltToTeravolt(baseValue);
                case UnitToolsVoltageUnit.Petavolt:
                    return UnitToolsMetricVoltage.VoltToPetavolt(baseValue);
                case UnitToolsVoltageUnit.Abvolt:
                    return UnitToolsScientificVoltage.VoltToAbvolt(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported voltage unit.");
            }
        }

        public static string GetSymbol(UnitToolsVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVoltageUnit.Nanovolt:
                    return "nV";
                case UnitToolsVoltageUnit.Microvolt:
                    return "µV";
                case UnitToolsVoltageUnit.Millivolt:
                    return "mV";
                case UnitToolsVoltageUnit.Volt:
                    return "V";
                case UnitToolsVoltageUnit.Kilovolt:
                    return "kV";
                case UnitToolsVoltageUnit.Megavolt:
                    return "MV";
                case UnitToolsVoltageUnit.Gigavolt:
                    return "GV";
                case UnitToolsVoltageUnit.Statvolt:
                    return "statV";
                case UnitToolsVoltageUnit.Femtovolt:
                    return "fV";
                case UnitToolsVoltageUnit.Picovolt:
                    return "pV";
                case UnitToolsVoltageUnit.Teravolt:
                    return "TV";
                case UnitToolsVoltageUnit.Petavolt:
                    return "PV";
                case UnitToolsVoltageUnit.Abvolt:
                    return "abV";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVoltageUnit.Nanovolt:
                    return "nanovolt";
                case UnitToolsVoltageUnit.Microvolt:
                    return "microvolt";
                case UnitToolsVoltageUnit.Millivolt:
                    return "millivolt";
                case UnitToolsVoltageUnit.Volt:
                    return "volt";
                case UnitToolsVoltageUnit.Kilovolt:
                    return "kilovolt";
                case UnitToolsVoltageUnit.Megavolt:
                    return "megavolt";
                case UnitToolsVoltageUnit.Gigavolt:
                    return "gigavolt";
                case UnitToolsVoltageUnit.Statvolt:
                    return "statvolt";
                case UnitToolsVoltageUnit.Femtovolt:
                    return "Femtovolt";
                case UnitToolsVoltageUnit.Picovolt:
                    return "Picovolt";
                case UnitToolsVoltageUnit.Teravolt:
                    return "Teravolt";
                case UnitToolsVoltageUnit.Petavolt:
                    return "Petavolt";
                case UnitToolsVoltageUnit.Abvolt:
                    return "Abvolt";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVoltageUnit.Nanovolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Microvolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Millivolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Volt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Kilovolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Megavolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Gigavolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Statvolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsVoltageUnit.Femtovolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Picovolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Teravolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Petavolt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVoltageUnit.Abvolt:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsVoltageUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsVoltageUnit.Nanovolt, UnitToolsVoltageUnit.Microvolt, UnitToolsVoltageUnit.Millivolt, UnitToolsVoltageUnit.Volt, UnitToolsVoltageUnit.Kilovolt, UnitToolsVoltageUnit.Megavolt, UnitToolsVoltageUnit.Gigavolt, UnitToolsVoltageUnit.Femtovolt, UnitToolsVoltageUnit.Picovolt, UnitToolsVoltageUnit.Teravolt, UnitToolsVoltageUnit.Petavolt };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsVoltageUnit.Statvolt, UnitToolsVoltageUnit.Abvolt };
                default:
                    return new[] { UnitToolsVoltageUnit.Nanovolt, UnitToolsVoltageUnit.Microvolt, UnitToolsVoltageUnit.Millivolt, UnitToolsVoltageUnit.Volt, UnitToolsVoltageUnit.Kilovolt, UnitToolsVoltageUnit.Megavolt, UnitToolsVoltageUnit.Gigavolt, UnitToolsVoltageUnit.Statvolt, UnitToolsVoltageUnit.Femtovolt, UnitToolsVoltageUnit.Picovolt, UnitToolsVoltageUnit.Teravolt, UnitToolsVoltageUnit.Petavolt, UnitToolsVoltageUnit.Abvolt };
            }
        }
    }
}
