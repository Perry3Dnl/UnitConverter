namespace UnitTools.ElectricFluxDensity.Scientific
{
    public static class UnitToolsScientificElectricFluxDensity
    {
        public static double StatcoulombPerSquareCentimeterToCoulombPerSquareMeter(double value)
        {
            return value * 3.3356409519815205e-06d;
        }

        public static double CoulombPerSquareMeterToStatcoulombPerSquareCentimeter(double baseValue)
        {
            return baseValue / 3.3356409519815205e-06d;
        }
    }
}
