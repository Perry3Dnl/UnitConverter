namespace UnitConverter.Permittivity.Metric
{
    public static class UnitConverterMetricPermittivity
    {
        public static double FaradPerMeterToFaradPerMeter(double value)
        {
            return value;
        }

        public static double PicofaradPerMeterToFaradPerMeter(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double FaradPerMeterToPicofaradPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double NanofaradPerMeterToFaradPerMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double FaradPerMeterToNanofaradPerMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrofaradPerMeterToFaradPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double FaradPerMeterToMicrofaradPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MillifaradPerMeterToFaradPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double FaradPerMeterToMillifaradPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double FemtofaradPerMeterToFaradPerMeter(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double FaradPerMeterToFemtofaradPerMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double FaradPerMillimeterToFaradPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double FaradPerMeterToFaradPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
