namespace RealisticPhysics.UnitConversion.Snap
{
    using RealisticPhysics.UnitConversion.Snap.Metric;
    using RealisticPhysics.UnitConversion.Snap.Imperial;
    using RealisticPhysics.UnitConversion.Snap.Engineering;

    public enum UnitConverterSnapUnit
    {
        MeterPerSecondFourth = 0,
        CentimeterPerSecondFourth = 1,
        MillimeterPerSecondFourth = 2,
        FootPerSecondFourth = 3,
        KilometerPerSecondFourth = 4,
        DecimeterPerSecondFourth = 5,
        MicrometerPerSecondFourth = 6,
        InchPerSecondFourth = 7,
        YardPerSecondFourth = 8,
        StandardGravityPerSecondSquared = 9,
    }

    public static class UnitConverterSnap
    {
        public static double Convert(double value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            double baseValue = ToMeterPerSecondFourth(value, from);
            return FromMeterPerSecondFourth(baseValue, to);
        }

        public static double ToMeterPerSecondFourth(double value, UnitConverterSnapUnit from)
        {
            switch (from)
            {
                case UnitConverterSnapUnit.MeterPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.CentimeterPerSecondFourth:
                    return UnitConverterMetricSnap.CentimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.MillimeterPerSecondFourth:
                    return UnitConverterMetricSnap.MillimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.FootPerSecondFourth:
                    return UnitConverterImperialSnap.FootPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.KilometerPerSecondFourth:
                    return UnitConverterMetricSnap.KilometerPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.DecimeterPerSecondFourth:
                    return UnitConverterMetricSnap.DecimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.MicrometerPerSecondFourth:
                    return UnitConverterMetricSnap.MicrometerPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.InchPerSecondFourth:
                    return UnitConverterImperialSnap.InchPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.YardPerSecondFourth:
                    return UnitConverterImperialSnap.YardPerSecondFourthToMeterPerSecondFourth(value);
                case UnitConverterSnapUnit.StandardGravityPerSecondSquared:
                    return UnitConverterEngineeringSnap.StandardGravityPerSecondSquaredToMeterPerSecondFourth(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported snap unit.");
            }
        }

        public static double FromMeterPerSecondFourth(double baseValue, UnitConverterSnapUnit to)
        {
            switch (to)
            {
                case UnitConverterSnapUnit.MeterPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToMeterPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.CentimeterPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToCentimeterPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.MillimeterPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToMillimeterPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.FootPerSecondFourth:
                    return UnitConverterImperialSnap.MeterPerSecondFourthToFootPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.KilometerPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToKilometerPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.DecimeterPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToDecimeterPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.MicrometerPerSecondFourth:
                    return UnitConverterMetricSnap.MeterPerSecondFourthToMicrometerPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.InchPerSecondFourth:
                    return UnitConverterImperialSnap.MeterPerSecondFourthToInchPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.YardPerSecondFourth:
                    return UnitConverterImperialSnap.MeterPerSecondFourthToYardPerSecondFourth(baseValue);
                case UnitConverterSnapUnit.StandardGravityPerSecondSquared:
                    return UnitConverterEngineeringSnap.MeterPerSecondFourthToStandardGravityPerSecondSquared(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported snap unit.");
            }
        }

        public static string GetSymbol(UnitConverterSnapUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSnapUnit.MeterPerSecondFourth:
                    return "m/s⁴";
                case UnitConverterSnapUnit.CentimeterPerSecondFourth:
                    return "cm/s⁴";
                case UnitConverterSnapUnit.MillimeterPerSecondFourth:
                    return "mm/s⁴";
                case UnitConverterSnapUnit.FootPerSecondFourth:
                    return "ft/s⁴";
                case UnitConverterSnapUnit.KilometerPerSecondFourth:
                    return "km/s⁴";
                case UnitConverterSnapUnit.DecimeterPerSecondFourth:
                    return "dm/s⁴";
                case UnitConverterSnapUnit.MicrometerPerSecondFourth:
                    return "µm/s⁴";
                case UnitConverterSnapUnit.InchPerSecondFourth:
                    return "in/s⁴";
                case UnitConverterSnapUnit.YardPerSecondFourth:
                    return "yd/s⁴";
                case UnitConverterSnapUnit.StandardGravityPerSecondSquared:
                    return "g₀/s²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSnapUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSnapUnit.MeterPerSecondFourth:
                    return "Meter Per Second Fourth";
                case UnitConverterSnapUnit.CentimeterPerSecondFourth:
                    return "Centimeter Per Second Fourth";
                case UnitConverterSnapUnit.MillimeterPerSecondFourth:
                    return "Millimeter Per Second Fourth";
                case UnitConverterSnapUnit.FootPerSecondFourth:
                    return "Foot Per Second Fourth";
                case UnitConverterSnapUnit.KilometerPerSecondFourth:
                    return "Kilometer Per Second Fourth";
                case UnitConverterSnapUnit.DecimeterPerSecondFourth:
                    return "Decimeter Per Second Fourth";
                case UnitConverterSnapUnit.MicrometerPerSecondFourth:
                    return "Micrometer Per Second Fourth";
                case UnitConverterSnapUnit.InchPerSecondFourth:
                    return "Inch Per Second Fourth";
                case UnitConverterSnapUnit.YardPerSecondFourth:
                    return "Yard Per Second Fourth";
                case UnitConverterSnapUnit.StandardGravityPerSecondSquared:
                    return "Standard Gravity Per Second Squared";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSnapUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSnapUnit.MeterPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.CentimeterPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.MillimeterPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.FootPerSecondFourth:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSnapUnit.KilometerPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.DecimeterPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.MicrometerPerSecondFourth:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSnapUnit.InchPerSecondFourth:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSnapUnit.YardPerSecondFourth:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSnapUnit.StandardGravityPerSecondSquared:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSnapUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSnapUnit.MeterPerSecondFourth, UnitConverterSnapUnit.CentimeterPerSecondFourth, UnitConverterSnapUnit.MillimeterPerSecondFourth, UnitConverterSnapUnit.KilometerPerSecondFourth, UnitConverterSnapUnit.DecimeterPerSecondFourth, UnitConverterSnapUnit.MicrometerPerSecondFourth };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSnapUnit.FootPerSecondFourth, UnitConverterSnapUnit.InchPerSecondFourth, UnitConverterSnapUnit.YardPerSecondFourth };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterSnapUnit.StandardGravityPerSecondSquared };
                default:
                    return new[] { UnitConverterSnapUnit.MeterPerSecondFourth, UnitConverterSnapUnit.CentimeterPerSecondFourth, UnitConverterSnapUnit.MillimeterPerSecondFourth, UnitConverterSnapUnit.FootPerSecondFourth, UnitConverterSnapUnit.KilometerPerSecondFourth, UnitConverterSnapUnit.DecimeterPerSecondFourth, UnitConverterSnapUnit.MicrometerPerSecondFourth, UnitConverterSnapUnit.InchPerSecondFourth, UnitConverterSnapUnit.YardPerSecondFourth, UnitConverterSnapUnit.StandardGravityPerSecondSquared };
            }
        }
    }
}
