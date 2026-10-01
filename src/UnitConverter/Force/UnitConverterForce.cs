namespace UnitConverter.Force
{
    using UnitConverter.Force.Metric;
    using UnitConverter.Force.Scientific;
    using UnitConverter.Force.Imperial;
    using UnitConverter.Force.ImperialUS;
    using UnitConverter.Force.ImperialUK;
    using UnitConverter.Force.Historical;
    using UnitConverter.Force.Engineering;

    public enum UnitConverterForceUnit
    {
        Micronewton = 0,
        Millinewton = 1,
        Newton = 2,
        Kilonewton = 3,
        Meganewton = 4,
        Dyne = 5,
        PoundForce = 6,
        OunceForce = 7,
        Kip = 8,
        Poundal = 9,
        KilogramForce = 10,
        TonForceUS = 11,
        TonForceUK = 12,
        Piconewton = 13,
        Nanonewton = 14,
        GramForce = 15,
        MilligramForce = 16,
        Pond = 17,
        Sthene = 18,
        JoulePerMeter = 19,
        PlanckForce = 20,
    }

    public static class UnitConverterForce
    {
        public static double Convert(double value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            double baseValue = ToNewton(value, from);
            return FromNewton(baseValue, to);
        }

        public static double ToNewton(double value, UnitConverterForceUnit from)
        {
            switch (from)
            {
                case UnitConverterForceUnit.Micronewton:
                    return UnitConverterMetricForce.MicronewtonToNewton(value);
                case UnitConverterForceUnit.Millinewton:
                    return UnitConverterMetricForce.MillinewtonToNewton(value);
                case UnitConverterForceUnit.Newton:
                    return UnitConverterMetricForce.NewtonToNewton(value);
                case UnitConverterForceUnit.Kilonewton:
                    return UnitConverterMetricForce.KilonewtonToNewton(value);
                case UnitConverterForceUnit.Meganewton:
                    return UnitConverterMetricForce.MeganewtonToNewton(value);
                case UnitConverterForceUnit.Dyne:
                    return UnitConverterScientificForce.DyneToNewton(value);
                case UnitConverterForceUnit.PoundForce:
                    return UnitConverterImperialForce.PoundForceToNewton(value);
                case UnitConverterForceUnit.OunceForce:
                    return UnitConverterImperialForce.OunceForceToNewton(value);
                case UnitConverterForceUnit.Kip:
                    return UnitConverterImperialUSForce.KipToNewton(value);
                case UnitConverterForceUnit.Poundal:
                    return UnitConverterImperialForce.PoundalToNewton(value);
                case UnitConverterForceUnit.KilogramForce:
                    return UnitConverterMetricForce.KilogramForceToNewton(value);
                case UnitConverterForceUnit.TonForceUS:
                    return UnitConverterImperialUSForce.TonForceUSToNewton(value);
                case UnitConverterForceUnit.TonForceUK:
                    return UnitConverterImperialUKForce.TonForceUKToNewton(value);
                case UnitConverterForceUnit.Piconewton:
                    return UnitConverterMetricForce.PiconewtonToNewton(value);
                case UnitConverterForceUnit.Nanonewton:
                    return UnitConverterMetricForce.NanonewtonToNewton(value);
                case UnitConverterForceUnit.GramForce:
                    return UnitConverterMetricForce.GramForceToNewton(value);
                case UnitConverterForceUnit.MilligramForce:
                    return UnitConverterMetricForce.MilligramForceToNewton(value);
                case UnitConverterForceUnit.Pond:
                    return UnitConverterHistoricalForce.PondToNewton(value);
                case UnitConverterForceUnit.Sthene:
                    return UnitConverterHistoricalForce.StheneToNewton(value);
                case UnitConverterForceUnit.JoulePerMeter:
                    return UnitConverterEngineeringForce.JoulePerMeterToNewton(value);
                case UnitConverterForceUnit.PlanckForce:
                    return UnitConverterScientificForce.PlanckForceToNewton(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported force unit.");
            }
        }

        public static double FromNewton(double baseValue, UnitConverterForceUnit to)
        {
            switch (to)
            {
                case UnitConverterForceUnit.Micronewton:
                    return UnitConverterMetricForce.NewtonToMicronewton(baseValue);
                case UnitConverterForceUnit.Millinewton:
                    return UnitConverterMetricForce.NewtonToMillinewton(baseValue);
                case UnitConverterForceUnit.Newton:
                    return UnitConverterMetricForce.NewtonToNewton(baseValue);
                case UnitConverterForceUnit.Kilonewton:
                    return UnitConverterMetricForce.NewtonToKilonewton(baseValue);
                case UnitConverterForceUnit.Meganewton:
                    return UnitConverterMetricForce.NewtonToMeganewton(baseValue);
                case UnitConverterForceUnit.Dyne:
                    return UnitConverterScientificForce.NewtonToDyne(baseValue);
                case UnitConverterForceUnit.PoundForce:
                    return UnitConverterImperialForce.NewtonToPoundForce(baseValue);
                case UnitConverterForceUnit.OunceForce:
                    return UnitConverterImperialForce.NewtonToOunceForce(baseValue);
                case UnitConverterForceUnit.Kip:
                    return UnitConverterImperialUSForce.NewtonToKip(baseValue);
                case UnitConverterForceUnit.Poundal:
                    return UnitConverterImperialForce.NewtonToPoundal(baseValue);
                case UnitConverterForceUnit.KilogramForce:
                    return UnitConverterMetricForce.NewtonToKilogramForce(baseValue);
                case UnitConverterForceUnit.TonForceUS:
                    return UnitConverterImperialUSForce.NewtonToTonForceUS(baseValue);
                case UnitConverterForceUnit.TonForceUK:
                    return UnitConverterImperialUKForce.NewtonToTonForceUK(baseValue);
                case UnitConverterForceUnit.Piconewton:
                    return UnitConverterMetricForce.NewtonToPiconewton(baseValue);
                case UnitConverterForceUnit.Nanonewton:
                    return UnitConverterMetricForce.NewtonToNanonewton(baseValue);
                case UnitConverterForceUnit.GramForce:
                    return UnitConverterMetricForce.NewtonToGramForce(baseValue);
                case UnitConverterForceUnit.MilligramForce:
                    return UnitConverterMetricForce.NewtonToMilligramForce(baseValue);
                case UnitConverterForceUnit.Pond:
                    return UnitConverterHistoricalForce.NewtonToPond(baseValue);
                case UnitConverterForceUnit.Sthene:
                    return UnitConverterHistoricalForce.NewtonToSthene(baseValue);
                case UnitConverterForceUnit.JoulePerMeter:
                    return UnitConverterEngineeringForce.NewtonToJoulePerMeter(baseValue);
                case UnitConverterForceUnit.PlanckForce:
                    return UnitConverterScientificForce.NewtonToPlanckForce(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported force unit.");
            }
        }

        public static string GetSymbol(UnitConverterForceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForceUnit.Micronewton:
                    return "µN";
                case UnitConverterForceUnit.Millinewton:
                    return "mN";
                case UnitConverterForceUnit.Newton:
                    return "N";
                case UnitConverterForceUnit.Kilonewton:
                    return "kN";
                case UnitConverterForceUnit.Meganewton:
                    return "MN";
                case UnitConverterForceUnit.Dyne:
                    return "dyn";
                case UnitConverterForceUnit.PoundForce:
                    return "lbf";
                case UnitConverterForceUnit.OunceForce:
                    return "ozf";
                case UnitConverterForceUnit.Kip:
                    return "kip";
                case UnitConverterForceUnit.Poundal:
                    return "pdl";
                case UnitConverterForceUnit.KilogramForce:
                    return "kgf";
                case UnitConverterForceUnit.TonForceUS:
                    return "tonf US";
                case UnitConverterForceUnit.TonForceUK:
                    return "tonf UK";
                case UnitConverterForceUnit.Piconewton:
                    return "pN";
                case UnitConverterForceUnit.Nanonewton:
                    return "nN";
                case UnitConverterForceUnit.GramForce:
                    return "gf";
                case UnitConverterForceUnit.MilligramForce:
                    return "mgf";
                case UnitConverterForceUnit.Pond:
                    return "p";
                case UnitConverterForceUnit.Sthene:
                    return "sn";
                case UnitConverterForceUnit.JoulePerMeter:
                    return "J/m";
                case UnitConverterForceUnit.PlanckForce:
                    return "FP";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterForceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForceUnit.Micronewton:
                    return "micronewton";
                case UnitConverterForceUnit.Millinewton:
                    return "millinewton";
                case UnitConverterForceUnit.Newton:
                    return "newton";
                case UnitConverterForceUnit.Kilonewton:
                    return "kilonewton";
                case UnitConverterForceUnit.Meganewton:
                    return "meganewton";
                case UnitConverterForceUnit.Dyne:
                    return "dyne";
                case UnitConverterForceUnit.PoundForce:
                    return "pound-force";
                case UnitConverterForceUnit.OunceForce:
                    return "ounce-force";
                case UnitConverterForceUnit.Kip:
                    return "kip";
                case UnitConverterForceUnit.Poundal:
                    return "poundal";
                case UnitConverterForceUnit.KilogramForce:
                    return "kilogram-force";
                case UnitConverterForceUnit.TonForceUS:
                    return "US ton-force";
                case UnitConverterForceUnit.TonForceUK:
                    return "UK ton-force";
                case UnitConverterForceUnit.Piconewton:
                    return "Piconewton";
                case UnitConverterForceUnit.Nanonewton:
                    return "Nanonewton";
                case UnitConverterForceUnit.GramForce:
                    return "Gram Force";
                case UnitConverterForceUnit.MilligramForce:
                    return "Milligram Force";
                case UnitConverterForceUnit.Pond:
                    return "Pond";
                case UnitConverterForceUnit.Sthene:
                    return "Sthene";
                case UnitConverterForceUnit.JoulePerMeter:
                    return "Joule Per Meter";
                case UnitConverterForceUnit.PlanckForce:
                    return "Planck Force";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterForceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForceUnit.Micronewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Millinewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Newton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Kilonewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Meganewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Dyne:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterForceUnit.PoundForce:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForceUnit.OunceForce:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForceUnit.Kip:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterForceUnit.Poundal:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForceUnit.KilogramForce:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.TonForceUS:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterForceUnit.TonForceUK:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterForceUnit.Piconewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Nanonewton:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.GramForce:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.MilligramForce:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForceUnit.Pond:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterForceUnit.Sthene:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterForceUnit.JoulePerMeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterForceUnit.PlanckForce:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterForceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterForceUnit.Micronewton, UnitConverterForceUnit.Millinewton, UnitConverterForceUnit.Newton, UnitConverterForceUnit.Kilonewton, UnitConverterForceUnit.Meganewton, UnitConverterForceUnit.KilogramForce, UnitConverterForceUnit.Piconewton, UnitConverterForceUnit.Nanonewton, UnitConverterForceUnit.GramForce, UnitConverterForceUnit.MilligramForce };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterForceUnit.Dyne, UnitConverterForceUnit.PlanckForce };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterForceUnit.PoundForce, UnitConverterForceUnit.OunceForce, UnitConverterForceUnit.Poundal };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterForceUnit.Kip, UnitConverterForceUnit.TonForceUS };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterForceUnit.TonForceUK };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterForceUnit.Pond, UnitConverterForceUnit.Sthene };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterForceUnit.JoulePerMeter };
                default:
                    return new[] { UnitConverterForceUnit.Micronewton, UnitConverterForceUnit.Millinewton, UnitConverterForceUnit.Newton, UnitConverterForceUnit.Kilonewton, UnitConverterForceUnit.Meganewton, UnitConverterForceUnit.Dyne, UnitConverterForceUnit.PoundForce, UnitConverterForceUnit.OunceForce, UnitConverterForceUnit.Kip, UnitConverterForceUnit.Poundal, UnitConverterForceUnit.KilogramForce, UnitConverterForceUnit.TonForceUS, UnitConverterForceUnit.TonForceUK, UnitConverterForceUnit.Piconewton, UnitConverterForceUnit.Nanonewton, UnitConverterForceUnit.GramForce, UnitConverterForceUnit.MilligramForce, UnitConverterForceUnit.Pond, UnitConverterForceUnit.Sthene, UnitConverterForceUnit.JoulePerMeter, UnitConverterForceUnit.PlanckForce };
            }
        }
    }
}
