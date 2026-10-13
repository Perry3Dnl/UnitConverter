namespace UnitTools.CurrentDensity
{
    using UnitTools.CurrentDensity.Metric;
    using UnitTools.CurrentDensity.Imperial;

    public enum UnitToolsCurrentDensityUnit
    {
        AmperePerSquareMeter = 0,
        MilliamperePerSquareMeter = 1,
        AmperePerSquareCentimeter = 2,
        AmperePerSquareMillimeter = 3,
        AmperePerSquareInch = 4,
        KiloamperePerSquareMeter = 5,
        MegaamperePerSquareMeter = 6,
        MilliamperePerSquareCentimeter = 7,
        MicroamperePerSquareCentimeter = 8,
        AmperePerSquareFoot = 9,
        NanoamperePerSquareMeter = 10,
        KiloamperePerSquareCentimeter = 11,
        MegaamperePerSquareMillimeter = 12,
        MilliamperePerSquareInch = 13,
    }

    public static class UnitToolsCurrentDensity
    {
        public static double Convert(double value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            double baseValue = ToAmperePerSquareMeter(value, from);
            return FromAmperePerSquareMeter(baseValue, to);
        }

        public static double ToAmperePerSquareMeter(double value, UnitToolsCurrentDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.MilliamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMillimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.AmperePerSquareInch:
                    return UnitToolsImperialCurrentDensity.AmperePerSquareInchToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.KiloamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.MegaamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.MilliamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.MicroamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitToolsImperialCurrentDensity.AmperePerSquareFootToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.NanoamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.KiloamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitToolsMetricCurrentDensity.MegaamperePerSquareMillimeterToAmperePerSquareMeter(value);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitToolsImperialCurrentDensity.MilliamperePerSquareInchToAmperePerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported current density unit.");
            }
        }

        public static double FromAmperePerSquareMeter(double baseValue, UnitToolsCurrentDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMeter(baseValue);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareMeter(baseValue);
                case UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareCentimeter(baseValue);
                case UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMillimeter(baseValue);
                case UnitToolsCurrentDensityUnit.AmperePerSquareInch:
                    return UnitToolsImperialCurrentDensity.AmperePerSquareMeterToAmperePerSquareInch(baseValue);
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToKiloamperePerSquareMeter(baseValue);
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToMegaamperePerSquareMeter(baseValue);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareCentimeter(baseValue);
                case UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToMicroamperePerSquareCentimeter(baseValue);
                case UnitToolsCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitToolsImperialCurrentDensity.AmperePerSquareMeterToAmperePerSquareFoot(baseValue);
                case UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToNanoamperePerSquareMeter(baseValue);
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToKiloamperePerSquareCentimeter(baseValue);
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitToolsMetricCurrentDensity.AmperePerSquareMeterToMegaamperePerSquareMillimeter(baseValue);
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitToolsImperialCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported current density unit.");
            }
        }

        public static string GetSymbol(UnitToolsCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentDensityUnit.AmperePerSquareMeter:
                    return "A/m²";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter:
                    return "mA/m²";
                case UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter:
                    return "A/cm²";
                case UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter:
                    return "A/mm²";
                case UnitToolsCurrentDensityUnit.AmperePerSquareInch:
                    return "A/in²";
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter:
                    return "kA/m²";
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter:
                    return "MA/m²";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return "mA/cm²";
                case UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return "µA/cm²";
                case UnitToolsCurrentDensityUnit.AmperePerSquareFoot:
                    return "A/ft²";
                case UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter:
                    return "nA/m²";
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return "kA/cm²";
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return "MA/mm²";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareInch:
                    return "mA/in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentDensityUnit.AmperePerSquareMeter:
                    return "Ampere Per Square Meter";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter:
                    return "Milliampere Per Square Meter";
                case UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter:
                    return "Ampere Per Square Centimeter";
                case UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter:
                    return "Ampere Per Square Millimeter";
                case UnitToolsCurrentDensityUnit.AmperePerSquareInch:
                    return "Ampere Per Square Inch";
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter:
                    return "Kiloampere Per Square Meter";
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter:
                    return "Megaampere Per Square Meter";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return "Milliampere Per Square Centimeter";
                case UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return "Microampere Per Square Centimeter";
                case UnitToolsCurrentDensityUnit.AmperePerSquareFoot:
                    return "Ampere Per Square Foot";
                case UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter:
                    return "Nanoampere Per Square Meter";
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return "Kiloampere Per Square Centimeter";
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return "Megaampere Per Square Millimeter";
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareInch:
                    return "Milliampere Per Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.AmperePerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsCurrentDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsCurrentDensityUnit.AmperePerSquareMeter, UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter, UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter, UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter, UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter, UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter, UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter, UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsCurrentDensityUnit.AmperePerSquareInch, UnitToolsCurrentDensityUnit.AmperePerSquareFoot, UnitToolsCurrentDensityUnit.MilliamperePerSquareInch };
                default:
                    return new[] { UnitToolsCurrentDensityUnit.AmperePerSquareMeter, UnitToolsCurrentDensityUnit.MilliamperePerSquareMeter, UnitToolsCurrentDensityUnit.AmperePerSquareCentimeter, UnitToolsCurrentDensityUnit.AmperePerSquareMillimeter, UnitToolsCurrentDensityUnit.AmperePerSquareInch, UnitToolsCurrentDensityUnit.KiloamperePerSquareMeter, UnitToolsCurrentDensityUnit.MegaamperePerSquareMeter, UnitToolsCurrentDensityUnit.MilliamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.MicroamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.AmperePerSquareFoot, UnitToolsCurrentDensityUnit.NanoamperePerSquareMeter, UnitToolsCurrentDensityUnit.KiloamperePerSquareCentimeter, UnitToolsCurrentDensityUnit.MegaamperePerSquareMillimeter, UnitToolsCurrentDensityUnit.MilliamperePerSquareInch };
            }
        }
    }
}
