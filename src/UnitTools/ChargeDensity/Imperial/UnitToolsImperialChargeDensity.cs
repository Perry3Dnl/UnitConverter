namespace UnitTools.ChargeDensity.Imperial
{
    public static class UnitToolsImperialChargeDensity
    {
        public static double CoulombPerCubicInchToCoulombPerCubicMeter(double value)
        {
            return value * 61023.74409473229d;
        }

        public static double CoulombPerCubicMeterToCoulombPerCubicInch(double baseValue)
        {
            return baseValue / 61023.74409473229d;
        }
    }
}
