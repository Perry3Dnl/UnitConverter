namespace UnitTools.Luminance
{
    using UnitTools.Luminance.Metric;
    using UnitTools.Luminance.Imperial;
    using UnitTools.Luminance.Historical;

    public enum UnitToolsLuminanceUnit
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

    public static class UnitToolsLuminance
    {
        public static double Convert(double value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            double baseValue = ToCandelaPerSquareMeter(value, from);
            return FromCandelaPerSquareMeter(baseValue, to);
        }

        public static double ToCandelaPerSquareMeter(double value, UnitToolsLuminanceUnit from)
        {
            switch (from)
            {
                case UnitToolsLuminanceUnit.CandelaPerSquareMeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.Nit:
                    return UnitToolsMetricLuminance.NitToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.Stilb:
                    return UnitToolsMetricLuminance.StilbToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.Lambert:
                    return UnitToolsMetricLuminance.LambertToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.FootLambert:
                    return UnitToolsImperialLuminance.FootLambertToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.Apostilb:
                    return UnitToolsMetricLuminance.ApostilbToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareCentimeterToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareMillimeterToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.CandelaPerSquareFoot:
                    return UnitToolsImperialLuminance.CandelaPerSquareFootToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.CandelaPerSquareInch:
                    return UnitToolsImperialLuminance.CandelaPerSquareInchToCandelaPerSquareMeter(value);
                case UnitToolsLuminanceUnit.Skot:
                    return UnitToolsHistoricalLuminance.SkotToCandelaPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported luminance unit.");
            }
        }

        public static double FromCandelaPerSquareMeter(double baseValue, UnitToolsLuminanceUnit to)
        {
            switch (to)
            {
                case UnitToolsLuminanceUnit.CandelaPerSquareMeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMeter(baseValue);
                case UnitToolsLuminanceUnit.Nit:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToNit(baseValue);
                case UnitToolsLuminanceUnit.Stilb:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToStilb(baseValue);
                case UnitToolsLuminanceUnit.Lambert:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToLambert(baseValue);
                case UnitToolsLuminanceUnit.FootLambert:
                    return UnitToolsImperialLuminance.CandelaPerSquareMeterToFootLambert(baseValue);
                case UnitToolsLuminanceUnit.Apostilb:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToApostilb(baseValue);
                case UnitToolsLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareCentimeter(baseValue);
                case UnitToolsLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitToolsMetricLuminance.CandelaPerSquareMeterToCandelaPerSquareMillimeter(baseValue);
                case UnitToolsLuminanceUnit.CandelaPerSquareFoot:
                    return UnitToolsImperialLuminance.CandelaPerSquareMeterToCandelaPerSquareFoot(baseValue);
                case UnitToolsLuminanceUnit.CandelaPerSquareInch:
                    return UnitToolsImperialLuminance.CandelaPerSquareMeterToCandelaPerSquareInch(baseValue);
                case UnitToolsLuminanceUnit.Skot:
                    return UnitToolsHistoricalLuminance.CandelaPerSquareMeterToSkot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported luminance unit.");
            }
        }

        public static string GetSymbol(UnitToolsLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminanceUnit.CandelaPerSquareMeter:
                    return "cd/m²";
                case UnitToolsLuminanceUnit.Nit:
                    return "nt";
                case UnitToolsLuminanceUnit.Stilb:
                    return "sb";
                case UnitToolsLuminanceUnit.Lambert:
                    return "L";
                case UnitToolsLuminanceUnit.FootLambert:
                    return "fL";
                case UnitToolsLuminanceUnit.Apostilb:
                    return "asb";
                case UnitToolsLuminanceUnit.CandelaPerSquareCentimeter:
                    return "cd/cm²";
                case UnitToolsLuminanceUnit.CandelaPerSquareMillimeter:
                    return "cd/mm²";
                case UnitToolsLuminanceUnit.CandelaPerSquareFoot:
                    return "cd/ft²";
                case UnitToolsLuminanceUnit.CandelaPerSquareInch:
                    return "cd/in²";
                case UnitToolsLuminanceUnit.Skot:
                    return "sk";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminanceUnit.CandelaPerSquareMeter:
                    return "Candela Per Square Meter";
                case UnitToolsLuminanceUnit.Nit:
                    return "Nit";
                case UnitToolsLuminanceUnit.Stilb:
                    return "Stilb";
                case UnitToolsLuminanceUnit.Lambert:
                    return "Lambert";
                case UnitToolsLuminanceUnit.FootLambert:
                    return "Foot Lambert";
                case UnitToolsLuminanceUnit.Apostilb:
                    return "Apostilb";
                case UnitToolsLuminanceUnit.CandelaPerSquareCentimeter:
                    return "Candela Per Square Centimeter";
                case UnitToolsLuminanceUnit.CandelaPerSquareMillimeter:
                    return "Candela Per Square Millimeter";
                case UnitToolsLuminanceUnit.CandelaPerSquareFoot:
                    return "Candela Per Square Foot";
                case UnitToolsLuminanceUnit.CandelaPerSquareInch:
                    return "Candela Per Square Inch";
                case UnitToolsLuminanceUnit.Skot:
                    return "Skot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLuminanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLuminanceUnit.CandelaPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.Nit:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.Stilb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.Lambert:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.FootLambert:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminanceUnit.Apostilb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.CandelaPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.CandelaPerSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLuminanceUnit.CandelaPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminanceUnit.CandelaPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLuminanceUnit.Skot:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLuminanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLuminanceUnit.CandelaPerSquareMeter, UnitToolsLuminanceUnit.Nit, UnitToolsLuminanceUnit.Stilb, UnitToolsLuminanceUnit.Lambert, UnitToolsLuminanceUnit.Apostilb, UnitToolsLuminanceUnit.CandelaPerSquareCentimeter, UnitToolsLuminanceUnit.CandelaPerSquareMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsLuminanceUnit.FootLambert, UnitToolsLuminanceUnit.CandelaPerSquareFoot, UnitToolsLuminanceUnit.CandelaPerSquareInch };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsLuminanceUnit.Skot };
                default:
                    return new[] { UnitToolsLuminanceUnit.CandelaPerSquareMeter, UnitToolsLuminanceUnit.Nit, UnitToolsLuminanceUnit.Stilb, UnitToolsLuminanceUnit.Lambert, UnitToolsLuminanceUnit.FootLambert, UnitToolsLuminanceUnit.Apostilb, UnitToolsLuminanceUnit.CandelaPerSquareCentimeter, UnitToolsLuminanceUnit.CandelaPerSquareMillimeter, UnitToolsLuminanceUnit.CandelaPerSquareFoot, UnitToolsLuminanceUnit.CandelaPerSquareInch, UnitToolsLuminanceUnit.Skot };
            }
        }
    }
}
