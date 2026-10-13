namespace UnitTools.ForcePerLength
{
    using UnitTools.ForcePerLength.Metric;
    using UnitTools.ForcePerLength.Imperial;
    using UnitTools.ForcePerLength.Scientific;

    public enum UnitToolsForcePerLengthUnit
    {
        NewtonPerMeter = 0,
        KilonewtonPerMeter = 1,
        NewtonPerMillimeter = 2,
        PoundForcePerFoot = 3,
        PoundForcePerInch = 4,
        MillinewtonPerMeter = 5,
        NewtonPerCentimeter = 6,
        NewtonPerInch = 7,
        DynePerCentimeter = 8,
        OunceForcePerInch = 9,
        KilogramForcePerCentimeter = 10,
    }

    public static class UnitToolsForcePerLength
    {
        public static double Convert(double value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            double baseValue = ToNewtonPerMeter(value, from);
            return FromNewtonPerMeter(baseValue, to);
        }

        public static double ToNewtonPerMeter(double value, UnitToolsForcePerLengthUnit from)
        {
            switch (from)
            {
                case UnitToolsForcePerLengthUnit.NewtonPerMeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitToolsMetricForcePerLength.KilonewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMillimeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.PoundForcePerFoot:
                    return UnitToolsImperialForcePerLength.PoundForcePerFootToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.PoundForcePerInch:
                    return UnitToolsImperialForcePerLength.PoundForcePerInchToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitToolsMetricForcePerLength.MillinewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitToolsMetricForcePerLength.NewtonPerCentimeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.NewtonPerInch:
                    return UnitToolsImperialForcePerLength.NewtonPerInchToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.DynePerCentimeter:
                    return UnitToolsScientificForcePerLength.DynePerCentimeterToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.OunceForcePerInch:
                    return UnitToolsImperialForcePerLength.OunceForcePerInchToNewtonPerMeter(value);
                case UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitToolsMetricForcePerLength.KilogramForcePerCentimeterToNewtonPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported force per length unit.");
            }
        }

        public static double FromNewtonPerMeter(double baseValue, UnitToolsForcePerLengthUnit to)
        {
            switch (to)
            {
                case UnitToolsForcePerLengthUnit.NewtonPerMeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToNewtonPerMeter(baseValue);
                case UnitToolsForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToKilonewtonPerMeter(baseValue);
                case UnitToolsForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToNewtonPerMillimeter(baseValue);
                case UnitToolsForcePerLengthUnit.PoundForcePerFoot:
                    return UnitToolsImperialForcePerLength.NewtonPerMeterToPoundForcePerFoot(baseValue);
                case UnitToolsForcePerLengthUnit.PoundForcePerInch:
                    return UnitToolsImperialForcePerLength.NewtonPerMeterToPoundForcePerInch(baseValue);
                case UnitToolsForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToMillinewtonPerMeter(baseValue);
                case UnitToolsForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToNewtonPerCentimeter(baseValue);
                case UnitToolsForcePerLengthUnit.NewtonPerInch:
                    return UnitToolsImperialForcePerLength.NewtonPerMeterToNewtonPerInch(baseValue);
                case UnitToolsForcePerLengthUnit.DynePerCentimeter:
                    return UnitToolsScientificForcePerLength.NewtonPerMeterToDynePerCentimeter(baseValue);
                case UnitToolsForcePerLengthUnit.OunceForcePerInch:
                    return UnitToolsImperialForcePerLength.NewtonPerMeterToOunceForcePerInch(baseValue);
                case UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitToolsMetricForcePerLength.NewtonPerMeterToKilogramForcePerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported force per length unit.");
            }
        }

        public static string GetSymbol(UnitToolsForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForcePerLengthUnit.NewtonPerMeter:
                    return "N/m";
                case UnitToolsForcePerLengthUnit.KilonewtonPerMeter:
                    return "kN/m";
                case UnitToolsForcePerLengthUnit.NewtonPerMillimeter:
                    return "N/mm";
                case UnitToolsForcePerLengthUnit.PoundForcePerFoot:
                    return "lbf/ft";
                case UnitToolsForcePerLengthUnit.PoundForcePerInch:
                    return "lbf/in";
                case UnitToolsForcePerLengthUnit.MillinewtonPerMeter:
                    return "mN/m";
                case UnitToolsForcePerLengthUnit.NewtonPerCentimeter:
                    return "N/cm";
                case UnitToolsForcePerLengthUnit.NewtonPerInch:
                    return "N/in";
                case UnitToolsForcePerLengthUnit.DynePerCentimeter:
                    return "dyn/cm";
                case UnitToolsForcePerLengthUnit.OunceForcePerInch:
                    return "ozf/in";
                case UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter:
                    return "kgf/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForcePerLengthUnit.NewtonPerMeter:
                    return "Newton Per Meter";
                case UnitToolsForcePerLengthUnit.KilonewtonPerMeter:
                    return "Kilonewton Per Meter";
                case UnitToolsForcePerLengthUnit.NewtonPerMillimeter:
                    return "Newton Per Millimeter";
                case UnitToolsForcePerLengthUnit.PoundForcePerFoot:
                    return "Pound Force Per Foot";
                case UnitToolsForcePerLengthUnit.PoundForcePerInch:
                    return "Pound Force Per Inch";
                case UnitToolsForcePerLengthUnit.MillinewtonPerMeter:
                    return "Millinewton Per Meter";
                case UnitToolsForcePerLengthUnit.NewtonPerCentimeter:
                    return "Newton Per Centimeter";
                case UnitToolsForcePerLengthUnit.NewtonPerInch:
                    return "Newton Per Inch";
                case UnitToolsForcePerLengthUnit.DynePerCentimeter:
                    return "Dyne Per Centimeter";
                case UnitToolsForcePerLengthUnit.OunceForcePerInch:
                    return "Ounce Force Per Inch";
                case UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter:
                    return "Kilogram Force Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForcePerLengthUnit.NewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForcePerLengthUnit.PoundForcePerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForcePerLengthUnit.PoundForcePerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForcePerLengthUnit.NewtonPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForcePerLengthUnit.DynePerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsForcePerLengthUnit.OunceForcePerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsForcePerLengthUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsForcePerLengthUnit.NewtonPerMeter, UnitToolsForcePerLengthUnit.KilonewtonPerMeter, UnitToolsForcePerLengthUnit.NewtonPerMillimeter, UnitToolsForcePerLengthUnit.MillinewtonPerMeter, UnitToolsForcePerLengthUnit.NewtonPerCentimeter, UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsForcePerLengthUnit.PoundForcePerFoot, UnitToolsForcePerLengthUnit.PoundForcePerInch, UnitToolsForcePerLengthUnit.NewtonPerInch, UnitToolsForcePerLengthUnit.OunceForcePerInch };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsForcePerLengthUnit.DynePerCentimeter };
                default:
                    return new[] { UnitToolsForcePerLengthUnit.NewtonPerMeter, UnitToolsForcePerLengthUnit.KilonewtonPerMeter, UnitToolsForcePerLengthUnit.NewtonPerMillimeter, UnitToolsForcePerLengthUnit.PoundForcePerFoot, UnitToolsForcePerLengthUnit.PoundForcePerInch, UnitToolsForcePerLengthUnit.MillinewtonPerMeter, UnitToolsForcePerLengthUnit.NewtonPerCentimeter, UnitToolsForcePerLengthUnit.NewtonPerInch, UnitToolsForcePerLengthUnit.DynePerCentimeter, UnitToolsForcePerLengthUnit.OunceForcePerInch, UnitToolsForcePerLengthUnit.KilogramForcePerCentimeter };
            }
        }
    }
}
