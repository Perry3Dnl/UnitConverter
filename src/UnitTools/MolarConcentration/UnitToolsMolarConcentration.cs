namespace UnitTools.MolarConcentration
{
    using UnitTools.MolarConcentration.Metric;

    public enum UnitToolsMolarConcentrationUnit
    {
        MolePerCubicMeter = 0,
        MolePerLiter = 1,
        Molar = 2,
        MillimolePerLiter = 3,
        MicromolePerLiter = 4,
        MolePerCubicCentimeter = 5,
        Millimolar = 6,
        Micromolar = 7,
        Nanomolar = 8,
        Picomolar = 9,
        MolePerMilliliter = 10,
        MillimolePerMilliliter = 11,
    }

    public static class UnitToolsMolarConcentration
    {
        public static double Convert(double value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            double baseValue = ToMolePerCubicMeter(value, from);
            return FromMolePerCubicMeter(baseValue, to);
        }

        public static double ToMolePerCubicMeter(double value, UnitToolsMolarConcentrationUnit from)
        {
            switch (from)
            {
                case UnitToolsMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MolePerLiter:
                    return UnitToolsMetricMolarConcentration.MolePerLiterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.Molar:
                    return UnitToolsMetricMolarConcentration.MolarToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MillimolePerLiter:
                    return UnitToolsMetricMolarConcentration.MillimolePerLiterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MicromolePerLiter:
                    return UnitToolsMetricMolarConcentration.MicromolePerLiterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicCentimeterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.Millimolar:
                    return UnitToolsMetricMolarConcentration.MillimolarToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.Micromolar:
                    return UnitToolsMetricMolarConcentration.MicromolarToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.Nanomolar:
                    return UnitToolsMetricMolarConcentration.NanomolarToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.Picomolar:
                    return UnitToolsMetricMolarConcentration.PicomolarToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MolePerMilliliter:
                    return UnitToolsMetricMolarConcentration.MolePerMilliliterToMolePerCubicMeter(value);
                case UnitToolsMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitToolsMetricMolarConcentration.MillimolePerMilliliterToMolePerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported molar concentration unit.");
            }
        }

        public static double FromMolePerCubicMeter(double baseValue, UnitToolsMolarConcentrationUnit to)
        {
            switch (to)
            {
                case UnitToolsMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolePerCubicMeter(baseValue);
                case UnitToolsMolarConcentrationUnit.MolePerLiter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolePerLiter(baseValue);
                case UnitToolsMolarConcentrationUnit.Molar:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolar(baseValue);
                case UnitToolsMolarConcentrationUnit.MillimolePerLiter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMillimolePerLiter(baseValue);
                case UnitToolsMolarConcentrationUnit.MicromolePerLiter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMicromolePerLiter(baseValue);
                case UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolePerCubicCentimeter(baseValue);
                case UnitToolsMolarConcentrationUnit.Millimolar:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMillimolar(baseValue);
                case UnitToolsMolarConcentrationUnit.Micromolar:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMicromolar(baseValue);
                case UnitToolsMolarConcentrationUnit.Nanomolar:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToNanomolar(baseValue);
                case UnitToolsMolarConcentrationUnit.Picomolar:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToPicomolar(baseValue);
                case UnitToolsMolarConcentrationUnit.MolePerMilliliter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMolePerMilliliter(baseValue);
                case UnitToolsMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitToolsMetricMolarConcentration.MolePerCubicMeterToMillimolePerMilliliter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported molar concentration unit.");
            }
        }

        public static string GetSymbol(UnitToolsMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarConcentrationUnit.MolePerCubicMeter:
                    return "mol/m³";
                case UnitToolsMolarConcentrationUnit.MolePerLiter:
                    return "mol/L";
                case UnitToolsMolarConcentrationUnit.Molar:
                    return "M";
                case UnitToolsMolarConcentrationUnit.MillimolePerLiter:
                    return "mmol/L";
                case UnitToolsMolarConcentrationUnit.MicromolePerLiter:
                    return "µmol/L";
                case UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter:
                    return "mol/cm³";
                case UnitToolsMolarConcentrationUnit.Millimolar:
                    return "mM";
                case UnitToolsMolarConcentrationUnit.Micromolar:
                    return "µM";
                case UnitToolsMolarConcentrationUnit.Nanomolar:
                    return "nM";
                case UnitToolsMolarConcentrationUnit.Picomolar:
                    return "pM";
                case UnitToolsMolarConcentrationUnit.MolePerMilliliter:
                    return "mol/mL";
                case UnitToolsMolarConcentrationUnit.MillimolePerMilliliter:
                    return "mmol/mL";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarConcentrationUnit.MolePerCubicMeter:
                    return "Mole Per Cubic Meter";
                case UnitToolsMolarConcentrationUnit.MolePerLiter:
                    return "Mole Per Liter";
                case UnitToolsMolarConcentrationUnit.Molar:
                    return "Molar";
                case UnitToolsMolarConcentrationUnit.MillimolePerLiter:
                    return "Millimole Per Liter";
                case UnitToolsMolarConcentrationUnit.MicromolePerLiter:
                    return "Micromole Per Liter";
                case UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter:
                    return "Mole Per Cubic Centimeter";
                case UnitToolsMolarConcentrationUnit.Millimolar:
                    return "Millimolar";
                case UnitToolsMolarConcentrationUnit.Micromolar:
                    return "Micromolar";
                case UnitToolsMolarConcentrationUnit.Nanomolar:
                    return "Nanomolar";
                case UnitToolsMolarConcentrationUnit.Picomolar:
                    return "Picomolar";
                case UnitToolsMolarConcentrationUnit.MolePerMilliliter:
                    return "Mole Per Milliliter";
                case UnitToolsMolarConcentrationUnit.MillimolePerMilliliter:
                    return "Millimole Per Milliliter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MolePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.Molar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MillimolePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MicromolePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.Millimolar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.Micromolar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.Nanomolar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.Picomolar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MolePerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMolarConcentrationUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMolarConcentrationUnit.MolePerCubicMeter, UnitToolsMolarConcentrationUnit.MolePerLiter, UnitToolsMolarConcentrationUnit.Molar, UnitToolsMolarConcentrationUnit.MillimolePerLiter, UnitToolsMolarConcentrationUnit.MicromolePerLiter, UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter, UnitToolsMolarConcentrationUnit.Millimolar, UnitToolsMolarConcentrationUnit.Micromolar, UnitToolsMolarConcentrationUnit.Nanomolar, UnitToolsMolarConcentrationUnit.Picomolar, UnitToolsMolarConcentrationUnit.MolePerMilliliter, UnitToolsMolarConcentrationUnit.MillimolePerMilliliter };
                default:
                    return new[] { UnitToolsMolarConcentrationUnit.MolePerCubicMeter, UnitToolsMolarConcentrationUnit.MolePerLiter, UnitToolsMolarConcentrationUnit.Molar, UnitToolsMolarConcentrationUnit.MillimolePerLiter, UnitToolsMolarConcentrationUnit.MicromolePerLiter, UnitToolsMolarConcentrationUnit.MolePerCubicCentimeter, UnitToolsMolarConcentrationUnit.Millimolar, UnitToolsMolarConcentrationUnit.Micromolar, UnitToolsMolarConcentrationUnit.Nanomolar, UnitToolsMolarConcentrationUnit.Picomolar, UnitToolsMolarConcentrationUnit.MolePerMilliliter, UnitToolsMolarConcentrationUnit.MillimolePerMilliliter };
            }
        }
    }
}
