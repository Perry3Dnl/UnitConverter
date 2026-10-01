namespace RealisticPhysics.UnitConversion.ElectricFlux
{
    using RealisticPhysics.UnitConversion.ElectricFlux.Metric;
    using RealisticPhysics.UnitConversion.ElectricFlux.Scientific;
    using RealisticPhysics.UnitConversion.ElectricFlux.Imperial;

    public enum UnitConverterElectricFluxUnit
    {
        VoltMeter = 0,
        KilovoltMeter = 1,
        VoltCentimeter = 2,
        StatvoltCentimeter = 3,
        MillivoltMeter = 4,
        MicrovoltMeter = 5,
        VoltMillimeter = 6,
        VoltInch = 7,
        VoltFoot = 8,
        NanovoltMeter = 9,
        PicovoltMeter = 10,
        MegavoltMeter = 11,
        GigavoltMeter = 12,
        VoltKilometer = 13,
        StatvoltMeter = 14,
    }

    public static class UnitConverterElectricFlux
    {
        public static double Convert(double value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            double baseValue = ToVoltMeter(value, from);
            return FromVoltMeter(baseValue, to);
        }

        public static double ToVoltMeter(double value, UnitConverterElectricFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricFluxUnit.VoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.KilovoltMeter:
                    return UnitConverterMetricElectricFlux.KilovoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.VoltCentimeter:
                    return UnitConverterMetricElectricFlux.VoltCentimeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.StatvoltCentimeter:
                    return UnitConverterScientificElectricFlux.StatvoltCentimeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.MillivoltMeter:
                    return UnitConverterMetricElectricFlux.MillivoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.MicrovoltMeter:
                    return UnitConverterMetricElectricFlux.MicrovoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.VoltMillimeter:
                    return UnitConverterMetricElectricFlux.VoltMillimeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.VoltInch:
                    return UnitConverterImperialElectricFlux.VoltInchToVoltMeter(value);
                case UnitConverterElectricFluxUnit.VoltFoot:
                    return UnitConverterImperialElectricFlux.VoltFootToVoltMeter(value);
                case UnitConverterElectricFluxUnit.NanovoltMeter:
                    return UnitConverterMetricElectricFlux.NanovoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.PicovoltMeter:
                    return UnitConverterMetricElectricFlux.PicovoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.MegavoltMeter:
                    return UnitConverterMetricElectricFlux.MegavoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.GigavoltMeter:
                    return UnitConverterMetricElectricFlux.GigavoltMeterToVoltMeter(value);
                case UnitConverterElectricFluxUnit.VoltKilometer:
                    return UnitConverterMetricElectricFlux.VoltKilometerToVoltMeter(value);
                case UnitConverterElectricFluxUnit.StatvoltMeter:
                    return UnitConverterScientificElectricFlux.StatvoltMeterToVoltMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric flux unit.");
            }
        }

        public static double FromVoltMeter(double baseValue, UnitConverterElectricFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricFluxUnit.VoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToVoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.KilovoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToKilovoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.VoltCentimeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToVoltCentimeter(baseValue);
                case UnitConverterElectricFluxUnit.StatvoltCentimeter:
                    return UnitConverterScientificElectricFlux.VoltMeterToStatvoltCentimeter(baseValue);
                case UnitConverterElectricFluxUnit.MillivoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToMillivoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.MicrovoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToMicrovoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.VoltMillimeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToVoltMillimeter(baseValue);
                case UnitConverterElectricFluxUnit.VoltInch:
                    return UnitConverterImperialElectricFlux.VoltMeterToVoltInch(baseValue);
                case UnitConverterElectricFluxUnit.VoltFoot:
                    return UnitConverterImperialElectricFlux.VoltMeterToVoltFoot(baseValue);
                case UnitConverterElectricFluxUnit.NanovoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToNanovoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.PicovoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToPicovoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.MegavoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToMegavoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.GigavoltMeter:
                    return UnitConverterMetricElectricFlux.VoltMeterToGigavoltMeter(baseValue);
                case UnitConverterElectricFluxUnit.VoltKilometer:
                    return UnitConverterMetricElectricFlux.VoltMeterToVoltKilometer(baseValue);
                case UnitConverterElectricFluxUnit.StatvoltMeter:
                    return UnitConverterScientificElectricFlux.VoltMeterToStatvoltMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxUnit.VoltMeter:
                    return "V·m";
                case UnitConverterElectricFluxUnit.KilovoltMeter:
                    return "kV·m";
                case UnitConverterElectricFluxUnit.VoltCentimeter:
                    return "V·cm";
                case UnitConverterElectricFluxUnit.StatvoltCentimeter:
                    return "statV·cm";
                case UnitConverterElectricFluxUnit.MillivoltMeter:
                    return "mV·m";
                case UnitConverterElectricFluxUnit.MicrovoltMeter:
                    return "µV·m";
                case UnitConverterElectricFluxUnit.VoltMillimeter:
                    return "V·mm";
                case UnitConverterElectricFluxUnit.VoltInch:
                    return "V·in";
                case UnitConverterElectricFluxUnit.VoltFoot:
                    return "V·ft";
                case UnitConverterElectricFluxUnit.NanovoltMeter:
                    return "nV·m";
                case UnitConverterElectricFluxUnit.PicovoltMeter:
                    return "pV·m";
                case UnitConverterElectricFluxUnit.MegavoltMeter:
                    return "MV·m";
                case UnitConverterElectricFluxUnit.GigavoltMeter:
                    return "GV·m";
                case UnitConverterElectricFluxUnit.VoltKilometer:
                    return "V·km";
                case UnitConverterElectricFluxUnit.StatvoltMeter:
                    return "statV·m";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxUnit.VoltMeter:
                    return "Volt Meter";
                case UnitConverterElectricFluxUnit.KilovoltMeter:
                    return "Kilovolt Meter";
                case UnitConverterElectricFluxUnit.VoltCentimeter:
                    return "Volt Centimeter";
                case UnitConverterElectricFluxUnit.StatvoltCentimeter:
                    return "Statvolt Centimeter";
                case UnitConverterElectricFluxUnit.MillivoltMeter:
                    return "Millivolt Meter";
                case UnitConverterElectricFluxUnit.MicrovoltMeter:
                    return "Microvolt Meter";
                case UnitConverterElectricFluxUnit.VoltMillimeter:
                    return "Volt Millimeter";
                case UnitConverterElectricFluxUnit.VoltInch:
                    return "Volt Inch";
                case UnitConverterElectricFluxUnit.VoltFoot:
                    return "Volt Foot";
                case UnitConverterElectricFluxUnit.NanovoltMeter:
                    return "Nanovolt Meter";
                case UnitConverterElectricFluxUnit.PicovoltMeter:
                    return "Picovolt Meter";
                case UnitConverterElectricFluxUnit.MegavoltMeter:
                    return "Megavolt Meter";
                case UnitConverterElectricFluxUnit.GigavoltMeter:
                    return "Gigavolt Meter";
                case UnitConverterElectricFluxUnit.VoltKilometer:
                    return "Volt Kilometer";
                case UnitConverterElectricFluxUnit.StatvoltMeter:
                    return "Statvolt Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxUnit.VoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.KilovoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.VoltCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.StatvoltCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricFluxUnit.MillivoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.MicrovoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.VoltMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.VoltInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFluxUnit.VoltFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFluxUnit.NanovoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.PicovoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.MegavoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.GigavoltMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.VoltKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxUnit.StatvoltMeter:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricFluxUnit.VoltMeter, UnitConverterElectricFluxUnit.KilovoltMeter, UnitConverterElectricFluxUnit.VoltCentimeter, UnitConverterElectricFluxUnit.MillivoltMeter, UnitConverterElectricFluxUnit.MicrovoltMeter, UnitConverterElectricFluxUnit.VoltMillimeter, UnitConverterElectricFluxUnit.NanovoltMeter, UnitConverterElectricFluxUnit.PicovoltMeter, UnitConverterElectricFluxUnit.MegavoltMeter, UnitConverterElectricFluxUnit.GigavoltMeter, UnitConverterElectricFluxUnit.VoltKilometer };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricFluxUnit.StatvoltCentimeter, UnitConverterElectricFluxUnit.StatvoltMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterElectricFluxUnit.VoltInch, UnitConverterElectricFluxUnit.VoltFoot };
                default:
                    return new[] { UnitConverterElectricFluxUnit.VoltMeter, UnitConverterElectricFluxUnit.KilovoltMeter, UnitConverterElectricFluxUnit.VoltCentimeter, UnitConverterElectricFluxUnit.StatvoltCentimeter, UnitConverterElectricFluxUnit.MillivoltMeter, UnitConverterElectricFluxUnit.MicrovoltMeter, UnitConverterElectricFluxUnit.VoltMillimeter, UnitConverterElectricFluxUnit.VoltInch, UnitConverterElectricFluxUnit.VoltFoot, UnitConverterElectricFluxUnit.NanovoltMeter, UnitConverterElectricFluxUnit.PicovoltMeter, UnitConverterElectricFluxUnit.MegavoltMeter, UnitConverterElectricFluxUnit.GigavoltMeter, UnitConverterElectricFluxUnit.VoltKilometer, UnitConverterElectricFluxUnit.StatvoltMeter };
            }
        }
    }
}
