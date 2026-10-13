namespace UnitTools.AreaDensity
{
    using UnitTools.AreaDensity.Metric;
    using UnitTools.AreaDensity.Imperial;

    public enum UnitToolsAreaDensityUnit
    {
        KilogramPerSquareMeter = 0,
        GramPerSquareMeter = 1,
        MilligramPerSquareMeter = 2,
        PoundPerSquareFoot = 3,
        PoundPerSquareInch = 4,
        OuncePerSquareYard = 5,
        MicrogramPerSquareMeter = 6,
        GramPerSquareCentimeter = 7,
        KilogramPerSquareMillimeter = 8,
        OuncePerSquareFoot = 9,
        OuncePerSquareInch = 10,
        PoundPerSquareYard = 11,
    }

    public static class UnitToolsAreaDensity
    {
        public static double Convert(double value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            double baseValue = ToKilogramPerSquareMeter(value, from);
            return FromKilogramPerSquareMeter(baseValue, to);
        }

        public static double ToKilogramPerSquareMeter(double value, UnitToolsAreaDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.GramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.GramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.MilligramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.PoundPerSquareFoot:
                    return UnitToolsImperialAreaDensity.PoundPerSquareFootToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.PoundPerSquareInch:
                    return UnitToolsImperialAreaDensity.PoundPerSquareInchToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.OuncePerSquareYard:
                    return UnitToolsImperialAreaDensity.OuncePerSquareYardToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.MicrogramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitToolsMetricAreaDensity.GramPerSquareCentimeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMillimeterToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.OuncePerSquareFoot:
                    return UnitToolsImperialAreaDensity.OuncePerSquareFootToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.OuncePerSquareInch:
                    return UnitToolsImperialAreaDensity.OuncePerSquareInchToKilogramPerSquareMeter(value);
                case UnitToolsAreaDensityUnit.PoundPerSquareYard:
                    return UnitToolsImperialAreaDensity.PoundPerSquareYardToKilogramPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported area density unit.");
            }
        }

        public static double FromKilogramPerSquareMeter(double baseValue, UnitToolsAreaDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMeter(baseValue);
                case UnitToolsAreaDensityUnit.GramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToGramPerSquareMeter(baseValue);
                case UnitToolsAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToMilligramPerSquareMeter(baseValue);
                case UnitToolsAreaDensityUnit.PoundPerSquareFoot:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareFoot(baseValue);
                case UnitToolsAreaDensityUnit.PoundPerSquareInch:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareInch(baseValue);
                case UnitToolsAreaDensityUnit.OuncePerSquareYard:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareYard(baseValue);
                case UnitToolsAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToMicrogramPerSquareMeter(baseValue);
                case UnitToolsAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToGramPerSquareCentimeter(baseValue);
                case UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitToolsMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMillimeter(baseValue);
                case UnitToolsAreaDensityUnit.OuncePerSquareFoot:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareFoot(baseValue);
                case UnitToolsAreaDensityUnit.OuncePerSquareInch:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareInch(baseValue);
                case UnitToolsAreaDensityUnit.PoundPerSquareYard:
                    return UnitToolsImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareYard(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported area density unit.");
            }
        }

        public static string GetSymbol(UnitToolsAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaDensityUnit.KilogramPerSquareMeter:
                    return "kg/m²";
                case UnitToolsAreaDensityUnit.GramPerSquareMeter:
                    return "g/m²";
                case UnitToolsAreaDensityUnit.MilligramPerSquareMeter:
                    return "mg/m²";
                case UnitToolsAreaDensityUnit.PoundPerSquareFoot:
                    return "lb/ft²";
                case UnitToolsAreaDensityUnit.PoundPerSquareInch:
                    return "lb/in²";
                case UnitToolsAreaDensityUnit.OuncePerSquareYard:
                    return "oz/yd²";
                case UnitToolsAreaDensityUnit.MicrogramPerSquareMeter:
                    return "µg/m²";
                case UnitToolsAreaDensityUnit.GramPerSquareCentimeter:
                    return "g/cm²";
                case UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter:
                    return "kg/mm²";
                case UnitToolsAreaDensityUnit.OuncePerSquareFoot:
                    return "oz/ft²";
                case UnitToolsAreaDensityUnit.OuncePerSquareInch:
                    return "oz/in²";
                case UnitToolsAreaDensityUnit.PoundPerSquareYard:
                    return "lb/yd²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaDensityUnit.KilogramPerSquareMeter:
                    return "Kilogram Per Square Meter";
                case UnitToolsAreaDensityUnit.GramPerSquareMeter:
                    return "Gram Per Square Meter";
                case UnitToolsAreaDensityUnit.MilligramPerSquareMeter:
                    return "Milligram Per Square Meter";
                case UnitToolsAreaDensityUnit.PoundPerSquareFoot:
                    return "Pound Per Square Foot";
                case UnitToolsAreaDensityUnit.PoundPerSquareInch:
                    return "Pound Per Square Inch";
                case UnitToolsAreaDensityUnit.OuncePerSquareYard:
                    return "Ounce Per Square Yard";
                case UnitToolsAreaDensityUnit.MicrogramPerSquareMeter:
                    return "Microgram Per Square Meter";
                case UnitToolsAreaDensityUnit.GramPerSquareCentimeter:
                    return "Gram Per Square Centimeter";
                case UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter:
                    return "Kilogram Per Square Millimeter";
                case UnitToolsAreaDensityUnit.OuncePerSquareFoot:
                    return "Ounce Per Square Foot";
                case UnitToolsAreaDensityUnit.OuncePerSquareInch:
                    return "Ounce Per Square Inch";
                case UnitToolsAreaDensityUnit.PoundPerSquareYard:
                    return "Pound Per Square Yard";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.GramPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.PoundPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaDensityUnit.PoundPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaDensityUnit.OuncePerSquareYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaDensityUnit.OuncePerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaDensityUnit.OuncePerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaDensityUnit.PoundPerSquareYard:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAreaDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAreaDensityUnit.KilogramPerSquareMeter, UnitToolsAreaDensityUnit.GramPerSquareMeter, UnitToolsAreaDensityUnit.MilligramPerSquareMeter, UnitToolsAreaDensityUnit.MicrogramPerSquareMeter, UnitToolsAreaDensityUnit.GramPerSquareCentimeter, UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsAreaDensityUnit.PoundPerSquareFoot, UnitToolsAreaDensityUnit.PoundPerSquareInch, UnitToolsAreaDensityUnit.OuncePerSquareYard, UnitToolsAreaDensityUnit.OuncePerSquareFoot, UnitToolsAreaDensityUnit.OuncePerSquareInch, UnitToolsAreaDensityUnit.PoundPerSquareYard };
                default:
                    return new[] { UnitToolsAreaDensityUnit.KilogramPerSquareMeter, UnitToolsAreaDensityUnit.GramPerSquareMeter, UnitToolsAreaDensityUnit.MilligramPerSquareMeter, UnitToolsAreaDensityUnit.PoundPerSquareFoot, UnitToolsAreaDensityUnit.PoundPerSquareInch, UnitToolsAreaDensityUnit.OuncePerSquareYard, UnitToolsAreaDensityUnit.MicrogramPerSquareMeter, UnitToolsAreaDensityUnit.GramPerSquareCentimeter, UnitToolsAreaDensityUnit.KilogramPerSquareMillimeter, UnitToolsAreaDensityUnit.OuncePerSquareFoot, UnitToolsAreaDensityUnit.OuncePerSquareInch, UnitToolsAreaDensityUnit.PoundPerSquareYard };
            }
        }
    }
}
