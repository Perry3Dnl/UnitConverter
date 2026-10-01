namespace UnitConverter.Impulse
{
    using UnitConverter.Impulse.Metric;
    using UnitConverter.Impulse.Scientific;
    using UnitConverter.Impulse.Imperial;

    public enum UnitConverterImpulseUnit
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

    public static class UnitConverterImpulse
    {
        public static double Convert(double value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            double baseValue = ToNewtonSecond(value, from);
            return FromNewtonSecond(baseValue, to);
        }

        public static double ToNewtonSecond(double value, UnitConverterImpulseUnit from)
        {
            switch (from)
            {
                case UnitConverterImpulseUnit.NewtonSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.KilonewtonSecond:
                    return UnitConverterMetricImpulse.KilonewtonSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.DyneSecond:
                    return UnitConverterScientificImpulse.DyneSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.PoundForceSecond:
                    return UnitConverterImperialImpulse.PoundForceSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.KilogramForceSecond:
                    return UnitConverterMetricImpulse.KilogramForceSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.MillinewtonSecond:
                    return UnitConverterMetricImpulse.MillinewtonSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.MeganewtonSecond:
                    return UnitConverterMetricImpulse.MeganewtonSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.NewtonMinute:
                    return UnitConverterMetricImpulse.NewtonMinuteToNewtonSecond(value);
                case UnitConverterImpulseUnit.KilogramMeterPerSecond:
                    return UnitConverterMetricImpulse.KilogramMeterPerSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.GramCentimeterPerSecond:
                    return UnitConverterMetricImpulse.GramCentimeterPerSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.OunceForceSecond:
                    return UnitConverterImperialImpulse.OunceForceSecondToNewtonSecond(value);
                case UnitConverterImpulseUnit.PoundForceMinute:
                    return UnitConverterImperialImpulse.PoundForceMinuteToNewtonSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported impulse unit.");
            }
        }

        public static double FromNewtonSecond(double baseValue, UnitConverterImpulseUnit to)
        {
            switch (to)
            {
                case UnitConverterImpulseUnit.NewtonSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToNewtonSecond(baseValue);
                case UnitConverterImpulseUnit.KilonewtonSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToKilonewtonSecond(baseValue);
                case UnitConverterImpulseUnit.DyneSecond:
                    return UnitConverterScientificImpulse.NewtonSecondToDyneSecond(baseValue);
                case UnitConverterImpulseUnit.PoundForceSecond:
                    return UnitConverterImperialImpulse.NewtonSecondToPoundForceSecond(baseValue);
                case UnitConverterImpulseUnit.KilogramForceSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToKilogramForceSecond(baseValue);
                case UnitConverterImpulseUnit.MillinewtonSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToMillinewtonSecond(baseValue);
                case UnitConverterImpulseUnit.MeganewtonSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToMeganewtonSecond(baseValue);
                case UnitConverterImpulseUnit.NewtonMinute:
                    return UnitConverterMetricImpulse.NewtonSecondToNewtonMinute(baseValue);
                case UnitConverterImpulseUnit.KilogramMeterPerSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToKilogramMeterPerSecond(baseValue);
                case UnitConverterImpulseUnit.GramCentimeterPerSecond:
                    return UnitConverterMetricImpulse.NewtonSecondToGramCentimeterPerSecond(baseValue);
                case UnitConverterImpulseUnit.OunceForceSecond:
                    return UnitConverterImperialImpulse.NewtonSecondToOunceForceSecond(baseValue);
                case UnitConverterImpulseUnit.PoundForceMinute:
                    return UnitConverterImperialImpulse.NewtonSecondToPoundForceMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported impulse unit.");
            }
        }

        public static string GetSymbol(UnitConverterImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterImpulseUnit.NewtonSecond:
                    return "N·s";
                case UnitConverterImpulseUnit.KilonewtonSecond:
                    return "kN·s";
                case UnitConverterImpulseUnit.DyneSecond:
                    return "dyn·s";
                case UnitConverterImpulseUnit.PoundForceSecond:
                    return "lbf·s";
                case UnitConverterImpulseUnit.KilogramForceSecond:
                    return "kgf·s";
                case UnitConverterImpulseUnit.MillinewtonSecond:
                    return "mN·s";
                case UnitConverterImpulseUnit.MeganewtonSecond:
                    return "MN·s";
                case UnitConverterImpulseUnit.NewtonMinute:
                    return "N·min";
                case UnitConverterImpulseUnit.KilogramMeterPerSecond:
                    return "kg·m/s";
                case UnitConverterImpulseUnit.GramCentimeterPerSecond:
                    return "g·cm/s";
                case UnitConverterImpulseUnit.OunceForceSecond:
                    return "ozf·s";
                case UnitConverterImpulseUnit.PoundForceMinute:
                    return "lbf·min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterImpulseUnit.NewtonSecond:
                    return "Newton Second";
                case UnitConverterImpulseUnit.KilonewtonSecond:
                    return "Kilonewton Second";
                case UnitConverterImpulseUnit.DyneSecond:
                    return "Dyne Second";
                case UnitConverterImpulseUnit.PoundForceSecond:
                    return "Pound Force Second";
                case UnitConverterImpulseUnit.KilogramForceSecond:
                    return "Kilogram Force Second";
                case UnitConverterImpulseUnit.MillinewtonSecond:
                    return "Millinewton Second";
                case UnitConverterImpulseUnit.MeganewtonSecond:
                    return "Meganewton Second";
                case UnitConverterImpulseUnit.NewtonMinute:
                    return "Newton Minute";
                case UnitConverterImpulseUnit.KilogramMeterPerSecond:
                    return "Kilogram Meter Per Second";
                case UnitConverterImpulseUnit.GramCentimeterPerSecond:
                    return "Gram Centimeter Per Second";
                case UnitConverterImpulseUnit.OunceForceSecond:
                    return "Ounce Force Second";
                case UnitConverterImpulseUnit.PoundForceMinute:
                    return "Pound Force Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterImpulseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterImpulseUnit.NewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.KilonewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.DyneSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterImpulseUnit.PoundForceSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterImpulseUnit.KilogramForceSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.MillinewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.MeganewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.NewtonMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.KilogramMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.GramCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterImpulseUnit.OunceForceSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterImpulseUnit.PoundForceMinute:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterImpulseUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterImpulseUnit.NewtonSecond, UnitConverterImpulseUnit.KilonewtonSecond, UnitConverterImpulseUnit.KilogramForceSecond, UnitConverterImpulseUnit.MillinewtonSecond, UnitConverterImpulseUnit.MeganewtonSecond, UnitConverterImpulseUnit.NewtonMinute, UnitConverterImpulseUnit.KilogramMeterPerSecond, UnitConverterImpulseUnit.GramCentimeterPerSecond };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterImpulseUnit.DyneSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterImpulseUnit.PoundForceSecond, UnitConverterImpulseUnit.OunceForceSecond, UnitConverterImpulseUnit.PoundForceMinute };
                default:
                    return new[] { UnitConverterImpulseUnit.NewtonSecond, UnitConverterImpulseUnit.KilonewtonSecond, UnitConverterImpulseUnit.DyneSecond, UnitConverterImpulseUnit.PoundForceSecond, UnitConverterImpulseUnit.KilogramForceSecond, UnitConverterImpulseUnit.MillinewtonSecond, UnitConverterImpulseUnit.MeganewtonSecond, UnitConverterImpulseUnit.NewtonMinute, UnitConverterImpulseUnit.KilogramMeterPerSecond, UnitConverterImpulseUnit.GramCentimeterPerSecond, UnitConverterImpulseUnit.OunceForceSecond, UnitConverterImpulseUnit.PoundForceMinute };
            }
        }
    }
}
