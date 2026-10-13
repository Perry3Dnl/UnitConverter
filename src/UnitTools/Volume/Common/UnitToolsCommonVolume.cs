namespace UnitTools.Volume.Common
{
    public static class UnitToolsCommonVolume
    {
        public static double DropToLiter(double value)
        {
            return value * 5.0000000000000002e-05d;
        }

        public static double LiterToDrop(double baseValue)
        {
            return baseValue / 5.0000000000000002e-05d;
        }
    }
}
