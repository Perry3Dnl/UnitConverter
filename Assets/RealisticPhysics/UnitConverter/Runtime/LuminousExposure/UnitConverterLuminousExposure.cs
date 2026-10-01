namespace RealisticPhysics.UnitConversion.LuminousExposure
{
    using RealisticPhysics.UnitConversion.LuminousExposure.Metric;
    using RealisticPhysics.UnitConversion.LuminousExposure.Imperial;

    public enum UnitConverterLuminousExposureUnit
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

    public static class UnitConverterLuminousExposure
    {
        public static double Convert(double value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            double baseValue = ToLuxSecond(value, from);
            return FromLuxSecond(baseValue, to);
        }

        public static double ToLuxSecond(double value, UnitConverterLuminousExposureUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminousExposureUnit.LuxSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.LuxHour:
                    return UnitConverterMetricLuminousExposure.LuxHourToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.FootCandleSecond:
                    return UnitConverterImperialLuminousExposure.FootCandleSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.PhotSecond:
                    return UnitConverterMetricLuminousExposure.PhotSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.LuxMinute:
                    return UnitConverterMetricLuminousExposure.LuxMinuteToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.KiloluxSecond:
                    return UnitConverterMetricLuminousExposure.KiloluxSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.FootCandleMinute:
                    return UnitConverterImperialLuminousExposure.FootCandleMinuteToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.FootCandleHour:
                    return UnitConverterImperialLuminousExposure.FootCandleHourToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitConverterMetricLuminousExposure.LumenSecondPerSquareMeterToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.MilliluxSecond:
                    return UnitConverterMetricLuminousExposure.MilliluxSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.MegaluxSecond:
                    return UnitConverterMetricLuminousExposure.MegaluxSecondToLuxSecond(value);
                case UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitConverterMetricLuminousExposure.LumenHourPerSquareMeterToLuxSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminous exposure unit.");
            }
        }

        public static double FromLuxSecond(double baseValue, UnitConverterLuminousExposureUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminousExposureUnit.LuxSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLuxSecond(baseValue);
                case UnitConverterLuminousExposureUnit.LuxHour:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLuxHour(baseValue);
                case UnitConverterLuminousExposureUnit.FootCandleSecond:
                    return UnitConverterImperialLuminousExposure.LuxSecondToFootCandleSecond(baseValue);
                case UnitConverterLuminousExposureUnit.PhotSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToPhotSecond(baseValue);
                case UnitConverterLuminousExposureUnit.LuxMinute:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLuxMinute(baseValue);
                case UnitConverterLuminousExposureUnit.KiloluxSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToKiloluxSecond(baseValue);
                case UnitConverterLuminousExposureUnit.FootCandleMinute:
                    return UnitConverterImperialLuminousExposure.LuxSecondToFootCandleMinute(baseValue);
                case UnitConverterLuminousExposureUnit.FootCandleHour:
                    return UnitConverterImperialLuminousExposure.LuxSecondToFootCandleHour(baseValue);
                case UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLumenSecondPerSquareMeter(baseValue);
                case UnitConverterLuminousExposureUnit.MilliluxSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToMilliluxSecond(baseValue);
                case UnitConverterLuminousExposureUnit.MegaluxSecond:
                    return UnitConverterMetricLuminousExposure.LuxSecondToMegaluxSecond(baseValue);
                case UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitConverterMetricLuminousExposure.LuxSecondToLumenHourPerSquareMeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminous exposure unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousExposureUnit.LuxSecond:
                    return "lx·s";
                case UnitConverterLuminousExposureUnit.LuxHour:
                    return "lx·h";
                case UnitConverterLuminousExposureUnit.FootCandleSecond:
                    return "fc·s";
                case UnitConverterLuminousExposureUnit.PhotSecond:
                    return "ph·s";
                case UnitConverterLuminousExposureUnit.LuxMinute:
                    return "lx·min";
                case UnitConverterLuminousExposureUnit.KiloluxSecond:
                    return "klx·s";
                case UnitConverterLuminousExposureUnit.FootCandleMinute:
                    return "fc·min";
                case UnitConverterLuminousExposureUnit.FootCandleHour:
                    return "fc·h";
                case UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return "lm·s/m²";
                case UnitConverterLuminousExposureUnit.MilliluxSecond:
                    return "mlx·s";
                case UnitConverterLuminousExposureUnit.MegaluxSecond:
                    return "Mlx·s";
                case UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter:
                    return "lm·h/m²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousExposureUnit.LuxSecond:
                    return "Lux Second";
                case UnitConverterLuminousExposureUnit.LuxHour:
                    return "Lux Hour";
                case UnitConverterLuminousExposureUnit.FootCandleSecond:
                    return "Foot Candle Second";
                case UnitConverterLuminousExposureUnit.PhotSecond:
                    return "Phot Second";
                case UnitConverterLuminousExposureUnit.LuxMinute:
                    return "Lux Minute";
                case UnitConverterLuminousExposureUnit.KiloluxSecond:
                    return "Kilolux Second";
                case UnitConverterLuminousExposureUnit.FootCandleMinute:
                    return "Foot Candle Minute";
                case UnitConverterLuminousExposureUnit.FootCandleHour:
                    return "Foot Candle Hour";
                case UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return "Lumen Second Per Square Meter";
                case UnitConverterLuminousExposureUnit.MilliluxSecond:
                    return "Millilux Second";
                case UnitConverterLuminousExposureUnit.MegaluxSecond:
                    return "Megalux Second";
                case UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter:
                    return "Lumen Hour Per Square Meter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminousExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminousExposureUnit.LuxSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.LuxHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.FootCandleSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminousExposureUnit.PhotSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.LuxMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.KiloluxSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.FootCandleMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminousExposureUnit.FootCandleHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.MilliluxSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.MegaluxSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminousExposureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminousExposureUnit.LuxSecond, UnitConverterLuminousExposureUnit.LuxHour, UnitConverterLuminousExposureUnit.PhotSecond, UnitConverterLuminousExposureUnit.LuxMinute, UnitConverterLuminousExposureUnit.KiloluxSecond, UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter, UnitConverterLuminousExposureUnit.MilliluxSecond, UnitConverterLuminousExposureUnit.MegaluxSecond, UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterLuminousExposureUnit.FootCandleSecond, UnitConverterLuminousExposureUnit.FootCandleMinute, UnitConverterLuminousExposureUnit.FootCandleHour };
                default:
                    return new[] { UnitConverterLuminousExposureUnit.LuxSecond, UnitConverterLuminousExposureUnit.LuxHour, UnitConverterLuminousExposureUnit.FootCandleSecond, UnitConverterLuminousExposureUnit.PhotSecond, UnitConverterLuminousExposureUnit.LuxMinute, UnitConverterLuminousExposureUnit.KiloluxSecond, UnitConverterLuminousExposureUnit.FootCandleMinute, UnitConverterLuminousExposureUnit.FootCandleHour, UnitConverterLuminousExposureUnit.LumenSecondPerSquareMeter, UnitConverterLuminousExposureUnit.MilliluxSecond, UnitConverterLuminousExposureUnit.MegaluxSecond, UnitConverterLuminousExposureUnit.LumenHourPerSquareMeter };
            }
        }
    }
}
