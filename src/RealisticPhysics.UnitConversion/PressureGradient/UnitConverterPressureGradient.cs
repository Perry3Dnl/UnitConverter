namespace RealisticPhysics.UnitConversion.PressureGradient
{
    using RealisticPhysics.UnitConversion.PressureGradient.Metric;
    using RealisticPhysics.UnitConversion.PressureGradient.Imperial;

    public enum UnitConverterPressureGradientUnit
    {
        PascalPerMeter = 0,
        KilopascalPerMeter = 1,
        PascalPerCentimeter = 2,
        BarPerMeter = 3,
        MillimeterMercuryPerMeter = 4,
        PsiPerFoot = 5,
        PascalPerMillimeter = 6,
        MegapascalPerMeter = 7,
        KilopascalPerCentimeter = 8,
        BarPerCentimeter = 9,
        AtmospherePerMeter = 10,
        PsiPerInch = 11,
        InchMercuryPerFoot = 12,
    }

    public static class UnitConverterPressureGradient
    {
        public static double Convert(double value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            double baseValue = ToPascalPerMeter(value, from);
            return FromPascalPerMeter(baseValue, to);
        }

        public static double ToPascalPerMeter(double value, UnitConverterPressureGradientUnit from)
        {
            switch (from)
            {
                case UnitConverterPressureGradientUnit.PascalPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.KilopascalPerMeter:
                    return UnitConverterMetricPressureGradient.KilopascalPerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.PascalPerCentimeter:
                    return UnitConverterMetricPressureGradient.PascalPerCentimeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.BarPerMeter:
                    return UnitConverterMetricPressureGradient.BarPerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitConverterMetricPressureGradient.MillimeterMercuryPerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.PsiPerFoot:
                    return UnitConverterImperialPressureGradient.PsiPerFootToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.PascalPerMillimeter:
                    return UnitConverterMetricPressureGradient.PascalPerMillimeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.MegapascalPerMeter:
                    return UnitConverterMetricPressureGradient.MegapascalPerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitConverterMetricPressureGradient.KilopascalPerCentimeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.BarPerCentimeter:
                    return UnitConverterMetricPressureGradient.BarPerCentimeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.AtmospherePerMeter:
                    return UnitConverterMetricPressureGradient.AtmospherePerMeterToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.PsiPerInch:
                    return UnitConverterImperialPressureGradient.PsiPerInchToPascalPerMeter(value);
                case UnitConverterPressureGradientUnit.InchMercuryPerFoot:
                    return UnitConverterImperialPressureGradient.InchMercuryPerFootToPascalPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pressure gradient unit.");
            }
        }

        public static double FromPascalPerMeter(double baseValue, UnitConverterPressureGradientUnit to)
        {
            switch (to)
            {
                case UnitConverterPressureGradientUnit.PascalPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToPascalPerMeter(baseValue);
                case UnitConverterPressureGradientUnit.KilopascalPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToKilopascalPerMeter(baseValue);
                case UnitConverterPressureGradientUnit.PascalPerCentimeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToPascalPerCentimeter(baseValue);
                case UnitConverterPressureGradientUnit.BarPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToBarPerMeter(baseValue);
                case UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToMillimeterMercuryPerMeter(baseValue);
                case UnitConverterPressureGradientUnit.PsiPerFoot:
                    return UnitConverterImperialPressureGradient.PascalPerMeterToPsiPerFoot(baseValue);
                case UnitConverterPressureGradientUnit.PascalPerMillimeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToPascalPerMillimeter(baseValue);
                case UnitConverterPressureGradientUnit.MegapascalPerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToMegapascalPerMeter(baseValue);
                case UnitConverterPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToKilopascalPerCentimeter(baseValue);
                case UnitConverterPressureGradientUnit.BarPerCentimeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToBarPerCentimeter(baseValue);
                case UnitConverterPressureGradientUnit.AtmospherePerMeter:
                    return UnitConverterMetricPressureGradient.PascalPerMeterToAtmospherePerMeter(baseValue);
                case UnitConverterPressureGradientUnit.PsiPerInch:
                    return UnitConverterImperialPressureGradient.PascalPerMeterToPsiPerInch(baseValue);
                case UnitConverterPressureGradientUnit.InchMercuryPerFoot:
                    return UnitConverterImperialPressureGradient.PascalPerMeterToInchMercuryPerFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pressure gradient unit.");
            }
        }

        public static string GetSymbol(UnitConverterPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureGradientUnit.PascalPerMeter:
                    return "Pa/m";
                case UnitConverterPressureGradientUnit.KilopascalPerMeter:
                    return "kPa/m";
                case UnitConverterPressureGradientUnit.PascalPerCentimeter:
                    return "Pa/cm";
                case UnitConverterPressureGradientUnit.BarPerMeter:
                    return "bar/m";
                case UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter:
                    return "mmHg/m";
                case UnitConverterPressureGradientUnit.PsiPerFoot:
                    return "psi/ft";
                case UnitConverterPressureGradientUnit.PascalPerMillimeter:
                    return "Pa/mm";
                case UnitConverterPressureGradientUnit.MegapascalPerMeter:
                    return "MPa/m";
                case UnitConverterPressureGradientUnit.KilopascalPerCentimeter:
                    return "kPa/cm";
                case UnitConverterPressureGradientUnit.BarPerCentimeter:
                    return "bar/cm";
                case UnitConverterPressureGradientUnit.AtmospherePerMeter:
                    return "atm/m";
                case UnitConverterPressureGradientUnit.PsiPerInch:
                    return "psi/in";
                case UnitConverterPressureGradientUnit.InchMercuryPerFoot:
                    return "inHg/ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureGradientUnit.PascalPerMeter:
                    return "Pascal Per Meter";
                case UnitConverterPressureGradientUnit.KilopascalPerMeter:
                    return "Kilopascal Per Meter";
                case UnitConverterPressureGradientUnit.PascalPerCentimeter:
                    return "Pascal Per Centimeter";
                case UnitConverterPressureGradientUnit.BarPerMeter:
                    return "Bar Per Meter";
                case UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter:
                    return "Millimeter Mercury Per Meter";
                case UnitConverterPressureGradientUnit.PsiPerFoot:
                    return "Psi Per Foot";
                case UnitConverterPressureGradientUnit.PascalPerMillimeter:
                    return "Pascal Per Millimeter";
                case UnitConverterPressureGradientUnit.MegapascalPerMeter:
                    return "Megapascal Per Meter";
                case UnitConverterPressureGradientUnit.KilopascalPerCentimeter:
                    return "Kilopascal Per Centimeter";
                case UnitConverterPressureGradientUnit.BarPerCentimeter:
                    return "Bar Per Centimeter";
                case UnitConverterPressureGradientUnit.AtmospherePerMeter:
                    return "Atmosphere Per Meter";
                case UnitConverterPressureGradientUnit.PsiPerInch:
                    return "Psi Per Inch";
                case UnitConverterPressureGradientUnit.InchMercuryPerFoot:
                    return "Inch Mercury Per Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureGradientUnit.PascalPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.KilopascalPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.PascalPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.BarPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.PsiPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureGradientUnit.PascalPerMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.MegapascalPerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.BarPerCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.AtmospherePerMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPressureGradientUnit.PsiPerInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPressureGradientUnit.InchMercuryPerFoot:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPressureGradientUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPressureGradientUnit.PascalPerMeter, UnitConverterPressureGradientUnit.KilopascalPerMeter, UnitConverterPressureGradientUnit.PascalPerCentimeter, UnitConverterPressureGradientUnit.BarPerMeter, UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter, UnitConverterPressureGradientUnit.PascalPerMillimeter, UnitConverterPressureGradientUnit.MegapascalPerMeter, UnitConverterPressureGradientUnit.KilopascalPerCentimeter, UnitConverterPressureGradientUnit.BarPerCentimeter, UnitConverterPressureGradientUnit.AtmospherePerMeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPressureGradientUnit.PsiPerFoot, UnitConverterPressureGradientUnit.PsiPerInch, UnitConverterPressureGradientUnit.InchMercuryPerFoot };
                default:
                    return new[] { UnitConverterPressureGradientUnit.PascalPerMeter, UnitConverterPressureGradientUnit.KilopascalPerMeter, UnitConverterPressureGradientUnit.PascalPerCentimeter, UnitConverterPressureGradientUnit.BarPerMeter, UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter, UnitConverterPressureGradientUnit.PsiPerFoot, UnitConverterPressureGradientUnit.PascalPerMillimeter, UnitConverterPressureGradientUnit.MegapascalPerMeter, UnitConverterPressureGradientUnit.KilopascalPerCentimeter, UnitConverterPressureGradientUnit.BarPerCentimeter, UnitConverterPressureGradientUnit.AtmospherePerMeter, UnitConverterPressureGradientUnit.PsiPerInch, UnitConverterPressureGradientUnit.InchMercuryPerFoot };
            }
        }
    }
}
