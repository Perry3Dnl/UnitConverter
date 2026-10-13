namespace UnitTools.Angle.Historical
{
    public static class UnitToolsHistoricalAngle
    {
        public static double SextantToDegree(double value)
        {
            return value * 60.0d;
        }

        public static double DegreeToSextant(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double SignToDegree(double value)
        {
            return value * 30.0d;
        }

        public static double DegreeToSign(double baseValue)
        {
            return baseValue / 30.0d;
        }
    }
}
