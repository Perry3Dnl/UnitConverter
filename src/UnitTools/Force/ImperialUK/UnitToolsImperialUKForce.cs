namespace UnitTools.Force.ImperialUK
{
    public static class UnitToolsImperialUKForce
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
