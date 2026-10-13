namespace UnitTools.ElectricFluxDensity
{
    using UnitTools.ElectricFluxDensity.Metric;
    using UnitTools.ElectricFluxDensity.Scientific;
    using UnitTools.ElectricFluxDensity.Imperial;

    public enum UnitToolsElectricFluxDensityUnit
    {
        CoulombPerSquareMeter = 0,
        MillicoulombPerSquareMeter = 1,
        MicrocoulombPerSquareMeter = 2,
        CoulombPerSquareCentimeter = 3,
        StatcoulombPerSquareCentimeter = 4,
        NanocoulombPerSquareMeter = 5,
        CoulombPerSquareInch = 6,
        CoulombPerSquareFoot = 7,
        MicrocoulombPerSquareCentimeter = 8,
        NanocoulombPerSquareCentimeter = 9,
    }

    public static class UnitToolsElectricFluxDensity
    {
        public static double Convert(double value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            double baseValue = ToCoulombPerSquareMeter(value, from);
            return FromCoulombPerSquareMeter(baseValue, to);
        }

        public static double ToCoulombPerSquareMeter(double value, UnitToolsElectricFluxDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.MillicoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.MicrocoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitToolsScientificElectricFluxDensity.StatcoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.NanocoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitToolsImperialElectricFluxDensity.CoulombPerSquareInchToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitToolsImperialElectricFluxDensity.CoulombPerSquareFootToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.MicrocoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.NanocoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric flux density unit.");
            }
        }

        public static double FromCoulombPerSquareMeter(double baseValue, UnitToolsElectricFluxDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareMeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToMillicoulombPerSquareMeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToMicrocoulombPerSquareMeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareCentimeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitToolsScientificElectricFluxDensity.CoulombPerSquareMeterToStatcoulombPerSquareCentimeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToNanocoulombPerSquareMeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitToolsImperialElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareInch(baseValue);
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitToolsImperialElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareFoot(baseValue);
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToMicrocoulombPerSquareCentimeter(baseValue);
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitToolsMetricElectricFluxDensity.CoulombPerSquareMeterToNanocoulombPerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric flux density unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return "C/m²";
                case UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return "mC/m²";
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return "µC/m²";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return "C/cm²";
                case UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return "statC/cm²";
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return "nC/m²";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch:
                    return "C/in²";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return "C/ft²";
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return "µC/cm²";
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return "nC/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return "Coulomb Per Square Meter";
                case UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return "Millicoulomb Per Square Meter";
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return "Microcoulomb Per Square Meter";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return "Coulomb Per Square Centimeter";
                case UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return "Statcoulomb Per Square Centimeter";
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return "Nanocoulomb Per Square Meter";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch:
                    return "Coulomb Per Square Inch";
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return "Coulomb Per Square Foot";
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return "Microcoulomb Per Square Centimeter";
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return "Nanocoulomb Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricFluxDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter, UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch, UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot };
                default:
                    return new[] { UnitToolsElectricFluxDensityUnit.CoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.MillicoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.CoulombPerSquareCentimeter, UnitToolsElectricFluxDensityUnit.StatcoulombPerSquareCentimeter, UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareMeter, UnitToolsElectricFluxDensityUnit.CoulombPerSquareInch, UnitToolsElectricFluxDensityUnit.CoulombPerSquareFoot, UnitToolsElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, UnitToolsElectricFluxDensityUnit.NanocoulombPerSquareCentimeter };
            }
        }
    }
}
