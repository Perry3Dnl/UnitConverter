namespace UnitTools.MolarMass.Imperial
{
    public static class UnitToolsImperialMolarMass
    {
        public static double PoundPerPoundMoleToKilogramPerMole(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerMoleToPoundPerPoundMole(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double OuncePerMoleToKilogramPerMole(double value)
        {
            return value * 0.028349523125000001d;
        }

        public static double KilogramPerMoleToOuncePerMole(double baseValue)
        {
            return baseValue / 0.028349523125000001d;
        }

        public static double PoundPerMoleToKilogramPerMole(double value)
        {
            return value * 0.45359237000000002d;
        }

        public static double KilogramPerMoleToPoundPerMole(double baseValue)
        {
            return baseValue / 0.45359237000000002d;
        }
    }
}
