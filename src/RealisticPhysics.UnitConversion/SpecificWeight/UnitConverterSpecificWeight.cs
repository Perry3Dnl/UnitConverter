namespace RealisticPhysics.UnitConversion.SpecificWeight
{
    using RealisticPhysics.UnitConversion.SpecificWeight.Metric;
    using RealisticPhysics.UnitConversion.SpecificWeight.Imperial;
    using RealisticPhysics.UnitConversion.SpecificWeight.ImperialUS;
    using RealisticPhysics.UnitConversion.SpecificWeight.ImperialUK;

    public enum UnitConverterSpecificWeightUnit
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

    public static class UnitConverterSpecificWeight
    {
        public static double Convert(double value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            double baseValue = ToNewtonPerCubicMeter(value, from);
            return FromNewtonPerCubicMeter(baseValue, to);
        }

        public static double ToNewtonPerCubicMeter(double value, UnitConverterSpecificWeightUnit from)
        {
            switch (from)
            {
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.KilonewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.NewtonPerLiter:
                    return UnitConverterMetricSpecificWeight.NewtonPerLiterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitConverterImperialSpecificWeight.PoundForcePerCubicFootToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitConverterMetricSpecificWeight.KilogramForcePerCubicMeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.MillinewtonPerCubicMeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicCentimeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMillimeterToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitConverterImperialSpecificWeight.OunceForcePerCubicFootToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitConverterImperialUSSpecificWeight.PoundForcePerUSGallonToNewtonPerCubicMeter(value);
                case UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitConverterImperialUKSpecificWeight.PoundForcePerImperialGallonToNewtonPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific weight unit.");
            }
        }

        public static double FromNewtonPerCubicMeter(double baseValue, UnitConverterSpecificWeightUnit to)
        {
            switch (to)
            {
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMeter(baseValue);
                case UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToKilonewtonPerCubicMeter(baseValue);
                case UnitConverterSpecificWeightUnit.NewtonPerLiter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerLiter(baseValue);
                case UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitConverterImperialSpecificWeight.NewtonPerCubicMeterToPoundForcePerCubicFoot(baseValue);
                case UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToKilogramForcePerCubicMeter(baseValue);
                case UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToMillinewtonPerCubicMeter(baseValue);
                case UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicCentimeter(baseValue);
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitConverterMetricSpecificWeight.NewtonPerCubicMeterToNewtonPerCubicMillimeter(baseValue);
                case UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitConverterImperialSpecificWeight.NewtonPerCubicMeterToOunceForcePerCubicFoot(baseValue);
                case UnitConverterSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitConverterImperialUSSpecificWeight.NewtonPerCubicMeterToPoundForcePerUSGallon(baseValue);
                case UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitConverterImperialUKSpecificWeight.NewtonPerCubicMeterToPoundForcePerImperialGallon(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific weight unit.");
            }
        }

        public static string GetSymbol(UnitConverterSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMeter:
                    return "N/m³";
                case UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return "kN/m³";
                case UnitConverterSpecificWeightUnit.NewtonPerLiter:
                    return "N/L";
                case UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot:
                    return "lbf/ft³";
                case UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return "kgf/m³";
                case UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return "mN/m³";
                case UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return "N/cm³";
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return "N/mm³";
                case UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot:
                    return "ozf/ft³";
                case UnitConverterSpecificWeightUnit.PoundForcePerUSGallon:
                    return "lbf/gal US";
                case UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon:
                    return "lbf/gal imp";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMeter:
                    return "Newton Per Cubic Meter";
                case UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return "Kilonewton Per Cubic Meter";
                case UnitConverterSpecificWeightUnit.NewtonPerLiter:
                    return "Newton Per Liter";
                case UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot:
                    return "Pound Force Per Cubic Foot";
                case UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return "Kilogram Force Per Cubic Meter";
                case UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return "Millinewton Per Cubic Meter";
                case UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return "Newton Per Cubic Centimeter";
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return "Newton Per Cubic Millimeter";
                case UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot:
                    return "Ounce Force Per Cubic Foot";
                case UnitConverterSpecificWeightUnit.PoundForcePerUSGallon:
                    return "Pound Force Per US Gallon";
                case UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon:
                    return "Pound Force Per Imperial Gallon";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSpecificWeightUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.NewtonPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificWeightUnit.PoundForcePerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon:
                    return UnitConverterUnitSystem.ImperialUK;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSpecificWeightUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSpecificWeightUnit.NewtonPerCubicMeter, UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter, UnitConverterSpecificWeightUnit.NewtonPerLiter, UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter, UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter, UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter, UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot, UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterSpecificWeightUnit.PoundForcePerUSGallon };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon };
                default:
                    return new[] { UnitConverterSpecificWeightUnit.NewtonPerCubicMeter, UnitConverterSpecificWeightUnit.KilonewtonPerCubicMeter, UnitConverterSpecificWeightUnit.NewtonPerLiter, UnitConverterSpecificWeightUnit.PoundForcePerCubicFoot, UnitConverterSpecificWeightUnit.KilogramForcePerCubicMeter, UnitConverterSpecificWeightUnit.MillinewtonPerCubicMeter, UnitConverterSpecificWeightUnit.NewtonPerCubicCentimeter, UnitConverterSpecificWeightUnit.NewtonPerCubicMillimeter, UnitConverterSpecificWeightUnit.OunceForcePerCubicFoot, UnitConverterSpecificWeightUnit.PoundForcePerUSGallon, UnitConverterSpecificWeightUnit.PoundForcePerImperialGallon };
            }
        }
    }
}
