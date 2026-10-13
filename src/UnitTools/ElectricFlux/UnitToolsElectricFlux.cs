namespace UnitTools.ElectricFlux
{
    using UnitTools.ElectricFlux.Metric;
    using UnitTools.ElectricFlux.Scientific;
    using UnitTools.ElectricFlux.Imperial;

    public enum UnitToolsElectricFluxUnit
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

    public static class UnitToolsElectricFlux
    {
        public static double Convert(double value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            double baseValue = ToVoltMeter(value, from);
            return FromVoltMeter(baseValue, to);
        }

        public static double ToVoltMeter(double value, UnitToolsElectricFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricFluxUnit.VoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.KilovoltMeter:
                    return UnitToolsMetricElectricFlux.KilovoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.VoltCentimeter:
                    return UnitToolsMetricElectricFlux.VoltCentimeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.StatvoltCentimeter:
                    return UnitToolsScientificElectricFlux.StatvoltCentimeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.MillivoltMeter:
                    return UnitToolsMetricElectricFlux.MillivoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.MicrovoltMeter:
                    return UnitToolsMetricElectricFlux.MicrovoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.VoltMillimeter:
                    return UnitToolsMetricElectricFlux.VoltMillimeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.VoltInch:
                    return UnitToolsImperialElectricFlux.VoltInchToVoltMeter(value);
                case UnitToolsElectricFluxUnit.VoltFoot:
                    return UnitToolsImperialElectricFlux.VoltFootToVoltMeter(value);
                case UnitToolsElectricFluxUnit.NanovoltMeter:
                    return UnitToolsMetricElectricFlux.NanovoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.PicovoltMeter:
                    return UnitToolsMetricElectricFlux.PicovoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.MegavoltMeter:
                    return UnitToolsMetricElectricFlux.MegavoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.GigavoltMeter:
                    return UnitToolsMetricElectricFlux.GigavoltMeterToVoltMeter(value);
                case UnitToolsElectricFluxUnit.VoltKilometer:
                    return UnitToolsMetricElectricFlux.VoltKilometerToVoltMeter(value);
                case UnitToolsElectricFluxUnit.StatvoltMeter:
                    return UnitToolsScientificElectricFlux.StatvoltMeterToVoltMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric flux unit.");
            }
        }

        public static double FromVoltMeter(double baseValue, UnitToolsElectricFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricFluxUnit.VoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToVoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.KilovoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToKilovoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.VoltCentimeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToVoltCentimeter(baseValue);
                case UnitToolsElectricFluxUnit.StatvoltCentimeter:
                    return UnitToolsScientificElectricFlux.VoltMeterToStatvoltCentimeter(baseValue);
                case UnitToolsElectricFluxUnit.MillivoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToMillivoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.MicrovoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToMicrovoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.VoltMillimeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToVoltMillimeter(baseValue);
                case UnitToolsElectricFluxUnit.VoltInch:
                    return UnitToolsImperialElectricFlux.VoltMeterToVoltInch(baseValue);
                case UnitToolsElectricFluxUnit.VoltFoot:
                    return UnitToolsImperialElectricFlux.VoltMeterToVoltFoot(baseValue);
                case UnitToolsElectricFluxUnit.NanovoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToNanovoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.PicovoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToPicovoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.MegavoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToMegavoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.GigavoltMeter:
                    return UnitToolsMetricElectricFlux.VoltMeterToGigavoltMeter(baseValue);
                case UnitToolsElectricFluxUnit.VoltKilometer:
                    return UnitToolsMetricElectricFlux.VoltMeterToVoltKilometer(baseValue);
                case UnitToolsElectricFluxUnit.StatvoltMeter:
                    return UnitToolsScientificElectricFlux.VoltMeterToStatvoltMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxUnit.VoltMeter:
                    return "V·m";
                case UnitToolsElectricFluxUnit.KilovoltMeter:
                    return "kV·m";
                case UnitToolsElectricFluxUnit.VoltCentimeter:
                    return "V·cm";
                case UnitToolsElectricFluxUnit.StatvoltCentimeter:
                    return "statV·cm";
                case UnitToolsElectricFluxUnit.MillivoltMeter:
                    return "mV·m";
                case UnitToolsElectricFluxUnit.MicrovoltMeter:
                    return "µV·m";
                case UnitToolsElectricFluxUnit.VoltMillimeter:
                    return "V·mm";
                case UnitToolsElectricFluxUnit.VoltInch:
                    return "V·in";
                case UnitToolsElectricFluxUnit.VoltFoot:
                    return "V·ft";
                case UnitToolsElectricFluxUnit.NanovoltMeter:
                    return "nV·m";
                case UnitToolsElectricFluxUnit.PicovoltMeter:
                    return "pV·m";
                case UnitToolsElectricFluxUnit.MegavoltMeter:
                    return "MV·m";
                case UnitToolsElectricFluxUnit.GigavoltMeter:
                    return "GV·m";
                case UnitToolsElectricFluxUnit.VoltKilometer:
                    return "V·km";
                case UnitToolsElectricFluxUnit.StatvoltMeter:
                    return "statV·m";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxUnit.VoltMeter:
                    return "Volt Meter";
                case UnitToolsElectricFluxUnit.KilovoltMeter:
                    return "Kilovolt Meter";
                case UnitToolsElectricFluxUnit.VoltCentimeter:
                    return "Volt Centimeter";
                case UnitToolsElectricFluxUnit.StatvoltCentimeter:
                    return "Statvolt Centimeter";
                case UnitToolsElectricFluxUnit.MillivoltMeter:
                    return "Millivolt Meter";
                case UnitToolsElectricFluxUnit.MicrovoltMeter:
                    return "Microvolt Meter";
                case UnitToolsElectricFluxUnit.VoltMillimeter:
                    return "Volt Millimeter";
                case UnitToolsElectricFluxUnit.VoltInch:
                    return "Volt Inch";
                case UnitToolsElectricFluxUnit.VoltFoot:
                    return "Volt Foot";
                case UnitToolsElectricFluxUnit.NanovoltMeter:
                    return "Nanovolt Meter";
                case UnitToolsElectricFluxUnit.PicovoltMeter:
                    return "Picovolt Meter";
                case UnitToolsElectricFluxUnit.MegavoltMeter:
                    return "Megavolt Meter";
                case UnitToolsElectricFluxUnit.GigavoltMeter:
                    return "Gigavolt Meter";
                case UnitToolsElectricFluxUnit.VoltKilometer:
                    return "Volt Kilometer";
                case UnitToolsElectricFluxUnit.StatvoltMeter:
                    return "Statvolt Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxUnit.VoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.KilovoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.VoltCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.StatvoltCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricFluxUnit.MillivoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.MicrovoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.VoltMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.VoltInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFluxUnit.VoltFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFluxUnit.NanovoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.PicovoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.MegavoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.GigavoltMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.VoltKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxUnit.StatvoltMeter:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricFluxUnit.VoltMeter, UnitToolsElectricFluxUnit.KilovoltMeter, UnitToolsElectricFluxUnit.VoltCentimeter, UnitToolsElectricFluxUnit.MillivoltMeter, UnitToolsElectricFluxUnit.MicrovoltMeter, UnitToolsElectricFluxUnit.VoltMillimeter, UnitToolsElectricFluxUnit.NanovoltMeter, UnitToolsElectricFluxUnit.PicovoltMeter, UnitToolsElectricFluxUnit.MegavoltMeter, UnitToolsElectricFluxUnit.GigavoltMeter, UnitToolsElectricFluxUnit.VoltKilometer };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricFluxUnit.StatvoltCentimeter, UnitToolsElectricFluxUnit.StatvoltMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsElectricFluxUnit.VoltInch, UnitToolsElectricFluxUnit.VoltFoot };
                default:
                    return new[] { UnitToolsElectricFluxUnit.VoltMeter, UnitToolsElectricFluxUnit.KilovoltMeter, UnitToolsElectricFluxUnit.VoltCentimeter, UnitToolsElectricFluxUnit.StatvoltCentimeter, UnitToolsElectricFluxUnit.MillivoltMeter, UnitToolsElectricFluxUnit.MicrovoltMeter, UnitToolsElectricFluxUnit.VoltMillimeter, UnitToolsElectricFluxUnit.VoltInch, UnitToolsElectricFluxUnit.VoltFoot, UnitToolsElectricFluxUnit.NanovoltMeter, UnitToolsElectricFluxUnit.PicovoltMeter, UnitToolsElectricFluxUnit.MegavoltMeter, UnitToolsElectricFluxUnit.GigavoltMeter, UnitToolsElectricFluxUnit.VoltKilometer, UnitToolsElectricFluxUnit.StatvoltMeter };
            }
        }
    }
}
