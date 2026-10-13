namespace UnitTools.PressureGradient
{
    using UnitTools.PressureGradient.Metric;
    using UnitTools.PressureGradient.Imperial;

    public enum UnitToolsPressureGradientUnit
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

    public static class UnitToolsPressureGradient
    {
        public static double Convert(double value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            double baseValue = ToPascalPerMeter(value, from);
            return FromPascalPerMeter(baseValue, to);
        }

        public static double ToPascalPerMeter(double value, UnitToolsPressureGradientUnit from)
        {
            switch (from)
            {
                case UnitToolsPressureGradientUnit.PascalPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.KilopascalPerMeter:
                    return UnitToolsMetricPressureGradient.KilopascalPerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.PascalPerCentimeter:
                    return UnitToolsMetricPressureGradient.PascalPerCentimeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.BarPerMeter:
                    return UnitToolsMetricPressureGradient.BarPerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitToolsMetricPressureGradient.MillimeterMercuryPerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.PsiPerFoot:
                    return UnitToolsImperialPressureGradient.PsiPerFootToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.PascalPerMillimeter:
                    return UnitToolsMetricPressureGradient.PascalPerMillimeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.MegapascalPerMeter:
                    return UnitToolsMetricPressureGradient.MegapascalPerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitToolsMetricPressureGradient.KilopascalPerCentimeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.BarPerCentimeter:
                    return UnitToolsMetricPressureGradient.BarPerCentimeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.AtmospherePerMeter:
                    return UnitToolsMetricPressureGradient.AtmospherePerMeterToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.PsiPerInch:
                    return UnitToolsImperialPressureGradient.PsiPerInchToPascalPerMeter(value);
                case UnitToolsPressureGradientUnit.InchMercuryPerFoot:
                    return UnitToolsImperialPressureGradient.InchMercuryPerFootToPascalPerMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported pressure gradient unit.");
            }
        }

        public static double FromPascalPerMeter(double baseValue, UnitToolsPressureGradientUnit to)
        {
            switch (to)
            {
                case UnitToolsPressureGradientUnit.PascalPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToPascalPerMeter(baseValue);
                case UnitToolsPressureGradientUnit.KilopascalPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToKilopascalPerMeter(baseValue);
                case UnitToolsPressureGradientUnit.PascalPerCentimeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToPascalPerCentimeter(baseValue);
                case UnitToolsPressureGradientUnit.BarPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToBarPerMeter(baseValue);
                case UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToMillimeterMercuryPerMeter(baseValue);
                case UnitToolsPressureGradientUnit.PsiPerFoot:
                    return UnitToolsImperialPressureGradient.PascalPerMeterToPsiPerFoot(baseValue);
                case UnitToolsPressureGradientUnit.PascalPerMillimeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToPascalPerMillimeter(baseValue);
                case UnitToolsPressureGradientUnit.MegapascalPerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToMegapascalPerMeter(baseValue);
                case UnitToolsPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToKilopascalPerCentimeter(baseValue);
                case UnitToolsPressureGradientUnit.BarPerCentimeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToBarPerCentimeter(baseValue);
                case UnitToolsPressureGradientUnit.AtmospherePerMeter:
                    return UnitToolsMetricPressureGradient.PascalPerMeterToAtmospherePerMeter(baseValue);
                case UnitToolsPressureGradientUnit.PsiPerInch:
                    return UnitToolsImperialPressureGradient.PascalPerMeterToPsiPerInch(baseValue);
                case UnitToolsPressureGradientUnit.InchMercuryPerFoot:
                    return UnitToolsImperialPressureGradient.PascalPerMeterToInchMercuryPerFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported pressure gradient unit.");
            }
        }

        public static string GetSymbol(UnitToolsPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureGradientUnit.PascalPerMeter:
                    return "Pa/m";
                case UnitToolsPressureGradientUnit.KilopascalPerMeter:
                    return "kPa/m";
                case UnitToolsPressureGradientUnit.PascalPerCentimeter:
                    return "Pa/cm";
                case UnitToolsPressureGradientUnit.BarPerMeter:
                    return "bar/m";
                case UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter:
                    return "mmHg/m";
                case UnitToolsPressureGradientUnit.PsiPerFoot:
                    return "psi/ft";
                case UnitToolsPressureGradientUnit.PascalPerMillimeter:
                    return "Pa/mm";
                case UnitToolsPressureGradientUnit.MegapascalPerMeter:
                    return "MPa/m";
                case UnitToolsPressureGradientUnit.KilopascalPerCentimeter:
                    return "kPa/cm";
                case UnitToolsPressureGradientUnit.BarPerCentimeter:
                    return "bar/cm";
                case UnitToolsPressureGradientUnit.AtmospherePerMeter:
                    return "atm/m";
                case UnitToolsPressureGradientUnit.PsiPerInch:
                    return "psi/in";
                case UnitToolsPressureGradientUnit.InchMercuryPerFoot:
                    return "inHg/ft";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureGradientUnit.PascalPerMeter:
                    return "Pascal Per Meter";
                case UnitToolsPressureGradientUnit.KilopascalPerMeter:
                    return "Kilopascal Per Meter";
                case UnitToolsPressureGradientUnit.PascalPerCentimeter:
                    return "Pascal Per Centimeter";
                case UnitToolsPressureGradientUnit.BarPerMeter:
                    return "Bar Per Meter";
                case UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter:
                    return "Millimeter Mercury Per Meter";
                case UnitToolsPressureGradientUnit.PsiPerFoot:
                    return "Psi Per Foot";
                case UnitToolsPressureGradientUnit.PascalPerMillimeter:
                    return "Pascal Per Millimeter";
                case UnitToolsPressureGradientUnit.MegapascalPerMeter:
                    return "Megapascal Per Meter";
                case UnitToolsPressureGradientUnit.KilopascalPerCentimeter:
                    return "Kilopascal Per Centimeter";
                case UnitToolsPressureGradientUnit.BarPerCentimeter:
                    return "Bar Per Centimeter";
                case UnitToolsPressureGradientUnit.AtmospherePerMeter:
                    return "Atmosphere Per Meter";
                case UnitToolsPressureGradientUnit.PsiPerInch:
                    return "Psi Per Inch";
                case UnitToolsPressureGradientUnit.InchMercuryPerFoot:
                    return "Inch Mercury Per Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPressureGradientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPressureGradientUnit.PascalPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.KilopascalPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.PascalPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.BarPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.PsiPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureGradientUnit.PascalPerMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.MegapascalPerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.KilopascalPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.BarPerCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.AtmospherePerMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPressureGradientUnit.PsiPerInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPressureGradientUnit.InchMercuryPerFoot:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPressureGradientUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPressureGradientUnit.PascalPerMeter, UnitToolsPressureGradientUnit.KilopascalPerMeter, UnitToolsPressureGradientUnit.PascalPerCentimeter, UnitToolsPressureGradientUnit.BarPerMeter, UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter, UnitToolsPressureGradientUnit.PascalPerMillimeter, UnitToolsPressureGradientUnit.MegapascalPerMeter, UnitToolsPressureGradientUnit.KilopascalPerCentimeter, UnitToolsPressureGradientUnit.BarPerCentimeter, UnitToolsPressureGradientUnit.AtmospherePerMeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPressureGradientUnit.PsiPerFoot, UnitToolsPressureGradientUnit.PsiPerInch, UnitToolsPressureGradientUnit.InchMercuryPerFoot };
                default:
                    return new[] { UnitToolsPressureGradientUnit.PascalPerMeter, UnitToolsPressureGradientUnit.KilopascalPerMeter, UnitToolsPressureGradientUnit.PascalPerCentimeter, UnitToolsPressureGradientUnit.BarPerMeter, UnitToolsPressureGradientUnit.MillimeterMercuryPerMeter, UnitToolsPressureGradientUnit.PsiPerFoot, UnitToolsPressureGradientUnit.PascalPerMillimeter, UnitToolsPressureGradientUnit.MegapascalPerMeter, UnitToolsPressureGradientUnit.KilopascalPerCentimeter, UnitToolsPressureGradientUnit.BarPerCentimeter, UnitToolsPressureGradientUnit.AtmospherePerMeter, UnitToolsPressureGradientUnit.PsiPerInch, UnitToolsPressureGradientUnit.InchMercuryPerFoot };
            }
        }
    }
}
