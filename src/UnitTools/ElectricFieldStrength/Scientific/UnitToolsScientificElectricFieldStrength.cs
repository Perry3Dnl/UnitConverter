namespace UnitTools.ElectricFieldStrength.Scientific
{
    public static class UnitToolsScientificElectricFieldStrength
    {
        public static double StatvoltPerCentimeterToVoltPerMeter(double value)
        {
            return value * 29979.245800000001d;
        }

        public static double VoltPerMeterToStatvoltPerCentimeter(double baseValue)
        {
            return baseValue / 29979.245800000001d;
        }

        public static double StatvoltPerMeterToVoltPerMeter(double value)
        {
            return value * 299.79245800000001d;
        }

        public static double VoltPerMeterToStatvoltPerMeter(double baseValue)
        {
            return baseValue / 299.79245800000001d;
        }

        public static double AbvoltPerCentimeterToVoltPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double VoltPerMeterToAbvoltPerCentimeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }
    }
}
