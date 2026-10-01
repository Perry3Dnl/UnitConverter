namespace RealisticPhysics.UnitConversion.MagnetizingFieldStrength
{
    using RealisticPhysics.UnitConversion.MagnetizingFieldStrength.Metric;
    using RealisticPhysics.UnitConversion.MagnetizingFieldStrength.Engineering;
    using RealisticPhysics.UnitConversion.MagnetizingFieldStrength.Scientific;
    using RealisticPhysics.UnitConversion.MagnetizingFieldStrength.Imperial;

    public enum UnitConverterMagnetizingFieldStrengthUnit
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

    public static class UnitConverterMagnetizingFieldStrength
    {
        public static double Convert(double value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            double baseValue = ToAmperePerMeter(value, from);
            return FromAmperePerMeter(baseValue, to);
        }

        public static double ToAmperePerMeter(double value, UnitConverterMagnetizingFieldStrengthUnit from)
        {
            switch (from)
            {
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerCentimeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMillimeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitConverterEngineeringMagnetizingFieldStrength.AmpereTurnPerMeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.Oersted:
                    return UnitConverterScientificMagnetizingFieldStrength.OerstedToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.KiloamperePerMeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.MilliamperePerMeterToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitConverterImperialMagnetizingFieldStrength.AmperePerInchToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitConverterImperialMagnetizingFieldStrength.AmpereTurnPerInchToAmperePerMeter(value);
                case UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitConverterScientificMagnetizingFieldStrength.GilbertPerCentimeterToAmperePerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetizing field strength unit.");
            }
        }

        public static double FromAmperePerMeter(double baseValue, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            switch (to)
            {
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerCentimeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToAmperePerMillimeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitConverterEngineeringMagnetizingFieldStrength.AmperePerMeterToAmpereTurnPerMeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.Oersted:
                    return UnitConverterScientificMagnetizingFieldStrength.AmperePerMeterToOersted(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToKiloamperePerMeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitConverterMetricMagnetizingFieldStrength.AmperePerMeterToMilliamperePerMeter(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitConverterImperialMagnetizingFieldStrength.AmperePerMeterToAmperePerInch(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitConverterImperialMagnetizingFieldStrength.AmperePerMeterToAmpereTurnPerInch(baseValue);
                case UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitConverterScientificMagnetizingFieldStrength.AmperePerMeterToGilbertPerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetizing field strength unit.");
            }
        }

        public static string GetSymbol(UnitConverterMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return "A/m";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return "A/cm";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return "A/mm";
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return "At/m";
                case UnitConverterMagnetizingFieldStrengthUnit.Oersted:
                    return "Oe";
                case UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return "kA/m";
                case UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return "mA/m";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch:
                    return "A/in";
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return "At/in";
                case UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return "Gb/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return "Ampere Per Meter";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return "Ampere Per Centimeter";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return "Ampere Per Millimeter";
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return "Ampere Turn Per Meter";
                case UnitConverterMagnetizingFieldStrengthUnit.Oersted:
                    return "Oersted";
                case UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return "Kiloampere Per Meter";
                case UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return "Milliampere Per Meter";
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch:
                    return "Ampere Per Inch";
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return "Ampere Turn Per Inch";
                case UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return "Gilbert Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMagnetizingFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterMagnetizingFieldStrengthUnit.Oersted:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMagnetizingFieldStrengthUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter, UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter, UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter, UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter, UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterMagnetizingFieldStrengthUnit.Oersted, UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch, UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch };
                default:
                    return new[] { UnitConverterMagnetizingFieldStrengthUnit.AmperePerMeter, UnitConverterMagnetizingFieldStrengthUnit.AmperePerCentimeter, UnitConverterMagnetizingFieldStrengthUnit.AmperePerMillimeter, UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerMeter, UnitConverterMagnetizingFieldStrengthUnit.Oersted, UnitConverterMagnetizingFieldStrengthUnit.KiloamperePerMeter, UnitConverterMagnetizingFieldStrengthUnit.MilliamperePerMeter, UnitConverterMagnetizingFieldStrengthUnit.AmperePerInch, UnitConverterMagnetizingFieldStrengthUnit.AmpereTurnPerInch, UnitConverterMagnetizingFieldStrengthUnit.GilbertPerCentimeter };
            }
        }
    }
}
