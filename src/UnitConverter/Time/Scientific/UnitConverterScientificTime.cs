namespace UnitConverter.Time.Scientific
{
    public static class UnitConverterScientificTime
    {
        public static double NanosecondToSecond(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double SecondToNanosecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrosecondToSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double SecondToMicrosecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double JulianYearToSecond(double value)
        {
            return value * 31557600.0d;
        }

        public static double SecondToJulianYear(double baseValue)
        {
            return baseValue / 31557600.0d;
        }

        public static double ShakeToSecond(double value)
        {
            return value * 1e-08d;
        }

        public static double SecondToShake(double baseValue)
        {
            return baseValue / 1e-08d;
        }

        public static double SvedbergToSecond(double value)
        {
            return value * 1e-13d;
        }

        public static double SecondToSvedberg(double baseValue)
        {
            return baseValue / 1e-13d;
        }
    }
}
