namespace RealisticPhysics.UnitConversion.Voltage
{
    using RealisticPhysics.UnitConversion.Voltage.Metric;
    using RealisticPhysics.UnitConversion.Voltage.Scientific;

    public enum UnitConverterVoltageUnit
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

    public static class UnitConverterVoltage
    {
        public static double Convert(double value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            double baseValue = ToVolt(value, from);
            return FromVolt(baseValue, to);
        }

        public static double ToVolt(double value, UnitConverterVoltageUnit from)
        {
            switch (from)
            {
                case UnitConverterVoltageUnit.Nanovolt:
                    return UnitConverterMetricVoltage.NanovoltToVolt(value);
                case UnitConverterVoltageUnit.Microvolt:
                    return UnitConverterMetricVoltage.MicrovoltToVolt(value);
                case UnitConverterVoltageUnit.Millivolt:
                    return UnitConverterMetricVoltage.MillivoltToVolt(value);
                case UnitConverterVoltageUnit.Volt:
                    return UnitConverterMetricVoltage.VoltToVolt(value);
                case UnitConverterVoltageUnit.Kilovolt:
                    return UnitConverterMetricVoltage.KilovoltToVolt(value);
                case UnitConverterVoltageUnit.Megavolt:
                    return UnitConverterMetricVoltage.MegavoltToVolt(value);
                case UnitConverterVoltageUnit.Gigavolt:
                    return UnitConverterMetricVoltage.GigavoltToVolt(value);
                case UnitConverterVoltageUnit.Statvolt:
                    return UnitConverterScientificVoltage.StatvoltToVolt(value);
                case UnitConverterVoltageUnit.Femtovolt:
                    return UnitConverterMetricVoltage.FemtovoltToVolt(value);
                case UnitConverterVoltageUnit.Picovolt:
                    return UnitConverterMetricVoltage.PicovoltToVolt(value);
                case UnitConverterVoltageUnit.Teravolt:
                    return UnitConverterMetricVoltage.TeravoltToVolt(value);
                case UnitConverterVoltageUnit.Petavolt:
                    return UnitConverterMetricVoltage.PetavoltToVolt(value);
                case UnitConverterVoltageUnit.Abvolt:
                    return UnitConverterScientificVoltage.AbvoltToVolt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported voltage unit.");
            }
        }

