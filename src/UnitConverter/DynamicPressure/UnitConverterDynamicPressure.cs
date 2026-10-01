namespace UnitConverter.DynamicPressure
{
    using UnitConverter.DynamicPressure.Metric;
    using UnitConverter.DynamicPressure.Imperial;
    using UnitConverter.DynamicPressure.Engineering;

    public enum UnitConverterDynamicPressureUnit
    {
        Pascal = 0,
        Kilopascal = 1,
        Megapascal = 2,
        Bar = 3,
        Atmosphere = 4,
        Psi = 5,
        Psf = 6,
        Hectopascal = 7,
        Millibar = 8,
        Torr = 9,
        MillimeterMercury = 10,
        InchMercury = 11,
        InchWater = 12,
        FootWater = 13,
        KilogramForcePerSquareCentimeter = 14,
    }

    public static class UnitConverterDynamicPressure
    {
        public static double Convert(double value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitConverterDynamicPressureUnit from)
        {
            switch (from)
            {
                case UnitConverterDynamicPressureUnit.Pascal:
                    return UnitConverterMetricDynamicPressure.PascalToPascal(value);
                case UnitConverterDynamicPressureUnit.Kilopascal:
                    return UnitConverterMetricDynamicPressure.KilopascalToPascal(value);
                case UnitConverterDynamicPressureUnit.Megapascal:
                    return UnitConverterMetricDynamicPressure.MegapascalToPascal(value);
                case UnitConverterDynamicPressureUnit.Bar:
                    return UnitConverterMetricDynamicPressure.BarToPascal(value);
                case UnitConverterDynamicPressureUnit.Atmosphere:
                    return UnitConverterMetricDynamicPressure.AtmosphereToPascal(value);
                case UnitConverterDynamicPressureUnit.Psi:
                    return UnitConverterImperialDynamicPressure.PsiToPascal(value);
                case UnitConverterDynamicPressureUnit.Psf:
                    return UnitConverterImperialDynamicPressure.PsfToPascal(value);
                case UnitConverterDynamicPressureUnit.Hectopascal:
                    return UnitConverterMetricDynamicPressure.HectopascalToPascal(value);
                case UnitConverterDynamicPressureUnit.Millibar:
                    return UnitConverterMetricDynamicPressure.MillibarToPascal(value);
                case UnitConverterDynamicPressureUnit.Torr:
                    return UnitConverterMetricDynamicPressure.TorrToPascal(value);
                case UnitConverterDynamicPressureUnit.MillimeterMercury:
                    return UnitConverterMetricDynamicPressure.MillimeterMercuryToPascal(value);
                case UnitConverterDynamicPressureUnit.InchMercury:
                    return UnitConverterImperialDynamicPressure.InchMercuryToPascal(value);
                case UnitConverterDynamicPressureUnit.InchWater:
                    return UnitConverterImperialDynamicPressure.InchWaterToPascal(value);
                case UnitConverterDynamicPressureUnit.FootWater:
                    return UnitConverterImperialDynamicPressure.FootWaterToPascal(value);
                case UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringDynamicPressure.KilogramForcePerSquareCentimeterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dynamic pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitConverterDynamicPressureUnit to)
        {
            switch (to)
            {
                case UnitConverterDynamicPressureUnit.Pascal:
                    return UnitConverterMetricDynamicPressure.PascalToPascal(baseValue);
                case UnitConverterDynamicPressureUnit.Kilopascal:
                    return UnitConverterMetricDynamicPressure.PascalToKilopascal(baseValue);
                case UnitConverterDynamicPressureUnit.Megapascal:
                    return UnitConverterMetricDynamicPressure.PascalToMegapascal(baseValue);
                case UnitConverterDynamicPressureUnit.Bar:
                    return UnitConverterMetricDynamicPressure.PascalToBar(baseValue);
                case UnitConverterDynamicPressureUnit.Atmosphere:
                    return UnitConverterMetricDynamicPressure.PascalToAtmosphere(baseValue);
                case UnitConverterDynamicPressureUnit.Psi:
                    return UnitConverterImperialDynamicPressure.PascalToPsi(baseValue);
                case UnitConverterDynamicPressureUnit.Psf:
                    return UnitConverterImperialDynamicPressure.PascalToPsf(baseValue);
                case UnitConverterDynamicPressureUnit.Hectopascal:
                    return UnitConverterMetricDynamicPressure.PascalToHectopascal(baseValue);
                case UnitConverterDynamicPressureUnit.Millibar:
                    return UnitConverterMetricDynamicPressure.PascalToMillibar(baseValue);
                case UnitConverterDynamicPressureUnit.Torr:
                    return UnitConverterMetricDynamicPressure.PascalToTorr(baseValue);
                case UnitConverterDynamicPressureUnit.MillimeterMercury:
                    return UnitConverterMetricDynamicPressure.PascalToMillimeterMercury(baseValue);
                case UnitConverterDynamicPressureUnit.InchMercury:
                    return UnitConverterImperialDynamicPressure.PascalToInchMercury(baseValue);
                case UnitConverterDynamicPressureUnit.InchWater:
                    return UnitConverterImperialDynamicPressure.PascalToInchWater(baseValue);
                case UnitConverterDynamicPressureUnit.FootWater:
                    return UnitConverterImperialDynamicPressure.PascalToFootWater(baseValue);
                case UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringDynamicPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dynamic pressure unit.");
            }
        }

        public static string GetSymbol(UnitConverterDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicPressureUnit.Pascal:
                    return "Pa";
                case UnitConverterDynamicPressureUnit.Kilopascal:
                    return "kPa";
                case UnitConverterDynamicPressureUnit.Megapascal:
                    return "MPa";
                case UnitConverterDynamicPressureUnit.Bar:
                    return "bar";
                case UnitConverterDynamicPressureUnit.Atmosphere:
                    return "atm";
                case UnitConverterDynamicPressureUnit.Psi:
                    return "psi";
                case UnitConverterDynamicPressureUnit.Psf:
                    return "psf";
                case UnitConverterDynamicPressureUnit.Hectopascal:
                    return "hPa";
                case UnitConverterDynamicPressureUnit.Millibar:
                    return "mbar";
                case UnitConverterDynamicPressureUnit.Torr:
                    return "Torr";
                case UnitConverterDynamicPressureUnit.MillimeterMercury:
                    return "mmHg";
                case UnitConverterDynamicPressureUnit.InchMercury:
                    return "inHg";
                case UnitConverterDynamicPressureUnit.InchWater:
                    return "inH₂O";
                case UnitConverterDynamicPressureUnit.FootWater:
                    return "ftH₂O";
                case UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicPressureUnit.Pascal:
                    return "Pascal";
                case UnitConverterDynamicPressureUnit.Kilopascal:
                    return "Kilopascal";
                case UnitConverterDynamicPressureUnit.Megapascal:
                    return "Megapascal";
                case UnitConverterDynamicPressureUnit.Bar:
                    return "Bar";
                case UnitConverterDynamicPressureUnit.Atmosphere:
                    return "Atmosphere";
                case UnitConverterDynamicPressureUnit.Psi:
                    return "Psi";
                case UnitConverterDynamicPressureUnit.Psf:
                    return "Psf";
                case UnitConverterDynamicPressureUnit.Hectopascal:
                    return "Hectopascal";
                case UnitConverterDynamicPressureUnit.Millibar:
                    return "Millibar";
                case UnitConverterDynamicPressureUnit.Torr:
                    return "Torr";
                case UnitConverterDynamicPressureUnit.MillimeterMercury:
                    return "Millimeter Mercury";
                case UnitConverterDynamicPressureUnit.InchMercury:
                    return "Inch Mercury";
                case UnitConverterDynamicPressureUnit.InchWater:
                    return "Inch Water";
                case UnitConverterDynamicPressureUnit.FootWater:
                    return "Foot Water";
                case UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDynamicPressureUnit.Pascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Kilopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Megapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Bar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Atmosphere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Psi:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicPressureUnit.Psf:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicPressureUnit.Hectopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Millibar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.Torr:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.MillimeterMercury:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDynamicPressureUnit.InchMercury:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicPressureUnit.InchWater:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicPressureUnit.FootWater:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDynamicPressureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterDynamicPressureUnit.Pascal, UnitConverterDynamicPressureUnit.Kilopascal, UnitConverterDynamicPressureUnit.Megapascal, UnitConverterDynamicPressureUnit.Bar, UnitConverterDynamicPressureUnit.Atmosphere, UnitConverterDynamicPressureUnit.Hectopascal, UnitConverterDynamicPressureUnit.Millibar, UnitConverterDynamicPressureUnit.Torr, UnitConverterDynamicPressureUnit.MillimeterMercury };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterDynamicPressureUnit.Psi, UnitConverterDynamicPressureUnit.Psf, UnitConverterDynamicPressureUnit.InchMercury, UnitConverterDynamicPressureUnit.InchWater, UnitConverterDynamicPressureUnit.FootWater };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter };
                default:
                    return new[] { UnitConverterDynamicPressureUnit.Pascal, UnitConverterDynamicPressureUnit.Kilopascal, UnitConverterDynamicPressureUnit.Megapascal, UnitConverterDynamicPressureUnit.Bar, UnitConverterDynamicPressureUnit.Atmosphere, UnitConverterDynamicPressureUnit.Psi, UnitConverterDynamicPressureUnit.Psf, UnitConverterDynamicPressureUnit.Hectopascal, UnitConverterDynamicPressureUnit.Millibar, UnitConverterDynamicPressureUnit.Torr, UnitConverterDynamicPressureUnit.MillimeterMercury, UnitConverterDynamicPressureUnit.InchMercury, UnitConverterDynamicPressureUnit.InchWater, UnitConverterDynamicPressureUnit.FootWater, UnitConverterDynamicPressureUnit.KilogramForcePerSquareCentimeter };
            }
        }
    }
}
