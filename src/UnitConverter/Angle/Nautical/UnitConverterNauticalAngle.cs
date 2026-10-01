namespace UnitConverter.Angle.Nautical
{
    public static class UnitConverterNauticalAngle
    {
        public static double CompassPointToDegree(double value)
        {
            return value * 11.25d;
        }

        public static double DegreeToCompassPoint(double baseValue)
        {
            return baseValue / 11.25d;
        }
    }
}
