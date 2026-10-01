namespace RealisticPhysics.UnitConversion.ElectricCharge.Metric
{
    public static class UnitConverterMetricElectricCharge
    {
        public static double NanocoulombToCoulomb(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double CoulombToNanocoulomb(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrocoulombToCoulomb(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombToMicrocoulomb(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MillicoulombToCoulomb(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombToMillicoulomb(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double CoulombToCoulomb(double value)
        {
            return value;
        }

        public static double KilocoulombToCoulomb(double value)
        {
            return value * 1000.0d;
        }

        public static double CoulombToKilocoulomb(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double FemtocoulombToCoulomb(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double CoulombToFemtocoulomb(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double PicocoulombToCoulomb(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double CoulombToPicocoulomb(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double MegacoulombToCoulomb(double value)
        {
            return value * 1000000.0d;
        }

        public static double CoulombToMegacoulomb(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigacoulombToCoulomb(double value)
        {
            return value * 1000000000.0d;
        }

        public static double CoulombToGigacoulomb(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }
    }
}
