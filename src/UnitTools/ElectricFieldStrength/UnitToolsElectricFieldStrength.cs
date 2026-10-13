namespace UnitTools.ElectricFieldStrength
{
    using UnitTools.ElectricFieldStrength.Metric;
    using UnitTools.ElectricFieldStrength.Scientific;
    using UnitTools.ElectricFieldStrength.Imperial;

    public enum UnitToolsElectricFieldStrengthUnit
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

    public static class UnitToolsElectricFieldStrength
    {
        public static double Convert(double value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            double baseValue = ToVoltPerMeter(value, from);
            return FromVoltPerMeter(baseValue, to);
        }

        public static double ToVoltPerMeter(double value, UnitToolsElectricFieldStrengthUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.MillivoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.KilovoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerCentimeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMillimeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitToolsScientificElectricFieldStrength.StatvoltPerCentimeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.MicrovoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.MegavoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitToolsMetricElectricFieldStrength.KilovoltPerCentimeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.VoltPerInch:
                    return UnitToolsImperialElectricFieldStrength.VoltPerInchToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitToolsImperialElectricFieldStrength.VoltPerFootToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.NanovoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.GigavoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitToolsScientificElectricFieldStrength.StatvoltPerMeterToVoltPerMeter(value);
                case UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitToolsScientificElectricFieldStrength.AbvoltPerCentimeterToVoltPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric field strength unit.");
            }
        }

        public static double FromVoltPerMeter(double baseValue, UnitToolsElectricFieldStrengthUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToVoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToMillivoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToKilovoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToVoltPerCentimeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToVoltPerMillimeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitToolsScientificElectricFieldStrength.VoltPerMeterToStatvoltPerCentimeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToMicrovoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToMegavoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToKilovoltPerCentimeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.VoltPerInch:
                    return UnitToolsImperialElectricFieldStrength.VoltPerMeterToVoltPerInch(baseValue);
                case UnitToolsElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitToolsImperialElectricFieldStrength.VoltPerMeterToVoltPerFoot(baseValue);
                case UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToNanovoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitToolsMetricElectricFieldStrength.VoltPerMeterToGigavoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitToolsScientificElectricFieldStrength.VoltPerMeterToStatvoltPerMeter(baseValue);
                case UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitToolsScientificElectricFieldStrength.VoltPerMeterToAbvoltPerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric field strength unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFieldStrengthUnit.VoltPerMeter:
                    return "V/m";
                case UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter:
                    return "mV/m";
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter:
                    return "kV/m";
                case UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter:
                    return "V/cm";
                case UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter:
                    return "V/mm";
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return "statV/cm";
                case UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return "µV/m";
                case UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter:
                    return "MV/m";
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return "kV/cm";
                case UnitToolsElectricFieldStrengthUnit.VoltPerInch:
                    return "V/in";
                case UnitToolsElectricFieldStrengthUnit.VoltPerFoot:
                    return "V/ft";
                case UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter:
                    return "nV/m";
                case UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter:
                    return "GV/m";
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter:
                    return "statV/m";
                case UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return "abV/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFieldStrengthUnit.VoltPerMeter:
                    return "Volt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter:
                    return "Millivolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter:
                    return "Kilovolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter:
                    return "Volt Per Centimeter";
                case UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter:
                    return "Volt Per Millimeter";
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return "Statvolt Per Centimeter";
                case UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return "Microvolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter:
                    return "Megavolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return "Kilovolt Per Centimeter";
                case UnitToolsElectricFieldStrengthUnit.VoltPerInch:
                    return "Volt Per Inch";
                case UnitToolsElectricFieldStrengthUnit.VoltPerFoot:
                    return "Volt Per Foot";
                case UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter:
                    return "Nanovolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter:
                    return "Gigavolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter:
                    return "Statvolt Per Meter";
                case UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return "Abvolt Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricFieldStrengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFieldStrengthUnit.VoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.VoltPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFieldStrengthUnit.VoltPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricFieldStrengthUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricFieldStrengthUnit.VoltPerMeter, UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter, UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter, UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter, UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter, UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter, UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter, UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter, UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsElectricFieldStrengthUnit.VoltPerInch, UnitToolsElectricFieldStrengthUnit.VoltPerFoot };
                default:
                    return new[] { UnitToolsElectricFieldStrengthUnit.VoltPerMeter, UnitToolsElectricFieldStrengthUnit.MillivoltPerMeter, UnitToolsElectricFieldStrengthUnit.KilovoltPerMeter, UnitToolsElectricFieldStrengthUnit.VoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.VoltPerMillimeter, UnitToolsElectricFieldStrengthUnit.StatvoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.MicrovoltPerMeter, UnitToolsElectricFieldStrengthUnit.MegavoltPerMeter, UnitToolsElectricFieldStrengthUnit.KilovoltPerCentimeter, UnitToolsElectricFieldStrengthUnit.VoltPerInch, UnitToolsElectricFieldStrengthUnit.VoltPerFoot, UnitToolsElectricFieldStrengthUnit.NanovoltPerMeter, UnitToolsElectricFieldStrengthUnit.GigavoltPerMeter, UnitToolsElectricFieldStrengthUnit.StatvoltPerMeter, UnitToolsElectricFieldStrengthUnit.AbvoltPerCentimeter };
            }
        }
    }
}
