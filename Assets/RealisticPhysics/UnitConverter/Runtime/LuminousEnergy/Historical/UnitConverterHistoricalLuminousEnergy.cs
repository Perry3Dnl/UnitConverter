namespace RealisticPhysics.UnitConversion.LuminousEnergy.Historical
{
    public static class UnitConverterHistoricalLuminousEnergy
    {
        public static double TalbotToLumenSecond(double value)
        {
            return value * 1.0d;
        }

        public static double LumenSecondToTalbot(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double LumergToLumenSecond(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double LumenSecondToLumerg(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }
    }
}
