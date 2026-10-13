namespace UnitTools.Inductance
{
    using UnitTools.Inductance.Metric;
    using UnitTools.Inductance.Scientific;

    public enum UnitToolsInductanceUnit
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

    public static class UnitToolsInductance
    {
        public static double Convert(double value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            double baseValue = ToHenry(value, from);
            return FromHenry(baseValue, to);
        }

        public static double ToHenry(double value, UnitToolsInductanceUnit from)
        {
            switch (from)
            {
                case UnitToolsInductanceUnit.Nanohenry:
                    return UnitToolsMetricInductance.NanohenryToHenry(value);
                case UnitToolsInductanceUnit.Microhenry:
                    return UnitToolsMetricInductance.MicrohenryToHenry(value);
                case UnitToolsInductanceUnit.Millihenry:
                    return UnitToolsMetricInductance.MillihenryToHenry(value);
                case UnitToolsInductanceUnit.Henry:
                    return UnitToolsMetricInductance.HenryToHenry(value);
                case UnitToolsInductanceUnit.Kilohenry:
                    return UnitToolsMetricInductance.KilohenryToHenry(value);
                case UnitToolsInductanceUnit.Femtohenry:
                    return UnitToolsMetricInductance.FemtohenryToHenry(value);
                case UnitToolsInductanceUnit.Picohenry:
                    return UnitToolsMetricInductance.PicohenryToHenry(value);
                case UnitToolsInductanceUnit.Megahenry:
                    return UnitToolsMetricInductance.MegahenryToHenry(value);
                case UnitToolsInductanceUnit.Gigahenry:
                    return UnitToolsMetricInductance.GigahenryToHenry(value);
                case UnitToolsInductanceUnit.Abhenry:
                    return UnitToolsScientificInductance.AbhenryToHenry(value);
                case UnitToolsInductanceUnit.Centihenry:
                    return UnitToolsMetricInductance.CentihenryToHenry(value);
                case UnitToolsInductanceUnit.Decihenry:
                    return UnitToolsMetricInductance.DecihenryToHenry(value);
                case UnitToolsInductanceUnit.Decahenry:
                    return UnitToolsMetricInductance.DecahenryToHenry(value);
                case UnitToolsInductanceUnit.Hectohenry:
                    return UnitToolsMetricInductance.HectohenryToHenry(value);
                case UnitToolsInductanceUnit.Stathenry:
                    return UnitToolsScientificInductance.StathenryToHenry(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported inductance unit.");
            }
        }

        public static double FromHenry(double baseValue, UnitToolsInductanceUnit to)
        {
            switch (to)
            {
                case UnitToolsInductanceUnit.Nanohenry:
                    return UnitToolsMetricInductance.HenryToNanohenry(baseValue);
                case UnitToolsInductanceUnit.Microhenry:
                    return UnitToolsMetricInductance.HenryToMicrohenry(baseValue);
                case UnitToolsInductanceUnit.Millihenry:
                    return UnitToolsMetricInductance.HenryToMillihenry(baseValue);
                case UnitToolsInductanceUnit.Henry:
                    return UnitToolsMetricInductance.HenryToHenry(baseValue);
                case UnitToolsInductanceUnit.Kilohenry:
                    return UnitToolsMetricInductance.HenryToKilohenry(baseValue);
                case UnitToolsInductanceUnit.Femtohenry:
                    return UnitToolsMetricInductance.HenryToFemtohenry(baseValue);
                case UnitToolsInductanceUnit.Picohenry:
                    return UnitToolsMetricInductance.HenryToPicohenry(baseValue);
                case UnitToolsInductanceUnit.Megahenry:
                    return UnitToolsMetricInductance.HenryToMegahenry(baseValue);
                case UnitToolsInductanceUnit.Gigahenry:
                    return UnitToolsMetricInductance.HenryToGigahenry(baseValue);
                case UnitToolsInductanceUnit.Abhenry:
                    return UnitToolsScientificInductance.HenryToAbhenry(baseValue);
                case UnitToolsInductanceUnit.Centihenry:
                    return UnitToolsMetricInductance.HenryToCentihenry(baseValue);
                case UnitToolsInductanceUnit.Decihenry:
                    return UnitToolsMetricInductance.HenryToDecihenry(baseValue);
                case UnitToolsInductanceUnit.Decahenry:
                    return UnitToolsMetricInductance.HenryToDecahenry(baseValue);
                case UnitToolsInductanceUnit.Hectohenry:
                    return UnitToolsMetricInductance.HenryToHectohenry(baseValue);
                case UnitToolsInductanceUnit.Stathenry:
                    return UnitToolsScientificInductance.HenryToStathenry(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported inductance unit.");
            }
        }

        public static string GetSymbol(UnitToolsInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsInductanceUnit.Nanohenry:
                    return "nH";
                case UnitToolsInductanceUnit.Microhenry:
                    return "µH";
                case UnitToolsInductanceUnit.Millihenry:
                    return "mH";
                case UnitToolsInductanceUnit.Henry:
                    return "H";
                case UnitToolsInductanceUnit.Kilohenry:
                    return "kH";
                case UnitToolsInductanceUnit.Femtohenry:
                    return "fH";
                case UnitToolsInductanceUnit.Picohenry:
                    return "pH";
                case UnitToolsInductanceUnit.Megahenry:
                    return "MH";
                case UnitToolsInductanceUnit.Gigahenry:
                    return "GH";
                case UnitToolsInductanceUnit.Abhenry:
                    return "abH";
                case UnitToolsInductanceUnit.Centihenry:
                    return "cH";
                case UnitToolsInductanceUnit.Decihenry:
                    return "dH";
                case UnitToolsInductanceUnit.Decahenry:
                    return "daH";
                case UnitToolsInductanceUnit.Hectohenry:
                    return "hH";
                case UnitToolsInductanceUnit.Stathenry:
                    return "statH";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsInductanceUnit.Nanohenry:
                    return "nanohenry";
                case UnitToolsInductanceUnit.Microhenry:
                    return "microhenry";
                case UnitToolsInductanceUnit.Millihenry:
                    return "millihenry";
                case UnitToolsInductanceUnit.Henry:
                    return "henry";
                case UnitToolsInductanceUnit.Kilohenry:
                    return "kilohenry";
                case UnitToolsInductanceUnit.Femtohenry:
                    return "Femtohenry";
                case UnitToolsInductanceUnit.Picohenry:
                    return "Picohenry";
                case UnitToolsInductanceUnit.Megahenry:
                    return "Megahenry";
                case UnitToolsInductanceUnit.Gigahenry:
                    return "Gigahenry";
                case UnitToolsInductanceUnit.Abhenry:
                    return "Abhenry";
                case UnitToolsInductanceUnit.Centihenry:
                    return "Centihenry";
                case UnitToolsInductanceUnit.Decihenry:
                    return "Decihenry";
                case UnitToolsInductanceUnit.Decahenry:
                    return "Decahenry";
                case UnitToolsInductanceUnit.Hectohenry:
                    return "Hectohenry";
                case UnitToolsInductanceUnit.Stathenry:
                    return "Stathenry";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsInductanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsInductanceUnit.Nanohenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Microhenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Millihenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Henry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Kilohenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Femtohenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Picohenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Megahenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Gigahenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Abhenry:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsInductanceUnit.Centihenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Decihenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Decahenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Hectohenry:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsInductanceUnit.Stathenry:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsInductanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsInductanceUnit.Nanohenry, UnitToolsInductanceUnit.Microhenry, UnitToolsInductanceUnit.Millihenry, UnitToolsInductanceUnit.Henry, UnitToolsInductanceUnit.Kilohenry, UnitToolsInductanceUnit.Femtohenry, UnitToolsInductanceUnit.Picohenry, UnitToolsInductanceUnit.Megahenry, UnitToolsInductanceUnit.Gigahenry, UnitToolsInductanceUnit.Centihenry, UnitToolsInductanceUnit.Decihenry, UnitToolsInductanceUnit.Decahenry, UnitToolsInductanceUnit.Hectohenry };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsInductanceUnit.Abhenry, UnitToolsInductanceUnit.Stathenry };
                default:
                    return new[] { UnitToolsInductanceUnit.Nanohenry, UnitToolsInductanceUnit.Microhenry, UnitToolsInductanceUnit.Millihenry, UnitToolsInductanceUnit.Henry, UnitToolsInductanceUnit.Kilohenry, UnitToolsInductanceUnit.Femtohenry, UnitToolsInductanceUnit.Picohenry, UnitToolsInductanceUnit.Megahenry, UnitToolsInductanceUnit.Gigahenry, UnitToolsInductanceUnit.Abhenry, UnitToolsInductanceUnit.Centihenry, UnitToolsInductanceUnit.Decihenry, UnitToolsInductanceUnit.Decahenry, UnitToolsInductanceUnit.Hectohenry, UnitToolsInductanceUnit.Stathenry };
            }
        }
    }
}
