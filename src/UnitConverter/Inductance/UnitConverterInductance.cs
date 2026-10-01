namespace UnitConverter.Inductance
{
    using UnitConverter.Inductance.Metric;
    using UnitConverter.Inductance.Scientific;

    public enum UnitConverterInductanceUnit
    {
        Nanohenry = 0,
        Microhenry = 1,
        Millihenry = 2,
        Henry = 3,
        Kilohenry = 4,
        Femtohenry = 5,
        Picohenry = 6,
        Megahenry = 7,
        Gigahenry = 8,
        Abhenry = 9,
        Centihenry = 10,
        Decihenry = 11,
        Decahenry = 12,
        Hectohenry = 13,
        Stathenry = 14,
    }

    public static class UnitConverterInductance
    {
        public static double Convert(double value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            double baseValue = ToHenry(value, from);
            return FromHenry(baseValue, to);
        }

        public static double ToHenry(double value, UnitConverterInductanceUnit from)
        {
            switch (from)
            {
                case UnitConverterInductanceUnit.Nanohenry:
                    return UnitConverterMetricInductance.NanohenryToHenry(value);
                case UnitConverterInductanceUnit.Microhenry:
                    return UnitConverterMetricInductance.MicrohenryToHenry(value);
                case UnitConverterInductanceUnit.Millihenry:
                    return UnitConverterMetricInductance.MillihenryToHenry(value);
                case UnitConverterInductanceUnit.Henry:
                    return UnitConverterMetricInductance.HenryToHenry(value);
                case UnitConverterInductanceUnit.Kilohenry:
                    return UnitConverterMetricInductance.KilohenryToHenry(value);
                case UnitConverterInductanceUnit.Femtohenry:
                    return UnitConverterMetricInductance.FemtohenryToHenry(value);
                case UnitConverterInductanceUnit.Picohenry:
                    return UnitConverterMetricInductance.PicohenryToHenry(value);
                case UnitConverterInductanceUnit.Megahenry:
                    return UnitConverterMetricInductance.MegahenryToHenry(value);
                case UnitConverterInductanceUnit.Gigahenry:
                    return UnitConverterMetricInductance.GigahenryToHenry(value);
                case UnitConverterInductanceUnit.Abhenry:
                    return UnitConverterScientificInductance.AbhenryToHenry(value);
                case UnitConverterInductanceUnit.Centihenry:
                    return UnitConverterMetricInductance.CentihenryToHenry(value);
                case UnitConverterInductanceUnit.Decihenry:
                    return UnitConverterMetricInductance.DecihenryToHenry(value);
                case UnitConverterInductanceUnit.Decahenry:
                    return UnitConverterMetricInductance.DecahenryToHenry(value);
                case UnitConverterInductanceUnit.Hectohenry:
                    return UnitConverterMetricInductance.HectohenryToHenry(value);
                case UnitConverterInductanceUnit.Stathenry:
                    return UnitConverterScientificInductance.StathenryToHenry(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported inductance unit.");
            }
        }

        public static double FromHenry(double baseValue, UnitConverterInductanceUnit to)
        {
            switch (to)
            {
                case UnitConverterInductanceUnit.Nanohenry:
                    return UnitConverterMetricInductance.HenryToNanohenry(baseValue);
                case UnitConverterInductanceUnit.Microhenry:
                    return UnitConverterMetricInductance.HenryToMicrohenry(baseValue);
                case UnitConverterInductanceUnit.Millihenry:
                    return UnitConverterMetricInductance.HenryToMillihenry(baseValue);
                case UnitConverterInductanceUnit.Henry:
                    return UnitConverterMetricInductance.HenryToHenry(baseValue);
                case UnitConverterInductanceUnit.Kilohenry:
                    return UnitConverterMetricInductance.HenryToKilohenry(baseValue);
                case UnitConverterInductanceUnit.Femtohenry:
                    return UnitConverterMetricInductance.HenryToFemtohenry(baseValue);
                case UnitConverterInductanceUnit.Picohenry:
                    return UnitConverterMetricInductance.HenryToPicohenry(baseValue);
                case UnitConverterInductanceUnit.Megahenry:
                    return UnitConverterMetricInductance.HenryToMegahenry(baseValue);
                case UnitConverterInductanceUnit.Gigahenry:
                    return UnitConverterMetricInductance.HenryToGigahenry(baseValue);
                case UnitConverterInductanceUnit.Abhenry:
                    return UnitConverterScientificInductance.HenryToAbhenry(baseValue);
                case UnitConverterInductanceUnit.Centihenry:
                    return UnitConverterMetricInductance.HenryToCentihenry(baseValue);
                case UnitConverterInductanceUnit.Decihenry:
                    return UnitConverterMetricInductance.HenryToDecihenry(baseValue);
                case UnitConverterInductanceUnit.Decahenry:
                    return UnitConverterMetricInductance.HenryToDecahenry(baseValue);
                case UnitConverterInductanceUnit.Hectohenry:
                    return UnitConverterMetricInductance.HenryToHectohenry(baseValue);
                case UnitConverterInductanceUnit.Stathenry:
                    return UnitConverterScientificInductance.HenryToStathenry(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported inductance unit.");
            }
        }

        public static string GetSymbol(UnitConverterInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterInductanceUnit.Nanohenry:
                    return "nH";
                case UnitConverterInductanceUnit.Microhenry:
                    return "µH";
                case UnitConverterInductanceUnit.Millihenry:
                    return "mH";
                case UnitConverterInductanceUnit.Henry:
                    return "H";
                case UnitConverterInductanceUnit.Kilohenry:
                    return "kH";
                case UnitConverterInductanceUnit.Femtohenry:
                    return "fH";
                case UnitConverterInductanceUnit.Picohenry:
                    return "pH";
                case UnitConverterInductanceUnit.Megahenry:
                    return "MH";
                case UnitConverterInductanceUnit.Gigahenry:
                    return "GH";
                case UnitConverterInductanceUnit.Abhenry:
                    return "abH";
                case UnitConverterInductanceUnit.Centihenry:
                    return "cH";
                case UnitConverterInductanceUnit.Decihenry:
                    return "dH";
                case UnitConverterInductanceUnit.Decahenry:
                    return "daH";
                case UnitConverterInductanceUnit.Hectohenry:
                    return "hH";
                case UnitConverterInductanceUnit.Stathenry:
                    return "statH";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterInductanceUnit.Nanohenry:
                    return "nanohenry";
                case UnitConverterInductanceUnit.Microhenry:
                    return "microhenry";
                case UnitConverterInductanceUnit.Millihenry:
                    return "millihenry";
                case UnitConverterInductanceUnit.Henry:
                    return "henry";
                case UnitConverterInductanceUnit.Kilohenry:
                    return "kilohenry";
                case UnitConverterInductanceUnit.Femtohenry:
                    return "Femtohenry";
                case UnitConverterInductanceUnit.Picohenry:
                    return "Picohenry";
                case UnitConverterInductanceUnit.Megahenry:
                    return "Megahenry";
                case UnitConverterInductanceUnit.Gigahenry:
                    return "Gigahenry";
                case UnitConverterInductanceUnit.Abhenry:
                    return "Abhenry";
                case UnitConverterInductanceUnit.Centihenry:
                    return "Centihenry";
                case UnitConverterInductanceUnit.Decihenry:
                    return "Decihenry";
                case UnitConverterInductanceUnit.Decahenry:
                    return "Decahenry";
                case UnitConverterInductanceUnit.Hectohenry:
                    return "Hectohenry";
                case UnitConverterInductanceUnit.Stathenry:
                    return "Stathenry";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterInductanceUnit.Nanohenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Microhenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Millihenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Henry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Kilohenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Femtohenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Picohenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Megahenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Gigahenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Abhenry:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterInductanceUnit.Centihenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Decihenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Decahenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Hectohenry:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterInductanceUnit.Stathenry:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterInductanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterInductanceUnit.Nanohenry, UnitConverterInductanceUnit.Microhenry, UnitConverterInductanceUnit.Millihenry, UnitConverterInductanceUnit.Henry, UnitConverterInductanceUnit.Kilohenry, UnitConverterInductanceUnit.Femtohenry, UnitConverterInductanceUnit.Picohenry, UnitConverterInductanceUnit.Megahenry, UnitConverterInductanceUnit.Gigahenry, UnitConverterInductanceUnit.Centihenry, UnitConverterInductanceUnit.Decihenry, UnitConverterInductanceUnit.Decahenry, UnitConverterInductanceUnit.Hectohenry };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterInductanceUnit.Abhenry, UnitConverterInductanceUnit.Stathenry };
                default:
                    return new[] { UnitConverterInductanceUnit.Nanohenry, UnitConverterInductanceUnit.Microhenry, UnitConverterInductanceUnit.Millihenry, UnitConverterInductanceUnit.Henry, UnitConverterInductanceUnit.Kilohenry, UnitConverterInductanceUnit.Femtohenry, UnitConverterInductanceUnit.Picohenry, UnitConverterInductanceUnit.Megahenry, UnitConverterInductanceUnit.Gigahenry, UnitConverterInductanceUnit.Abhenry, UnitConverterInductanceUnit.Centihenry, UnitConverterInductanceUnit.Decihenry, UnitConverterInductanceUnit.Decahenry, UnitConverterInductanceUnit.Hectohenry, UnitConverterInductanceUnit.Stathenry };
            }
        }
    }
}
