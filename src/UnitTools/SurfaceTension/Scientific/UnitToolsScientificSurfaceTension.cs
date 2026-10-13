namespace UnitTools.SurfaceTension.Scientific
{
    public static class UnitToolsScientificSurfaceTension
    {
        public static double DynePerCentimeterToNewtonPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerMeterToDynePerCentimeter(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
