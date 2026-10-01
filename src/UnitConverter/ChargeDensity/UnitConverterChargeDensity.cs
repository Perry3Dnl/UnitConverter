namespace UnitConverter.ChargeDensity
{
    using UnitConverter.ChargeDensity.Metric;
    using UnitConverter.ChargeDensity.Scientific;
    using UnitConverter.ChargeDensity.Imperial;

    public enum UnitConverterChargeDensityUnit
    {
        CoulombPerCubicMeter = 0,
        MillicoulombPerCubicMeter = 1,
        MicrocoulombPerCubicMeter = 2,
        CoulombPerLiter = 3,
        CoulombPerCubicCentimeter = 4,
        StatcoulombPerCubicCentimeter = 5,
        NanocoulombPerCubicMeter = 6,
        CoulombPerCubicMillimeter = 7,
        CoulombPerCubicInch = 8,
        MicrocoulombPerLiter = 9,
        NanocoulombPerLiter = 10,
    }

    public static class UnitConverterChargeDensity
    {
        public static double Convert(double value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            double baseValue = ToCoulombPerCubicMeter(value, from);
            return FromCoulombPerCubicMeter(baseValue, to);
        }

        public static double ToCoulombPerCubicMeter(double value, UnitConverterChargeDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.MillicoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.MicrocoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.CoulombPerLiter:
                    return UnitConverterMetricChargeDensity.CoulombPerLiterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicCentimeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitConverterScientificChargeDensity.StatcoulombPerCubicCentimeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.NanocoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMillimeterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.CoulombPerCubicInch:
                    return UnitConverterImperialChargeDensity.CoulombPerCubicInchToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitConverterMetricChargeDensity.MicrocoulombPerLiterToCoulombPerCubicMeter(value);
                case UnitConverterChargeDensityUnit.NanocoulombPerLiter:
                    return UnitConverterMetricChargeDensity.NanocoulombPerLiterToCoulombPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported charge density unit.");
            }
        }

        public static double FromCoulombPerCubicMeter(double baseValue, UnitConverterChargeDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMeter(baseValue);
                case UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToMillicoulombPerCubicMeter(baseValue);
                case UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToMicrocoulombPerCubicMeter(baseValue);
                case UnitConverterChargeDensityUnit.CoulombPerLiter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToCoulombPerLiter(baseValue);
                case UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicCentimeter(baseValue);
                case UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitConverterScientificChargeDensity.CoulombPerCubicMeterToStatcoulombPerCubicCentimeter(baseValue);
                case UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToNanocoulombPerCubicMeter(baseValue);
                case UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMillimeter(baseValue);
                case UnitConverterChargeDensityUnit.CoulombPerCubicInch:
                    return UnitConverterImperialChargeDensity.CoulombPerCubicMeterToCoulombPerCubicInch(baseValue);
                case UnitConverterChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToMicrocoulombPerLiter(baseValue);
                case UnitConverterChargeDensityUnit.NanocoulombPerLiter:
                    return UnitConverterMetricChargeDensity.CoulombPerCubicMeterToNanocoulombPerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported charge density unit.");
            }
        }

        public static string GetSymbol(UnitConverterChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterChargeDensityUnit.CoulombPerCubicMeter:
                    return "C/m³";
                case UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter:
                    return "mC/m³";
                case UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return "µC/m³";
                case UnitConverterChargeDensityUnit.CoulombPerLiter:
                    return "C/L";
                case UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter:
                    return "C/cm³";
                case UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return "statC/cm³";
                case UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter:
                    return "nC/m³";
                case UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter:
                    return "C/mm³";
                case UnitConverterChargeDensityUnit.CoulombPerCubicInch:
                    return "C/in³";
                case UnitConverterChargeDensityUnit.MicrocoulombPerLiter:
                    return "µC/L";
                case UnitConverterChargeDensityUnit.NanocoulombPerLiter:
                    return "nC/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterChargeDensityUnit.CoulombPerCubicMeter:
                    return "Coulomb Per Cubic Meter";
                case UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter:
                    return "Millicoulomb Per Cubic Meter";
                case UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return "Microcoulomb Per Cubic Meter";
                case UnitConverterChargeDensityUnit.CoulombPerLiter:
                    return "Coulomb Per Liter";
                case UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter:
                    return "Coulomb Per Cubic Centimeter";
                case UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return "Statcoulomb Per Cubic Centimeter";
                case UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter:
                    return "Nanocoulomb Per Cubic Meter";
                case UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter:
                    return "Coulomb Per Cubic Millimeter";
                case UnitConverterChargeDensityUnit.CoulombPerCubicInch:
                    return "Coulomb Per Cubic Inch";
                case UnitConverterChargeDensityUnit.MicrocoulombPerLiter:
                    return "Microcoulomb Per Liter";
                case UnitConverterChargeDensityUnit.NanocoulombPerLiter:
                    return "Nanocoulomb Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.CoulombPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.CoulombPerCubicInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterChargeDensityUnit.NanocoulombPerLiter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterChargeDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterChargeDensityUnit.CoulombPerCubicMeter, UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter, UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter, UnitConverterChargeDensityUnit.CoulombPerLiter, UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter, UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter, UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter, UnitConverterChargeDensityUnit.MicrocoulombPerLiter, UnitConverterChargeDensityUnit.NanocoulombPerLiter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterChargeDensityUnit.CoulombPerCubicInch };
                default:
                    return new[] { UnitConverterChargeDensityUnit.CoulombPerCubicMeter, UnitConverterChargeDensityUnit.MillicoulombPerCubicMeter, UnitConverterChargeDensityUnit.MicrocoulombPerCubicMeter, UnitConverterChargeDensityUnit.CoulombPerLiter, UnitConverterChargeDensityUnit.CoulombPerCubicCentimeter, UnitConverterChargeDensityUnit.StatcoulombPerCubicCentimeter, UnitConverterChargeDensityUnit.NanocoulombPerCubicMeter, UnitConverterChargeDensityUnit.CoulombPerCubicMillimeter, UnitConverterChargeDensityUnit.CoulombPerCubicInch, UnitConverterChargeDensityUnit.MicrocoulombPerLiter, UnitConverterChargeDensityUnit.NanocoulombPerLiter };
            }
        }
    }
}
