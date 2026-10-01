namespace UnitConverter.LuminousFlux.Common
{
    public static class UnitConverterCommonLuminousFlux
    {
        public static double LumenPerSteradianSteradianToLumen(double value)
        {
            return value * 1.0d;
        }

        public static double LumenToLumenPerSteradianSteradian(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double LumenMinutePerSecondAliasToLumen(double value)
        {
            return value * 60.0d;
        }

        public static double LumenToLumenMinutePerSecondAlias(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double LumenHourPerSecondAliasToLumen(double value)
        {
            return value * 3600.0d;
        }

        public static double LumenToLumenHourPerSecondAlias(double baseValue)
        {
            return baseValue / 3600.0d;
        }
    }
}
