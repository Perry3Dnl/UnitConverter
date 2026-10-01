namespace RealisticPhysics.UnitConversion.MassConcentration
{
    using RealisticPhysics.UnitConversion.MassConcentration.Metric;
    using RealisticPhysics.UnitConversion.MassConcentration.Common;
    using RealisticPhysics.UnitConversion.MassConcentration.Imperial;
    using RealisticPhysics.UnitConversion.MassConcentration.ImperialUS;

    public enum UnitConverterMassConcentrationUnit
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

    public static class UnitConverterMassConcentration
    {
        public static double Convert(double value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            double baseValue = ToKilogramPerCubicMeter(value, from);
            return FromKilogramPerCubicMeter(baseValue, to);
        }

        public static double ToKilogramPerCubicMeter(double value, UnitConverterMassConcentrationUnit from)
        {
            switch (from)
            {
                case UnitConverterMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.GramPerLiter:
                    return UnitConverterMetricMassConcentration.GramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.MilligramPerLiter:
                    return UnitConverterMetricMassConcentration.MilligramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.MicrogramPerLiter:
                    return UnitConverterMetricMassConcentration.MicrogramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.GramPerCubicMeter:
                    return UnitConverterMetricMassConcentration.GramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.PartPerMillionWater:
                    return UnitConverterCommonMassConcentration.PartPerMillionWaterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.NanogramPerLiter:
                    return UnitConverterMetricMassConcentration.NanogramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitConverterMetricMassConcentration.MilligramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.GramPerMilliliter:
                    return UnitConverterMetricMassConcentration.GramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.KilogramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitConverterImperialMassConcentration.PoundPerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterMassConcentrationUnit.PoundPerUSGallon:
                    return UnitConverterImperialUSMassConcentration.PoundPerUSGallonToKilogramPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass concentration unit.");
            }
        }

        public static double FromKilogramPerCubicMeter(double baseValue, UnitConverterMassConcentrationUnit to)
        {
            switch (to)
            {
                case UnitConverterMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToKilogramPerCubicMeter(baseValue);
                case UnitConverterMassConcentrationUnit.GramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToGramPerLiter(baseValue);
                case UnitConverterMassConcentrationUnit.MilligramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToMilligramPerLiter(baseValue);
                case UnitConverterMassConcentrationUnit.MicrogramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToMicrogramPerLiter(baseValue);
                case UnitConverterMassConcentrationUnit.GramPerCubicMeter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToGramPerCubicMeter(baseValue);
                case UnitConverterMassConcentrationUnit.PartPerMillionWater:
                    return UnitConverterCommonMassConcentration.KilogramPerCubicMeterToPartPerMillionWater(baseValue);
                case UnitConverterMassConcentrationUnit.NanogramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToNanogramPerLiter(baseValue);
                case UnitConverterMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToMilligramPerMilliliter(baseValue);
                case UnitConverterMassConcentrationUnit.GramPerMilliliter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToGramPerMilliliter(baseValue);
                case UnitConverterMassConcentrationUnit.KilogramPerLiter:
                    return UnitConverterMetricMassConcentration.KilogramPerCubicMeterToKilogramPerLiter(baseValue);
                case UnitConverterMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitConverterImperialMassConcentration.KilogramPerCubicMeterToPoundPerCubicFoot(baseValue);
                case UnitConverterMassConcentrationUnit.PoundPerUSGallon:
                    return UnitConverterImperialUSMassConcentration.KilogramPerCubicMeterToPoundPerUSGallon(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass concentration unit.");
            }
        }

        public static string GetSymbol(UnitConverterMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassConcentrationUnit.KilogramPerCubicMeter:
                    return "kg/m³";
                case UnitConverterMassConcentrationUnit.GramPerLiter:
                    return "g/L";
                case UnitConverterMassConcentrationUnit.MilligramPerLiter:
                    return "mg/L";
                case UnitConverterMassConcentrationUnit.MicrogramPerLiter:
                    return "µg/L";
                case UnitConverterMassConcentrationUnit.GramPerCubicMeter:
                    return "g/m³";
                case UnitConverterMassConcentrationUnit.PartPerMillionWater:
                    return "ppm water";
                case UnitConverterMassConcentrationUnit.NanogramPerLiter:
                    return "ng/L";
                case UnitConverterMassConcentrationUnit.MilligramPerMilliliter:
                    return "mg/mL";
                case UnitConverterMassConcentrationUnit.GramPerMilliliter:
                    return "g/mL";
                case UnitConverterMassConcentrationUnit.KilogramPerLiter:
                    return "kg/L";
                case UnitConverterMassConcentrationUnit.PoundPerCubicFoot:
                    return "lb/ft³";
                case UnitConverterMassConcentrationUnit.PoundPerUSGallon:
                    return "lb/gal US";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassConcentrationUnit.KilogramPerCubicMeter:
                    return "Kilogram Per Cubic Meter";
                case UnitConverterMassConcentrationUnit.GramPerLiter:
                    return "Gram Per Liter";
                case UnitConverterMassConcentrationUnit.MilligramPerLiter:
                    return "Milligram Per Liter";
                case UnitConverterMassConcentrationUnit.MicrogramPerLiter:
                    return "Microgram Per Liter";
                case UnitConverterMassConcentrationUnit.GramPerCubicMeter:
                    return "Gram Per Cubic Meter";
                case UnitConverterMassConcentrationUnit.PartPerMillionWater:
                    return "Part Per Million Water";
                case UnitConverterMassConcentrationUnit.NanogramPerLiter:
                    return "Nanogram Per Liter";
                case UnitConverterMassConcentrationUnit.MilligramPerMilliliter:
                    return "Milligram Per Milliliter";
                case UnitConverterMassConcentrationUnit.GramPerMilliliter:
                    return "Gram Per Milliliter";
                case UnitConverterMassConcentrationUnit.KilogramPerLiter:
                    return "Kilogram Per Liter";
                case UnitConverterMassConcentrationUnit.PoundPerCubicFoot:
                    return "Pound Per Cubic Foot";
                case UnitConverterMassConcentrationUnit.PoundPerUSGallon:
                    return "Pound Per US Gallon";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMassConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassConcentrationUnit.KilogramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.GramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.MilligramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.MicrogramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.GramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.PartPerMillionWater:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterMassConcentrationUnit.NanogramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.MilligramPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.GramPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.KilogramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassConcentrationUnit.PoundPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassConcentrationUnit.PoundPerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMassConcentrationUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMassConcentrationUnit.KilogramPerCubicMeter, UnitConverterMassConcentrationUnit.GramPerLiter, UnitConverterMassConcentrationUnit.MilligramPerLiter, UnitConverterMassConcentrationUnit.MicrogramPerLiter, UnitConverterMassConcentrationUnit.GramPerCubicMeter, UnitConverterMassConcentrationUnit.NanogramPerLiter, UnitConverterMassConcentrationUnit.MilligramPerMilliliter, UnitConverterMassConcentrationUnit.GramPerMilliliter, UnitConverterMassConcentrationUnit.KilogramPerLiter };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterMassConcentrationUnit.PartPerMillionWater };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMassConcentrationUnit.PoundPerCubicFoot };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterMassConcentrationUnit.PoundPerUSGallon };
                default:
                    return new[] { UnitConverterMassConcentrationUnit.KilogramPerCubicMeter, UnitConverterMassConcentrationUnit.GramPerLiter, UnitConverterMassConcentrationUnit.MilligramPerLiter, UnitConverterMassConcentrationUnit.MicrogramPerLiter, UnitConverterMassConcentrationUnit.GramPerCubicMeter, UnitConverterMassConcentrationUnit.PartPerMillionWater, UnitConverterMassConcentrationUnit.NanogramPerLiter, UnitConverterMassConcentrationUnit.MilligramPerMilliliter, UnitConverterMassConcentrationUnit.GramPerMilliliter, UnitConverterMassConcentrationUnit.KilogramPerLiter, UnitConverterMassConcentrationUnit.PoundPerCubicFoot, UnitConverterMassConcentrationUnit.PoundPerUSGallon };
            }
        }
    }
}
