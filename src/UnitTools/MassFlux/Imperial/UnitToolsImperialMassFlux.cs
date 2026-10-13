namespace UnitTools.MassFlux.Imperial
{
    public static class UnitToolsImperialMassFlux
    {
        public static double PoundPerSquareFootSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 4.8824276363830501d;
        }

        public static double KilogramPerSquareMeterSecondToPoundPerSquareFootSecond(double baseValue)
        {
            return baseValue / 4.8824276363830501d;
        }

        public static double OuncePerSquareFootSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 0.30515172727394063d;
        }

        public static double KilogramPerSquareMeterSecondToOuncePerSquareFootSecond(double baseValue)
        {
            return baseValue / 0.30515172727394063d;
        }

        public static double PoundPerSquareInchSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 703.06957963915931d;
        }

        public static double KilogramPerSquareMeterSecondToPoundPerSquareInchSecond(double baseValue)
        {
            return baseValue / 703.06957963915931d;
        }
    }
}
