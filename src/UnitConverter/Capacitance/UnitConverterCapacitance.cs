namespace UnitConverter.Capacitance
{
    using UnitConverter.Capacitance.Metric;
    using UnitConverter.Capacitance.Scientific;

    public enum UnitConverterCapacitanceUnit
    {
        Picofarad = 0,
        Nanofarad = 1,
        Microfarad = 2,
        Millifarad = 3,
        Farad = 4,
        Kilofarad = 5,
        Attofarad = 6,
        Femtofarad = 7,
        Megafarad = 8,
        Gigafarad = 9,
        Abfarad = 10,
        Statfarad = 11,
        MicrofaradPerVoltEquivalent = 12,
        Centifarad = 13,
        Decifarad = 14,
        Decafarad = 15,
        Hectofarad = 16,
    }

    public static class UnitConverterCapacitance
    {
        public static double Convert(double value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            double baseValue = ToFarad(value, from);
            return FromFarad(baseValue, to);
        }

        public static double ToFarad(double value, UnitConverterCapacitanceUnit from)
        {
            switch (from)
            {
                case UnitConverterCapacitanceUnit.Picofarad:
                    return UnitConverterMetricCapacitance.PicofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Nanofarad:
                    return UnitConverterMetricCapacitance.NanofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Microfarad:
                    return UnitConverterMetricCapacitance.MicrofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Millifarad:
                    return UnitConverterMetricCapacitance.MillifaradToFarad(value);
                case UnitConverterCapacitanceUnit.Farad:
                    return UnitConverterMetricCapacitance.FaradToFarad(value);
                case UnitConverterCapacitanceUnit.Kilofarad:
                    return UnitConverterMetricCapacitance.KilofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Attofarad:
                    return UnitConverterMetricCapacitance.AttofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Femtofarad:
                    return UnitConverterMetricCapacitance.FemtofaradToFarad(value);
                case UnitConverterCapacitanceUnit.Megafarad:
                    return UnitConverterMetricCapacitance.MegafaradToFarad(value);
                case UnitConverterCapacitanceUnit.Gigafarad:
                    return UnitConverterMetricCapacitance.GigafaradToFarad(value);
                case UnitConverterCapacitanceUnit.Abfarad:
                    return UnitConverterScientificCapacitance.AbfaradToFarad(value);
                case UnitConverterCapacitanceUnit.Statfarad:
                    return UnitConverterScientificCapacitance.StatfaradToFarad(value);
                case UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitConverterMetricCapacitance.MicrofaradPerVoltEquivalentToFarad(value);
                case UnitConverterCapacitanceUnit.Centifarad:
                    return UnitConverterMetricCapacitance.CentifaradToFarad(value);
                case UnitConverterCapacitanceUnit.Decifarad:
                    return UnitConverterMetricCapacitance.DecifaradToFarad(value);
                case UnitConverterCapacitanceUnit.Decafarad:
                    return UnitConverterMetricCapacitance.DecafaradToFarad(value);
                case UnitConverterCapacitanceUnit.Hectofarad:
                    return UnitConverterMetricCapacitance.HectofaradToFarad(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported capacitance unit.");
            }
        }

        public static double FromFarad(double baseValue, UnitConverterCapacitanceUnit to)
        {
            switch (to)
            {
                case UnitConverterCapacitanceUnit.Picofarad:
                    return UnitConverterMetricCapacitance.FaradToPicofarad(baseValue);
                case UnitConverterCapacitanceUnit.Nanofarad:
                    return UnitConverterMetricCapacitance.FaradToNanofarad(baseValue);
                case UnitConverterCapacitanceUnit.Microfarad:
                    return UnitConverterMetricCapacitance.FaradToMicrofarad(baseValue);
                case UnitConverterCapacitanceUnit.Millifarad:
                    return UnitConverterMetricCapacitance.FaradToMillifarad(baseValue);
                case UnitConverterCapacitanceUnit.Farad:
                    return UnitConverterMetricCapacitance.FaradToFarad(baseValue);
                case UnitConverterCapacitanceUnit.Kilofarad:
                    return UnitConverterMetricCapacitance.FaradToKilofarad(baseValue);
                case UnitConverterCapacitanceUnit.Attofarad:
                    return UnitConverterMetricCapacitance.FaradToAttofarad(baseValue);
                case UnitConverterCapacitanceUnit.Femtofarad:
                    return UnitConverterMetricCapacitance.FaradToFemtofarad(baseValue);
                case UnitConverterCapacitanceUnit.Megafarad:
                    return UnitConverterMetricCapacitance.FaradToMegafarad(baseValue);
                case UnitConverterCapacitanceUnit.Gigafarad:
                    return UnitConverterMetricCapacitance.FaradToGigafarad(baseValue);
                case UnitConverterCapacitanceUnit.Abfarad:
                    return UnitConverterScientificCapacitance.FaradToAbfarad(baseValue);
                case UnitConverterCapacitanceUnit.Statfarad:
                    return UnitConverterScientificCapacitance.FaradToStatfarad(baseValue);
                case UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitConverterMetricCapacitance.FaradToMicrofaradPerVoltEquivalent(baseValue);
                case UnitConverterCapacitanceUnit.Centifarad:
                    return UnitConverterMetricCapacitance.FaradToCentifarad(baseValue);
                case UnitConverterCapacitanceUnit.Decifarad:
                    return UnitConverterMetricCapacitance.FaradToDecifarad(baseValue);
                case UnitConverterCapacitanceUnit.Decafarad:
                    return UnitConverterMetricCapacitance.FaradToDecafarad(baseValue);
                case UnitConverterCapacitanceUnit.Hectofarad:
                    return UnitConverterMetricCapacitance.FaradToHectofarad(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported capacitance unit.");
            }
        }

        public static string GetSymbol(UnitConverterCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCapacitanceUnit.Picofarad:
                    return "pF";
                case UnitConverterCapacitanceUnit.Nanofarad:
                    return "nF";
                case UnitConverterCapacitanceUnit.Microfarad:
                    return "µF";
                case UnitConverterCapacitanceUnit.Millifarad:
                    return "mF";
                case UnitConverterCapacitanceUnit.Farad:
                    return "F";
                case UnitConverterCapacitanceUnit.Kilofarad:
                    return "kF";
                case UnitConverterCapacitanceUnit.Attofarad:
                    return "aF";
                case UnitConverterCapacitanceUnit.Femtofarad:
                    return "fF";
                case UnitConverterCapacitanceUnit.Megafarad:
                    return "MF";
                case UnitConverterCapacitanceUnit.Gigafarad:
                    return "GF";
                case UnitConverterCapacitanceUnit.Abfarad:
                    return "abF";
                case UnitConverterCapacitanceUnit.Statfarad:
                    return "statF";
                case UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return "µF eq";
                case UnitConverterCapacitanceUnit.Centifarad:
                    return "cF";
                case UnitConverterCapacitanceUnit.Decifarad:
                    return "dF";
                case UnitConverterCapacitanceUnit.Decafarad:
                    return "daF";
                case UnitConverterCapacitanceUnit.Hectofarad:
                    return "hF";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCapacitanceUnit.Picofarad:
                    return "picofarad";
                case UnitConverterCapacitanceUnit.Nanofarad:
                    return "nanofarad";
                case UnitConverterCapacitanceUnit.Microfarad:
                    return "microfarad";
                case UnitConverterCapacitanceUnit.Millifarad:
                    return "millifarad";
                case UnitConverterCapacitanceUnit.Farad:
                    return "farad";
                case UnitConverterCapacitanceUnit.Kilofarad:
                    return "kilofarad";
                case UnitConverterCapacitanceUnit.Attofarad:
                    return "Attofarad";
                case UnitConverterCapacitanceUnit.Femtofarad:
                    return "Femtofarad";
                case UnitConverterCapacitanceUnit.Megafarad:
                    return "Megafarad";
                case UnitConverterCapacitanceUnit.Gigafarad:
                    return "Gigafarad";
                case UnitConverterCapacitanceUnit.Abfarad:
                    return "Abfarad";
                case UnitConverterCapacitanceUnit.Statfarad:
                    return "Statfarad";
                case UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return "Microfarad Per Volt Equivalent";
                case UnitConverterCapacitanceUnit.Centifarad:
                    return "Centifarad";
                case UnitConverterCapacitanceUnit.Decifarad:
                    return "Decifarad";
                case UnitConverterCapacitanceUnit.Decafarad:
                    return "Decafarad";
                case UnitConverterCapacitanceUnit.Hectofarad:
                    return "Hectofarad";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCapacitanceUnit.Picofarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Nanofarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Microfarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Millifarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Farad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Kilofarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Attofarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Femtofarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Megafarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Gigafarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Abfarad:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterCapacitanceUnit.Statfarad:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Centifarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Decifarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Decafarad:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCapacitanceUnit.Hectofarad:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterCapacitanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterCapacitanceUnit.Picofarad, UnitConverterCapacitanceUnit.Nanofarad, UnitConverterCapacitanceUnit.Microfarad, UnitConverterCapacitanceUnit.Millifarad, UnitConverterCapacitanceUnit.Farad, UnitConverterCapacitanceUnit.Kilofarad, UnitConverterCapacitanceUnit.Attofarad, UnitConverterCapacitanceUnit.Femtofarad, UnitConverterCapacitanceUnit.Megafarad, UnitConverterCapacitanceUnit.Gigafarad, UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent, UnitConverterCapacitanceUnit.Centifarad, UnitConverterCapacitanceUnit.Decifarad, UnitConverterCapacitanceUnit.Decafarad, UnitConverterCapacitanceUnit.Hectofarad };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterCapacitanceUnit.Abfarad, UnitConverterCapacitanceUnit.Statfarad };
                default:
                    return new[] { UnitConverterCapacitanceUnit.Picofarad, UnitConverterCapacitanceUnit.Nanofarad, UnitConverterCapacitanceUnit.Microfarad, UnitConverterCapacitanceUnit.Millifarad, UnitConverterCapacitanceUnit.Farad, UnitConverterCapacitanceUnit.Kilofarad, UnitConverterCapacitanceUnit.Attofarad, UnitConverterCapacitanceUnit.Femtofarad, UnitConverterCapacitanceUnit.Megafarad, UnitConverterCapacitanceUnit.Gigafarad, UnitConverterCapacitanceUnit.Abfarad, UnitConverterCapacitanceUnit.Statfarad, UnitConverterCapacitanceUnit.MicrofaradPerVoltEquivalent, UnitConverterCapacitanceUnit.Centifarad, UnitConverterCapacitanceUnit.Decifarad, UnitConverterCapacitanceUnit.Decafarad, UnitConverterCapacitanceUnit.Hectofarad };
            }
        }
    }
}
