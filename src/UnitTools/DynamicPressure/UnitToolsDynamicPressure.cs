namespace UnitTools.DynamicPressure
{
    using UnitTools.DynamicPressure.Metric;
    using UnitTools.DynamicPressure.Imperial;
    using UnitTools.DynamicPressure.Engineering;

    public enum UnitToolsDynamicPressureUnit
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

    public static class UnitToolsDynamicPressure
    {
        public static double Convert(double value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitToolsDynamicPressureUnit from)
        {
            switch (from)
            {
                case UnitToolsDynamicPressureUnit.Pascal:
                    return UnitToolsMetricDynamicPressure.PascalToPascal(value);
                case UnitToolsDynamicPressureUnit.Kilopascal:
                    return UnitToolsMetricDynamicPressure.KilopascalToPascal(value);
                case UnitToolsDynamicPressureUnit.Megapascal:
                    return UnitToolsMetricDynamicPressure.MegapascalToPascal(value);
                case UnitToolsDynamicPressureUnit.Bar:
                    return UnitToolsMetricDynamicPressure.BarToPascal(value);
                case UnitToolsDynamicPressureUnit.Atmosphere:
                    return UnitToolsMetricDynamicPressure.AtmosphereToPascal(value);
                case UnitToolsDynamicPressureUnit.Psi:
                    return UnitToolsImperialDynamicPressure.PsiToPascal(value);
                case UnitToolsDynamicPressureUnit.Psf:
                    return UnitToolsImperialDynamicPressure.PsfToPascal(value);
                case UnitToolsDynamicPressureUnit.Hectopascal:
                    return UnitToolsMetricDynamicPressure.HectopascalToPascal(value);
                case UnitToolsDynamicPressureUnit.Millibar:
                    return UnitToolsMetricDynamicPressure.MillibarToPascal(value);
                case UnitToolsDynamicPressureUnit.Torr:
                    return UnitToolsMetricDynamicPressure.TorrToPascal(value);
                case UnitToolsDynamicPressureUnit.MillimeterMercury:
                    return UnitToolsMetricDynamicPressure.MillimeterMercuryToPascal(value);
                case UnitToolsDynamicPressureUnit.InchMercury:
                    return UnitToolsImperialDynamicPressure.InchMercuryToPascal(value);
                case UnitToolsDynamicPressureUnit.InchWater:
                    return UnitToolsImperialDynamicPressure.InchWaterToPascal(value);
                case UnitToolsDynamicPressureUnit.FootWater:
                    return UnitToolsImperialDynamicPressure.FootWaterToPascal(value);
                case UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringDynamicPressure.KilogramForcePerSquareCentimeterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported dynamic pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitToolsDynamicPressureUnit to)
        {
            switch (to)
            {
                case UnitToolsDynamicPressureUnit.Pascal:
                    return UnitToolsMetricDynamicPressure.PascalToPascal(baseValue);
                case UnitToolsDynamicPressureUnit.Kilopascal:
                    return UnitToolsMetricDynamicPressure.PascalToKilopascal(baseValue);
                case UnitToolsDynamicPressureUnit.Megapascal:
                    return UnitToolsMetricDynamicPressure.PascalToMegapascal(baseValue);
                case UnitToolsDynamicPressureUnit.Bar:
                    return UnitToolsMetricDynamicPressure.PascalToBar(baseValue);
                case UnitToolsDynamicPressureUnit.Atmosphere:
                    return UnitToolsMetricDynamicPressure.PascalToAtmosphere(baseValue);
                case UnitToolsDynamicPressureUnit.Psi:
                    return UnitToolsImperialDynamicPressure.PascalToPsi(baseValue);
                case UnitToolsDynamicPressureUnit.Psf:
                    return UnitToolsImperialDynamicPressure.PascalToPsf(baseValue);
                case UnitToolsDynamicPressureUnit.Hectopascal:
                    return UnitToolsMetricDynamicPressure.PascalToHectopascal(baseValue);
                case UnitToolsDynamicPressureUnit.Millibar:
                    return UnitToolsMetricDynamicPressure.PascalToMillibar(baseValue);
                case UnitToolsDynamicPressureUnit.Torr:
                    return UnitToolsMetricDynamicPressure.PascalToTorr(baseValue);
                case UnitToolsDynamicPressureUnit.MillimeterMercury:
                    return UnitToolsMetricDynamicPressure.PascalToMillimeterMercury(baseValue);
                case UnitToolsDynamicPressureUnit.InchMercury:
                    return UnitToolsImperialDynamicPressure.PascalToInchMercury(baseValue);
                case UnitToolsDynamicPressureUnit.InchWater:
                    return UnitToolsImperialDynamicPressure.PascalToInchWater(baseValue);
                case UnitToolsDynamicPressureUnit.FootWater:
                    return UnitToolsImperialDynamicPressure.PascalToFootWater(baseValue);
                case UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringDynamicPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported dynamic pressure unit.");
            }
        }

        public static string GetSymbol(UnitToolsDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicPressureUnit.Pascal:
                    return "Pa";
                case UnitToolsDynamicPressureUnit.Kilopascal:
                    return "kPa";
                case UnitToolsDynamicPressureUnit.Megapascal:
                    return "MPa";
                case UnitToolsDynamicPressureUnit.Bar:
                    return "bar";
                case UnitToolsDynamicPressureUnit.Atmosphere:
                    return "atm";
                case UnitToolsDynamicPressureUnit.Psi:
                    return "psi";
                case UnitToolsDynamicPressureUnit.Psf:
                    return "psf";
                case UnitToolsDynamicPressureUnit.Hectopascal:
                    return "hPa";
                case UnitToolsDynamicPressureUnit.Millibar:
                    return "mbar";
                case UnitToolsDynamicPressureUnit.Torr:
                    return "Torr";
                case UnitToolsDynamicPressureUnit.MillimeterMercury:
                    return "mmHg";
                case UnitToolsDynamicPressureUnit.InchMercury:
                    return "inHg";
                case UnitToolsDynamicPressureUnit.InchWater:
                    return "inH₂O";
                case UnitToolsDynamicPressureUnit.FootWater:
                    return "ftH₂O";
                case UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicPressureUnit.Pascal:
                    return "Pascal";
                case UnitToolsDynamicPressureUnit.Kilopascal:
                    return "Kilopascal";
                case UnitToolsDynamicPressureUnit.Megapascal:
                    return "Megapascal";
                case UnitToolsDynamicPressureUnit.Bar:
                    return "Bar";
                case UnitToolsDynamicPressureUnit.Atmosphere:
                    return "Atmosphere";
                case UnitToolsDynamicPressureUnit.Psi:
                    return "Psi";
                case UnitToolsDynamicPressureUnit.Psf:
                    return "Psf";
                case UnitToolsDynamicPressureUnit.Hectopascal:
                    return "Hectopascal";
                case UnitToolsDynamicPressureUnit.Millibar:
                    return "Millibar";
                case UnitToolsDynamicPressureUnit.Torr:
                    return "Torr";
                case UnitToolsDynamicPressureUnit.MillimeterMercury:
                    return "Millimeter Mercury";
                case UnitToolsDynamicPressureUnit.InchMercury:
                    return "Inch Mercury";
                case UnitToolsDynamicPressureUnit.InchWater:
                    return "Inch Water";
                case UnitToolsDynamicPressureUnit.FootWater:
                    return "Foot Water";
                case UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDynamicPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDynamicPressureUnit.Pascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Kilopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Megapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Bar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Atmosphere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Psi:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicPressureUnit.Psf:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicPressureUnit.Hectopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Millibar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.Torr:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.MillimeterMercury:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDynamicPressureUnit.InchMercury:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicPressureUnit.InchWater:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicPressureUnit.FootWater:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDynamicPressureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsDynamicPressureUnit.Pascal, UnitToolsDynamicPressureUnit.Kilopascal, UnitToolsDynamicPressureUnit.Megapascal, UnitToolsDynamicPressureUnit.Bar, UnitToolsDynamicPressureUnit.Atmosphere, UnitToolsDynamicPressureUnit.Hectopascal, UnitToolsDynamicPressureUnit.Millibar, UnitToolsDynamicPressureUnit.Torr, UnitToolsDynamicPressureUnit.MillimeterMercury };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsDynamicPressureUnit.Psi, UnitToolsDynamicPressureUnit.Psf, UnitToolsDynamicPressureUnit.InchMercury, UnitToolsDynamicPressureUnit.InchWater, UnitToolsDynamicPressureUnit.FootWater };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter };
                default:
                    return new[] { UnitToolsDynamicPressureUnit.Pascal, UnitToolsDynamicPressureUnit.Kilopascal, UnitToolsDynamicPressureUnit.Megapascal, UnitToolsDynamicPressureUnit.Bar, UnitToolsDynamicPressureUnit.Atmosphere, UnitToolsDynamicPressureUnit.Psi, UnitToolsDynamicPressureUnit.Psf, UnitToolsDynamicPressureUnit.Hectopascal, UnitToolsDynamicPressureUnit.Millibar, UnitToolsDynamicPressureUnit.Torr, UnitToolsDynamicPressureUnit.MillimeterMercury, UnitToolsDynamicPressureUnit.InchMercury, UnitToolsDynamicPressureUnit.InchWater, UnitToolsDynamicPressureUnit.FootWater, UnitToolsDynamicPressureUnit.KilogramForcePerSquareCentimeter };
            }
        }
    }
}
