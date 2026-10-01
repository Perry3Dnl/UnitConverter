namespace RealisticPhysics.UnitConversion.VolumetricFlowRate.Survey
{
    public static class UnitConverterSurveyVolumetricFlowRate
    {
        public static double AcreFootPerDayToCubicMeterPerSecond(double value)
        {
            return value * 0.0142764101568d;
        }

        public static double CubicMeterPerSecondToAcreFootPerDay(double baseValue)
        {
            return baseValue / 0.0142764101568d;
        }
    }
}
