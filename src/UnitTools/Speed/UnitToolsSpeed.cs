namespace UnitTools.Speed
{
    using UnitTools.Speed.Metric;
    using UnitTools.Speed.Imperial;
    using UnitTools.Speed.Nautical;
    using UnitTools.Speed.Scientific;

    public enum UnitToolsSpeedUnit
    {
        MeterPerSecond = 0,
        KilometerPerHour = 1,
        FootPerSecond = 2,
        MilePerHour = 3,
        Knot = 4,
        MachAtSeaLevel = 5,
        SpeedOfLight = 6,
        MicrometerPerSecond = 7,
        CentimeterPerSecond = 8,
        MillimeterPerSecond = 9,
        MeterPerMinute = 10,
        MeterPerHour = 11,
        KilometerPerSecond = 12,
        InchPerSecond = 13,
        InchPerMinute = 14,
        FootPerMinute = 15,
        YardPerSecond = 16,
        MilePerSecond = 17,
        SpeedOfSoundAirApprox = 18,
    }

    public static class UnitToolsSpeed
    {
        public static double Convert(double value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            double baseValue = ToMeterPerSecond(value, from);
            return FromMeterPerSecond(baseValue, to);
        }

        public static double ToMeterPerSecond(double value, UnitToolsSpeedUnit from)
        {
            switch (from)
            {
                case UnitToolsSpeedUnit.MeterPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.KilometerPerHour:
                    return UnitToolsMetricSpeed.KilometerPerHourToMeterPerSecond(value);
                case UnitToolsSpeedUnit.FootPerSecond:
                    return UnitToolsImperialSpeed.FootPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MilePerHour:
                    return UnitToolsImperialSpeed.MilePerHourToMeterPerSecond(value);
                case UnitToolsSpeedUnit.Knot:
                    return UnitToolsNauticalSpeed.KnotToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MachAtSeaLevel:
                    return UnitToolsScientificSpeed.MachAtSeaLevelToMeterPerSecond(value);
                case UnitToolsSpeedUnit.SpeedOfLight:
                    return UnitToolsScientificSpeed.SpeedOfLightToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MicrometerPerSecond:
                    return UnitToolsMetricSpeed.MicrometerPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.CentimeterPerSecond:
                    return UnitToolsMetricSpeed.CentimeterPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MillimeterPerSecond:
                    return UnitToolsMetricSpeed.MillimeterPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MeterPerMinute:
                    return UnitToolsMetricSpeed.MeterPerMinuteToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MeterPerHour:
                    return UnitToolsMetricSpeed.MeterPerHourToMeterPerSecond(value);
                case UnitToolsSpeedUnit.KilometerPerSecond:
                    return UnitToolsMetricSpeed.KilometerPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.InchPerSecond:
                    return UnitToolsImperialSpeed.InchPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.InchPerMinute:
                    return UnitToolsImperialSpeed.InchPerMinuteToMeterPerSecond(value);
                case UnitToolsSpeedUnit.FootPerMinute:
                    return UnitToolsImperialSpeed.FootPerMinuteToMeterPerSecond(value);
                case UnitToolsSpeedUnit.YardPerSecond:
                    return UnitToolsImperialSpeed.YardPerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.MilePerSecond:
                    return UnitToolsImperialSpeed.MilePerSecondToMeterPerSecond(value);
                case UnitToolsSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitToolsScientificSpeed.SpeedOfSoundAirApproxToMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported speed unit.");
            }
        }

        public static double FromMeterPerSecond(double baseValue, UnitToolsSpeedUnit to)
        {
            switch (to)
            {
                case UnitToolsSpeedUnit.MeterPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToMeterPerSecond(baseValue);
                case UnitToolsSpeedUnit.KilometerPerHour:
                    return UnitToolsMetricSpeed.MeterPerSecondToKilometerPerHour(baseValue);
                case UnitToolsSpeedUnit.FootPerSecond:
                    return UnitToolsImperialSpeed.MeterPerSecondToFootPerSecond(baseValue);
                case UnitToolsSpeedUnit.MilePerHour:
                    return UnitToolsImperialSpeed.MeterPerSecondToMilePerHour(baseValue);
                case UnitToolsSpeedUnit.Knot:
                    return UnitToolsNauticalSpeed.MeterPerSecondToKnot(baseValue);
                case UnitToolsSpeedUnit.MachAtSeaLevel:
                    return UnitToolsScientificSpeed.MeterPerSecondToMachAtSeaLevel(baseValue);
                case UnitToolsSpeedUnit.SpeedOfLight:
                    return UnitToolsScientificSpeed.MeterPerSecondToSpeedOfLight(baseValue);
                case UnitToolsSpeedUnit.MicrometerPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToMicrometerPerSecond(baseValue);
                case UnitToolsSpeedUnit.CentimeterPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToCentimeterPerSecond(baseValue);
                case UnitToolsSpeedUnit.MillimeterPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToMillimeterPerSecond(baseValue);
                case UnitToolsSpeedUnit.MeterPerMinute:
                    return UnitToolsMetricSpeed.MeterPerSecondToMeterPerMinute(baseValue);
                case UnitToolsSpeedUnit.MeterPerHour:
                    return UnitToolsMetricSpeed.MeterPerSecondToMeterPerHour(baseValue);
                case UnitToolsSpeedUnit.KilometerPerSecond:
                    return UnitToolsMetricSpeed.MeterPerSecondToKilometerPerSecond(baseValue);
                case UnitToolsSpeedUnit.InchPerSecond:
                    return UnitToolsImperialSpeed.MeterPerSecondToInchPerSecond(baseValue);
                case UnitToolsSpeedUnit.InchPerMinute:
                    return UnitToolsImperialSpeed.MeterPerSecondToInchPerMinute(baseValue);
                case UnitToolsSpeedUnit.FootPerMinute:
                    return UnitToolsImperialSpeed.MeterPerSecondToFootPerMinute(baseValue);
                case UnitToolsSpeedUnit.YardPerSecond:
                    return UnitToolsImperialSpeed.MeterPerSecondToYardPerSecond(baseValue);
                case UnitToolsSpeedUnit.MilePerSecond:
                    return UnitToolsImperialSpeed.MeterPerSecondToMilePerSecond(baseValue);
                case UnitToolsSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitToolsScientificSpeed.MeterPerSecondToSpeedOfSoundAirApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported speed unit.");
            }
        }

        public static string GetSymbol(UnitToolsSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpeedUnit.MeterPerSecond:
                    return "m/s";
                case UnitToolsSpeedUnit.KilometerPerHour:
                    return "km/h";
                case UnitToolsSpeedUnit.FootPerSecond:
                    return "ft/s";
                case UnitToolsSpeedUnit.MilePerHour:
                    return "mph";
                case UnitToolsSpeedUnit.Knot:
                    return "kn";
                case UnitToolsSpeedUnit.MachAtSeaLevel:
                    return "M";
                case UnitToolsSpeedUnit.SpeedOfLight:
                    return "c";
                case UnitToolsSpeedUnit.MicrometerPerSecond:
                    return "µm/s";
                case UnitToolsSpeedUnit.CentimeterPerSecond:
                    return "cm/s";
                case UnitToolsSpeedUnit.MillimeterPerSecond:
                    return "mm/s";
                case UnitToolsSpeedUnit.MeterPerMinute:
                    return "m/min";
                case UnitToolsSpeedUnit.MeterPerHour:
                    return "m/h";
                case UnitToolsSpeedUnit.KilometerPerSecond:
                    return "km/s";
                case UnitToolsSpeedUnit.InchPerSecond:
                    return "in/s";
                case UnitToolsSpeedUnit.InchPerMinute:
                    return "in/min";
                case UnitToolsSpeedUnit.FootPerMinute:
                    return "ft/min";
                case UnitToolsSpeedUnit.YardPerSecond:
                    return "yd/s";
                case UnitToolsSpeedUnit.MilePerSecond:
                    return "mi/s";
                case UnitToolsSpeedUnit.SpeedOfSoundAirApprox:
                    return "Mach approx";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpeedUnit.MeterPerSecond:
                    return "meter per second";
                case UnitToolsSpeedUnit.KilometerPerHour:
                    return "kilometer per hour";
                case UnitToolsSpeedUnit.FootPerSecond:
                    return "foot per second";
                case UnitToolsSpeedUnit.MilePerHour:
                    return "mile per hour";
                case UnitToolsSpeedUnit.Knot:
                    return "knot";
                case UnitToolsSpeedUnit.MachAtSeaLevel:
                    return "Mach at sea level";
                case UnitToolsSpeedUnit.SpeedOfLight:
                    return "speed of light";
                case UnitToolsSpeedUnit.MicrometerPerSecond:
                    return "Micrometer Per Second";
                case UnitToolsSpeedUnit.CentimeterPerSecond:
                    return "Centimeter Per Second";
                case UnitToolsSpeedUnit.MillimeterPerSecond:
                    return "Millimeter Per Second";
                case UnitToolsSpeedUnit.MeterPerMinute:
                    return "Meter Per Minute";
                case UnitToolsSpeedUnit.MeterPerHour:
                    return "Meter Per Hour";
                case UnitToolsSpeedUnit.KilometerPerSecond:
                    return "Kilometer Per Second";
                case UnitToolsSpeedUnit.InchPerSecond:
                    return "Inch Per Second";
                case UnitToolsSpeedUnit.InchPerMinute:
                    return "Inch Per Minute";
                case UnitToolsSpeedUnit.FootPerMinute:
                    return "Foot Per Minute";
                case UnitToolsSpeedUnit.YardPerSecond:
                    return "Yard Per Second";
                case UnitToolsSpeedUnit.MilePerSecond:
                    return "Mile Per Second";
                case UnitToolsSpeedUnit.SpeedOfSoundAirApprox:
                    return "Speed Of Sound Air Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpeedUnit.MeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.KilometerPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.FootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.MilePerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.Knot:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsSpeedUnit.MachAtSeaLevel:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsSpeedUnit.SpeedOfLight:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsSpeedUnit.MicrometerPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.CentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.MillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.MeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.MeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.KilometerPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpeedUnit.InchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.InchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.FootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.YardPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.MilePerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSpeedUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSpeedUnit.MeterPerSecond, UnitToolsSpeedUnit.KilometerPerHour, UnitToolsSpeedUnit.MicrometerPerSecond, UnitToolsSpeedUnit.CentimeterPerSecond, UnitToolsSpeedUnit.MillimeterPerSecond, UnitToolsSpeedUnit.MeterPerMinute, UnitToolsSpeedUnit.MeterPerHour, UnitToolsSpeedUnit.KilometerPerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSpeedUnit.FootPerSecond, UnitToolsSpeedUnit.MilePerHour, UnitToolsSpeedUnit.InchPerSecond, UnitToolsSpeedUnit.InchPerMinute, UnitToolsSpeedUnit.FootPerMinute, UnitToolsSpeedUnit.YardPerSecond, UnitToolsSpeedUnit.MilePerSecond };
                case UnitToolsUnitSystem.Nautical:
                    return new[] { UnitToolsSpeedUnit.Knot };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsSpeedUnit.MachAtSeaLevel, UnitToolsSpeedUnit.SpeedOfLight, UnitToolsSpeedUnit.SpeedOfSoundAirApprox };
                default:
                    return new[] { UnitToolsSpeedUnit.MeterPerSecond, UnitToolsSpeedUnit.KilometerPerHour, UnitToolsSpeedUnit.FootPerSecond, UnitToolsSpeedUnit.MilePerHour, UnitToolsSpeedUnit.Knot, UnitToolsSpeedUnit.MachAtSeaLevel, UnitToolsSpeedUnit.SpeedOfLight, UnitToolsSpeedUnit.MicrometerPerSecond, UnitToolsSpeedUnit.CentimeterPerSecond, UnitToolsSpeedUnit.MillimeterPerSecond, UnitToolsSpeedUnit.MeterPerMinute, UnitToolsSpeedUnit.MeterPerHour, UnitToolsSpeedUnit.KilometerPerSecond, UnitToolsSpeedUnit.InchPerSecond, UnitToolsSpeedUnit.InchPerMinute, UnitToolsSpeedUnit.FootPerMinute, UnitToolsSpeedUnit.YardPerSecond, UnitToolsSpeedUnit.MilePerSecond, UnitToolsSpeedUnit.SpeedOfSoundAirApprox };
            }
        }
    }
}
