namespace UnitTools.ElectricalConductivity
{
    using UnitTools.ElectricalConductivity.Metric;
    using UnitTools.ElectricalConductivity.Scientific;

    public enum UnitToolsElectricalConductivityUnit
    {
        SiemensPerMeter = 0,
        MillisiemensPerMeter = 1,
        MicrosiemensPerMeter = 2,
        SiemensPerCentimeter = 3,
        MillisiemensPerCentimeter = 4,
        MegasiemensPerMeter = 5,
        NanosiemensPerMeter = 6,
        KilosiemensPerMeter = 7,
        SiemensPerMillimeter = 8,
        AbmhoPerCentimeter = 9,
        StatmhoPerCentimeter = 10,
        PicosiemensPerMeter = 11,
        GigasiemensPerMeter = 12,
        MicrosiemensPerMillimeter = 13,
        StatmhoPerMeter = 14,
    }

    public static class UnitToolsElectricalConductivity
    {
        public static double Convert(double value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            double baseValue = ToSiemensPerMeter(value, from);
            return FromSiemensPerMeter(baseValue, to);
        }

        public static double ToSiemensPerMeter(double value, UnitToolsElectricalConductivityUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricalConductivityUnit.SiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.MillisiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.MicrosiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerCentimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitToolsMetricElectricalConductivity.MillisiemensPerCentimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.MegasiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.NanosiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.KilosiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMillimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitToolsScientificElectricalConductivity.AbmhoPerCentimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitToolsScientificElectricalConductivity.StatmhoPerCentimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.PicosiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.GigasiemensPerMeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitToolsMetricElectricalConductivity.MicrosiemensPerMillimeterToSiemensPerMeter(value);
                case UnitToolsElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitToolsScientificElectricalConductivity.StatmhoPerMeterToSiemensPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electrical conductivity unit.");
            }
        }

        public static double FromSiemensPerMeter(double baseValue, UnitToolsElectricalConductivityUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricalConductivityUnit.SiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToSiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToMillisiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToMicrosiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToSiemensPerCentimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToMillisiemensPerCentimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToMegasiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToNanosiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToKilosiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToSiemensPerMillimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitToolsScientificElectricalConductivity.SiemensPerMeterToAbmhoPerCentimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitToolsScientificElectricalConductivity.SiemensPerMeterToStatmhoPerCentimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToPicosiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToGigasiemensPerMeter(baseValue);
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitToolsMetricElectricalConductivity.SiemensPerMeterToMicrosiemensPerMillimeter(baseValue);
                case UnitToolsElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitToolsScientificElectricalConductivity.SiemensPerMeterToStatmhoPerMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electrical conductivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalConductivityUnit.SiemensPerMeter:
                    return "S/m";
                case UnitToolsElectricalConductivityUnit.MillisiemensPerMeter:
                    return "mS/m";
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter:
                    return "µS/m";
                case UnitToolsElectricalConductivityUnit.SiemensPerCentimeter:
                    return "S/cm";
                case UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return "mS/cm";
                case UnitToolsElectricalConductivityUnit.MegasiemensPerMeter:
                    return "MS/m";
                case UnitToolsElectricalConductivityUnit.NanosiemensPerMeter:
                    return "nS/m";
                case UnitToolsElectricalConductivityUnit.KilosiemensPerMeter:
                    return "kS/m";
                case UnitToolsElectricalConductivityUnit.SiemensPerMillimeter:
                    return "S/mm";
                case UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter:
                    return "abmho/cm";
                case UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter:
                    return "statmho/cm";
                case UnitToolsElectricalConductivityUnit.PicosiemensPerMeter:
                    return "pS/m";
                case UnitToolsElectricalConductivityUnit.GigasiemensPerMeter:
                    return "GS/m";
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return "µS/mm";
                case UnitToolsElectricalConductivityUnit.StatmhoPerMeter:
                    return "statmho/m";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalConductivityUnit.SiemensPerMeter:
                    return "Siemens Per Meter";
                case UnitToolsElectricalConductivityUnit.MillisiemensPerMeter:
                    return "Millisiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter:
                    return "Microsiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.SiemensPerCentimeter:
                    return "Siemens Per Centimeter";
                case UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return "Millisiemens Per Centimeter";
                case UnitToolsElectricalConductivityUnit.MegasiemensPerMeter:
                    return "Megasiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.NanosiemensPerMeter:
                    return "Nanosiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.KilosiemensPerMeter:
                    return "Kilosiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.SiemensPerMillimeter:
                    return "Siemens Per Millimeter";
                case UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter:
                    return "Abmho Per Centimeter";
                case UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter:
                    return "Statmho Per Centimeter";
                case UnitToolsElectricalConductivityUnit.PicosiemensPerMeter:
                    return "Picosiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.GigasiemensPerMeter:
                    return "Gigasiemens Per Meter";
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return "Microsiemens Per Millimeter";
                case UnitToolsElectricalConductivityUnit.StatmhoPerMeter:
                    return "Statmho Per Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalConductivityUnit.SiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricalConductivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricalConductivityUnit.SiemensPerMeter, UnitToolsElectricalConductivityUnit.MillisiemensPerMeter, UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter, UnitToolsElectricalConductivityUnit.SiemensPerCentimeter, UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter, UnitToolsElectricalConductivityUnit.MegasiemensPerMeter, UnitToolsElectricalConductivityUnit.NanosiemensPerMeter, UnitToolsElectricalConductivityUnit.KilosiemensPerMeter, UnitToolsElectricalConductivityUnit.SiemensPerMillimeter, UnitToolsElectricalConductivityUnit.PicosiemensPerMeter, UnitToolsElectricalConductivityUnit.GigasiemensPerMeter, UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter, UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter, UnitToolsElectricalConductivityUnit.StatmhoPerMeter };
                default:
                    return new[] { UnitToolsElectricalConductivityUnit.SiemensPerMeter, UnitToolsElectricalConductivityUnit.MillisiemensPerMeter, UnitToolsElectricalConductivityUnit.MicrosiemensPerMeter, UnitToolsElectricalConductivityUnit.SiemensPerCentimeter, UnitToolsElectricalConductivityUnit.MillisiemensPerCentimeter, UnitToolsElectricalConductivityUnit.MegasiemensPerMeter, UnitToolsElectricalConductivityUnit.NanosiemensPerMeter, UnitToolsElectricalConductivityUnit.KilosiemensPerMeter, UnitToolsElectricalConductivityUnit.SiemensPerMillimeter, UnitToolsElectricalConductivityUnit.AbmhoPerCentimeter, UnitToolsElectricalConductivityUnit.StatmhoPerCentimeter, UnitToolsElectricalConductivityUnit.PicosiemensPerMeter, UnitToolsElectricalConductivityUnit.GigasiemensPerMeter, UnitToolsElectricalConductivityUnit.MicrosiemensPerMillimeter, UnitToolsElectricalConductivityUnit.StatmhoPerMeter };
            }
        }
    }
}
