namespace UnitTools.RadiationDose
{
    using UnitTools.RadiationDose.Metric;
    using UnitTools.RadiationDose.Common;
    using UnitTools.RadiationDose.Historical;
    using UnitTools.RadiationDose.Scientific;

    public enum UnitToolsRadiationDoseUnit
    {
        Nanogray = 0,
        Microgray = 1,
        Milligray = 2,
        Gray = 3,
        Rad = 4,
        Sievert = 5,
        Millisievert = 6,
        Microsievert = 7,
        Rem = 8,
        Millirem = 9,
        Picogray = 10,
        Centigray = 11,
        Kilogray = 12,
        Megagray = 13,
        RoentgenApprox = 14,
        MilliroentgenApprox = 15,
        Kilorem = 16,
        SievertPerGray = 17,
        Decigray = 18,
        Dekagray = 19,
        Hectogray = 20,
        Nanosievert = 21,
    }

    public static class UnitToolsRadiationDose
    {
        public static double Convert(double value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            double baseValue = ToGray(value, from);
            return FromGray(baseValue, to);
        }

        public static double ToGray(double value, UnitToolsRadiationDoseUnit from)
        {
            switch (from)
            {
                case UnitToolsRadiationDoseUnit.Nanogray:
                    return UnitToolsMetricRadiationDose.NanograyToGray(value);
                case UnitToolsRadiationDoseUnit.Microgray:
                    return UnitToolsMetricRadiationDose.MicrograyToGray(value);
                case UnitToolsRadiationDoseUnit.Milligray:
                    return UnitToolsMetricRadiationDose.MilligrayToGray(value);
                case UnitToolsRadiationDoseUnit.Gray:
                    return UnitToolsMetricRadiationDose.GrayToGray(value);
                case UnitToolsRadiationDoseUnit.Rad:
                    return UnitToolsCommonRadiationDose.RadToGray(value);
                case UnitToolsRadiationDoseUnit.Sievert:
                    return UnitToolsCommonRadiationDose.SievertToGray(value);
                case UnitToolsRadiationDoseUnit.Millisievert:
                    return UnitToolsCommonRadiationDose.MillisievertToGray(value);
                case UnitToolsRadiationDoseUnit.Microsievert:
                    return UnitToolsCommonRadiationDose.MicrosievertToGray(value);
                case UnitToolsRadiationDoseUnit.Rem:
                    return UnitToolsCommonRadiationDose.RemToGray(value);
                case UnitToolsRadiationDoseUnit.Millirem:
                    return UnitToolsCommonRadiationDose.MilliremToGray(value);
                case UnitToolsRadiationDoseUnit.Picogray:
                    return UnitToolsMetricRadiationDose.PicograyToGray(value);
                case UnitToolsRadiationDoseUnit.Centigray:
                    return UnitToolsMetricRadiationDose.CentigrayToGray(value);
                case UnitToolsRadiationDoseUnit.Kilogray:
                    return UnitToolsMetricRadiationDose.KilograyToGray(value);
                case UnitToolsRadiationDoseUnit.Megagray:
                    return UnitToolsMetricRadiationDose.MegagrayToGray(value);
                case UnitToolsRadiationDoseUnit.RoentgenApprox:
                    return UnitToolsHistoricalRadiationDose.RoentgenApproxToGray(value);
                case UnitToolsRadiationDoseUnit.MilliroentgenApprox:
                    return UnitToolsHistoricalRadiationDose.MilliroentgenApproxToGray(value);
                case UnitToolsRadiationDoseUnit.Kilorem:
                    return UnitToolsHistoricalRadiationDose.KiloremToGray(value);
                case UnitToolsRadiationDoseUnit.SievertPerGray:
                    return UnitToolsScientificRadiationDose.SievertPerGrayToGray(value);
                case UnitToolsRadiationDoseUnit.Decigray:
                    return UnitToolsMetricRadiationDose.DecigrayToGray(value);
                case UnitToolsRadiationDoseUnit.Dekagray:
                    return UnitToolsMetricRadiationDose.DekagrayToGray(value);
                case UnitToolsRadiationDoseUnit.Hectogray:
                    return UnitToolsMetricRadiationDose.HectograyToGray(value);
                case UnitToolsRadiationDoseUnit.Nanosievert:
                    return UnitToolsMetricRadiationDose.NanosievertToGray(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiation dose unit.");
            }
        }

        public static double FromGray(double baseValue, UnitToolsRadiationDoseUnit to)
        {
            switch (to)
            {
                case UnitToolsRadiationDoseUnit.Nanogray:
                    return UnitToolsMetricRadiationDose.GrayToNanogray(baseValue);
                case UnitToolsRadiationDoseUnit.Microgray:
                    return UnitToolsMetricRadiationDose.GrayToMicrogray(baseValue);
                case UnitToolsRadiationDoseUnit.Milligray:
                    return UnitToolsMetricRadiationDose.GrayToMilligray(baseValue);
                case UnitToolsRadiationDoseUnit.Gray:
                    return UnitToolsMetricRadiationDose.GrayToGray(baseValue);
                case UnitToolsRadiationDoseUnit.Rad:
                    return UnitToolsCommonRadiationDose.GrayToRad(baseValue);
                case UnitToolsRadiationDoseUnit.Sievert:
                    return UnitToolsCommonRadiationDose.GrayToSievert(baseValue);
                case UnitToolsRadiationDoseUnit.Millisievert:
                    return UnitToolsCommonRadiationDose.GrayToMillisievert(baseValue);
                case UnitToolsRadiationDoseUnit.Microsievert:
                    return UnitToolsCommonRadiationDose.GrayToMicrosievert(baseValue);
                case UnitToolsRadiationDoseUnit.Rem:
                    return UnitToolsCommonRadiationDose.GrayToRem(baseValue);
                case UnitToolsRadiationDoseUnit.Millirem:
                    return UnitToolsCommonRadiationDose.GrayToMillirem(baseValue);
                case UnitToolsRadiationDoseUnit.Picogray:
                    return UnitToolsMetricRadiationDose.GrayToPicogray(baseValue);
                case UnitToolsRadiationDoseUnit.Centigray:
                    return UnitToolsMetricRadiationDose.GrayToCentigray(baseValue);
                case UnitToolsRadiationDoseUnit.Kilogray:
                    return UnitToolsMetricRadiationDose.GrayToKilogray(baseValue);
                case UnitToolsRadiationDoseUnit.Megagray:
                    return UnitToolsMetricRadiationDose.GrayToMegagray(baseValue);
                case UnitToolsRadiationDoseUnit.RoentgenApprox:
                    return UnitToolsHistoricalRadiationDose.GrayToRoentgenApprox(baseValue);
                case UnitToolsRadiationDoseUnit.MilliroentgenApprox:
                    return UnitToolsHistoricalRadiationDose.GrayToMilliroentgenApprox(baseValue);
                case UnitToolsRadiationDoseUnit.Kilorem:
                    return UnitToolsHistoricalRadiationDose.GrayToKilorem(baseValue);
                case UnitToolsRadiationDoseUnit.SievertPerGray:
                    return UnitToolsScientificRadiationDose.GrayToSievertPerGray(baseValue);
                case UnitToolsRadiationDoseUnit.Decigray:
                    return UnitToolsMetricRadiationDose.GrayToDecigray(baseValue);
                case UnitToolsRadiationDoseUnit.Dekagray:
                    return UnitToolsMetricRadiationDose.GrayToDekagray(baseValue);
                case UnitToolsRadiationDoseUnit.Hectogray:
                    return UnitToolsMetricRadiationDose.GrayToHectogray(baseValue);
                case UnitToolsRadiationDoseUnit.Nanosievert:
                    return UnitToolsMetricRadiationDose.GrayToNanosievert(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiation dose unit.");
            }
        }

        public static string GetSymbol(UnitToolsRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationDoseUnit.Nanogray:
                    return "nGy";
                case UnitToolsRadiationDoseUnit.Microgray:
                    return "µGy";
                case UnitToolsRadiationDoseUnit.Milligray:
                    return "mGy";
                case UnitToolsRadiationDoseUnit.Gray:
                    return "Gy";
                case UnitToolsRadiationDoseUnit.Rad:
                    return "rad";
                case UnitToolsRadiationDoseUnit.Sievert:
                    return "Sv";
                case UnitToolsRadiationDoseUnit.Millisievert:
                    return "mSv";
                case UnitToolsRadiationDoseUnit.Microsievert:
                    return "µSv";
                case UnitToolsRadiationDoseUnit.Rem:
                    return "rem";
                case UnitToolsRadiationDoseUnit.Millirem:
                    return "mrem";
                case UnitToolsRadiationDoseUnit.Picogray:
                    return "pGy";
                case UnitToolsRadiationDoseUnit.Centigray:
                    return "cGy";
                case UnitToolsRadiationDoseUnit.Kilogray:
                    return "kGy";
                case UnitToolsRadiationDoseUnit.Megagray:
                    return "MGy";
                case UnitToolsRadiationDoseUnit.RoentgenApprox:
                    return "R";
                case UnitToolsRadiationDoseUnit.MilliroentgenApprox:
                    return "mR";
                case UnitToolsRadiationDoseUnit.Kilorem:
                    return "krem";
                case UnitToolsRadiationDoseUnit.SievertPerGray:
                    return "Sv/Gy";
                case UnitToolsRadiationDoseUnit.Decigray:
                    return "dGy";
                case UnitToolsRadiationDoseUnit.Dekagray:
                    return "daGy";
                case UnitToolsRadiationDoseUnit.Hectogray:
                    return "hGy";
                case UnitToolsRadiationDoseUnit.Nanosievert:
                    return "nSv";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationDoseUnit.Nanogray:
                    return "nanogray";
                case UnitToolsRadiationDoseUnit.Microgray:
                    return "microgray";
                case UnitToolsRadiationDoseUnit.Milligray:
                    return "milligray";
                case UnitToolsRadiationDoseUnit.Gray:
                    return "gray";
                case UnitToolsRadiationDoseUnit.Rad:
                    return "rad";
                case UnitToolsRadiationDoseUnit.Sievert:
                    return "sievert";
                case UnitToolsRadiationDoseUnit.Millisievert:
                    return "millisievert";
                case UnitToolsRadiationDoseUnit.Microsievert:
                    return "microsievert";
                case UnitToolsRadiationDoseUnit.Rem:
                    return "rem";
                case UnitToolsRadiationDoseUnit.Millirem:
                    return "millirem";
                case UnitToolsRadiationDoseUnit.Picogray:
                    return "Picogray";
                case UnitToolsRadiationDoseUnit.Centigray:
                    return "Centigray";
                case UnitToolsRadiationDoseUnit.Kilogray:
                    return "Kilogray";
                case UnitToolsRadiationDoseUnit.Megagray:
                    return "Megagray";
                case UnitToolsRadiationDoseUnit.RoentgenApprox:
                    return "Roentgen Approx";
                case UnitToolsRadiationDoseUnit.MilliroentgenApprox:
                    return "Milliroentgen Approx";
                case UnitToolsRadiationDoseUnit.Kilorem:
                    return "Kilorem";
                case UnitToolsRadiationDoseUnit.SievertPerGray:
                    return "Sievert Per Gray";
                case UnitToolsRadiationDoseUnit.Decigray:
                    return "Decigray";
                case UnitToolsRadiationDoseUnit.Dekagray:
                    return "Dekagray";
                case UnitToolsRadiationDoseUnit.Hectogray:
                    return "Hectogray";
                case UnitToolsRadiationDoseUnit.Nanosievert:
                    return "Nanosievert";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationDoseUnit.Nanogray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Microgray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Milligray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Gray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Rad:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Sievert:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Millisievert:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Microsievert:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Rem:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Millirem:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsRadiationDoseUnit.Picogray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Centigray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Kilogray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Megagray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.RoentgenApprox:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationDoseUnit.MilliroentgenApprox:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationDoseUnit.Kilorem:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationDoseUnit.SievertPerGray:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsRadiationDoseUnit.Decigray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Dekagray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Hectogray:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationDoseUnit.Nanosievert:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsRadiationDoseUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsRadiationDoseUnit.Nanogray, UnitToolsRadiationDoseUnit.Microgray, UnitToolsRadiationDoseUnit.Milligray, UnitToolsRadiationDoseUnit.Gray, UnitToolsRadiationDoseUnit.Picogray, UnitToolsRadiationDoseUnit.Centigray, UnitToolsRadiationDoseUnit.Kilogray, UnitToolsRadiationDoseUnit.Megagray, UnitToolsRadiationDoseUnit.Decigray, UnitToolsRadiationDoseUnit.Dekagray, UnitToolsRadiationDoseUnit.Hectogray, UnitToolsRadiationDoseUnit.Nanosievert };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsRadiationDoseUnit.Rad, UnitToolsRadiationDoseUnit.Sievert, UnitToolsRadiationDoseUnit.Millisievert, UnitToolsRadiationDoseUnit.Microsievert, UnitToolsRadiationDoseUnit.Rem, UnitToolsRadiationDoseUnit.Millirem };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsRadiationDoseUnit.RoentgenApprox, UnitToolsRadiationDoseUnit.MilliroentgenApprox, UnitToolsRadiationDoseUnit.Kilorem };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsRadiationDoseUnit.SievertPerGray };
                default:
                    return new[] { UnitToolsRadiationDoseUnit.Nanogray, UnitToolsRadiationDoseUnit.Microgray, UnitToolsRadiationDoseUnit.Milligray, UnitToolsRadiationDoseUnit.Gray, UnitToolsRadiationDoseUnit.Rad, UnitToolsRadiationDoseUnit.Sievert, UnitToolsRadiationDoseUnit.Millisievert, UnitToolsRadiationDoseUnit.Microsievert, UnitToolsRadiationDoseUnit.Rem, UnitToolsRadiationDoseUnit.Millirem, UnitToolsRadiationDoseUnit.Picogray, UnitToolsRadiationDoseUnit.Centigray, UnitToolsRadiationDoseUnit.Kilogray, UnitToolsRadiationDoseUnit.Megagray, UnitToolsRadiationDoseUnit.RoentgenApprox, UnitToolsRadiationDoseUnit.MilliroentgenApprox, UnitToolsRadiationDoseUnit.Kilorem, UnitToolsRadiationDoseUnit.SievertPerGray, UnitToolsRadiationDoseUnit.Decigray, UnitToolsRadiationDoseUnit.Dekagray, UnitToolsRadiationDoseUnit.Hectogray, UnitToolsRadiationDoseUnit.Nanosievert };
            }
        }
    }
}
