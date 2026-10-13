namespace UnitTools.MassConcentration
{
    using UnitTools.MassConcentration.Metric;
    using UnitTools.MassConcentration.Common;
    using UnitTools.MassConcentration.Imperial;
    using UnitTools.MassConcentration.ImperialUS;

    public enum UnitToolsMassConcentrationUnit
    {
        KilogramPerCubicMeter = 0,
        GramPerLiter = 1,
        MilligramPerLiter = 2,
        MicrogramPerLiter = 3,
        GramPerCubicMeter = 4,
        PartPerMillionWater = 5,
        NanogramPerLiter = 6,
        MilligramPerMilliliter = 7,
        GramPerMilliliter = 8,
        KilogramPerLiter = 9,
        PoundPerCubicFoot = 10,
        PoundPerUSGallon = 11,
    }

    public static class UnitToolsMassConcentration
    {
        public static double Convert(double value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            double baseValue = ToKilogramPerCubicMeter(value, from);
            return FromKilogramPerCubicMeter(baseValue, to);
        }

        public static double ToKilogramPerCubicMeter(double value, UnitToolsMassConcentrationUnit from)
        {
            switch (from)
            {
                case UnitToolsMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.GramPerLiter:
                    return UnitToolsMetricMassConcentration.GramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.MilligramPerLiter:
                    return UnitToolsMetricMassConcentration.MilligramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.MicrogramPerLiter:
                    return UnitToolsMetricMassConcentration.MicrogramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.GramPerCubicMeter:
                    return UnitToolsMetricMassConcentration.GramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.PartPerMillionWater:
                    return UnitToolsCommonMassConcentration.PartPerMillionWaterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.NanogramPerLiter:
                    return UnitToolsMetricMassConcentration.NanogramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitToolsMetricMassConcentration.MilligramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.GramPerMilliliter:
                    return UnitToolsMetricMassConcentration.GramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.KilogramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitToolsImperialMassConcentration.PoundPerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsMassConcentrationUnit.PoundPerUSGallon:
                    return UnitToolsImperialUSMassConcentration.PoundPerUSGallonToKilogramPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass concentration unit.");
            }
        }

        public static double FromKilogramPerCubicMeter(double baseValue, UnitToolsMassConcentrationUnit to)
        {
            switch (to)
            {
                case UnitToolsMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToKilogramPerCubicMeter(baseValue);
                case UnitToolsMassConcentrationUnit.GramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToGramPerLiter(baseValue);
                case UnitToolsMassConcentrationUnit.MilligramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToMilligramPerLiter(baseValue);
                case UnitToolsMassConcentrationUnit.MicrogramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToMicrogramPerLiter(baseValue);
                case UnitToolsMassConcentrationUnit.GramPerCubicMeter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToGramPerCubicMeter(baseValue);
                case UnitToolsMassConcentrationUnit.PartPerMillionWater:
                    return UnitToolsCommonMassConcentration.KilogramPerCubicMeterToPartPerMillionWater(baseValue);
                case UnitToolsMassConcentrationUnit.NanogramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToNanogramPerLiter(baseValue);
                case UnitToolsMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToMilligramPerMilliliter(baseValue);
                case UnitToolsMassConcentrationUnit.GramPerMilliliter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToGramPerMilliliter(baseValue);
                case UnitToolsMassConcentrationUnit.KilogramPerLiter:
                    return UnitToolsMetricMassConcentration.KilogramPerCubicMeterToKilogramPerLiter(baseValue);
                case UnitToolsMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitToolsImperialMassConcentration.KilogramPerCubicMeterToPoundPerCubicFoot(baseValue);
                case UnitToolsMassConcentrationUnit.PoundPerUSGallon:
                    return UnitToolsImperialUSMassConcentration.KilogramPerCubicMeterToPoundPerUSGallon(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass concentration unit.");
            }
        }

        public static string GetSymbol(UnitToolsMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassConcentrationUnit.KilogramPerCubicMeter:
                    return "kg/m³";
                case UnitToolsMassConcentrationUnit.GramPerLiter:
                    return "g/L";
                case UnitToolsMassConcentrationUnit.MilligramPerLiter:
                    return "mg/L";
                case UnitToolsMassConcentrationUnit.MicrogramPerLiter:
                    return "µg/L";
                case UnitToolsMassConcentrationUnit.GramPerCubicMeter:
                    return "g/m³";
                case UnitToolsMassConcentrationUnit.PartPerMillionWater:
                    return "ppm water";
                case UnitToolsMassConcentrationUnit.NanogramPerLiter:
                    return "ng/L";
                case UnitToolsMassConcentrationUnit.MilligramPerMilliliter:
                    return "mg/mL";
                case UnitToolsMassConcentrationUnit.GramPerMilliliter:
                    return "g/mL";
                case UnitToolsMassConcentrationUnit.KilogramPerLiter:
                    return "kg/L";
                case UnitToolsMassConcentrationUnit.PoundPerCubicFoot:
                    return "lb/ft³";
                case UnitToolsMassConcentrationUnit.PoundPerUSGallon:
                    return "lb/gal US";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassConcentrationUnit.KilogramPerCubicMeter:
                    return "Kilogram Per Cubic Meter";
                case UnitToolsMassConcentrationUnit.GramPerLiter:
                    return "Gram Per Liter";
                case UnitToolsMassConcentrationUnit.MilligramPerLiter:
                    return "Milligram Per Liter";
                case UnitToolsMassConcentrationUnit.MicrogramPerLiter:
                    return "Microgram Per Liter";
                case UnitToolsMassConcentrationUnit.GramPerCubicMeter:
                    return "Gram Per Cubic Meter";
                case UnitToolsMassConcentrationUnit.PartPerMillionWater:
                    return "Part Per Million Water";
                case UnitToolsMassConcentrationUnit.NanogramPerLiter:
                    return "Nanogram Per Liter";
                case UnitToolsMassConcentrationUnit.MilligramPerMilliliter:
                    return "Milligram Per Milliliter";
                case UnitToolsMassConcentrationUnit.GramPerMilliliter:
                    return "Gram Per Milliliter";
                case UnitToolsMassConcentrationUnit.KilogramPerLiter:
                    return "Kilogram Per Liter";
                case UnitToolsMassConcentrationUnit.PoundPerCubicFoot:
                    return "Pound Per Cubic Foot";
                case UnitToolsMassConcentrationUnit.PoundPerUSGallon:
                    return "Pound Per US Gallon";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.GramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.MilligramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.MicrogramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.GramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.PartPerMillionWater:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsMassConcentrationUnit.NanogramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.GramPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.KilogramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassConcentrationUnit.PoundPerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMassConcentrationUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMassConcentrationUnit.KilogramPerCubicMeter, UnitToolsMassConcentrationUnit.GramPerLiter, UnitToolsMassConcentrationUnit.MilligramPerLiter, UnitToolsMassConcentrationUnit.MicrogramPerLiter, UnitToolsMassConcentrationUnit.GramPerCubicMeter, UnitToolsMassConcentrationUnit.NanogramPerLiter, UnitToolsMassConcentrationUnit.MilligramPerMilliliter, UnitToolsMassConcentrationUnit.GramPerMilliliter, UnitToolsMassConcentrationUnit.KilogramPerLiter };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsMassConcentrationUnit.PartPerMillionWater };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMassConcentrationUnit.PoundPerCubicFoot };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsMassConcentrationUnit.PoundPerUSGallon };
                default:
                    return new[] { UnitToolsMassConcentrationUnit.KilogramPerCubicMeter, UnitToolsMassConcentrationUnit.GramPerLiter, UnitToolsMassConcentrationUnit.MilligramPerLiter, UnitToolsMassConcentrationUnit.MicrogramPerLiter, UnitToolsMassConcentrationUnit.GramPerCubicMeter, UnitToolsMassConcentrationUnit.PartPerMillionWater, UnitToolsMassConcentrationUnit.NanogramPerLiter, UnitToolsMassConcentrationUnit.MilligramPerMilliliter, UnitToolsMassConcentrationUnit.GramPerMilliliter, UnitToolsMassConcentrationUnit.KilogramPerLiter, UnitToolsMassConcentrationUnit.PoundPerCubicFoot, UnitToolsMassConcentrationUnit.PoundPerUSGallon };
            }
        }
    }
}
