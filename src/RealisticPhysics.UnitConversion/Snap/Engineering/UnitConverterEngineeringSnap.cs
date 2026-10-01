namespace RealisticPhysics.UnitConversion.Snap.Engineering
{
    public static class UnitConverterEngineeringSnap
    {
        public static double StandardGravityPerSecondSquaredToMeterPerSecondFourth(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double MeterPerSecondFourthToStandardGravityPerSecondSquared(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }
    }
}
