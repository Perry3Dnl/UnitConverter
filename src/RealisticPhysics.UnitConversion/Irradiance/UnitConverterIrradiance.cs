namespace RealisticPhysics.UnitConversion.Irradiance
{
    using RealisticPhysics.UnitConversion.Irradiance.Metric;
    using RealisticPhysics.UnitConversion.Irradiance.Scientific;
    using RealisticPhysics.UnitConversion.Irradiance.Imperial;

    public enum UnitConverterIrradianceUnit
    {
        WattPerSquareMeter = 0,
        KilowattPerSquareMeter = 1,
        MilliwattPerSquareCentimeter = 2,
        WattPerSquareCentimeter = 3,
        LangleyPerMinute = 4,
        MilliwattPerSquareMeter = 5,
        MicrowattPerSquareMeter = 6,
        WattPerSquareFoot = 7,
        WattPerSquareInch = 8,
        CaloriePerSquareCentimeterMinute = 9,
        LangleyPerHour = 10,
        NanowattPerSquareMeter = 11,
        MegawattPerSquareMeter = 12,
        CaloriePerSquareCentimeterSecond = 13,
        LangleyPerSecond = 14,
    }

    public static class UnitConverterIrradiance
    {
        public static double Convert(double value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            double baseValue = ToWattPerSquareMeter(value, from);
            return FromWattPerSquareMeter(baseValue, to);
        }

        public static double ToWattPerSquareMeter(double value, UnitConverterIrradianceUnit from)
        {
            switch (from)
            {
                case UnitConverterIrradianceUnit.WattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.KilowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.KilowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitConverterMetricIrradiance.MilliwattPerSquareCentimeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.WattPerSquareCentimeter:
                    return UnitConverterMetricIrradiance.WattPerSquareCentimeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.LangleyPerMinute:
                    return UnitConverterScientificIrradiance.LangleyPerMinuteToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitConverterMetricIrradiance.MilliwattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.MicrowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.WattPerSquareFoot:
                    return UnitConverterImperialIrradiance.WattPerSquareFootToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.WattPerSquareInch:
                    return UnitConverterImperialIrradiance.WattPerSquareInchToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitConverterMetricIrradiance.CaloriePerSquareCentimeterMinuteToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.LangleyPerHour:
                    return UnitConverterScientificIrradiance.LangleyPerHourToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.NanowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.NanowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.MegawattPerSquareMeter:
                    return UnitConverterMetricIrradiance.MegawattPerSquareMeterToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitConverterMetricIrradiance.CaloriePerSquareCentimeterSecondToWattPerSquareMeter(value);
                case UnitConverterIrradianceUnit.LangleyPerSecond:
                    return UnitConverterScientificIrradiance.LangleyPerSecondToWattPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported irradiance unit.");
            }
        }

        public static double FromWattPerSquareMeter(double baseValue, UnitConverterIrradianceUnit to)
        {
            switch (to)
            {
                case UnitConverterIrradianceUnit.WattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToWattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.KilowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToKilowattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToMilliwattPerSquareCentimeter(baseValue);
                case UnitConverterIrradianceUnit.WattPerSquareCentimeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToWattPerSquareCentimeter(baseValue);
                case UnitConverterIrradianceUnit.LangleyPerMinute:
                    return UnitConverterScientificIrradiance.WattPerSquareMeterToLangleyPerMinute(baseValue);
                case UnitConverterIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToMilliwattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToMicrowattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.WattPerSquareFoot:
                    return UnitConverterImperialIrradiance.WattPerSquareMeterToWattPerSquareFoot(baseValue);
                case UnitConverterIrradianceUnit.WattPerSquareInch:
                    return UnitConverterImperialIrradiance.WattPerSquareMeterToWattPerSquareInch(baseValue);
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToCaloriePerSquareCentimeterMinute(baseValue);
                case UnitConverterIrradianceUnit.LangleyPerHour:
                    return UnitConverterScientificIrradiance.WattPerSquareMeterToLangleyPerHour(baseValue);
                case UnitConverterIrradianceUnit.NanowattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToNanowattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.MegawattPerSquareMeter:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToMegawattPerSquareMeter(baseValue);
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitConverterMetricIrradiance.WattPerSquareMeterToCaloriePerSquareCentimeterSecond(baseValue);
                case UnitConverterIrradianceUnit.LangleyPerSecond:
                    return UnitConverterScientificIrradiance.WattPerSquareMeterToLangleyPerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported irradiance unit.");
            }
        }

        public static string GetSymbol(UnitConverterIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIrradianceUnit.WattPerSquareMeter:
                    return "W/m²";
                case UnitConverterIrradianceUnit.KilowattPerSquareMeter:
                    return "kW/m²";
                case UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter:
                    return "mW/cm²";
                case UnitConverterIrradianceUnit.WattPerSquareCentimeter:
                    return "W/cm²";
                case UnitConverterIrradianceUnit.LangleyPerMinute:
                    return "Ly/min";
                case UnitConverterIrradianceUnit.MilliwattPerSquareMeter:
                    return "mW/m²";
                case UnitConverterIrradianceUnit.MicrowattPerSquareMeter:
                    return "µW/m²";
                case UnitConverterIrradianceUnit.WattPerSquareFoot:
                    return "W/ft²";
                case UnitConverterIrradianceUnit.WattPerSquareInch:
                    return "W/in²";
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return "cal/(cm²·min)";
                case UnitConverterIrradianceUnit.LangleyPerHour:
                    return "Ly/h";
                case UnitConverterIrradianceUnit.NanowattPerSquareMeter:
                    return "nW/m²";
                case UnitConverterIrradianceUnit.MegawattPerSquareMeter:
                    return "MW/m²";
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return "cal/(cm²·s)";
                case UnitConverterIrradianceUnit.LangleyPerSecond:
                    return "Ly/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIrradianceUnit.WattPerSquareMeter:
                    return "Watt Per Square Meter";
                case UnitConverterIrradianceUnit.KilowattPerSquareMeter:
                    return "Kilowatt Per Square Meter";
                case UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter:
                    return "Milliwatt Per Square Centimeter";
                case UnitConverterIrradianceUnit.WattPerSquareCentimeter:
                    return "Watt Per Square Centimeter";
                case UnitConverterIrradianceUnit.LangleyPerMinute:
                    return "Langley Per Minute";
                case UnitConverterIrradianceUnit.MilliwattPerSquareMeter:
                    return "Milliwatt Per Square Meter";
                case UnitConverterIrradianceUnit.MicrowattPerSquareMeter:
                    return "Microwatt Per Square Meter";
                case UnitConverterIrradianceUnit.WattPerSquareFoot:
                    return "Watt Per Square Foot";
                case UnitConverterIrradianceUnit.WattPerSquareInch:
                    return "Watt Per Square Inch";
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return "Calorie Per Square Centimeter Minute";
                case UnitConverterIrradianceUnit.LangleyPerHour:
                    return "Langley Per Hour";
                case UnitConverterIrradianceUnit.NanowattPerSquareMeter:
                    return "Nanowatt Per Square Meter";
                case UnitConverterIrradianceUnit.MegawattPerSquareMeter:
                    return "Megawatt Per Square Meter";
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return "Calorie Per Square Centimeter Second";
                case UnitConverterIrradianceUnit.LangleyPerSecond:
                    return "Langley Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterIrradianceUnit.WattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.KilowattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.WattPerSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.LangleyPerMinute:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.WattPerSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterIrradianceUnit.WattPerSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.LangleyPerHour:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterIrradianceUnit.NanowattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.MegawattPerSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterIrradianceUnit.LangleyPerSecond:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterIrradianceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterIrradianceUnit.WattPerSquareMeter, UnitConverterIrradianceUnit.KilowattPerSquareMeter, UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter, UnitConverterIrradianceUnit.WattPerSquareCentimeter, UnitConverterIrradianceUnit.MilliwattPerSquareMeter, UnitConverterIrradianceUnit.MicrowattPerSquareMeter, UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute, UnitConverterIrradianceUnit.NanowattPerSquareMeter, UnitConverterIrradianceUnit.MegawattPerSquareMeter, UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterIrradianceUnit.LangleyPerMinute, UnitConverterIrradianceUnit.LangleyPerHour, UnitConverterIrradianceUnit.LangleyPerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterIrradianceUnit.WattPerSquareFoot, UnitConverterIrradianceUnit.WattPerSquareInch };
                default:
                    return new[] { UnitConverterIrradianceUnit.WattPerSquareMeter, UnitConverterIrradianceUnit.KilowattPerSquareMeter, UnitConverterIrradianceUnit.MilliwattPerSquareCentimeter, UnitConverterIrradianceUnit.WattPerSquareCentimeter, UnitConverterIrradianceUnit.LangleyPerMinute, UnitConverterIrradianceUnit.MilliwattPerSquareMeter, UnitConverterIrradianceUnit.MicrowattPerSquareMeter, UnitConverterIrradianceUnit.WattPerSquareFoot, UnitConverterIrradianceUnit.WattPerSquareInch, UnitConverterIrradianceUnit.CaloriePerSquareCentimeterMinute, UnitConverterIrradianceUnit.LangleyPerHour, UnitConverterIrradianceUnit.NanowattPerSquareMeter, UnitConverterIrradianceUnit.MegawattPerSquareMeter, UnitConverterIrradianceUnit.CaloriePerSquareCentimeterSecond, UnitConverterIrradianceUnit.LangleyPerSecond };
            }
        }
    }
}
