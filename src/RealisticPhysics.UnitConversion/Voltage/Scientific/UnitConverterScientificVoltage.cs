namespace RealisticPhysics.UnitConversion.Voltage.Scientific
{
    public static class UnitConverterScientificVoltage
    {
        public static double StatvoltToVolt(double value)
        {
            return value * 299.79245800000001d;
        }

        public static double VoltToStatvolt(double baseValue)
        {
            return baseValue / 299.79245800000001d;
        }

        public static double AbvoltToVolt(double value)
        {
            return value * 1e-08d;
        }

        public static double VoltToAbvolt(double baseValue)
        {
            return baseValue / 1e-08d;
        }
    }
}
