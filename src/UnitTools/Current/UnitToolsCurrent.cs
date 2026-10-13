namespace UnitTools.Current
{
    using UnitTools.Current.Metric;
    using UnitTools.Current.Scientific;

    public enum UnitToolsCurrentUnit
    {
        Nanoampere = 0,
        Microampere = 1,
        Milliampere = 2,
        Ampere = 3,
        Kiloampere = 4,
        Megaampere = 5,
        Statampere = 6,
        Femtoampere = 7,
        Picoampere = 8,
        Teraampere = 9,
        Petaampere = 10,
        Abampere = 11,
        Biot = 12,
    }

    public static class UnitToolsCurrent
    {
        public static double Convert(double value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            double baseValue = ToAmpere(value, from);
            return FromAmpere(baseValue, to);
        }

        public static double ToAmpere(double value, UnitToolsCurrentUnit from)
        {
            switch (from)
            {
                case UnitToolsCurrentUnit.Nanoampere:
                    return UnitToolsMetricCurrent.NanoampereToAmpere(value);
                case UnitToolsCurrentUnit.Microampere:
                    return UnitToolsMetricCurrent.MicroampereToAmpere(value);
                case UnitToolsCurrentUnit.Milliampere:
                    return UnitToolsMetricCurrent.MilliampereToAmpere(value);
                case UnitToolsCurrentUnit.Ampere:
                    return UnitToolsMetricCurrent.AmpereToAmpere(value);
                case UnitToolsCurrentUnit.Kiloampere:
                    return UnitToolsMetricCurrent.KiloampereToAmpere(value);
                case UnitToolsCurrentUnit.Megaampere:
                    return UnitToolsMetricCurrent.MegaampereToAmpere(value);
                case UnitToolsCurrentUnit.Statampere:
                    return UnitToolsScientificCurrent.StatampereToAmpere(value);
                case UnitToolsCurrentUnit.Femtoampere:
                    return UnitToolsMetricCurrent.FemtoampereToAmpere(value);
                case UnitToolsCurrentUnit.Picoampere:
                    return UnitToolsMetricCurrent.PicoampereToAmpere(value);
                case UnitToolsCurrentUnit.Teraampere:
                    return UnitToolsMetricCurrent.TeraampereToAmpere(value);
                case UnitToolsCurrentUnit.Petaampere:
                    return UnitToolsMetricCurrent.PetaampereToAmpere(value);
                case UnitToolsCurrentUnit.Abampere:
                    return UnitToolsScientificCurrent.AbampereToAmpere(value);
                case UnitToolsCurrentUnit.Biot:
                    return UnitToolsScientificCurrent.BiotToAmpere(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported current unit.");
            }
        }

        public static double FromAmpere(double baseValue, UnitToolsCurrentUnit to)
        {
            switch (to)
            {
                case UnitToolsCurrentUnit.Nanoampere:
                    return UnitToolsMetricCurrent.AmpereToNanoampere(baseValue);
                case UnitToolsCurrentUnit.Microampere:
                    return UnitToolsMetricCurrent.AmpereToMicroampere(baseValue);
                case UnitToolsCurrentUnit.Milliampere:
                    return UnitToolsMetricCurrent.AmpereToMilliampere(baseValue);
                case UnitToolsCurrentUnit.Ampere:
                    return UnitToolsMetricCurrent.AmpereToAmpere(baseValue);
                case UnitToolsCurrentUnit.Kiloampere:
                    return UnitToolsMetricCurrent.AmpereToKiloampere(baseValue);
                case UnitToolsCurrentUnit.Megaampere:
                    return UnitToolsMetricCurrent.AmpereToMegaampere(baseValue);
                case UnitToolsCurrentUnit.Statampere:
                    return UnitToolsScientificCurrent.AmpereToStatampere(baseValue);
                case UnitToolsCurrentUnit.Femtoampere:
                    return UnitToolsMetricCurrent.AmpereToFemtoampere(baseValue);
                case UnitToolsCurrentUnit.Picoampere:
                    return UnitToolsMetricCurrent.AmpereToPicoampere(baseValue);
                case UnitToolsCurrentUnit.Teraampere:
                    return UnitToolsMetricCurrent.AmpereToTeraampere(baseValue);
                case UnitToolsCurrentUnit.Petaampere:
                    return UnitToolsMetricCurrent.AmpereToPetaampere(baseValue);
                case UnitToolsCurrentUnit.Abampere:
                    return UnitToolsScientificCurrent.AmpereToAbampere(baseValue);
                case UnitToolsCurrentUnit.Biot:
                    return UnitToolsScientificCurrent.AmpereToBiot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported current unit.");
            }
        }

        public static string GetSymbol(UnitToolsCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentUnit.Nanoampere:
                    return "nA";
                case UnitToolsCurrentUnit.Microampere:
                    return "µA";
                case UnitToolsCurrentUnit.Milliampere:
                    return "mA";
                case UnitToolsCurrentUnit.Ampere:
                    return "A";
                case UnitToolsCurrentUnit.Kiloampere:
                    return "kA";
                case UnitToolsCurrentUnit.Megaampere:
                    return "MA";
                case UnitToolsCurrentUnit.Statampere:
                    return "statA";
                case UnitToolsCurrentUnit.Femtoampere:
                    return "fA";
                case UnitToolsCurrentUnit.Picoampere:
                    return "pA";
                case UnitToolsCurrentUnit.Teraampere:
                    return "TA";
                case UnitToolsCurrentUnit.Petaampere:
                    return "PA";
                case UnitToolsCurrentUnit.Abampere:
                    return "abA";
                case UnitToolsCurrentUnit.Biot:
                    return "Bi";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentUnit.Nanoampere:
                    return "nanoampere";
                case UnitToolsCurrentUnit.Microampere:
                    return "microampere";
                case UnitToolsCurrentUnit.Milliampere:
                    return "milliampere";
                case UnitToolsCurrentUnit.Ampere:
                    return "ampere";
                case UnitToolsCurrentUnit.Kiloampere:
                    return "kiloampere";
                case UnitToolsCurrentUnit.Megaampere:
                    return "megaampere";
                case UnitToolsCurrentUnit.Statampere:
                    return "statampere";
                case UnitToolsCurrentUnit.Femtoampere:
                    return "Femtoampere";
                case UnitToolsCurrentUnit.Picoampere:
                    return "Picoampere";
                case UnitToolsCurrentUnit.Teraampere:
                    return "Teraampere";
                case UnitToolsCurrentUnit.Petaampere:
                    return "Petaampere";
                case UnitToolsCurrentUnit.Abampere:
                    return "Abampere";
                case UnitToolsCurrentUnit.Biot:
                    return "Biot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentUnit.Nanoampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Microampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Milliampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Ampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Kiloampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Megaampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Statampere:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsCurrentUnit.Femtoampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Picoampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Teraampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Petaampere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentUnit.Abampere:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsCurrentUnit.Biot:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsCurrentUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsCurrentUnit.Nanoampere, UnitToolsCurrentUnit.Microampere, UnitToolsCurrentUnit.Milliampere, UnitToolsCurrentUnit.Ampere, UnitToolsCurrentUnit.Kiloampere, UnitToolsCurrentUnit.Megaampere, UnitToolsCurrentUnit.Femtoampere, UnitToolsCurrentUnit.Picoampere, UnitToolsCurrentUnit.Teraampere, UnitToolsCurrentUnit.Petaampere };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsCurrentUnit.Statampere, UnitToolsCurrentUnit.Abampere, UnitToolsCurrentUnit.Biot };
                default:
                    return new[] { UnitToolsCurrentUnit.Nanoampere, UnitToolsCurrentUnit.Microampere, UnitToolsCurrentUnit.Milliampere, UnitToolsCurrentUnit.Ampere, UnitToolsCurrentUnit.Kiloampere, UnitToolsCurrentUnit.Megaampere, UnitToolsCurrentUnit.Statampere, UnitToolsCurrentUnit.Femtoampere, UnitToolsCurrentUnit.Picoampere, UnitToolsCurrentUnit.Teraampere, UnitToolsCurrentUnit.Petaampere, UnitToolsCurrentUnit.Abampere, UnitToolsCurrentUnit.Biot };
            }
        }
    }
}
