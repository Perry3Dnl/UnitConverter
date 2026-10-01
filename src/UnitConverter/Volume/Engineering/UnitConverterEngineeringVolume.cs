namespace UnitConverter.Volume.Engineering
{
    public static class UnitConverterEngineeringVolume
    {
        public static double OilBarrelToLiter(double value)
        {
            return value * 158.98729492800001d;
        }

        public static double LiterToOilBarrel(double baseValue)
        {
            return baseValue / 158.98729492800001d;
        }

        public static double RegisterTonToLiter(double value)
        {
            return value * 2831.6846592000002d;
        }

        public static double LiterToRegisterTon(double baseValue)
        {
            return baseValue / 2831.6846592000002d;
        }

        public static double OilBarrelPerThousandToLiter(double value)
        {
            return value * 158.98729492800001d;
        }

        public static double LiterToOilBarrelPerThousand(double baseValue)
        {
            return baseValue / 158.98729492800001d;
        }
    }
}
