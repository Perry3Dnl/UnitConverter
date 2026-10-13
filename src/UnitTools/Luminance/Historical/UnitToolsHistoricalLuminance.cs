namespace UnitTools.Luminance.Historical
{
    public static class UnitToolsHistoricalLuminance
    {
        public static double SkotToCandelaPerSquareMeter(double value)
        {
            return value * 0.0003183098861837907d;
        }

        public static double CandelaPerSquareMeterToSkot(double baseValue)
        {
            return baseValue / 0.0003183098861837907d;
        }
    }
}
