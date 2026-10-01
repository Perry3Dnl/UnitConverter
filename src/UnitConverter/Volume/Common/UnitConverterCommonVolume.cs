namespace UnitConverter.Volume.Common
{
    public static class UnitConverterCommonVolume
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
