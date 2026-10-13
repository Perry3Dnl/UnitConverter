namespace UnitTools.VaporPressure
{
    using UnitTools.VaporPressure.Metric;
    using UnitTools.VaporPressure.Imperial;
    using UnitTools.VaporPressure.Engineering;

    public enum UnitToolsVaporPressureUnit
    {
        Pascal = 0,
        Kilopascal = 1,
        Megapascal = 2,
        Bar = 3,
        Millibar = 4,
        Atmosphere = 5,
        Torr = 6,
        Psi = 7,
        Hectopascal = 8,
        Micropascal = 9,
        Millipascal = 10,
        KilogramForcePerSquareCentimeter = 11,
        InchMercury = 12,
        InchWater = 13,
    }

    public static class UnitToolsVaporPressure
    {
        public static double Convert(double value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitToolsVaporPressureUnit from)
        {
            switch (from)
            {
                case UnitToolsVaporPressureUnit.Pascal:
                    return UnitToolsMetricVaporPressure.PascalToPascal(value);
                case UnitToolsVaporPressureUnit.Kilopascal:
                    return UnitToolsMetricVaporPressure.KilopascalToPascal(value);
                case UnitToolsVaporPressureUnit.Megapascal:
                    return UnitToolsMetricVaporPressure.MegapascalToPascal(value);
                case UnitToolsVaporPressureUnit.Bar:
                    return UnitToolsMetricVaporPressure.BarToPascal(value);
                case UnitToolsVaporPressureUnit.Millibar:
                    return UnitToolsMetricVaporPressure.MillibarToPascal(value);
                case UnitToolsVaporPressureUnit.Atmosphere:
                    return UnitToolsMetricVaporPressure.AtmosphereToPascal(value);
                case UnitToolsVaporPressureUnit.Torr:
                    return UnitToolsMetricVaporPressure.TorrToPascal(value);
                case UnitToolsVaporPressureUnit.Psi:
                    return UnitToolsImperialVaporPressure.PsiToPascal(value);
                case UnitToolsVaporPressureUnit.Hectopascal:
                    return UnitToolsMetricVaporPressure.HectopascalToPascal(value);
                case UnitToolsVaporPressureUnit.Micropascal:
                    return UnitToolsMetricVaporPressure.MicropascalToPascal(value);
                case UnitToolsVaporPressureUnit.Millipascal:
                    return UnitToolsMetricVaporPressure.MillipascalToPascal(value);
                case UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringVaporPressure.KilogramForcePerSquareCentimeterToPascal(value);
                case UnitToolsVaporPressureUnit.InchMercury:
                    return UnitToolsImperialVaporPressure.InchMercuryToPascal(value);
                case UnitToolsVaporPressureUnit.InchWater:
                    return UnitToolsImperialVaporPressure.InchWaterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported vapor pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitToolsVaporPressureUnit to)
        {
            switch (to)
            {
                case UnitToolsVaporPressureUnit.Pascal:
                    return UnitToolsMetricVaporPressure.PascalToPascal(baseValue);
                case UnitToolsVaporPressureUnit.Kilopascal:
                    return UnitToolsMetricVaporPressure.PascalToKilopascal(baseValue);
                case UnitToolsVaporPressureUnit.Megapascal:
                    return UnitToolsMetricVaporPressure.PascalToMegapascal(baseValue);
                case UnitToolsVaporPressureUnit.Bar:
                    return UnitToolsMetricVaporPressure.PascalToBar(baseValue);
                case UnitToolsVaporPressureUnit.Millibar:
                    return UnitToolsMetricVaporPressure.PascalToMillibar(baseValue);
                case UnitToolsVaporPressureUnit.Atmosphere:
                    return UnitToolsMetricVaporPressure.PascalToAtmosphere(baseValue);
                case UnitToolsVaporPressureUnit.Torr:
                    return UnitToolsMetricVaporPressure.PascalToTorr(baseValue);
                case UnitToolsVaporPressureUnit.Psi:
                    return UnitToolsImperialVaporPressure.PascalToPsi(baseValue);
                case UnitToolsVaporPressureUnit.Hectopascal:
                    return UnitToolsMetricVaporPressure.PascalToHectopascal(baseValue);
                case UnitToolsVaporPressureUnit.Micropascal:
                    return UnitToolsMetricVaporPressure.PascalToMicropascal(baseValue);
                case UnitToolsVaporPressureUnit.Millipascal:
                    return UnitToolsMetricVaporPressure.PascalToMillipascal(baseValue);
                case UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsEngineeringVaporPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                case UnitToolsVaporPressureUnit.InchMercury:
                    return UnitToolsImperialVaporPressure.PascalToInchMercury(baseValue);
                case UnitToolsVaporPressureUnit.InchWater:
                    return UnitToolsImperialVaporPressure.PascalToInchWater(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported vapor pressure unit.");
            }
        }

        public static string GetSymbol(UnitToolsVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVaporPressureUnit.Pascal:
                    return "Pa";
                case UnitToolsVaporPressureUnit.Kilopascal:
                    return "kPa";
                case UnitToolsVaporPressureUnit.Megapascal:
                    return "MPa";
                case UnitToolsVaporPressureUnit.Bar:
                    return "bar";
                case UnitToolsVaporPressureUnit.Millibar:
                    return "mbar";
                case UnitToolsVaporPressureUnit.Atmosphere:
                    return "atm";
                case UnitToolsVaporPressureUnit.Torr:
                    return "Torr";
                case UnitToolsVaporPressureUnit.Psi:
                    return "psi";
                case UnitToolsVaporPressureUnit.Hectopascal:
                    return "hPa";
                case UnitToolsVaporPressureUnit.Micropascal:
                    return "µPa";
                case UnitToolsVaporPressureUnit.Millipascal:
                    return "mPa";
                case UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                case UnitToolsVaporPressureUnit.InchMercury:
                    return "inHg";
                case UnitToolsVaporPressureUnit.InchWater:
                    return "inH₂O";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVaporPressureUnit.Pascal:
                    return "Pascal";
                case UnitToolsVaporPressureUnit.Kilopascal:
                    return "Kilopascal";
                case UnitToolsVaporPressureUnit.Megapascal:
                    return "Megapascal";
                case UnitToolsVaporPressureUnit.Bar:
                    return "Bar";
                case UnitToolsVaporPressureUnit.Millibar:
                    return "Millibar";
                case UnitToolsVaporPressureUnit.Atmosphere:
                    return "Atmosphere";
                case UnitToolsVaporPressureUnit.Torr:
                    return "Torr";
                case UnitToolsVaporPressureUnit.Psi:
                    return "Psi";
                case UnitToolsVaporPressureUnit.Hectopascal:
                    return "Hectopascal";
                case UnitToolsVaporPressureUnit.Micropascal:
                    return "Micropascal";
                case UnitToolsVaporPressureUnit.Millipascal:
                    return "Millipascal";
                case UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                case UnitToolsVaporPressureUnit.InchMercury:
                    return "Inch Mercury";
                case UnitToolsVaporPressureUnit.InchWater:
                    return "Inch Water";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVaporPressureUnit.Pascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Kilopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Megapascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Bar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Millibar:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Atmosphere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Torr:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Psi:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVaporPressureUnit.Hectopascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Micropascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.Millipascal:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsVaporPressureUnit.InchMercury:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVaporPressureUnit.InchWater:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsVaporPressureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsVaporPressureUnit.Pascal, UnitToolsVaporPressureUnit.Kilopascal, UnitToolsVaporPressureUnit.Megapascal, UnitToolsVaporPressureUnit.Bar, UnitToolsVaporPressureUnit.Millibar, UnitToolsVaporPressureUnit.Atmosphere, UnitToolsVaporPressureUnit.Torr, UnitToolsVaporPressureUnit.Hectopascal, UnitToolsVaporPressureUnit.Micropascal, UnitToolsVaporPressureUnit.Millipascal };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsVaporPressureUnit.Psi, UnitToolsVaporPressureUnit.InchMercury, UnitToolsVaporPressureUnit.InchWater };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter };
                default:
                    return new[] { UnitToolsVaporPressureUnit.Pascal, UnitToolsVaporPressureUnit.Kilopascal, UnitToolsVaporPressureUnit.Megapascal, UnitToolsVaporPressureUnit.Bar, UnitToolsVaporPressureUnit.Millibar, UnitToolsVaporPressureUnit.Atmosphere, UnitToolsVaporPressureUnit.Torr, UnitToolsVaporPressureUnit.Psi, UnitToolsVaporPressureUnit.Hectopascal, UnitToolsVaporPressureUnit.Micropascal, UnitToolsVaporPressureUnit.Millipascal, UnitToolsVaporPressureUnit.KilogramForcePerSquareCentimeter, UnitToolsVaporPressureUnit.InchMercury, UnitToolsVaporPressureUnit.InchWater };
            }
        }
    }
}
