namespace UnitTools.ElectricResistance
{
    using UnitTools.ElectricResistance.Metric;
    using UnitTools.ElectricResistance.Scientific;

    public enum UnitToolsElectricResistanceUnit
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

    public static class UnitToolsElectricResistance
    {
        public static double Convert(double value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            double baseValue = ToOhm(value, from);
            return FromOhm(baseValue, to);
        }

        public static double ToOhm(double value, UnitToolsElectricResistanceUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricResistanceUnit.Microohm:
                    return UnitToolsMetricElectricResistance.MicroohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Milliohm:
                    return UnitToolsMetricElectricResistance.MilliohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Ohm:
                    return UnitToolsMetricElectricResistance.OhmToOhm(value);
                case UnitToolsElectricResistanceUnit.Kiloohm:
                    return UnitToolsMetricElectricResistance.KiloohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Megaohm:
                    return UnitToolsMetricElectricResistance.MegaohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Gigaohm:
                    return UnitToolsMetricElectricResistance.GigaohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Statohm:
                    return UnitToolsScientificElectricResistance.StatohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Picoohm:
                    return UnitToolsMetricElectricResistance.PicoohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Nanoohm:
                    return UnitToolsMetricElectricResistance.NanoohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Teraohm:
                    return UnitToolsMetricElectricResistance.TeraohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Petaohm:
                    return UnitToolsMetricElectricResistance.PetaohmToOhm(value);
                case UnitToolsElectricResistanceUnit.Abohm:
                    return UnitToolsScientificElectricResistance.AbohmToOhm(value);
                case UnitToolsElectricResistanceUnit.QuantumHallResistance:
                    return UnitToolsScientificElectricResistance.QuantumHallResistanceToOhm(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric resistance unit.");
            }
        }

