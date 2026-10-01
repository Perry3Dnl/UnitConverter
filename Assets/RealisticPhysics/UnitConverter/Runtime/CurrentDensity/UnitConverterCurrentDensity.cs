namespace RealisticPhysics.UnitConversion.CurrentDensity
{
    using RealisticPhysics.UnitConversion.CurrentDensity.Metric;
    using RealisticPhysics.UnitConversion.CurrentDensity.Imperial;

    public enum UnitConverterCurrentDensityUnit
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

    public static class UnitConverterCurrentDensity
    {
        public static double Convert(double value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            double baseValue = ToAmperePerSquareMeter(value, from);
            return FromAmperePerSquareMeter(baseValue, to);
        }

        public static double ToAmperePerSquareMeter(double value, UnitConverterCurrentDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.MilliamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMillimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.AmperePerSquareInch:
                    return UnitConverterImperialCurrentDensity.AmperePerSquareInchToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.KiloamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.MegaamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.MilliamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.MicroamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitConverterImperialCurrentDensity.AmperePerSquareFootToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.NanoamperePerSquareMeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.KiloamperePerSquareCentimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitConverterMetricCurrentDensity.MegaamperePerSquareMillimeterToAmperePerSquareMeter(value);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitConverterImperialCurrentDensity.MilliamperePerSquareInchToAmperePerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported current density unit.");
            }
        }

        public static double FromAmperePerSquareMeter(double baseValue, UnitConverterCurrentDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMeter(baseValue);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareMeter(baseValue);
                case UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareCentimeter(baseValue);
                case UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToAmperePerSquareMillimeter(baseValue);
                case UnitConverterCurrentDensityUnit.AmperePerSquareInch:
                    return UnitConverterImperialCurrentDensity.AmperePerSquareMeterToAmperePerSquareInch(baseValue);
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToKiloamperePerSquareMeter(baseValue);
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToMegaamperePerSquareMeter(baseValue);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareCentimeter(baseValue);
                case UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToMicroamperePerSquareCentimeter(baseValue);
                case UnitConverterCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitConverterImperialCurrentDensity.AmperePerSquareMeterToAmperePerSquareFoot(baseValue);
                case UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToNanoamperePerSquareMeter(baseValue);
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToKiloamperePerSquareCentimeter(baseValue);
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitConverterMetricCurrentDensity.AmperePerSquareMeterToMegaamperePerSquareMillimeter(baseValue);
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitConverterImperialCurrentDensity.AmperePerSquareMeterToMilliamperePerSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported current density unit.");
            }
        }

        public static string GetSymbol(UnitConverterCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentDensityUnit.AmperePerSquareMeter:
                    return "A/m²";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter:
                    return "mA/m²";
                case UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter:
                    return "A/cm²";
                case UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter:
                    return "A/mm²";
                case UnitConverterCurrentDensityUnit.AmperePerSquareInch:
                    return "A/in²";
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter:
                    return "kA/m²";
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter:
                    return "MA/m²";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return "mA/cm²";
                case UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return "µA/cm²";
                case UnitConverterCurrentDensityUnit.AmperePerSquareFoot:
                    return "A/ft²";
                case UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter:
                    return "nA/m²";
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return "kA/cm²";
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return "MA/mm²";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareInch:
                    return "mA/in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentDensityUnit.AmperePerSquareMeter:
                    return "Ampere Per Square Meter";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter:
                    return "Milliampere Per Square Meter";
                case UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter:
                    return "Ampere Per Square Centimeter";
                case UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter:
                    return "Ampere Per Square Millimeter";
                case UnitConverterCurrentDensityUnit.AmperePerSquareInch:
                    return "Ampere Per Square Inch";
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter:
                    return "Kiloampere Per Square Meter";
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter:
                    return "Megaampere Per Square Meter";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return "Milliampere Per Square Centimeter";
                case UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return "Microampere Per Square Centimeter";
                case UnitConverterCurrentDensityUnit.AmperePerSquareFoot:
                    return "Ampere Per Square Foot";
                case UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter:
                    return "Nanoampere Per Square Meter";
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return "Kiloampere Per Square Centimeter";
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return "Megaampere Per Square Millimeter";
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareInch:
                    return "Milliampere Per Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterCurrentDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterCurrentDensityUnit.AmperePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.AmperePerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.AmperePerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterCurrentDensityUnit.MilliamperePerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterCurrentDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterCurrentDensityUnit.AmperePerSquareMeter, UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter, UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter, UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter, UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter, UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter, UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter, UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterCurrentDensityUnit.AmperePerSquareInch, UnitConverterCurrentDensityUnit.AmperePerSquareFoot, UnitConverterCurrentDensityUnit.MilliamperePerSquareInch };
                default:
                    return new[] { UnitConverterCurrentDensityUnit.AmperePerSquareMeter, UnitConverterCurrentDensityUnit.MilliamperePerSquareMeter, UnitConverterCurrentDensityUnit.AmperePerSquareCentimeter, UnitConverterCurrentDensityUnit.AmperePerSquareMillimeter, UnitConverterCurrentDensityUnit.AmperePerSquareInch, UnitConverterCurrentDensityUnit.KiloamperePerSquareMeter, UnitConverterCurrentDensityUnit.MegaamperePerSquareMeter, UnitConverterCurrentDensityUnit.MilliamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.MicroamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.AmperePerSquareFoot, UnitConverterCurrentDensityUnit.NanoamperePerSquareMeter, UnitConverterCurrentDensityUnit.KiloamperePerSquareCentimeter, UnitConverterCurrentDensityUnit.MegaamperePerSquareMillimeter, UnitConverterCurrentDensityUnit.MilliamperePerSquareInch };
            }
        }
    }
}
