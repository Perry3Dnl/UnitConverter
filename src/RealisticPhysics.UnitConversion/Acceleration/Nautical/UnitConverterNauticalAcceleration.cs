namespace RealisticPhysics.UnitConversion.Acceleration.Nautical
{
    public static class UnitConverterNauticalAcceleration
    {
        public static double KnotPerSecondToMeterPerSecondSquared(double value)
        {
            return value * 0.51444444444444448d;
        }

        public static double MeterPerSecondSquaredToKnotPerSecond(double baseValue)
        {
            return baseValue / 0.51444444444444448d;
        }
    }
}
