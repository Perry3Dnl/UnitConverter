namespace UnitTools.LuminousExposure
{
    using UnitTools.LuminousExposure.Metric;
    using UnitTools.LuminousExposure.Imperial;

    public enum UnitToolsLuminousExposureUnit
    {
        LuxSecond = 0,
        LuxHour = 1,
        FootCandleSecond = 2,
        PhotSecond = 3,
        LuxMinute = 4,
        KiloluxSecond = 5,
        FootCandleMinute = 6,
        FootCandleHour = 7,
        LumenSecondPerSquareMeter = 8,
        MilliluxSecond = 9,
        MegaluxSecond = 10,
        LumenHourPerSquareMeter = 11,
    }

    public static class UnitToolsLuminousExposure
    {
        public static double Convert(double value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            double baseValue = ToLuxSecond(value, from);
            return FromLuxSecond(baseValue, to);
        }

        public static double ToLuxSecond(double value, UnitToolsLuminousExposureUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminousExposureUnit.LuxSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.LuxHour:
                    return UnitToolsMetricLuminousExposure.LuxHourToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.FootCandleSecond:
                    return UnitToolsImperialLuminousExposure.FootCandleSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.PhotSecond:
                    return UnitToolsMetricLuminousExposure.PhotSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.LuxMinute:
                    return UnitToolsMetricLuminousExposure.LuxMinuteToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.KiloluxSecond:
                    return UnitToolsMetricLuminousExposure.KiloluxSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.FootCandleMinute:
                    return UnitToolsImperialLuminousExposure.FootCandleMinuteToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.FootCandleHour:
                    return UnitToolsImperialLuminousExposure.FootCandleHourToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitToolsMetricLuminousExposure.LumenSecondPerSquareMeterToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.MilliluxSecond:
                    return UnitToolsMetricLuminousExposure.MilliluxSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.MegaluxSecond:
                    return UnitToolsMetricLuminousExposure.MegaluxSecondToLuxSecond(value);
                case UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitToolsMetricLuminousExposure.LumenHourPerSquareMeterToLuxSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous exposure unit.");
            }
        }

        public static double FromLuxSecond(double baseValue, UnitToolsLuminousExposureUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminousExposureUnit.LuxSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLuxSecond(baseValue);
                case UnitToolsLuminousExposureUnit.LuxHour:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLuxHour(baseValue);
                case UnitToolsLuminousExposureUnit.FootCandleSecond:
                    return UnitToolsImperialLuminousExposure.LuxSecondToFootCandleSecond(baseValue);
                case UnitToolsLuminousExposureUnit.PhotSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToPhotSecond(baseValue);
                case UnitToolsLuminousExposureUnit.LuxMinute:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLuxMinute(baseValue);
                case UnitToolsLuminousExposureUnit.KiloluxSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToKiloluxSecond(baseValue);
                case UnitToolsLuminousExposureUnit.FootCandleMinute:
                    return UnitToolsImperialLuminousExposure.LuxSecondToFootCandleMinute(baseValue);
                case UnitToolsLuminousExposureUnit.FootCandleHour:
                    return UnitToolsImperialLuminousExposure.LuxSecondToFootCandleHour(baseValue);
                case UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLumenSecondPerSquareMeter(baseValue);
                case UnitToolsLuminousExposureUnit.MilliluxSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToMilliluxSecond(baseValue);
                case UnitToolsLuminousExposureUnit.MegaluxSecond:
                    return UnitToolsMetricLuminousExposure.LuxSecondToMegaluxSecond(baseValue);
                case UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitToolsMetricLuminousExposure.LuxSecondToLumenHourPerSquareMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous exposure unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousExposureUnit.LuxSecond:
                    return "lx·s";
                case UnitToolsLuminousExposureUnit.LuxHour:
                    return "lx·h";
                case UnitToolsLuminousExposureUnit.FootCandleSecond:
                    return "fc·s";
                case UnitToolsLuminousExposureUnit.PhotSecond:
                    return "ph·s";
                case UnitToolsLuminousExposureUnit.LuxMinute:
                    return "lx·min";
                case UnitToolsLuminousExposureUnit.KiloluxSecond:
                    return "klx·s";
                case UnitToolsLuminousExposureUnit.FootCandleMinute:
                    return "fc·min";
                case UnitToolsLuminousExposureUnit.FootCandleHour:
                    return "fc·h";
                case UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return "lm·s/m²";
                case UnitToolsLuminousExposureUnit.MilliluxSecond:
                    return "mlx·s";
                case UnitToolsLuminousExposureUnit.MegaluxSecond:
                    return "Mlx·s";
                case UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter:
                    return "lm·h/m²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousExposureUnit.LuxSecond:
                    return "Lux Second";
                case UnitToolsLuminousExposureUnit.LuxHour:
                    return "Lux Hour";
                case UnitToolsLuminousExposureUnit.FootCandleSecond:
                    return "Foot Candle Second";
                case UnitToolsLuminousExposureUnit.PhotSecond:
                    return "Phot Second";
                case UnitToolsLuminousExposureUnit.LuxMinute:
                    return "Lux Minute";
                case UnitToolsLuminousExposureUnit.KiloluxSecond:
                    return "Kilolux Second";
                case UnitToolsLuminousExposureUnit.FootCandleMinute:
                    return "Foot Candle Minute";
                case UnitToolsLuminousExposureUnit.FootCandleHour:
                    return "Foot Candle Hour";
                case UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return "Lumen Second Per Square Meter";
                case UnitToolsLuminousExposureUnit.MilliluxSecond:
                    return "Millilux Second";
                case UnitToolsLuminousExposureUnit.MegaluxSecond:
                    return "Megalux Second";
                case UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter:
                    return "Lumen Hour Per Square Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminousExposureUnit.LuxSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.LuxHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.FootCandleSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminousExposureUnit.PhotSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.LuxMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.KiloluxSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.FootCandleMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminousExposureUnit.FootCandleHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.MilliluxSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.MegaluxSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminousExposureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminousExposureUnit.LuxSecond, UnitToolsLuminousExposureUnit.LuxHour, UnitToolsLuminousExposureUnit.PhotSecond, UnitToolsLuminousExposureUnit.LuxMinute, UnitToolsLuminousExposureUnit.KiloluxSecond, UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter, UnitToolsLuminousExposureUnit.MilliluxSecond, UnitToolsLuminousExposureUnit.MegaluxSecond, UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsLuminousExposureUnit.FootCandleSecond, UnitToolsLuminousExposureUnit.FootCandleMinute, UnitToolsLuminousExposureUnit.FootCandleHour };
                default:
                    return new[] { UnitToolsLuminousExposureUnit.LuxSecond, UnitToolsLuminousExposureUnit.LuxHour, UnitToolsLuminousExposureUnit.FootCandleSecond, UnitToolsLuminousExposureUnit.PhotSecond, UnitToolsLuminousExposureUnit.LuxMinute, UnitToolsLuminousExposureUnit.KiloluxSecond, UnitToolsLuminousExposureUnit.FootCandleMinute, UnitToolsLuminousExposureUnit.FootCandleHour, UnitToolsLuminousExposureUnit.LumenSecondPerSquareMeter, UnitToolsLuminousExposureUnit.MilliluxSecond, UnitToolsLuminousExposureUnit.MegaluxSecond, UnitToolsLuminousExposureUnit.LumenHourPerSquareMeter };
            }
        }
    }
}
