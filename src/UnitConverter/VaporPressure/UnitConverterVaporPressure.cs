namespace UnitConverter.VaporPressure
{
    using UnitConverter.VaporPressure.Metric;
    using UnitConverter.VaporPressure.Imperial;
    using UnitConverter.VaporPressure.Engineering;

    public enum UnitConverterVaporPressureUnit
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

    public static class UnitConverterVaporPressure
    {
        public static double Convert(double value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            double baseValue = ToPascal(value, from);
            return FromPascal(baseValue, to);
        }

        public static double ToPascal(double value, UnitConverterVaporPressureUnit from)
        {
            switch (from)
            {
                case UnitConverterVaporPressureUnit.Pascal:
                    return UnitConverterMetricVaporPressure.PascalToPascal(value);
                case UnitConverterVaporPressureUnit.Kilopascal:
                    return UnitConverterMetricVaporPressure.KilopascalToPascal(value);
                case UnitConverterVaporPressureUnit.Megapascal:
                    return UnitConverterMetricVaporPressure.MegapascalToPascal(value);
                case UnitConverterVaporPressureUnit.Bar:
                    return UnitConverterMetricVaporPressure.BarToPascal(value);
                case UnitConverterVaporPressureUnit.Millibar:
                    return UnitConverterMetricVaporPressure.MillibarToPascal(value);
                case UnitConverterVaporPressureUnit.Atmosphere:
                    return UnitConverterMetricVaporPressure.AtmosphereToPascal(value);
                case UnitConverterVaporPressureUnit.Torr:
                    return UnitConverterMetricVaporPressure.TorrToPascal(value);
                case UnitConverterVaporPressureUnit.Psi:
                    return UnitConverterImperialVaporPressure.PsiToPascal(value);
                case UnitConverterVaporPressureUnit.Hectopascal:
                    return UnitConverterMetricVaporPressure.HectopascalToPascal(value);
                case UnitConverterVaporPressureUnit.Micropascal:
                    return UnitConverterMetricVaporPressure.MicropascalToPascal(value);
                case UnitConverterVaporPressureUnit.Millipascal:
                    return UnitConverterMetricVaporPressure.MillipascalToPascal(value);
                case UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringVaporPressure.KilogramForcePerSquareCentimeterToPascal(value);
                case UnitConverterVaporPressureUnit.InchMercury:
                    return UnitConverterImperialVaporPressure.InchMercuryToPascal(value);
                case UnitConverterVaporPressureUnit.InchWater:
                    return UnitConverterImperialVaporPressure.InchWaterToPascal(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported vapor pressure unit.");
            }
        }

        public static double FromPascal(double baseValue, UnitConverterVaporPressureUnit to)
        {
            switch (to)
            {
                case UnitConverterVaporPressureUnit.Pascal:
                    return UnitConverterMetricVaporPressure.PascalToPascal(baseValue);
                case UnitConverterVaporPressureUnit.Kilopascal:
                    return UnitConverterMetricVaporPressure.PascalToKilopascal(baseValue);
                case UnitConverterVaporPressureUnit.Megapascal:
                    return UnitConverterMetricVaporPressure.PascalToMegapascal(baseValue);
                case UnitConverterVaporPressureUnit.Bar:
                    return UnitConverterMetricVaporPressure.PascalToBar(baseValue);
                case UnitConverterVaporPressureUnit.Millibar:
                    return UnitConverterMetricVaporPressure.PascalToMillibar(baseValue);
                case UnitConverterVaporPressureUnit.Atmosphere:
                    return UnitConverterMetricVaporPressure.PascalToAtmosphere(baseValue);
                case UnitConverterVaporPressureUnit.Torr:
                    return UnitConverterMetricVaporPressure.PascalToTorr(baseValue);
                case UnitConverterVaporPressureUnit.Psi:
                    return UnitConverterImperialVaporPressure.PascalToPsi(baseValue);
                case UnitConverterVaporPressureUnit.Hectopascal:
                    return UnitConverterMetricVaporPressure.PascalToHectopascal(baseValue);
                case UnitConverterVaporPressureUnit.Micropascal:
                    return UnitConverterMetricVaporPressure.PascalToMicropascal(baseValue);
                case UnitConverterVaporPressureUnit.Millipascal:
                    return UnitConverterMetricVaporPressure.PascalToMillipascal(baseValue);
                case UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterEngineeringVaporPressure.PascalToKilogramForcePerSquareCentimeter(baseValue);
                case UnitConverterVaporPressureUnit.InchMercury:
                    return UnitConverterImperialVaporPressure.PascalToInchMercury(baseValue);
                case UnitConverterVaporPressureUnit.InchWater:
                    return UnitConverterImperialVaporPressure.PascalToInchWater(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported vapor pressure unit.");
            }
        }

        public static string GetSymbol(UnitConverterVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVaporPressureUnit.Pascal:
                    return "Pa";
                case UnitConverterVaporPressureUnit.Kilopascal:
                    return "kPa";
                case UnitConverterVaporPressureUnit.Megapascal:
                    return "MPa";
                case UnitConverterVaporPressureUnit.Bar:
                    return "bar";
                case UnitConverterVaporPressureUnit.Millibar:
                    return "mbar";
                case UnitConverterVaporPressureUnit.Atmosphere:
                    return "atm";
                case UnitConverterVaporPressureUnit.Torr:
                    return "Torr";
                case UnitConverterVaporPressureUnit.Psi:
                    return "psi";
                case UnitConverterVaporPressureUnit.Hectopascal:
                    return "hPa";
                case UnitConverterVaporPressureUnit.Micropascal:
                    return "µPa";
                case UnitConverterVaporPressureUnit.Millipascal:
                    return "mPa";
                case UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return "kgf/cm²";
                case UnitConverterVaporPressureUnit.InchMercury:
                    return "inHg";
                case UnitConverterVaporPressureUnit.InchWater:
                    return "inH₂O";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVaporPressureUnit.Pascal:
                    return "Pascal";
                case UnitConverterVaporPressureUnit.Kilopascal:
                    return "Kilopascal";
                case UnitConverterVaporPressureUnit.Megapascal:
                    return "Megapascal";
                case UnitConverterVaporPressureUnit.Bar:
                    return "Bar";
                case UnitConverterVaporPressureUnit.Millibar:
                    return "Millibar";
                case UnitConverterVaporPressureUnit.Atmosphere:
                    return "Atmosphere";
                case UnitConverterVaporPressureUnit.Torr:
                    return "Torr";
                case UnitConverterVaporPressureUnit.Psi:
                    return "Psi";
                case UnitConverterVaporPressureUnit.Hectopascal:
                    return "Hectopascal";
                case UnitConverterVaporPressureUnit.Micropascal:
                    return "Micropascal";
                case UnitConverterVaporPressureUnit.Millipascal:
                    return "Millipascal";
                case UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return "Kilogram Force Per Square Centimeter";
                case UnitConverterVaporPressureUnit.InchMercury:
                    return "Inch Mercury";
                case UnitConverterVaporPressureUnit.InchWater:
                    return "Inch Water";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterVaporPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVaporPressureUnit.Pascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Kilopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Megapascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Bar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Millibar:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Atmosphere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Torr:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Psi:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVaporPressureUnit.Hectopascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Micropascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.Millipascal:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterVaporPressureUnit.InchMercury:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVaporPressureUnit.InchWater:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterVaporPressureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterVaporPressureUnit.Pascal, UnitConverterVaporPressureUnit.Kilopascal, UnitConverterVaporPressureUnit.Megapascal, UnitConverterVaporPressureUnit.Bar, UnitConverterVaporPressureUnit.Millibar, UnitConverterVaporPressureUnit.Atmosphere, UnitConverterVaporPressureUnit.Torr, UnitConverterVaporPressureUnit.Hectopascal, UnitConverterVaporPressureUnit.Micropascal, UnitConverterVaporPressureUnit.Millipascal };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterVaporPressureUnit.Psi, UnitConverterVaporPressureUnit.InchMercury, UnitConverterVaporPressureUnit.InchWater };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter };
                default:
                    return new[] { UnitConverterVaporPressureUnit.Pascal, UnitConverterVaporPressureUnit.Kilopascal, UnitConverterVaporPressureUnit.Megapascal, UnitConverterVaporPressureUnit.Bar, UnitConverterVaporPressureUnit.Millibar, UnitConverterVaporPressureUnit.Atmosphere, UnitConverterVaporPressureUnit.Torr, UnitConverterVaporPressureUnit.Psi, UnitConverterVaporPressureUnit.Hectopascal, UnitConverterVaporPressureUnit.Micropascal, UnitConverterVaporPressureUnit.Millipascal, UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter, UnitConverterVaporPressureUnit.InchMercury, UnitConverterVaporPressureUnit.InchWater };
            }
        }
    }
}
