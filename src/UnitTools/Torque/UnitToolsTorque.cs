namespace UnitTools.Torque
{
    using UnitTools.Torque.Metric;
    using UnitTools.Torque.Scientific;
    using UnitTools.Torque.Imperial;

    public enum UnitToolsTorqueUnit
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

    public static class UnitToolsTorque
    {
        public static double Convert(double value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            double baseValue = ToNewtonMeter(value, from);
            return FromNewtonMeter(baseValue, to);
        }

        public static double ToNewtonMeter(double value, UnitToolsTorqueUnit from)
        {
            switch (from)
            {
                case UnitToolsTorqueUnit.NewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.KilonewtonMeter:
                    return UnitToolsMetricTorque.KilonewtonMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.DyneCentimeter:
                    return UnitToolsScientificTorque.DyneCentimeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.PoundForceFoot:
                    return UnitToolsImperialTorque.PoundForceFootToNewtonMeter(value);
                case UnitToolsTorqueUnit.PoundForceInch:
                    return UnitToolsImperialTorque.PoundForceInchToNewtonMeter(value);
                case UnitToolsTorqueUnit.OunceForceInch:
                    return UnitToolsImperialTorque.OunceForceInchToNewtonMeter(value);
                case UnitToolsTorqueUnit.MillinewtonMeter:
                    return UnitToolsMetricTorque.MillinewtonMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.MicronewtonMeter:
                    return UnitToolsMetricTorque.MicronewtonMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.MeganewtonMeter:
                    return UnitToolsMetricTorque.MeganewtonMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.NewtonCentimeter:
                    return UnitToolsMetricTorque.NewtonCentimeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.NewtonMillimeter:
                    return UnitToolsMetricTorque.NewtonMillimeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.KilogramForceMeter:
                    return UnitToolsMetricTorque.KilogramForceMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.KilogramForceCentimeter:
                    return UnitToolsMetricTorque.KilogramForceCentimeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.GramForceCentimeter:
                    return UnitToolsMetricTorque.GramForceCentimeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.DyneMeter:
                    return UnitToolsScientificTorque.DyneMeterToNewtonMeter(value);
                case UnitToolsTorqueUnit.PoundForceYard:
                    return UnitToolsImperialTorque.PoundForceYardToNewtonMeter(value);
                case UnitToolsTorqueUnit.OunceForceFoot:
                    return UnitToolsImperialTorque.OunceForceFootToNewtonMeter(value);
                case UnitToolsTorqueUnit.PoundalFoot:
                    return UnitToolsImperialTorque.PoundalFootToNewtonMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported torque unit.");
            }
        }

        public static double FromNewtonMeter(double baseValue, UnitToolsTorqueUnit to)
        {
            switch (to)
            {
                case UnitToolsTorqueUnit.NewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToNewtonMeter(baseValue);
                case UnitToolsTorqueUnit.KilonewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToKilonewtonMeter(baseValue);
                case UnitToolsTorqueUnit.DyneCentimeter:
                    return UnitToolsScientificTorque.NewtonMeterToDyneCentimeter(baseValue);
                case UnitToolsTorqueUnit.PoundForceFoot:
                    return UnitToolsImperialTorque.NewtonMeterToPoundForceFoot(baseValue);
                case UnitToolsTorqueUnit.PoundForceInch:
                    return UnitToolsImperialTorque.NewtonMeterToPoundForceInch(baseValue);
                case UnitToolsTorqueUnit.OunceForceInch:
                    return UnitToolsImperialTorque.NewtonMeterToOunceForceInch(baseValue);
                case UnitToolsTorqueUnit.MillinewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToMillinewtonMeter(baseValue);
                case UnitToolsTorqueUnit.MicronewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToMicronewtonMeter(baseValue);
                case UnitToolsTorqueUnit.MeganewtonMeter:
                    return UnitToolsMetricTorque.NewtonMeterToMeganewtonMeter(baseValue);
                case UnitToolsTorqueUnit.NewtonCentimeter:
                    return UnitToolsMetricTorque.NewtonMeterToNewtonCentimeter(baseValue);
                case UnitToolsTorqueUnit.NewtonMillimeter:
                    return UnitToolsMetricTorque.NewtonMeterToNewtonMillimeter(baseValue);
                case UnitToolsTorqueUnit.KilogramForceMeter:
                    return UnitToolsMetricTorque.NewtonMeterToKilogramForceMeter(baseValue);
                case UnitToolsTorqueUnit.KilogramForceCentimeter:
                    return UnitToolsMetricTorque.NewtonMeterToKilogramForceCentimeter(baseValue);
                case UnitToolsTorqueUnit.GramForceCentimeter:
                    return UnitToolsMetricTorque.NewtonMeterToGramForceCentimeter(baseValue);
                case UnitToolsTorqueUnit.DyneMeter:
                    return UnitToolsScientificTorque.NewtonMeterToDyneMeter(baseValue);
                case UnitToolsTorqueUnit.PoundForceYard:
                    return UnitToolsImperialTorque.NewtonMeterToPoundForceYard(baseValue);
                case UnitToolsTorqueUnit.OunceForceFoot:
                    return UnitToolsImperialTorque.NewtonMeterToOunceForceFoot(baseValue);
                case UnitToolsTorqueUnit.PoundalFoot:
                    return UnitToolsImperialTorque.NewtonMeterToPoundalFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported torque unit.");
            }
        }

        public static string GetSymbol(UnitToolsTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorqueUnit.NewtonMeter:
                    return "N·m";
                case UnitToolsTorqueUnit.KilonewtonMeter:
                    return "kN·m";
                case UnitToolsTorqueUnit.DyneCentimeter:
                    return "dyn·cm";
                case UnitToolsTorqueUnit.PoundForceFoot:
                    return "lbf·ft";
                case UnitToolsTorqueUnit.PoundForceInch:
                    return "lbf·in";
                case UnitToolsTorqueUnit.OunceForceInch:
                    return "ozf·in";
                case UnitToolsTorqueUnit.MillinewtonMeter:
                    return "mN·m";
                case UnitToolsTorqueUnit.MicronewtonMeter:
                    return "µN·m";
                case UnitToolsTorqueUnit.MeganewtonMeter:
                    return "MN·m";
                case UnitToolsTorqueUnit.NewtonCentimeter:
                    return "N·cm";
                case UnitToolsTorqueUnit.NewtonMillimeter:
                    return "N·mm";
                case UnitToolsTorqueUnit.KilogramForceMeter:
                    return "kgf·m";
                case UnitToolsTorqueUnit.KilogramForceCentimeter:
                    return "kgf·cm";
                case UnitToolsTorqueUnit.GramForceCentimeter:
                    return "gf·cm";
                case UnitToolsTorqueUnit.DyneMeter:
                    return "dyn·m";
                case UnitToolsTorqueUnit.PoundForceYard:
                    return "lbf·yd";
                case UnitToolsTorqueUnit.OunceForceFoot:
                    return "ozf·ft";
                case UnitToolsTorqueUnit.PoundalFoot:
                    return "pdl·ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorqueUnit.NewtonMeter:
                    return "newton-meter";
                case UnitToolsTorqueUnit.KilonewtonMeter:
                    return "kilonewton-meter";
                case UnitToolsTorqueUnit.DyneCentimeter:
                    return "dyne-centimeter";
                case UnitToolsTorqueUnit.PoundForceFoot:
                    return "pound-force foot";
                case UnitToolsTorqueUnit.PoundForceInch:
                    return "pound-force inch";
                case UnitToolsTorqueUnit.OunceForceInch:
                    return "ounce-force inch";
                case UnitToolsTorqueUnit.MillinewtonMeter:
                    return "Millinewton Meter";
                case UnitToolsTorqueUnit.MicronewtonMeter:
                    return "Micronewton Meter";
                case UnitToolsTorqueUnit.MeganewtonMeter:
                    return "Meganewton Meter";
                case UnitToolsTorqueUnit.NewtonCentimeter:
                    return "Newton Centimeter";
                case UnitToolsTorqueUnit.NewtonMillimeter:
                    return "Newton Millimeter";
                case UnitToolsTorqueUnit.KilogramForceMeter:
                    return "Kilogram Force Meter";
                case UnitToolsTorqueUnit.KilogramForceCentimeter:
                    return "Kilogram Force Centimeter";
                case UnitToolsTorqueUnit.GramForceCentimeter:
                    return "Gram Force Centimeter";
                case UnitToolsTorqueUnit.DyneMeter:
                    return "Dyne Meter";
                case UnitToolsTorqueUnit.PoundForceYard:
                    return "Pound Force Yard";
                case UnitToolsTorqueUnit.OunceForceFoot:
                    return "Ounce Force Foot";
                case UnitToolsTorqueUnit.PoundalFoot:
                    return "Poundal Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsTorqueUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorqueUnit.NewtonMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.KilonewtonMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.DyneCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTorqueUnit.PoundForceFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorqueUnit.PoundForceInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorqueUnit.OunceForceInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorqueUnit.MillinewtonMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.MicronewtonMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.MeganewtonMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.NewtonCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.NewtonMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.KilogramForceMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.KilogramForceCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.GramForceCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorqueUnit.DyneMeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsTorqueUnit.PoundForceYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorqueUnit.OunceForceFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorqueUnit.PoundalFoot:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsTorqueUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsTorqueUnit.NewtonMeter, UnitToolsTorqueUnit.KilonewtonMeter, UnitToolsTorqueUnit.MillinewtonMeter, UnitToolsTorqueUnit.MicronewtonMeter, UnitToolsTorqueUnit.MeganewtonMeter, UnitToolsTorqueUnit.NewtonCentimeter, UnitToolsTorqueUnit.NewtonMillimeter, UnitToolsTorqueUnit.KilogramForceMeter, UnitToolsTorqueUnit.KilogramForceCentimeter, UnitToolsTorqueUnit.GramForceCentimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsTorqueUnit.DyneCentimeter, UnitToolsTorqueUnit.DyneMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsTorqueUnit.PoundForceFoot, UnitToolsTorqueUnit.PoundForceInch, UnitToolsTorqueUnit.OunceForceInch, UnitToolsTorqueUnit.PoundForceYard, UnitToolsTorqueUnit.OunceForceFoot, UnitToolsTorqueUnit.PoundalFoot };
                default:
                    return new[] { UnitToolsTorqueUnit.NewtonMeter, UnitToolsTorqueUnit.KilonewtonMeter, UnitToolsTorqueUnit.DyneCentimeter, UnitToolsTorqueUnit.PoundForceFoot, UnitToolsTorqueUnit.PoundForceInch, UnitToolsTorqueUnit.OunceForceInch, UnitToolsTorqueUnit.MillinewtonMeter, UnitToolsTorqueUnit.MicronewtonMeter, UnitToolsTorqueUnit.MeganewtonMeter, UnitToolsTorqueUnit.NewtonCentimeter, UnitToolsTorqueUnit.NewtonMillimeter, UnitToolsTorqueUnit.KilogramForceMeter, UnitToolsTorqueUnit.KilogramForceCentimeter, UnitToolsTorqueUnit.GramForceCentimeter, UnitToolsTorqueUnit.DyneMeter, UnitToolsTorqueUnit.PoundForceYard, UnitToolsTorqueUnit.OunceForceFoot, UnitToolsTorqueUnit.PoundalFoot };
            }
        }
    }
}
