namespace RealisticPhysics.UnitConversion.Jerk
{
    using RealisticPhysics.UnitConversion.Jerk.Metric;
    using RealisticPhysics.UnitConversion.Jerk.Imperial;
    using RealisticPhysics.UnitConversion.Jerk.Engineering;
    using RealisticPhysics.UnitConversion.Jerk.Scientific;

    public enum UnitConverterJerkUnit
    {
        MeterPerSecondCubed = 0,
        CentimeterPerSecondCubed = 1,
        MillimeterPerSecondCubed = 2,
        FootPerSecondCubed = 3,
        StandardGravityPerSecond = 4,
        KilometerPerHourPerSecondSquared = 5,
        MilePerHourPerSecondSquared = 6,
        InchPerSecondCubed = 7,
        YardPerSecondCubed = 8,
        GalPerSecond = 9,
        StandardGravityPerMinute = 10,
    }

    public static class UnitConverterJerk
    {
        public static double Convert(double value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            double baseValue = ToMeterPerSecondCubed(value, from);
            return FromMeterPerSecondCubed(baseValue, to);
        }

        public static double ToMeterPerSecondCubed(double value, UnitConverterJerkUnit from)
        {
            switch (from)
            {
                case UnitConverterJerkUnit.MeterPerSecondCubed:
                    return UnitConverterMetricJerk.MeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.CentimeterPerSecondCubed:
                    return UnitConverterMetricJerk.CentimeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.MillimeterPerSecondCubed:
                    return UnitConverterMetricJerk.MillimeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.FootPerSecondCubed:
                    return UnitConverterImperialJerk.FootPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.StandardGravityPerSecond:
                    return UnitConverterEngineeringJerk.StandardGravityPerSecondToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitConverterMetricJerk.KilometerPerHourPerSecondSquaredToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.MilePerHourPerSecondSquared:
                    return UnitConverterImperialJerk.MilePerHourPerSecondSquaredToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.InchPerSecondCubed:
                    return UnitConverterImperialJerk.InchPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.YardPerSecondCubed:
                    return UnitConverterImperialJerk.YardPerSecondCubedToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.GalPerSecond:
                    return UnitConverterScientificJerk.GalPerSecondToMeterPerSecondCubed(value);
                case UnitConverterJerkUnit.StandardGravityPerMinute:
                    return UnitConverterEngineeringJerk.StandardGravityPerMinuteToMeterPerSecondCubed(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported jerk unit.");
            }
        }

        public static double FromMeterPerSecondCubed(double baseValue, UnitConverterJerkUnit to)
        {
            switch (to)
            {
                case UnitConverterJerkUnit.MeterPerSecondCubed:
                    return UnitConverterMetricJerk.MeterPerSecondCubedToMeterPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.CentimeterPerSecondCubed:
                    return UnitConverterMetricJerk.MeterPerSecondCubedToCentimeterPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.MillimeterPerSecondCubed:
                    return UnitConverterMetricJerk.MeterPerSecondCubedToMillimeterPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.FootPerSecondCubed:
                    return UnitConverterImperialJerk.MeterPerSecondCubedToFootPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.StandardGravityPerSecond:
                    return UnitConverterEngineeringJerk.MeterPerSecondCubedToStandardGravityPerSecond(baseValue);
                case UnitConverterJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitConverterMetricJerk.MeterPerSecondCubedToKilometerPerHourPerSecondSquared(baseValue);
                case UnitConverterJerkUnit.MilePerHourPerSecondSquared:
                    return UnitConverterImperialJerk.MeterPerSecondCubedToMilePerHourPerSecondSquared(baseValue);
                case UnitConverterJerkUnit.InchPerSecondCubed:
                    return UnitConverterImperialJerk.MeterPerSecondCubedToInchPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.YardPerSecondCubed:
                    return UnitConverterImperialJerk.MeterPerSecondCubedToYardPerSecondCubed(baseValue);
                case UnitConverterJerkUnit.GalPerSecond:
                    return UnitConverterScientificJerk.MeterPerSecondCubedToGalPerSecond(baseValue);
                case UnitConverterJerkUnit.StandardGravityPerMinute:
                    return UnitConverterEngineeringJerk.MeterPerSecondCubedToStandardGravityPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported jerk unit.");
            }
        }

        public static string GetSymbol(UnitConverterJerkUnit unit)
        {
            switch (unit)
            {
                case UnitConverterJerkUnit.MeterPerSecondCubed:
                    return "m/s³";
                case UnitConverterJerkUnit.CentimeterPerSecondCubed:
                    return "cm/s³";
                case UnitConverterJerkUnit.MillimeterPerSecondCubed:
                    return "mm/s³";
                case UnitConverterJerkUnit.FootPerSecondCubed:
                    return "ft/s³";
                case UnitConverterJerkUnit.StandardGravityPerSecond:
                    return "g₀/s";
                case UnitConverterJerkUnit.KilometerPerHourPerSecondSquared:
                    return "km/h/s²";
                case UnitConverterJerkUnit.MilePerHourPerSecondSquared:
                    return "mph/s²";
                case UnitConverterJerkUnit.InchPerSecondCubed:
                    return "in/s³";
                case UnitConverterJerkUnit.YardPerSecondCubed:
                    return "yd/s³";
                case UnitConverterJerkUnit.GalPerSecond:
                    return "Gal/s";
                case UnitConverterJerkUnit.StandardGravityPerMinute:
                    return "g₀/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterJerkUnit unit)
        {
            switch (unit)
            {
                case UnitConverterJerkUnit.MeterPerSecondCubed:
                    return "Meter Per Second Cubed";
                case UnitConverterJerkUnit.CentimeterPerSecondCubed:
                    return "Centimeter Per Second Cubed";
                case UnitConverterJerkUnit.MillimeterPerSecondCubed:
                    return "Millimeter Per Second Cubed";
                case UnitConverterJerkUnit.FootPerSecondCubed:
                    return "Foot Per Second Cubed";
                case UnitConverterJerkUnit.StandardGravityPerSecond:
                    return "Standard Gravity Per Second";
                case UnitConverterJerkUnit.KilometerPerHourPerSecondSquared:
                    return "Kilometer Per Hour Per Second Squared";
                case UnitConverterJerkUnit.MilePerHourPerSecondSquared:
                    return "Mile Per Hour Per Second Squared";
                case UnitConverterJerkUnit.InchPerSecondCubed:
                    return "Inch Per Second Cubed";
                case UnitConverterJerkUnit.YardPerSecondCubed:
                    return "Yard Per Second Cubed";
                case UnitConverterJerkUnit.GalPerSecond:
                    return "Gal Per Second";
                case UnitConverterJerkUnit.StandardGravityPerMinute:
                    return "Standard Gravity Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterJerkUnit unit)
        {
            switch (unit)
            {
                case UnitConverterJerkUnit.MeterPerSecondCubed:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterJerkUnit.CentimeterPerSecondCubed:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterJerkUnit.MillimeterPerSecondCubed:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterJerkUnit.FootPerSecondCubed:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterJerkUnit.StandardGravityPerSecond:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterJerkUnit.MilePerHourPerSecondSquared:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterJerkUnit.InchPerSecondCubed:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterJerkUnit.YardPerSecondCubed:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterJerkUnit.GalPerSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterJerkUnit.StandardGravityPerMinute:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterJerkUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterJerkUnit.MeterPerSecondCubed, UnitConverterJerkUnit.CentimeterPerSecondCubed, UnitConverterJerkUnit.MillimeterPerSecondCubed, UnitConverterJerkUnit.KilometerPerHourPerSecondSquared };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterJerkUnit.FootPerSecondCubed, UnitConverterJerkUnit.MilePerHourPerSecondSquared, UnitConverterJerkUnit.InchPerSecondCubed, UnitConverterJerkUnit.YardPerSecondCubed };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterJerkUnit.StandardGravityPerSecond, UnitConverterJerkUnit.StandardGravityPerMinute };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterJerkUnit.GalPerSecond };
                default:
                    return new[] { UnitConverterJerkUnit.MeterPerSecondCubed, UnitConverterJerkUnit.CentimeterPerSecondCubed, UnitConverterJerkUnit.MillimeterPerSecondCubed, UnitConverterJerkUnit.FootPerSecondCubed, UnitConverterJerkUnit.StandardGravityPerSecond, UnitConverterJerkUnit.KilometerPerHourPerSecondSquared, UnitConverterJerkUnit.MilePerHourPerSecondSquared, UnitConverterJerkUnit.InchPerSecondCubed, UnitConverterJerkUnit.YardPerSecondCubed, UnitConverterJerkUnit.GalPerSecond, UnitConverterJerkUnit.StandardGravityPerMinute };
            }
        }
    }
}
