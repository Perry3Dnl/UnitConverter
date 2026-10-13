namespace UnitTools.Capacitance
{
    using UnitTools.Capacitance.Metric;
    using UnitTools.Capacitance.Scientific;

    public enum UnitToolsCapacitanceUnit
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

    public static class UnitToolsCapacitance
    {
        public static double Convert(double value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            double baseValue = ToFarad(value, from);
            return FromFarad(baseValue, to);
        }

        public static double ToFarad(double value, UnitToolsCapacitanceUnit from)
        {
            switch (from)
            {
                case UnitToolsCapacitanceUnit.Picofarad:
                    return UnitToolsMetricCapacitance.PicofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Nanofarad:
                    return UnitToolsMetricCapacitance.NanofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Microfarad:
                    return UnitToolsMetricCapacitance.MicrofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Millifarad:
                    return UnitToolsMetricCapacitance.MillifaradToFarad(value);
                case UnitToolsCapacitanceUnit.Farad:
                    return UnitToolsMetricCapacitance.FaradToFarad(value);
                case UnitToolsCapacitanceUnit.Kilofarad:
                    return UnitToolsMetricCapacitance.KilofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Attofarad:
                    return UnitToolsMetricCapacitance.AttofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Femtofarad:
                    return UnitToolsMetricCapacitance.FemtofaradToFarad(value);
                case UnitToolsCapacitanceUnit.Megafarad:
                    return UnitToolsMetricCapacitance.MegafaradToFarad(value);
                case UnitToolsCapacitanceUnit.Gigafarad:
                    return UnitToolsMetricCapacitance.GigafaradToFarad(value);
                case UnitToolsCapacitanceUnit.Abfarad:
                    return UnitToolsScientificCapacitance.AbfaradToFarad(value);
                case UnitToolsCapacitanceUnit.Statfarad:
                    return UnitToolsScientificCapacitance.StatfaradToFarad(value);
                case UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitToolsMetricCapacitance.MicrofaradPerVoltEquivalentToFarad(value);
                case UnitToolsCapacitanceUnit.Centifarad:
                    return UnitToolsMetricCapacitance.CentifaradToFarad(value);
                case UnitToolsCapacitanceUnit.Decifarad:
                    return UnitToolsMetricCapacitance.DecifaradToFarad(value);
                case UnitToolsCapacitanceUnit.Decafarad:
                    return UnitToolsMetricCapacitance.DecafaradToFarad(value);
                case UnitToolsCapacitanceUnit.Hectofarad:
                    return UnitToolsMetricCapacitance.HectofaradToFarad(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported capacitance unit.");
            }
        }

        public static double FromFarad(double baseValue, UnitToolsCapacitanceUnit to)
        {
            switch (to)
            {
                case UnitToolsCapacitanceUnit.Picofarad:
                    return UnitToolsMetricCapacitance.FaradToPicofarad(baseValue);
                case UnitToolsCapacitanceUnit.Nanofarad:
                    return UnitToolsMetricCapacitance.FaradToNanofarad(baseValue);
                case UnitToolsCapacitanceUnit.Microfarad:
                    return UnitToolsMetricCapacitance.FaradToMicrofarad(baseValue);
                case UnitToolsCapacitanceUnit.Millifarad:
                    return UnitToolsMetricCapacitance.FaradToMillifarad(baseValue);
                case UnitToolsCapacitanceUnit.Farad:
                    return UnitToolsMetricCapacitance.FaradToFarad(baseValue);
                case UnitToolsCapacitanceUnit.Kilofarad:
                    return UnitToolsMetricCapacitance.FaradToKilofarad(baseValue);
                case UnitToolsCapacitanceUnit.Attofarad:
                    return UnitToolsMetricCapacitance.FaradToAttofarad(baseValue);
                case UnitToolsCapacitanceUnit.Femtofarad:
                    return UnitToolsMetricCapacitance.FaradToFemtofarad(baseValue);
                case UnitToolsCapacitanceUnit.Megafarad:
                    return UnitToolsMetricCapacitance.FaradToMegafarad(baseValue);
                case UnitToolsCapacitanceUnit.Gigafarad:
                    return UnitToolsMetricCapacitance.FaradToGigafarad(baseValue);
                case UnitToolsCapacitanceUnit.Abfarad:
                    return UnitToolsScientificCapacitance.FaradToAbfarad(baseValue);
                case UnitToolsCapacitanceUnit.Statfarad:
                    return UnitToolsScientificCapacitance.FaradToStatfarad(baseValue);
                case UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitToolsMetricCapacitance.FaradToMicrofaradPerVoltEquivalent(baseValue);
                case UnitToolsCapacitanceUnit.Centifarad:
                    return UnitToolsMetricCapacitance.FaradToCentifarad(baseValue);
                case UnitToolsCapacitanceUnit.Decifarad:
                    return UnitToolsMetricCapacitance.FaradToDecifarad(baseValue);
                case UnitToolsCapacitanceUnit.Decafarad:
                    return UnitToolsMetricCapacitance.FaradToDecafarad(baseValue);
                case UnitToolsCapacitanceUnit.Hectofarad:
                    return UnitToolsMetricCapacitance.FaradToHectofarad(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported capacitance unit.");
            }
        }

        public static string GetSymbol(UnitToolsCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCapacitanceUnit.Picofarad:
                    return "pF";
                case UnitToolsCapacitanceUnit.Nanofarad:
                    return "nF";
                case UnitToolsCapacitanceUnit.Microfarad:
                    return "µF";
                case UnitToolsCapacitanceUnit.Millifarad:
                    return "mF";
                case UnitToolsCapacitanceUnit.Farad:
                    return "F";
                case UnitToolsCapacitanceUnit.Kilofarad:
                    return "kF";
                case UnitToolsCapacitanceUnit.Attofarad:
                    return "aF";
                case UnitToolsCapacitanceUnit.Femtofarad:
                    return "fF";
                case UnitToolsCapacitanceUnit.Megafarad:
                    return "MF";
                case UnitToolsCapacitanceUnit.Gigafarad:
                    return "GF";
                case UnitToolsCapacitanceUnit.Abfarad:
                    return "abF";
                case UnitToolsCapacitanceUnit.Statfarad:
                    return "statF";
                case UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return "µF eq";
                case UnitToolsCapacitanceUnit.Centifarad:
                    return "cF";
                case UnitToolsCapacitanceUnit.Decifarad:
                    return "dF";
                case UnitToolsCapacitanceUnit.Decafarad:
                    return "daF";
                case UnitToolsCapacitanceUnit.Hectofarad:
                    return "hF";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCapacitanceUnit.Picofarad:
                    return "picofarad";
                case UnitToolsCapacitanceUnit.Nanofarad:
                    return "nanofarad";
                case UnitToolsCapacitanceUnit.Microfarad:
                    return "microfarad";
                case UnitToolsCapacitanceUnit.Millifarad:
                    return "millifarad";
                case UnitToolsCapacitanceUnit.Farad:
                    return "farad";
                case UnitToolsCapacitanceUnit.Kilofarad:
                    return "kilofarad";
                case UnitToolsCapacitanceUnit.Attofarad:
                    return "Attofarad";
                case UnitToolsCapacitanceUnit.Femtofarad:
                    return "Femtofarad";
                case UnitToolsCapacitanceUnit.Megafarad:
                    return "Megafarad";
                case UnitToolsCapacitanceUnit.Gigafarad:
                    return "Gigafarad";
                case UnitToolsCapacitanceUnit.Abfarad:
                    return "Abfarad";
                case UnitToolsCapacitanceUnit.Statfarad:
                    return "Statfarad";
                case UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return "Microfarad Per Volt Equivalent";
                case UnitToolsCapacitanceUnit.Centifarad:
                    return "Centifarad";
                case UnitToolsCapacitanceUnit.Decifarad:
                    return "Decifarad";
                case UnitToolsCapacitanceUnit.Decafarad:
                    return "Decafarad";
                case UnitToolsCapacitanceUnit.Hectofarad:
                    return "Hectofarad";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsCapacitanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCapacitanceUnit.Picofarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Nanofarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Microfarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Millifarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Farad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Kilofarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Attofarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Femtofarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Megafarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Gigafarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Abfarad:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsCapacitanceUnit.Statfarad:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Centifarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Decifarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Decafarad:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCapacitanceUnit.Hectofarad:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsCapacitanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsCapacitanceUnit.Picofarad, UnitToolsCapacitanceUnit.Nanofarad, UnitToolsCapacitanceUnit.Microfarad, UnitToolsCapacitanceUnit.Millifarad, UnitToolsCapacitanceUnit.Farad, UnitToolsCapacitanceUnit.Kilofarad, UnitToolsCapacitanceUnit.Attofarad, UnitToolsCapacitanceUnit.Femtofarad, UnitToolsCapacitanceUnit.Megafarad, UnitToolsCapacitanceUnit.Gigafarad, UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent, UnitToolsCapacitanceUnit.Centifarad, UnitToolsCapacitanceUnit.Decifarad, UnitToolsCapacitanceUnit.Decafarad, UnitToolsCapacitanceUnit.Hectofarad };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsCapacitanceUnit.Abfarad, UnitToolsCapacitanceUnit.Statfarad };
                default:
                    return new[] { UnitToolsCapacitanceUnit.Picofarad, UnitToolsCapacitanceUnit.Nanofarad, UnitToolsCapacitanceUnit.Microfarad, UnitToolsCapacitanceUnit.Millifarad, UnitToolsCapacitanceUnit.Farad, UnitToolsCapacitanceUnit.Kilofarad, UnitToolsCapacitanceUnit.Attofarad, UnitToolsCapacitanceUnit.Femtofarad, UnitToolsCapacitanceUnit.Megafarad, UnitToolsCapacitanceUnit.Gigafarad, UnitToolsCapacitanceUnit.Abfarad, UnitToolsCapacitanceUnit.Statfarad, UnitToolsCapacitanceUnit.MicrofaradPerVoltEquivalent, UnitToolsCapacitanceUnit.Centifarad, UnitToolsCapacitanceUnit.Decifarad, UnitToolsCapacitanceUnit.Decafarad, UnitToolsCapacitanceUnit.Hectofarad };
            }
        }
    }
}
