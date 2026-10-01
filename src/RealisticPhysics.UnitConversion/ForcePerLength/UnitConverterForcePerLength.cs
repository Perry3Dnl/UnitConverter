namespace RealisticPhysics.UnitConversion.ForcePerLength
{
    using RealisticPhysics.UnitConversion.ForcePerLength.Metric;
    using RealisticPhysics.UnitConversion.ForcePerLength.Imperial;
    using RealisticPhysics.UnitConversion.ForcePerLength.Scientific;

    public enum UnitConverterForcePerLengthUnit
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

    public static class UnitConverterForcePerLength
    {
        public static double Convert(double value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            double baseValue = ToNewtonPerMeter(value, from);
            return FromNewtonPerMeter(baseValue, to);
        }

        public static double ToNewtonPerMeter(double value, UnitConverterForcePerLengthUnit from)
        {
            switch (from)
            {
                case UnitConverterForcePerLengthUnit.NewtonPerMeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitConverterMetricForcePerLength.KilonewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMillimeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.PoundForcePerFoot:
                    return UnitConverterImperialForcePerLength.PoundForcePerFootToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.PoundForcePerInch:
                    return UnitConverterImperialForcePerLength.PoundForcePerInchToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitConverterMetricForcePerLength.MillinewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitConverterMetricForcePerLength.NewtonPerCentimeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.NewtonPerInch:
                    return UnitConverterImperialForcePerLength.NewtonPerInchToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.DynePerCentimeter:
                    return UnitConverterScientificForcePerLength.DynePerCentimeterToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.OunceForcePerInch:
                    return UnitConverterImperialForcePerLength.OunceForcePerInchToNewtonPerMeter(value);
                case UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitConverterMetricForcePerLength.KilogramForcePerCentimeterToNewtonPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported force per length unit.");
            }
        }

        public static double FromNewtonPerMeter(double baseValue, UnitConverterForcePerLengthUnit to)
        {
            switch (to)
            {
                case UnitConverterForcePerLengthUnit.NewtonPerMeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToNewtonPerMeter(baseValue);
                case UnitConverterForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToKilonewtonPerMeter(baseValue);
                case UnitConverterForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToNewtonPerMillimeter(baseValue);
                case UnitConverterForcePerLengthUnit.PoundForcePerFoot:
                    return UnitConverterImperialForcePerLength.NewtonPerMeterToPoundForcePerFoot(baseValue);
                case UnitConverterForcePerLengthUnit.PoundForcePerInch:
                    return UnitConverterImperialForcePerLength.NewtonPerMeterToPoundForcePerInch(baseValue);
                case UnitConverterForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToMillinewtonPerMeter(baseValue);
                case UnitConverterForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToNewtonPerCentimeter(baseValue);
                case UnitConverterForcePerLengthUnit.NewtonPerInch:
                    return UnitConverterImperialForcePerLength.NewtonPerMeterToNewtonPerInch(baseValue);
                case UnitConverterForcePerLengthUnit.DynePerCentimeter:
                    return UnitConverterScientificForcePerLength.NewtonPerMeterToDynePerCentimeter(baseValue);
                case UnitConverterForcePerLengthUnit.OunceForcePerInch:
                    return UnitConverterImperialForcePerLength.NewtonPerMeterToOunceForcePerInch(baseValue);
                case UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitConverterMetricForcePerLength.NewtonPerMeterToKilogramForcePerCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported force per length unit.");
            }
        }

        public static string GetSymbol(UnitConverterForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForcePerLengthUnit.NewtonPerMeter:
                    return "N/m";
                case UnitConverterForcePerLengthUnit.KilonewtonPerMeter:
                    return "kN/m";
                case UnitConverterForcePerLengthUnit.NewtonPerMillimeter:
                    return "N/mm";
                case UnitConverterForcePerLengthUnit.PoundForcePerFoot:
                    return "lbf/ft";
                case UnitConverterForcePerLengthUnit.PoundForcePerInch:
                    return "lbf/in";
                case UnitConverterForcePerLengthUnit.MillinewtonPerMeter:
                    return "mN/m";
                case UnitConverterForcePerLengthUnit.NewtonPerCentimeter:
                    return "N/cm";
                case UnitConverterForcePerLengthUnit.NewtonPerInch:
                    return "N/in";
                case UnitConverterForcePerLengthUnit.DynePerCentimeter:
                    return "dyn/cm";
                case UnitConverterForcePerLengthUnit.OunceForcePerInch:
                    return "ozf/in";
                case UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter:
                    return "kgf/cm";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForcePerLengthUnit.NewtonPerMeter:
                    return "Newton Per Meter";
                case UnitConverterForcePerLengthUnit.KilonewtonPerMeter:
                    return "Kilonewton Per Meter";
                case UnitConverterForcePerLengthUnit.NewtonPerMillimeter:
                    return "Newton Per Millimeter";
                case UnitConverterForcePerLengthUnit.PoundForcePerFoot:
                    return "Pound Force Per Foot";
                case UnitConverterForcePerLengthUnit.PoundForcePerInch:
                    return "Pound Force Per Inch";
                case UnitConverterForcePerLengthUnit.MillinewtonPerMeter:
                    return "Millinewton Per Meter";
                case UnitConverterForcePerLengthUnit.NewtonPerCentimeter:
                    return "Newton Per Centimeter";
                case UnitConverterForcePerLengthUnit.NewtonPerInch:
                    return "Newton Per Inch";
                case UnitConverterForcePerLengthUnit.DynePerCentimeter:
                    return "Dyne Per Centimeter";
                case UnitConverterForcePerLengthUnit.OunceForcePerInch:
                    return "Ounce Force Per Inch";
                case UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter:
                    return "Kilogram Force Per Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterForcePerLengthUnit.NewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForcePerLengthUnit.KilonewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForcePerLengthUnit.NewtonPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForcePerLengthUnit.PoundForcePerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForcePerLengthUnit.PoundForcePerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForcePerLengthUnit.MillinewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForcePerLengthUnit.NewtonPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterForcePerLengthUnit.NewtonPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForcePerLengthUnit.DynePerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterForcePerLengthUnit.OunceForcePerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterForcePerLengthUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterForcePerLengthUnit.NewtonPerMeter, UnitConverterForcePerLengthUnit.KilonewtonPerMeter, UnitConverterForcePerLengthUnit.NewtonPerMillimeter, UnitConverterForcePerLengthUnit.MillinewtonPerMeter, UnitConverterForcePerLengthUnit.NewtonPerCentimeter, UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterForcePerLengthUnit.PoundForcePerFoot, UnitConverterForcePerLengthUnit.PoundForcePerInch, UnitConverterForcePerLengthUnit.NewtonPerInch, UnitConverterForcePerLengthUnit.OunceForcePerInch };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterForcePerLengthUnit.DynePerCentimeter };
                default:
                    return new[] { UnitConverterForcePerLengthUnit.NewtonPerMeter, UnitConverterForcePerLengthUnit.KilonewtonPerMeter, UnitConverterForcePerLengthUnit.NewtonPerMillimeter, UnitConverterForcePerLengthUnit.PoundForcePerFoot, UnitConverterForcePerLengthUnit.PoundForcePerInch, UnitConverterForcePerLengthUnit.MillinewtonPerMeter, UnitConverterForcePerLengthUnit.NewtonPerCentimeter, UnitConverterForcePerLengthUnit.NewtonPerInch, UnitConverterForcePerLengthUnit.DynePerCentimeter, UnitConverterForcePerLengthUnit.OunceForcePerInch, UnitConverterForcePerLengthUnit.KilogramForcePerCentimeter };
            }
        }
    }
}
