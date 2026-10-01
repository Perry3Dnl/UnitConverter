namespace RealisticPhysics.UnitConversion.Angle.Astronomical
{
    public static class UnitConverterAstronomicalAngle
    {
        public static double HourAngleToDegree(double value)
        {
            return value * 15.0d;
        }

        public static double DegreeToHourAngle(double baseValue)
        {
            return baseValue / 15.0d;
        }

        public static double MinuteOfTimeToDegree(double value)
        {
            return value * 0.25d;
        }

        public static double DegreeToMinuteOfTime(double baseValue)
        {
            return baseValue / 0.25d;
        }

        public static double SecondOfTimeToDegree(double value)
        {
            return value * 0.0041666666666666666d;
        }

        public static double DegreeToSecondOfTime(double baseValue)
        {
            return baseValue / 0.0041666666666666666d;
        }
    }
}
