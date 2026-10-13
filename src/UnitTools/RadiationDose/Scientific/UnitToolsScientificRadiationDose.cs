namespace UnitTools.RadiationDose.Scientific
{
    public static class UnitToolsScientificRadiationDose
    {
        public static double SievertPerGrayToGray(double value)
        {
            return value * 1.0d;
        }

        public static double GrayToSievertPerGray(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
