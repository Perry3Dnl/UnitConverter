namespace UnitTools.ElectricFlux.Metric
{
    public static class UnitToolsMetricElectricFlux
    {
        public static double VoltMeterToVoltMeter(double value)
        {
            return value;
        }

        public static double KilovoltMeterToVoltMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double VoltMeterToKilovoltMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double VoltCentimeterToVoltMeter(double value)
        {
            return value * 0.01d;
        }

        public static double VoltMeterToVoltCentimeter(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MillivoltMeterToVoltMeter(double value)
        {
            return value * 0.001d;
        }

        public static double VoltMeterToMillivoltMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrovoltMeterToVoltMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double VoltMeterToMicrovoltMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double VoltMillimeterToVoltMeter(double value)
        {
            return value * 0.001d;
        }

        public static double VoltMeterToVoltMillimeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double NanovoltMeterToVoltMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double VoltMeterToNanovoltMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double PicovoltMeterToVoltMeter(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double VoltMeterToPicovoltMeter(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double MegavoltMeterToVoltMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double VoltMeterToMegavoltMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigavoltMeterToVoltMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double VoltMeterToGigavoltMeter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double VoltKilometerToVoltMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double VoltMeterToVoltKilometer(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
