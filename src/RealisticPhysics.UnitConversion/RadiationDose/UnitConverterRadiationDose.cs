namespace RealisticPhysics.UnitConversion.RadiationDose
{
    using RealisticPhysics.UnitConversion.RadiationDose.Metric;
    using RealisticPhysics.UnitConversion.RadiationDose.Common;
    using RealisticPhysics.UnitConversion.RadiationDose.Historical;
    using RealisticPhysics.UnitConversion.RadiationDose.Scientific;

    public enum UnitConverterRadiationDoseUnit
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

    public static class UnitConverterRadiationDose
    {
        public static double Convert(double value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            double baseValue = ToGray(value, from);
            return FromGray(baseValue, to);
        }

        public static double ToGray(double value, UnitConverterRadiationDoseUnit from)
        {
            switch (from)
            {
                case UnitConverterRadiationDoseUnit.Nanogray:
                    return UnitConverterMetricRadiationDose.NanograyToGray(value);
                case UnitConverterRadiationDoseUnit.Microgray:
                    return UnitConverterMetricRadiationDose.MicrograyToGray(value);
                case UnitConverterRadiationDoseUnit.Milligray:
                    return UnitConverterMetricRadiationDose.MilligrayToGray(value);
                case UnitConverterRadiationDoseUnit.Gray:
                    return UnitConverterMetricRadiationDose.GrayToGray(value);
                case UnitConverterRadiationDoseUnit.Rad:
                    return UnitConverterCommonRadiationDose.RadToGray(value);
                case UnitConverterRadiationDoseUnit.Sievert:
                    return UnitConverterCommonRadiationDose.SievertToGray(value);
                case UnitConverterRadiationDoseUnit.Millisievert:
                    return UnitConverterCommonRadiationDose.MillisievertToGray(value);
                case UnitConverterRadiationDoseUnit.Microsievert:
                    return UnitConverterCommonRadiationDose.MicrosievertToGray(value);
                case UnitConverterRadiationDoseUnit.Rem:
                    return UnitConverterCommonRadiationDose.RemToGray(value);
                case UnitConverterRadiationDoseUnit.Millirem:
                    return UnitConverterCommonRadiationDose.MilliremToGray(value);
                case UnitConverterRadiationDoseUnit.Picogray:
                    return UnitConverterMetricRadiationDose.PicograyToGray(value);
                case UnitConverterRadiationDoseUnit.Centigray:
                    return UnitConverterMetricRadiationDose.CentigrayToGray(value);
                case UnitConverterRadiationDoseUnit.Kilogray:
                    return UnitConverterMetricRadiationDose.KilograyToGray(value);
                case UnitConverterRadiationDoseUnit.Megagray:
                    return UnitConverterMetricRadiationDose.MegagrayToGray(value);
                case UnitConverterRadiationDoseUnit.RoentgenApprox:
                    return UnitConverterHistoricalRadiationDose.RoentgenApproxToGray(value);
                case UnitConverterRadiationDoseUnit.MilliroentgenApprox:
                    return UnitConverterHistoricalRadiationDose.MilliroentgenApproxToGray(value);
                case UnitConverterRadiationDoseUnit.Kilorem:
                    return UnitConverterHistoricalRadiationDose.KiloremToGray(value);
                case UnitConverterRadiationDoseUnit.SievertPerGray:
                    return UnitConverterScientificRadiationDose.SievertPerGrayToGray(value);
                case UnitConverterRadiationDoseUnit.Decigray:
                    return UnitConverterMetricRadiationDose.DecigrayToGray(value);
                case UnitConverterRadiationDoseUnit.Dekagray:
                    return UnitConverterMetricRadiationDose.DekagrayToGray(value);
                case UnitConverterRadiationDoseUnit.Hectogray:
                    return UnitConverterMetricRadiationDose.HectograyToGray(value);
                case UnitConverterRadiationDoseUnit.Nanosievert:
                    return UnitConverterMetricRadiationDose.NanosievertToGray(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiation dose unit.");
            }
        }

        public static double FromGray(double baseValue, UnitConverterRadiationDoseUnit to)
        {
            switch (to)
            {
                case UnitConverterRadiationDoseUnit.Nanogray:
                    return UnitConverterMetricRadiationDose.GrayToNanogray(baseValue);
                case UnitConverterRadiationDoseUnit.Microgray:
                    return UnitConverterMetricRadiationDose.GrayToMicrogray(baseValue);
                case UnitConverterRadiationDoseUnit.Milligray:
                    return UnitConverterMetricRadiationDose.GrayToMilligray(baseValue);
                case UnitConverterRadiationDoseUnit.Gray:
                    return UnitConverterMetricRadiationDose.GrayToGray(baseValue);
                case UnitConverterRadiationDoseUnit.Rad:
                    return UnitConverterCommonRadiationDose.GrayToRad(baseValue);
                case UnitConverterRadiationDoseUnit.Sievert:
                    return UnitConverterCommonRadiationDose.GrayToSievert(baseValue);
                case UnitConverterRadiationDoseUnit.Millisievert:
                    return UnitConverterCommonRadiationDose.GrayToMillisievert(baseValue);
                case UnitConverterRadiationDoseUnit.Microsievert:
                    return UnitConverterCommonRadiationDose.GrayToMicrosievert(baseValue);
                case UnitConverterRadiationDoseUnit.Rem:
                    return UnitConverterCommonRadiationDose.GrayToRem(baseValue);
                case UnitConverterRadiationDoseUnit.Millirem:
                    return UnitConverterCommonRadiationDose.GrayToMillirem(baseValue);
                case UnitConverterRadiationDoseUnit.Picogray:
                    return UnitConverterMetricRadiationDose.GrayToPicogray(baseValue);
                case UnitConverterRadiationDoseUnit.Centigray:
                    return UnitConverterMetricRadiationDose.GrayToCentigray(baseValue);
                case UnitConverterRadiationDoseUnit.Kilogray:
                    return UnitConverterMetricRadiationDose.GrayToKilogray(baseValue);
                case UnitConverterRadiationDoseUnit.Megagray:
                    return UnitConverterMetricRadiationDose.GrayToMegagray(baseValue);
                case UnitConverterRadiationDoseUnit.RoentgenApprox:
                    return UnitConverterHistoricalRadiationDose.GrayToRoentgenApprox(baseValue);
                case UnitConverterRadiationDoseUnit.MilliroentgenApprox:
                    return UnitConverterHistoricalRadiationDose.GrayToMilliroentgenApprox(baseValue);
                case UnitConverterRadiationDoseUnit.Kilorem:
                    return UnitConverterHistoricalRadiationDose.GrayToKilorem(baseValue);
                case UnitConverterRadiationDoseUnit.SievertPerGray:
                    return UnitConverterScientificRadiationDose.GrayToSievertPerGray(baseValue);
                case UnitConverterRadiationDoseUnit.Decigray:
                    return UnitConverterMetricRadiationDose.GrayToDecigray(baseValue);
                case UnitConverterRadiationDoseUnit.Dekagray:
                    return UnitConverterMetricRadiationDose.GrayToDekagray(baseValue);
                case UnitConverterRadiationDoseUnit.Hectogray:
                    return UnitConverterMetricRadiationDose.GrayToHectogray(baseValue);
                case UnitConverterRadiationDoseUnit.Nanosievert:
                    return UnitConverterMetricRadiationDose.GrayToNanosievert(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiation dose unit.");
            }
        }

        public static string GetSymbol(UnitConverterRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationDoseUnit.Nanogray:
                    return "nGy";
                case UnitConverterRadiationDoseUnit.Microgray:
                    return "µGy";
                case UnitConverterRadiationDoseUnit.Milligray:
                    return "mGy";
                case UnitConverterRadiationDoseUnit.Gray:
                    return "Gy";
                case UnitConverterRadiationDoseUnit.Rad:
                    return "rad";
                case UnitConverterRadiationDoseUnit.Sievert:
                    return "Sv";
                case UnitConverterRadiationDoseUnit.Millisievert:
                    return "mSv";
                case UnitConverterRadiationDoseUnit.Microsievert:
                    return "µSv";
                case UnitConverterRadiationDoseUnit.Rem:
                    return "rem";
                case UnitConverterRadiationDoseUnit.Millirem:
                    return "mrem";
                case UnitConverterRadiationDoseUnit.Picogray:
                    return "pGy";
                case UnitConverterRadiationDoseUnit.Centigray:
                    return "cGy";
                case UnitConverterRadiationDoseUnit.Kilogray:
                    return "kGy";
                case UnitConverterRadiationDoseUnit.Megagray:
                    return "MGy";
                case UnitConverterRadiationDoseUnit.RoentgenApprox:
                    return "R";
                case UnitConverterRadiationDoseUnit.MilliroentgenApprox:
                    return "mR";
                case UnitConverterRadiationDoseUnit.Kilorem:
                    return "krem";
                case UnitConverterRadiationDoseUnit.SievertPerGray:
                    return "Sv/Gy";
                case UnitConverterRadiationDoseUnit.Decigray:
                    return "dGy";
                case UnitConverterRadiationDoseUnit.Dekagray:
                    return "daGy";
                case UnitConverterRadiationDoseUnit.Hectogray:
                    return "hGy";
                case UnitConverterRadiationDoseUnit.Nanosievert:
                    return "nSv";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationDoseUnit.Nanogray:
                    return "nanogray";
                case UnitConverterRadiationDoseUnit.Microgray:
                    return "microgray";
                case UnitConverterRadiationDoseUnit.Milligray:
                    return "milligray";
                case UnitConverterRadiationDoseUnit.Gray:
                    return "gray";
                case UnitConverterRadiationDoseUnit.Rad:
                    return "rad";
                case UnitConverterRadiationDoseUnit.Sievert:
                    return "sievert";
                case UnitConverterRadiationDoseUnit.Millisievert:
                    return "millisievert";
                case UnitConverterRadiationDoseUnit.Microsievert:
                    return "microsievert";
                case UnitConverterRadiationDoseUnit.Rem:
                    return "rem";
                case UnitConverterRadiationDoseUnit.Millirem:
                    return "millirem";
                case UnitConverterRadiationDoseUnit.Picogray:
                    return "Picogray";
                case UnitConverterRadiationDoseUnit.Centigray:
                    return "Centigray";
                case UnitConverterRadiationDoseUnit.Kilogray:
                    return "Kilogray";
                case UnitConverterRadiationDoseUnit.Megagray:
                    return "Megagray";
                case UnitConverterRadiationDoseUnit.RoentgenApprox:
                    return "Roentgen Approx";
                case UnitConverterRadiationDoseUnit.MilliroentgenApprox:
                    return "Milliroentgen Approx";
                case UnitConverterRadiationDoseUnit.Kilorem:
                    return "Kilorem";
                case UnitConverterRadiationDoseUnit.SievertPerGray:
                    return "Sievert Per Gray";
                case UnitConverterRadiationDoseUnit.Decigray:
                    return "Decigray";
                case UnitConverterRadiationDoseUnit.Dekagray:
                    return "Dekagray";
                case UnitConverterRadiationDoseUnit.Hectogray:
                    return "Hectogray";
                case UnitConverterRadiationDoseUnit.Nanosievert:
                    return "Nanosievert";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterRadiationDoseUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationDoseUnit.Nanogray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Microgray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Milligray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Gray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Rad:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Sievert:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Millisievert:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Microsievert:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Rem:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Millirem:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterRadiationDoseUnit.Picogray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Centigray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Kilogray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Megagray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.RoentgenApprox:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationDoseUnit.MilliroentgenApprox:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationDoseUnit.Kilorem:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationDoseUnit.SievertPerGray:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterRadiationDoseUnit.Decigray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Dekagray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Hectogray:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationDoseUnit.Nanosievert:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterRadiationDoseUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterRadiationDoseUnit.Nanogray, UnitConverterRadiationDoseUnit.Microgray, UnitConverterRadiationDoseUnit.Milligray, UnitConverterRadiationDoseUnit.Gray, UnitConverterRadiationDoseUnit.Picogray, UnitConverterRadiationDoseUnit.Centigray, UnitConverterRadiationDoseUnit.Kilogray, UnitConverterRadiationDoseUnit.Megagray, UnitConverterRadiationDoseUnit.Decigray, UnitConverterRadiationDoseUnit.Dekagray, UnitConverterRadiationDoseUnit.Hectogray, UnitConverterRadiationDoseUnit.Nanosievert };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterRadiationDoseUnit.Rad, UnitConverterRadiationDoseUnit.Sievert, UnitConverterRadiationDoseUnit.Millisievert, UnitConverterRadiationDoseUnit.Microsievert, UnitConverterRadiationDoseUnit.Rem, UnitConverterRadiationDoseUnit.Millirem };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterRadiationDoseUnit.RoentgenApprox, UnitConverterRadiationDoseUnit.MilliroentgenApprox, UnitConverterRadiationDoseUnit.Kilorem };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterRadiationDoseUnit.SievertPerGray };
                default:
                    return new[] { UnitConverterRadiationDoseUnit.Nanogray, UnitConverterRadiationDoseUnit.Microgray, UnitConverterRadiationDoseUnit.Milligray, UnitConverterRadiationDoseUnit.Gray, UnitConverterRadiationDoseUnit.Rad, UnitConverterRadiationDoseUnit.Sievert, UnitConverterRadiationDoseUnit.Millisievert, UnitConverterRadiationDoseUnit.Microsievert, UnitConverterRadiationDoseUnit.Rem, UnitConverterRadiationDoseUnit.Millirem, UnitConverterRadiationDoseUnit.Picogray, UnitConverterRadiationDoseUnit.Centigray, UnitConverterRadiationDoseUnit.Kilogray, UnitConverterRadiationDoseUnit.Megagray, UnitConverterRadiationDoseUnit.RoentgenApprox, UnitConverterRadiationDoseUnit.MilliroentgenApprox, UnitConverterRadiationDoseUnit.Kilorem, UnitConverterRadiationDoseUnit.SievertPerGray, UnitConverterRadiationDoseUnit.Decigray, UnitConverterRadiationDoseUnit.Dekagray, UnitConverterRadiationDoseUnit.Hectogray, UnitConverterRadiationDoseUnit.Nanosievert };
            }
        }
    }
}
