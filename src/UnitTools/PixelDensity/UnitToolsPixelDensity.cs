namespace UnitTools.PixelDensity
{
    using UnitTools.PixelDensity.Common;
    using UnitTools.PixelDensity.Imperial;
    using UnitTools.PixelDensity.Metric;

    public enum UnitToolsPixelDensityUnit
    {
        PixelPerMeter = 0,
        PixelPerCentimeter = 1,
        PixelPerMillimeter = 2,
        PixelPerInch = 3,
        PixelPerFoot = 4,
        PixelPerYard = 5,
        PixelPerKilometer = 6,
        DotPerInch = 7,
        PointPerInch = 8,
        PixelPerMile = 9,
        DotPerCentimeter = 10,
        DotPerMillimeter = 11,
        DotPerMeter = 12,
        PixelPerUnityUnit = 13,
    }

    public static class UnitToolsPixelDensity
    {
        public static double Convert(double value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            double baseValue = ToPixelPerMeter(value, from);
            return FromPixelPerMeter(baseValue, to);
        }

        public static double ToPixelPerMeter(double value, UnitToolsPixelDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsPixelDensityUnit.PixelPerMeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerCentimeter:
                    return UnitToolsCommonPixelDensity.PixelPerCentimeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerMillimeter:
                    return UnitToolsCommonPixelDensity.PixelPerMillimeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerInch:
                    return UnitToolsCommonPixelDensity.PixelPerInchToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerFoot:
                    return UnitToolsImperialPixelDensity.PixelPerFootToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerYard:
                    return UnitToolsImperialPixelDensity.PixelPerYardToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerKilometer:
                    return UnitToolsMetricPixelDensity.PixelPerKilometerToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.DotPerInch:
                    return UnitToolsCommonPixelDensity.DotPerInchToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PointPerInch:
                    return UnitToolsCommonPixelDensity.PointPerInchToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerMile:
                    return UnitToolsImperialPixelDensity.PixelPerMileToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.DotPerCentimeter:
                    return UnitToolsCommonPixelDensity.DotPerCentimeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.DotPerMillimeter:
                    return UnitToolsCommonPixelDensity.DotPerMillimeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.DotPerMeter:
                    return UnitToolsCommonPixelDensity.DotPerMeterToPixelPerMeter(value);
                case UnitToolsPixelDensityUnit.PixelPerUnityUnit:
                    return UnitToolsCommonPixelDensity.PixelPerUnityUnitToPixelPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pixel density unit.");
            }
        }

        public static double FromPixelPerMeter(double baseValue, UnitToolsPixelDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsPixelDensityUnit.PixelPerMeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerMeter(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerCentimeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerCentimeter(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerMillimeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerMillimeter(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerInch:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerInch(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerFoot:
                    return UnitToolsImperialPixelDensity.PixelPerMeterToPixelPerFoot(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerYard:
                    return UnitToolsImperialPixelDensity.PixelPerMeterToPixelPerYard(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerKilometer:
                    return UnitToolsMetricPixelDensity.PixelPerMeterToPixelPerKilometer(baseValue);
                case UnitToolsPixelDensityUnit.DotPerInch:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToDotPerInch(baseValue);
                case UnitToolsPixelDensityUnit.PointPerInch:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPointPerInch(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerMile:
                    return UnitToolsImperialPixelDensity.PixelPerMeterToPixelPerMile(baseValue);
                case UnitToolsPixelDensityUnit.DotPerCentimeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToDotPerCentimeter(baseValue);
                case UnitToolsPixelDensityUnit.DotPerMillimeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToDotPerMillimeter(baseValue);
                case UnitToolsPixelDensityUnit.DotPerMeter:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToDotPerMeter(baseValue);
                case UnitToolsPixelDensityUnit.PixelPerUnityUnit:
                    return UnitToolsCommonPixelDensity.PixelPerMeterToPixelPerUnityUnit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pixel density unit.");
            }
        }

        public static string GetSymbol(UnitToolsPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPixelDensityUnit.PixelPerMeter:
                    return "px/m";
                case UnitToolsPixelDensityUnit.PixelPerCentimeter:
                    return "px/cm";
                case UnitToolsPixelDensityUnit.PixelPerMillimeter:
                    return "px/mm";
                case UnitToolsPixelDensityUnit.PixelPerInch:
                    return "ppi";
                case UnitToolsPixelDensityUnit.PixelPerFoot:
                    return "px/ft";
                case UnitToolsPixelDensityUnit.PixelPerYard:
                    return "px/yd";
                case UnitToolsPixelDensityUnit.PixelPerKilometer:
                    return "px/km";
                case UnitToolsPixelDensityUnit.DotPerInch:
                    return "dpi";
                case UnitToolsPixelDensityUnit.PointPerInch:
                    return "ppi point";
                case UnitToolsPixelDensityUnit.PixelPerMile:
                    return "px/mi";
                case UnitToolsPixelDensityUnit.DotPerCentimeter:
                    return "dpcm";
                case UnitToolsPixelDensityUnit.DotPerMillimeter:
                    return "dpmm";
                case UnitToolsPixelDensityUnit.DotPerMeter:
                    return "dpm";
                case UnitToolsPixelDensityUnit.PixelPerUnityUnit:
                    return "px/UU";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPixelDensityUnit.PixelPerMeter:
                    return "Pixel Per Meter";
                case UnitToolsPixelDensityUnit.PixelPerCentimeter:
                    return "Pixel Per Centimeter";
                case UnitToolsPixelDensityUnit.PixelPerMillimeter:
                    return "Pixel Per Millimeter";
                case UnitToolsPixelDensityUnit.PixelPerInch:
                    return "Pixel Per Inch";
                case UnitToolsPixelDensityUnit.PixelPerFoot:
                    return "Pixel Per Foot";
                case UnitToolsPixelDensityUnit.PixelPerYard:
                    return "Pixel Per Yard";
                case UnitToolsPixelDensityUnit.PixelPerKilometer:
                    return "Pixel Per Kilometer";
                case UnitToolsPixelDensityUnit.DotPerInch:
                    return "Dot Per Inch";
                case UnitToolsPixelDensityUnit.PointPerInch:
                    return "Point Per Inch";
                case UnitToolsPixelDensityUnit.PixelPerMile:
                    return "Pixel Per Mile";
                case UnitToolsPixelDensityUnit.DotPerCentimeter:
                    return "Dot Per Centimeter";
                case UnitToolsPixelDensityUnit.DotPerMillimeter:
                    return "Dot Per Millimeter";
                case UnitToolsPixelDensityUnit.DotPerMeter:
                    return "Dot Per Meter";
                case UnitToolsPixelDensityUnit.PixelPerUnityUnit:
                    return "Pixel Per Unity Unit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPixelDensityUnit.PixelPerMeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerCentimeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerMillimeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerInch:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPixelDensityUnit.PixelPerYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPixelDensityUnit.PixelPerKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPixelDensityUnit.DotPerInch:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PointPerInch:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerMile:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPixelDensityUnit.DotPerCentimeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.DotPerMillimeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.DotPerMeter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsPixelDensityUnit.PixelPerUnityUnit:
                    return UnitToolsUnitSystem.Common;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPixelDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsPixelDensityUnit.PixelPerMeter, UnitToolsPixelDensityUnit.PixelPerCentimeter, UnitToolsPixelDensityUnit.PixelPerMillimeter, UnitToolsPixelDensityUnit.PixelPerInch, UnitToolsPixelDensityUnit.DotPerInch, UnitToolsPixelDensityUnit.PointPerInch, UnitToolsPixelDensityUnit.DotPerCentimeter, UnitToolsPixelDensityUnit.DotPerMillimeter, UnitToolsPixelDensityUnit.DotPerMeter, UnitToolsPixelDensityUnit.PixelPerUnityUnit };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPixelDensityUnit.PixelPerFoot, UnitToolsPixelDensityUnit.PixelPerYard, UnitToolsPixelDensityUnit.PixelPerMile };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPixelDensityUnit.PixelPerKilometer };
                default:
                    return new[] { UnitToolsPixelDensityUnit.PixelPerMeter, UnitToolsPixelDensityUnit.PixelPerCentimeter, UnitToolsPixelDensityUnit.PixelPerMillimeter, UnitToolsPixelDensityUnit.PixelPerInch, UnitToolsPixelDensityUnit.PixelPerFoot, UnitToolsPixelDensityUnit.PixelPerYard, UnitToolsPixelDensityUnit.PixelPerKilometer, UnitToolsPixelDensityUnit.DotPerInch, UnitToolsPixelDensityUnit.PointPerInch, UnitToolsPixelDensityUnit.PixelPerMile, UnitToolsPixelDensityUnit.DotPerCentimeter, UnitToolsPixelDensityUnit.DotPerMillimeter, UnitToolsPixelDensityUnit.DotPerMeter, UnitToolsPixelDensityUnit.PixelPerUnityUnit };
            }
        }
    }
}
