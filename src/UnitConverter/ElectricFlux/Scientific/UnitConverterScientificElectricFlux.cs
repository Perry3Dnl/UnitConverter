namespace UnitConverter.ElectricFlux.Scientific
{
    public static class UnitConverterScientificElectricFlux
    {
        public static double StatvoltCentimeterToVoltMeter(double value)
        {
            return value * 2.9979245799999998d;
        }

        public static double VoltMeterToStatvoltCentimeter(double baseValue)
        {
            return baseValue / 2.9979245799999998d;
        }

        public static double StatvoltMeterToVoltMeter(double value)
        {
            return value * 299.79245800000001d;
        }

        public static double VoltMeterToStatvoltMeter(double baseValue)
        {
            return baseValue / 299.79245800000001d;
        }
    }
}
