namespace UnitTools.Impulse
{
    using UnitTools.Impulse.Metric;
    using UnitTools.Impulse.Scientific;
    using UnitTools.Impulse.Imperial;

    public enum UnitToolsImpulseUnit
    {
        NewtonSecond = 0,
        KilonewtonSecond = 1,
        DyneSecond = 2,
        PoundForceSecond = 3,
        KilogramForceSecond = 4,
        MillinewtonSecond = 5,
        MeganewtonSecond = 6,
        NewtonMinute = 7,
        KilogramMeterPerSecond = 8,
        GramCentimeterPerSecond = 9,
        OunceForceSecond = 10,
        PoundForceMinute = 11,
    }

    public static class UnitToolsImpulse
    {
        public static double Convert(double value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            double baseValue = ToNewtonSecond(value, from);
            return FromNewtonSecond(baseValue, to);
        }

        public static double ToNewtonSecond(double value, UnitToolsImpulseUnit from)
        {
            switch (from)
            {
                case UnitToolsImpulseUnit.NewtonSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.KilonewtonSecond:
                    return UnitToolsMetricImpulse.KilonewtonSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.DyneSecond:
                    return UnitToolsScientificImpulse.DyneSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.PoundForceSecond:
                    return UnitToolsImperialImpulse.PoundForceSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.KilogramForceSecond:
                    return UnitToolsMetricImpulse.KilogramForceSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.MillinewtonSecond:
                    return UnitToolsMetricImpulse.MillinewtonSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.MeganewtonSecond:
                    return UnitToolsMetricImpulse.MeganewtonSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.NewtonMinute:
                    return UnitToolsMetricImpulse.NewtonMinuteToNewtonSecond(value);
                case UnitToolsImpulseUnit.KilogramMeterPerSecond:
                    return UnitToolsMetricImpulse.KilogramMeterPerSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.GramCentimeterPerSecond:
                    return UnitToolsMetricImpulse.GramCentimeterPerSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.OunceForceSecond:
                    return UnitToolsImperialImpulse.OunceForceSecondToNewtonSecond(value);
                case UnitToolsImpulseUnit.PoundForceMinute:
                    return UnitToolsImperialImpulse.PoundForceMinuteToNewtonSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported impulse unit.");
            }
        }

        public static double FromNewtonSecond(double baseValue, UnitToolsImpulseUnit to)
        {
            switch (to)
            {
                case UnitToolsImpulseUnit.NewtonSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToNewtonSecond(baseValue);
                case UnitToolsImpulseUnit.KilonewtonSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToKilonewtonSecond(baseValue);
                case UnitToolsImpulseUnit.DyneSecond:
                    return UnitToolsScientificImpulse.NewtonSecondToDyneSecond(baseValue);
                case UnitToolsImpulseUnit.PoundForceSecond:
                    return UnitToolsImperialImpulse.NewtonSecondToPoundForceSecond(baseValue);
                case UnitToolsImpulseUnit.KilogramForceSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToKilogramForceSecond(baseValue);
                case UnitToolsImpulseUnit.MillinewtonSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToMillinewtonSecond(baseValue);
                case UnitToolsImpulseUnit.MeganewtonSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToMeganewtonSecond(baseValue);
                case UnitToolsImpulseUnit.NewtonMinute:
                    return UnitToolsMetricImpulse.NewtonSecondToNewtonMinute(baseValue);
                case UnitToolsImpulseUnit.KilogramMeterPerSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToKilogramMeterPerSecond(baseValue);
                case UnitToolsImpulseUnit.GramCentimeterPerSecond:
                    return UnitToolsMetricImpulse.NewtonSecondToGramCentimeterPerSecond(baseValue);
                case UnitToolsImpulseUnit.OunceForceSecond:
                    return UnitToolsImperialImpulse.NewtonSecondToOunceForceSecond(baseValue);
                case UnitToolsImpulseUnit.PoundForceMinute:
                    return UnitToolsImperialImpulse.NewtonSecondToPoundForceMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported impulse unit.");
            }
        }

