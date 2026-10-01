namespace UnitConverter.SurfaceTension
{
    using UnitConverter.SurfaceTension.Metric;
    using UnitConverter.SurfaceTension.Scientific;
    using UnitConverter.SurfaceTension.Imperial;

    public enum UnitConverterSurfaceTensionUnit
    {
        NewtonPerMeter = 0,
        MillinewtonPerMeter = 1,
        MicronewtonPerMeter = 2,
        DynePerCentimeter = 3,
        GramForcePerCentimeter = 4,
        PoundForcePerFoot = 5,
        PoundForcePerInch = 6,
        JoulePerSquareMeter = 7,
        MillijoulePerSquareMeter = 8,
        MicrojoulePerSquareMeter = 9,
        NewtonPerCentimeter = 10,
        NewtonPerMillimeter = 11,
        PoundalPerFoot = 12,
        OunceForcePerFoot = 13,
    }

    public static class UnitConverterSurfaceTension
    {
        public static double Convert(double value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            double baseValue = ToNewtonPerMeter(value, from);
            return FromNewtonPerMeter(baseValue, to);
        }

        public static double ToNewtonPerMeter(double value, UnitConverterSurfaceTensionUnit from)
        {
            switch (from)
            {
                case UnitConverterSurfaceTensionUnit.NewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.MillinewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.MicronewtonPerMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.DynePerCentimeter:
                    return UnitConverterScientificSurfaceTension.DynePerCentimeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitConverterMetricSurfaceTension.GramForcePerCentimeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitConverterImperialSurfaceTension.PoundForcePerFootToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.PoundForcePerInch:
                    return UnitConverterImperialSurfaceTension.PoundForcePerInchToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.JoulePerSquareMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.MillijoulePerSquareMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.MicrojoulePerSquareMeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerCentimeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMillimeterToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.PoundalPerFoot:
                    return UnitConverterImperialSurfaceTension.PoundalPerFootToNewtonPerMeter(value);
                case UnitConverterSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitConverterImperialSurfaceTension.OunceForcePerFootToNewtonPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported surface tension unit.");
            }
        }

        public static double FromNewtonPerMeter(double baseValue, UnitConverterSurfaceTensionUnit to)
        {
            switch (to)
            {
                case UnitConverterSurfaceTensionUnit.NewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToNewtonPerMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToMillinewtonPerMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToMicronewtonPerMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.DynePerCentimeter:
                    return UnitConverterScientificSurfaceTension.NewtonPerMeterToDynePerCentimeter(baseValue);
                case UnitConverterSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToGramForcePerCentimeter(baseValue);
                case UnitConverterSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitConverterImperialSurfaceTension.NewtonPerMeterToPoundForcePerFoot(baseValue);
                case UnitConverterSurfaceTensionUnit.PoundForcePerInch:
                    return UnitConverterImperialSurfaceTension.NewtonPerMeterToPoundForcePerInch(baseValue);
                case UnitConverterSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToJoulePerSquareMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToMillijoulePerSquareMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToMicrojoulePerSquareMeter(baseValue);
                case UnitConverterSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToNewtonPerCentimeter(baseValue);
                case UnitConverterSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitConverterMetricSurfaceTension.NewtonPerMeterToNewtonPerMillimeter(baseValue);
                case UnitConverterSurfaceTensionUnit.PoundalPerFoot:
                    return UnitConverterImperialSurfaceTension.NewtonPerMeterToPoundalPerFoot(baseValue);
                case UnitConverterSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitConverterImperialSurfaceTension.NewtonPerMeterToOunceForcePerFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported surface tension unit.");
            }
        }

        public static string GetSymbol(UnitConverterSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSurfaceTensionUnit.NewtonPerMeter:
                    return "N/m";
                case UnitConverterSurfaceTensionUnit.MillinewtonPerMeter:
                    return "mN/m";
                case UnitConverterSurfaceTensionUnit.MicronewtonPerMeter:
                    return "µN/m";
                case UnitConverterSurfaceTensionUnit.DynePerCentimeter:
                    return "dyn/cm";
                case UnitConverterSurfaceTensionUnit.GramForcePerCentimeter:
                    return "gf/cm";
                case UnitConverterSurfaceTensionUnit.PoundForcePerFoot:
                    return "lbf/ft";
                case UnitConverterSurfaceTensionUnit.PoundForcePerInch:
                    return "lbf/in";
                case UnitConverterSurfaceTensionUnit.JoulePerSquareMeter:
                    return "J/m²";
                case UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return "mJ/m²";
                case UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return "µJ/m²";
                case UnitConverterSurfaceTensionUnit.NewtonPerCentimeter:
                    return "N/cm";
                case UnitConverterSurfaceTensionUnit.NewtonPerMillimeter:
                    return "N/mm";
                case UnitConverterSurfaceTensionUnit.PoundalPerFoot:
                    return "pdl/ft";
                case UnitConverterSurfaceTensionUnit.OunceForcePerFoot:
                    return "ozf/ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSurfaceTensionUnit.NewtonPerMeter:
                    return "Newton Per Meter";
                case UnitConverterSurfaceTensionUnit.MillinewtonPerMeter:
                    return "Millinewton Per Meter";
                case UnitConverterSurfaceTensionUnit.MicronewtonPerMeter:
                    return "Micronewton Per Meter";
                case UnitConverterSurfaceTensionUnit.DynePerCentimeter:
                    return "Dyne Per Centimeter";
                case UnitConverterSurfaceTensionUnit.GramForcePerCentimeter:
                    return "Gram Force Per Centimeter";
                case UnitConverterSurfaceTensionUnit.PoundForcePerFoot:
                    return "Pound Force Per Foot";
                case UnitConverterSurfaceTensionUnit.PoundForcePerInch:
                    return "Pound Force Per Inch";
                case UnitConverterSurfaceTensionUnit.JoulePerSquareMeter:
                    return "Joule Per Square Meter";
                case UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return "Millijoule Per Square Meter";
                case UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return "Microjoule Per Square Meter";
                case UnitConverterSurfaceTensionUnit.NewtonPerCentimeter:
                    return "Newton Per Centimeter";
                case UnitConverterSurfaceTensionUnit.NewtonPerMillimeter:
                    return "Newton Per Millimeter";
                case UnitConverterSurfaceTensionUnit.PoundalPerFoot:
                    return "Poundal Per Foot";
                case UnitConverterSurfaceTensionUnit.OunceForcePerFoot:
                    return "Ounce Force Per Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSurfaceTensionUnit.NewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.DynePerCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSurfaceTensionUnit.PoundForcePerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSurfaceTensionUnit.PoundalPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSurfaceTensionUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSurfaceTensionUnit.NewtonPerMeter, UnitConverterSurfaceTensionUnit.MillinewtonPerMeter, UnitConverterSurfaceTensionUnit.MicronewtonPerMeter, UnitConverterSurfaceTensionUnit.GramForcePerCentimeter, UnitConverterSurfaceTensionUnit.JoulePerSquareMeter, UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter, UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter, UnitConverterSurfaceTensionUnit.NewtonPerCentimeter, UnitConverterSurfaceTensionUnit.NewtonPerMillimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterSurfaceTensionUnit.DynePerCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSurfaceTensionUnit.PoundForcePerFoot, UnitConverterSurfaceTensionUnit.PoundForcePerInch, UnitConverterSurfaceTensionUnit.PoundalPerFoot, UnitConverterSurfaceTensionUnit.OunceForcePerFoot };
                default:
                    return new[] { UnitConverterSurfaceTensionUnit.NewtonPerMeter, UnitConverterSurfaceTensionUnit.MillinewtonPerMeter, UnitConverterSurfaceTensionUnit.MicronewtonPerMeter, UnitConverterSurfaceTensionUnit.DynePerCentimeter, UnitConverterSurfaceTensionUnit.GramForcePerCentimeter, UnitConverterSurfaceTensionUnit.PoundForcePerFoot, UnitConverterSurfaceTensionUnit.PoundForcePerInch, UnitConverterSurfaceTensionUnit.JoulePerSquareMeter, UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter, UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter, UnitConverterSurfaceTensionUnit.NewtonPerCentimeter, UnitConverterSurfaceTensionUnit.NewtonPerMillimeter, UnitConverterSurfaceTensionUnit.PoundalPerFoot, UnitConverterSurfaceTensionUnit.OunceForcePerFoot };
            }
        }
    }
}
