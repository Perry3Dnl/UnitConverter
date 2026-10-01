namespace RealisticPhysics.UnitConversion.RadiationDose.Common
{
    public static class UnitConverterCommonRadiationDose
    {
        public static double RadToGray(double value)
        {
            return value * 0.01d;
        }

        public static double GrayToRad(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double SievertToGray(double value)
        {
            return value * 1.0d;
        }

        public static double GrayToSievert(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double MillisievertToGray(double value)
        {
            return value * 0.001d;
        }

        public static double GrayToMillisievert(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrosievertToGray(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double GrayToMicrosievert(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double RemToGray(double value)
        {
            return value * 0.01d;
        }

        public static double GrayToRem(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MilliremToGray(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double GrayToMillirem(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
