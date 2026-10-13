namespace UnitTools.ActivityConcentration
{
    using UnitTools.ActivityConcentration.Metric;
    using UnitTools.ActivityConcentration.Historical;
    using UnitTools.ActivityConcentration.ImperialUS;

    public enum UnitToolsActivityConcentrationUnit
    {
        BecquerelPerCubicMeter = 0,
        KilobecquerelPerCubicMeter = 1,
        MegabecquerelPerCubicMeter = 2,
        BecquerelPerLiter = 3,
        CuriePerCubicMeter = 4,
        MillibecquerelPerCubicMeter = 5,
        MicrobecquerelPerCubicMeter = 6,
        BecquerelPerMilliliter = 7,
        KilobecquerelPerLiter = 8,
        MicrocuriePerLiter = 9,
        BecquerelPerCubicCentimeter = 10,
        BecquerelPerUSGallon = 11,
        PicocuriePerLiter = 12,
        NanocuriePerLiter = 13,
    }

    public static class UnitToolsActivityConcentration
    {
        public static double Convert(double value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            double baseValue = ToBecquerelPerCubicMeter(value, from);
            return FromBecquerelPerCubicMeter(baseValue, to);
        }

        public static double ToBecquerelPerCubicMeter(double value, UnitToolsActivityConcentrationUnit from)
        {
            switch (from)
            {
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.KilobecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.MegabecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerLiterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitToolsHistoricalActivityConcentration.CuriePerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.MillibecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.MicrobecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerMilliliterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitToolsMetricActivityConcentration.KilobecquerelPerLiterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.MicrocuriePerLiterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicCentimeterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitToolsImperialUSActivityConcentration.BecquerelPerUSGallonToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.PicocuriePerLiterToBecquerelPerCubicMeter(value);
                case UnitToolsActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.NanocuriePerLiterToBecquerelPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported activity concentration unit.");
            }
        }

        public static double FromBecquerelPerCubicMeter(double baseValue, UnitToolsActivityConcentrationUnit to)
        {
            switch (to)
            {
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToKilobecquerelPerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToMegabecquerelPerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerLiter(baseValue);
                case UnitToolsActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitToolsHistoricalActivityConcentration.BecquerelPerCubicMeterToCuriePerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToMillibecquerelPerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToMicrobecquerelPerCubicMeter(baseValue);
                case UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerMilliliter(baseValue);
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToKilobecquerelPerLiter(baseValue);
                case UnitToolsActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.BecquerelPerCubicMeterToMicrocuriePerLiter(baseValue);
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitToolsMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicCentimeter(baseValue);
                case UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitToolsImperialUSActivityConcentration.BecquerelPerCubicMeterToBecquerelPerUSGallon(baseValue);
                case UnitToolsActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.BecquerelPerCubicMeterToPicocuriePerLiter(baseValue);
                case UnitToolsActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitToolsHistoricalActivityConcentration.BecquerelPerCubicMeterToNanocuriePerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported activity concentration unit.");
            }
        }

        public static string GetSymbol(UnitToolsActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return "Bq/m³";
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return "kBq/m³";
                case UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return "MBq/m³";
                case UnitToolsActivityConcentrationUnit.BecquerelPerLiter:
                    return "Bq/L";
                case UnitToolsActivityConcentrationUnit.CuriePerCubicMeter:
                    return "Ci/m³";
                case UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return "mBq/m³";
                case UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return "µBq/m³";
                case UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter:
                    return "Bq/mL";
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter:
                    return "kBq/L";
                case UnitToolsActivityConcentrationUnit.MicrocuriePerLiter:
                    return "µCi/L";
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return "Bq/cm³";
                case UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon:
                    return "Bq/gal US";
                case UnitToolsActivityConcentrationUnit.PicocuriePerLiter:
                    return "pCi/L";
                case UnitToolsActivityConcentrationUnit.NanocuriePerLiter:
                    return "nCi/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return "Becquerel Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return "Kilobecquerel Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return "Megabecquerel Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.BecquerelPerLiter:
                    return "Becquerel Per Liter";
                case UnitToolsActivityConcentrationUnit.CuriePerCubicMeter:
                    return "Curie Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return "Millibecquerel Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return "Microbecquerel Per Cubic Meter";
                case UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter:
                    return "Becquerel Per Milliliter";
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter:
                    return "Kilobecquerel Per Liter";
                case UnitToolsActivityConcentrationUnit.MicrocuriePerLiter:
                    return "Microcurie Per Liter";
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return "Becquerel Per Cubic Centimeter";
                case UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon:
                    return "Becquerel Per US Gallon";
                case UnitToolsActivityConcentrationUnit.PicocuriePerLiter:
                    return "Picocurie Per Liter";
                case UnitToolsActivityConcentrationUnit.NanocuriePerLiter:
                    return "Nanocurie Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsActivityConcentrationUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.BecquerelPerLiter, UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter, UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter, UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsActivityConcentrationUnit.CuriePerCubicMeter, UnitToolsActivityConcentrationUnit.MicrocuriePerLiter, UnitToolsActivityConcentrationUnit.PicocuriePerLiter, UnitToolsActivityConcentrationUnit.NanocuriePerLiter };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon };
                default:
                    return new[] { UnitToolsActivityConcentrationUnit.BecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.KilobecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.MegabecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.BecquerelPerLiter, UnitToolsActivityConcentrationUnit.CuriePerCubicMeter, UnitToolsActivityConcentrationUnit.MillibecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.MicrobecquerelPerCubicMeter, UnitToolsActivityConcentrationUnit.BecquerelPerMilliliter, UnitToolsActivityConcentrationUnit.KilobecquerelPerLiter, UnitToolsActivityConcentrationUnit.MicrocuriePerLiter, UnitToolsActivityConcentrationUnit.BecquerelPerCubicCentimeter, UnitToolsActivityConcentrationUnit.BecquerelPerUSGallon, UnitToolsActivityConcentrationUnit.PicocuriePerLiter, UnitToolsActivityConcentrationUnit.NanocuriePerLiter };
            }
        }
    }
}
