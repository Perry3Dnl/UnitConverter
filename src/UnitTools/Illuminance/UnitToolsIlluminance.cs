namespace UnitTools.Illuminance
{
    using UnitTools.Illuminance.Metric;
    using UnitTools.Illuminance.Imperial;

    public enum UnitToolsIlluminanceUnit
    {
        Nox = 0,
        Lux = 1,
        Kilolux = 2,
        Phot = 3,
        FootCandle = 4,
        Microlux = 5,
        Millilux = 6,
        Megalux = 7,
        LumenPerSquareMeter = 8,
        LumenPerSquareFoot = 9,
        LumenPerSquareInch = 10,
    }

    public static class UnitToolsIlluminance
    {
        public static double Convert(double value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            double baseValue = ToLux(value, from);
            return FromLux(baseValue, to);
        }

        public static double ToLux(double value, UnitToolsIlluminanceUnit from)
        {
            switch (from)
            {
                case UnitToolsIlluminanceUnit.Nox:
                    return UnitToolsMetricIlluminance.NoxToLux(value);
                case UnitToolsIlluminanceUnit.Lux:
                    return UnitToolsMetricIlluminance.LuxToLux(value);
                case UnitToolsIlluminanceUnit.Kilolux:
                    return UnitToolsMetricIlluminance.KiloluxToLux(value);
                case UnitToolsIlluminanceUnit.Phot:
                    return UnitToolsMetricIlluminance.PhotToLux(value);
                case UnitToolsIlluminanceUnit.FootCandle:
                    return UnitToolsImperialIlluminance.FootCandleToLux(value);
                case UnitToolsIlluminanceUnit.Microlux:
                    return UnitToolsMetricIlluminance.MicroluxToLux(value);
                case UnitToolsIlluminanceUnit.Millilux:
                    return UnitToolsMetricIlluminance.MilliluxToLux(value);
                case UnitToolsIlluminanceUnit.Megalux:
                    return UnitToolsMetricIlluminance.MegaluxToLux(value);
                case UnitToolsIlluminanceUnit.LumenPerSquareMeter:
                    return UnitToolsMetricIlluminance.LumenPerSquareMeterToLux(value);
                case UnitToolsIlluminanceUnit.LumenPerSquareFoot:
                    return UnitToolsImperialIlluminance.LumenPerSquareFootToLux(value);
                case UnitToolsIlluminanceUnit.LumenPerSquareInch:
                    return UnitToolsImperialIlluminance.LumenPerSquareInchToLux(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported illuminance unit.");
            }
        }

        public static double FromLux(double baseValue, UnitToolsIlluminanceUnit to)
        {
            switch (to)
            {
                case UnitToolsIlluminanceUnit.Nox:
                    return UnitToolsMetricIlluminance.LuxToNox(baseValue);
                case UnitToolsIlluminanceUnit.Lux:
                    return UnitToolsMetricIlluminance.LuxToLux(baseValue);
                case UnitToolsIlluminanceUnit.Kilolux:
                    return UnitToolsMetricIlluminance.LuxToKilolux(baseValue);
                case UnitToolsIlluminanceUnit.Phot:
                    return UnitToolsMetricIlluminance.LuxToPhot(baseValue);
                case UnitToolsIlluminanceUnit.FootCandle:
                    return UnitToolsImperialIlluminance.LuxToFootCandle(baseValue);
                case UnitToolsIlluminanceUnit.Microlux:
                    return UnitToolsMetricIlluminance.LuxToMicrolux(baseValue);
                case UnitToolsIlluminanceUnit.Millilux:
                    return UnitToolsMetricIlluminance.LuxToMillilux(baseValue);
                case UnitToolsIlluminanceUnit.Megalux:
                    return UnitToolsMetricIlluminance.LuxToMegalux(baseValue);
                case UnitToolsIlluminanceUnit.LumenPerSquareMeter:
                    return UnitToolsMetricIlluminance.LuxToLumenPerSquareMeter(baseValue);
                case UnitToolsIlluminanceUnit.LumenPerSquareFoot:
                    return UnitToolsImperialIlluminance.LuxToLumenPerSquareFoot(baseValue);
                case UnitToolsIlluminanceUnit.LumenPerSquareInch:
                    return UnitToolsImperialIlluminance.LuxToLumenPerSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported illuminance unit.");
            }
        }

        public static string GetSymbol(UnitToolsIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIlluminanceUnit.Nox:
                    return "nx";
                case UnitToolsIlluminanceUnit.Lux:
                    return "lx";
                case UnitToolsIlluminanceUnit.Kilolux:
                    return "klx";
                case UnitToolsIlluminanceUnit.Phot:
                    return "ph";
                case UnitToolsIlluminanceUnit.FootCandle:
                    return "fc";
                case UnitToolsIlluminanceUnit.Microlux:
                    return "µlx";
                case UnitToolsIlluminanceUnit.Millilux:
                    return "mlx";
                case UnitToolsIlluminanceUnit.Megalux:
                    return "Mlx";
                case UnitToolsIlluminanceUnit.LumenPerSquareMeter:
                    return "lm/m²";
                case UnitToolsIlluminanceUnit.LumenPerSquareFoot:
                    return "lm/ft²";
                case UnitToolsIlluminanceUnit.LumenPerSquareInch:
                    return "lm/in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIlluminanceUnit.Nox:
                    return "nox";
                case UnitToolsIlluminanceUnit.Lux:
                    return "lux";
                case UnitToolsIlluminanceUnit.Kilolux:
                    return "kilolux";
                case UnitToolsIlluminanceUnit.Phot:
                    return "phot";
                case UnitToolsIlluminanceUnit.FootCandle:
                    return "foot-candle";
                case UnitToolsIlluminanceUnit.Microlux:
                    return "Microlux";
                case UnitToolsIlluminanceUnit.Millilux:
                    return "Millilux";
                case UnitToolsIlluminanceUnit.Megalux:
                    return "Megalux";
                case UnitToolsIlluminanceUnit.LumenPerSquareMeter:
                    return "Lumen Per Square Meter";
                case UnitToolsIlluminanceUnit.LumenPerSquareFoot:
                    return "Lumen Per Square Foot";
                case UnitToolsIlluminanceUnit.LumenPerSquareInch:
                    return "Lumen Per Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIlluminanceUnit.Nox:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.Lux:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.Kilolux:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.Phot:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.FootCandle:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsIlluminanceUnit.Microlux:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.Millilux:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.Megalux:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.LumenPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIlluminanceUnit.LumenPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsIlluminanceUnit.LumenPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsIlluminanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsIlluminanceUnit.Nox, UnitToolsIlluminanceUnit.Lux, UnitToolsIlluminanceUnit.Kilolux, UnitToolsIlluminanceUnit.Phot, UnitToolsIlluminanceUnit.Microlux, UnitToolsIlluminanceUnit.Millilux, UnitToolsIlluminanceUnit.Megalux, UnitToolsIlluminanceUnit.LumenPerSquareMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsIlluminanceUnit.FootCandle, UnitToolsIlluminanceUnit.LumenPerSquareFoot, UnitToolsIlluminanceUnit.LumenPerSquareInch };
                default:
                    return new[] { UnitToolsIlluminanceUnit.Nox, UnitToolsIlluminanceUnit.Lux, UnitToolsIlluminanceUnit.Kilolux, UnitToolsIlluminanceUnit.Phot, UnitToolsIlluminanceUnit.FootCandle, UnitToolsIlluminanceUnit.Microlux, UnitToolsIlluminanceUnit.Millilux, UnitToolsIlluminanceUnit.Megalux, UnitToolsIlluminanceUnit.LumenPerSquareMeter, UnitToolsIlluminanceUnit.LumenPerSquareFoot, UnitToolsIlluminanceUnit.LumenPerSquareInch };
            }
        }
    }
}
