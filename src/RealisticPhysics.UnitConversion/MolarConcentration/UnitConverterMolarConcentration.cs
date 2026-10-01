namespace RealisticPhysics.UnitConversion.MolarConcentration
{
    using RealisticPhysics.UnitConversion.MolarConcentration.Metric;

    public enum UnitConverterMolarConcentrationUnit
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

    public static class UnitConverterMolarConcentration
    {
        public static double Convert(double value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            double baseValue = ToMolePerCubicMeter(value, from);
            return FromMolePerCubicMeter(baseValue, to);
        }

        public static double ToMolePerCubicMeter(double value, UnitConverterMolarConcentrationUnit from)
        {
            switch (from)
            {
                case UnitConverterMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MolePerLiter:
                    return UnitConverterMetricMolarConcentration.MolePerLiterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.Molar:
                    return UnitConverterMetricMolarConcentration.MolarToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MillimolePerLiter:
                    return UnitConverterMetricMolarConcentration.MillimolePerLiterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MicromolePerLiter:
                    return UnitConverterMetricMolarConcentration.MicromolePerLiterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicCentimeterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.Millimolar:
                    return UnitConverterMetricMolarConcentration.MillimolarToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.Micromolar:
                    return UnitConverterMetricMolarConcentration.MicromolarToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.Nanomolar:
                    return UnitConverterMetricMolarConcentration.NanomolarToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.Picomolar:
                    return UnitConverterMetricMolarConcentration.PicomolarToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MolePerMilliliter:
                    return UnitConverterMetricMolarConcentration.MolePerMilliliterToMolePerCubicMeter(value);
                case UnitConverterMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitConverterMetricMolarConcentration.MillimolePerMilliliterToMolePerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported molar concentration unit.");
            }
        }

        public static double FromMolePerCubicMeter(double baseValue, UnitConverterMolarConcentrationUnit to)
        {
            switch (to)
            {
                case UnitConverterMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolePerCubicMeter(baseValue);
                case UnitConverterMolarConcentrationUnit.MolePerLiter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolePerLiter(baseValue);
                case UnitConverterMolarConcentrationUnit.Molar:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolar(baseValue);
                case UnitConverterMolarConcentrationUnit.MillimolePerLiter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMillimolePerLiter(baseValue);
                case UnitConverterMolarConcentrationUnit.MicromolePerLiter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMicromolePerLiter(baseValue);
                case UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolePerCubicCentimeter(baseValue);
                case UnitConverterMolarConcentrationUnit.Millimolar:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMillimolar(baseValue);
                case UnitConverterMolarConcentrationUnit.Micromolar:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMicromolar(baseValue);
                case UnitConverterMolarConcentrationUnit.Nanomolar:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToNanomolar(baseValue);
                case UnitConverterMolarConcentrationUnit.Picomolar:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToPicomolar(baseValue);
                case UnitConverterMolarConcentrationUnit.MolePerMilliliter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMolePerMilliliter(baseValue);
                case UnitConverterMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitConverterMetricMolarConcentration.MolePerCubicMeterToMillimolePerMilliliter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported molar concentration unit.");
            }
        }

        public static string GetSymbol(UnitConverterMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarConcentrationUnit.MolePerCubicMeter:
                    return "mol/m³";
                case UnitConverterMolarConcentrationUnit.MolePerLiter:
                    return "mol/L";
                case UnitConverterMolarConcentrationUnit.Molar:
                    return "M";
                case UnitConverterMolarConcentrationUnit.MillimolePerLiter:
                    return "mmol/L";
                case UnitConverterMolarConcentrationUnit.MicromolePerLiter:
                    return "µmol/L";
                case UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter:
                    return "mol/cm³";
                case UnitConverterMolarConcentrationUnit.Millimolar:
                    return "mM";
                case UnitConverterMolarConcentrationUnit.Micromolar:
                    return "µM";
                case UnitConverterMolarConcentrationUnit.Nanomolar:
                    return "nM";
                case UnitConverterMolarConcentrationUnit.Picomolar:
                    return "pM";
                case UnitConverterMolarConcentrationUnit.MolePerMilliliter:
                    return "mol/mL";
                case UnitConverterMolarConcentrationUnit.MillimolePerMilliliter:
                    return "mmol/mL";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarConcentrationUnit.MolePerCubicMeter:
                    return "Mole Per Cubic Meter";
                case UnitConverterMolarConcentrationUnit.MolePerLiter:
                    return "Mole Per Liter";
                case UnitConverterMolarConcentrationUnit.Molar:
                    return "Molar";
                case UnitConverterMolarConcentrationUnit.MillimolePerLiter:
                    return "Millimole Per Liter";
                case UnitConverterMolarConcentrationUnit.MicromolePerLiter:
                    return "Micromole Per Liter";
                case UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter:
                    return "Mole Per Cubic Centimeter";
                case UnitConverterMolarConcentrationUnit.Millimolar:
                    return "Millimolar";
                case UnitConverterMolarConcentrationUnit.Micromolar:
                    return "Micromolar";
                case UnitConverterMolarConcentrationUnit.Nanomolar:
                    return "Nanomolar";
                case UnitConverterMolarConcentrationUnit.Picomolar:
                    return "Picomolar";
                case UnitConverterMolarConcentrationUnit.MolePerMilliliter:
                    return "Mole Per Milliliter";
                case UnitConverterMolarConcentrationUnit.MillimolePerMilliliter:
                    return "Millimole Per Milliliter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMolarConcentrationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarConcentrationUnit.MolePerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MolePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.Molar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MillimolePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MicromolePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.Millimolar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.Micromolar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.Nanomolar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.Picomolar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MolePerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarConcentrationUnit.MillimolePerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMolarConcentrationUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMolarConcentrationUnit.MolePerCubicMeter, UnitConverterMolarConcentrationUnit.MolePerLiter, UnitConverterMolarConcentrationUnit.Molar, UnitConverterMolarConcentrationUnit.MillimolePerLiter, UnitConverterMolarConcentrationUnit.MicromolePerLiter, UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter, UnitConverterMolarConcentrationUnit.Millimolar, UnitConverterMolarConcentrationUnit.Micromolar, UnitConverterMolarConcentrationUnit.Nanomolar, UnitConverterMolarConcentrationUnit.Picomolar, UnitConverterMolarConcentrationUnit.MolePerMilliliter, UnitConverterMolarConcentrationUnit.MillimolePerMilliliter };
                default:
                    return new[] { UnitConverterMolarConcentrationUnit.MolePerCubicMeter, UnitConverterMolarConcentrationUnit.MolePerLiter, UnitConverterMolarConcentrationUnit.Molar, UnitConverterMolarConcentrationUnit.MillimolePerLiter, UnitConverterMolarConcentrationUnit.MicromolePerLiter, UnitConverterMolarConcentrationUnit.MolePerCubicCentimeter, UnitConverterMolarConcentrationUnit.Millimolar, UnitConverterMolarConcentrationUnit.Micromolar, UnitConverterMolarConcentrationUnit.Nanomolar, UnitConverterMolarConcentrationUnit.Picomolar, UnitConverterMolarConcentrationUnit.MolePerMilliliter, UnitConverterMolarConcentrationUnit.MillimolePerMilliliter };
            }
        }
    }
}
