namespace RealisticPhysics.UnitConversion.EnergyDensity.Imperial
{
    public static class UnitConverterImperialEnergyDensity
    {
        public static double BtuPerCubicFootToJoulePerCubicMeter(double value)
        {
            return value * 37258.945807831282d;
        }

        public static double JoulePerCubicMeterToBtuPerCubicFoot(double baseValue)
        {
            return baseValue / 37258.945807831282d;
        }

        public static double FootPoundPerCubicFootToJoulePerCubicMeter(double value)
        {
            return value * 47.880258980335839d;
        }

        public static double JoulePerCubicMeterToFootPoundPerCubicFoot(double baseValue)
        {
            return baseValue / 47.880258980335839d;
        }

        public static double ThermPerCubicFootToJoulePerCubicMeter(double value)
        {
            return value * 3725894580.6188445d;
        }

        public static double JoulePerCubicMeterToThermPerCubicFoot(double baseValue)
        {
            return baseValue / 3725894580.6188445d;
        }
    }
}
