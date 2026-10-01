namespace RealisticPhysics.UnitConversion.Luminance
{
    using RealisticPhysics.UnitConversion.Luminance.Metric;
    using RealisticPhysics.UnitConversion.Luminance.Imperial;
    using RealisticPhysics.UnitConversion.Luminance.Historical;

    public enum UnitConverterLuminanceUnit
    {
        CandelaPerSquareMeter = 0,
        Nit = 1,
        Stilb = 2,
        Lambert = 3,
        FootLambert = 4,
        Apostilb = 5,
        CandelaPerSquareCentimeter = 6,
        CandelaPerSquareMillimeter = 7,
        CandelaPerSquareFoot = 8,
        CandelaPerSquareInch = 9,
        Skot = 10,
    }

    public static class UnitConverterLuminance
    {
        public static double Convert(double value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            double baseValue = ToCandelaPerSquareMeter(value, from);
            return FromCandelaPerSquareMeter(baseValue, to);
        }

        public static double ToCandelaPerSquareMeter(double value, UnitConverterLuminanceUnit from)
        {
            switch (from)
            {
                case UnitConverterLuminanceUnit.CandelaPerSquareMeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.Nit:
                    return UnitConverterMetricLuminance.NitToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.Stilb:
                    return UnitConverterMetricLuminance.StilbToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.Lambert:
                    return UnitConverterMetricLuminance.LambertToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.FootLambert:
                    return UnitConverterImperialLuminance.FootLambertToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.Apostilb:
                    return UnitConverterMetricLuminance.ApostilbToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareCentimeterToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareMillimeterToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.CandelaPerSquareFoot:
                    return UnitConverterImperialLuminance.CandelaPerSquareFootToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.CandelaPerSquareInch:
                    return UnitConverterImperialLuminance.CandelaPerSquareInchToCandelaPerSquareMeter(value);
                case UnitConverterLuminanceUnit.Skot:
                    return UnitConverterHistoricalLuminance.SkotToCandelaPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminance unit.");
            }
        }

        public static double FromCandelaPerSquareMeter(double baseValue, UnitConverterLuminanceUnit to)
        {
            switch (to)
            {
                case UnitConverterLuminanceUnit.CandelaPerSquareMeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMeter(baseValue);
                case UnitConverterLuminanceUnit.Nit:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToNit(baseValue);
                case UnitConverterLuminanceUnit.Stilb:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToStilb(baseValue);
                case UnitConverterLuminanceUnit.Lambert:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToLambert(baseValue);
                case UnitConverterLuminanceUnit.FootLambert:
                    return UnitConverterImperialLuminance.CandelaPerSquareMeterToFootLambert(baseValue);
                case UnitConverterLuminanceUnit.Apostilb:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToApostilb(baseValue);
                case UnitConverterLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareCentimeter(baseValue);
                case UnitConverterLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitConverterMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMillimeter(baseValue);
                case UnitConverterLuminanceUnit.CandelaPerSquareFoot:
                    return UnitConverterImperialLuminance.CandelaPerSquareMeterToCandelaPerSquareFoot(baseValue);
                case UnitConverterLuminanceUnit.CandelaPerSquareInch:
                    return UnitConverterImperialLuminance.CandelaPerSquareMeterToCandelaPerSquareInch(baseValue);
                case UnitConverterLuminanceUnit.Skot:
                    return UnitConverterHistoricalLuminance.CandelaPerSquareMeterToSkot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminance unit.");
            }
        }

        public static string GetSymbol(UnitConverterLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminanceUnit.CandelaPerSquareMeter:
                    return "cd/m²";
                case UnitConverterLuminanceUnit.Nit:
                    return "nt";
                case UnitConverterLuminanceUnit.Stilb:
                    return "sb";
                case UnitConverterLuminanceUnit.Lambert:
                    return "L";
                case UnitConverterLuminanceUnit.FootLambert:
                    return "fL";
                case UnitConverterLuminanceUnit.Apostilb:
                    return "asb";
                case UnitConverterLuminanceUnit.CandelaPerSquareCentimeter:
                    return "cd/cm²";
                case UnitConverterLuminanceUnit.CandelaPerSquareMillimeter:
                    return "cd/mm²";
                case UnitConverterLuminanceUnit.CandelaPerSquareFoot:
                    return "cd/ft²";
                case UnitConverterLuminanceUnit.CandelaPerSquareInch:
                    return "cd/in²";
                case UnitConverterLuminanceUnit.Skot:
                    return "sk";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminanceUnit.CandelaPerSquareMeter:
                    return "Candela Per Square Meter";
                case UnitConverterLuminanceUnit.Nit:
                    return "Nit";
                case UnitConverterLuminanceUnit.Stilb:
                    return "Stilb";
                case UnitConverterLuminanceUnit.Lambert:
                    return "Lambert";
                case UnitConverterLuminanceUnit.FootLambert:
                    return "Foot Lambert";
                case UnitConverterLuminanceUnit.Apostilb:
                    return "Apostilb";
                case UnitConverterLuminanceUnit.CandelaPerSquareCentimeter:
                    return "Candela Per Square Centimeter";
                case UnitConverterLuminanceUnit.CandelaPerSquareMillimeter:
                    return "Candela Per Square Millimeter";
                case UnitConverterLuminanceUnit.CandelaPerSquareFoot:
                    return "Candela Per Square Foot";
                case UnitConverterLuminanceUnit.CandelaPerSquareInch:
                    return "Candela Per Square Inch";
                case UnitConverterLuminanceUnit.Skot:
                    return "Skot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLuminanceUnit.CandelaPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.Nit:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.Stilb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.Lambert:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.FootLambert:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminanceUnit.Apostilb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLuminanceUnit.CandelaPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminanceUnit.CandelaPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLuminanceUnit.Skot:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLuminanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLuminanceUnit.CandelaPerSquareMeter, UnitConverterLuminanceUnit.Nit, UnitConverterLuminanceUnit.Stilb, UnitConverterLuminanceUnit.Lambert, UnitConverterLuminanceUnit.Apostilb, UnitConverterLuminanceUnit.CandelaPerSquareCentimeter, UnitConverterLuminanceUnit.CandelaPerSquareMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterLuminanceUnit.FootLambert, UnitConverterLuminanceUnit.CandelaPerSquareFoot, UnitConverterLuminanceUnit.CandelaPerSquareInch };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterLuminanceUnit.Skot };
                default:
                    return new[] { UnitConverterLuminanceUnit.CandelaPerSquareMeter, UnitConverterLuminanceUnit.Nit, UnitConverterLuminanceUnit.Stilb, UnitConverterLuminanceUnit.Lambert, UnitConverterLuminanceUnit.FootLambert, UnitConverterLuminanceUnit.Apostilb, UnitConverterLuminanceUnit.CandelaPerSquareCentimeter, UnitConverterLuminanceUnit.CandelaPerSquareMillimeter, UnitConverterLuminanceUnit.CandelaPerSquareFoot, UnitConverterLuminanceUnit.CandelaPerSquareInch, UnitConverterLuminanceUnit.Skot };
            }
        }
    }
}
