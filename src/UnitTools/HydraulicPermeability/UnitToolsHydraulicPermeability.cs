namespace UnitTools.HydraulicPermeability
{
    using UnitTools.HydraulicPermeability.Metric;
    using UnitTools.HydraulicPermeability.Engineering;
    using UnitTools.HydraulicPermeability.Imperial;

    public enum UnitToolsHydraulicPermeabilityUnit
    {
        SquareMeter = 0,
        SquareCentimeter = 1,
        SquareMillimeter = 2,
        Darcy = 3,
        Millidarcy = 4,
        Microdarcy = 5,
        Nanodarcy = 6,
        Kilodarcy = 7,
        SquareMicrometer = 8,
        SquareNanometer = 9,
        SquareInch = 10,
    }

    public static class UnitToolsHydraulicPermeability
    {
        public static double Convert(double value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            double baseValue = ToSquareMeter(value, from);
            return FromSquareMeter(baseValue, to);
        }

        public static double ToSquareMeter(double value, UnitToolsHydraulicPermeabilityUnit from)
        {
            switch (from)
            {
                case UnitToolsHydraulicPermeabilityUnit.SquareMeter:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitToolsMetricHydraulicPermeability.SquareCentimeterToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitToolsMetricHydraulicPermeability.SquareMillimeterToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.Darcy:
                    return UnitToolsEngineeringHydraulicPermeability.DarcyToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.Millidarcy:
                    return UnitToolsEngineeringHydraulicPermeability.MillidarcyToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.Microdarcy:
                    return UnitToolsEngineeringHydraulicPermeability.MicrodarcyToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitToolsEngineeringHydraulicPermeability.NanodarcyToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitToolsEngineeringHydraulicPermeability.KilodarcyToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitToolsMetricHydraulicPermeability.SquareMicrometerToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitToolsMetricHydraulicPermeability.SquareNanometerToSquareMeter(value);
                case UnitToolsHydraulicPermeabilityUnit.SquareInch:
                    return UnitToolsImperialHydraulicPermeability.SquareInchToSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported hydraulic permeability unit.");
            }
        }

        public static double FromSquareMeter(double baseValue, UnitToolsHydraulicPermeabilityUnit to)
        {
            switch (to)
            {
                case UnitToolsHydraulicPermeabilityUnit.SquareMeter:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareMeter(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareCentimeter(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareMillimeter(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.Darcy:
                    return UnitToolsEngineeringHydraulicPermeability.SquareMeterToDarcy(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.Millidarcy:
                    return UnitToolsEngineeringHydraulicPermeability.SquareMeterToMillidarcy(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.Microdarcy:
                    return UnitToolsEngineeringHydraulicPermeability.SquareMeterToMicrodarcy(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitToolsEngineeringHydraulicPermeability.SquareMeterToNanodarcy(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitToolsEngineeringHydraulicPermeability.SquareMeterToKilodarcy(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareMicrometer(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitToolsMetricHydraulicPermeability.SquareMeterToSquareNanometer(baseValue);
                case UnitToolsHydraulicPermeabilityUnit.SquareInch:
                    return UnitToolsImperialHydraulicPermeability.SquareMeterToSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported hydraulic permeability unit.");
            }
        }

        public static string GetSymbol(UnitToolsHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHydraulicPermeabilityUnit.SquareMeter:
                    return "m²";
                case UnitToolsHydraulicPermeabilityUnit.SquareCentimeter:
                    return "cm²";
                case UnitToolsHydraulicPermeabilityUnit.SquareMillimeter:
                    return "mm²";
                case UnitToolsHydraulicPermeabilityUnit.Darcy:
                    return "D";
                case UnitToolsHydraulicPermeabilityUnit.Millidarcy:
                    return "mD";
                case UnitToolsHydraulicPermeabilityUnit.Microdarcy:
                    return "µD";
                case UnitToolsHydraulicPermeabilityUnit.Nanodarcy:
                    return "nD";
                case UnitToolsHydraulicPermeabilityUnit.Kilodarcy:
                    return "kD";
                case UnitToolsHydraulicPermeabilityUnit.SquareMicrometer:
                    return "µm²";
                case UnitToolsHydraulicPermeabilityUnit.SquareNanometer:
                    return "nm²";
                case UnitToolsHydraulicPermeabilityUnit.SquareInch:
                    return "in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHydraulicPermeabilityUnit.SquareMeter:
                    return "Square Meter";
                case UnitToolsHydraulicPermeabilityUnit.SquareCentimeter:
                    return "Square Centimeter";
                case UnitToolsHydraulicPermeabilityUnit.SquareMillimeter:
                    return "Square Millimeter";
                case UnitToolsHydraulicPermeabilityUnit.Darcy:
                    return "Darcy";
                case UnitToolsHydraulicPermeabilityUnit.Millidarcy:
                    return "Millidarcy";
                case UnitToolsHydraulicPermeabilityUnit.Microdarcy:
                    return "Microdarcy";
                case UnitToolsHydraulicPermeabilityUnit.Nanodarcy:
                    return "Nanodarcy";
                case UnitToolsHydraulicPermeabilityUnit.Kilodarcy:
                    return "Kilodarcy";
                case UnitToolsHydraulicPermeabilityUnit.SquareMicrometer:
                    return "Square Micrometer";
                case UnitToolsHydraulicPermeabilityUnit.SquareNanometer:
                    return "Square Nanometer";
                case UnitToolsHydraulicPermeabilityUnit.SquareInch:
                    return "Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHydraulicPermeabilityUnit.SquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHydraulicPermeabilityUnit.Darcy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsHydraulicPermeabilityUnit.Millidarcy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsHydraulicPermeabilityUnit.Microdarcy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHydraulicPermeabilityUnit.SquareInch:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsHydraulicPermeabilityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsHydraulicPermeabilityUnit.SquareMeter, UnitToolsHydraulicPermeabilityUnit.SquareCentimeter, UnitToolsHydraulicPermeabilityUnit.SquareMillimeter, UnitToolsHydraulicPermeabilityUnit.SquareMicrometer, UnitToolsHydraulicPermeabilityUnit.SquareNanometer };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsHydraulicPermeabilityUnit.Darcy, UnitToolsHydraulicPermeabilityUnit.Millidarcy, UnitToolsHydraulicPermeabilityUnit.Microdarcy, UnitToolsHydraulicPermeabilityUnit.Nanodarcy, UnitToolsHydraulicPermeabilityUnit.Kilodarcy };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsHydraulicPermeabilityUnit.SquareInch };
                default:
                    return new[] { UnitToolsHydraulicPermeabilityUnit.SquareMeter, UnitToolsHydraulicPermeabilityUnit.SquareCentimeter, UnitToolsHydraulicPermeabilityUnit.SquareMillimeter, UnitToolsHydraulicPermeabilityUnit.Darcy, UnitToolsHydraulicPermeabilityUnit.Millidarcy, UnitToolsHydraulicPermeabilityUnit.Microdarcy, UnitToolsHydraulicPermeabilityUnit.Nanodarcy, UnitToolsHydraulicPermeabilityUnit.Kilodarcy, UnitToolsHydraulicPermeabilityUnit.SquareMicrometer, UnitToolsHydraulicPermeabilityUnit.SquareNanometer, UnitToolsHydraulicPermeabilityUnit.SquareInch };
            }
        }
    }
}
