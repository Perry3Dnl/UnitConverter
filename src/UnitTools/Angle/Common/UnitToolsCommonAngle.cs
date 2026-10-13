namespace UnitTools.Angle.Common
{
    public static class UnitToolsCommonAngle
    {
        public static double DegreeToDegree(double value)
        {
            return value;
        }

        public static double TurnToDegree(double value)
        {
            return value * 360.0d;
        }

        public static double DegreeToTurn(double baseValue)
        {
            return baseValue / 360.0d;
        }

        public static double QuadrantToDegree(double value)
        {
            return value * 90.0d;
        }

        public static double DegreeToQuadrant(double baseValue)
        {
            return baseValue / 90.0d;
        }
    }
}
