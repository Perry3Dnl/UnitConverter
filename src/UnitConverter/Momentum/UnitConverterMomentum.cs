namespace UnitConverter.Momentum
{
    using UnitConverter.Momentum.Metric;
    using UnitConverter.Momentum.Imperial;

    public enum UnitConverterMomentumUnit
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

    public static class UnitConverterMomentum
    {
        public static double Convert(double value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            double baseValue = ToKilogramMeterPerSecond(value, from);
            return FromKilogramMeterPerSecond(baseValue, to);
        }

        public static double ToKilogramMeterPerSecond(double value, UnitConverterMomentumUnit from)
        {
            switch (from)
            {
                case UnitConverterMomentumUnit.KilogramMeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.NewtonSecond:
                    return UnitConverterMetricMomentum.NewtonSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.GramCentimeterPerSecond:
                    return UnitConverterMetricMomentum.GramCentimeterPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.PoundFootPerSecond:
                    return UnitConverterImperialMomentum.PoundFootPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.SlugFootPerSecond:
                    return UnitConverterImperialMomentum.SlugFootPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.KilogramKilometerPerSecond:
                    return UnitConverterMetricMomentum.KilogramKilometerPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.GramMeterPerSecond:
                    return UnitConverterMetricMomentum.GramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.MilligramMeterPerSecond:
                    return UnitConverterMetricMomentum.MilligramMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.TonneMeterPerSecond:
                    return UnitConverterMetricMomentum.TonneMeterPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.PoundInchPerSecond:
                    return UnitConverterImperialMomentum.PoundInchPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.OunceFootPerSecond:
                    return UnitConverterImperialMomentum.OunceFootPerSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.KilonewtonSecond:
                    return UnitConverterMetricMomentum.KilonewtonSecondToKilogramMeterPerSecond(value);
                case UnitConverterMomentumUnit.PoundForceSecond:
                    return UnitConverterImperialMomentum.PoundForceSecondToKilogramMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported momentum unit.");
            }
        }

        public static double FromKilogramMeterPerSecond(double baseValue, UnitConverterMomentumUnit to)
        {
            switch (to)
            {
                case UnitConverterMomentumUnit.KilogramMeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToKilogramMeterPerSecond(baseValue);
                case UnitConverterMomentumUnit.NewtonSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToNewtonSecond(baseValue);
                case UnitConverterMomentumUnit.GramCentimeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToGramCentimeterPerSecond(baseValue);
                case UnitConverterMomentumUnit.PoundFootPerSecond:
                    return UnitConverterImperialMomentum.KilogramMeterPerSecondToPoundFootPerSecond(baseValue);
                case UnitConverterMomentumUnit.SlugFootPerSecond:
                    return UnitConverterImperialMomentum.KilogramMeterPerSecondToSlugFootPerSecond(baseValue);
                case UnitConverterMomentumUnit.KilogramKilometerPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToKilogramKilometerPerSecond(baseValue);
                case UnitConverterMomentumUnit.GramMeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToGramMeterPerSecond(baseValue);
                case UnitConverterMomentumUnit.MilligramMeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToMilligramMeterPerSecond(baseValue);
                case UnitConverterMomentumUnit.TonneMeterPerSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToTonneMeterPerSecond(baseValue);
                case UnitConverterMomentumUnit.PoundInchPerSecond:
                    return UnitConverterImperialMomentum.KilogramMeterPerSecondToPoundInchPerSecond(baseValue);
                case UnitConverterMomentumUnit.OunceFootPerSecond:
                    return UnitConverterImperialMomentum.KilogramMeterPerSecondToOunceFootPerSecond(baseValue);
                case UnitConverterMomentumUnit.KilonewtonSecond:
                    return UnitConverterMetricMomentum.KilogramMeterPerSecondToKilonewtonSecond(baseValue);
                case UnitConverterMomentumUnit.PoundForceSecond:
                    return UnitConverterImperialMomentum.KilogramMeterPerSecondToPoundForceSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported momentum unit.");
            }
        }

        public static string GetSymbol(UnitConverterMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentumUnit.KilogramMeterPerSecond:
                    return "kg·m/s";
                case UnitConverterMomentumUnit.NewtonSecond:
                    return "N·s";
                case UnitConverterMomentumUnit.GramCentimeterPerSecond:
                    return "g·cm/s";
                case UnitConverterMomentumUnit.PoundFootPerSecond:
                    return "lb·ft/s";
                case UnitConverterMomentumUnit.SlugFootPerSecond:
                    return "slug·ft/s";
                case UnitConverterMomentumUnit.KilogramKilometerPerSecond:
                    return "kg·km/s";
                case UnitConverterMomentumUnit.GramMeterPerSecond:
                    return "g·m/s";
                case UnitConverterMomentumUnit.MilligramMeterPerSecond:
                    return "mg·m/s";
                case UnitConverterMomentumUnit.TonneMeterPerSecond:
                    return "t·m/s";
                case UnitConverterMomentumUnit.PoundInchPerSecond:
                    return "lb·in/s";
                case UnitConverterMomentumUnit.OunceFootPerSecond:
                    return "oz·ft/s";
                case UnitConverterMomentumUnit.KilonewtonSecond:
                    return "kN·s";
                case UnitConverterMomentumUnit.PoundForceSecond:
                    return "lbf·s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentumUnit.KilogramMeterPerSecond:
                    return "Kilogram Meter Per Second";
                case UnitConverterMomentumUnit.NewtonSecond:
                    return "Newton Second";
                case UnitConverterMomentumUnit.GramCentimeterPerSecond:
                    return "Gram Centimeter Per Second";
                case UnitConverterMomentumUnit.PoundFootPerSecond:
                    return "Pound Foot Per Second";
                case UnitConverterMomentumUnit.SlugFootPerSecond:
                    return "Slug Foot Per Second";
                case UnitConverterMomentumUnit.KilogramKilometerPerSecond:
                    return "Kilogram Kilometer Per Second";
                case UnitConverterMomentumUnit.GramMeterPerSecond:
                    return "Gram Meter Per Second";
                case UnitConverterMomentumUnit.MilligramMeterPerSecond:
                    return "Milligram Meter Per Second";
                case UnitConverterMomentumUnit.TonneMeterPerSecond:
                    return "Tonne Meter Per Second";
                case UnitConverterMomentumUnit.PoundInchPerSecond:
                    return "Pound Inch Per Second";
                case UnitConverterMomentumUnit.OunceFootPerSecond:
                    return "Ounce Foot Per Second";
                case UnitConverterMomentumUnit.KilonewtonSecond:
                    return "Kilonewton Second";
                case UnitConverterMomentumUnit.PoundForceSecond:
                    return "Pound Force Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMomentumUnit.KilogramMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.NewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.GramCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.PoundFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentumUnit.SlugFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentumUnit.KilogramKilometerPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.GramMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.MilligramMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.TonneMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.PoundInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentumUnit.OunceFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMomentumUnit.KilonewtonSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMomentumUnit.PoundForceSecond:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMomentumUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMomentumUnit.KilogramMeterPerSecond, UnitConverterMomentumUnit.NewtonSecond, UnitConverterMomentumUnit.GramCentimeterPerSecond, UnitConverterMomentumUnit.KilogramKilometerPerSecond, UnitConverterMomentumUnit.GramMeterPerSecond, UnitConverterMomentumUnit.MilligramMeterPerSecond, UnitConverterMomentumUnit.TonneMeterPerSecond, UnitConverterMomentumUnit.KilonewtonSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMomentumUnit.PoundFootPerSecond, UnitConverterMomentumUnit.SlugFootPerSecond, UnitConverterMomentumUnit.PoundInchPerSecond, UnitConverterMomentumUnit.OunceFootPerSecond, UnitConverterMomentumUnit.PoundForceSecond };
                default:
                    return new[] { UnitConverterMomentumUnit.KilogramMeterPerSecond, UnitConverterMomentumUnit.NewtonSecond, UnitConverterMomentumUnit.GramCentimeterPerSecond, UnitConverterMomentumUnit.PoundFootPerSecond, UnitConverterMomentumUnit.SlugFootPerSecond, UnitConverterMomentumUnit.KilogramKilometerPerSecond, UnitConverterMomentumUnit.GramMeterPerSecond, UnitConverterMomentumUnit.MilligramMeterPerSecond, UnitConverterMomentumUnit.TonneMeterPerSecond, UnitConverterMomentumUnit.PoundInchPerSecond, UnitConverterMomentumUnit.OunceFootPerSecond, UnitConverterMomentumUnit.KilonewtonSecond, UnitConverterMomentumUnit.PoundForceSecond };
            }
        }
    }
}
