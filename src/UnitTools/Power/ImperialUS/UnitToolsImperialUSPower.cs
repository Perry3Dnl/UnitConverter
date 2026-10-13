namespace UnitTools.Power.ImperialUS
{
    public static class UnitToolsImperialUSPower
    {
        public static double HorsepowerBoilerToWatt(double value)
        {
            return value * 9809.5d;
        }

        public static double WattToHorsepowerBoiler(double baseValue)
        {
            return baseValue / 9809.5d;
        }
    }
}
