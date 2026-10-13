namespace UnitTools.ChargeDensity
{
    using UnitTools.ChargeDensity.Metric;
    using UnitTools.ChargeDensity.Scientific;
    using UnitTools.ChargeDensity.Imperial;

    public enum UnitToolsChargeDensityUnit
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

    public static class UnitToolsChargeDensity
    {
        public static double Convert(double value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            double baseValue = ToCoulombPerCubicMeter(value, from);
            return FromCoulombPerCubicMeter(baseValue, to);
        }

        public static double ToCoulombPerCubicMeter(double value, UnitToolsChargeDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.MillicoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.MicrocoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.CoulombPerLiter:
                    return UnitToolsMetricChargeDensity.CoulombPerLiterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicCentimeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitToolsScientificChargeDensity.StatcoulombPerCubicCentimeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.NanocoulombPerCubicMeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMillimeterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.CoulombPerCubicInch:
                    return UnitToolsImperialChargeDensity.CoulombPerCubicInchToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitToolsMetricChargeDensity.MicrocoulombPerLiterToCoulombPerCubicMeter(value);
                case UnitToolsChargeDensityUnit.NanocoulombPerLiter:
                    return UnitToolsMetricChargeDensity.NanocoulombPerLiterToCoulombPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported charge density unit.");
            }
        }

        public static double FromCoulombPerCubicMeter(double baseValue, UnitToolsChargeDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMeter(baseValue);
                case UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToMillicoulombPerCubicMeter(baseValue);
                case UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToMicrocoulombPerCubicMeter(baseValue);
                case UnitToolsChargeDensityUnit.CoulombPerLiter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToCoulombPerLiter(baseValue);
                case UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicCentimeter(baseValue);
                case UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitToolsScientificChargeDensity.CoulombPerCubicMeterToStatcoulombPerCubicCentimeter(baseValue);
                case UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToNanocoulombPerCubicMeter(baseValue);
                case UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToCoulombPerCubicMillimeter(baseValue);
                case UnitToolsChargeDensityUnit.CoulombPerCubicInch:
                    return UnitToolsImperialChargeDensity.CoulombPerCubicMeterToCoulombPerCubicInch(baseValue);
                case UnitToolsChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToMicrocoulombPerLiter(baseValue);
                case UnitToolsChargeDensityUnit.NanocoulombPerLiter:
                    return UnitToolsMetricChargeDensity.CoulombPerCubicMeterToNanocoulombPerLiter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported charge density unit.");
            }
        }

        public static string GetSymbol(UnitToolsChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsChargeDensityUnit.CoulombPerCubicMeter:
                    return "C/m³";
                case UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter:
                    return "mC/m³";
                case UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return "µC/m³";
                case UnitToolsChargeDensityUnit.CoulombPerLiter:
                    return "C/L";
                case UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter:
                    return "C/cm³";
                case UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return "statC/cm³";
                case UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter:
                    return "nC/m³";
                case UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter:
                    return "C/mm³";
                case UnitToolsChargeDensityUnit.CoulombPerCubicInch:
                    return "C/in³";
                case UnitToolsChargeDensityUnit.MicrocoulombPerLiter:
                    return "µC/L";
                case UnitToolsChargeDensityUnit.NanocoulombPerLiter:
                    return "nC/L";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsChargeDensityUnit.CoulombPerCubicMeter:
                    return "Coulomb Per Cubic Meter";
                case UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter:
                    return "Millicoulomb Per Cubic Meter";
                case UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return "Microcoulomb Per Cubic Meter";
                case UnitToolsChargeDensityUnit.CoulombPerLiter:
                    return "Coulomb Per Liter";
                case UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter:
                    return "Coulomb Per Cubic Centimeter";
                case UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return "Statcoulomb Per Cubic Centimeter";
                case UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter:
                    return "Nanocoulomb Per Cubic Meter";
                case UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter:
                    return "Coulomb Per Cubic Millimeter";
                case UnitToolsChargeDensityUnit.CoulombPerCubicInch:
                    return "Coulomb Per Cubic Inch";
                case UnitToolsChargeDensityUnit.MicrocoulombPerLiter:
                    return "Microcoulomb Per Liter";
                case UnitToolsChargeDensityUnit.NanocoulombPerLiter:
                    return "Nanocoulomb Per Liter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsChargeDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsChargeDensityUnit.CoulombPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.CoulombPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.CoulombPerCubicInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsChargeDensityUnit.MicrocoulombPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsChargeDensityUnit.NanocoulombPerLiter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsChargeDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsChargeDensityUnit.CoulombPerCubicMeter, UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter, UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter, UnitToolsChargeDensityUnit.CoulombPerLiter, UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter, UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter, UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter, UnitToolsChargeDensityUnit.MicrocoulombPerLiter, UnitToolsChargeDensityUnit.NanocoulombPerLiter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsChargeDensityUnit.CoulombPerCubicInch };
                default:
                    return new[] { UnitToolsChargeDensityUnit.CoulombPerCubicMeter, UnitToolsChargeDensityUnit.MillicoulombPerCubicMeter, UnitToolsChargeDensityUnit.MicrocoulombPerCubicMeter, UnitToolsChargeDensityUnit.CoulombPerLiter, UnitToolsChargeDensityUnit.CoulombPerCubicCentimeter, UnitToolsChargeDensityUnit.StatcoulombPerCubicCentimeter, UnitToolsChargeDensityUnit.NanocoulombPerCubicMeter, UnitToolsChargeDensityUnit.CoulombPerCubicMillimeter, UnitToolsChargeDensityUnit.CoulombPerCubicInch, UnitToolsChargeDensityUnit.MicrocoulombPerLiter, UnitToolsChargeDensityUnit.NanocoulombPerLiter };
            }
        }
    }
}
