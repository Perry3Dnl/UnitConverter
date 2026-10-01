namespace UnitConverter.Speed
{
    using UnitConverter.Speed.Metric;
    using UnitConverter.Speed.Imperial;
    using UnitConverter.Speed.Nautical;
    using UnitConverter.Speed.Scientific;

    public enum UnitConverterSpeedUnit
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

    public static class UnitConverterSpeed
    {
        public static double Convert(double value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            double baseValue = ToMeterPerSecond(value, from);
            return FromMeterPerSecond(baseValue, to);
        }

        public static double ToMeterPerSecond(double value, UnitConverterSpeedUnit from)
        {
            switch (from)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return UnitConverterMetricSpeed.KilometerPerHourToMeterPerSecond(value);
                case UnitConverterSpeedUnit.FootPerSecond:
                    return UnitConverterImperialSpeed.FootPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MilePerHour:
                    return UnitConverterImperialSpeed.MilePerHourToMeterPerSecond(value);
                case UnitConverterSpeedUnit.Knot:
                    return UnitConverterNauticalSpeed.KnotToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MachAtSeaLevel:
                    return UnitConverterScientificSpeed.MachAtSeaLevelToMeterPerSecond(value);
                case UnitConverterSpeedUnit.SpeedOfLight:
                    return UnitConverterScientificSpeed.SpeedOfLightToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return UnitConverterMetricSpeed.MicrometerPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return UnitConverterMetricSpeed.CentimeterPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return UnitConverterMetricSpeed.MillimeterPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MeterPerMinute:
                    return UnitConverterMetricSpeed.MeterPerMinuteToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MeterPerHour:
                    return UnitConverterMetricSpeed.MeterPerHourToMeterPerSecond(value);
                case UnitConverterSpeedUnit.KilometerPerSecond:
                    return UnitConverterMetricSpeed.KilometerPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.InchPerSecond:
                    return UnitConverterImperialSpeed.InchPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.InchPerMinute:
                    return UnitConverterImperialSpeed.InchPerMinuteToMeterPerSecond(value);
                case UnitConverterSpeedUnit.FootPerMinute:
                    return UnitConverterImperialSpeed.FootPerMinuteToMeterPerSecond(value);
                case UnitConverterSpeedUnit.YardPerSecond:
                    return UnitConverterImperialSpeed.YardPerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.MilePerSecond:
                    return UnitConverterImperialSpeed.MilePerSecondToMeterPerSecond(value);
                case UnitConverterSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitConverterScientificSpeed.SpeedOfSoundAirApproxToMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported speed unit.");
            }
        }

        public static double FromMeterPerSecond(double baseValue, UnitConverterSpeedUnit to)
        {
            switch (to)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToMeterPerSecond(baseValue);
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return UnitConverterMetricSpeed.MeterPerSecondToKilometerPerHour(baseValue);
                case UnitConverterSpeedUnit.FootPerSecond:
                    return UnitConverterImperialSpeed.MeterPerSecondToFootPerSecond(baseValue);
                case UnitConverterSpeedUnit.MilePerHour:
                    return UnitConverterImperialSpeed.MeterPerSecondToMilePerHour(baseValue);
                case UnitConverterSpeedUnit.Knot:
                    return UnitConverterNauticalSpeed.MeterPerSecondToKnot(baseValue);
                case UnitConverterSpeedUnit.MachAtSeaLevel:
                    return UnitConverterScientificSpeed.MeterPerSecondToMachAtSeaLevel(baseValue);
                case UnitConverterSpeedUnit.SpeedOfLight:
                    return UnitConverterScientificSpeed.MeterPerSecondToSpeedOfLight(baseValue);
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToMicrometerPerSecond(baseValue);
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToCentimeterPerSecond(baseValue);
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToMillimeterPerSecond(baseValue);
                case UnitConverterSpeedUnit.MeterPerMinute:
                    return UnitConverterMetricSpeed.MeterPerSecondToMeterPerMinute(baseValue);
                case UnitConverterSpeedUnit.MeterPerHour:
                    return UnitConverterMetricSpeed.MeterPerSecondToMeterPerHour(baseValue);
                case UnitConverterSpeedUnit.KilometerPerSecond:
                    return UnitConverterMetricSpeed.MeterPerSecondToKilometerPerSecond(baseValue);
                case UnitConverterSpeedUnit.InchPerSecond:
                    return UnitConverterImperialSpeed.MeterPerSecondToInchPerSecond(baseValue);
                case UnitConverterSpeedUnit.InchPerMinute:
                    return UnitConverterImperialSpeed.MeterPerSecondToInchPerMinute(baseValue);
                case UnitConverterSpeedUnit.FootPerMinute:
                    return UnitConverterImperialSpeed.MeterPerSecondToFootPerMinute(baseValue);
                case UnitConverterSpeedUnit.YardPerSecond:
                    return UnitConverterImperialSpeed.MeterPerSecondToYardPerSecond(baseValue);
                case UnitConverterSpeedUnit.MilePerSecond:
                    return UnitConverterImperialSpeed.MeterPerSecondToMilePerSecond(baseValue);
                case UnitConverterSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitConverterScientificSpeed.MeterPerSecondToSpeedOfSoundAirApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported speed unit.");
            }
        }

        public static string GetSymbol(UnitConverterSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return "m/s";
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return "km/h";
                case UnitConverterSpeedUnit.FootPerSecond:
                    return "ft/s";
                case UnitConverterSpeedUnit.MilePerHour:
                    return "mph";
                case UnitConverterSpeedUnit.Knot:
                    return "kn";
                case UnitConverterSpeedUnit.MachAtSeaLevel:
                    return "M";
                case UnitConverterSpeedUnit.SpeedOfLight:
                    return "c";
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return "µm/s";
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return "cm/s";
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return "mm/s";
                case UnitConverterSpeedUnit.MeterPerMinute:
                    return "m/min";
                case UnitConverterSpeedUnit.MeterPerHour:
                    return "m/h";
                case UnitConverterSpeedUnit.KilometerPerSecond:
                    return "km/s";
                case UnitConverterSpeedUnit.InchPerSecond:
                    return "in/s";
                case UnitConverterSpeedUnit.InchPerMinute:
                    return "in/min";
                case UnitConverterSpeedUnit.FootPerMinute:
                    return "ft/min";
                case UnitConverterSpeedUnit.YardPerSecond:
                    return "yd/s";
                case UnitConverterSpeedUnit.MilePerSecond:
                    return "mi/s";
                case UnitConverterSpeedUnit.SpeedOfSoundAirApprox:
                    return "Mach approx";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return "meter per second";
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return "kilometer per hour";
                case UnitConverterSpeedUnit.FootPerSecond:
                    return "foot per second";
                case UnitConverterSpeedUnit.MilePerHour:
                    return "mile per hour";
                case UnitConverterSpeedUnit.Knot:
                    return "knot";
                case UnitConverterSpeedUnit.MachAtSeaLevel:
                    return "Mach at sea level";
                case UnitConverterSpeedUnit.SpeedOfLight:
                    return "speed of light";
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return "Micrometer Per Second";
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return "Centimeter Per Second";
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return "Millimeter Per Second";
                case UnitConverterSpeedUnit.MeterPerMinute:
                    return "Meter Per Minute";
                case UnitConverterSpeedUnit.MeterPerHour:
                    return "Meter Per Hour";
                case UnitConverterSpeedUnit.KilometerPerSecond:
                    return "Kilometer Per Second";
                case UnitConverterSpeedUnit.InchPerSecond:
                    return "Inch Per Second";
                case UnitConverterSpeedUnit.InchPerMinute:
                    return "Inch Per Minute";
                case UnitConverterSpeedUnit.FootPerMinute:
                    return "Foot Per Minute";
                case UnitConverterSpeedUnit.YardPerSecond:
                    return "Yard Per Second";
                case UnitConverterSpeedUnit.MilePerSecond:
                    return "Mile Per Second";
                case UnitConverterSpeedUnit.SpeedOfSoundAirApprox:
                    return "Speed Of Sound Air Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.FootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.MilePerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.Knot:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterSpeedUnit.MachAtSeaLevel:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterSpeedUnit.SpeedOfLight:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.MeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.MeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.KilometerPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpeedUnit.InchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.InchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.FootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.YardPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.MilePerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpeedUnit.SpeedOfSoundAirApprox:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSpeedUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSpeedUnit.MeterPerSecond, UnitConverterSpeedUnit.KilometerPerHour, UnitConverterSpeedUnit.MicrometerPerSecond, UnitConverterSpeedUnit.CentimeterPerSecond, UnitConverterSpeedUnit.MillimeterPerSecond, UnitConverterSpeedUnit.MeterPerMinute, UnitConverterSpeedUnit.MeterPerHour, UnitConverterSpeedUnit.KilometerPerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSpeedUnit.FootPerSecond, UnitConverterSpeedUnit.MilePerHour, UnitConverterSpeedUnit.InchPerSecond, UnitConverterSpeedUnit.InchPerMinute, UnitConverterSpeedUnit.FootPerMinute, UnitConverterSpeedUnit.YardPerSecond, UnitConverterSpeedUnit.MilePerSecond };
                case UnitConverterUnitSystem.Nautical:
                    return new[] { UnitConverterSpeedUnit.Knot };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterSpeedUnit.MachAtSeaLevel, UnitConverterSpeedUnit.SpeedOfLight, UnitConverterSpeedUnit.SpeedOfSoundAirApprox };
                default:
                    return new[] { UnitConverterSpeedUnit.MeterPerSecond, UnitConverterSpeedUnit.KilometerPerHour, UnitConverterSpeedUnit.FootPerSecond, UnitConverterSpeedUnit.MilePerHour, UnitConverterSpeedUnit.Knot, UnitConverterSpeedUnit.MachAtSeaLevel, UnitConverterSpeedUnit.SpeedOfLight, UnitConverterSpeedUnit.MicrometerPerSecond, UnitConverterSpeedUnit.CentimeterPerSecond, UnitConverterSpeedUnit.MillimeterPerSecond, UnitConverterSpeedUnit.MeterPerMinute, UnitConverterSpeedUnit.MeterPerHour, UnitConverterSpeedUnit.KilometerPerSecond, UnitConverterSpeedUnit.InchPerSecond, UnitConverterSpeedUnit.InchPerMinute, UnitConverterSpeedUnit.FootPerMinute, UnitConverterSpeedUnit.YardPerSecond, UnitConverterSpeedUnit.MilePerSecond, UnitConverterSpeedUnit.SpeedOfSoundAirApprox };
            }
        }
    }
}
