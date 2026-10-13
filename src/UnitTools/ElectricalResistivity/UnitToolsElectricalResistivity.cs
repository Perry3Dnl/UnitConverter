namespace UnitTools.ElectricalResistivity
{
    using UnitTools.ElectricalResistivity.Metric;
    using UnitTools.ElectricalResistivity.Imperial;

    public enum UnitToolsElectricalResistivityUnit
    {
        OhmMeter = 0,
        OhmCentimeter = 1,
        OhmMillimeter = 2,
        MicroohmMeter = 3,
        OhmInch = 4,
        CircularMilOhmPerFoot = 5,
        NanoohmMeter = 6,
        MilliohmMeter = 7,
        KiloohmMeter = 8,
        OhmFoot = 9,
        MicroohmCentimeter = 10,
        PicoohmMeter = 11,
        MegaohmMeter = 12,
        OhmMillimeterSquaredPerMeter = 13,
        MicroohmInch = 14,
    }

    public static class UnitToolsElectricalResistivity
    {
        public static double Convert(double value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            double baseValue = ToOhmMeter(value, from);
            return FromOhmMeter(baseValue, to);
        }

        public static double ToOhmMeter(double value, UnitToolsElectricalResistivityUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricalResistivityUnit.OhmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.OhmCentimeter:
                    return UnitToolsMetricElectricalResistivity.OhmCentimeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.OhmMillimeter:
                    return UnitToolsMetricElectricalResistivity.OhmMillimeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.MicroohmMeter:
                    return UnitToolsMetricElectricalResistivity.MicroohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.OhmInch:
                    return UnitToolsImperialElectricalResistivity.OhmInchToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitToolsImperialElectricalResistivity.CircularMilOhmPerFootToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.NanoohmMeter:
                    return UnitToolsMetricElectricalResistivity.NanoohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.MilliohmMeter:
                    return UnitToolsMetricElectricalResistivity.MilliohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.KiloohmMeter:
                    return UnitToolsMetricElectricalResistivity.KiloohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.OhmFoot:
                    return UnitToolsImperialElectricalResistivity.OhmFootToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitToolsMetricElectricalResistivity.MicroohmCentimeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.PicoohmMeter:
                    return UnitToolsMetricElectricalResistivity.PicoohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.MegaohmMeter:
                    return UnitToolsMetricElectricalResistivity.MegaohmMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMillimeterSquaredPerMeterToOhmMeter(value);
                case UnitToolsElectricalResistivityUnit.MicroohmInch:
                    return UnitToolsImperialElectricalResistivity.MicroohmInchToOhmMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electrical resistivity unit.");
            }
        }

        public static double FromOhmMeter(double baseValue, UnitToolsElectricalResistivityUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricalResistivityUnit.OhmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToOhmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.OhmCentimeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToOhmCentimeter(baseValue);
                case UnitToolsElectricalResistivityUnit.OhmMillimeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToOhmMillimeter(baseValue);
                case UnitToolsElectricalResistivityUnit.MicroohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToMicroohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.OhmInch:
                    return UnitToolsImperialElectricalResistivity.OhmMeterToOhmInch(baseValue);
                case UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitToolsImperialElectricalResistivity.OhmMeterToCircularMilOhmPerFoot(baseValue);
                case UnitToolsElectricalResistivityUnit.NanoohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToNanoohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.MilliohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToMilliohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.KiloohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToKiloohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.OhmFoot:
                    return UnitToolsImperialElectricalResistivity.OhmMeterToOhmFoot(baseValue);
                case UnitToolsElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToMicroohmCentimeter(baseValue);
                case UnitToolsElectricalResistivityUnit.PicoohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToPicoohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.MegaohmMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToMegaohmMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitToolsMetricElectricalResistivity.OhmMeterToOhmMillimeterSquaredPerMeter(baseValue);
                case UnitToolsElectricalResistivityUnit.MicroohmInch:
                    return UnitToolsImperialElectricalResistivity.OhmMeterToMicroohmInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electrical resistivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalResistivityUnit.OhmMeter:
                    return "Ω·m";
                case UnitToolsElectricalResistivityUnit.OhmCentimeter:
                    return "Ω·cm";
                case UnitToolsElectricalResistivityUnit.OhmMillimeter:
                    return "Ω·mm";
                case UnitToolsElectricalResistivityUnit.MicroohmMeter:
                    return "µΩ·m";
                case UnitToolsElectricalResistivityUnit.OhmInch:
                    return "Ω·in";
                case UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return "Ω·cmil/ft";
                case UnitToolsElectricalResistivityUnit.NanoohmMeter:
                    return "nΩ·m";
                case UnitToolsElectricalResistivityUnit.MilliohmMeter:
                    return "mΩ·m";
                case UnitToolsElectricalResistivityUnit.KiloohmMeter:
                    return "kΩ·m";
                case UnitToolsElectricalResistivityUnit.OhmFoot:
                    return "Ω·ft";
                case UnitToolsElectricalResistivityUnit.MicroohmCentimeter:
                    return "µΩ·cm";
                case UnitToolsElectricalResistivityUnit.PicoohmMeter:
                    return "pΩ·m";
                case UnitToolsElectricalResistivityUnit.MegaohmMeter:
                    return "MΩ·m";
                case UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return "Ω·mm²/m";
                case UnitToolsElectricalResistivityUnit.MicroohmInch:
                    return "µΩ·in";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalResistivityUnit.OhmMeter:
                    return "Ohm Meter";
                case UnitToolsElectricalResistivityUnit.OhmCentimeter:
                    return "Ohm Centimeter";
                case UnitToolsElectricalResistivityUnit.OhmMillimeter:
                    return "Ohm Millimeter";
                case UnitToolsElectricalResistivityUnit.MicroohmMeter:
                    return "Microohm Meter";
                case UnitToolsElectricalResistivityUnit.OhmInch:
                    return "Ohm Inch";
                case UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return "Circular Mil Ohm Per Foot";
                case UnitToolsElectricalResistivityUnit.NanoohmMeter:
                    return "Nanoohm Meter";
                case UnitToolsElectricalResistivityUnit.MilliohmMeter:
                    return "Milliohm Meter";
                case UnitToolsElectricalResistivityUnit.KiloohmMeter:
                    return "Kiloohm Meter";
                case UnitToolsElectricalResistivityUnit.OhmFoot:
                    return "Ohm Foot";
                case UnitToolsElectricalResistivityUnit.MicroohmCentimeter:
                    return "Microohm Centimeter";
                case UnitToolsElectricalResistivityUnit.PicoohmMeter:
                    return "Picoohm Meter";
                case UnitToolsElectricalResistivityUnit.MegaohmMeter:
                    return "Megaohm Meter";
                case UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return "Ohm Millimeter Squared Per Meter";
                case UnitToolsElectricalResistivityUnit.MicroohmInch:
                    return "Microohm Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricalResistivityUnit.OhmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.OhmCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.OhmMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.MicroohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.OhmInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricalResistivityUnit.NanoohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.MilliohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.KiloohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.OhmFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.PicoohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.MegaohmMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricalResistivityUnit.MicroohmInch:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricalResistivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricalResistivityUnit.OhmMeter, UnitToolsElectricalResistivityUnit.OhmCentimeter, UnitToolsElectricalResistivityUnit.OhmMillimeter, UnitToolsElectricalResistivityUnit.MicroohmMeter, UnitToolsElectricalResistivityUnit.NanoohmMeter, UnitToolsElectricalResistivityUnit.MilliohmMeter, UnitToolsElectricalResistivityUnit.KiloohmMeter, UnitToolsElectricalResistivityUnit.MicroohmCentimeter, UnitToolsElectricalResistivityUnit.PicoohmMeter, UnitToolsElectricalResistivityUnit.MegaohmMeter, UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsElectricalResistivityUnit.OhmInch, UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot, UnitToolsElectricalResistivityUnit.OhmFoot, UnitToolsElectricalResistivityUnit.MicroohmInch };
                default:
                    return new[] { UnitToolsElectricalResistivityUnit.OhmMeter, UnitToolsElectricalResistivityUnit.OhmCentimeter, UnitToolsElectricalResistivityUnit.OhmMillimeter, UnitToolsElectricalResistivityUnit.MicroohmMeter, UnitToolsElectricalResistivityUnit.OhmInch, UnitToolsElectricalResistivityUnit.CircularMilOhmPerFoot, UnitToolsElectricalResistivityUnit.NanoohmMeter, UnitToolsElectricalResistivityUnit.MilliohmMeter, UnitToolsElectricalResistivityUnit.KiloohmMeter, UnitToolsElectricalResistivityUnit.OhmFoot, UnitToolsElectricalResistivityUnit.MicroohmCentimeter, UnitToolsElectricalResistivityUnit.PicoohmMeter, UnitToolsElectricalResistivityUnit.MegaohmMeter, UnitToolsElectricalResistivityUnit.OhmMillimeterSquaredPerMeter, UnitToolsElectricalResistivityUnit.MicroohmInch };
            }
        }
    }
}
