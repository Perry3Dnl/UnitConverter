namespace UnitTools.SurfaceTension
{
    using UnitTools.SurfaceTension.Metric;
    using UnitTools.SurfaceTension.Scientific;
    using UnitTools.SurfaceTension.Imperial;

    public enum UnitToolsSurfaceTensionUnit
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

    public static class UnitToolsSurfaceTension
    {
        public static double Convert(double value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            double baseValue = ToNewtonPerMeter(value, from);
            return FromNewtonPerMeter(baseValue, to);
        }

        public static double ToNewtonPerMeter(double value, UnitToolsSurfaceTensionUnit from)
        {
            switch (from)
            {
                case UnitToolsSurfaceTensionUnit.NewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.MillinewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.MicronewtonPerMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.DynePerCentimeter:
                    return UnitToolsScientificSurfaceTension.DynePerCentimeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitToolsMetricSurfaceTension.GramForcePerCentimeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitToolsImperialSurfaceTension.PoundForcePerFootToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.PoundForcePerInch:
                    return UnitToolsImperialSurfaceTension.PoundForcePerInchToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.JoulePerSquareMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.MillijoulePerSquareMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.MicrojoulePerSquareMeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerCentimeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMillimeterToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.PoundalPerFoot:
                    return UnitToolsImperialSurfaceTension.PoundalPerFootToNewtonPerMeter(value);
                case UnitToolsSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitToolsImperialSurfaceTension.OunceForcePerFootToNewtonPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported surface tension unit.");
            }
        }

        public static double FromNewtonPerMeter(double baseValue, UnitToolsSurfaceTensionUnit to)
        {
            switch (to)
            {
                case UnitToolsSurfaceTensionUnit.NewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToNewtonPerMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToMillinewtonPerMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToMicronewtonPerMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.DynePerCentimeter:
                    return UnitToolsScientificSurfaceTension.NewtonPerMeterToDynePerCentimeter(baseValue);
                case UnitToolsSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToGramForcePerCentimeter(baseValue);
                case UnitToolsSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitToolsImperialSurfaceTension.NewtonPerMeterToPoundForcePerFoot(baseValue);
                case UnitToolsSurfaceTensionUnit.PoundForcePerInch:
                    return UnitToolsImperialSurfaceTension.NewtonPerMeterToPoundForcePerInch(baseValue);
                case UnitToolsSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToJoulePerSquareMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToMillijoulePerSquareMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToMicrojoulePerSquareMeter(baseValue);
                case UnitToolsSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToNewtonPerCentimeter(baseValue);
                case UnitToolsSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitToolsMetricSurfaceTension.NewtonPerMeterToNewtonPerMillimeter(baseValue);
                case UnitToolsSurfaceTensionUnit.PoundalPerFoot:
                    return UnitToolsImperialSurfaceTension.NewtonPerMeterToPoundalPerFoot(baseValue);
                case UnitToolsSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitToolsImperialSurfaceTension.NewtonPerMeterToOunceForcePerFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported surface tension unit.");
            }
        }

        public static string GetSymbol(UnitToolsSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSurfaceTensionUnit.NewtonPerMeter:
                    return "N/m";
                case UnitToolsSurfaceTensionUnit.MillinewtonPerMeter:
                    return "mN/m";
                case UnitToolsSurfaceTensionUnit.MicronewtonPerMeter:
                    return "µN/m";
                case UnitToolsSurfaceTensionUnit.DynePerCentimeter:
                    return "dyn/cm";
                case UnitToolsSurfaceTensionUnit.GramForcePerCentimeter:
                    return "gf/cm";
                case UnitToolsSurfaceTensionUnit.PoundForcePerFoot:
                    return "lbf/ft";
                case UnitToolsSurfaceTensionUnit.PoundForcePerInch:
                    return "lbf/in";
                case UnitToolsSurfaceTensionUnit.JoulePerSquareMeter:
                    return "J/m²";
                case UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return "mJ/m²";
                case UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return "µJ/m²";
                case UnitToolsSurfaceTensionUnit.NewtonPerCentimeter:
                    return "N/cm";
                case UnitToolsSurfaceTensionUnit.NewtonPerMillimeter:
                    return "N/mm";
                case UnitToolsSurfaceTensionUnit.PoundalPerFoot:
                    return "pdl/ft";
                case UnitToolsSurfaceTensionUnit.OunceForcePerFoot:
                    return "ozf/ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSurfaceTensionUnit.NewtonPerMeter:
                    return "Newton Per Meter";
                case UnitToolsSurfaceTensionUnit.MillinewtonPerMeter:
                    return "Millinewton Per Meter";
                case UnitToolsSurfaceTensionUnit.MicronewtonPerMeter:
                    return "Micronewton Per Meter";
                case UnitToolsSurfaceTensionUnit.DynePerCentimeter:
                    return "Dyne Per Centimeter";
                case UnitToolsSurfaceTensionUnit.GramForcePerCentimeter:
                    return "Gram Force Per Centimeter";
                case UnitToolsSurfaceTensionUnit.PoundForcePerFoot:
                    return "Pound Force Per Foot";
                case UnitToolsSurfaceTensionUnit.PoundForcePerInch:
                    return "Pound Force Per Inch";
                case UnitToolsSurfaceTensionUnit.JoulePerSquareMeter:
                    return "Joule Per Square Meter";
                case UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return "Millijoule Per Square Meter";
                case UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return "Microjoule Per Square Meter";
                case UnitToolsSurfaceTensionUnit.NewtonPerCentimeter:
                    return "Newton Per Centimeter";
                case UnitToolsSurfaceTensionUnit.NewtonPerMillimeter:
                    return "Newton Per Millimeter";
                case UnitToolsSurfaceTensionUnit.PoundalPerFoot:
                    return "Poundal Per Foot";
                case UnitToolsSurfaceTensionUnit.OunceForcePerFoot:
                    return "Ounce Force Per Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSurfaceTensionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSurfaceTensionUnit.NewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.MillinewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.MicronewtonPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.DynePerCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsSurfaceTensionUnit.GramForcePerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.PoundForcePerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSurfaceTensionUnit.PoundForcePerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSurfaceTensionUnit.JoulePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.NewtonPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.NewtonPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSurfaceTensionUnit.PoundalPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSurfaceTensionUnit.OunceForcePerFoot:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSurfaceTensionUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSurfaceTensionUnit.NewtonPerMeter, UnitToolsSurfaceTensionUnit.MillinewtonPerMeter, UnitToolsSurfaceTensionUnit.MicronewtonPerMeter, UnitToolsSurfaceTensionUnit.GramForcePerCentimeter, UnitToolsSurfaceTensionUnit.JoulePerSquareMeter, UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter, UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter, UnitToolsSurfaceTensionUnit.NewtonPerCentimeter, UnitToolsSurfaceTensionUnit.NewtonPerMillimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsSurfaceTensionUnit.DynePerCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSurfaceTensionUnit.PoundForcePerFoot, UnitToolsSurfaceTensionUnit.PoundForcePerInch, UnitToolsSurfaceTensionUnit.PoundalPerFoot, UnitToolsSurfaceTensionUnit.OunceForcePerFoot };
                default:
                    return new[] { UnitToolsSurfaceTensionUnit.NewtonPerMeter, UnitToolsSurfaceTensionUnit.MillinewtonPerMeter, UnitToolsSurfaceTensionUnit.MicronewtonPerMeter, UnitToolsSurfaceTensionUnit.DynePerCentimeter, UnitToolsSurfaceTensionUnit.GramForcePerCentimeter, UnitToolsSurfaceTensionUnit.PoundForcePerFoot, UnitToolsSurfaceTensionUnit.PoundForcePerInch, UnitToolsSurfaceTensionUnit.JoulePerSquareMeter, UnitToolsSurfaceTensionUnit.MillijoulePerSquareMeter, UnitToolsSurfaceTensionUnit.MicrojoulePerSquareMeter, UnitToolsSurfaceTensionUnit.NewtonPerCentimeter, UnitToolsSurfaceTensionUnit.NewtonPerMillimeter, UnitToolsSurfaceTensionUnit.PoundalPerFoot, UnitToolsSurfaceTensionUnit.OunceForcePerFoot };
            }
        }
    }
}
