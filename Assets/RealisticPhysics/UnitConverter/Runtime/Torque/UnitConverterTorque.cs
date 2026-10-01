namespace RealisticPhysics.UnitConversion.Torque
{
    using RealisticPhysics.UnitConversion.Torque.Metric;
    using RealisticPhysics.UnitConversion.Torque.Scientific;
    using RealisticPhysics.UnitConversion.Torque.Imperial;

    public enum UnitConverterTorqueUnit
    {
        NewtonMeter = 0,
        KilonewtonMeter = 1,
        DyneCentimeter = 2,
        PoundForceFoot = 3,
        PoundForceInch = 4,
        OunceForceInch = 5,
        MillinewtonMeter = 6,
        MicronewtonMeter = 7,
        MeganewtonMeter = 8,
        NewtonCentimeter = 9,
        NewtonMillimeter = 10,
        KilogramForceMeter = 11,
        KilogramForceCentimeter = 12,
        GramForceCentimeter = 13,
        DyneMeter = 14,
        PoundForceYard = 15,
        OunceForceFoot = 16,
        PoundalFoot = 17,
    }

    public static class UnitConverterTorque
    {
        public static double Convert(double value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            double baseValue = ToNewtonMeter(value, from);
            return FromNewtonMeter(baseValue, to);
        }

        public static double ToNewtonMeter(double value, UnitConverterTorqueUnit from)
        {
            switch (from)
            {
                case UnitConverterTorqueUnit.NewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.KilonewtonMeter:
                    return UnitConverterMetricTorque.KilonewtonMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.DyneCentimeter:
                    return UnitConverterScientificTorque.DyneCentimeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.PoundForceFoot:
                    return UnitConverterImperialTorque.PoundForceFootToNewtonMeter(value);
                case UnitConverterTorqueUnit.PoundForceInch:
                    return UnitConverterImperialTorque.PoundForceInchToNewtonMeter(value);
                case UnitConverterTorqueUnit.OunceForceInch:
                    return UnitConverterImperialTorque.OunceForceInchToNewtonMeter(value);
                case UnitConverterTorqueUnit.MillinewtonMeter:
                    return UnitConverterMetricTorque.MillinewtonMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.MicronewtonMeter:
                    return UnitConverterMetricTorque.MicronewtonMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.MeganewtonMeter:
                    return UnitConverterMetricTorque.MeganewtonMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.NewtonCentimeter:
                    return UnitConverterMetricTorque.NewtonCentimeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.NewtonMillimeter:
                    return UnitConverterMetricTorque.NewtonMillimeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.KilogramForceMeter:
                    return UnitConverterMetricTorque.KilogramForceMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.KilogramForceCentimeter:
                    return UnitConverterMetricTorque.KilogramForceCentimeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.GramForceCentimeter:
                    return UnitConverterMetricTorque.GramForceCentimeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.DyneMeter:
                    return UnitConverterScientificTorque.DyneMeterToNewtonMeter(value);
                case UnitConverterTorqueUnit.PoundForceYard:
                    return UnitConverterImperialTorque.PoundForceYardToNewtonMeter(value);
                case UnitConverterTorqueUnit.OunceForceFoot:
                    return UnitConverterImperialTorque.OunceForceFootToNewtonMeter(value);
                case UnitConverterTorqueUnit.PoundalFoot:
                    return UnitConverterImperialTorque.PoundalFootToNewtonMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported torque unit.");
            }
        }

        public static double FromNewtonMeter(double baseValue, UnitConverterTorqueUnit to)
        {
            switch (to)
            {
                case UnitConverterTorqueUnit.NewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToNewtonMeter(baseValue);
                case UnitConverterTorqueUnit.KilonewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToKilonewtonMeter(baseValue);
                case UnitConverterTorqueUnit.DyneCentimeter:
                    return UnitConverterScientificTorque.NewtonMeterToDyneCentimeter(baseValue);
                case UnitConverterTorqueUnit.PoundForceFoot:
                    return UnitConverterImperialTorque.NewtonMeterToPoundForceFoot(baseValue);
                case UnitConverterTorqueUnit.PoundForceInch:
                    return UnitConverterImperialTorque.NewtonMeterToPoundForceInch(baseValue);
                case UnitConverterTorqueUnit.OunceForceInch:
                    return UnitConverterImperialTorque.NewtonMeterToOunceForceInch(baseValue);
                case UnitConverterTorqueUnit.MillinewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToMillinewtonMeter(baseValue);
                case UnitConverterTorqueUnit.MicronewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToMicronewtonMeter(baseValue);
                case UnitConverterTorqueUnit.MeganewtonMeter:
                    return UnitConverterMetricTorque.NewtonMeterToMeganewtonMeter(baseValue);
                case UnitConverterTorqueUnit.NewtonCentimeter:
                    return UnitConverterMetricTorque.NewtonMeterToNewtonCentimeter(baseValue);
                case UnitConverterTorqueUnit.NewtonMillimeter:
                    return UnitConverterMetricTorque.NewtonMeterToNewtonMillimeter(baseValue);
                case UnitConverterTorqueUnit.KilogramForceMeter:
                    return UnitConverterMetricTorque.NewtonMeterToKilogramForceMeter(baseValue);
                case UnitConverterTorqueUnit.KilogramForceCentimeter:
                    return UnitConverterMetricTorque.NewtonMeterToKilogramForceCentimeter(baseValue);
                case UnitConverterTorqueUnit.GramForceCentimeter:
                    return UnitConverterMetricTorque.NewtonMeterToGramForceCentimeter(baseValue);
                case UnitConverterTorqueUnit.DyneMeter:
                    return UnitConverterScientificTorque.NewtonMeterToDyneMeter(baseValue);
                case UnitConverterTorqueUnit.PoundForceYard:
                    return UnitConverterImperialTorque.NewtonMeterToPoundForceYard(baseValue);
                case UnitConverterTorqueUnit.OunceForceFoot:
                    return UnitConverterImperialTorque.NewtonMeterToOunceForceFoot(baseValue);
                case UnitConverterTorqueUnit.PoundalFoot:
                    return UnitConverterImperialTorque.NewtonMeterToPoundalFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported torque unit.");
            }
        }

        public static string GetSymbol(UnitConverterTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorqueUnit.NewtonMeter:
                    return "N·m";
                case UnitConverterTorqueUnit.KilonewtonMeter:
                    return "kN·m";
                case UnitConverterTorqueUnit.DyneCentimeter:
                    return "dyn·cm";
                case UnitConverterTorqueUnit.PoundForceFoot:
                    return "lbf·ft";
                case UnitConverterTorqueUnit.PoundForceInch:
                    return "lbf·in";
                case UnitConverterTorqueUnit.OunceForceInch:
                    return "ozf·in";
                case UnitConverterTorqueUnit.MillinewtonMeter:
                    return "mN·m";
                case UnitConverterTorqueUnit.MicronewtonMeter:
                    return "µN·m";
                case UnitConverterTorqueUnit.MeganewtonMeter:
                    return "MN·m";
                case UnitConverterTorqueUnit.NewtonCentimeter:
                    return "N·cm";
                case UnitConverterTorqueUnit.NewtonMillimeter:
                    return "N·mm";
                case UnitConverterTorqueUnit.KilogramForceMeter:
                    return "kgf·m";
                case UnitConverterTorqueUnit.KilogramForceCentimeter:
                    return "kgf·cm";
                case UnitConverterTorqueUnit.GramForceCentimeter:
                    return "gf·cm";
                case UnitConverterTorqueUnit.DyneMeter:
                    return "dyn·m";
                case UnitConverterTorqueUnit.PoundForceYard:
                    return "lbf·yd";
                case UnitConverterTorqueUnit.OunceForceFoot:
                    return "ozf·ft";
                case UnitConverterTorqueUnit.PoundalFoot:
                    return "pdl·ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorqueUnit.NewtonMeter:
                    return "newton-meter";
                case UnitConverterTorqueUnit.KilonewtonMeter:
                    return "kilonewton-meter";
                case UnitConverterTorqueUnit.DyneCentimeter:
                    return "dyne-centimeter";
                case UnitConverterTorqueUnit.PoundForceFoot:
                    return "pound-force foot";
                case UnitConverterTorqueUnit.PoundForceInch:
                    return "pound-force inch";
                case UnitConverterTorqueUnit.OunceForceInch:
                    return "ounce-force inch";
                case UnitConverterTorqueUnit.MillinewtonMeter:
                    return "Millinewton Meter";
                case UnitConverterTorqueUnit.MicronewtonMeter:
                    return "Micronewton Meter";
                case UnitConverterTorqueUnit.MeganewtonMeter:
                    return "Meganewton Meter";
                case UnitConverterTorqueUnit.NewtonCentimeter:
                    return "Newton Centimeter";
                case UnitConverterTorqueUnit.NewtonMillimeter:
                    return "Newton Millimeter";
                case UnitConverterTorqueUnit.KilogramForceMeter:
                    return "Kilogram Force Meter";
                case UnitConverterTorqueUnit.KilogramForceCentimeter:
                    return "Kilogram Force Centimeter";
                case UnitConverterTorqueUnit.GramForceCentimeter:
                    return "Gram Force Centimeter";
                case UnitConverterTorqueUnit.DyneMeter:
                    return "Dyne Meter";
                case UnitConverterTorqueUnit.PoundForceYard:
                    return "Pound Force Yard";
                case UnitConverterTorqueUnit.OunceForceFoot:
                    return "Ounce Force Foot";
                case UnitConverterTorqueUnit.PoundalFoot:
                    return "Poundal Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorqueUnit.NewtonMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.KilonewtonMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.DyneCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTorqueUnit.PoundForceFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorqueUnit.PoundForceInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorqueUnit.OunceForceInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorqueUnit.MillinewtonMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.MicronewtonMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.MeganewtonMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.NewtonCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.NewtonMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.KilogramForceMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.KilogramForceCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.GramForceCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorqueUnit.DyneMeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterTorqueUnit.PoundForceYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorqueUnit.OunceForceFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorqueUnit.PoundalFoot:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterTorqueUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterTorqueUnit.NewtonMeter, UnitConverterTorqueUnit.KilonewtonMeter, UnitConverterTorqueUnit.MillinewtonMeter, UnitConverterTorqueUnit.MicronewtonMeter, UnitConverterTorqueUnit.MeganewtonMeter, UnitConverterTorqueUnit.NewtonCentimeter, UnitConverterTorqueUnit.NewtonMillimeter, UnitConverterTorqueUnit.KilogramForceMeter, UnitConverterTorqueUnit.KilogramForceCentimeter, UnitConverterTorqueUnit.GramForceCentimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterTorqueUnit.DyneCentimeter, UnitConverterTorqueUnit.DyneMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterTorqueUnit.PoundForceFoot, UnitConverterTorqueUnit.PoundForceInch, UnitConverterTorqueUnit.OunceForceInch, UnitConverterTorqueUnit.PoundForceYard, UnitConverterTorqueUnit.OunceForceFoot, UnitConverterTorqueUnit.PoundalFoot };
                default:
                    return new[] { UnitConverterTorqueUnit.NewtonMeter, UnitConverterTorqueUnit.KilonewtonMeter, UnitConverterTorqueUnit.DyneCentimeter, UnitConverterTorqueUnit.PoundForceFoot, UnitConverterTorqueUnit.PoundForceInch, UnitConverterTorqueUnit.OunceForceInch, UnitConverterTorqueUnit.MillinewtonMeter, UnitConverterTorqueUnit.MicronewtonMeter, UnitConverterTorqueUnit.MeganewtonMeter, UnitConverterTorqueUnit.NewtonCentimeter, UnitConverterTorqueUnit.NewtonMillimeter, UnitConverterTorqueUnit.KilogramForceMeter, UnitConverterTorqueUnit.KilogramForceCentimeter, UnitConverterTorqueUnit.GramForceCentimeter, UnitConverterTorqueUnit.DyneMeter, UnitConverterTorqueUnit.PoundForceYard, UnitConverterTorqueUnit.OunceForceFoot, UnitConverterTorqueUnit.PoundalFoot };
            }
        }
    }
}
