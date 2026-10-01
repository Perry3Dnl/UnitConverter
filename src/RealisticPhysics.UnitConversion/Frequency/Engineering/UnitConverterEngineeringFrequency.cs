namespace RealisticPhysics.UnitConversion.Frequency.Engineering
{
    public static class UnitConverterEngineeringFrequency
    {
        public static double RevolutionsPerMinuteToHertz(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double HertzToRevolutionsPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }
    }
}
