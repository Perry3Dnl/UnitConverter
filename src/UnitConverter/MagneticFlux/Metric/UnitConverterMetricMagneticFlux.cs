namespace UnitConverter.MagneticFlux.Metric
{
    public static class UnitConverterMetricMagneticFlux
    {
        public static double NanoweberToWeber(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double WeberToNanoweber(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicroweberToWeber(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double WeberToMicroweber(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliweberToWeber(double value)
        {
            return value * 0.001d;
        }

        public static double WeberToMilliweber(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double WeberToWeber(double value)
        {
            return value;
        }

        public static double PicoweberToWeber(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double WeberToPicoweber(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double FemtoweberToWeber(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double WeberToFemtoweber(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double KiloweberToWeber(double value)
        {
            return value * 1000.0d;
        }

        public static double WeberToKiloweber(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegaweberToWeber(double value)
        {
            return value * 1000000.0d;
        }

        public static double WeberToMegaweber(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double AttoweberToWeber(double value)
        {
            return value * 1.0000000000000001e-18d;
        }

        public static double WeberToAttoweber(double baseValue)
        {
            return baseValue / 1.0000000000000001e-18d;
        }

        public static double VoltSecondToWeber(double value)
        {
            return value * 1.0d;
        }

        public static double WeberToVoltSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