        public static double FromVolt(double baseValue, UnitConverterVoltageUnit to)
        {
            switch (to)
            {
                case UnitConverterVoltageUnit.Nanovolt:
                    return UnitConverterMetricVoltage.VoltToNanovolt(baseValue);
                case UnitConverterVoltageUnit.Microvolt:
                    return UnitConverterMetricVoltage.VoltToMicrovolt(baseValue);
                case UnitConverterVoltageUnit.Millivolt:
                    return UnitConverterMetricVoltage.VoltToMillivolt(baseValue);
                case UnitConverterVoltageUnit.Volt:
                    return UnitConverterMetricVoltage.VoltToVolt(baseValue);
                case UnitConverterVoltageUnit.Kilovolt:
                    return UnitConverterMetricVoltage.VoltToKilovolt(baseValue);
                case UnitConverterVoltageUnit.Megavolt:
                    return UnitConverterMetricVoltage.VoltToMegavolt(baseValue);
                case UnitConverterVoltageUnit.Gigavolt:
                    return UnitConverterMetricVoltage.VoltToGigavolt(baseValue);
                case UnitConverterVoltageUnit.Statvolt:
                    return UnitConverterScientificVoltage.VoltToStatvolt(baseValue);
                case UnitConverterVoltageUnit.Femtovolt:
                    return UnitConverterMetricVoltage.VoltToFemtovolt(baseValue);
                case UnitConverterVoltageUnit.Picovolt:
                    return UnitConverterMetricVoltage.VoltToPicovolt(baseValue);
                case UnitConverterVoltageUnit.Teravolt:
                    return UnitConverterMetricVoltage.VoltToTeravolt(baseValue);
                case UnitConverterVoltageUnit.Petavolt:
                    return UnitConverterMetricVoltage.VoltToPetavolt(baseValue);
                case UnitConverterVoltageUnit.Abvolt:
                    return UnitConverterScientificVoltage.VoltToAbvolt(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported voltage unit.");
            }
        }

        public static string GetSymbol(UnitConverterVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVoltageUnit.Nanovolt:
                    return "nV";
                case UnitConverterVoltageUnit.Microvolt:
                    return "µV";
                case UnitConverterVoltageUnit.Millivolt:
                    return "mV";
                case UnitConverterVoltageUnit.Volt:
                    return "V";
                case UnitConverterVoltageUnit.Kilovolt:
                    return "kV";
                case UnitConverterVoltageUnit.Megavolt:
                    return "MV";
                case UnitConverterVoltageUnit.Gigavolt:
                    return "GV";
                case UnitConverterVoltageUnit.Statvolt:
                    return "statV";
                case UnitConverterVoltageUnit.Femtovolt:
                    return "fV";
                case UnitConverterVoltageUnit.Picovolt:
                    return "pV";
                case UnitConverterVoltageUnit.Teravolt:
                    return "TV";
                case UnitConverterVoltageUnit.Petavolt:
                    return "PV";
                case UnitConverterVoltageUnit.Abvolt:
                    return "abV";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVoltageUnit.Nanovolt:
                    return "nanovolt";
                case UnitConverterVoltageUnit.Microvolt:
                    return "microvolt";
                case UnitConverterVoltageUnit.Millivolt:
                    return "millivolt";
                case UnitConverterVoltageUnit.Volt:
                    return "volt";
                case UnitConverterVoltageUnit.Kilovolt:
                    return "kilovolt";
                case UnitConverterVoltageUnit.Megavolt:
                    return "megavolt";
                case UnitConverterVoltageUnit.Gigavolt:
                    return "gigavolt";
                case UnitConverterVoltageUnit.Statvolt:
                    return "statvolt";
                case UnitConverterVoltageUnit.Femtovolt:
                    return "Femtovolt";
                case UnitConverterVoltageUnit.Picovolt:
                    return "Picovolt";
                case UnitConverterVoltageUnit.Teravolt:
                    return "Teravolt";
                case UnitConverterVoltageUnit.Petavolt:
                    return "Petavolt";
                case UnitConverterVoltageUnit.Abvolt:
                    return "Abvolt";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterVoltageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVoltageUnit.Nanovolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Microvolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Millivolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Volt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Kilovolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Megavolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Gigavolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Statvolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterVoltageUnit.Femtovolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Picovolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Teravolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Petavolt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVoltageUnit.Abvolt:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterVoltageUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterVoltageUnit.Nanovolt, UnitConverterVoltageUnit.Microvolt, UnitConverterVoltageUnit.Millivolt, UnitConverterVoltageUnit.Volt, UnitConverterVoltageUnit.Kilovolt, UnitConverterVoltageUnit.Megavolt, UnitConverterVoltageUnit.Gigavolt, UnitConverterVoltageUnit.Femtovolt, UnitConverterVoltageUnit.Picovolt, UnitConverterVoltageUnit.Teravolt, UnitConverterVoltageUnit.Petavolt };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterVoltageUnit.Statvolt, UnitConverterVoltageUnit.Abvolt };
                default:
                    return new[] { UnitConverterVoltageUnit.Nanovolt, UnitConverterVoltageUnit.Microvolt, UnitConverterVoltageUnit.Millivolt, UnitConverterVoltageUnit.Volt, UnitConverterVoltageUnit.Kilovolt, UnitConverterVoltageUnit.Megavolt, UnitConverterVoltageUnit.Gigavolt, UnitConverterVoltageUnit.Statvolt, UnitConverterVoltageUnit.Femtovolt, UnitConverterVoltageUnit.Picovolt, UnitConverterVoltageUnit.Teravolt, UnitConverterVoltageUnit.Petavolt, UnitConverterVoltageUnit.Abvolt };
            }
        }
    }
}
