namespace UnitConverter.Density
{
    using UnitConverter.Density.Metric;
    using UnitConverter.Density.Imperial;
    using UnitConverter.Density.ImperialUS;
    using UnitConverter.Density.ImperialUK;

    public enum UnitConverterDensityUnit
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

    public static class UnitConverterDensity
    {
        public static double Convert(double value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            double baseValue = ToKilogramPerCubicMeter(value, from);
            return FromKilogramPerCubicMeter(baseValue, to);
        }

        public static double ToKilogramPerCubicMeter(double value, UnitConverterDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterDensityUnit.KilogramPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.GramPerCubicMeter:
                    return UnitConverterMetricDensity.GramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.GramPerCubicCentimeter:
                    return UnitConverterMetricDensity.GramPerCubicCentimeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.GramPerMilliliter:
                    return UnitConverterMetricDensity.GramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.KilogramPerLiter:
                    return UnitConverterMetricDensity.KilogramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MetricTonPerCubicMeter:
                    return UnitConverterMetricDensity.MetricTonPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.PoundPerCubicFoot:
                    return UnitConverterImperialDensity.PoundPerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.PoundPerCubicInch:
                    return UnitConverterImperialDensity.PoundPerCubicInchToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.SlugPerCubicFoot:
                    return UnitConverterImperialDensity.SlugPerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MicrogramPerCubicMeter:
                    return UnitConverterMetricDensity.MicrogramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MilligramPerCubicMeter:
                    return UnitConverterMetricDensity.MilligramPerCubicMeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MilligramPerLiter:
                    return UnitConverterMetricDensity.MilligramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MicrogramPerLiter:
                    return UnitConverterMetricDensity.MicrogramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.GramPerLiter:
                    return UnitConverterMetricDensity.GramPerLiterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.GramPerCubicMillimeter:
                    return UnitConverterMetricDensity.GramPerCubicMillimeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.KilogramPerCubicCentimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicCentimeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.OuncePerCubicInch:
                    return UnitConverterImperialDensity.OuncePerCubicInchToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.OuncePerUSGallon:
                    return UnitConverterImperialUSDensity.OuncePerUSGallonToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.PoundPerUSGallon:
                    return UnitConverterImperialUSDensity.PoundPerUSGallonToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.PoundPerImperialGallon:
                    return UnitConverterImperialUKDensity.PoundPerImperialGallonToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.TonUSPerCubicYard:
                    return UnitConverterImperialUSDensity.TonUSPerCubicYardToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.TonUKPerCubicYard:
                    return UnitConverterImperialUKDensity.TonUKPerCubicYardToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MilligramPerMilliliter:
                    return UnitConverterMetricDensity.MilligramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.MicrogramPerMilliliter:
                    return UnitConverterMetricDensity.MicrogramPerMilliliterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.OuncePerCubicFoot:
                    return UnitConverterImperialDensity.OuncePerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.ShortTonPerCubicFoot:
                    return UnitConverterImperialUSDensity.ShortTonPerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.LongTonPerCubicFoot:
                    return UnitConverterImperialUKDensity.LongTonPerCubicFootToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.KilogramPerCubicMillimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMillimeterToKilogramPerCubicMeter(value);
                case UnitConverterDensityUnit.TonnesPerLiter:
                    return UnitConverterMetricDensity.TonnesPerLiterToKilogramPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported density unit.");
            }
        }

