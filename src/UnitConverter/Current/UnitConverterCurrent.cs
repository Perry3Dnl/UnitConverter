namespace UnitConverter.Current
{
    using UnitConverter.Current.Metric;
    using UnitConverter.Current.Scientific;

    public enum UnitConverterCurrentUnit
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

    public static class UnitConverterCurrent
    {
        public static double Convert(double value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            double baseValue = ToAmpere(value, from);
            return FromAmpere(baseValue, to);
        }

        public static double ToAmpere(double value, UnitConverterCurrentUnit from)
        {
            switch (from)
            {
                case UnitConverterCurrentUnit.Nanoampere:
                    return UnitConverterMetricCurrent.NanoampereToAmpere(value);
                case UnitConverterCurrentUnit.Microampere:
                    return UnitConverterMetricCurrent.MicroampereToAmpere(value);
                case UnitConverterCurrentUnit.Milliampere:
                    return UnitConverterMetricCurrent.MilliampereToAmpere(value);
                case UnitConverterCurrentUnit.Ampere:
                    return UnitConverterMetricCurrent.AmpereToAmpere(value);
                case UnitConverterCurrentUnit.Kiloampere:
                    return UnitConverterMetricCurrent.KiloampereToAmpere(value);
                case UnitConverterCurrentUnit.Megaampere:
                    return UnitConverterMetricCurrent.MegaampereToAmpere(value);
                case UnitConverterCurrentUnit.Statampere:
                    return UnitConverterScientificCurrent.StatampereToAmpere(value);
                case UnitConverterCurrentUnit.Femtoampere:
                    return UnitConverterMetricCurrent.FemtoampereToAmpere(value);
                case UnitConverterCurrentUnit.Picoampere:
                    return UnitConverterMetricCurrent.PicoampereToAmpere(value);
                case UnitConverterCurrentUnit.Teraampere:
                    return UnitConverterMetricCurrent.TeraampereToAmpere(value);
                case UnitConverterCurrentUnit.Petaampere:
                    return UnitConverterMetricCurrent.PetaampereToAmpere(value);
                case UnitConverterCurrentUnit.Abampere:
                    return UnitConverterScientificCurrent.AbampereToAmpere(value);
                case UnitConverterCurrentUnit.Biot:
                    return UnitConverterScientificCurrent.BiotToAmpere(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported current unit.");
            }
        }

        public static double FromAmpere(double baseValue, UnitConverterCurrentUnit to)
        {
            switch (to)
            {
                case UnitConverterCurrentUnit.Nanoampere:
                    return UnitConverterMetricCurrent.AmpereToNanoampere(baseValue);
                case UnitConverterCurrentUnit.Microampere:
                    return UnitConverterMetricCurrent.AmpereToMicroampere(baseValue);
                case UnitConverterCurrentUnit.Milliampere:
                    return UnitConverterMetricCurrent.AmpereToMilliampere(baseValue);
                case UnitConverterCurrentUnit.Ampere:
                    return UnitConverterMetricCurrent.AmpereToAmpere(baseValue);
                case UnitConverterCurrentUnit.Kiloampere:
                    return UnitConverterMetricCurrent.AmpereToKiloampere(baseValue);
                case UnitConverterCurrentUnit.Megaampere:
                    return UnitConverterMetricCurrent.AmpereToMegaampere(baseValue);
                case UnitConverterCurrentUnit.Statampere:
                    return UnitConverterScientificCurrent.AmpereToStatampere(baseValue);
                case UnitConverterCurrentUnit.Femtoampere:
                    return UnitConverterMetricCurrent.AmpereToFemtoampere(baseValue);
                case UnitConverterCurrentUnit.Picoampere:
                    return UnitConverterMetricCurrent.AmpereToPicoampere(baseValue);
                case UnitConverterCurrentUnit.Teraampere:
                    return UnitConverterMetricCurrent.AmpereToTeraampere(baseValue);
                case UnitConverterCurrentUnit.Petaampere:
                    return UnitConverterMetricCurrent.AmpereToPetaampere(baseValue);
                case UnitConverterCurrentUnit.Abampere:
                    return UnitConverterScientificCurrent.AmpereToAbampere(baseValue);
                case UnitConverterCurrentUnit.Biot:
                    return UnitConverterScientificCurrent.AmpereToBiot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported current unit.");
            }
        }

        public static string GetSymbol(UnitConverterCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentUnit.Nanoampere:
                    return "nA";
                case UnitConverterCurrentUnit.Microampere:
                    return "µA";
                case UnitConverterCurrentUnit.Milliampere:
                    return "mA";
                case UnitConverterCurrentUnit.Ampere:
                    return "A";
                case UnitConverterCurrentUnit.Kiloampere:
                    return "kA";
                case UnitConverterCurrentUnit.Megaampere:
                    return "MA";
                case UnitConverterCurrentUnit.Statampere:
                    return "statA";
                case UnitConverterCurrentUnit.Femtoampere:
                    return "fA";
                case UnitConverterCurrentUnit.Picoampere:
                    return "pA";
                case UnitConverterCurrentUnit.Teraampere:
                    return "TA";
                case UnitConverterCurrentUnit.Petaampere:
                    return "PA";
                case UnitConverterCurrentUnit.Abampere:
                    return "abA";
                case UnitConverterCurrentUnit.Biot:
                    return "Bi";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentUnit.Nanoampere:
                    return "nanoampere";
                case UnitConverterCurrentUnit.Microampere:
                    return "microampere";
                case UnitConverterCurrentUnit.Milliampere:
                    return "milliampere";
                case UnitConverterCurrentUnit.Ampere:
                    return "ampere";
                case UnitConverterCurrentUnit.Kiloampere:
                    return "kiloampere";
                case UnitConverterCurrentUnit.Megaampere:
                    return "megaampere";
                case UnitConverterCurrentUnit.Statampere:
                    return "statampere";
                case UnitConverterCurrentUnit.Femtoampere:
                    return "Femtoampere";
                case UnitConverterCurrentUnit.Picoampere:
                    return "Picoampere";
                case UnitConverterCurrentUnit.Teraampere:
                    return "Teraampere";
                case UnitConverterCurrentUnit.Petaampere:
                    return "Petaampere";
                case UnitConverterCurrentUnit.Abampere:
                    return "Abampere";
                case UnitConverterCurrentUnit.Biot:
                    return "Biot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterCurrentUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentUnit.Nanoampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Microampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Milliampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Ampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Kiloampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Megaampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Statampere:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterCurrentUnit.Femtoampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Picoampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Teraampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Petaampere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentUnit.Abampere:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterCurrentUnit.Biot:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterCurrentUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterCurrentUnit.Nanoampere, UnitConverterCurrentUnit.Microampere, UnitConverterCurrentUnit.Milliampere, UnitConverterCurrentUnit.Ampere, UnitConverterCurrentUnit.Kiloampere, UnitConverterCurrentUnit.Megaampere, UnitConverterCurrentUnit.Femtoampere, UnitConverterCurrentUnit.Picoampere, UnitConverterCurrentUnit.Teraampere, UnitConverterCurrentUnit.Petaampere };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterCurrentUnit.Statampere, UnitConverterCurrentUnit.Abampere, UnitConverterCurrentUnit.Biot };
                default:
                    return new[] { UnitConverterCurrentUnit.Nanoampere, UnitConverterCurrentUnit.Microampere, UnitConverterCurrentUnit.Milliampere, UnitConverterCurrentUnit.Ampere, UnitConverterCurrentUnit.Kiloampere, UnitConverterCurrentUnit.Megaampere, UnitConverterCurrentUnit.Statampere, UnitConverterCurrentUnit.Femtoampere, UnitConverterCurrentUnit.Picoampere, UnitConverterCurrentUnit.Teraampere, UnitConverterCurrentUnit.Petaampere, UnitConverterCurrentUnit.Abampere, UnitConverterCurrentUnit.Biot };
            }
        }
    }
}
