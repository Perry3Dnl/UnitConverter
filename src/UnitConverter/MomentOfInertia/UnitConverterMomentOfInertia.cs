namespace UnitConverter.MomentOfInertia
{
    using UnitConverter.MomentOfInertia.Metric;
    using UnitConverter.MomentOfInertia.Imperial;

    public enum UnitConverterMomentOfInertiaUnit
    {
        KilogramSquareMeter = 0,
        GramSquareCentimeter = 1,
        KilogramSquareCentimeter = 2,
        PoundSquareFoot = 3,
        SlugSquareFoot = 4,
        GramSquareMeter = 5,
        KilogramSquareMillimeter = 6,
        GramSquareMillimeter = 7,
        PoundSquareInch = 8,
        SlugSquareInch = 9,
        TonneSquareMeter = 10,
    }

    public static class UnitConverterMomentOfInertia
    {
        public static double Convert(double value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            double baseValue = ToKilogramSquareMeter(value, from);
            return FromKilogramSquareMeter(baseValue, to);
        }

        public static double ToKilogramSquareMeter(double value, UnitConverterMomentOfInertiaUnit from)
        {
            switch (from)
            {
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitConverterMetricMomentOfInertia.GramSquareCentimeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareCentimeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitConverterImperialMomentOfInertia.PoundSquareFootToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitConverterImperialMomentOfInertia.SlugSquareFootToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.GramSquareMeter:
                    return UnitConverterMetricMomentOfInertia.GramSquareMeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMillimeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitConverterMetricMomentOfInertia.GramSquareMillimeterToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.PoundSquareInch:
                    return UnitConverterImperialMomentOfInertia.PoundSquareInchToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.SlugSquareInch:
                    return UnitConverterImperialMomentOfInertia.SlugSquareInchToKilogramSquareMeter(value);
                case UnitConverterMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitConverterMetricMomentOfInertia.TonneSquareMeterToKilogramSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported moment of inertia unit.");
            }
        }

        public static double FromKilogramSquareMeter(double baseValue, UnitConverterMomentOfInertiaUnit to)
        {
            switch (to)
            {
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToGramSquareCentimeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareCentimeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitConverterImperialMomentOfInertia.KilogramSquareMeterToPoundSquareFoot(baseValue);
                case UnitConverterMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitConverterImperialMomentOfInertia.KilogramSquareMeterToSlugSquareFoot(baseValue);
                case UnitConverterMomentOfInertiaUnit.GramSquareMeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToGramSquareMeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMillimeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToGramSquareMillimeter(baseValue);
                case UnitConverterMomentOfInertiaUnit.PoundSquareInch:
                    return UnitConverterImperialMomentOfInertia.KilogramSquareMeterToPoundSquareInch(baseValue);
                case UnitConverterMomentOfInertiaUnit.SlugSquareInch:
                    return UnitConverterImperialMomentOfInertia.KilogramSquareMeterToSlugSquareInch(baseValue);
                case UnitConverterMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitConverterMetricMomentOfInertia.KilogramSquareMeterToTonneSquareMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported moment of inertia unit.");
            }
        }

        public static string GetSymbol(UnitConverterMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMeter:
                    return "kg·m²";
                case UnitConverterMomentOfInertiaUnit.GramSquareCentimeter:
                    return "g·cm²";
                case UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return "kg·cm²";
                case UnitConverterMomentOfInertiaUnit.PoundSquareFoot:
                    return "lb·ft²";
                case UnitConverterMomentOfInertiaUnit.SlugSquareFoot:
                    return "slug·ft²";
                case UnitConverterMomentOfInertiaUnit.GramSquareMeter:
                    return "g·m²";
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return "kg·mm²";
                case UnitConverterMomentOfInertiaUnit.GramSquareMillimeter:
                    return "g·mm²";
                case UnitConverterMomentOfInertiaUnit.PoundSquareInch:
                    return "lb·in²";
                case UnitConverterMomentOfInertiaUnit.SlugSquareInch:
                    return "slug·in²";
                case UnitConverterMomentOfInertiaUnit.TonneSquareMeter:
                    return "t·m²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMeter:
                    return "Kilogram Square Meter";
                case UnitConverterMomentOfInertiaUnit.GramSquareCentimeter:
                    return "Gram Square Centimeter";
                case UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return "Kilogram Square Centimeter";
                case UnitConverterMomentOfInertiaUnit.PoundSquareFoot:
                    return "Pound Square Foot";
                case UnitConverterMomentOfInertiaUnit.SlugSquareFoot:
                    return "Slug Square Foot";
                case UnitConverterMomentOfInertiaUnit.GramSquareMeter:
                    return "Gram Square Meter";
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return "Kilogram Square Millimeter";
                case UnitConverterMomentOfInertiaUnit.GramSquareMillimeter:
                    return "Gram Square Millimeter";
                case UnitConverterMomentOfInertiaUnit.PoundSquareInch:
                    return "Pound Square Inch";
                case UnitConverterMomentOfInertiaUnit.SlugSquareInch:
                    return "Slug Square Inch";
                case UnitConverterMomentOfInertiaUnit.TonneSquareMeter:
                    return "Tonne Square Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentOfInertiaUnit.GramSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentOfInertiaUnit.PoundSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentOfInertiaUnit.SlugSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMomentOfInertiaUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMomentOfInertiaUnit.KilogramSquareMeter, UnitConverterMomentOfInertiaUnit.GramSquareCentimeter, UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter, UnitConverterMomentOfInertiaUnit.GramSquareMeter, UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter, UnitConverterMomentOfInertiaUnit.GramSquareMillimeter, UnitConverterMomentOfInertiaUnit.TonneSquareMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMomentOfInertiaUnit.PoundSquareFoot, UnitConverterMomentOfInertiaUnit.SlugSquareFoot, UnitConverterMomentOfInertiaUnit.PoundSquareInch, UnitConverterMomentOfInertiaUnit.SlugSquareInch };
                default:
                    return new[] { UnitConverterMomentOfInertiaUnit.KilogramSquareMeter, UnitConverterMomentOfInertiaUnit.GramSquareCentimeter, UnitConverterMomentOfInertiaUnit.KilogramSquareCentimeter, UnitConverterMomentOfInertiaUnit.PoundSquareFoot, UnitConverterMomentOfInertiaUnit.SlugSquareFoot, UnitConverterMomentOfInertiaUnit.GramSquareMeter, UnitConverterMomentOfInertiaUnit.KilogramSquareMillimeter, UnitConverterMomentOfInertiaUnit.GramSquareMillimeter, UnitConverterMomentOfInertiaUnit.PoundSquareInch, UnitConverterMomentOfInertiaUnit.SlugSquareInch, UnitConverterMomentOfInertiaUnit.TonneSquareMeter };
            }
        }
    }
}
