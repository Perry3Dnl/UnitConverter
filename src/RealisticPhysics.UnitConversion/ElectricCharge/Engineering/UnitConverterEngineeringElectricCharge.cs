namespace RealisticPhysics.UnitConversion.ElectricCharge.Engineering
{
    public static class UnitConverterEngineeringElectricCharge
    {
        public static double AmpereHourToCoulomb(double value)
        {
            return value * 3600.0d;
        }

        public static double CoulombToAmpereHour(double baseValue)
        {
            return baseValue / 3600.0d;
        }

        public static double MilliampereHourToCoulomb(double value)
        {
            return value * 3.6000000000000001d;
        }

        public static double CoulombToMilliampereHour(double baseValue)
        {
            return baseValue / 3.6000000000000001d;
        }
    }
}
