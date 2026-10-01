namespace UnitConverter.Voltage.Metric
{
    public static class UnitConverterMetricVoltage
    {
        public static double NanovoltToVolt(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double VoltToNanovolt(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrovoltToVolt(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double VoltToMicrovolt(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MillivoltToVolt(double value)
        {
            return value * 0.001d;
        }

        public static double VoltToMillivolt(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double VoltToVolt(double value)
        {
            return value;
        }

        public static double KilovoltToVolt(double value)
        {
            return value * 1000.0d;
        }

        public static double VoltToKilovolt(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegavoltToVolt(double value)
        {
            return value * 1000000.0d;
        }

        public static double VoltToMegavolt(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigavoltToVolt(double value)
        {
            return value * 1000000000.0d;
        }

        public static double VoltToGigavolt(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double FemtovoltToVolt(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double VoltToFemtovolt(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double PicovoltToVolt(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double VoltToPicovolt(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double TeravoltToVolt(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double VoltToTeravolt(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }

        public static double PetavoltToVolt(double value)
        {
            return value * 1000000000000000.0d;
        }

        public static double VoltToPetavolt(double baseValue)
        {
            return baseValue / 1000000000000000.0d;
        }
    }
}
