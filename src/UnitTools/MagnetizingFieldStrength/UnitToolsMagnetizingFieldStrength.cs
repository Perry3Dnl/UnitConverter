namespace UnitTools.MagnetizingFieldStrength
{
    using UnitTools.MagnetizingFieldStrength.Metric;
    using UnitTools.MagnetizingFieldStrength.Engineering;
    using UnitTools.MagnetizingFieldStrength.Scientific;
    using UnitTools.MagnetizingFieldStrength.Imperial;

    public enum UnitToolsMagnetizingFieldStrengthUnit
    {
        AmperePerMeter = 0,
        AmperePerCentimeter = 1,
        AmperePerMillimeter = 2,
        AmpereTurnPerMeter = 3,
        Oersted = 4,
        KiloamperePerMeter = 5,
        MilliamperePerMeter = 6,
        AmperePerInch = 7,
        AmpereTurnPerInch = 8,
        GilbertPerCentimeter = 9,
    }

    public static class UnitToolsMagnetizingFieldStrength
    {
        public static double Convert(double value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            double baseValue = ToAmperePerMeter(value, from);
            return FromAmperePerMeter(baseValue, to);
        }

        public static double ToAmperePerMeter(double value, UnitToolsMagnetizingFieldStrengthUnit from)
        {
            switch (from)
            {
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerCentimeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMillimeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitToolsEngineeringMagnetizingFieldStrength.AmpereTurnPerMeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.Oersted:
                    return UnitToolsScientificMagnetizingFieldStrength.OerstedToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.KiloamperePerMeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.MilliamperePerMeterToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitToolsImperialMagnetizingFieldStrength.AmperePerInchToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitToolsImperialMagnetizingFieldStrength.AmpereTurnPerInchToAmperePerMeter(value);
                case UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitToolsScientificMagnetizingFieldStrength.GilbertPerCentimeterToAmperePerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetizing field strength unit.");
            }
        }

        public static double FromAmperePerMeter(double baseValue, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            switch (to)
            {
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerCentimeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMillimeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitToolsEngineeringMagnetizingFieldStrength.AmperePerMeterToAmpereTurnPerMeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.Oersted:
                    return UnitToolsScientificMagnetizingFieldStrength.AmperePerMeterToOersted(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToKiloamperePerMeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitToolsMetricMagnetizingFieldStrength.AmperePerMeterToMilliamperePerMeter(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitToolsImperialMagnetizingFieldStrength.AmperePerMeterToAmperePerInch(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitToolsImperialMagnetizingFieldStrength.AmperePerMeterToAmpereTurnPerInch(baseValue);
                case UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitToolsScientificMagnetizingFieldStrength.AmperePerMeterToGilbertPerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetizing field strength unit.");
            }
        }

        public static string GetSymbol(UnitToolsMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return "A/m";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return "A/cm";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return "A/mm";
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return "At/m";
                case UnitToolsMagnetizingFieldStrengthUnit.Oersted:
                    return "Oe";
                case UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return "kA/m";
                case UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return "mA/m";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch:
                    return "A/in";
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return "At/in";
                case UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return "Gb/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return "Ampere Per Meter";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return "Ampere Per Centimeter";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return "Ampere Per Millimeter";
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return "Ampere Turn Per Meter";
                case UnitToolsMagnetizingFieldStrengthUnit.Oersted:
                    return "Oersted";
                case UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return "Kiloampere Per Meter";
                case UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return "Milliampere Per Meter";
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch:
                    return "Ampere Per Inch";
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return "Ampere Turn Per Inch";
                case UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return "Gilbert Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsMagnetizingFieldStrengthUnit.Oersted:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMagnetizingFieldStrengthUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter, UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter, UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter, UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter, UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsMagnetizingFieldStrengthUnit.Oersted, UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch, UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch };
                default:
                    return new[] { UnitToolsMagnetizingFieldStrengthUnit.AmperePerMeter, UnitToolsMagnetizingFieldStrengthUnit.AmperePerCentimeter, UnitToolsMagnetizingFieldStrengthUnit.AmperePerMillimeter, UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, UnitToolsMagnetizingFieldStrengthUnit.Oersted, UnitToolsMagnetizingFieldStrengthUnit.KiloamperePerMeter, UnitToolsMagnetizingFieldStrengthUnit.MilliamperePerMeter, UnitToolsMagnetizingFieldStrengthUnit.AmperePerInch, UnitToolsMagnetizingFieldStrengthUnit.AmpereTurnPerInch, UnitToolsMagnetizingFieldStrengthUnit.GilbertPerCentimeter };
            }
        }
    }
}
