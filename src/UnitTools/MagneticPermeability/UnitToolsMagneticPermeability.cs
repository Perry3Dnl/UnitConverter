namespace UnitTools.MagneticPermeability
{
    using UnitTools.MagneticPermeability.Metric;
    using UnitTools.MagneticPermeability.Scientific;
    using UnitTools.MagneticPermeability.Imperial;

    public enum UnitToolsMagneticPermeabilityUnit
    {
        HenryPerMeter = 0,
        MillihenryPerMeter = 1,
        MicrohenryPerMeter = 2,
        NanohenryPerMeter = 3,
        VacuumPermeability = 4,
        PicohenryPerMeter = 5,
        HenryPerMillimeter = 6,
        HenryPerInch = 7,
        RelativePermeability = 8,
        GaussPerOersted = 9,
    }

    public static class UnitToolsMagneticPermeability
    {
        public static double Convert(double value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            double baseValue = ToHenryPerMeter(value, from);
            return FromHenryPerMeter(baseValue, to);
        }

        public static double ToHenryPerMeter(double value, UnitToolsMagneticPermeabilityUnit from)
        {
            switch (from)
            {
                case UnitToolsMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.MillihenryPerMeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.MicrohenryPerMeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.NanohenryPerMeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitToolsScientificMagneticPermeability.VacuumPermeabilityToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.PicohenryPerMeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMillimeterToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.HenryPerInch:
                    return UnitToolsImperialMagneticPermeability.HenryPerInchToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.RelativePermeability:
                    return UnitToolsScientificMagneticPermeability.RelativePermeabilityToHenryPerMeter(value);
                case UnitToolsMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitToolsScientificMagneticPermeability.GaussPerOerstedToHenryPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic permeability unit.");
            }
        }

        public static double FromHenryPerMeter(double baseValue, UnitToolsMagneticPermeabilityUnit to)
        {
            switch (to)
            {
                case UnitToolsMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToHenryPerMeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToMillihenryPerMeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToMicrohenryPerMeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToNanohenryPerMeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitToolsScientificMagneticPermeability.HenryPerMeterToVacuumPermeability(baseValue);
                case UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToPicohenryPerMeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitToolsMetricMagneticPermeability.HenryPerMeterToHenryPerMillimeter(baseValue);
                case UnitToolsMagneticPermeabilityUnit.HenryPerInch:
                    return UnitToolsImperialMagneticPermeability.HenryPerMeterToHenryPerInch(baseValue);
                case UnitToolsMagneticPermeabilityUnit.RelativePermeability:
                    return UnitToolsScientificMagneticPermeability.HenryPerMeterToRelativePermeability(baseValue);
                case UnitToolsMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitToolsScientificMagneticPermeability.HenryPerMeterToGaussPerOersted(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic permeability unit.");
            }
        }

        public static string GetSymbol(UnitToolsMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticPermeabilityUnit.HenryPerMeter:
                    return "H/m";
                case UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter:
                    return "mH/m";
                case UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return "µH/m";
                case UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter:
                    return "nH/m";
                case UnitToolsMagneticPermeabilityUnit.VacuumPermeability:
                    return "µ₀";
                case UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter:
                    return "pH/m";
                case UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter:
                    return "H/mm";
                case UnitToolsMagneticPermeabilityUnit.HenryPerInch:
                    return "H/in";
                case UnitToolsMagneticPermeabilityUnit.RelativePermeability:
                    return "µr·µ₀";
                case UnitToolsMagneticPermeabilityUnit.GaussPerOersted:
                    return "G/Oe";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticPermeabilityUnit.HenryPerMeter:
                    return "Henry Per Meter";
                case UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter:
                    return "Millihenry Per Meter";
                case UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return "Microhenry Per Meter";
                case UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter:
                    return "Nanohenry Per Meter";
                case UnitToolsMagneticPermeabilityUnit.VacuumPermeability:
                    return "Vacuum Permeability";
                case UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter:
                    return "Picohenry Per Meter";
                case UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter:
                    return "Henry Per Millimeter";
                case UnitToolsMagneticPermeabilityUnit.HenryPerInch:
                    return "Henry Per Inch";
                case UnitToolsMagneticPermeabilityUnit.RelativePermeability:
                    return "Relative Permeability";
                case UnitToolsMagneticPermeabilityUnit.GaussPerOersted:
                    return "Gauss Per Oersted";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticPermeabilityUnit.HenryPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMagneticPermeabilityUnit.RelativePermeability:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMagneticPermeabilityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMagneticPermeabilityUnit.HenryPerMeter, UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter, UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter, UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter, UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter, UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsMagneticPermeabilityUnit.VacuumPermeability, UnitToolsMagneticPermeabilityUnit.RelativePermeability, UnitToolsMagneticPermeabilityUnit.GaussPerOersted };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMagneticPermeabilityUnit.HenryPerInch };
                default:
                    return new[] { UnitToolsMagneticPermeabilityUnit.HenryPerMeter, UnitToolsMagneticPermeabilityUnit.MillihenryPerMeter, UnitToolsMagneticPermeabilityUnit.MicrohenryPerMeter, UnitToolsMagneticPermeabilityUnit.NanohenryPerMeter, UnitToolsMagneticPermeabilityUnit.VacuumPermeability, UnitToolsMagneticPermeabilityUnit.PicohenryPerMeter, UnitToolsMagneticPermeabilityUnit.HenryPerMillimeter, UnitToolsMagneticPermeabilityUnit.HenryPerInch, UnitToolsMagneticPermeabilityUnit.RelativePermeability, UnitToolsMagneticPermeabilityUnit.GaussPerOersted };
            }
        }
    }
}
