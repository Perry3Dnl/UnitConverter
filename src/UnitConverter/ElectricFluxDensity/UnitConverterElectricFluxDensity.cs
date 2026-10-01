namespace UnitConverter.ElectricFluxDensity
{
    using UnitConverter.ElectricFluxDensity.Metric;
    using UnitConverter.ElectricFluxDensity.Scientific;
    using UnitConverter.ElectricFluxDensity.Imperial;

    public enum UnitConverterElectricFluxDensityUnit
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

    public static class UnitConverterElectricFluxDensity
    {
        public static double Convert(double value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            double baseValue = ToCoulombPerSquareMeter(value, from);
            return FromCoulombPerSquareMeter(baseValue, to);
        }

        public static double ToCoulombPerSquareMeter(double value, UnitConverterElectricFluxDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.MillicoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.MicrocoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitConverterScientificElectricFluxDensity.StatcoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.NanocoulombPerSquareMeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitConverterImperialElectricFluxDensity.CoulombPerSquareInchToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitConverterImperialElectricFluxDensity.CoulombPerSquareFootToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.MicrocoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.NanocoulombPerSquareCentimeterToCoulombPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric flux density unit.");
            }
        }

        public static double FromCoulombPerSquareMeter(double baseValue, UnitConverterElectricFluxDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareMeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToMillicoulombPerSquareMeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToMicrocoulombPerSquareMeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareCentimeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitConverterScientificElectricFluxDensity.CoulombPerSquareMeterToStatcoulombPerSquareCentimeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToNanocoulombPerSquareMeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitConverterImperialElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareInch(baseValue);
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitConverterImperialElectricFluxDensity.CoulombPerSquareMeterToCoulombPerSquareFoot(baseValue);
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToMicrocoulombPerSquareCentimeter(baseValue);
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitConverterMetricElectricFluxDensity.CoulombPerSquareMeterToNanocoulombPerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric flux density unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return "C/m²";
                case UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return "mC/m²";
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return "µC/m²";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return "C/cm²";
                case UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return "statC/cm²";
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return "nC/m²";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch:
                    return "C/in²";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return "C/ft²";
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return "µC/cm²";
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return "nC/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return "Coulomb Per Square Meter";
                case UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return "Millicoulomb Per Square Meter";
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return "Microcoulomb Per Square Meter";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return "Coulomb Per Square Centimeter";
                case UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return "Statcoulomb Per Square Centimeter";
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return "Nanocoulomb Per Square Meter";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch:
                    return "Coulomb Per Square Inch";
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return "Coulomb Per Square Foot";
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return "Microcoulomb Per Square Centimeter";
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return "Nanocoulomb Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricFluxDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricFluxDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter, UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch, UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot };
                default:
                    return new[] { UnitConverterElectricFluxDensityUnit.CoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.MillicoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.CoulombPerSquareCentimeter, UnitConverterElectricFluxDensityUnit.StatcoulombPerSquareCentimeter, UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareMeter, UnitConverterElectricFluxDensityUnit.CoulombPerSquareInch, UnitConverterElectricFluxDensityUnit.CoulombPerSquareFoot, UnitConverterElectricFluxDensityUnit.MicrocoulombPerSquareCentimeter, UnitConverterElectricFluxDensityUnit.NanocoulombPerSquareCentimeter };
            }
        }
    }
}
