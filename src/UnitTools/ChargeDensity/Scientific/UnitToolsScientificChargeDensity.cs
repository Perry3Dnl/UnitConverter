namespace UnitTools.ChargeDensity.Scientific
{
    public static class UnitToolsScientificChargeDensity
    {
        public static double StatcoulombPerCubicCentimeterToCoulombPerCubicMeter(double value)
        {
            return value * 0.00033356409519815205d;
        }

        public static double CoulombPerCubicMeterToStatcoulombPerCubicCentimeter(double baseValue)
        {
            return baseValue / 0.00033356409519815205d;
        }
    }
}
