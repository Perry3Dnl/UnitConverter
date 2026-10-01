namespace UnitConverter.Power.Scientific
{
    public static class UnitConverterScientificPower
    {
        public static double ErgPerSecondToWatt(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double WattToErgPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }
    }
}
