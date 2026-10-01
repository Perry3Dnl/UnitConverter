namespace RealisticPhysics.UnitConversion.ElectricFluxDensity.Imperial
{
    public static class UnitConverterImperialElectricFluxDensity
    {
        public static double CoulombPerSquareInchToCoulombPerSquareMeter(double value)
        {
            return value * 1550.0031000062002d;
        }

        public static double CoulombPerSquareMeterToCoulombPerSquareInch(double baseValue)
        {
            return baseValue / 1550.0031000062002d;
        }

        public static double CoulombPerSquareFootToCoulombPerSquareMeter(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double CoulombPerSquareMeterToCoulombPerSquareFoot(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }
    }
}
