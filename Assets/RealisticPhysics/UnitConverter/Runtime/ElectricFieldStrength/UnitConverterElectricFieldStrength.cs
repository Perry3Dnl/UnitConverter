namespace RealisticPhysics.UnitConversion.ElectricFieldStrength
{
    using RealisticPhysics.UnitConversion.ElectricFieldStrength.Metric;
    using RealisticPhysics.UnitConversion.ElectricFieldStrength.Scientific;
    using RealisticPhysics.UnitConversion.ElectricFieldStrength.Imperial;

    public enum UnitConverterElectricFieldStrengthUnit
    {
        VoltPerMeter = 0,
        MillivoltPerMeter = 1,
        KilovoltPerMeter = 2,
        VoltPerCentimeter = 3,
        VoltPerMillimeter = 4,
        StatvoltPerCentimeter = 5,
        MicrovoltPerMeter = 6,
        MegavoltPerMeter = 7,
        KilovoltPerCentimeter = 8,
        VoltPerInch = 9,
        VoltPerFoot = 10,
        NanovoltPerMeter = 11,
        GigavoltPerMeter = 12,
        StatvoltPerMeter = 13,
        AbvoltPerCentimeter = 14,
    }

    public static class UnitConverterElectricFieldStrength
    {
        public static double Convert(double value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            double baseValue = ToVoltPerMeter(value, from);
            return FromVoltPerMeter(baseValue, to);
        }

        public static double ToVoltPerMeter(double value, UnitConverterElectricFieldStrengthUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.MillivoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.KilovoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerCentimeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMillimeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitConverterScientificElectricFieldStrength.StatvoltPerCentimeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.MicrovoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.MegavoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitConverterMetricElectricFieldStrength.KilovoltPerCentimeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.VoltPerInch:
                    return UnitConverterImperialElectricFieldStrength.VoltPerInchToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitConverterImperialElectricFieldStrength.VoltPerFootToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.NanovoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.GigavoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitConverterScientificElectricFieldStrength.StatvoltPerMeterToVoltPerMeter(value);
                case UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitConverterScientificElectricFieldStrength.AbvoltPerCentimeterToVoltPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric field strength unit.");
            }
        }

        public static double FromVoltPerMeter(double baseValue, UnitConverterElectricFieldStrengthUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToVoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToMillivoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToKilovoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToVoltPerCentimeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToVoltPerMillimeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitConverterScientificElectricFieldStrength.VoltPerMeterToStatvoltPerCentimeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToMicrovoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToMegavoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToKilovoltPerCentimeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.VoltPerInch:
                    return UnitConverterImperialElectricFieldStrength.VoltPerMeterToVoltPerInch(baseValue);
                case UnitConverterElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitConverterImperialElectricFieldStrength.VoltPerMeterToVoltPerFoot(baseValue);
                case UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToNanovoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitConverterMetricElectricFieldStrength.VoltPerMeterToGigavoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitConverterScientificElectricFieldStrength.VoltPerMeterToStatvoltPerMeter(baseValue);
                case UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitConverterScientificElectricFieldStrength.VoltPerMeterToAbvoltPerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric field strength unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFieldStrengthUnit.VoltPerMeter:
                    return "V/m";
                case UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter:
                    return "mV/m";
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter:
                    return "kV/m";
                case UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter:
                    return "V/cm";
                case UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter:
                    return "V/mm";
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return "statV/cm";
                case UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return "µV/m";
                case UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter:
                    return "MV/m";
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return "kV/cm";
                case UnitConverterElectricFieldStrengthUnit.VoltPerInch:
                    return "V/in";
                case UnitConverterElectricFieldStrengthUnit.VoltPerFoot:
                    return "V/ft";
                case UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter:
                    return "nV/m";
                case UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter:
                    return "GV/m";
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter:
                    return "statV/m";
                case UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return "abV/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFieldStrengthUnit.VoltPerMeter:
                    return "Volt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter:
                    return "Millivolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter:
                    return "Kilovolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter:
                    return "Volt Per Centimeter";
                case UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter:
                    return "Volt Per Millimeter";
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return "Statvolt Per Centimeter";
                case UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return "Microvolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter:
                    return "Megavolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return "Kilovolt Per Centimeter";
                case UnitConverterElectricFieldStrengthUnit.VoltPerInch:
                    return "Volt Per Inch";
                case UnitConverterElectricFieldStrengthUnit.VoltPerFoot:
                    return "Volt Per Foot";
                case UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter:
                    return "Nanovolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter:
                    return "Gigavolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter:
                    return "Statvolt Per Meter";
                case UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return "Abvolt Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.VoltPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricFieldStrengthUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricFieldStrengthUnit.VoltPerMeter, UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter, UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter, UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter, UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter, UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter, UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter, UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter, UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterElectricFieldStrengthUnit.VoltPerInch, UnitConverterElectricFieldStrengthUnit.VoltPerFoot };
                default:
                    return new[] { UnitConverterElectricFieldStrengthUnit.VoltPerMeter, UnitConverterElectricFieldStrengthUnit.MillivoltPerMeter, UnitConverterElectricFieldStrengthUnit.KilovoltPerMeter, UnitConverterElectricFieldStrengthUnit.VoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.VoltPerMillimeter, UnitConverterElectricFieldStrengthUnit.StatvoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.MicrovoltPerMeter, UnitConverterElectricFieldStrengthUnit.MegavoltPerMeter, UnitConverterElectricFieldStrengthUnit.KilovoltPerCentimeter, UnitConverterElectricFieldStrengthUnit.VoltPerInch, UnitConverterElectricFieldStrengthUnit.VoltPerFoot, UnitConverterElectricFieldStrengthUnit.NanovoltPerMeter, UnitConverterElectricFieldStrengthUnit.GigavoltPerMeter, UnitConverterElectricFieldStrengthUnit.StatvoltPerMeter, UnitConverterElectricFieldStrengthUnit.AbvoltPerCentimeter };
            }
        }
    }
}
