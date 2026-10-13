namespace UnitTools.Conductance
{
    using UnitTools.Conductance.Metric;
    using UnitTools.Conductance.Engineering;
    using UnitTools.Conductance.Scientific;

    public enum UnitToolsConductanceUnit
    {
        Nanosiemens = 0,
        Microsiemens = 1,
        Millisiemens = 2,
        Siemens = 3,
        Kilosiemens = 4,
        Mho = 5,
        Femtosiemens = 6,
        Picosiemens = 7,
        Megasiemens = 8,
        Gigasiemens = 9,
        Abmho = 10,
        Centisiemens = 11,
        Decisiemens = 12,
        Decasiemens = 13,
        Hectosiemens = 14,
        Statmho = 15,
    }

    public static class UnitToolsConductance
    {
        public static double Convert(double value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            double baseValue = ToSiemens(value, from);
            return FromSiemens(baseValue, to);
        }

        public static double ToSiemens(double value, UnitToolsConductanceUnit from)
        {
            switch (from)
            {
                case UnitToolsConductanceUnit.Nanosiemens:
                    return UnitToolsMetricConductance.NanosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Microsiemens:
                    return UnitToolsMetricConductance.MicrosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Millisiemens:
                    return UnitToolsMetricConductance.MillisiemensToSiemens(value);
                case UnitToolsConductanceUnit.Siemens:
                    return UnitToolsMetricConductance.SiemensToSiemens(value);
                case UnitToolsConductanceUnit.Kilosiemens:
                    return UnitToolsMetricConductance.KilosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Mho:
                    return UnitToolsEngineeringConductance.MhoToSiemens(value);
                case UnitToolsConductanceUnit.Femtosiemens:
                    return UnitToolsMetricConductance.FemtosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Picosiemens:
                    return UnitToolsMetricConductance.PicosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Megasiemens:
                    return UnitToolsMetricConductance.MegasiemensToSiemens(value);
                case UnitToolsConductanceUnit.Gigasiemens:
                    return UnitToolsMetricConductance.GigasiemensToSiemens(value);
                case UnitToolsConductanceUnit.Abmho:
                    return UnitToolsScientificConductance.AbmhoToSiemens(value);
                case UnitToolsConductanceUnit.Centisiemens:
                    return UnitToolsMetricConductance.CentisiemensToSiemens(value);
                case UnitToolsConductanceUnit.Decisiemens:
                    return UnitToolsMetricConductance.DecisiemensToSiemens(value);
                case UnitToolsConductanceUnit.Decasiemens:
                    return UnitToolsMetricConductance.DecasiemensToSiemens(value);
                case UnitToolsConductanceUnit.Hectosiemens:
                    return UnitToolsMetricConductance.HectosiemensToSiemens(value);
                case UnitToolsConductanceUnit.Statmho:
                    return UnitToolsScientificConductance.StatmhoToSiemens(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported conductance unit.");
            }
        }

        public static double FromSiemens(double baseValue, UnitToolsConductanceUnit to)
        {
            switch (to)
            {
                case UnitToolsConductanceUnit.Nanosiemens:
                    return UnitToolsMetricConductance.SiemensToNanosiemens(baseValue);
                case UnitToolsConductanceUnit.Microsiemens:
                    return UnitToolsMetricConductance.SiemensToMicrosiemens(baseValue);
                case UnitToolsConductanceUnit.Millisiemens:
                    return UnitToolsMetricConductance.SiemensToMillisiemens(baseValue);
                case UnitToolsConductanceUnit.Siemens:
                    return UnitToolsMetricConductance.SiemensToSiemens(baseValue);
                case UnitToolsConductanceUnit.Kilosiemens:
                    return UnitToolsMetricConductance.SiemensToKilosiemens(baseValue);
                case UnitToolsConductanceUnit.Mho:
                    return UnitToolsEngineeringConductance.SiemensToMho(baseValue);
                case UnitToolsConductanceUnit.Femtosiemens:
                    return UnitToolsMetricConductance.SiemensToFemtosiemens(baseValue);
                case UnitToolsConductanceUnit.Picosiemens:
                    return UnitToolsMetricConductance.SiemensToPicosiemens(baseValue);
                case UnitToolsConductanceUnit.Megasiemens:
                    return UnitToolsMetricConductance.SiemensToMegasiemens(baseValue);
                case UnitToolsConductanceUnit.Gigasiemens:
                    return UnitToolsMetricConductance.SiemensToGigasiemens(baseValue);
                case UnitToolsConductanceUnit.Abmho:
                    return UnitToolsScientificConductance.SiemensToAbmho(baseValue);
                case UnitToolsConductanceUnit.Centisiemens:
                    return UnitToolsMetricConductance.SiemensToCentisiemens(baseValue);
                case UnitToolsConductanceUnit.Decisiemens:
                    return UnitToolsMetricConductance.SiemensToDecisiemens(baseValue);
                case UnitToolsConductanceUnit.Decasiemens:
                    return UnitToolsMetricConductance.SiemensToDecasiemens(baseValue);
                case UnitToolsConductanceUnit.Hectosiemens:
                    return UnitToolsMetricConductance.SiemensToHectosiemens(baseValue);
                case UnitToolsConductanceUnit.Statmho:
                    return UnitToolsScientificConductance.SiemensToStatmho(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported conductance unit.");
            }
        }

        public static string GetSymbol(UnitToolsConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsConductanceUnit.Nanosiemens:
                    return "nS";
                case UnitToolsConductanceUnit.Microsiemens:
                    return "µS";
                case UnitToolsConductanceUnit.Millisiemens:
                    return "mS";
                case UnitToolsConductanceUnit.Siemens:
                    return "S";
                case UnitToolsConductanceUnit.Kilosiemens:
                    return "kS";
                case UnitToolsConductanceUnit.Mho:
                    return "℧";
                case UnitToolsConductanceUnit.Femtosiemens:
                    return "fS";
                case UnitToolsConductanceUnit.Picosiemens:
                    return "pS";
                case UnitToolsConductanceUnit.Megasiemens:
                    return "MS";
                case UnitToolsConductanceUnit.Gigasiemens:
                    return "GS";
                case UnitToolsConductanceUnit.Abmho:
                    return "abmho";
                case UnitToolsConductanceUnit.Centisiemens:
                    return "cS";
                case UnitToolsConductanceUnit.Decisiemens:
                    return "dS";
                case UnitToolsConductanceUnit.Decasiemens:
                    return "daS";
                case UnitToolsConductanceUnit.Hectosiemens:
                    return "hS";
                case UnitToolsConductanceUnit.Statmho:
                    return "statmho";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsConductanceUnit.Nanosiemens:
                    return "nanosiemens";
                case UnitToolsConductanceUnit.Microsiemens:
                    return "microsiemens";
                case UnitToolsConductanceUnit.Millisiemens:
                    return "millisiemens";
                case UnitToolsConductanceUnit.Siemens:
                    return "siemens";
                case UnitToolsConductanceUnit.Kilosiemens:
                    return "kilosiemens";
                case UnitToolsConductanceUnit.Mho:
                    return "mho";
                case UnitToolsConductanceUnit.Femtosiemens:
                    return "Femtosiemens";
                case UnitToolsConductanceUnit.Picosiemens:
                    return "Picosiemens";
                case UnitToolsConductanceUnit.Megasiemens:
                    return "Megasiemens";
                case UnitToolsConductanceUnit.Gigasiemens:
                    return "Gigasiemens";
                case UnitToolsConductanceUnit.Abmho:
                    return "Abmho";
                case UnitToolsConductanceUnit.Centisiemens:
                    return "Centisiemens";
                case UnitToolsConductanceUnit.Decisiemens:
                    return "Decisiemens";
                case UnitToolsConductanceUnit.Decasiemens:
                    return "Decasiemens";
                case UnitToolsConductanceUnit.Hectosiemens:
                    return "Hectosiemens";
                case UnitToolsConductanceUnit.Statmho:
                    return "Statmho";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsConductanceUnit.Nanosiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Microsiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Millisiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Siemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Kilosiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Mho:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsConductanceUnit.Femtosiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Picosiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Megasiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Gigasiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Abmho:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsConductanceUnit.Centisiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Decisiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Decasiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Hectosiemens:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsConductanceUnit.Statmho:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsConductanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsConductanceUnit.Nanosiemens, UnitToolsConductanceUnit.Microsiemens, UnitToolsConductanceUnit.Millisiemens, UnitToolsConductanceUnit.Siemens, UnitToolsConductanceUnit.Kilosiemens, UnitToolsConductanceUnit.Femtosiemens, UnitToolsConductanceUnit.Picosiemens, UnitToolsConductanceUnit.Megasiemens, UnitToolsConductanceUnit.Gigasiemens, UnitToolsConductanceUnit.Centisiemens, UnitToolsConductanceUnit.Decisiemens, UnitToolsConductanceUnit.Decasiemens, UnitToolsConductanceUnit.Hectosiemens };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsConductanceUnit.Mho };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsConductanceUnit.Abmho, UnitToolsConductanceUnit.Statmho };
                default:
                    return new[] { UnitToolsConductanceUnit.Nanosiemens, UnitToolsConductanceUnit.Microsiemens, UnitToolsConductanceUnit.Millisiemens, UnitToolsConductanceUnit.Siemens, UnitToolsConductanceUnit.Kilosiemens, UnitToolsConductanceUnit.Mho, UnitToolsConductanceUnit.Femtosiemens, UnitToolsConductanceUnit.Picosiemens, UnitToolsConductanceUnit.Megasiemens, UnitToolsConductanceUnit.Gigasiemens, UnitToolsConductanceUnit.Abmho, UnitToolsConductanceUnit.Centisiemens, UnitToolsConductanceUnit.Decisiemens, UnitToolsConductanceUnit.Decasiemens, UnitToolsConductanceUnit.Hectosiemens, UnitToolsConductanceUnit.Statmho };
            }
        }
    }
}
