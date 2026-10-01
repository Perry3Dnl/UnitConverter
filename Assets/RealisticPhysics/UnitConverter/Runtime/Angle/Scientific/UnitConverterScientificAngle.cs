namespace RealisticPhysics.UnitConversion.Angle.Scientific
{
    public static class UnitConverterScientificAngle
    {
        public static double ArcsecondToDegree(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double DegreeToArcsecond(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double ArcminuteToDegree(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double DegreeToArcminute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double RadianToDegree(double value)
        {
            return value * 57.295779513082323d;
        }

        public static double DegreeToRadian(double baseValue)
        {
            return baseValue / 57.295779513082323d;
        }

        public static double MilliradianToDegree(double value)
        {
            return value * 0.057295779513082318d;
        }

        public static double DegreeToMilliradian(double baseValue)
        {
            return baseValue / 0.057295779513082318d;
        }
    }
}
