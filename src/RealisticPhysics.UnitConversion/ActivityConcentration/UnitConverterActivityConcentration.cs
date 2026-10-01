namespace RealisticPhysics.UnitConversion.ActivityConcentration
{
    using RealisticPhysics.UnitConversion.ActivityConcentration.Metric;
    using RealisticPhysics.UnitConversion.ActivityConcentration.Historical;
    using RealisticPhysics.UnitConversion.ActivityConcentration.ImperialUS;

    public enum UnitConverterActivityConcentrationUnit
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

    public static class UnitConverterActivityConcentration
    {
        public static double Convert(double value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            double baseValue = ToBecquerelPerCubicMeter(value, from);
            return FromBecquerelPerCubicMeter(baseValue, to);
        }

        public static double ToBecquerelPerCubicMeter(double value, UnitConverterActivityConcentrationUnit from)
        {
            switch (from)
            {
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.KilobecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.MegabecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerLiterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitConverterHistoricalActivityConcentration.CuriePerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.MillibecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.MicrobecquerelPerCubicMeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerMilliliterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitConverterMetricActivityConcentration.KilobecquerelPerLiterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.MicrocuriePerLiterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicCentimeterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitConverterImperialUSActivityConcentration.BecquerelPerUSGallonToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.PicocuriePerLiterToBecquerelPerCubicMeter(value);
                case UnitConverterActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.NanocuriePerLiterToBecquerelPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported activity concentration unit.");
            }
        }

        public static double FromBecquerelPerCubicMeter(double baseValue, UnitConverterActivityConcentrationUnit to)
        {
            switch (to)
            {
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToKilobecquerelPerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToMegabecquerelPerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerLiter(baseValue);
                case UnitConverterActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitConverterHistoricalActivityConcentration.BecquerelPerCubicMeterToCuriePerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToMillibecquerelPerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToMicrobecquerelPerCubicMeter(baseValue);
                case UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerMilliliter(baseValue);
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToKilobecquerelPerLiter(baseValue);
                case UnitConverterActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.BecquerelPerCubicMeterToMicrocuriePerLiter(baseValue);
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitConverterMetricActivityConcentration.BecquerelPerCubicMeterToBecquerelPerCubicCentimeter(baseValue);
                case UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitConverterImperialUSActivityConcentration.BecquerelPerCubicMeterToBecquerelPerUSGallon(baseValue);
                case UnitConverterActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.BecquerelPerCubicMeterToPicocuriePerLiter(baseValue);
                case UnitConverterActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitConverterHistoricalActivityConcentration.BecquerelPerCubicMeterToNanocuriePerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported activity concentration unit.");
            }
        }

        public static string GetSymbol(UnitConverterActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return "Bq/m³";
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return "kBq/m³";
                case UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return "MBq/m³";
                case UnitConverterActivityConcentrationUnit.BecquerelPerLiter:
                    return "Bq/L";
                case UnitConverterActivityConcentrationUnit.CuriePerCubicMeter:
                    return "Ci/m³";
                case UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return "mBq/m³";
                case UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return "µBq/m³";
                case UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter:
                    return "Bq/mL";
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter:
                    return "kBq/L";
                case UnitConverterActivityConcentrationUnit.MicrocuriePerLiter:
                    return "µCi/L";
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return "Bq/cm³";
                case UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon:
                    return "Bq/gal US";
                case UnitConverterActivityConcentrationUnit.PicocuriePerLiter:
                    return "pCi/L";
                case UnitConverterActivityConcentrationUnit.NanocuriePerLiter:
                    return "nCi/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return "Becquerel Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return "Kilobecquerel Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return "Megabecquerel Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.BecquerelPerLiter:
                    return "Becquerel Per Liter";
                case UnitConverterActivityConcentrationUnit.CuriePerCubicMeter:
                    return "Curie Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return "Millibecquerel Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return "Microbecquerel Per Cubic Meter";
                case UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter:
                    return "Becquerel Per Milliliter";
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter:
                    return "Kilobecquerel Per Liter";
                case UnitConverterActivityConcentrationUnit.MicrocuriePerLiter:
                    return "Microcurie Per Liter";
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return "Becquerel Per Cubic Centimeter";
                case UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon:
                    return "Becquerel Per US Gallon";
                case UnitConverterActivityConcentrationUnit.PicocuriePerLiter:
                    return "Picocurie Per Liter";
                case UnitConverterActivityConcentrationUnit.NanocuriePerLiter:
                    return "Nanocurie Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterActivityConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.BecquerelPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.CuriePerCubicMeter:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.MicrocuriePerLiter:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterActivityConcentrationUnit.PicocuriePerLiter:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterActivityConcentrationUnit.NanocuriePerLiter:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterActivityConcentrationUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.BecquerelPerLiter, UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter, UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter, UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterActivityConcentrationUnit.CuriePerCubicMeter, UnitConverterActivityConcentrationUnit.MicrocuriePerLiter, UnitConverterActivityConcentrationUnit.PicocuriePerLiter, UnitConverterActivityConcentrationUnit.NanocuriePerLiter };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon };
                default:
                    return new[] { UnitConverterActivityConcentrationUnit.BecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.KilobecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.MegabecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.BecquerelPerLiter, UnitConverterActivityConcentrationUnit.CuriePerCubicMeter, UnitConverterActivityConcentrationUnit.MillibecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.MicrobecquerelPerCubicMeter, UnitConverterActivityConcentrationUnit.BecquerelPerMilliliter, UnitConverterActivityConcentrationUnit.KilobecquerelPerLiter, UnitConverterActivityConcentrationUnit.MicrocuriePerLiter, UnitConverterActivityConcentrationUnit.BecquerelPerCubicCentimeter, UnitConverterActivityConcentrationUnit.BecquerelPerUSGallon, UnitConverterActivityConcentrationUnit.PicocuriePerLiter, UnitConverterActivityConcentrationUnit.NanocuriePerLiter };
            }
        }
    }
}
