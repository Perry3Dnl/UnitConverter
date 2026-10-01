namespace RealisticPhysics.UnitConversion.Illuminance
{
    using RealisticPhysics.UnitConversion.Illuminance.Metric;
    using RealisticPhysics.UnitConversion.Illuminance.Imperial;

    public enum UnitConverterIlluminanceUnit
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

    public static class UnitConverterIlluminance
    {
        public static double Convert(double value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            double baseValue = ToLux(value, from);
            return FromLux(baseValue, to);
        }

        public static double ToLux(double value, UnitConverterIlluminanceUnit from)
        {
            switch (from)
            {
                case UnitConverterIlluminanceUnit.Nox:
                    return UnitConverterMetricIlluminance.NoxToLux(value);
                case UnitConverterIlluminanceUnit.Lux:
                    return UnitConverterMetricIlluminance.LuxToLux(value);
                case UnitConverterIlluminanceUnit.Kilolux:
                    return UnitConverterMetricIlluminance.KiloluxToLux(value);
                case UnitConverterIlluminanceUnit.Phot:
                    return UnitConverterMetricIlluminance.PhotToLux(value);
                case UnitConverterIlluminanceUnit.FootCandle:
                    return UnitConverterImperialIlluminance.FootCandleToLux(value);
                case UnitConverterIlluminanceUnit.Microlux:
                    return UnitConverterMetricIlluminance.MicroluxToLux(value);
                case UnitConverterIlluminanceUnit.Millilux:
                    return UnitConverterMetricIlluminance.MilliluxToLux(value);
                case UnitConverterIlluminanceUnit.Megalux:
                    return UnitConverterMetricIlluminance.MegaluxToLux(value);
                case UnitConverterIlluminanceUnit.LumenPerSquareMeter:
                    return UnitConverterMetricIlluminance.LumenPerSquareMeterToLux(value);
                case UnitConverterIlluminanceUnit.LumenPerSquareFoot:
                    return UnitConverterImperialIlluminance.LumenPerSquareFootToLux(value);
                case UnitConverterIlluminanceUnit.LumenPerSquareInch:
                    return UnitConverterImperialIlluminance.LumenPerSquareInchToLux(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported illuminance unit.");
            }
        }

        public static double FromLux(double baseValue, UnitConverterIlluminanceUnit to)
        {
            switch (to)
            {
                case UnitConverterIlluminanceUnit.Nox:
                    return UnitConverterMetricIlluminance.LuxToNox(baseValue);
                case UnitConverterIlluminanceUnit.Lux:
                    return UnitConverterMetricIlluminance.LuxToLux(baseValue);
                case UnitConverterIlluminanceUnit.Kilolux:
                    return UnitConverterMetricIlluminance.LuxToKilolux(baseValue);
                case UnitConverterIlluminanceUnit.Phot:
                    return UnitConverterMetricIlluminance.LuxToPhot(baseValue);
                case UnitConverterIlluminanceUnit.FootCandle:
                    return UnitConverterImperialIlluminance.LuxToFootCandle(baseValue);
                case UnitConverterIlluminanceUnit.Microlux:
                    return UnitConverterMetricIlluminance.LuxToMicrolux(baseValue);
                case UnitConverterIlluminanceUnit.Millilux:
                    return UnitConverterMetricIlluminance.LuxToMillilux(baseValue);
                case UnitConverterIlluminanceUnit.Megalux:
                    return UnitConverterMetricIlluminance.LuxToMegalux(baseValue);
                case UnitConverterIlluminanceUnit.LumenPerSquareMeter:
                    return UnitConverterMetricIlluminance.LuxToLumenPerSquareMeter(baseValue);
                case UnitConverterIlluminanceUnit.LumenPerSquareFoot:
                    return UnitConverterImperialIlluminance.LuxToLumenPerSquareFoot(baseValue);
                case UnitConverterIlluminanceUnit.LumenPerSquareInch:
                    return UnitConverterImperialIlluminance.LuxToLumenPerSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported illuminance unit.");
            }
        }

        public static string GetSymbol(UnitConverterIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIlluminanceUnit.Nox:
                    return "nx";
                case UnitConverterIlluminanceUnit.Lux:
                    return "lx";
                case UnitConverterIlluminanceUnit.Kilolux:
                    return "klx";
                case UnitConverterIlluminanceUnit.Phot:
                    return "ph";
                case UnitConverterIlluminanceUnit.FootCandle:
                    return "fc";
                case UnitConverterIlluminanceUnit.Microlux:
                    return "µlx";
                case UnitConverterIlluminanceUnit.Millilux:
                    return "mlx";
                case UnitConverterIlluminanceUnit.Megalux:
                    return "Mlx";
                case UnitConverterIlluminanceUnit.LumenPerSquareMeter:
                    return "lm/m²";
                case UnitConverterIlluminanceUnit.LumenPerSquareFoot:
                    return "lm/ft²";
                case UnitConverterIlluminanceUnit.LumenPerSquareInch:
                    return "lm/in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIlluminanceUnit.Nox:
                    return "nox";
                case UnitConverterIlluminanceUnit.Lux:
                    return "lux";
                case UnitConverterIlluminanceUnit.Kilolux:
                    return "kilolux";
                case UnitConverterIlluminanceUnit.Phot:
                    return "phot";
                case UnitConverterIlluminanceUnit.FootCandle:
                    return "foot-candle";
                case UnitConverterIlluminanceUnit.Microlux:
                    return "Microlux";
                case UnitConverterIlluminanceUnit.Millilux:
                    return "Millilux";
                case UnitConverterIlluminanceUnit.Megalux:
                    return "Megalux";
                case UnitConverterIlluminanceUnit.LumenPerSquareMeter:
                    return "Lumen Per Square Meter";
                case UnitConverterIlluminanceUnit.LumenPerSquareFoot:
                    return "Lumen Per Square Foot";
                case UnitConverterIlluminanceUnit.LumenPerSquareInch:
                    return "Lumen Per Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterIlluminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIlluminanceUnit.Nox:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.Lux:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.Kilolux:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.Phot:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.FootCandle:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterIlluminanceUnit.Microlux:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.Millilux:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.Megalux:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.LumenPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIlluminanceUnit.LumenPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterIlluminanceUnit.LumenPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterIlluminanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterIlluminanceUnit.Nox, UnitConverterIlluminanceUnit.Lux, UnitConverterIlluminanceUnit.Kilolux, UnitConverterIlluminanceUnit.Phot, UnitConverterIlluminanceUnit.Microlux, UnitConverterIlluminanceUnit.Millilux, UnitConverterIlluminanceUnit.Megalux, UnitConverterIlluminanceUnit.LumenPerSquareMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterIlluminanceUnit.FootCandle, UnitConverterIlluminanceUnit.LumenPerSquareFoot, UnitConverterIlluminanceUnit.LumenPerSquareInch };
                default:
                    return new[] { UnitConverterIlluminanceUnit.Nox, UnitConverterIlluminanceUnit.Lux, UnitConverterIlluminanceUnit.Kilolux, UnitConverterIlluminanceUnit.Phot, UnitConverterIlluminanceUnit.FootCandle, UnitConverterIlluminanceUnit.Microlux, UnitConverterIlluminanceUnit.Millilux, UnitConverterIlluminanceUnit.Megalux, UnitConverterIlluminanceUnit.LumenPerSquareMeter, UnitConverterIlluminanceUnit.LumenPerSquareFoot, UnitConverterIlluminanceUnit.LumenPerSquareInch };
            }
        }
    }
}
