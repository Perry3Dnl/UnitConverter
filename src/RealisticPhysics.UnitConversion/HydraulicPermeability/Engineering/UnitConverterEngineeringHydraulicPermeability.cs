namespace RealisticPhysics.UnitConversion.HydraulicPermeability.Engineering
{
    public static class UnitConverterEngineeringHydraulicPermeability
    {
        public static double DarcyToSquareMeter(double value)
        {
            return value * 9.8692330000000009e-13d;
        }

        public static double SquareMeterToDarcy(double baseValue)
        {
            return baseValue / 9.8692330000000009e-13d;
        }

        public static double MillidarcyToSquareMeter(double value)
        {
            return value * 9.8692330000000007e-16d;
        }

        public static double SquareMeterToMillidarcy(double baseValue)
        {
            return baseValue / 9.8692330000000007e-16d;
        }

        public static double MicrodarcyToSquareMeter(double value)
        {
            return value * 9.8692329999999995e-19d;
        }

        public static double SquareMeterToMicrodarcy(double baseValue)
        {
            return baseValue / 9.8692329999999995e-19d;
        }

        public static double NanodarcyToSquareMeter(double value)
        {
            return value * 9.8692329999999999e-22d;
        }

        public static double SquareMeterToNanodarcy(double baseValue)
        {
            return baseValue / 9.8692329999999999e-22d;
        }

        public static double KilodarcyToSquareMeter(double value)
        {
            return value * 9.8692329999999996e-10d;
        }

        public static double SquareMeterToKilodarcy(double baseValue)
        {
            return baseValue / 9.8692329999999996e-10d;
        }
    }
}
