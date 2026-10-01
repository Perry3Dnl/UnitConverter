namespace RealisticPhysics.UnitConversion.Jerk.Engineering
{
    public static class UnitConverterEngineeringJerk
    {
        public static double StandardGravityPerSecondToMeterPerSecondCubed(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double MeterPerSecondCubedToStandardGravityPerSecond(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double StandardGravityPerMinuteToMeterPerSecondCubed(double value)
        {
            return value * 0.16344416666666667d;
        }

        public static double MeterPerSecondCubedToStandardGravityPerMinute(double baseValue)
        {
            return baseValue / 0.16344416666666667d;
        }
    }
}
