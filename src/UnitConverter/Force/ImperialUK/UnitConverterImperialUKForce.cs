namespace UnitConverter.Force.ImperialUK
{
    public static class UnitConverterImperialUKForce
    {
        public static double TonForceUKToNewton(double value)
        {
            return value * 9964.0164181835207d;
        }

        public static double NewtonToTonForceUK(double baseValue)
        {
            return baseValue / 9964.0164181835207d;
        }
    }
}
