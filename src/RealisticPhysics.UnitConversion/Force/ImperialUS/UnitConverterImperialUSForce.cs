namespace RealisticPhysics.UnitConversion.Force.ImperialUS
{
    public static class UnitConverterImperialUSForce
    {
        public static double KipToNewton(double value)
        {
            return value * 4448.2216152604997d;
        }

        public static double NewtonToKip(double baseValue)
        {
            return baseValue / 4448.2216152604997d;
        }

        public static double TonForceUSToNewton(double value)
        {
            return value * 8896.4432305209994d;
        }

        public static double NewtonToTonForceUS(double baseValue)
        {
            return baseValue / 8896.4432305209994d;
        }
    }
}
