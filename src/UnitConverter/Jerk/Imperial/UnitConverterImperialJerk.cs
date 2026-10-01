namespace UnitConverter.Jerk.Imperial
{
    public static class UnitConverterImperialJerk
    {
        public static double FootPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double MeterPerSecondCubedToFootPerSecondCubed(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double MilePerHourPerSecondSquaredToMeterPerSecondCubed(double value)
        {
            return value * 0.44703999999999999d;
        }

        public static double MeterPerSecondCubedToMilePerHourPerSecondSquared(double baseValue)
        {
            return baseValue / 0.44703999999999999d;
        }

        public static double InchPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double MeterPerSecondCubedToInchPerSecondCubed(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double YardPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value * 0.91439999999999999d;
        }

        public static double MeterPerSecondCubedToYardPerSecondCubed(double baseValue)
        {
            return baseValue / 0.91439999999999999d;
        }
    }
}
