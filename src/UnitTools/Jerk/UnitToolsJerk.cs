namespace UnitTools.Jerk
{
    using UnitTools.Jerk.Metric;
    using UnitTools.Jerk.Imperial;
    using UnitTools.Jerk.Engineering;
    using UnitTools.Jerk.Scientific;

    public enum UnitToolsJerkUnit
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

    public static class UnitToolsJerk
    {
        public static double Convert(double value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            double baseValue = ToMeterPerSecondCubed(value, from);
            return FromMeterPerSecondCubed(baseValue, to);
        }

        public static double ToMeterPerSecondCubed(double value, UnitToolsJerkUnit from)
        {
            switch (from)
            {
                case UnitToolsJerkUnit.MeterPerSecondCubed:
                    return UnitToolsMetricJerk.MeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.CentimeterPerSecondCubed:
                    return UnitToolsMetricJerk.CentimeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.MillimeterPerSecondCubed:
                    return UnitToolsMetricJerk.MillimeterPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.FootPerSecondCubed:
                    return UnitToolsImperialJerk.FootPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.StandardGravityPerSecond:
                    return UnitToolsEngineeringJerk.StandardGravityPerSecondToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitToolsMetricJerk.KilometerPerHourPerSecondSquaredToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.MilePerHourPerSecondSquared:
                    return UnitToolsImperialJerk.MilePerHourPerSecondSquaredToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.InchPerSecondCubed:
                    return UnitToolsImperialJerk.InchPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.YardPerSecondCubed:
                    return UnitToolsImperialJerk.YardPerSecondCubedToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.GalPerSecond:
                    return UnitToolsScientificJerk.GalPerSecondToMeterPerSecondCubed(value);
                case UnitToolsJerkUnit.StandardGravityPerMinute:
                    return UnitToolsEngineeringJerk.StandardGravityPerMinuteToMeterPerSecondCubed(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported jerk unit.");
            }
        }

        public static double FromMeterPerSecondCubed(double baseValue, UnitToolsJerkUnit to)
        {
            switch (to)
            {
                case UnitToolsJerkUnit.MeterPerSecondCubed:
                    return UnitToolsMetricJerk.MeterPerSecondCubedToMeterPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.CentimeterPerSecondCubed:
                    return UnitToolsMetricJerk.MeterPerSecondCubedToCentimeterPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.MillimeterPerSecondCubed:
                    return UnitToolsMetricJerk.MeterPerSecondCubedToMillimeterPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.FootPerSecondCubed:
                    return UnitToolsImperialJerk.MeterPerSecondCubedToFootPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.StandardGravityPerSecond:
                    return UnitToolsEngineeringJerk.MeterPerSecondCubedToStandardGravityPerSecond(baseValue);
                case UnitToolsJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitToolsMetricJerk.MeterPerSecondCubedToKilometerPerHourPerSecondSquared(baseValue);
                case UnitToolsJerkUnit.MilePerHourPerSecondSquared:
                    return UnitToolsImperialJerk.MeterPerSecondCubedToMilePerHourPerSecondSquared(baseValue);
                case UnitToolsJerkUnit.InchPerSecondCubed:
                    return UnitToolsImperialJerk.MeterPerSecondCubedToInchPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.YardPerSecondCubed:
                    return UnitToolsImperialJerk.MeterPerSecondCubedToYardPerSecondCubed(baseValue);
                case UnitToolsJerkUnit.GalPerSecond:
                    return UnitToolsScientificJerk.MeterPerSecondCubedToGalPerSecond(baseValue);
                case UnitToolsJerkUnit.StandardGravityPerMinute:
                    return UnitToolsEngineeringJerk.MeterPerSecondCubedToStandardGravityPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported jerk unit.");
            }
        }

        public static string GetSymbol(UnitToolsJerkUnit unit)
        {
            switch (unit)
            {
                case UnitToolsJerkUnit.MeterPerSecondCubed:
                    return "m/s³";
                case UnitToolsJerkUnit.CentimeterPerSecondCubed:
                    return "cm/s³";
                case UnitToolsJerkUnit.MillimeterPerSecondCubed:
                    return "mm/s³";
                case UnitToolsJerkUnit.FootPerSecondCubed:
                    return "ft/s³";
                case UnitToolsJerkUnit.StandardGravityPerSecond:
                    return "g₀/s";
                case UnitToolsJerkUnit.KilometerPerHourPerSecondSquared:
                    return "km/h/s²";
                case UnitToolsJerkUnit.MilePerHourPerSecondSquared:
                    return "mph/s²";
                case UnitToolsJerkUnit.InchPerSecondCubed:
                    return "in/s³";
                case UnitToolsJerkUnit.YardPerSecondCubed:
                    return "yd/s³";
                case UnitToolsJerkUnit.GalPerSecond:
                    return "Gal/s";
                case UnitToolsJerkUnit.StandardGravityPerMinute:
                    return "g₀/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsJerkUnit unit)
        {
            switch (unit)
            {
                case UnitToolsJerkUnit.MeterPerSecondCubed:
                    return "Meter Per Second Cubed";
                case UnitToolsJerkUnit.CentimeterPerSecondCubed:
                    return "Centimeter Per Second Cubed";
                case UnitToolsJerkUnit.MillimeterPerSecondCubed:
                    return "Millimeter Per Second Cubed";
                case UnitToolsJerkUnit.FootPerSecondCubed:
                    return "Foot Per Second Cubed";
                case UnitToolsJerkUnit.StandardGravityPerSecond:
                    return "Standard Gravity Per Second";
                case UnitToolsJerkUnit.KilometerPerHourPerSecondSquared:
                    return "Kilometer Per Hour Per Second Squared";
                case UnitToolsJerkUnit.MilePerHourPerSecondSquared:
                    return "Mile Per Hour Per Second Squared";
                case UnitToolsJerkUnit.InchPerSecondCubed:
                    return "Inch Per Second Cubed";
                case UnitToolsJerkUnit.YardPerSecondCubed:
                    return "Yard Per Second Cubed";
                case UnitToolsJerkUnit.GalPerSecond:
                    return "Gal Per Second";
                case UnitToolsJerkUnit.StandardGravityPerMinute:
                    return "Standard Gravity Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsJerkUnit unit)
        {
            switch (unit)
            {
                case UnitToolsJerkUnit.MeterPerSecondCubed:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsJerkUnit.CentimeterPerSecondCubed:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsJerkUnit.MillimeterPerSecondCubed:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsJerkUnit.FootPerSecondCubed:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsJerkUnit.StandardGravityPerSecond:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsJerkUnit.KilometerPerHourPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsJerkUnit.MilePerHourPerSecondSquared:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsJerkUnit.InchPerSecondCubed:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsJerkUnit.YardPerSecondCubed:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsJerkUnit.GalPerSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsJerkUnit.StandardGravityPerMinute:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsJerkUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsJerkUnit.MeterPerSecondCubed, UnitToolsJerkUnit.CentimeterPerSecondCubed, UnitToolsJerkUnit.MillimeterPerSecondCubed, UnitToolsJerkUnit.KilometerPerHourPerSecondSquared };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsJerkUnit.FootPerSecondCubed, UnitToolsJerkUnit.MilePerHourPerSecondSquared, UnitToolsJerkUnit.InchPerSecondCubed, UnitToolsJerkUnit.YardPerSecondCubed };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsJerkUnit.StandardGravityPerSecond, UnitToolsJerkUnit.StandardGravityPerMinute };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsJerkUnit.GalPerSecond };
                default:
                    return new[] { UnitToolsJerkUnit.MeterPerSecondCubed, UnitToolsJerkUnit.CentimeterPerSecondCubed, UnitToolsJerkUnit.MillimeterPerSecondCubed, UnitToolsJerkUnit.FootPerSecondCubed, UnitToolsJerkUnit.StandardGravityPerSecond, UnitToolsJerkUnit.KilometerPerHourPerSecondSquared, UnitToolsJerkUnit.MilePerHourPerSecondSquared, UnitToolsJerkUnit.InchPerSecondCubed, UnitToolsJerkUnit.YardPerSecondCubed, UnitToolsJerkUnit.GalPerSecond, UnitToolsJerkUnit.StandardGravityPerMinute };
            }
        }
    }
}
