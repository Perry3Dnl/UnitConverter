namespace UnitConverter.Speed.Nautical
{
    public static class UnitConverterNauticalSpeed
    {
        public static double KnotToMeterPerSecond(double value)
        {
            return value * 0.51444444444444448d;
        }

        public static double MeterPerSecondToKnot(double baseValue)
        {
            return baseValue / 0.51444444444444448d;
        }
    }
}
