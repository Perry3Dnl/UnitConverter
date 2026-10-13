namespace UnitTools.FrameRate.Common
{
    public static class UnitToolsCommonFrameRate
    {
        public static double FramePerSecondToFramePerSecond(double value)
        {
            return value;
        }

        public static double FramePerMinuteToFramePerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double FramePerSecondToFramePerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double FramePerHourToFramePerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double FramePerSecondToFramePerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double KiloframePerSecondToFramePerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double FramePerSecondToKiloframePerSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegaframePerSecondToFramePerSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double FramePerSecondToMegaframePerSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double FramePerMillisecondToFramePerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double FramePerSecondToFramePerMillisecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double FramePerDayToFramePerSecond(double value)
        {
            return value * 1.1574074074074073e-05d;
        }

        public static double FramePerSecondToFramePerDay(double baseValue)
        {
            return baseValue / 1.1574074074074073e-05d;
        }

        public static double FramePerWeekToFramePerSecond(double value)
        {
            return value * 1.6534391534391535e-06d;
        }

        public static double FramePerSecondToFramePerWeek(double baseValue)
        {
            return baseValue / 1.6534391534391535e-06d;
        }

        public static double FramePerMicrosecondToFramePerSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double FramePerSecondToFramePerMicrosecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double FramePerNanosecondToFramePerSecond(double value)
        {
            return value * 1000000000.0d;
        }

        public static double FramePerSecondToFramePerNanosecond(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double FramePerMonthJulianToFramePerSecond(double value)
        {
            return value * 3.8025705376834739e-07d;
        }

        public static double FramePerSecondToFramePerMonthJulian(double baseValue)
        {
            return baseValue / 3.8025705376834739e-07d;
        }

        public static double FramePerYearJulianToFramePerSecond(double value)
        {
            return value * 3.1688087814028947e-08d;
        }

        public static double FramePerSecondToFramePerYearJulian(double baseValue)
        {
            return baseValue / 3.1688087814028947e-08d;
        }
    }
}
