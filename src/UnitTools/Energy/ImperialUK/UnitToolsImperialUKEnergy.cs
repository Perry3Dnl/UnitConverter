namespace UnitTools.Energy.ImperialUK
{
    public static class UnitToolsImperialUKEnergy
    {
        public static double ThermUKToJoule(double value)
        {
            return value * 105505585.257348d;
        }

        public static double JouleToThermUK(double baseValue)
        {
            return baseValue / 105505585.257348d;
        }
    }
}
