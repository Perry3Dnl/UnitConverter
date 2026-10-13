namespace UnitTools.SpecificWeight
{
    using UnitTools.SpecificWeight.Metric;
    using UnitTools.SpecificWeight.Imperial;
    using UnitTools.SpecificWeight.ImperialUS;
    using UnitTools.SpecificWeight.ImperialUK;

    public enum UnitToolsSpecificWeightUnit
    {
        NewtonPerCubicMeter = 0,
        KilonewtonPerCubicMeter = 1,
        NewtonPerLiter = 2,
        PoundForcePerCubicFoot = 3,
        KilogramForcePerCubicMeter = 4,
        MillinewtonPerCubicMeter = 5,
        NewtonPerCubicCentimeter = 6,
        NewtonPerCubicMillimeter = 7,
        OunceForcePerCubicFoot = 8,
        PoundForcePerUSGallon = 9,
        PoundForcePerImperialGallon = 10,
    }

    public static class UnitToolsSpecificWeight
    {
        public static double Convert(double value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            double baseValue = ToNewtonPerCubicMeter(value, from);
            return FromNewtonPerCubicMeter(baseValue, to);
        }

        public static double ToNewtonPerCubicMeter(double value, UnitToolsSpecificWeightUnit from)
        {
            switch (from)
            {
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.KilonewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.NewtonPerLiter:
                    return UnitToolsMetricSpecificWeight.NewtonPerLiterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitToolsImperialSpecificWeight.PoundForcePerCubicFootToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitToolsMetricSpecificWeight.KilogramForcePerCubicMeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.MillinewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicCentimeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMillimeterToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitToolsImperialSpecificWeight.OunceForcePerCubicFootToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitToolsImperialUSSpecificWeight.PoundForcePerUSGallonToNewtonPerCubicMeter(value);
                case UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitToolsImperialUKSpecificWeight.PoundForcePerImperialGallonToNewtonPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific weight unit.");
            }
        }

        public static double FromNewtonPerCubicMeter(double baseValue, UnitToolsSpecificWeightUnit to)
        {
            switch (to)
            {
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMeter(baseValue);
                case UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToKilonewtonPerCubicMeter(baseValue);
                case UnitToolsSpecificWeightUnit.NewtonPerLiter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerLiter(baseValue);
                case UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitToolsImperialSpecificWeight.NewtonPerCubicMeterToPoundForcePerCubicFoot(baseValue);
                case UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToKilogramForcePerCubicMeter(baseValue);
                case UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToMillinewtonPerCubicMeter(baseValue);
                case UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicCentimeter(baseValue);
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitToolsMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMillimeter(baseValue);
                case UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitToolsImperialSpecificWeight.NewtonPerCubicMeterToOunceForcePerCubicFoot(baseValue);
                case UnitToolsSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitToolsImperialUSSpecificWeight.NewtonPerCubicMeterToPoundForcePerUSGallon(baseValue);
                case UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitToolsImperialUKSpecificWeight.NewtonPerCubicMeterToPoundForcePerImperialGallon(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific weight unit.");
            }
        }

        public static string GetSymbol(UnitToolsSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMeter:
                    return "N/m³";
                case UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return "kN/m³";
                case UnitToolsSpecificWeightUnit.NewtonPerLiter:
                    return "N/L";
                case UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot:
                    return "lbf/ft³";
                case UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return "kgf/m³";
                case UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return "mN/m³";
                case UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return "N/cm³";
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return "N/mm³";
                case UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot:
                    return "ozf/ft³";
                case UnitToolsSpecificWeightUnit.PoundForcePerUSGallon:
                    return "lbf/gal US";
                case UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon:
                    return "lbf/gal imp";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMeter:
                    return "Newton Per Cubic Meter";
                case UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return "Kilonewton Per Cubic Meter";
                case UnitToolsSpecificWeightUnit.NewtonPerLiter:
                    return "Newton Per Liter";
                case UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot:
                    return "Pound Force Per Cubic Foot";
                case UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return "Kilogram Force Per Cubic Meter";
                case UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return "Millinewton Per Cubic Meter";
                case UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return "Newton Per Cubic Centimeter";
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return "Newton Per Cubic Millimeter";
                case UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot:
                    return "Ounce Force Per Cubic Foot";
                case UnitToolsSpecificWeightUnit.PoundForcePerUSGallon:
                    return "Pound Force Per US Gallon";
                case UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon:
                    return "Pound Force Per Imperial Gallon";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.NewtonPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitToolsUnitSystem.ImperialUK;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSpecificWeightUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSpecificWeightUnit.NewtonPerCubicMeter, UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter, UnitToolsSpecificWeightUnit.NewtonPerLiter, UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter, UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter, UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter, UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot, UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsSpecificWeightUnit.PoundForcePerUSGallon };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon };
                default:
                    return new[] { UnitToolsSpecificWeightUnit.NewtonPerCubicMeter, UnitToolsSpecificWeightUnit.KilonewtonPerCubicMeter, UnitToolsSpecificWeightUnit.NewtonPerLiter, UnitToolsSpecificWeightUnit.PoundForcePerCubicFoot, UnitToolsSpecificWeightUnit.KilogramForcePerCubicMeter, UnitToolsSpecificWeightUnit.MillinewtonPerCubicMeter, UnitToolsSpecificWeightUnit.NewtonPerCubicCentimeter, UnitToolsSpecificWeightUnit.NewtonPerCubicMillimeter, UnitToolsSpecificWeightUnit.OunceForcePerCubicFoot, UnitToolsSpecificWeightUnit.PoundForcePerUSGallon, UnitToolsSpecificWeightUnit.PoundForcePerImperialGallon };
            }
        }
    }
}
