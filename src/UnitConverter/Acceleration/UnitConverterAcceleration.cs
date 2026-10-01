namespace UnitConverter.Acceleration
{
    using UnitConverter.Acceleration.Metric;
    using UnitConverter.Acceleration.Imperial;
    using UnitConverter.Acceleration.Scientific;
    using UnitConverter.Acceleration.Nautical;

    public enum UnitConverterAccelerationUnit
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

    public static class UnitConverterAcceleration
    {
        public static double Convert(double value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            double baseValue = ToMeterPerSecondSquared(value, from);
            return FromMeterPerSecondSquared(baseValue, to);
        }

        public static double ToMeterPerSecondSquared(double value, UnitConverterAccelerationUnit from)
        {
            switch (from)
            {
                case UnitConverterAccelerationUnit.MeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.FootPerSecondSquared:
                    return UnitConverterImperialAcceleration.FootPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.Galileo:
                    return UnitConverterScientificAcceleration.GalileoToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.StandardGravity:
                    return UnitConverterScientificAcceleration.StandardGravityToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitConverterMetricAcceleration.KilometerPerHourPerSecondToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.MilePerHourPerSecond:
                    return UnitConverterImperialAcceleration.MilePerHourPerSecondToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.InchPerSecondSquared:
                    return UnitConverterImperialAcceleration.InchPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.YardPerSecondSquared:
                    return UnitConverterImperialAcceleration.YardPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.CentimeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.MillimeterPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.KilometerPerSecondSquared:
                    return UnitConverterMetricAcceleration.KilometerPerSecondSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.FootPerMinuteSquared:
                    return UnitConverterImperialAcceleration.FootPerMinuteSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.MeterPerMinuteSquared:
                    return UnitConverterMetricAcceleration.MeterPerMinuteSquaredToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.KnotPerSecond:
                    return UnitConverterNauticalAcceleration.KnotPerSecondToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.Gal:
                    return UnitConverterScientificAcceleration.GalToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.Milligal:
                    return UnitConverterScientificAcceleration.MilligalToMeterPerSecondSquared(value);
                case UnitConverterAccelerationUnit.Microgal:
                    return UnitConverterScientificAcceleration.MicrogalToMeterPerSecondSquared(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported acceleration unit.");
            }
        }

        public static double FromMeterPerSecondSquared(double baseValue, UnitConverterAccelerationUnit to)
        {
            switch (to)
            {
                case UnitConverterAccelerationUnit.MeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToMeterPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.FootPerSecondSquared:
                    return UnitConverterImperialAcceleration.MeterPerSecondSquaredToFootPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.Galileo:
                    return UnitConverterScientificAcceleration.MeterPerSecondSquaredToGalileo(baseValue);
                case UnitConverterAccelerationUnit.StandardGravity:
                    return UnitConverterScientificAcceleration.MeterPerSecondSquaredToStandardGravity(baseValue);
                case UnitConverterAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToKilometerPerHourPerSecond(baseValue);
                case UnitConverterAccelerationUnit.MilePerHourPerSecond:
                    return UnitConverterImperialAcceleration.MeterPerSecondSquaredToMilePerHourPerSecond(baseValue);
                case UnitConverterAccelerationUnit.InchPerSecondSquared:
                    return UnitConverterImperialAcceleration.MeterPerSecondSquaredToInchPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.YardPerSecondSquared:
                    return UnitConverterImperialAcceleration.MeterPerSecondSquaredToYardPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToCentimeterPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToMillimeterPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.KilometerPerSecondSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToKilometerPerSecondSquared(baseValue);
                case UnitConverterAccelerationUnit.FootPerMinuteSquared:
                    return UnitConverterImperialAcceleration.MeterPerSecondSquaredToFootPerMinuteSquared(baseValue);
                case UnitConverterAccelerationUnit.MeterPerMinuteSquared:
                    return UnitConverterMetricAcceleration.MeterPerSecondSquaredToMeterPerMinuteSquared(baseValue);
                case UnitConverterAccelerationUnit.KnotPerSecond:
                    return UnitConverterNauticalAcceleration.MeterPerSecondSquaredToKnotPerSecond(baseValue);
                case UnitConverterAccelerationUnit.Gal:
                    return UnitConverterScientificAcceleration.MeterPerSecondSquaredToGal(baseValue);
                case UnitConverterAccelerationUnit.Milligal:
                    return UnitConverterScientificAcceleration.MeterPerSecondSquaredToMilligal(baseValue);
                case UnitConverterAccelerationUnit.Microgal:
                    return UnitConverterScientificAcceleration.MeterPerSecondSquaredToMicrogal(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported acceleration unit.");
            }
        }

        public static string GetSymbol(UnitConverterAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAccelerationUnit.MeterPerSecondSquared:
                    return "m/s²";
                case UnitConverterAccelerationUnit.FootPerSecondSquared:
                    return "ft/s²";
                case UnitConverterAccelerationUnit.Galileo:
                    return "Gal";
                case UnitConverterAccelerationUnit.StandardGravity:
                    return "g₀";
                case UnitConverterAccelerationUnit.KilometerPerHourPerSecond:
                    return "km/h/s";
                case UnitConverterAccelerationUnit.MilePerHourPerSecond:
                    return "mph/s";
                case UnitConverterAccelerationUnit.InchPerSecondSquared:
                    return "in/s²";
                case UnitConverterAccelerationUnit.YardPerSecondSquared:
                    return "yd/s²";
                case UnitConverterAccelerationUnit.CentimeterPerSecondSquared:
                    return "cm/s²";
                case UnitConverterAccelerationUnit.MillimeterPerSecondSquared:
                    return "mm/s²";
                case UnitConverterAccelerationUnit.KilometerPerSecondSquared:
                    return "km/s²";
                case UnitConverterAccelerationUnit.FootPerMinuteSquared:
                    return "ft/min²";
                case UnitConverterAccelerationUnit.MeterPerMinuteSquared:
                    return "m/min²";
                case UnitConverterAccelerationUnit.KnotPerSecond:
                    return "kn/s";
                case UnitConverterAccelerationUnit.Gal:
                    return "Gal";
                case UnitConverterAccelerationUnit.Milligal:
                    return "mGal";
                case UnitConverterAccelerationUnit.Microgal:
                    return "µGal";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAccelerationUnit.MeterPerSecondSquared:
                    return "meter per second squared";
                case UnitConverterAccelerationUnit.FootPerSecondSquared:
                    return "foot per second squared";
                case UnitConverterAccelerationUnit.Galileo:
                    return "galileo";
                case UnitConverterAccelerationUnit.StandardGravity:
                    return "standard gravity";
                case UnitConverterAccelerationUnit.KilometerPerHourPerSecond:
                    return "Kilometer Per Hour Per Second";
                case UnitConverterAccelerationUnit.MilePerHourPerSecond:
                    return "Mile Per Hour Per Second";
                case UnitConverterAccelerationUnit.InchPerSecondSquared:
                    return "Inch Per Second Squared";
                case UnitConverterAccelerationUnit.YardPerSecondSquared:
                    return "Yard Per Second Squared";
                case UnitConverterAccelerationUnit.CentimeterPerSecondSquared:
                    return "Centimeter Per Second Squared";
                case UnitConverterAccelerationUnit.MillimeterPerSecondSquared:
                    return "Millimeter Per Second Squared";
                case UnitConverterAccelerationUnit.KilometerPerSecondSquared:
                    return "Kilometer Per Second Squared";
                case UnitConverterAccelerationUnit.FootPerMinuteSquared:
                    return "Foot Per Minute Squared";
                case UnitConverterAccelerationUnit.MeterPerMinuteSquared:
                    return "Meter Per Minute Squared";
                case UnitConverterAccelerationUnit.KnotPerSecond:
                    return "Knot Per Second";
                case UnitConverterAccelerationUnit.Gal:
                    return "Gal";
                case UnitConverterAccelerationUnit.Milligal:
                    return "Milligal";
                case UnitConverterAccelerationUnit.Microgal:
                    return "Microgal";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAccelerationUnit.MeterPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.FootPerSecondSquared:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAccelerationUnit.Galileo:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAccelerationUnit.StandardGravity:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAccelerationUnit.KilometerPerHourPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.MilePerHourPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAccelerationUnit.InchPerSecondSquared:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAccelerationUnit.YardPerSecondSquared:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAccelerationUnit.CentimeterPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.MillimeterPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.KilometerPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.FootPerMinuteSquared:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAccelerationUnit.MeterPerMinuteSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAccelerationUnit.KnotPerSecond:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterAccelerationUnit.Gal:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAccelerationUnit.Milligal:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAccelerationUnit.Microgal:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAccelerationUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAccelerationUnit.MeterPerSecondSquared, UnitConverterAccelerationUnit.KilometerPerHourPerSecond, UnitConverterAccelerationUnit.CentimeterPerSecondSquared, UnitConverterAccelerationUnit.MillimeterPerSecondSquared, UnitConverterAccelerationUnit.KilometerPerSecondSquared, UnitConverterAccelerationUnit.MeterPerMinuteSquared };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterAccelerationUnit.FootPerSecondSquared, UnitConverterAccelerationUnit.MilePerHourPerSecond, UnitConverterAccelerationUnit.InchPerSecondSquared, UnitConverterAccelerationUnit.YardPerSecondSquared, UnitConverterAccelerationUnit.FootPerMinuteSquared };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAccelerationUnit.Galileo, UnitConverterAccelerationUnit.StandardGravity, UnitConverterAccelerationUnit.Gal, UnitConverterAccelerationUnit.Milligal, UnitConverterAccelerationUnit.Microgal };
                case UnitConverterUnitSystem.Nautical:
                    return new[] { UnitConverterAccelerationUnit.KnotPerSecond };
                default:
                    return new[] { UnitConverterAccelerationUnit.MeterPerSecondSquared, UnitConverterAccelerationUnit.FootPerSecondSquared, UnitConverterAccelerationUnit.Galileo, UnitConverterAccelerationUnit.StandardGravity, UnitConverterAccelerationUnit.KilometerPerHourPerSecond, UnitConverterAccelerationUnit.MilePerHourPerSecond, UnitConverterAccelerationUnit.InchPerSecondSquared, UnitConverterAccelerationUnit.YardPerSecondSquared, UnitConverterAccelerationUnit.CentimeterPerSecondSquared, UnitConverterAccelerationUnit.MillimeterPerSecondSquared, UnitConverterAccelerationUnit.KilometerPerSecondSquared, UnitConverterAccelerationUnit.FootPerMinuteSquared, UnitConverterAccelerationUnit.MeterPerMinuteSquared, UnitConverterAccelerationUnit.KnotPerSecond, UnitConverterAccelerationUnit.Gal, UnitConverterAccelerationUnit.Milligal, UnitConverterAccelerationUnit.Microgal };
            }
        }
    }
}
