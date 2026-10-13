namespace UnitTools.Momentum
{
    using UnitTools.Momentum.Metric;
    using UnitTools.Momentum.Imperial;

    public enum UnitToolsMomentumUnit
    {
        KilogramMeterPerSecond = 0,
        NewtonSecond = 1,
        GramCentimeterPerSecond = 2,
        PoundFootPerSecond = 3,
        SlugFootPerSecond = 4,
        KilogramKilometerPerSecond = 5,
        GramMeterPerSecond = 6,
        MilligramMeterPerSecond = 7,
        TonneMeterPerSecond = 8,
        PoundInchPerSecond = 9,
        OunceFootPerSecond = 10,
        KilonewtonSecond = 11,
        PoundForceSecond = 12,
    }

    public static class UnitToolsMomentum
    {
        public static double Convert(double value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            double baseValue = ToKilogramMeterPerSecond(value, from);
            return FromKilogramMeterPerSecond(baseValue, to);
        }

        public static double ToKilogramMeterPerSecond(double value, UnitToolsMomentumUnit from)
        {
            switch (from)
            {
                case UnitToolsMomentumUnit.KilogramMeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.NewtonSecond:
                    return UnitToolsMetricMomentum.NewtonSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.GramCentimeterPerSecond:
                    return UnitToolsMetricMomentum.GramCentimeterPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.PoundFootPerSecond:
                    return UnitToolsImperialMomentum.PoundFootPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.SlugFootPerSecond:
                    return UnitToolsImperialMomentum.SlugFootPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.KilogramKilometerPerSecond:
                    return UnitToolsMetricMomentum.KilogramKilometerPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.GramMeterPerSecond:
                    return UnitToolsMetricMomentum.GramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.MilligramMeterPerSecond:
                    return UnitToolsMetricMomentum.MilligramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.TonneMeterPerSecond:
                    return UnitToolsMetricMomentum.TonneMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.PoundInchPerSecond:
                    return UnitToolsImperialMomentum.PoundInchPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.OunceFootPerSecond:
                    return UnitToolsImperialMomentum.OunceFootPerSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.KilonewtonSecond:
                    return UnitToolsMetricMomentum.KilonewtonSecondToKilogramMeterPerSecond(value);
                case UnitToolsMomentumUnit.PoundForceSecond:
                    return UnitToolsImperialMomentum.PoundForceSecondToKilogramMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported momentum unit.");
            }
        }

        public static double FromKilogramMeterPerSecond(double baseValue, UnitToolsMomentumUnit to)
        {
            switch (to)
            {
                case UnitToolsMomentumUnit.KilogramMeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToKilogramMeterPerSecond(baseValue);
                case UnitToolsMomentumUnit.NewtonSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToNewtonSecond(baseValue);
                case UnitToolsMomentumUnit.GramCentimeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToGramCentimeterPerSecond(baseValue);
                case UnitToolsMomentumUnit.PoundFootPerSecond:
                    return UnitToolsImperialMomentum.KilogramMeterPerSecondToPoundFootPerSecond(baseValue);
                case UnitToolsMomentumUnit.SlugFootPerSecond:
                    return UnitToolsImperialMomentum.KilogramMeterPerSecondToSlugFootPerSecond(baseValue);
                case UnitToolsMomentumUnit.KilogramKilometerPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToKilogramKilometerPerSecond(baseValue);
                case UnitToolsMomentumUnit.GramMeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToGramMeterPerSecond(baseValue);
                case UnitToolsMomentumUnit.MilligramMeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToMilligramMeterPerSecond(baseValue);
                case UnitToolsMomentumUnit.TonneMeterPerSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToTonneMeterPerSecond(baseValue);
                case UnitToolsMomentumUnit.PoundInchPerSecond:
                    return UnitToolsImperialMomentum.KilogramMeterPerSecondToPoundInchPerSecond(baseValue);
                case UnitToolsMomentumUnit.OunceFootPerSecond:
                    return UnitToolsImperialMomentum.KilogramMeterPerSecondToOunceFootPerSecond(baseValue);
                case UnitToolsMomentumUnit.KilonewtonSecond:
                    return UnitToolsMetricMomentum.KilogramMeterPerSecondToKilonewtonSecond(baseValue);
                case UnitToolsMomentumUnit.PoundForceSecond:
                    return UnitToolsImperialMomentum.KilogramMeterPerSecondToPoundForceSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported momentum unit.");
            }
        }

        public static string GetSymbol(UnitToolsMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentumUnit.KilogramMeterPerSecond:
                    return "kg·m/s";
                case UnitToolsMomentumUnit.NewtonSecond:
                    return "N·s";
                case UnitToolsMomentumUnit.GramCentimeterPerSecond:
                    return "g·cm/s";
                case UnitToolsMomentumUnit.PoundFootPerSecond:
                    return "lb·ft/s";
                case UnitToolsMomentumUnit.SlugFootPerSecond:
                    return "slug·ft/s";
                case UnitToolsMomentumUnit.KilogramKilometerPerSecond:
                    return "kg·km/s";
                case UnitToolsMomentumUnit.GramMeterPerSecond:
                    return "g·m/s";
                case UnitToolsMomentumUnit.MilligramMeterPerSecond:
                    return "mg·m/s";
                case UnitToolsMomentumUnit.TonneMeterPerSecond:
                    return "t·m/s";
                case UnitToolsMomentumUnit.PoundInchPerSecond:
                    return "lb·in/s";
                case UnitToolsMomentumUnit.OunceFootPerSecond:
                    return "oz·ft/s";
                case UnitToolsMomentumUnit.KilonewtonSecond:
                    return "kN·s";
                case UnitToolsMomentumUnit.PoundForceSecond:
                    return "lbf·s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentumUnit.KilogramMeterPerSecond:
                    return "Kilogram Meter Per Second";
                case UnitToolsMomentumUnit.NewtonSecond:
                    return "Newton Second";
                case UnitToolsMomentumUnit.GramCentimeterPerSecond:
                    return "Gram Centimeter Per Second";
                case UnitToolsMomentumUnit.PoundFootPerSecond:
                    return "Pound Foot Per Second";
                case UnitToolsMomentumUnit.SlugFootPerSecond:
                    return "Slug Foot Per Second";
                case UnitToolsMomentumUnit.KilogramKilometerPerSecond:
                    return "Kilogram Kilometer Per Second";
                case UnitToolsMomentumUnit.GramMeterPerSecond:
                    return "Gram Meter Per Second";
                case UnitToolsMomentumUnit.MilligramMeterPerSecond:
                    return "Milligram Meter Per Second";
                case UnitToolsMomentumUnit.TonneMeterPerSecond:
                    return "Tonne Meter Per Second";
                case UnitToolsMomentumUnit.PoundInchPerSecond:
                    return "Pound Inch Per Second";
                case UnitToolsMomentumUnit.OunceFootPerSecond:
                    return "Ounce Foot Per Second";
                case UnitToolsMomentumUnit.KilonewtonSecond:
                    return "Kilonewton Second";
                case UnitToolsMomentumUnit.PoundForceSecond:
                    return "Pound Force Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMomentumUnit.KilogramMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.NewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.GramCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.PoundFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentumUnit.SlugFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentumUnit.KilogramKilometerPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.GramMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.MilligramMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.TonneMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.PoundInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentumUnit.OunceFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMomentumUnit.KilonewtonSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMomentumUnit.PoundForceSecond:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMomentumUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMomentumUnit.KilogramMeterPerSecond, UnitToolsMomentumUnit.NewtonSecond, UnitToolsMomentumUnit.GramCentimeterPerSecond, UnitToolsMomentumUnit.KilogramKilometerPerSecond, UnitToolsMomentumUnit.GramMeterPerSecond, UnitToolsMomentumUnit.MilligramMeterPerSecond, UnitToolsMomentumUnit.TonneMeterPerSecond, UnitToolsMomentumUnit.KilonewtonSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMomentumUnit.PoundFootPerSecond, UnitToolsMomentumUnit.SlugFootPerSecond, UnitToolsMomentumUnit.PoundInchPerSecond, UnitToolsMomentumUnit.OunceFootPerSecond, UnitToolsMomentumUnit.PoundForceSecond };
                default:
                    return new[] { UnitToolsMomentumUnit.KilogramMeterPerSecond, UnitToolsMomentumUnit.NewtonSecond, UnitToolsMomentumUnit.GramCentimeterPerSecond, UnitToolsMomentumUnit.PoundFootPerSecond, UnitToolsMomentumUnit.SlugFootPerSecond, UnitToolsMomentumUnit.KilogramKilometerPerSecond, UnitToolsMomentumUnit.GramMeterPerSecond, UnitToolsMomentumUnit.MilligramMeterPerSecond, UnitToolsMomentumUnit.TonneMeterPerSecond, UnitToolsMomentumUnit.PoundInchPerSecond, UnitToolsMomentumUnit.OunceFootPerSecond, UnitToolsMomentumUnit.KilonewtonSecond, UnitToolsMomentumUnit.PoundForceSecond };
            }
        }
    }
}