        public static double FromKilogramPerCubicMeter(double baseValue, UnitConverterDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterDensityUnit.KilogramPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMeter(baseValue);
                case UnitConverterDensityUnit.GramPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToGramPerCubicMeter(baseValue);
                case UnitConverterDensityUnit.GramPerCubicCentimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToGramPerCubicCentimeter(baseValue);
                case UnitConverterDensityUnit.GramPerMilliliter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToGramPerMilliliter(baseValue);
                case UnitConverterDensityUnit.KilogramPerLiter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToKilogramPerLiter(baseValue);
                case UnitConverterDensityUnit.MetricTonPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMetricTonPerCubicMeter(baseValue);
                case UnitConverterDensityUnit.PoundPerCubicFoot:
                    return UnitConverterImperialDensity.KilogramPerCubicMeterToPoundPerCubicFoot(baseValue);
                case UnitConverterDensityUnit.PoundPerCubicInch:
                    return UnitConverterImperialDensity.KilogramPerCubicMeterToPoundPerCubicInch(baseValue);
                case UnitConverterDensityUnit.SlugPerCubicFoot:
                    return UnitConverterImperialDensity.KilogramPerCubicMeterToSlugPerCubicFoot(baseValue);
                case UnitConverterDensityUnit.MicrogramPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMicrogramPerCubicMeter(baseValue);
                case UnitConverterDensityUnit.MilligramPerCubicMeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMilligramPerCubicMeter(baseValue);
                case UnitConverterDensityUnit.MilligramPerLiter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMilligramPerLiter(baseValue);
                case UnitConverterDensityUnit.MicrogramPerLiter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMicrogramPerLiter(baseValue);
                case UnitConverterDensityUnit.GramPerLiter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToGramPerLiter(baseValue);
                case UnitConverterDensityUnit.GramPerCubicMillimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToGramPerCubicMillimeter(baseValue);
                case UnitConverterDensityUnit.KilogramPerCubicCentimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToKilogramPerCubicCentimeter(baseValue);
                case UnitConverterDensityUnit.OuncePerCubicInch:
                    return UnitConverterImperialDensity.KilogramPerCubicMeterToOuncePerCubicInch(baseValue);
                case UnitConverterDensityUnit.OuncePerUSGallon:
                    return UnitConverterImperialUSDensity.KilogramPerCubicMeterToOuncePerUSGallon(baseValue);
                case UnitConverterDensityUnit.PoundPerUSGallon:
                    return UnitConverterImperialUSDensity.KilogramPerCubicMeterToPoundPerUSGallon(baseValue);
                case UnitConverterDensityUnit.PoundPerImperialGallon:
                    return UnitConverterImperialUKDensity.KilogramPerCubicMeterToPoundPerImperialGallon(baseValue);
                case UnitConverterDensityUnit.TonUSPerCubicYard:
                    return UnitConverterImperialUSDensity.KilogramPerCubicMeterToTonUSPerCubicYard(baseValue);
                case UnitConverterDensityUnit.TonUKPerCubicYard:
                    return UnitConverterImperialUKDensity.KilogramPerCubicMeterToTonUKPerCubicYard(baseValue);
                case UnitConverterDensityUnit.MilligramPerMilliliter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMilligramPerMilliliter(baseValue);
                case UnitConverterDensityUnit.MicrogramPerMilliliter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToMicrogramPerMilliliter(baseValue);
                case UnitConverterDensityUnit.OuncePerCubicFoot:
                    return UnitConverterImperialDensity.KilogramPerCubicMeterToOuncePerCubicFoot(baseValue);
                case UnitConverterDensityUnit.ShortTonPerCubicFoot:
                    return UnitConverterImperialUSDensity.KilogramPerCubicMeterToShortTonPerCubicFoot(baseValue);
                case UnitConverterDensityUnit.LongTonPerCubicFoot:
                    return UnitConverterImperialUKDensity.KilogramPerCubicMeterToLongTonPerCubicFoot(baseValue);
                case UnitConverterDensityUnit.KilogramPerCubicMillimeter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToKilogramPerCubicMillimeter(baseValue);
                case UnitConverterDensityUnit.TonnesPerLiter:
                    return UnitConverterMetricDensity.KilogramPerCubicMeterToTonnesPerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported density unit.");
            }
        }

        public static string GetSymbol(UnitConverterDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDensityUnit.KilogramPerCubicMeter:
                    return "kg/m³";
                case UnitConverterDensityUnit.GramPerCubicMeter:
                    return "g/m³";
                case UnitConverterDensityUnit.GramPerCubicCentimeter:
                    return "g/cm³";
                case UnitConverterDensityUnit.GramPerMilliliter:
                    return "g/mL";
                case UnitConverterDensityUnit.KilogramPerLiter:
                    return "kg/L";
                case UnitConverterDensityUnit.MetricTonPerCubicMeter:
                    return "t/m³";
                case UnitConverterDensityUnit.PoundPerCubicFoot:
                    return "lb/ft³";
                case UnitConverterDensityUnit.PoundPerCubicInch:
                    return "lb/in³";
                case UnitConverterDensityUnit.SlugPerCubicFoot:
                    return "slug/ft³";
                case UnitConverterDensityUnit.MicrogramPerCubicMeter:
                    return "µg/m³";
                case UnitConverterDensityUnit.MilligramPerCubicMeter:
                    return "mg/m³";
                case UnitConverterDensityUnit.MilligramPerLiter:
                    return "mg/L";
                case UnitConverterDensityUnit.MicrogramPerLiter:
                    return "µg/L";
                case UnitConverterDensityUnit.GramPerLiter:
                    return "g/L";
                case UnitConverterDensityUnit.GramPerCubicMillimeter:
                    return "g/mm³";
                case UnitConverterDensityUnit.KilogramPerCubicCentimeter:
                    return "kg/cm³";
                case UnitConverterDensityUnit.OuncePerCubicInch:
                    return "oz/in³";
                case UnitConverterDensityUnit.OuncePerUSGallon:
                    return "oz/gal US";
                case UnitConverterDensityUnit.PoundPerUSGallon:
                    return "lb/gal US";
                case UnitConverterDensityUnit.PoundPerImperialGallon:
                    return "lb/gal imp";
                case UnitConverterDensityUnit.TonUSPerCubicYard:
                    return "ton US/yd³";
                case UnitConverterDensityUnit.TonUKPerCubicYard:
                    return "ton UK/yd³";
                case UnitConverterDensityUnit.MilligramPerMilliliter:
                    return "mg/mL";
                case UnitConverterDensityUnit.MicrogramPerMilliliter:
                    return "µg/mL";
                case UnitConverterDensityUnit.OuncePerCubicFoot:
                    return "oz/ft³";
                case UnitConverterDensityUnit.ShortTonPerCubicFoot:
                    return "ton US/ft³";
                case UnitConverterDensityUnit.LongTonPerCubicFoot:
                    return "ton UK/ft³";
                case UnitConverterDensityUnit.KilogramPerCubicMillimeter:
                    return "kg/mm³";
                case UnitConverterDensityUnit.TonnesPerLiter:
                    return "t/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDensityUnit.KilogramPerCubicMeter:
                    return "kilogram per cubic meter";
                case UnitConverterDensityUnit.GramPerCubicMeter:
                    return "gram per cubic meter";
                case UnitConverterDensityUnit.GramPerCubicCentimeter:
                    return "gram per cubic centimeter";
                case UnitConverterDensityUnit.GramPerMilliliter:
                    return "gram per milliliter";
                case UnitConverterDensityUnit.KilogramPerLiter:
                    return "kilogram per liter";
                case UnitConverterDensityUnit.MetricTonPerCubicMeter:
                    return "metric ton per cubic meter";
                case UnitConverterDensityUnit.PoundPerCubicFoot:
                    return "pound per cubic foot";
                case UnitConverterDensityUnit.PoundPerCubicInch:
                    return "pound per cubic inch";
                case UnitConverterDensityUnit.SlugPerCubicFoot:
                    return "slug per cubic foot";
                case UnitConverterDensityUnit.MicrogramPerCubicMeter:
                    return "Microgram Per Cubic Meter";
                case UnitConverterDensityUnit.MilligramPerCubicMeter:
                    return "Milligram Per Cubic Meter";
                case UnitConverterDensityUnit.MilligramPerLiter:
                    return "Milligram Per Liter";
                case UnitConverterDensityUnit.MicrogramPerLiter:
                    return "Microgram Per Liter";
                case UnitConverterDensityUnit.GramPerLiter:
                    return "Gram Per Liter";
                case UnitConverterDensityUnit.GramPerCubicMillimeter:
                    return "Gram Per Cubic Millimeter";
                case UnitConverterDensityUnit.KilogramPerCubicCentimeter:
                    return "Kilogram Per Cubic Centimeter";
                case UnitConverterDensityUnit.OuncePerCubicInch:
                    return "Ounce Per Cubic Inch";
                case UnitConverterDensityUnit.OuncePerUSGallon:
                    return "Ounce Per US Gallon";
                case UnitConverterDensityUnit.PoundPerUSGallon:
                    return "Pound Per US Gallon";
                case UnitConverterDensityUnit.PoundPerImperialGallon:
                    return "Pound Per Imperial Gallon";
                case UnitConverterDensityUnit.TonUSPerCubicYard:
                    return "Ton US Per Cubic Yard";
                case UnitConverterDensityUnit.TonUKPerCubicYard:
                    return "Ton UK Per Cubic Yard";
                case UnitConverterDensityUnit.MilligramPerMilliliter:
                    return "Milligram Per Milliliter";
                case UnitConverterDensityUnit.MicrogramPerMilliliter:
                    return "Microgram Per Milliliter";
                case UnitConverterDensityUnit.OuncePerCubicFoot:
                    return "Ounce Per Cubic Foot";
                case UnitConverterDensityUnit.ShortTonPerCubicFoot:
                    return "Short Ton Per Cubic Foot";
                case UnitConverterDensityUnit.LongTonPerCubicFoot:
                    return "Long Ton Per Cubic Foot";
                case UnitConverterDensityUnit.KilogramPerCubicMillimeter:
                    return "Kilogram Per Cubic Millimeter";
                case UnitConverterDensityUnit.TonnesPerLiter:
                    return "Tonnes Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDensityUnit.KilogramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.GramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.GramPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.GramPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.KilogramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.MetricTonPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.PoundPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDensityUnit.PoundPerCubicInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDensityUnit.SlugPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDensityUnit.MicrogramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.MilligramPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.MilligramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.MicrogramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.GramPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.GramPerCubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.KilogramPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.OuncePerCubicInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDensityUnit.OuncePerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterDensityUnit.PoundPerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterDensityUnit.PoundPerImperialGallon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterDensityUnit.TonUSPerCubicYard:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterDensityUnit.TonUKPerCubicYard:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterDensityUnit.MilligramPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.MicrogramPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.OuncePerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDensityUnit.ShortTonPerCubicFoot:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterDensityUnit.LongTonPerCubicFoot:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterDensityUnit.KilogramPerCubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDensityUnit.TonnesPerLiter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterDensityUnit.KilogramPerCubicMeter, UnitConverterDensityUnit.GramPerCubicMeter, UnitConverterDensityUnit.GramPerCubicCentimeter, UnitConverterDensityUnit.GramPerMilliliter, UnitConverterDensityUnit.KilogramPerLiter, UnitConverterDensityUnit.MetricTonPerCubicMeter, UnitConverterDensityUnit.MicrogramPerCubicMeter, UnitConverterDensityUnit.MilligramPerCubicMeter, UnitConverterDensityUnit.MilligramPerLiter, UnitConverterDensityUnit.MicrogramPerLiter, UnitConverterDensityUnit.GramPerLiter, UnitConverterDensityUnit.GramPerCubicMillimeter, UnitConverterDensityUnit.KilogramPerCubicCentimeter, UnitConverterDensityUnit.MilligramPerMilliliter, UnitConverterDensityUnit.MicrogramPerMilliliter, UnitConverterDensityUnit.KilogramPerCubicMillimeter, UnitConverterDensityUnit.TonnesPerLiter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterDensityUnit.PoundPerCubicFoot, UnitConverterDensityUnit.PoundPerCubicInch, UnitConverterDensityUnit.SlugPerCubicFoot, UnitConverterDensityUnit.OuncePerCubicInch, UnitConverterDensityUnit.OuncePerCubicFoot };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterDensityUnit.OuncePerUSGallon, UnitConverterDensityUnit.PoundPerUSGallon, UnitConverterDensityUnit.TonUSPerCubicYard, UnitConverterDensityUnit.ShortTonPerCubicFoot };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterDensityUnit.PoundPerImperialGallon, UnitConverterDensityUnit.TonUKPerCubicYard, UnitConverterDensityUnit.LongTonPerCubicFoot };
                default:
                    return new[] { UnitConverterDensityUnit.KilogramPerCubicMeter, UnitConverterDensityUnit.GramPerCubicMeter, UnitConverterDensityUnit.GramPerCubicCentimeter, UnitConverterDensityUnit.GramPerMilliliter, UnitConverterDensityUnit.KilogramPerLiter, UnitConverterDensityUnit.MetricTonPerCubicMeter, UnitConverterDensityUnit.PoundPerCubicFoot, UnitConverterDensityUnit.PoundPerCubicInch, UnitConverterDensityUnit.SlugPerCubicFoot, UnitConverterDensityUnit.MicrogramPerCubicMeter, UnitConverterDensityUnit.MilligramPerCubicMeter, UnitConverterDensityUnit.MilligramPerLiter, UnitConverterDensityUnit.MicrogramPerLiter, UnitConverterDensityUnit.GramPerLiter, UnitConverterDensityUnit.GramPerCubicMillimeter, UnitConverterDensityUnit.KilogramPerCubicCentimeter, UnitConverterDensityUnit.OuncePerCubicInch, UnitConverterDensityUnit.OuncePerUSGallon, UnitConverterDensityUnit.PoundPerUSGallon, UnitConverterDensityUnit.PoundPerImperialGallon, UnitConverterDensityUnit.TonUSPerCubicYard, UnitConverterDensityUnit.TonUKPerCubicYard, UnitConverterDensityUnit.MilligramPerMilliliter, UnitConverterDensityUnit.MicrogramPerMilliliter, UnitConverterDensityUnit.OuncePerCubicFoot, UnitConverterDensityUnit.ShortTonPerCubicFoot, UnitConverterDensityUnit.LongTonPerCubicFoot, UnitConverterDensityUnit.KilogramPerCubicMillimeter, UnitConverterDensityUnit.TonnesPerLiter };
            }
        }
    }
}
