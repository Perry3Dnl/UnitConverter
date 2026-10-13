namespace UnitTools.MomentOfInertia
{
    using UnitTools.MomentOfInertia.Metric;
    using UnitTools.MomentOfInertia.Imperial;

    public enum UnitToolsMomentOfInertiaUnit
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

    public static class UnitToolsMomentOfInertia
    {
        public static double Convert(double value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            double baseValue = ToKilogramSquareMeter(value, from);
            return FromKilogramSquareMeter(baseValue, to);
        }

        public static double ToKilogramSquareMeter(double value, UnitToolsMomentOfInertiaUnit from)
        {
            switch (from)
            {
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitToolsMetricMomentOfInertia.GramSquareCentimeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareCentimeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitToolsImperialMomentOfInertia.PoundSquareFootToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitToolsImperialMomentOfInertia.SlugSquareFootToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.GramSquareMeter:
                    return UnitToolsMetricMomentOfInertia.GramSquareMeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMillimeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitToolsMetricMomentOfInertia.GramSquareMillimeterToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.PoundSquareInch:
                    return UnitToolsImperialMomentOfInertia.PoundSquareInchToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.SlugSquareInch:
                    return UnitToolsImperialMomentOfInertia.SlugSquareInchToKilogramSquareMeter(value);
                case UnitToolsMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitToolsMetricMomentOfInertia.TonneSquareMeterToKilogramSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported moment of inertia unit.");
            }
        }

        public static double FromKilogramSquareMeter(double baseValue, UnitToolsMomentOfInertiaUnit to)
        {
            switch (to)
            {
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToGramSquareCentimeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareCentimeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitToolsImperialMomentOfInertia.KilogramSquareMeterToPoundSquareFoot(baseValue);
                case UnitToolsMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitToolsImperialMomentOfInertia.KilogramSquareMeterToSlugSquareFoot(baseValue);
                case UnitToolsMomentOfInertiaUnit.GramSquareMeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToGramSquareMeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToKilogramSquareMillimeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToGramSquareMillimeter(baseValue);
                case UnitToolsMomentOfInertiaUnit.PoundSquareInch:
                    return UnitToolsImperialMomentOfInertia.KilogramSquareMeterToPoundSquareInch(baseValue);
                case UnitToolsMomentOfInertiaUnit.SlugSquareInch:
                    return UnitToolsImperialMomentOfInertia.KilogramSquareMeterToSlugSquareInch(baseValue);
                case UnitToolsMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitToolsMetricMomentOfInertia.KilogramSquareMeterToTonneSquareMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported moment of inertia unit.");
            }
        }

        public static string GetSymbol(UnitToolsMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMeter:
                    return "kg·m²";
                case UnitToolsMomentOfInertiaUnit.GramSquareCentimeter:
                    return "g·cm²";
                case UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return "kg·cm²";
                case UnitToolsMomentOfInertiaUnit.PoundSquareFoot:
                    return "lb·ft²";
                case UnitToolsMomentOfInertiaUnit.SlugSquareFoot:
                    return "slug·ft²";
                case UnitToolsMomentOfInertiaUnit.GramSquareMeter:
                    return "g·m²";
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return "kg·mm²";
                case UnitToolsMomentOfInertiaUnit.GramSquareMillimeter:
                    return "g·mm²";
                case UnitToolsMomentOfInertiaUnit.PoundSquareInch:
                    return "lb·in²";
                case UnitToolsMomentOfInertiaUnit.SlugSquareInch:
                    return "slug·in²";
                case UnitToolsMomentOfInertiaUnit.TonneSquareMeter:
                    return "t·m²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMeter:
                    return "Kilogram Square Meter";
                case UnitToolsMomentOfInertiaUnit.GramSquareCentimeter:
                    return "Gram Square Centimeter";
                case UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return "Kilogram Square Centimeter";
                case UnitToolsMomentOfInertiaUnit.PoundSquareFoot:
                    return "Pound Square Foot";
                case UnitToolsMomentOfInertiaUnit.SlugSquareFoot:
                    return "Slug Square Foot";
                case UnitToolsMomentOfInertiaUnit.GramSquareMeter:
                    return "Gram Square Meter";
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return "Kilogram Square Millimeter";
                case UnitToolsMomentOfInertiaUnit.GramSquareMillimeter:
                    return "Gram Square Millimeter";
                case UnitToolsMomentOfInertiaUnit.PoundSquareInch:
                    return "Pound Square Inch";
                case UnitToolsMomentOfInertiaUnit.SlugSquareInch:
                    return "Slug Square Inch";
                case UnitToolsMomentOfInertiaUnit.TonneSquareMeter:
                    return "Tonne Square Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMomentOfInertiaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.GramSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.PoundSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentOfInertiaUnit.SlugSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentOfInertiaUnit.GramSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.GramSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentOfInertiaUnit.PoundSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentOfInertiaUnit.SlugSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentOfInertiaUnit.TonneSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMomentOfInertiaUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMomentOfInertiaUnit.KilogramSquareMeter, UnitToolsMomentOfInertiaUnit.GramSquareCentimeter, UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter, UnitToolsMomentOfInertiaUnit.GramSquareMeter, UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter, UnitToolsMomentOfInertiaUnit.GramSquareMillimeter, UnitToolsMomentOfInertiaUnit.TonneSquareMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMomentOfInertiaUnit.PoundSquareFoot, UnitToolsMomentOfInertiaUnit.SlugSquareFoot, UnitToolsMomentOfInertiaUnit.PoundSquareInch, UnitToolsMomentOfInertiaUnit.SlugSquareInch };
                default:
                    return new[] { UnitToolsMomentOfInertiaUnit.KilogramSquareMeter, UnitToolsMomentOfInertiaUnit.GramSquareCentimeter, UnitToolsMomentOfInertiaUnit.KilogramSquareCentimeter, UnitToolsMomentOfInertiaUnit.PoundSquareFoot, UnitToolsMomentOfInertiaUnit.SlugSquareFoot, UnitToolsMomentOfInertiaUnit.GramSquareMeter, UnitToolsMomentOfInertiaUnit.KilogramSquareMillimeter, UnitToolsMomentOfInertiaUnit.GramSquareMillimeter, UnitToolsMomentOfInertiaUnit.PoundSquareInch, UnitToolsMomentOfInertiaUnit.SlugSquareInch, UnitToolsMomentOfInertiaUnit.TonneSquareMeter };
            }
        }
    }
}
