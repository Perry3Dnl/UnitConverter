namespace UnitConverter.ElectricResistance
{
    using UnitConverter.ElectricResistance.Metric;
    using UnitConverter.ElectricResistance.Scientific;

    public enum UnitConverterElectricResistanceUnit
    {
        Microohm = 0,
        Milliohm = 1,
        Ohm = 2,
        Kiloohm = 3,
        Megaohm = 4,
        Gigaohm = 5,
        Statohm = 6,
        Picoohm = 7,
        Nanoohm = 8,
        Teraohm = 9,
        Petaohm = 10,
        Abohm = 11,
        QuantumHallResistance = 12,
    }

    public static class UnitConverterElectricResistance
    {
        public static double Convert(double value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            double baseValue = ToOhm(value, from);
            return FromOhm(baseValue, to);
        }

        public static double ToOhm(double value, UnitConverterElectricResistanceUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricResistanceUnit.Microohm:
                    return UnitConverterMetricElectricResistance.MicroohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Milliohm:
                    return UnitConverterMetricElectricResistance.MilliohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Ohm:
                    return UnitConverterMetricElectricResistance.OhmToOhm(value);
                case UnitConverterElectricResistanceUnit.Kiloohm:
                    return UnitConverterMetricElectricResistance.KiloohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Megaohm:
                    return UnitConverterMetricElectricResistance.MegaohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Gigaohm:
                    return UnitConverterMetricElectricResistance.GigaohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Statohm:
                    return UnitConverterScientificElectricResistance.StatohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Picoohm:
                    return UnitConverterMetricElectricResistance.PicoohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Nanoohm:
                    return UnitConverterMetricElectricResistance.NanoohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Teraohm:
                    return UnitConverterMetricElectricResistance.TeraohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Petaohm:
                    return UnitConverterMetricElectricResistance.PetaohmToOhm(value);
                case UnitConverterElectricResistanceUnit.Abohm:
                    return UnitConverterScientificElectricResistance.AbohmToOhm(value);
                case UnitConverterElectricResistanceUnit.QuantumHallResistance:
                    return UnitConverterScientificElectricResistance.QuantumHallResistanceToOhm(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric resistance unit.");
            }
        }

        public static double FromOhm(double baseValue, UnitConverterElectricResistanceUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricResistanceUnit.Microohm:
                    return UnitConverterMetricElectricResistance.OhmToMicroohm(baseValue);
                case UnitConverterElectricResistanceUnit.Milliohm:
                    return UnitConverterMetricElectricResistance.OhmToMilliohm(baseValue);
                case UnitConverterElectricResistanceUnit.Ohm:
                    return UnitConverterMetricElectricResistance.OhmToOhm(baseValue);
                case UnitConverterElectricResistanceUnit.Kiloohm:
                    return UnitConverterMetricElectricResistance.OhmToKiloohm(baseValue);
                case UnitConverterElectricResistanceUnit.Megaohm:
                    return UnitConverterMetricElectricResistance.OhmToMegaohm(baseValue);
                case UnitConverterElectricResistanceUnit.Gigaohm:
                    return UnitConverterMetricElectricResistance.OhmToGigaohm(baseValue);
                case UnitConverterElectricResistanceUnit.Statohm:
                    return UnitConverterScientificElectricResistance.OhmToStatohm(baseValue);
                case UnitConverterElectricResistanceUnit.Picoohm:
                    return UnitConverterMetricElectricResistance.OhmToPicoohm(baseValue);
                case UnitConverterElectricResistanceUnit.Nanoohm:
                    return UnitConverterMetricElectricResistance.OhmToNanoohm(baseValue);
                case UnitConverterElectricResistanceUnit.Teraohm:
                    return UnitConverterMetricElectricResistance.OhmToTeraohm(baseValue);
                case UnitConverterElectricResistanceUnit.Petaohm:
                    return UnitConverterMetricElectricResistance.OhmToPetaohm(baseValue);
                case UnitConverterElectricResistanceUnit.Abohm:
                    return UnitConverterScientificElectricResistance.OhmToAbohm(baseValue);
                case UnitConverterElectricResistanceUnit.QuantumHallResistance:
                    return UnitConverterScientificElectricResistance.OhmToQuantumHallResistance(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric resistance unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricResistanceUnit.Microohm:
                    return "µΩ";
                case UnitConverterElectricResistanceUnit.Milliohm:
                    return "mΩ";
                case UnitConverterElectricResistanceUnit.Ohm:
                    return "Ω";
                case UnitConverterElectricResistanceUnit.Kiloohm:
                    return "kΩ";
                case UnitConverterElectricResistanceUnit.Megaohm:
                    return "MΩ";
                case UnitConverterElectricResistanceUnit.Gigaohm:
                    return "GΩ";
                case UnitConverterElectricResistanceUnit.Statohm:
                    return "statΩ";
                case UnitConverterElectricResistanceUnit.Picoohm:
                    return "pΩ";
                case UnitConverterElectricResistanceUnit.Nanoohm:
                    return "nΩ";
                case UnitConverterElectricResistanceUnit.Teraohm:
                    return "TΩ";
                case UnitConverterElectricResistanceUnit.Petaohm:
                    return "PΩ";
                case UnitConverterElectricResistanceUnit.Abohm:
                    return "abΩ";
                case UnitConverterElectricResistanceUnit.QuantumHallResistance:
                    return "Rᴋ";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricResistanceUnit.Microohm:
                    return "microohm";
                case UnitConverterElectricResistanceUnit.Milliohm:
                    return "milliohm";
                case UnitConverterElectricResistanceUnit.Ohm:
                    return "ohm";
                case UnitConverterElectricResistanceUnit.Kiloohm:
                    return "kiloohm";
                case UnitConverterElectricResistanceUnit.Megaohm:
                    return "megaohm";
                case UnitConverterElectricResistanceUnit.Gigaohm:
                    return "gigaohm";
                case UnitConverterElectricResistanceUnit.Statohm:
                    return "statohm";
                case UnitConverterElectricResistanceUnit.Picoohm:
                    return "Picoohm";
                case UnitConverterElectricResistanceUnit.Nanoohm:
                    return "Nanoohm";
                case UnitConverterElectricResistanceUnit.Teraohm:
                    return "Teraohm";
                case UnitConverterElectricResistanceUnit.Petaohm:
                    return "Petaohm";
                case UnitConverterElectricResistanceUnit.Abohm:
                    return "Abohm";
                case UnitConverterElectricResistanceUnit.QuantumHallResistance:
                    return "Quantum Hall Resistance";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricResistanceUnit.Microohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Milliohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Ohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Kiloohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Megaohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Gigaohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Statohm:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricResistanceUnit.Picoohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Nanoohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Teraohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Petaohm:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricResistanceUnit.Abohm:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricResistanceUnit.QuantumHallResistance:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricResistanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricResistanceUnit.Microohm, UnitConverterElectricResistanceUnit.Milliohm, UnitConverterElectricResistanceUnit.Ohm, UnitConverterElectricResistanceUnit.Kiloohm, UnitConverterElectricResistanceUnit.Megaohm, UnitConverterElectricResistanceUnit.Gigaohm, UnitConverterElectricResistanceUnit.Picoohm, UnitConverterElectricResistanceUnit.Nanoohm, UnitConverterElectricResistanceUnit.Teraohm, UnitConverterElectricResistanceUnit.Petaohm };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricResistanceUnit.Statohm, UnitConverterElectricResistanceUnit.Abohm, UnitConverterElectricResistanceUnit.QuantumHallResistance };
                default:
                    return new[] { UnitConverterElectricResistanceUnit.Microohm, UnitConverterElectricResistanceUnit.Milliohm, UnitConverterElectricResistanceUnit.Ohm, UnitConverterElectricResistanceUnit.Kiloohm, UnitConverterElectricResistanceUnit.Megaohm, UnitConverterElectricResistanceUnit.Gigaohm, UnitConverterElectricResistanceUnit.Statohm, UnitConverterElectricResistanceUnit.Picoohm, UnitConverterElectricResistanceUnit.Nanoohm, UnitConverterElectricResistanceUnit.Teraohm, UnitConverterElectricResistanceUnit.Petaohm, UnitConverterElectricResistanceUnit.Abohm, UnitConverterElectricResistanceUnit.QuantumHallResistance };
            }
        }
    }
}
