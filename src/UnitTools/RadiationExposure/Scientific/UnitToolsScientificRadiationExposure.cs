namespace UnitTools.RadiationExposure.Scientific
{
    public static class UnitToolsScientificRadiationExposure
    {
        public static double StatcoulombPerGramToCoulombPerKilogram(double value)
        {
            return value * 3.3356409519815198e-07d;
        }

        public static double CoulombPerKilogramToStatcoulombPerGram(double baseValue)
        {
            return baseValue / 3.3356409519815198e-07d;
        }
    }
}
