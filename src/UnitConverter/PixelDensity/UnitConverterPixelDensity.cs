namespace UnitConverter.PixelDensity
{
    using UnitConverter.PixelDensity.Common;
    using UnitConverter.PixelDensity.Imperial;
    using UnitConverter.PixelDensity.Metric;

    public enum UnitConverterPixelDensityUnit
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

    public static class UnitConverterPixelDensity
    {
        public static double Convert(double value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            double baseValue = ToPixelPerMeter(value, from);
            return FromPixelPerMeter(baseValue, to);
        }

        public static double ToPixelPerMeter(double value, UnitConverterPixelDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterPixelDensityUnit.PixelPerMeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerCentimeter:
                    return UnitConverterCommonPixelDensity.PixelPerCentimeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerMillimeter:
                    return UnitConverterCommonPixelDensity.PixelPerMillimeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerInch:
                    return UnitConverterCommonPixelDensity.PixelPerInchToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerFoot:
                    return UnitConverterImperialPixelDensity.PixelPerFootToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerYard:
                    return UnitConverterImperialPixelDensity.PixelPerYardToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerKilometer:
                    return UnitConverterMetricPixelDensity.PixelPerKilometerToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.DotPerInch:
                    return UnitConverterCommonPixelDensity.DotPerInchToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PointPerInch:
                    return UnitConverterCommonPixelDensity.PointPerInchToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerMile:
                    return UnitConverterImperialPixelDensity.PixelPerMileToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.DotPerCentimeter:
                    return UnitConverterCommonPixelDensity.DotPerCentimeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.DotPerMillimeter:
                    return UnitConverterCommonPixelDensity.DotPerMillimeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.DotPerMeter:
                    return UnitConverterCommonPixelDensity.DotPerMeterToPixelPerMeter(value);
                case UnitConverterPixelDensityUnit.PixelPerUnityUnit:
                    return UnitConverterCommonPixelDensity.PixelPerUnityUnitToPixelPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pixel density unit.");
            }
        }

        public static double FromPixelPerMeter(double baseValue, UnitConverterPixelDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterPixelDensityUnit.PixelPerMeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerMeter(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerCentimeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerCentimeter(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerMillimeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerMillimeter(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerInch:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerInch(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerFoot:
                    return UnitConverterImperialPixelDensity.PixelPerMeterToPixelPerFoot(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerYard:
                    return UnitConverterImperialPixelDensity.PixelPerMeterToPixelPerYard(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerKilometer:
                    return UnitConverterMetricPixelDensity.PixelPerMeterToPixelPerKilometer(baseValue);
                case UnitConverterPixelDensityUnit.DotPerInch:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToDotPerInch(baseValue);
                case UnitConverterPixelDensityUnit.PointPerInch:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPointPerInch(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerMile:
                    return UnitConverterImperialPixelDensity.PixelPerMeterToPixelPerMile(baseValue);
                case UnitConverterPixelDensityUnit.DotPerCentimeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToDotPerCentimeter(baseValue);
                case UnitConverterPixelDensityUnit.DotPerMillimeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToDotPerMillimeter(baseValue);
                case UnitConverterPixelDensityUnit.DotPerMeter:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToDotPerMeter(baseValue);
                case UnitConverterPixelDensityUnit.PixelPerUnityUnit:
                    return UnitConverterCommonPixelDensity.PixelPerMeterToPixelPerUnityUnit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pixel density unit.");
            }
        }

        public static string GetSymbol(UnitConverterPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPixelDensityUnit.PixelPerMeter:
                    return "px/m";
                case UnitConverterPixelDensityUnit.PixelPerCentimeter:
                    return "px/cm";
                case UnitConverterPixelDensityUnit.PixelPerMillimeter:
                    return "px/mm";
                case UnitConverterPixelDensityUnit.PixelPerInch:
                    return "ppi";
                case UnitConverterPixelDensityUnit.PixelPerFoot:
                    return "px/ft";
                case UnitConverterPixelDensityUnit.PixelPerYard:
                    return "px/yd";
                case UnitConverterPixelDensityUnit.PixelPerKilometer:
                    return "px/km";
                case UnitConverterPixelDensityUnit.DotPerInch:
                    return "dpi";
                case UnitConverterPixelDensityUnit.PointPerInch:
                    return "ppi point";
                case UnitConverterPixelDensityUnit.PixelPerMile:
                    return "px/mi";
                case UnitConverterPixelDensityUnit.DotPerCentimeter:
                    return "dpcm";
                case UnitConverterPixelDensityUnit.DotPerMillimeter:
                    return "dpmm";
                case UnitConverterPixelDensityUnit.DotPerMeter:
                    return "dpm";
                case UnitConverterPixelDensityUnit.PixelPerUnityUnit:
                    return "px/UU";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPixelDensityUnit.PixelPerMeter:
                    return "Pixel Per Meter";
                case UnitConverterPixelDensityUnit.PixelPerCentimeter:
                    return "Pixel Per Centimeter";
                case UnitConverterPixelDensityUnit.PixelPerMillimeter:
                    return "Pixel Per Millimeter";
                case UnitConverterPixelDensityUnit.PixelPerInch:
                    return "Pixel Per Inch";
                case UnitConverterPixelDensityUnit.PixelPerFoot:
                    return "Pixel Per Foot";
                case UnitConverterPixelDensityUnit.PixelPerYard:
                    return "Pixel Per Yard";
                case UnitConverterPixelDensityUnit.PixelPerKilometer:
                    return "Pixel Per Kilometer";
                case UnitConverterPixelDensityUnit.DotPerInch:
                    return "Dot Per Inch";
                case UnitConverterPixelDensityUnit.PointPerInch:
                    return "Point Per Inch";
                case UnitConverterPixelDensityUnit.PixelPerMile:
                    return "Pixel Per Mile";
                case UnitConverterPixelDensityUnit.DotPerCentimeter:
                    return "Dot Per Centimeter";
                case UnitConverterPixelDensityUnit.DotPerMillimeter:
                    return "Dot Per Millimeter";
                case UnitConverterPixelDensityUnit.DotPerMeter:
                    return "Dot Per Meter";
                case UnitConverterPixelDensityUnit.PixelPerUnityUnit:
                    return "Pixel Per Unity Unit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPixelDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPixelDensityUnit.PixelPerMeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerCentimeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerMillimeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerInch:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPixelDensityUnit.PixelPerYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPixelDensityUnit.PixelPerKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPixelDensityUnit.DotPerInch:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PointPerInch:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerMile:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPixelDensityUnit.DotPerCentimeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.DotPerMillimeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.DotPerMeter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterPixelDensityUnit.PixelPerUnityUnit:
                    return UnitConverterUnitSystem.Common;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPixelDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterPixelDensityUnit.PixelPerMeter, UnitConverterPixelDensityUnit.PixelPerCentimeter, UnitConverterPixelDensityUnit.PixelPerMillimeter, UnitConverterPixelDensityUnit.PixelPerInch, UnitConverterPixelDensityUnit.DotPerInch, UnitConverterPixelDensityUnit.PointPerInch, UnitConverterPixelDensityUnit.DotPerCentimeter, UnitConverterPixelDensityUnit.DotPerMillimeter, UnitConverterPixelDensityUnit.DotPerMeter, UnitConverterPixelDensityUnit.PixelPerUnityUnit };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPixelDensityUnit.PixelPerFoot, UnitConverterPixelDensityUnit.PixelPerYard, UnitConverterPixelDensityUnit.PixelPerMile };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPixelDensityUnit.PixelPerKilometer };
                default:
                    return new[] { UnitConverterPixelDensityUnit.PixelPerMeter, UnitConverterPixelDensityUnit.PixelPerCentimeter, UnitConverterPixelDensityUnit.PixelPerMillimeter, UnitConverterPixelDensityUnit.PixelPerInch, UnitConverterPixelDensityUnit.PixelPerFoot, UnitConverterPixelDensityUnit.PixelPerYard, UnitConverterPixelDensityUnit.PixelPerKilometer, UnitConverterPixelDensityUnit.DotPerInch, UnitConverterPixelDensityUnit.PointPerInch, UnitConverterPixelDensityUnit.PixelPerMile, UnitConverterPixelDensityUnit.DotPerCentimeter, UnitConverterPixelDensityUnit.DotPerMillimeter, UnitConverterPixelDensityUnit.DotPerMeter, UnitConverterPixelDensityUnit.PixelPerUnityUnit };
            }
        }
    }
}
