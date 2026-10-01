namespace RealisticPhysics.UnitConversion.Force.Historical
{
    public static class UnitConverterHistoricalForce
    {
        public static double PondToNewton(double value)
        {
            return value * 0.0098066500000000001d;
        }

        public static double NewtonToPond(double baseValue)
        {
            return baseValue / 0.0098066500000000001d;
        }

        public static double StheneToNewton(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonToSthene(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
