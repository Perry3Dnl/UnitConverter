namespace UnitTools.TorquePerAngle.Imperial
{
    public static class UnitToolsImperialTorquePerAngle
    {
        public static double PoundForceFootPerRadianToNewtonMeterPerRadian(double value)
        {
            return value * 1.3558179483314003d;
        }

        public static double NewtonMeterPerRadianToPoundForceFootPerRadian(double baseValue)
        {
            return baseValue / 1.3558179483314003d;
        }

        public static double PoundForceInchPerDegreeToNewtonMeterPerRadian(double value)
        {
            return value * 6.473553852289629d;
        }

        public static double NewtonMeterPerRadianToPoundForceInchPerDegree(double baseValue)
        {
            return baseValue / 6.473553852289629d;
        }

        public static double PoundForceFootPerDegreeToNewtonMeterPerRadian(double value)
        {
            return value * 77.682646227475558d;
        }

        public static double NewtonMeterPerRadianToPoundForceFootPerDegree(double baseValue)
        {
            return baseValue / 77.682646227475558d;
        }
    }
}