        public static double FromOhm(double baseValue, UnitToolsElectricResistanceUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricResistanceUnit.Microohm:
                    return UnitToolsMetricElectricResistance.OhmToMicroohm(baseValue);
                case UnitToolsElectricResistanceUnit.Milliohm:
                    return UnitToolsMetricElectricResistance.OhmToMilliohm(baseValue);
                case UnitToolsElectricResistanceUnit.Ohm:
                    return UnitToolsMetricElectricResistance.OhmToOhm(baseValue);
                case UnitToolsElectricResistanceUnit.Kiloohm:
                    return UnitToolsMetricElectricResistance.OhmToKiloohm(baseValue);
                case UnitToolsElectricResistanceUnit.Megaohm:
                    return UnitToolsMetricElectricResistance.OhmToMegaohm(baseValue);
                case UnitToolsElectricResistanceUnit.Gigaohm:
                    return UnitToolsMetricElectricResistance.OhmToGigaohm(baseValue);
                case UnitToolsElectricResistanceUnit.Statohm:
                    return UnitToolsScientificElectricResistance.OhmToStatohm(baseValue);
                case UnitToolsElectricResistanceUnit.Picoohm:
                    return UnitToolsMetricElectricResistance.OhmToPicoohm(baseValue);
                case UnitToolsElectricResistanceUnit.Nanoohm:
                    return UnitToolsMetricElectricResistance.OhmToNanoohm(baseValue);
                case UnitToolsElectricResistanceUnit.Teraohm:
                    return UnitToolsMetricElectricResistance.OhmToTeraohm(baseValue);
                case UnitToolsElectricResistanceUnit.Petaohm:
                    return UnitToolsMetricElectricResistance.OhmToPetaohm(baseValue);
                case UnitToolsElectricResistanceUnit.Abohm:
                    return UnitToolsScientificElectricResistance.OhmToAbohm(baseValue);
                case UnitToolsElectricResistanceUnit.QuantumHallResistance:
                    return UnitToolsScientificElectricResistance.OhmToQuantumHallResistance(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric resistance unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricResistanceUnit.Microohm:
                    return "µΩ";
                case UnitToolsElectricResistanceUnit.Milliohm:
                    return "mΩ";
                case UnitToolsElectricResistanceUnit.Ohm:
                    return "Ω";
                case UnitToolsElectricResistanceUnit.Kiloohm:
                    return "kΩ";
                case UnitToolsElectricResistanceUnit.Megaohm:
                    return "MΩ";
                case UnitToolsElectricResistanceUnit.Gigaohm:
                    return "GΩ";
                case UnitToolsElectricResistanceUnit.Statohm:
                    return "statΩ";
                case UnitToolsElectricResistanceUnit.Picoohm:
                    return "pΩ";
                case UnitToolsElectricResistanceUnit.Nanoohm:
                    return "nΩ";
                case UnitToolsElectricResistanceUnit.Teraohm:
                    return "TΩ";
                case UnitToolsElectricResistanceUnit.Petaohm:
                    return "PΩ";
                case UnitToolsElectricResistanceUnit.Abohm:
                    return "abΩ";
                case UnitToolsElectricResistanceUnit.QuantumHallResistance:
                    return "Rᴋ";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricResistanceUnit.Microohm:
                    return "microohm";
                case UnitToolsElectricResistanceUnit.Milliohm:
                    return "milliohm";
                case UnitToolsElectricResistanceUnit.Ohm:
                    return "ohm";
                case UnitToolsElectricResistanceUnit.Kiloohm:
                    return "kiloohm";
                case UnitToolsElectricResistanceUnit.Megaohm:
                    return "megaohm";
                case UnitToolsElectricResistanceUnit.Gigaohm:
                    return "gigaohm";
                case UnitToolsElectricResistanceUnit.Statohm:
                    return "statohm";
                case UnitToolsElectricResistanceUnit.Picoohm:
                    return "Picoohm";
                case UnitToolsElectricResistanceUnit.Nanoohm:
                    return "Nanoohm";
                case UnitToolsElectricResistanceUnit.Teraohm:
                    return "Teraohm";
                case UnitToolsElectricResistanceUnit.Petaohm:
                    return "Petaohm";
                case UnitToolsElectricResistanceUnit.Abohm:
                    return "Abohm";
                case UnitToolsElectricResistanceUnit.QuantumHallResistance:
                    return "Quantum Hall Resistance";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricResistanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricResistanceUnit.Microohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Milliohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Ohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Kiloohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Megaohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Gigaohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Statohm:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricResistanceUnit.Picoohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Nanoohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Teraohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Petaohm:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricResistanceUnit.Abohm:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricResistanceUnit.QuantumHallResistance:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricResistanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricResistanceUnit.Microohm, UnitToolsElectricResistanceUnit.Milliohm, UnitToolsElectricResistanceUnit.Ohm, UnitToolsElectricResistanceUnit.Kiloohm, UnitToolsElectricResistanceUnit.Megaohm, UnitToolsElectricResistanceUnit.Gigaohm, UnitToolsElectricResistanceUnit.Picoohm, UnitToolsElectricResistanceUnit.Nanoohm, UnitToolsElectricResistanceUnit.Teraohm, UnitToolsElectricResistanceUnit.Petaohm };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricResistanceUnit.Statohm, UnitToolsElectricResistanceUnit.Abohm, UnitToolsElectricResistanceUnit.QuantumHallResistance };
                default:
                    return new[] { UnitToolsElectricResistanceUnit.Microohm, UnitToolsElectricResistanceUnit.Milliohm, UnitToolsElectricResistanceUnit.Ohm, UnitToolsElectricResistanceUnit.Kiloohm, UnitToolsElectricResistanceUnit.Megaohm, UnitToolsElectricResistanceUnit.Gigaohm, UnitToolsElectricResistanceUnit.Statohm, UnitToolsElectricResistanceUnit.Picoohm, UnitToolsElectricResistanceUnit.Nanoohm, UnitToolsElectricResistanceUnit.Teraohm, UnitToolsElectricResistanceUnit.Petaohm, UnitToolsElectricResistanceUnit.Abohm, UnitToolsElectricResistanceUnit.QuantumHallResistance };
            }
        }
    }
}
