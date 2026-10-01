namespace UnitConverter.ElectricalResistivity
{
    using UnitConverter.ElectricalResistivity.Metric;
    using UnitConverter.ElectricalResistivity.Imperial;

    public enum UnitConverterElectricalResistivityUnit
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

    public static class UnitConverterElectricalResistivity
    {
        public static double Convert(double value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            double baseValue = ToOhmMeter(value, from);
            return FromOhmMeter(baseValue, to);
        }

        public static double ToOhmMeter(double value, UnitConverterElectricalResistivityUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricalResistivityUnit.OhmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.OhmCentimeter:
                    return UnitConverterMetricElectricalResistivity.OhmCentimeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.OhmMillimeter:
                    return UnitConverterMetricElectricalResistivity.OhmMillimeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.MicroohmMeter:
                    return UnitConverterMetricElectricalResistivity.MicroohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.OhmInch:
                    return UnitConverterImperialElectricalResistivity.OhmInchToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitConverterImperialElectricalResistivity.CircularMilOhmPerFootToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.NanoohmMeter:
                    return UnitConverterMetricElectricalResistivity.NanoohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.MilliohmMeter:
                    return UnitConverterMetricElectricalResistivity.MilliohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.KiloohmMeter:
                    return UnitConverterMetricElectricalResistivity.KiloohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.OhmFoot:
                    return UnitConverterImperialElectricalResistivity.OhmFootToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitConverterMetricElectricalResistivity.MicroohmCentimeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.PicoohmMeter:
                    return UnitConverterMetricElectricalResistivity.PicoohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.MegaohmMeter:
                    return UnitConverterMetricElectricalResistivity.MegaohmMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMillimeterSquaredPerMeterToOhmMeter(value);
                case UnitConverterElectricalResistivityUnit.MicroohmInch:
                    return UnitConverterImperialElectricalResistivity.MicroohmInchToOhmMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electrical resistivity unit.");
            }
        }

        public static double FromOhmMeter(double baseValue, UnitConverterElectricalResistivityUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricalResistivityUnit.OhmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToOhmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.OhmCentimeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToOhmCentimeter(baseValue);
                case UnitConverterElectricalResistivityUnit.OhmMillimeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToOhmMillimeter(baseValue);
                case UnitConverterElectricalResistivityUnit.MicroohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToMicroohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.OhmInch:
                    return UnitConverterImperialElectricalResistivity.OhmMeterToOhmInch(baseValue);
                case UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitConverterImperialElectricalResistivity.OhmMeterToCircularMilOhmPerFoot(baseValue);
                case UnitConverterElectricalResistivityUnit.NanoohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToNanoohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.MilliohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToMilliohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.KiloohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToKiloohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.OhmFoot:
                    return UnitConverterImperialElectricalResistivity.OhmMeterToOhmFoot(baseValue);
                case UnitConverterElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToMicroohmCentimeter(baseValue);
                case UnitConverterElectricalResistivityUnit.PicoohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToPicoohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.MegaohmMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToMegaohmMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitConverterMetricElectricalResistivity.OhmMeterToOhmMillimeterSquaredPerMeter(baseValue);
                case UnitConverterElectricalResistivityUnit.MicroohmInch:
                    return UnitConverterImperialElectricalResistivity.OhmMeterToMicroohmInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electrical resistivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalResistivityUnit.OhmMeter:
                    return "Ω·m";
                case UnitConverterElectricalResistivityUnit.OhmCentimeter:
                    return "Ω·cm";
                case UnitConverterElectricalResistivityUnit.OhmMillimeter:
                    return "Ω·mm";
                case UnitConverterElectricalResistivityUnit.MicroohmMeter:
                    return "µΩ·m";
                case UnitConverterElectricalResistivityUnit.OhmInch:
                    return "Ω·in";
                case UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return "Ω·cmil/ft";
                case UnitConverterElectricalResistivityUnit.NanoohmMeter:
                    return "nΩ·m";
                case UnitConverterElectricalResistivityUnit.MilliohmMeter:
                    return "mΩ·m";
                case UnitConverterElectricalResistivityUnit.KiloohmMeter:
                    return "kΩ·m";
                case UnitConverterElectricalResistivityUnit.OhmFoot:
                    return "Ω·ft";
                case UnitConverterElectricalResistivityUnit.MicroohmCentimeter:
                    return "µΩ·cm";
                case UnitConverterElectricalResistivityUnit.PicoohmMeter:
                    return "pΩ·m";
                case UnitConverterElectricalResistivityUnit.MegaohmMeter:
                    return "MΩ·m";
                case UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return "Ω·mm²/m";
                case UnitConverterElectricalResistivityUnit.MicroohmInch:
                    return "µΩ·in";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalResistivityUnit.OhmMeter:
                    return "Ohm Meter";
                case UnitConverterElectricalResistivityUnit.OhmCentimeter:
                    return "Ohm Centimeter";
                case UnitConverterElectricalResistivityUnit.OhmMillimeter:
                    return "Ohm Millimeter";
                case UnitConverterElectricalResistivityUnit.MicroohmMeter:
                    return "Microohm Meter";
                case UnitConverterElectricalResistivityUnit.OhmInch:
                    return "Ohm Inch";
                case UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return "Circular Mil Ohm Per Foot";
                case UnitConverterElectricalResistivityUnit.NanoohmMeter:
                    return "Nanoohm Meter";
                case UnitConverterElectricalResistivityUnit.MilliohmMeter:
                    return "Milliohm Meter";
                case UnitConverterElectricalResistivityUnit.KiloohmMeter:
                    return "Kiloohm Meter";
                case UnitConverterElectricalResistivityUnit.OhmFoot:
                    return "Ohm Foot";
                case UnitConverterElectricalResistivityUnit.MicroohmCentimeter:
                    return "Microohm Centimeter";
                case UnitConverterElectricalResistivityUnit.PicoohmMeter:
                    return "Picoohm Meter";
                case UnitConverterElectricalResistivityUnit.MegaohmMeter:
                    return "Megaohm Meter";
                case UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return "Ohm Millimeter Squared Per Meter";
                case UnitConverterElectricalResistivityUnit.MicroohmInch:
                    return "Microohm Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricalResistivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricalResistivityUnit.OhmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.OhmCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.OhmMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.MicroohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.OhmInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricalResistivityUnit.NanoohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.MilliohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.KiloohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.OhmFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricalResistivityUnit.MicroohmCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.PicoohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.MegaohmMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricalResistivityUnit.MicroohmInch:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricalResistivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricalResistivityUnit.OhmMeter, UnitConverterElectricalResistivityUnit.OhmCentimeter, UnitConverterElectricalResistivityUnit.OhmMillimeter, UnitConverterElectricalResistivityUnit.MicroohmMeter, UnitConverterElectricalResistivityUnit.NanoohmMeter, UnitConverterElectricalResistivityUnit.MilliohmMeter, UnitConverterElectricalResistivityUnit.KiloohmMeter, UnitConverterElectricalResistivityUnit.MicroohmCentimeter, UnitConverterElectricalResistivityUnit.PicoohmMeter, UnitConverterElectricalResistivityUnit.MegaohmMeter, UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterElectricalResistivityUnit.OhmInch, UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot, UnitConverterElectricalResistivityUnit.OhmFoot, UnitConverterElectricalResistivityUnit.MicroohmInch };
                default:
                    return new[] { UnitConverterElectricalResistivityUnit.OhmMeter, UnitConverterElectricalResistivityUnit.OhmCentimeter, UnitConverterElectricalResistivityUnit.OhmMillimeter, UnitConverterElectricalResistivityUnit.MicroohmMeter, UnitConverterElectricalResistivityUnit.OhmInch, UnitConverterElectricalResistivityUnit.CircularMilOhmPerFoot, UnitConverterElectricalResistivityUnit.NanoohmMeter, UnitConverterElectricalResistivityUnit.MilliohmMeter, UnitConverterElectricalResistivityUnit.KiloohmMeter, UnitConverterElectricalResistivityUnit.OhmFoot, UnitConverterElectricalResistivityUnit.MicroohmCentimeter, UnitConverterElectricalResistivityUnit.PicoohmMeter, UnitConverterElectricalResistivityUnit.MegaohmMeter, UnitConverterElectricalResistivityUnit.OhmMillimeterSquaredPerMeter, UnitConverterElectricalResistivityUnit.MicroohmInch };
            }
        }
    }
}
