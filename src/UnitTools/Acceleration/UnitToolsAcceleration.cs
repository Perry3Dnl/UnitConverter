namespace UnitTools.Acceleration
{
    using UnitTools.Acceleration.Metric;
    using UnitTools.Acceleration.Imperial;
    using UnitTools.Acceleration.Scientific;
    using UnitTools.Acceleration.Nautical;

    public enum UnitToolsAccelerationUnit
    {
        MeterPerSecondSquared = 0,
        FootPerSecondSquared = 1,
        Galileo = 2,
        StandardGravity = 3,
        KilometerPerHourPerSecond = 4,
        MilePerHourPerSecond = 5,
        InchPerSecondSquared = 6,
        YardPerSecondSquared = 7,
        CentimeterPerSecondSquared = 8,
        MillimeterPerSecondSquared = 9,
        KilometerPerSecondSquared = 10,
        FootPerMinuteSquared = 11,
        MeterPerMinuteSquared = 12,
        KnotPerSecond = 13,
        Gal = 14,
        Milligal = 15,
        Microgal = 16,
    }

    public static class UnitToolsAcceleration
    {
        public static double Convert(double value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            double baseValue = ToMeterPerSecondSquared(value, from);
            return FromMeterPerSecondSquared(baseValue, to);
        }

        public static double ToMeterPerSecondSquared(double value, UnitToolsAccelerationUnit from)
        {
            switch (from)
            {
                case UnitToolsAccelerationUnit.MeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.FootPerSecondSquared:
                    return UnitToolsImperialAcceleration.FootPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.Galileo:
                    return UnitToolsScientificAcceleration.GalileoToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.StandardGravity:
                    return UnitToolsScientificAcceleration.StandardGravityToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitToolsMetricAcceleration.KilometerPerHourPerSecondToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.MilePerHourPerSecond:
                    return UnitToolsImperialAcceleration.MilePerHourPerSecondToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.InchPerSecondSquared:
                    return UnitToolsImperialAcceleration.InchPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.YardPerSecondSquared:
                    return UnitToolsImperialAcceleration.YardPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.CentimeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.MillimeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.KilometerPerSecondSquared:
                    return UnitToolsMetricAcceleration.KilometerPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.FootPerMinuteSquared:
                    return UnitToolsImperialAcceleration.FootPerMinuteSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.MeterPerMinuteSquared:
                    return UnitToolsMetricAcceleration.MeterPerMinuteSquaredToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.KnotPerSecond:
                    return UnitToolsNauticalAcceleration.KnotPerSecondToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.Gal:
                    return UnitToolsScientificAcceleration.GalToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.Milligal:
                    return UnitToolsScientificAcceleration.MilligalToMeterPerSecondSquared(value);
                case UnitToolsAccelerationUnit.Microgal:
                    return UnitToolsScientificAcceleration.MicrogalToMeterPerSecondSquared(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported acceleration unit.");
            }
        }

        public static double FromMeterPerSecondSquared(double baseValue, UnitToolsAccelerationUnit to)
        {
            switch (to)
            {
                case UnitToolsAccelerationUnit.MeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToMeterPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.FootPerSecondSquared:
                    return UnitToolsImperialAcceleration.MeterPerSecondSquaredToFootPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.Galileo:
                    return UnitToolsScientificAcceleration.MeterPerSecondSquaredToGalileo(baseValue);
                case UnitToolsAccelerationUnit.StandardGravity:
                    return UnitToolsScientificAcceleration.MeterPerSecondSquaredToStandardGravity(baseValue);
                case UnitToolsAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToKilometerPerHourPerSecond(baseValue);
                case UnitToolsAccelerationUnit.MilePerHourPerSecond:
                    return UnitToolsImperialAcceleration.MeterPerSecondSquaredToMilePerHourPerSecond(baseValue);
                case UnitToolsAccelerationUnit.InchPerSecondSquared:
                    return UnitToolsImperialAcceleration.MeterPerSecondSquaredToInchPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.YardPerSecondSquared:
                    return UnitToolsImperialAcceleration.MeterPerSecondSquaredToYardPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToCentimeterPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToMillimeterPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.KilometerPerSecondSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToKilometerPerSecondSquared(baseValue);
                case UnitToolsAccelerationUnit.FootPerMinuteSquared:
                    return UnitToolsImperialAcceleration.MeterPerSecondSquaredToFootPerMinuteSquared(baseValue);
                case UnitToolsAccelerationUnit.MeterPerMinuteSquared:
                    return UnitToolsMetricAcceleration.MeterPerSecondSquaredToMeterPerMinuteSquared(baseValue);
                case UnitToolsAccelerationUnit.KnotPerSecond:
                    return UnitToolsNauticalAcceleration.MeterPerSecondSquaredToKnotPerSecond(baseValue);
                case UnitToolsAccelerationUnit.Gal:
                    return UnitToolsScientificAcceleration.MeterPerSecondSquaredToGal(baseValue);
                case UnitToolsAccelerationUnit.Milligal:
                    return UnitToolsScientificAcceleration.MeterPerSecondSquaredToMilligal(baseValue);
                case UnitToolsAccelerationUnit.Microgal:
                    return UnitToolsScientificAcceleration.MeterPerSecondSquaredToMicrogal(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported acceleration unit.");
            }
        }

        public static string GetSymbol(UnitToolsAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAccelerationUnit.MeterPerSecondSquared:
                    return "m/s²";
                case UnitToolsAccelerationUnit.FootPerSecondSquared:
                    return "ft/s²";
                case UnitToolsAccelerationUnit.Galileo:
                    return "Gal";
                case UnitToolsAccelerationUnit.StandardGravity:
                    return "g₀";
                case UnitToolsAccelerationUnit.KilometerPerHourPerSecond:
                    return "km/h/s";
                case UnitToolsAccelerationUnit.MilePerHourPerSecond:
                    return "mph/s";
                case UnitToolsAccelerationUnit.InchPerSecondSquared:
                    return "in/s²";
                case UnitToolsAccelerationUnit.YardPerSecondSquared:
                    return "yd/s²";
                case UnitToolsAccelerationUnit.CentimeterPerSecondSquared:
                    return "cm/s²";
                case UnitToolsAccelerationUnit.MillimeterPerSecondSquared:
                    return "mm/s²";
                case UnitToolsAccelerationUnit.KilometerPerSecondSquared:
                    return "km/s²";
                case UnitToolsAccelerationUnit.FootPerMinuteSquared:
                    return "ft/min²";
                case UnitToolsAccelerationUnit.MeterPerMinuteSquared:
                    return "m/min²";
                case UnitToolsAccelerationUnit.KnotPerSecond:
                    return "kn/s";
                case UnitToolsAccelerationUnit.Gal:
                    return "Gal";
                case UnitToolsAccelerationUnit.Milligal:
                    return "mGal";
                case UnitToolsAccelerationUnit.Microgal:
                    return "µGal";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAccelerationUnit.MeterPerSecondSquared:
                    return "meter per second squared";
                case UnitToolsAccelerationUnit.FootPerSecondSquared:
                    return "foot per second squared";
                case UnitToolsAccelerationUnit.Galileo:
                    return "galileo";
                case UnitToolsAccelerationUnit.StandardGravity:
                    return "standard gravity";
                case UnitToolsAccelerationUnit.KilometerPerHourPerSecond:
                    return "Kilometer Per Hour Per Second";
                case UnitToolsAccelerationUnit.MilePerHourPerSecond:
                    return "Mile Per Hour Per Second";
                case UnitToolsAccelerationUnit.InchPerSecondSquared:
                    return "Inch Per Second Squared";
                case UnitToolsAccelerationUnit.YardPerSecondSquared:
                    return "Yard Per Second Squared";
                case UnitToolsAccelerationUnit.CentimeterPerSecondSquared:
                    return "Centimeter Per Second Squared";
                case UnitToolsAccelerationUnit.MillimeterPerSecondSquared:
                    return "Millimeter Per Second Squared";
                case UnitToolsAccelerationUnit.KilometerPerSecondSquared:
                    return "Kilometer Per Second Squared";
                case UnitToolsAccelerationUnit.FootPerMinuteSquared:
                    return "Foot Per Minute Squared";
                case UnitToolsAccelerationUnit.MeterPerMinuteSquared:
                    return "Meter Per Minute Squared";
                case UnitToolsAccelerationUnit.KnotPerSecond:
                    return "Knot Per Second";
                case UnitToolsAccelerationUnit.Gal:
                    return "Gal";
                case UnitToolsAccelerationUnit.Milligal:
                    return "Milligal";
                case UnitToolsAccelerationUnit.Microgal:
                    return "Microgal";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAccelerationUnit.MeterPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.FootPerSecondSquared:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAccelerationUnit.Galileo:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAccelerationUnit.StandardGravity:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.MilePerHourPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAccelerationUnit.InchPerSecondSquared:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAccelerationUnit.YardPerSecondSquared:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.KilometerPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.FootPerMinuteSquared:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAccelerationUnit.MeterPerMinuteSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAccelerationUnit.KnotPerSecond:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsAccelerationUnit.Gal:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAccelerationUnit.Milligal:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAccelerationUnit.Microgal:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAccelerationUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAccelerationUnit.MeterPerSecondSquared, UnitToolsAccelerationUnit.KilometerPerHourPerSecond, UnitToolsAccelerationUnit.CentimeterPerSecondSquared, UnitToolsAccelerationUnit.MillimeterPerSecondSquared, UnitToolsAccelerationUnit.KilometerPerSecondSquared, UnitToolsAccelerationUnit.MeterPerMinuteSquared };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsAccelerationUnit.FootPerSecondSquared, UnitToolsAccelerationUnit.MilePerHourPerSecond, UnitToolsAccelerationUnit.InchPerSecondSquared, UnitToolsAccelerationUnit.YardPerSecondSquared, UnitToolsAccelerationUnit.FootPerMinuteSquared };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAccelerationUnit.Galileo, UnitToolsAccelerationUnit.StandardGravity, UnitToolsAccelerationUnit.Gal, UnitToolsAccelerationUnit.Milligal, UnitToolsAccelerationUnit.Microgal };
                case UnitToolsUnitSystem.Nautical:
                    return new[] { UnitToolsAccelerationUnit.KnotPerSecond };
                default:
                    return new[] { UnitToolsAccelerationUnit.MeterPerSecondSquared, UnitToolsAccelerationUnit.FootPerSecondSquared, UnitToolsAccelerationUnit.Galileo, UnitToolsAccelerationUnit.StandardGravity, UnitToolsAccelerationUnit.KilometerPerHourPerSecond, UnitToolsAccelerationUnit.MilePerHourPerSecond, UnitToolsAccelerationUnit.InchPerSecondSquared, UnitToolsAccelerationUnit.YardPerSecondSquared, UnitToolsAccelerationUnit.CentimeterPerSecondSquared, UnitToolsAccelerationUnit.MillimeterPerSecondSquared, UnitToolsAccelerationUnit.KilometerPerSecondSquared, UnitToolsAccelerationUnit.FootPerMinuteSquared, UnitToolsAccelerationUnit.MeterPerMinuteSquared, UnitToolsAccelerationUnit.KnotPerSecond, UnitToolsAccelerationUnit.Gal, UnitToolsAccelerationUnit.Milligal, UnitToolsAccelerationUnit.Microgal };
            }
        }
    }
}
