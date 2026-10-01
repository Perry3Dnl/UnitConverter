namespace RealisticPhysics.UnitConversion.Permittivity
{
    using RealisticPhysics.UnitConversion.Permittivity.Metric;
    using RealisticPhysics.UnitConversion.Permittivity.Scientific;
    using RealisticPhysics.UnitConversion.Permittivity.Imperial;

    public enum UnitConverterPermittivityUnit
    {
        FaradPerMeter = 0,
        PicofaradPerMeter = 1,
        NanofaradPerMeter = 2,
        MicrofaradPerMeter = 3,
        VacuumPermittivity = 4,
        MillifaradPerMeter = 5,
        FemtofaradPerMeter = 6,
        FaradPerMillimeter = 7,
        FaradPerInch = 8,
        RelativePermittivity = 9,
    }

    public static class UnitConverterPermittivity
    {
        public static double Convert(double value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            double baseValue = ToFaradPerMeter(value, from);
            return FromFaradPerMeter(baseValue, to);
        }

        public static double ToFaradPerMeter(double value, UnitConverterPermittivityUnit from)
        {
            switch (from)
            {
                case UnitConverterPermittivityUnit.FaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.PicofaradPerMeter:
                    return UnitConverterMetricPermittivity.PicofaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.NanofaradPerMeter:
                    return UnitConverterMetricPermittivity.NanofaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.MicrofaradPerMeter:
                    return UnitConverterMetricPermittivity.MicrofaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.VacuumPermittivity:
                    return UnitConverterScientificPermittivity.VacuumPermittivityToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.MillifaradPerMeter:
                    return UnitConverterMetricPermittivity.MillifaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.FemtofaradPerMeter:
                    return UnitConverterMetricPermittivity.FemtofaradPerMeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.FaradPerMillimeter:
                    return UnitConverterMetricPermittivity.FaradPerMillimeterToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.FaradPerInch:
                    return UnitConverterImperialPermittivity.FaradPerInchToFaradPerMeter(value);
                case UnitConverterPermittivityUnit.RelativePermittivity:
                    return UnitConverterScientificPermittivity.RelativePermittivityToFaradPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported permittivity unit.");
            }
        }

        public static double FromFaradPerMeter(double baseValue, UnitConverterPermittivityUnit to)
        {
            switch (to)
            {
                case UnitConverterPermittivityUnit.FaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToFaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.PicofaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToPicofaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.NanofaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToNanofaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.MicrofaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToMicrofaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.VacuumPermittivity:
                    return UnitConverterScientificPermittivity.FaradPerMeterToVacuumPermittivity(baseValue);
                case UnitConverterPermittivityUnit.MillifaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToMillifaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.FemtofaradPerMeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToFemtofaradPerMeter(baseValue);
                case UnitConverterPermittivityUnit.FaradPerMillimeter:
                    return UnitConverterMetricPermittivity.FaradPerMeterToFaradPerMillimeter(baseValue);
                case UnitConverterPermittivityUnit.FaradPerInch:
                    return UnitConverterImperialPermittivity.FaradPerMeterToFaradPerInch(baseValue);
                case UnitConverterPermittivityUnit.RelativePermittivity:
                    return UnitConverterScientificPermittivity.FaradPerMeterToRelativePermittivity(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported permittivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPermittivityUnit.FaradPerMeter:
                    return "F/m";
                case UnitConverterPermittivityUnit.PicofaradPerMeter:
                    return "pF/m";
                case UnitConverterPermittivityUnit.NanofaradPerMeter:
                    return "nF/m";
                case UnitConverterPermittivityUnit.MicrofaradPerMeter:
                    return "µF/m";
                case UnitConverterPermittivityUnit.VacuumPermittivity:
                    return "ε₀";
                case UnitConverterPermittivityUnit.MillifaradPerMeter:
                    return "mF/m";
                case UnitConverterPermittivityUnit.FemtofaradPerMeter:
                    return "fF/m";
                case UnitConverterPermittivityUnit.FaradPerMillimeter:
                    return "F/mm";
                case UnitConverterPermittivityUnit.FaradPerInch:
                    return "F/in";
                case UnitConverterPermittivityUnit.RelativePermittivity:
                    return "εr·ε₀";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPermittivityUnit.FaradPerMeter:
                    return "Farad Per Meter";
                case UnitConverterPermittivityUnit.PicofaradPerMeter:
                    return "Picofarad Per Meter";
                case UnitConverterPermittivityUnit.NanofaradPerMeter:
                    return "Nanofarad Per Meter";
                case UnitConverterPermittivityUnit.MicrofaradPerMeter:
                    return "Microfarad Per Meter";
                case UnitConverterPermittivityUnit.VacuumPermittivity:
                    return "Vacuum Permittivity";
                case UnitConverterPermittivityUnit.MillifaradPerMeter:
                    return "Millifarad Per Meter";
                case UnitConverterPermittivityUnit.FemtofaradPerMeter:
                    return "Femtofarad Per Meter";
                case UnitConverterPermittivityUnit.FaradPerMillimeter:
                    return "Farad Per Millimeter";
                case UnitConverterPermittivityUnit.FaradPerInch:
                    return "Farad Per Inch";
                case UnitConverterPermittivityUnit.RelativePermittivity:
                    return "Relative Permittivity";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPermittivityUnit.FaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.PicofaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.NanofaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.MicrofaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.VacuumPermittivity:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPermittivityUnit.MillifaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.FemtofaradPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.FaradPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPermittivityUnit.FaradPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPermittivityUnit.RelativePermittivity:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPermittivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPermittivityUnit.FaradPerMeter, UnitConverterPermittivityUnit.PicofaradPerMeter, UnitConverterPermittivityUnit.NanofaradPerMeter, UnitConverterPermittivityUnit.MicrofaradPerMeter, UnitConverterPermittivityUnit.MillifaradPerMeter, UnitConverterPermittivityUnit.FemtofaradPerMeter, UnitConverterPermittivityUnit.FaradPerMillimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterPermittivityUnit.VacuumPermittivity, UnitConverterPermittivityUnit.RelativePermittivity };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPermittivityUnit.FaradPerInch };
                default:
                    return new[] { UnitConverterPermittivityUnit.FaradPerMeter, UnitConverterPermittivityUnit.PicofaradPerMeter, UnitConverterPermittivityUnit.NanofaradPerMeter, UnitConverterPermittivityUnit.MicrofaradPerMeter, UnitConverterPermittivityUnit.VacuumPermittivity, UnitConverterPermittivityUnit.MillifaradPerMeter, UnitConverterPermittivityUnit.FemtofaradPerMeter, UnitConverterPermittivityUnit.FaradPerMillimeter, UnitConverterPermittivityUnit.FaradPerInch, UnitConverterPermittivityUnit.RelativePermittivity };
            }
        }
    }
}
