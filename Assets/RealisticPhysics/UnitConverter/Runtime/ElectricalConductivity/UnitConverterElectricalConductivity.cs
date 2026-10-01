namespace RealisticPhysics.UnitConversion.ElectricalConductivity
{
    using RealisticPhysics.UnitConversion.ElectricalConductivity.Metric;
    using RealisticPhysics.UnitConversion.ElectricalConductivity.Scientific;

    public enum UnitConverterElectricalConductivityUnit
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

    public static class UnitConverterElectricalConductivity
    {
        public static double Convert(double value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            double baseValue = ToSiemensPerMeter(value, from);
            return FromSiemensPerMeter(baseValue, to);
        }

        public static double ToSiemensPerMeter(double value, UnitConverterElectricalConductivityUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricalConductivityUnit.SiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.MillisiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.MicrosiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerCentimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitConverterMetricElectricalConductivity.MillisiemensPerCentimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.MegasiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.NanosiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.KilosiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMillimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitConverterScientificElectricalConductivity.AbmhoPerCentimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitConverterScientificElectricalConductivity.StatmhoPerCentimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.PicosiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.GigasiemensPerMeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitConverterMetricElectricalConductivity.MicrosiemensPerMillimeterToSiemensPerMeter(value);
                case UnitConverterElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitConverterScientificElectricalConductivity.StatmhoPerMeterToSiemensPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electrical conductivity unit.");
            }
        }

        public static double FromSiemensPerMeter(double baseValue, UnitConverterElectricalConductivityUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricalConductivityUnit.SiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToSiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToMillisiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToMicrosiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToSiemensPerCentimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToMillisiemensPerCentimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToMegasiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToNanosiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToKilosiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToSiemensPerMillimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitConverterScientificElectricalConductivity.SiemensPerMeterToAbmhoPerCentimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitConverterScientificElectricalConductivity.SiemensPerMeterToStatmhoPerCentimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToPicosiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToGigasiemensPerMeter(baseValue);
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitConverterMetricElectricalConductivity.SiemensPerMeterToMicrosiemensPerMillimeter(baseValue);
                case UnitConverterElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitConverterScientificElectricalConductivity.SiemensPerMeterToStatmhoPerMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electrical conductivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalConductivityUnit.SiemensPerMeter:
                    return "S/m";
                case UnitConverterElectricalConductivityUnit.MillisiemensPerMeter:
                    return "mS/m";
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter:
                    return "µS/m";
                case UnitConverterElectricalConductivityUnit.SiemensPerCentimeter:
                    return "S/cm";
                case UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return "mS/cm";
                case UnitConverterElectricalConductivityUnit.MegasiemensPerMeter:
                    return "MS/m";
                case UnitConverterElectricalConductivityUnit.NanosiemensPerMeter:
                    return "nS/m";
                case UnitConverterElectricalConductivityUnit.KilosiemensPerMeter:
                    return "kS/m";
                case UnitConverterElectricalConductivityUnit.SiemensPerMillimeter:
                    return "S/mm";
                case UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter:
                    return "abmho/cm";
                case UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter:
                    return "statmho/cm";
                case UnitConverterElectricalConductivityUnit.PicosiemensPerMeter:
                    return "pS/m";
                case UnitConverterElectricalConductivityUnit.GigasiemensPerMeter:
                    return "GS/m";
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return "µS/mm";
                case UnitConverterElectricalConductivityUnit.StatmhoPerMeter:
                    return "statmho/m";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalConductivityUnit.SiemensPerMeter:
                    return "Siemens Per Meter";
                case UnitConverterElectricalConductivityUnit.MillisiemensPerMeter:
                    return "Millisiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter:
                    return "Microsiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.SiemensPerCentimeter:
                    return "Siemens Per Centimeter";
                case UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return "Millisiemens Per Centimeter";
                case UnitConverterElectricalConductivityUnit.MegasiemensPerMeter:
                    return "Megasiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.NanosiemensPerMeter:
                    return "Nanosiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.KilosiemensPerMeter:
                    return "Kilosiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.SiemensPerMillimeter:
                    return "Siemens Per Millimeter";
                case UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter:
                    return "Abmho Per Centimeter";
                case UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter:
                    return "Statmho Per Centimeter";
                case UnitConverterElectricalConductivityUnit.PicosiemensPerMeter:
                    return "Picosiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.GigasiemensPerMeter:
                    return "Gigasiemens Per Meter";
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return "Microsiemens Per Millimeter";
                case UnitConverterElectricalConductivityUnit.StatmhoPerMeter:
                    return "Statmho Per Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalConductivityUnit.SiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.MillisiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.SiemensPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.MegasiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.NanosiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.KilosiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.SiemensPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricalConductivityUnit.PicosiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.GigasiemensPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalConductivityUnit.StatmhoPerMeter:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricalConductivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricalConductivityUnit.SiemensPerMeter, UnitConverterElectricalConductivityUnit.MillisiemensPerMeter, UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter, UnitConverterElectricalConductivityUnit.SiemensPerCentimeter, UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter, UnitConverterElectricalConductivityUnit.MegasiemensPerMeter, UnitConverterElectricalConductivityUnit.NanosiemensPerMeter, UnitConverterElectricalConductivityUnit.KilosiemensPerMeter, UnitConverterElectricalConductivityUnit.SiemensPerMillimeter, UnitConverterElectricalConductivityUnit.PicosiemensPerMeter, UnitConverterElectricalConductivityUnit.GigasiemensPerMeter, UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter, UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter, UnitConverterElectricalConductivityUnit.StatmhoPerMeter };
                default:
                    return new[] { UnitConverterElectricalConductivityUnit.SiemensPerMeter, UnitConverterElectricalConductivityUnit.MillisiemensPerMeter, UnitConverterElectricalConductivityUnit.MicrosiemensPerMeter, UnitConverterElectricalConductivityUnit.SiemensPerCentimeter, UnitConverterElectricalConductivityUnit.MillisiemensPerCentimeter, UnitConverterElectricalConductivityUnit.MegasiemensPerMeter, UnitConverterElectricalConductivityUnit.NanosiemensPerMeter, UnitConverterElectricalConductivityUnit.KilosiemensPerMeter, UnitConverterElectricalConductivityUnit.SiemensPerMillimeter, UnitConverterElectricalConductivityUnit.AbmhoPerCentimeter, UnitConverterElectricalConductivityUnit.StatmhoPerCentimeter, UnitConverterElectricalConductivityUnit.PicosiemensPerMeter, UnitConverterElectricalConductivityUnit.GigasiemensPerMeter, UnitConverterElectricalConductivityUnit.MicrosiemensPerMillimeter, UnitConverterElectricalConductivityUnit.StatmhoPerMeter };
            }
        }
    }
}
