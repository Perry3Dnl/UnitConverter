namespace UnitConverter.SurfaceTension.Scientific
{
    public static class UnitConverterScientificSurfaceTension
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
