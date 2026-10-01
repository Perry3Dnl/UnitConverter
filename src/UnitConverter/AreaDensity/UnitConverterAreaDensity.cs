namespace UnitConverter.AreaDensity
{
    using UnitConverter.AreaDensity.Metric;
    using UnitConverter.AreaDensity.Imperial;

    public enum UnitConverterAreaDensityUnit
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

    public static class UnitConverterAreaDensity
    {
        public static double Convert(double value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            double baseValue = ToKilogramPerSquareMeter(value, from);
            return FromKilogramPerSquareMeter(baseValue, to);
        }

        public static double ToKilogramPerSquareMeter(double value, UnitConverterAreaDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.GramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.GramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.MilligramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.PoundPerSquareFoot:
                    return UnitConverterImperialAreaDensity.PoundPerSquareFootToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.PoundPerSquareInch:
                    return UnitConverterImperialAreaDensity.PoundPerSquareInchToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.OuncePerSquareYard:
                    return UnitConverterImperialAreaDensity.OuncePerSquareYardToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.MicrogramPerSquareMeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitConverterMetricAreaDensity.GramPerSquareCentimeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMillimeterToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.OuncePerSquareFoot:
                    return UnitConverterImperialAreaDensity.OuncePerSquareFootToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.OuncePerSquareInch:
                    return UnitConverterImperialAreaDensity.OuncePerSquareInchToKilogramPerSquareMeter(value);
                case UnitConverterAreaDensityUnit.PoundPerSquareYard:
                    return UnitConverterImperialAreaDensity.PoundPerSquareYardToKilogramPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported area density unit.");
            }
        }

        public static double FromKilogramPerSquareMeter(double baseValue, UnitConverterAreaDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMeter(baseValue);
                case UnitConverterAreaDensityUnit.GramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToGramPerSquareMeter(baseValue);
                case UnitConverterAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToMilligramPerSquareMeter(baseValue);
                case UnitConverterAreaDensityUnit.PoundPerSquareFoot:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareFoot(baseValue);
                case UnitConverterAreaDensityUnit.PoundPerSquareInch:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareInch(baseValue);
                case UnitConverterAreaDensityUnit.OuncePerSquareYard:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareYard(baseValue);
                case UnitConverterAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToMicrogramPerSquareMeter(baseValue);
                case UnitConverterAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToGramPerSquareCentimeter(baseValue);
                case UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitConverterMetricAreaDensity.KilogramPerSquareMeterToKilogramPerSquareMillimeter(baseValue);
                case UnitConverterAreaDensityUnit.OuncePerSquareFoot:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareFoot(baseValue);
                case UnitConverterAreaDensityUnit.OuncePerSquareInch:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToOuncePerSquareInch(baseValue);
                case UnitConverterAreaDensityUnit.PoundPerSquareYard:
                    return UnitConverterImperialAreaDensity.KilogramPerSquareMeterToPoundPerSquareYard(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported area density unit.");
            }
        }

        public static string GetSymbol(UnitConverterAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaDensityUnit.KilogramPerSquareMeter:
                    return "kg/m²";
                case UnitConverterAreaDensityUnit.GramPerSquareMeter:
                    return "g/m²";
                case UnitConverterAreaDensityUnit.MilligramPerSquareMeter:
                    return "mg/m²";
                case UnitConverterAreaDensityUnit.PoundPerSquareFoot:
                    return "lb/ft²";
                case UnitConverterAreaDensityUnit.PoundPerSquareInch:
                    return "lb/in²";
                case UnitConverterAreaDensityUnit.OuncePerSquareYard:
                    return "oz/yd²";
                case UnitConverterAreaDensityUnit.MicrogramPerSquareMeter:
                    return "µg/m²";
                case UnitConverterAreaDensityUnit.GramPerSquareCentimeter:
                    return "g/cm²";
                case UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter:
                    return "kg/mm²";
                case UnitConverterAreaDensityUnit.OuncePerSquareFoot:
                    return "oz/ft²";
                case UnitConverterAreaDensityUnit.OuncePerSquareInch:
                    return "oz/in²";
                case UnitConverterAreaDensityUnit.PoundPerSquareYard:
                    return "lb/yd²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaDensityUnit.KilogramPerSquareMeter:
                    return "Kilogram Per Square Meter";
                case UnitConverterAreaDensityUnit.GramPerSquareMeter:
                    return "Gram Per Square Meter";
                case UnitConverterAreaDensityUnit.MilligramPerSquareMeter:
                    return "Milligram Per Square Meter";
                case UnitConverterAreaDensityUnit.PoundPerSquareFoot:
                    return "Pound Per Square Foot";
                case UnitConverterAreaDensityUnit.PoundPerSquareInch:
                    return "Pound Per Square Inch";
                case UnitConverterAreaDensityUnit.OuncePerSquareYard:
                    return "Ounce Per Square Yard";
                case UnitConverterAreaDensityUnit.MicrogramPerSquareMeter:
                    return "Microgram Per Square Meter";
                case UnitConverterAreaDensityUnit.GramPerSquareCentimeter:
                    return "Gram Per Square Centimeter";
                case UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter:
                    return "Kilogram Per Square Millimeter";
                case UnitConverterAreaDensityUnit.OuncePerSquareFoot:
                    return "Ounce Per Square Foot";
                case UnitConverterAreaDensityUnit.OuncePerSquareInch:
                    return "Ounce Per Square Inch";
                case UnitConverterAreaDensityUnit.PoundPerSquareYard:
                    return "Pound Per Square Yard";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAreaDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaDensityUnit.KilogramPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.GramPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.MilligramPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.PoundPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaDensityUnit.PoundPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaDensityUnit.OuncePerSquareYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaDensityUnit.MicrogramPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.GramPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaDensityUnit.OuncePerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaDensityUnit.OuncePerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaDensityUnit.PoundPerSquareYard:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAreaDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAreaDensityUnit.KilogramPerSquareMeter, UnitConverterAreaDensityUnit.GramPerSquareMeter, UnitConverterAreaDensityUnit.MilligramPerSquareMeter, UnitConverterAreaDensityUnit.MicrogramPerSquareMeter, UnitConverterAreaDensityUnit.GramPerSquareCentimeter, UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterAreaDensityUnit.PoundPerSquareFoot, UnitConverterAreaDensityUnit.PoundPerSquareInch, UnitConverterAreaDensityUnit.OuncePerSquareYard, UnitConverterAreaDensityUnit.OuncePerSquareFoot, UnitConverterAreaDensityUnit.OuncePerSquareInch, UnitConverterAreaDensityUnit.PoundPerSquareYard };
                default:
                    return new[] { UnitConverterAreaDensityUnit.KilogramPerSquareMeter, UnitConverterAreaDensityUnit.GramPerSquareMeter, UnitConverterAreaDensityUnit.MilligramPerSquareMeter, UnitConverterAreaDensityUnit.PoundPerSquareFoot, UnitConverterAreaDensityUnit.PoundPerSquareInch, UnitConverterAreaDensityUnit.OuncePerSquareYard, UnitConverterAreaDensityUnit.MicrogramPerSquareMeter, UnitConverterAreaDensityUnit.GramPerSquareCentimeter, UnitConverterAreaDensityUnit.KilogramPerSquareMillimeter, UnitConverterAreaDensityUnit.OuncePerSquareFoot, UnitConverterAreaDensityUnit.OuncePerSquareInch, UnitConverterAreaDensityUnit.PoundPerSquareYard };
            }
        }
    }
}
