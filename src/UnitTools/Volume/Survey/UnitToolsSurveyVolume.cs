namespace UnitTools.Volume.Survey
{
    public static class UnitToolsSurveyVolume
    {
        public static double AcreFootToLiter(double value)
        {
            return value * 1233481.8375475199d;
        }

        public static double LiterToAcreFoot(double baseValue)
        {
            return baseValue / 1233481.8375475199d;
        }
    }
}