        public static string GetSymbol(UnitToolsImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsImpulseUnit.NewtonSecond:
                    return "N·s";
                case UnitToolsImpulseUnit.KilonewtonSecond:
                    return "kN·s";
                case UnitToolsImpulseUnit.DyneSecond:
                    return "dyn·s";
                case UnitToolsImpulseUnit.PoundForceSecond:
                    return "lbf·s";
                case UnitToolsImpulseUnit.KilogramForceSecond:
                    return "kgf·s";
                case UnitToolsImpulseUnit.MillinewtonSecond:
                    return "mN·s";
                case UnitToolsImpulseUnit.MeganewtonSecond:
                    return "MN·s";
                case UnitToolsImpulseUnit.NewtonMinute:
                    return "N·min";
                case UnitToolsImpulseUnit.KilogramMeterPerSecond:
                    return "kg·m/s";
                case UnitToolsImpulseUnit.GramCentimeterPerSecond:
                    return "g·cm/s";
                case UnitToolsImpulseUnit.OunceForceSecond:
                    return "ozf·s";
                case UnitToolsImpulseUnit.PoundForceMinute:
                    return "lbf·min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsImpulseUnit.NewtonSecond:
                    return "Newton Second";
                case UnitToolsImpulseUnit.KilonewtonSecond:
                    return "Kilonewton Second";
                case UnitToolsImpulseUnit.DyneSecond:
                    return "Dyne Second";
                case UnitToolsImpulseUnit.PoundForceSecond:
                    return "Pound Force Second";
                case UnitToolsImpulseUnit.KilogramForceSecond:
                    return "Kilogram Force Second";
                case UnitToolsImpulseUnit.MillinewtonSecond:
                    return "Millinewton Second";
                case UnitToolsImpulseUnit.MeganewtonSecond:
                    return "Meganewton Second";
                case UnitToolsImpulseUnit.NewtonMinute:
                    return "Newton Minute";
                case UnitToolsImpulseUnit.KilogramMeterPerSecond:
                    return "Kilogram Meter Per Second";
                case UnitToolsImpulseUnit.GramCentimeterPerSecond:
                    return "Gram Centimeter Per Second";
                case UnitToolsImpulseUnit.OunceForceSecond:
                    return "Ounce Force Second";
                case UnitToolsImpulseUnit.PoundForceMinute:
                    return "Pound Force Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsImpulseUnit.NewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.KilonewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.DyneSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsImpulseUnit.PoundForceSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsImpulseUnit.KilogramForceSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.MillinewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.MeganewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.NewtonMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.KilogramMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.GramCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsImpulseUnit.OunceForceSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsImpulseUnit.PoundForceMinute:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsImpulseUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsImpulseUnit.NewtonSecond, UnitToolsImpulseUnit.KilonewtonSecond, UnitToolsImpulseUnit.KilogramForceSecond, UnitToolsImpulseUnit.MillinewtonSecond, UnitToolsImpulseUnit.MeganewtonSecond, UnitToolsImpulseUnit.NewtonMinute, UnitToolsImpulseUnit.KilogramMeterPerSecond, UnitToolsImpulseUnit.GramCentimeterPerSecond };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsImpulseUnit.DyneSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsImpulseUnit.PoundForceSecond, UnitToolsImpulseUnit.OunceForceSecond, UnitToolsImpulseUnit.PoundForceMinute };
                default:
                    return new[] { UnitToolsImpulseUnit.NewtonSecond, UnitToolsImpulseUnit.KilonewtonSecond, UnitToolsImpulseUnit.DyneSecond, UnitToolsImpulseUnit.PoundForceSecond, UnitToolsImpulseUnit.KilogramForceSecond, UnitToolsImpulseUnit.MillinewtonSecond, UnitToolsImpulseUnit.MeganewtonSecond, UnitToolsImpulseUnit.NewtonMinute, UnitToolsImpulseUnit.KilogramMeterPerSecond, UnitToolsImpulseUnit.GramCentimeterPerSecond, UnitToolsImpulseUnit.OunceForceSecond, UnitToolsImpulseUnit.PoundForceMinute };
            }
        }
    }
}
