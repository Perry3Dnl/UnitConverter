namespace UnitTools.Density
{
    using UnitTools.Density.Metric;
    using UnitTools.Density.Imperial;
    using UnitTools.Density.ImperialUS;
    using UnitTools.Density.ImperialUK;

    public enum UnitToolsDensityUnit
    {
        KilogramPerCubicMeter = 0,
        GramPerCubicMeter = 1,
        GramPerCubicCentimeter = 2,
        GramPerMilliliter = 3,
        KilogramPerLiter = 4,
        MetricTonPerCubicMeter = 5,
        PoundPerCubicFoot = 6,
        PoundPerCubicInch = 7,
        SlugPerCubicFoot = 8,
        MicrogramPerCubicMeter = 9,
        MilligramPerCubicMeter = 10,
        MilligramPerLiter = 11,
        MicrogramPerLiter = 12,
        GramPerLiter = 13,
        GramPerCubicMillimeter = 14,
        KilogramPerCubicCentimeter = 15,
        OuncePerCubicInch = 16,
        OuncePerUSGallon = 17,
        PoundPerUSGallon = 18,
        PoundPerImperialGallon = 19,
        TonUSPerCubicYard = 20,
        TonUKPerCubicYard = 21,
        MilligramPerMilliliter = 22,
        MicrogramPerMilliliter = 23,
        OuncePerCubicFoot = 24,
        ShortTonPerCubicFoot = 25,
        LongTonPerCubicFoot = 26,
        KilogramPerCubicMillimeter = 27,
        TonnesPerLiter = 28,
    }

    public static class UnitToolsDensity
    {
        public static double Convert(double value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            double baseValue = ToKilogramPerCubicMeter(value, from);
            return FromKilogramPerCubicMeter(baseValue, to);
        }

        public static double ToKilogramPerCubicMeter(double value, UnitToolsDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsDensityUnit.KilogramPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.GramPerCubicMeter:
                    return UnitToolsMetricDensity.GramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.GramPerCubicCentimeter:
                    return UnitToolsMetricDensity.GramPerCubicCentimeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.GramPerMilliliter:
                    return UnitToolsMetricDensity.GramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.KilogramPerLiter:
                    return UnitToolsMetricDensity.KilogramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MetricTonPerCubicMeter:
                    return UnitToolsMetricDensity.MetricTonPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.PoundPerCubicFoot:
                    return UnitToolsImperialDensity.PoundPerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.PoundPerCubicInch:
                    return UnitToolsImperialDensity.PoundPerCubicInchToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.SlugPerCubicFoot:
                    return UnitToolsImperialDensity.SlugPerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MicrogramPerCubicMeter:
                    return UnitToolsMetricDensity.MicrogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MilligramPerCubicMeter:
                    return UnitToolsMetricDensity.MilligramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MilligramPerLiter:
                    return UnitToolsMetricDensity.MilligramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MicrogramPerLiter:
                    return UnitToolsMetricDensity.MicrogramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.GramPerLiter:
                    return UnitToolsMetricDensity.GramPerLiterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.GramPerCubicMillimeter:
                    return UnitToolsMetricDensity.GramPerCubicMillimeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.KilogramPerCubicCentimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicCentimeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.OuncePerCubicInch:
                    return UnitToolsImperialDensity.OuncePerCubicInchToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.OuncePerUSGallon:
                    return UnitToolsImperialUSDensity.OuncePerUSGallonToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.PoundPerUSGallon:
                    return UnitToolsImperialUSDensity.PoundPerUSGallonToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.PoundPerImperialGallon:
                    return UnitToolsImperialUKDensity.PoundPerImperialGallonToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.TonUSPerCubicYard:
                    return UnitToolsImperialUSDensity.TonUSPerCubicYardToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.TonUKPerCubicYard:
                    return UnitToolsImperialUKDensity.TonUKPerCubicYardToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MilligramPerMilliliter:
                    return UnitToolsMetricDensity.MilligramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.MicrogramPerMilliliter:
                    return UnitToolsMetricDensity.MicrogramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.OuncePerCubicFoot:
                    return UnitToolsImperialDensity.OuncePerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.ShortTonPerCubicFoot:
                    return UnitToolsImperialUSDensity.ShortTonPerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.LongTonPerCubicFoot:
                    return UnitToolsImperialUKDensity.LongTonPerCubicFootToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.KilogramPerCubicMillimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMillimeterToKilogramPerCubicMeter(value);
                case UnitToolsDensityUnit.TonnesPerLiter:
                    return UnitToolsMetricDensity.TonnesPerLiterToKilogramPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported density unit.");
            }
        }

        public static double FromKilogramPerCubicMeter(double baseValue, UnitToolsDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsDensityUnit.KilogramPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMeter(baseValue);
                case UnitToolsDensityUnit.GramPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToGramPerCubicMeter(baseValue);
                case UnitToolsDensityUnit.GramPerCubicCentimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToGramPerCubicCentimeter(baseValue);
                case UnitToolsDensityUnit.GramPerMilliliter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToGramPerMilliliter(baseValue);
                case UnitToolsDensityUnit.KilogramPerLiter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToKilogramPerLiter(baseValue);
                case UnitToolsDensityUnit.MetricTonPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMetricTonPerCubicMeter(baseValue);
                case UnitToolsDensityUnit.PoundPerCubicFoot:
                    return UnitToolsImperialDensity.KilogramPerCubicMeterToPoundPerCubicFoot(baseValue);
                case UnitToolsDensityUnit.PoundPerCubicInch:
                    return UnitToolsImperialDensity.KilogramPerCubicMeterToPoundPerCubicInch(baseValue);
                case UnitToolsDensityUnit.SlugPerCubicFoot:
                    return UnitToolsImperialDensity.KilogramPerCubicMeterToSlugPerCubicFoot(baseValue);
                case UnitToolsDensityUnit.MicrogramPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMicrogramPerCubicMeter(baseValue);
                case UnitToolsDensityUnit.MilligramPerCubicMeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMilligramPerCubicMeter(baseValue);
                case UnitToolsDensityUnit.MilligramPerLiter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMilligramPerLiter(baseValue);
                case UnitToolsDensityUnit.MicrogramPerLiter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMicrogramPerLiter(baseValue);
                case UnitToolsDensityUnit.GramPerLiter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToGramPerLiter(baseValue);
                case UnitToolsDensityUnit.GramPerCubicMillimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToGramPerCubicMillimeter(baseValue);
                case UnitToolsDensityUnit.KilogramPerCubicCentimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToKilogramPerCubicCentimeter(baseValue);
                case UnitToolsDensityUnit.OuncePerCubicInch:
                    return UnitToolsImperialDensity.KilogramPerCubicMeterToOuncePerCubicInch(baseValue);
                case UnitToolsDensityUnit.OuncePerUSGallon:
                    return UnitToolsImperialUSDensity.KilogramPerCubicMeterToOuncePerUSGallon(baseValue);
                case UnitToolsDensityUnit.PoundPerUSGallon:
                    return UnitToolsImperialUSDensity.KilogramPerCubicMeterToPoundPerUSGallon(baseValue);
                case UnitToolsDensityUnit.PoundPerImperialGallon:
                    return UnitToolsImperialUKDensity.KilogramPerCubicMeterToPoundPerImperialGallon(baseValue);
                case UnitToolsDensityUnit.TonUSPerCubicYard:
                    return UnitToolsImperialUSDensity.KilogramPerCubicMeterToTonUSPerCubicYard(baseValue);
                case UnitToolsDensityUnit.TonUKPerCubicYard:
                    return UnitToolsImperialUKDensity.KilogramPerCubicMeterToTonUKPerCubicYard(baseValue);
                case UnitToolsDensityUnit.MilligramPerMilliliter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMilligramPerMilliliter(baseValue);
                case UnitToolsDensityUnit.MicrogramPerMilliliter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToMicrogramPerMilliliter(baseValue);
                case UnitToolsDensityUnit.OuncePerCubicFoot:
                    return UnitToolsImperialDensity.KilogramPerCubicMeterToOuncePerCubicFoot(baseValue);
                case UnitToolsDensityUnit.ShortTonPerCubicFoot:
                    return UnitToolsImperialUSDensity.KilogramPerCubicMeterToShortTonPerCubicFoot(baseValue);
                case UnitToolsDensityUnit.LongTonPerCubicFoot:
                    return UnitToolsImperialUKDensity.KilogramPerCubicMeterToLongTonPerCubicFoot(baseValue);
                case UnitToolsDensityUnit.KilogramPerCubicMillimeter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMillimeter(baseValue);
                case UnitToolsDensityUnit.TonnesPerLiter:
                    return UnitToolsMetricDensity.KilogramPerCubicMeterToTonnesPerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported density unit.");
            }
        }

        public static string GetSymbol(UnitToolsDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDensityUnit.KilogramPerCubicMeter:
                    return "kg/m³";
                case UnitToolsDensityUnit.GramPerCubicMeter:
                    return "g/m³";
                case UnitToolsDensityUnit.GramPerCubicCentimeter:
                    return "g/cm³";
                case UnitToolsDensityUnit.GramPerMilliliter:
                    return "g/mL";
                case UnitToolsDensityUnit.KilogramPerLiter:
                    return "kg/L";
                case UnitToolsDensityUnit.MetricTonPerCubicMeter:
                    return "t/m³";
                case UnitToolsDensityUnit.PoundPerCubicFoot:
                    return "lb/ft³";
                case UnitToolsDensityUnit.PoundPerCubicInch:
                    return "lb/in³";
                case UnitToolsDensityUnit.SlugPerCubicFoot:
                    return "slug/ft³";
                case UnitToolsDensityUnit.MicrogramPerCubicMeter:
                    return "µg/m³";
                case UnitToolsDensityUnit.MilligramPerCubicMeter:
                    return "mg/m³";
                case UnitToolsDensityUnit.MilligramPerLiter:
                    return "mg/L";
                case UnitToolsDensityUnit.MicrogramPerLiter:
                    return "µg/L";
                case UnitToolsDensityUnit.GramPerLiter:
                    return "g/L";
                case UnitToolsDensityUnit.GramPerCubicMillimeter:
                    return "g/mm³";
                case UnitToolsDensityUnit.KilogramPerCubicCentimeter:
                    return "kg/cm³";
                case UnitToolsDensityUnit.OuncePerCubicInch:
                    return "oz/in³";
                case UnitToolsDensityUnit.OuncePerUSGallon:
                    return "oz/gal US";
                case UnitToolsDensityUnit.PoundPerUSGallon:
                    return "lb/gal US";
                case UnitToolsDensityUnit.PoundPerImperialGallon:
                    return "lb/gal imp";
                case UnitToolsDensityUnit.TonUSPerCubicYard:
                    return "ton US/yd³";
                case UnitToolsDensityUnit.TonUKPerCubicYard:
                    return "ton UK/yd³";
                case UnitToolsDensityUnit.MilligramPerMilliliter:
                    return "mg/mL";
                case UnitToolsDensityUnit.MicrogramPerMilliliter:
                    return "µg/mL";
                case UnitToolsDensityUnit.OuncePerCubicFoot:
                    return "oz/ft³";
                case UnitToolsDensityUnit.ShortTonPerCubicFoot:
                    return "ton US/ft³";
                case UnitToolsDensityUnit.LongTonPerCubicFoot:
                    return "ton UK/ft³";
                case UnitToolsDensityUnit.KilogramPerCubicMillimeter:
                    return "kg/mm³";
                case UnitToolsDensityUnit.TonnesPerLiter:
                    return "t/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDensityUnit.KilogramPerCubicMeter:
                    return "kilogram per cubic meter";
                case UnitToolsDensityUnit.GramPerCubicMeter:
                    return "gram per cubic meter";
                case UnitToolsDensityUnit.GramPerCubicCentimeter:
                    return "gram per cubic centimeter";
                case UnitToolsDensityUnit.GramPerMilliliter:
                    return "gram per milliliter";
                case UnitToolsDensityUnit.KilogramPerLiter:
                    return "kilogram per liter";
                case UnitToolsDensityUnit.MetricTonPerCubicMeter:
                    return "metric ton per cubic meter";
                case UnitToolsDensityUnit.PoundPerCubicFoot:
                    return "pound per cubic foot";
                case UnitToolsDensityUnit.PoundPerCubicInch:
                    return "pound per cubic inch";
                case UnitToolsDensityUnit.SlugPerCubicFoot:
                    return "slug per cubic foot";
                case UnitToolsDensityUnit.MicrogramPerCubicMeter:
                    return "Microgram Per Cubic Meter";
                case UnitToolsDensityUnit.MilligramPerCubicMeter:
                    return "Milligram Per Cubic Meter";
                case UnitToolsDensityUnit.MilligramPerLiter:
                    return "Milligram Per Liter";
                case UnitToolsDensityUnit.MicrogramPerLiter:
                    return "Microgram Per Liter";
                case UnitToolsDensityUnit.GramPerLiter:
                    return "Gram Per Liter";
                case UnitToolsDensityUnit.GramPerCubicMillimeter:
                    return "Gram Per Cubic Millimeter";
                case UnitToolsDensityUnit.KilogramPerCubicCentimeter:
                    return "Kilogram Per Cubic Centimeter";
                case UnitToolsDensityUnit.OuncePerCubicInch:
                    return "Ounce Per Cubic Inch";
                case UnitToolsDensityUnit.OuncePerUSGallon:
                    return "Ounce Per US Gallon";
                case UnitToolsDensityUnit.PoundPerUSGallon:
                    return "Pound Per US Gallon";
                case UnitToolsDensityUnit.PoundPerImperialGallon:
                    return "Pound Per Imperial Gallon";
                case UnitToolsDensityUnit.TonUSPerCubicYard:
                    return "Ton US Per Cubic Yard";
                case UnitToolsDensityUnit.TonUKPerCubicYard:
                    return "Ton UK Per Cubic Yard";
                case UnitToolsDensityUnit.MilligramPerMilliliter:
                    return "Milligram Per Milliliter";
                case UnitToolsDensityUnit.MicrogramPerMilliliter:
                    return "Microgram Per Milliliter";
                case UnitToolsDensityUnit.OuncePerCubicFoot:
                    return "Ounce Per Cubic Foot";
                case UnitToolsDensityUnit.ShortTonPerCubicFoot:
                    return "Short Ton Per Cubic Foot";
                case UnitToolsDensityUnit.LongTonPerCubicFoot:
                    return "Long Ton Per Cubic Foot";
                case UnitToolsDensityUnit.KilogramPerCubicMillimeter:
                    return "Kilogram Per Cubic Millimeter";
                case UnitToolsDensityUnit.TonnesPerLiter:
                    return "Tonnes Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDensityUnit.KilogramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.GramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.GramPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.GramPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.KilogramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.MetricTonPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.PoundPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDensityUnit.PoundPerCubicInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDensityUnit.SlugPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDensityUnit.MicrogramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.MilligramPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.MilligramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.MicrogramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.GramPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.GramPerCubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.KilogramPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.OuncePerCubicInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDensityUnit.OuncePerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsDensityUnit.PoundPerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsDensityUnit.PoundPerImperialGallon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsDensityUnit.TonUSPerCubicYard:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsDensityUnit.TonUKPerCubicYard:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsDensityUnit.MilligramPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.MicrogramPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.OuncePerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDensityUnit.ShortTonPerCubicFoot:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsDensityUnit.LongTonPerCubicFoot:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsDensityUnit.KilogramPerCubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDensityUnit.TonnesPerLiter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsDensityUnit.KilogramPerCubicMeter, UnitToolsDensityUnit.GramPerCubicMeter, UnitToolsDensityUnit.GramPerCubicCentimeter, UnitToolsDensityUnit.GramPerMilliliter, UnitToolsDensityUnit.KilogramPerLiter, UnitToolsDensityUnit.MetricTonPerCubicMeter, UnitToolsDensityUnit.MicrogramPerCubicMeter, UnitToolsDensityUnit.MilligramPerCubicMeter, UnitToolsDensityUnit.MilligramPerLiter, UnitToolsDensityUnit.MicrogramPerLiter, UnitToolsDensityUnit.GramPerLiter, UnitToolsDensityUnit.GramPerCubicMillimeter, UnitToolsDensityUnit.KilogramPerCubicCentimeter, UnitToolsDensityUnit.MilligramPerMilliliter, UnitToolsDensityUnit.MicrogramPerMilliliter, UnitToolsDensityUnit.KilogramPerCubicMillimeter, UnitToolsDensityUnit.TonnesPerLiter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsDensityUnit.PoundPerCubicFoot, UnitToolsDensityUnit.PoundPerCubicInch, UnitToolsDensityUnit.SlugPerCubicFoot, UnitToolsDensityUnit.OuncePerCubicInch, UnitToolsDensityUnit.OuncePerCubicFoot };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsDensityUnit.OuncePerUSGallon, UnitToolsDensityUnit.PoundPerUSGallon, UnitToolsDensityUnit.TonUSPerCubicYard, UnitToolsDensityUnit.ShortTonPerCubicFoot };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsDensityUnit.PoundPerImperialGallon, UnitToolsDensityUnit.TonUKPerCubicYard, UnitToolsDensityUnit.LongTonPerCubicFoot };
                default:
                    return new[] { UnitToolsDensityUnit.KilogramPerCubicMeter, UnitToolsDensityUnit.GramPerCubicMeter, UnitToolsDensityUnit.GramPerCubicCentimeter, UnitToolsDensityUnit.GramPerMilliliter, UnitToolsDensityUnit.KilogramPerLiter, UnitToolsDensityUnit.MetricTonPerCubicMeter, UnitToolsDensityUnit.PoundPerCubicFoot, UnitToolsDensityUnit.PoundPerCubicInch, UnitToolsDensityUnit.SlugPerCubicFoot, UnitToolsDensityUnit.MicrogramPerCubicMeter, UnitToolsDensityUnit.MilligramPerCubicMeter, UnitToolsDensityUnit.MilligramPerLiter, UnitToolsDensityUnit.MicrogramPerLiter, UnitToolsDensityUnit.GramPerLiter, UnitToolsDensityUnit.GramPerCubicMillimeter, UnitToolsDensityUnit.KilogramPerCubicCentimeter, UnitToolsDensityUnit.OuncePerCubicInch, UnitToolsDensityUnit.OuncePerUSGallon, UnitToolsDensityUnit.PoundPerUSGallon, UnitToolsDensityUnit.PoundPerImperialGallon, UnitToolsDensityUnit.TonUSPerCubicYard, UnitToolsDensityUnit.TonUKPerCubicYard, UnitToolsDensityUnit.MilligramPerMilliliter, UnitToolsDensityUnit.MicrogramPerMilliliter, UnitToolsDensityUnit.OuncePerCubicFoot, UnitToolsDensityUnit.ShortTonPerCubicFoot, UnitToolsDensityUnit.LongTonPerCubicFoot, UnitToolsDensityUnit.KilogramPerCubicMillimeter, UnitToolsDensityUnit.TonnesPerLiter };
            }
        }
    }
}
