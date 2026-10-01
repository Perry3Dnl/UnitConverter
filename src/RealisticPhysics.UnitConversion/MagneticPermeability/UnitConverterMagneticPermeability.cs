namespace RealisticPhysics.UnitConversion.MagneticPermeability
{
    using RealisticPhysics.UnitConversion.MagneticPermeability.Metric;
    using RealisticPhysics.UnitConversion.MagneticPermeability.Scientific;
    using RealisticPhysics.UnitConversion.MagneticPermeability.Imperial;

    public enum UnitConverterMagneticPermeabilityUnit
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

    public static class UnitConverterMagneticPermeability
    {
        public static double Convert(double value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            double baseValue = ToHenryPerMeter(value, from);
            return FromHenryPerMeter(baseValue, to);
        }

        public static double ToHenryPerMeter(double value, UnitConverterMagneticPermeabilityUnit from)
        {
            switch (from)
            {
                case UnitConverterMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.MillihenryPerMeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.MicrohenryPerMeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.NanohenryPerMeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitConverterScientificMagneticPermeability.VacuumPermeabilityToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.PicohenryPerMeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMillimeterToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.HenryPerInch:
                    return UnitConverterImperialMagneticPermeability.HenryPerInchToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.RelativePermeability:
                    return UnitConverterScientificMagneticPermeability.RelativePermeabilityToHenryPerMeter(value);
                case UnitConverterMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitConverterScientificMagneticPermeability.GaussPerOerstedToHenryPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic permeability unit.");
            }
        }

        public static double FromHenryPerMeter(double baseValue, UnitConverterMagneticPermeabilityUnit to)
        {
            switch (to)
            {
                case UnitConverterMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToHenryPerMeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToMillihenryPerMeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToMicrohenryPerMeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToNanohenryPerMeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitConverterScientificMagneticPermeability.HenryPerMeterToVacuumPermeability(baseValue);
                case UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToPicohenryPerMeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitConverterMetricMagneticPermeability.HenryPerMeterToHenryPerMillimeter(baseValue);
                case UnitConverterMagneticPermeabilityUnit.HenryPerInch:
                    return UnitConverterImperialMagneticPermeability.HenryPerMeterToHenryPerInch(baseValue);
                case UnitConverterMagneticPermeabilityUnit.RelativePermeability:
                    return UnitConverterScientificMagneticPermeability.HenryPerMeterToRelativePermeability(baseValue);
                case UnitConverterMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitConverterScientificMagneticPermeability.HenryPerMeterToGaussPerOersted(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic permeability unit.");
            }
        }

        public static string GetSymbol(UnitConverterMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticPermeabilityUnit.HenryPerMeter:
                    return "H/m";
                case UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter:
                    return "mH/m";
                case UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return "µH/m";
                case UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter:
                    return "nH/m";
                case UnitConverterMagneticPermeabilityUnit.VacuumPermeability:
                    return "µ₀";
                case UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter:
                    return "pH/m";
                case UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter:
                    return "H/mm";
                case UnitConverterMagneticPermeabilityUnit.HenryPerInch:
                    return "H/in";
                case UnitConverterMagneticPermeabilityUnit.RelativePermeability:
                    return "µr·µ₀";
                case UnitConverterMagneticPermeabilityUnit.GaussPerOersted:
                    return "G/Oe";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticPermeabilityUnit.HenryPerMeter:
                    return "Henry Per Meter";
                case UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter:
                    return "Millihenry Per Meter";
                case UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return "Microhenry Per Meter";
                case UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter:
                    return "Nanohenry Per Meter";
                case UnitConverterMagneticPermeabilityUnit.VacuumPermeability:
                    return "Vacuum Permeability";
                case UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter:
                    return "Picohenry Per Meter";
                case UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter:
                    return "Henry Per Millimeter";
                case UnitConverterMagneticPermeabilityUnit.HenryPerInch:
                    return "Henry Per Inch";
                case UnitConverterMagneticPermeabilityUnit.RelativePermeability:
                    return "Relative Permeability";
                case UnitConverterMagneticPermeabilityUnit.GaussPerOersted:
                    return "Gauss Per Oersted";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMagneticPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticPermeabilityUnit.HenryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.VacuumPermeability:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticPermeabilityUnit.HenryPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMagneticPermeabilityUnit.RelativePermeability:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticPermeabilityUnit.GaussPerOersted:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMagneticPermeabilityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMagneticPermeabilityUnit.HenryPerMeter, UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter, UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter, UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter, UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter, UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterMagneticPermeabilityUnit.VacuumPermeability, UnitConverterMagneticPermeabilityUnit.RelativePermeability, UnitConverterMagneticPermeabilityUnit.GaussPerOersted };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMagneticPermeabilityUnit.HenryPerInch };
                default:
                    return new[] { UnitConverterMagneticPermeabilityUnit.HenryPerMeter, UnitConverterMagneticPermeabilityUnit.MillihenryPerMeter, UnitConverterMagneticPermeabilityUnit.MicrohenryPerMeter, UnitConverterMagneticPermeabilityUnit.NanohenryPerMeter, UnitConverterMagneticPermeabilityUnit.VacuumPermeability, UnitConverterMagneticPermeabilityUnit.PicohenryPerMeter, UnitConverterMagneticPermeabilityUnit.HenryPerMillimeter, UnitConverterMagneticPermeabilityUnit.HenryPerInch, UnitConverterMagneticPermeabilityUnit.RelativePermeability, UnitConverterMagneticPermeabilityUnit.GaussPerOersted };
            }
        }
    }
}
