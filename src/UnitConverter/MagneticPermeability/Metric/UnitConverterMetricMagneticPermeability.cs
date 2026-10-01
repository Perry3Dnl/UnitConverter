namespace UnitConverter.MagneticPermeability.Metric
{
    public static class UnitConverterMetricMagneticPermeability
    {
        public static double HenryPerMeterToHenryPerMeter(double value)
        {
            return value;
        }

        public static double MillihenryPerMeterToHenryPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double HenryPerMeterToMillihenryPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrohenryPerMeterToHenryPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double HenryPerMeterToMicrohenryPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NanohenryPerMeterToHenryPerMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double HenryPerMeterToNanohenryPerMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double PicohenryPerMeterToHenryPerMeter(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double HenryPerMeterToPicohenryPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double HenryPerMillimeterToHenryPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double HenryPerMeterToHenryPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
