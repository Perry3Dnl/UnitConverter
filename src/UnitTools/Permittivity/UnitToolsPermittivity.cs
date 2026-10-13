namespace UnitTools.Permittivity
{
    using UnitTools.Permittivity.Metric;
    using UnitTools.Permittivity.Scientific;
    using UnitTools.Permittivity.Imperial;

    public enum UnitToolsPermittivityUnit
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

    public static class UnitToolsPermittivity
    {
        public static double Convert(double value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            double baseValue = ToFaradPerMeter(value, from);
            return FromFaradPerMeter(baseValue, to);
        }

        public static double ToFaradPerMeter(double value, UnitToolsPermittivityUnit from)
        {
            switch (from)
            {
                case UnitToolsPermittivityUnit.FaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.PicofaradPerMeter:
                    return UnitToolsMetricPermittivity.PicofaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.NanofaradPerMeter:
                    return UnitToolsMetricPermittivity.NanofaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.MicrofaradPerMeter:
                    return UnitToolsMetricPermittivity.MicrofaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.VacuumPermittivity:
                    return UnitToolsScientificPermittivity.VacuumPermittivityToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.MillifaradPerMeter:
                    return UnitToolsMetricPermittivity.MillifaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.FemtofaradPerMeter:
                    return UnitToolsMetricPermittivity.FemtofaradPerMeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.FaradPerMillimeter:
                    return UnitToolsMetricPermittivity.FaradPerMillimeterToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.FaradPerInch:
                    return UnitToolsImperialPermittivity.FaradPerInchToFaradPerMeter(value);
                case UnitToolsPermittivityUnit.RelativePermittivity:
                    return UnitToolsScientificPermittivity.RelativePermittivityToFaradPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported permittivity unit.");
            }
        }

        public static double FromFaradPerMeter(double baseValue, UnitToolsPermittivityUnit to)
        {
            switch (to)
            {
                case UnitToolsPermittivityUnit.FaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToFaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.PicofaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToPicofaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.NanofaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToNanofaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.MicrofaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToMicrofaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.VacuumPermittivity:
                    return UnitToolsScientificPermittivity.FaradPerMeterToVacuumPermittivity(baseValue);
                case UnitToolsPermittivityUnit.MillifaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToMillifaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.FemtofaradPerMeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToFemtofaradPerMeter(baseValue);
                case UnitToolsPermittivityUnit.FaradPerMillimeter:
                    return UnitToolsMetricPermittivity.FaradPerMeterToFaradPerMillimeter(baseValue);
                case UnitToolsPermittivityUnit.FaradPerInch:
                    return UnitToolsImperialPermittivity.FaradPerMeterToFaradPerInch(baseValue);
                case UnitToolsPermittivityUnit.RelativePermittivity:
                    return UnitToolsScientificPermittivity.FaradPerMeterToRelativePermittivity(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported permittivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPermittivityUnit.FaradPerMeter:
                    return "F/m";
                case UnitToolsPermittivityUnit.PicofaradPerMeter:
                    return "pF/m";
                case UnitToolsPermittivityUnit.NanofaradPerMeter:
                    return "nF/m";
                case UnitToolsPermittivityUnit.MicrofaradPerMeter:
                    return "µF/m";
                case UnitToolsPermittivityUnit.VacuumPermittivity:
                    return "ε₀";
                case UnitToolsPermittivityUnit.MillifaradPerMeter:
                    return "mF/m";
                case UnitToolsPermittivityUnit.FemtofaradPerMeter:
                    return "fF/m";
                case UnitToolsPermittivityUnit.FaradPerMillimeter:
                    return "F/mm";
                case UnitToolsPermittivityUnit.FaradPerInch:
                    return "F/in";
                case UnitToolsPermittivityUnit.RelativePermittivity:
                    return "εr·ε₀";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPermittivityUnit.FaradPerMeter:
                    return "Farad Per Meter";
                case UnitToolsPermittivityUnit.PicofaradPerMeter:
                    return "Picofarad Per Meter";
                case UnitToolsPermittivityUnit.NanofaradPerMeter:
                    return "Nanofarad Per Meter";
                case UnitToolsPermittivityUnit.MicrofaradPerMeter:
                    return "Microfarad Per Meter";
                case UnitToolsPermittivityUnit.VacuumPermittivity:
                    return "Vacuum Permittivity";
                case UnitToolsPermittivityUnit.MillifaradPerMeter:
                    return "Millifarad Per Meter";
                case UnitToolsPermittivityUnit.FemtofaradPerMeter:
                    return "Femtofarad Per Meter";
                case UnitToolsPermittivityUnit.FaradPerMillimeter:
                    return "Farad Per Millimeter";
                case UnitToolsPermittivityUnit.FaradPerInch:
                    return "Farad Per Inch";
                case UnitToolsPermittivityUnit.RelativePermittivity:
                    return "Relative Permittivity";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPermittivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPermittivityUnit.FaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.PicofaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.NanofaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.MicrofaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.VacuumPermittivity:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPermittivityUnit.MillifaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.FemtofaradPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.FaradPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPermittivityUnit.FaradPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPermittivityUnit.RelativePermittivity:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPermittivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPermittivityUnit.FaradPerMeter, UnitToolsPermittivityUnit.PicofaradPerMeter, UnitToolsPermittivityUnit.NanofaradPerMeter, UnitToolsPermittivityUnit.MicrofaradPerMeter, UnitToolsPermittivityUnit.MillifaradPerMeter, UnitToolsPermittivityUnit.FemtofaradPerMeter, UnitToolsPermittivityUnit.FaradPerMillimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsPermittivityUnit.VacuumPermittivity, UnitToolsPermittivityUnit.RelativePermittivity };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPermittivityUnit.FaradPerInch };
                default:
                    return new[] { UnitToolsPermittivityUnit.FaradPerMeter, UnitToolsPermittivityUnit.PicofaradPerMeter, UnitToolsPermittivityUnit.NanofaradPerMeter, UnitToolsPermittivityUnit.MicrofaradPerMeter, UnitToolsPermittivityUnit.VacuumPermittivity, UnitToolsPermittivityUnit.MillifaradPerMeter, UnitToolsPermittivityUnit.FemtofaradPerMeter, UnitToolsPermittivityUnit.FaradPerMillimeter, UnitToolsPermittivityUnit.FaradPerInch, UnitToolsPermittivityUnit.RelativePermittivity };
            }
        }
    }
}
