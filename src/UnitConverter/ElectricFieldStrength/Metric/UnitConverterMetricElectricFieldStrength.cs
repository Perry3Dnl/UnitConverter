namespace UnitConverter.ElectricFieldStrength.Metric
{
    public static class UnitConverterMetricElectricFieldStrength
    {
        public static double VoltPerMeterToVoltPerMeter(double value)
        {
            return value;
        }

        public static double MillivoltPerMeterToVoltPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double VoltPerMeterToMillivoltPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilovoltPerMeterToVoltPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double VoltPerMeterToKilovoltPerMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double VoltPerCentimeterToVoltPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double VoltPerMeterToVoltPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double VoltPerMillimeterToVoltPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double VoltPerMeterToVoltPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MicrovoltPerMeterToVoltPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double VoltPerMeterToMicrovoltPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MegavoltPerMeterToVoltPerMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double VoltPerMeterToMegavoltPerMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double KilovoltPerCentimeterToVoltPerMeter(double value)
        {
            return value * 100000.0d;
        }

        public static double VoltPerMeterToKilovoltPerCentimeter(double baseValue)
        {
            return baseValue / 100000.0d;
        }

        public static double NanovoltPerMeterToVoltPerMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double VoltPerMeterToNanovoltPerMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double GigavoltPerMeterToVoltPerMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double VoltPerMeterToGigavoltPerMeter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }
    }
}
