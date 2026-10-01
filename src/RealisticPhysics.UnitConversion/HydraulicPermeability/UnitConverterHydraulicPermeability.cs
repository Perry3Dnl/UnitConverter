namespace RealisticPhysics.UnitConversion.HydraulicPermeability
{
    using RealisticPhysics.UnitConversion.HydraulicPermeability.Metric;
    using RealisticPhysics.UnitConversion.HydraulicPermeability.Engineering;
    using RealisticPhysics.UnitConversion.HydraulicPermeability.Imperial;

    public enum UnitConverterHydraulicPermeabilityUnit
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

    public static class UnitConverterHydraulicPermeability
    {
        public static double Convert(double value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            double baseValue = ToSquareMeter(value, from);
            return FromSquareMeter(baseValue, to);
        }

        public static double ToSquareMeter(double value, UnitConverterHydraulicPermeabilityUnit from)
        {
            switch (from)
            {
                case UnitConverterHydraulicPermeabilityUnit.SquareMeter:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitConverterMetricHydraulicPermeability.SquareCentimeterToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitConverterMetricHydraulicPermeability.SquareMillimeterToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.Darcy:
                    return UnitConverterEngineeringHydraulicPermeability.DarcyToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.Millidarcy:
                    return UnitConverterEngineeringHydraulicPermeability.MillidarcyToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.Microdarcy:
                    return UnitConverterEngineeringHydraulicPermeability.MicrodarcyToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitConverterEngineeringHydraulicPermeability.NanodarcyToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitConverterEngineeringHydraulicPermeability.KilodarcyToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitConverterMetricHydraulicPermeability.SquareMicrometerToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitConverterMetricHydraulicPermeability.SquareNanometerToSquareMeter(value);
                case UnitConverterHydraulicPermeabilityUnit.SquareInch:
                    return UnitConverterImperialHydraulicPermeability.SquareInchToSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported hydraulic permeability unit.");
            }
        }

        public static double FromSquareMeter(double baseValue, UnitConverterHydraulicPermeabilityUnit to)
        {
            switch (to)
            {
                case UnitConverterHydraulicPermeabilityUnit.SquareMeter:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareMeter(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareCentimeter(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareMillimeter(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.Darcy:
                    return UnitConverterEngineeringHydraulicPermeability.SquareMeterToDarcy(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.Millidarcy:
                    return UnitConverterEngineeringHydraulicPermeability.SquareMeterToMillidarcy(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.Microdarcy:
                    return UnitConverterEngineeringHydraulicPermeability.SquareMeterToMicrodarcy(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitConverterEngineeringHydraulicPermeability.SquareMeterToNanodarcy(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitConverterEngineeringHydraulicPermeability.SquareMeterToKilodarcy(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareMicrometer(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitConverterMetricHydraulicPermeability.SquareMeterToSquareNanometer(baseValue);
                case UnitConverterHydraulicPermeabilityUnit.SquareInch:
                    return UnitConverterImperialHydraulicPermeability.SquareMeterToSquareInch(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported hydraulic permeability unit.");
            }
        }

        public static string GetSymbol(UnitConverterHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHydraulicPermeabilityUnit.SquareMeter:
                    return "m²";
                case UnitConverterHydraulicPermeabilityUnit.SquareCentimeter:
                    return "cm²";
                case UnitConverterHydraulicPermeabilityUnit.SquareMillimeter:
                    return "mm²";
                case UnitConverterHydraulicPermeabilityUnit.Darcy:
                    return "D";
                case UnitConverterHydraulicPermeabilityUnit.Millidarcy:
                    return "mD";
                case UnitConverterHydraulicPermeabilityUnit.Microdarcy:
                    return "µD";
                case UnitConverterHydraulicPermeabilityUnit.Nanodarcy:
                    return "nD";
                case UnitConverterHydraulicPermeabilityUnit.Kilodarcy:
                    return "kD";
                case UnitConverterHydraulicPermeabilityUnit.SquareMicrometer:
                    return "µm²";
                case UnitConverterHydraulicPermeabilityUnit.SquareNanometer:
                    return "nm²";
                case UnitConverterHydraulicPermeabilityUnit.SquareInch:
                    return "in²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHydraulicPermeabilityUnit.SquareMeter:
                    return "Square Meter";
                case UnitConverterHydraulicPermeabilityUnit.SquareCentimeter:
                    return "Square Centimeter";
                case UnitConverterHydraulicPermeabilityUnit.SquareMillimeter:
                    return "Square Millimeter";
                case UnitConverterHydraulicPermeabilityUnit.Darcy:
                    return "Darcy";
                case UnitConverterHydraulicPermeabilityUnit.Millidarcy:
                    return "Millidarcy";
                case UnitConverterHydraulicPermeabilityUnit.Microdarcy:
                    return "Microdarcy";
                case UnitConverterHydraulicPermeabilityUnit.Nanodarcy:
                    return "Nanodarcy";
                case UnitConverterHydraulicPermeabilityUnit.Kilodarcy:
                    return "Kilodarcy";
                case UnitConverterHydraulicPermeabilityUnit.SquareMicrometer:
                    return "Square Micrometer";
                case UnitConverterHydraulicPermeabilityUnit.SquareNanometer:
                    return "Square Nanometer";
                case UnitConverterHydraulicPermeabilityUnit.SquareInch:
                    return "Square Inch";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterHydraulicPermeabilityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHydraulicPermeabilityUnit.SquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHydraulicPermeabilityUnit.SquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHydraulicPermeabilityUnit.SquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHydraulicPermeabilityUnit.Darcy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterHydraulicPermeabilityUnit.Millidarcy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterHydraulicPermeabilityUnit.Microdarcy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterHydraulicPermeabilityUnit.Nanodarcy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterHydraulicPermeabilityUnit.Kilodarcy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterHydraulicPermeabilityUnit.SquareMicrometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHydraulicPermeabilityUnit.SquareNanometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHydraulicPermeabilityUnit.SquareInch:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterHydraulicPermeabilityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterHydraulicPermeabilityUnit.SquareMeter, UnitConverterHydraulicPermeabilityUnit.SquareCentimeter, UnitConverterHydraulicPermeabilityUnit.SquareMillimeter, UnitConverterHydraulicPermeabilityUnit.SquareMicrometer, UnitConverterHydraulicPermeabilityUnit.SquareNanometer };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterHydraulicPermeabilityUnit.Darcy, UnitConverterHydraulicPermeabilityUnit.Millidarcy, UnitConverterHydraulicPermeabilityUnit.Microdarcy, UnitConverterHydraulicPermeabilityUnit.Nanodarcy, UnitConverterHydraulicPermeabilityUnit.Kilodarcy };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterHydraulicPermeabilityUnit.SquareInch };
                default:
                    return new[] { UnitConverterHydraulicPermeabilityUnit.SquareMeter, UnitConverterHydraulicPermeabilityUnit.SquareCentimeter, UnitConverterHydraulicPermeabilityUnit.SquareMillimeter, UnitConverterHydraulicPermeabilityUnit.Darcy, UnitConverterHydraulicPermeabilityUnit.Millidarcy, UnitConverterHydraulicPermeabilityUnit.Microdarcy, UnitConverterHydraulicPermeabilityUnit.Nanodarcy, UnitConverterHydraulicPermeabilityUnit.Kilodarcy, UnitConverterHydraulicPermeabilityUnit.SquareMicrometer, UnitConverterHydraulicPermeabilityUnit.SquareNanometer, UnitConverterHydraulicPermeabilityUnit.SquareInch };
            }
        }
    }
}
