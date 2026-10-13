namespace UnitTools.LuminousEfficacy.Scientific
{
    public static class UnitToolsScientificLuminousEfficacy
    {
        public static double PhotopicMaximumToLumenPerWatt(double value)
        {
            return value * 683.0d;
        }

        public static double LumenPerWattToPhotopicMaximum(double baseValue)
        {
            return baseValue / 683.0d;
        }

        public static double PhotopicScotopicRatioApproxToLumenPerWatt(double value)
        {
            return value * 1700.0d;
        }

        public static double LumenPerWattToPhotopicScotopicRatioApprox(double baseValue)
        {
            return baseValue / 1700.0d;
        }
    }
}
