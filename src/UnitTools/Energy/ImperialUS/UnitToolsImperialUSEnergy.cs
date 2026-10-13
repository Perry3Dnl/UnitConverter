namespace UnitTools.Energy.ImperialUS
{
    public static class UnitToolsImperialUSEnergy
    {
        public static double ThermUSToJoule(double value)
        {
            return value * 105480400.0d;
        }

        public static double JouleToThermUS(double baseValue)
        {
            return baseValue / 105480400.0d;
        }

        public static double QuadToJoule(double value)
        {
            return value * 1.05505585262e+18d;
        }

        public static double JouleToQuad(double baseValue)
        {
            return baseValue / 1.05505585262e+18d;
        }
    }
}
