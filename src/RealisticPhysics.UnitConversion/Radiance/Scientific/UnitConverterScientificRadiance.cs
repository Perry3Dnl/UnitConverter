namespace RealisticPhysics.UnitConversion.Radiance.Scientific
{
    public static class UnitConverterScientificRadiance
    {
        public static double ErgPerSecondSteradianSquareCentimeterToWattPerSteradianSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double WattPerSteradianSquareMeterToErgPerSecondSteradianSquareCentimeter(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
