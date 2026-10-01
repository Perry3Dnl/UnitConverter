namespace UnitConverter.Conductance
{
    using UnitConverter.Conductance.Metric;
    using UnitConverter.Conductance.Engineering;
    using UnitConverter.Conductance.Scientific;

    public enum UnitConverterConductanceUnit
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

    public static class UnitConverterConductance
    {
        public static double Convert(double value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            double baseValue = ToSiemens(value, from);
            return FromSiemens(baseValue, to);
        }

        public static double ToSiemens(double value, UnitConverterConductanceUnit from)
        {
            switch (from)
            {
                case UnitConverterConductanceUnit.Nanosiemens:
                    return UnitConverterMetricConductance.NanosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Microsiemens:
                    return UnitConverterMetricConductance.MicrosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Millisiemens:
                    return UnitConverterMetricConductance.MillisiemensToSiemens(value);
                case UnitConverterConductanceUnit.Siemens:
                    return UnitConverterMetricConductance.SiemensToSiemens(value);
                case UnitConverterConductanceUnit.Kilosiemens:
                    return UnitConverterMetricConductance.KilosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Mho:
                    return UnitConverterEngineeringConductance.MhoToSiemens(value);
                case UnitConverterConductanceUnit.Femtosiemens:
                    return UnitConverterMetricConductance.FemtosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Picosiemens:
                    return UnitConverterMetricConductance.PicosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Megasiemens:
                    return UnitConverterMetricConductance.MegasiemensToSiemens(value);
                case UnitConverterConductanceUnit.Gigasiemens:
                    return UnitConverterMetricConductance.GigasiemensToSiemens(value);
                case UnitConverterConductanceUnit.Abmho:
                    return UnitConverterScientificConductance.AbmhoToSiemens(value);
                case UnitConverterConductanceUnit.Centisiemens:
                    return UnitConverterMetricConductance.CentisiemensToSiemens(value);
                case UnitConverterConductanceUnit.Decisiemens:
                    return UnitConverterMetricConductance.DecisiemensToSiemens(value);
                case UnitConverterConductanceUnit.Decasiemens:
                    return UnitConverterMetricConductance.DecasiemensToSiemens(value);
                case UnitConverterConductanceUnit.Hectosiemens:
                    return UnitConverterMetricConductance.HectosiemensToSiemens(value);
                case UnitConverterConductanceUnit.Statmho:
                    return UnitConverterScientificConductance.StatmhoToSiemens(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported conductance unit.");
            }
        }

        public static double FromSiemens(double baseValue, UnitConverterConductanceUnit to)
        {
            switch (to)
            {
                case UnitConverterConductanceUnit.Nanosiemens:
                    return UnitConverterMetricConductance.SiemensToNanosiemens(baseValue);
                case UnitConverterConductanceUnit.Microsiemens:
                    return UnitConverterMetricConductance.SiemensToMicrosiemens(baseValue);
                case UnitConverterConductanceUnit.Millisiemens:
                    return UnitConverterMetricConductance.SiemensToMillisiemens(baseValue);
                case UnitConverterConductanceUnit.Siemens:
                    return UnitConverterMetricConductance.SiemensToSiemens(baseValue);
                case UnitConverterConductanceUnit.Kilosiemens:
                    return UnitConverterMetricConductance.SiemensToKilosiemens(baseValue);
                case UnitConverterConductanceUnit.Mho:
                    return UnitConverterEngineeringConductance.SiemensToMho(baseValue);
                case UnitConverterConductanceUnit.Femtosiemens:
                    return UnitConverterMetricConductance.SiemensToFemtosiemens(baseValue);
                case UnitConverterConductanceUnit.Picosiemens:
                    return UnitConverterMetricConductance.SiemensToPicosiemens(baseValue);
                case UnitConverterConductanceUnit.Megasiemens:
                    return UnitConverterMetricConductance.SiemensToMegasiemens(baseValue);
                case UnitConverterConductanceUnit.Gigasiemens:
                    return UnitConverterMetricConductance.SiemensToGigasiemens(baseValue);
                case UnitConverterConductanceUnit.Abmho:
                    return UnitConverterScientificConductance.SiemensToAbmho(baseValue);
                case UnitConverterConductanceUnit.Centisiemens:
                    return UnitConverterMetricConductance.SiemensToCentisiemens(baseValue);
                case UnitConverterConductanceUnit.Decisiemens:
                    return UnitConverterMetricConductance.SiemensToDecisiemens(baseValue);
                case UnitConverterConductanceUnit.Decasiemens:
                    return UnitConverterMetricConductance.SiemensToDecasiemens(baseValue);
                case UnitConverterConductanceUnit.Hectosiemens:
                    return UnitConverterMetricConductance.SiemensToHectosiemens(baseValue);
                case UnitConverterConductanceUnit.Statmho:
                    return UnitConverterScientificConductance.SiemensToStatmho(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported conductance unit.");
            }
        }

        public static string GetSymbol(UnitConverterConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterConductanceUnit.Nanosiemens:
                    return "nS";
                case UnitConverterConductanceUnit.Microsiemens:
                    return "µS";
                case UnitConverterConductanceUnit.Millisiemens:
                    return "mS";
                case UnitConverterConductanceUnit.Siemens:
                    return "S";
                case UnitConverterConductanceUnit.Kilosiemens:
                    return "kS";
                case UnitConverterConductanceUnit.Mho:
                    return "℧";
                case UnitConverterConductanceUnit.Femtosiemens:
                    return "fS";
                case UnitConverterConductanceUnit.Picosiemens:
                    return "pS";
                case UnitConverterConductanceUnit.Megasiemens:
                    return "MS";
                case UnitConverterConductanceUnit.Gigasiemens:
                    return "GS";
                case UnitConverterConductanceUnit.Abmho:
                    return "abmho";
                case UnitConverterConductanceUnit.Centisiemens:
                    return "cS";
                case UnitConverterConductanceUnit.Decisiemens:
                    return "dS";
                case UnitConverterConductanceUnit.Decasiemens:
                    return "daS";
                case UnitConverterConductanceUnit.Hectosiemens:
                    return "hS";
                case UnitConverterConductanceUnit.Statmho:
                    return "statmho";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterConductanceUnit.Nanosiemens:
                    return "nanosiemens";
                case UnitConverterConductanceUnit.Microsiemens:
                    return "microsiemens";
                case UnitConverterConductanceUnit.Millisiemens:
                    return "millisiemens";
                case UnitConverterConductanceUnit.Siemens:
                    return "siemens";
                case UnitConverterConductanceUnit.Kilosiemens:
                    return "kilosiemens";
                case UnitConverterConductanceUnit.Mho:
                    return "mho";
                case UnitConverterConductanceUnit.Femtosiemens:
                    return "Femtosiemens";
                case UnitConverterConductanceUnit.Picosiemens:
                    return "Picosiemens";
                case UnitConverterConductanceUnit.Megasiemens:
                    return "Megasiemens";
                case UnitConverterConductanceUnit.Gigasiemens:
                    return "Gigasiemens";
                case UnitConverterConductanceUnit.Abmho:
                    return "Abmho";
                case UnitConverterConductanceUnit.Centisiemens:
                    return "Centisiemens";
                case UnitConverterConductanceUnit.Decisiemens:
                    return "Decisiemens";
                case UnitConverterConductanceUnit.Decasiemens:
                    return "Decasiemens";
                case UnitConverterConductanceUnit.Hectosiemens:
                    return "Hectosiemens";
                case UnitConverterConductanceUnit.Statmho:
                    return "Statmho";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterConductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterConductanceUnit.Nanosiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Microsiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Millisiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Siemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Kilosiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Mho:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterConductanceUnit.Femtosiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Picosiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Megasiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Gigasiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Abmho:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterConductanceUnit.Centisiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Decisiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Decasiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Hectosiemens:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterConductanceUnit.Statmho:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterConductanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterConductanceUnit.Nanosiemens, UnitConverterConductanceUnit.Microsiemens, UnitConverterConductanceUnit.Millisiemens, UnitConverterConductanceUnit.Siemens, UnitConverterConductanceUnit.Kilosiemens, UnitConverterConductanceUnit.Femtosiemens, UnitConverterConductanceUnit.Picosiemens, UnitConverterConductanceUnit.Megasiemens, UnitConverterConductanceUnit.Gigasiemens, UnitConverterConductanceUnit.Centisiemens, UnitConverterConductanceUnit.Decisiemens, UnitConverterConductanceUnit.Decasiemens, UnitConverterConductanceUnit.Hectosiemens };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterConductanceUnit.Mho };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterConductanceUnit.Abmho, UnitConverterConductanceUnit.Statmho };
                default:
                    return new[] { UnitConverterConductanceUnit.Nanosiemens, UnitConverterConductanceUnit.Microsiemens, UnitConverterConductanceUnit.Millisiemens, UnitConverterConductanceUnit.Siemens, UnitConverterConductanceUnit.Kilosiemens, UnitConverterConductanceUnit.Mho, UnitConverterConductanceUnit.Femtosiemens, UnitConverterConductanceUnit.Picosiemens, UnitConverterConductanceUnit.Megasiemens, UnitConverterConductanceUnit.Gigasiemens, UnitConverterConductanceUnit.Abmho, UnitConverterConductanceUnit.Centisiemens, UnitConverterConductanceUnit.Decisiemens, UnitConverterConductanceUnit.Decasiemens, UnitConverterConductanceUnit.Hectosiemens, UnitConverterConductanceUnit.Statmho };
            }
        }
    }
}
