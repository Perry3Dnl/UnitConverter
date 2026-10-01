namespace RealisticPhysics.UnitConversion.Angle
{
    using RealisticPhysics.UnitConversion.Angle.Scientific;
    using RealisticPhysics.UnitConversion.Angle.Common;
    using RealisticPhysics.UnitConversion.Angle.Metric;
    using RealisticPhysics.UnitConversion.Angle.Astronomical;
    using RealisticPhysics.UnitConversion.Angle.Historical;
    using RealisticPhysics.UnitConversion.Angle.Nautical;

    public enum UnitConverterAngleUnit
    {
        Arcsecond = 0,
        Arcminute = 1,
        Degree = 2,
        Radian = 3,
        Milliradian = 4,
        Gradian = 5,
        Turn = 6,
        Quadrant = 7,
        Microradian = 8,
        Nanoradian = 9,
        Milliarcsecond = 10,
        Microarcsecond = 11,
        HourAngle = 12,
        MinuteOfTime = 13,
        SecondOfTime = 14,
        NatoMil = 15,
        ArtilleryMil = 16,
        BinaryDegree = 17,
        Sextant = 18,
        Sign = 19,
        CompassPoint = 20,
    }

    public static class UnitConverterAngle
    {
        public static double Convert(double value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            double baseValue = ToDegree(value, from);
            return FromDegree(baseValue, to);
        }

        public static double ToDegree(double value, UnitConverterAngleUnit from)
        {
            switch (from)
            {
                case UnitConverterAngleUnit.Arcsecond:
                    return UnitConverterScientificAngle.ArcsecondToDegree(value);
                case UnitConverterAngleUnit.Arcminute:
                    return UnitConverterScientificAngle.ArcminuteToDegree(value);
                case UnitConverterAngleUnit.Degree:
                    return UnitConverterCommonAngle.DegreeToDegree(value);
                case UnitConverterAngleUnit.Radian:
                    return UnitConverterScientificAngle.RadianToDegree(value);
                case UnitConverterAngleUnit.Milliradian:
                    return UnitConverterScientificAngle.MilliradianToDegree(value);
                case UnitConverterAngleUnit.Gradian:
                    return UnitConverterMetricAngle.GradianToDegree(value);
                case UnitConverterAngleUnit.Turn:
                    return UnitConverterCommonAngle.TurnToDegree(value);
                case UnitConverterAngleUnit.Quadrant:
                    return UnitConverterCommonAngle.QuadrantToDegree(value);
                case UnitConverterAngleUnit.Microradian:
                    return UnitConverterMetricAngle.MicroradianToDegree(value);
                case UnitConverterAngleUnit.Nanoradian:
                    return UnitConverterMetricAngle.NanoradianToDegree(value);
                case UnitConverterAngleUnit.Milliarcsecond:
                    return UnitConverterMetricAngle.MilliarcsecondToDegree(value);
                case UnitConverterAngleUnit.Microarcsecond:
                    return UnitConverterMetricAngle.MicroarcsecondToDegree(value);
                case UnitConverterAngleUnit.HourAngle:
                    return UnitConverterAstronomicalAngle.HourAngleToDegree(value);
                case UnitConverterAngleUnit.MinuteOfTime:
                    return UnitConverterAstronomicalAngle.MinuteOfTimeToDegree(value);
                case UnitConverterAngleUnit.SecondOfTime:
                    return UnitConverterAstronomicalAngle.SecondOfTimeToDegree(value);
                case UnitConverterAngleUnit.NatoMil:
                    return UnitConverterMetricAngle.NatoMilToDegree(value);
                case UnitConverterAngleUnit.ArtilleryMil:
                    return UnitConverterMetricAngle.ArtilleryMilToDegree(value);
                case UnitConverterAngleUnit.BinaryDegree:
                    return UnitConverterMetricAngle.BinaryDegreeToDegree(value);
                case UnitConverterAngleUnit.Sextant:
                    return UnitConverterHistoricalAngle.SextantToDegree(value);
                case UnitConverterAngleUnit.Sign:
                    return UnitConverterHistoricalAngle.SignToDegree(value);
                case UnitConverterAngleUnit.CompassPoint:
                    return UnitConverterNauticalAngle.CompassPointToDegree(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angle unit.");
            }
        }

        public static double FromDegree(double baseValue, UnitConverterAngleUnit to)
        {
            switch (to)
            {
                case UnitConverterAngleUnit.Arcsecond:
                    return UnitConverterScientificAngle.DegreeToArcsecond(baseValue);
                case UnitConverterAngleUnit.Arcminute:
                    return UnitConverterScientificAngle.DegreeToArcminute(baseValue);
                case UnitConverterAngleUnit.Degree:
                    return UnitConverterCommonAngle.DegreeToDegree(baseValue);
                case UnitConverterAngleUnit.Radian:
                    return UnitConverterScientificAngle.DegreeToRadian(baseValue);
                case UnitConverterAngleUnit.Milliradian:
                    return UnitConverterScientificAngle.DegreeToMilliradian(baseValue);
                case UnitConverterAngleUnit.Gradian:
                    return UnitConverterMetricAngle.DegreeToGradian(baseValue);
                case UnitConverterAngleUnit.Turn:
                    return UnitConverterCommonAngle.DegreeToTurn(baseValue);
                case UnitConverterAngleUnit.Quadrant:
                    return UnitConverterCommonAngle.DegreeToQuadrant(baseValue);
                case UnitConverterAngleUnit.Microradian:
                    return UnitConverterMetricAngle.DegreeToMicroradian(baseValue);
                case UnitConverterAngleUnit.Nanoradian:
                    return UnitConverterMetricAngle.DegreeToNanoradian(baseValue);
                case UnitConverterAngleUnit.Milliarcsecond:
                    return UnitConverterMetricAngle.DegreeToMilliarcsecond(baseValue);
                case UnitConverterAngleUnit.Microarcsecond:
                    return UnitConverterMetricAngle.DegreeToMicroarcsecond(baseValue);
                case UnitConverterAngleUnit.HourAngle:
                    return UnitConverterAstronomicalAngle.DegreeToHourAngle(baseValue);
                case UnitConverterAngleUnit.MinuteOfTime:
                    return UnitConverterAstronomicalAngle.DegreeToMinuteOfTime(baseValue);
                case UnitConverterAngleUnit.SecondOfTime:
                    return UnitConverterAstronomicalAngle.DegreeToSecondOfTime(baseValue);
                case UnitConverterAngleUnit.NatoMil:
                    return UnitConverterMetricAngle.DegreeToNatoMil(baseValue);
                case UnitConverterAngleUnit.ArtilleryMil:
                    return UnitConverterMetricAngle.DegreeToArtilleryMil(baseValue);
                case UnitConverterAngleUnit.BinaryDegree:
                    return UnitConverterMetricAngle.DegreeToBinaryDegree(baseValue);
                case UnitConverterAngleUnit.Sextant:
                    return UnitConverterHistoricalAngle.DegreeToSextant(baseValue);
                case UnitConverterAngleUnit.Sign:
                    return UnitConverterHistoricalAngle.DegreeToSign(baseValue);
                case UnitConverterAngleUnit.CompassPoint:
                    return UnitConverterNauticalAngle.DegreeToCompassPoint(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angle unit.");
            }
        }

        public static string GetSymbol(UnitConverterAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngleUnit.Arcsecond:
                    return "arcsec";
                case UnitConverterAngleUnit.Arcminute:
                    return "arcmin";
                case UnitConverterAngleUnit.Degree:
                    return "°";
                case UnitConverterAngleUnit.Radian:
                    return "rad";
                case UnitConverterAngleUnit.Milliradian:
                    return "mrad";
                case UnitConverterAngleUnit.Gradian:
                    return "gon";
                case UnitConverterAngleUnit.Turn:
                    return "turn";
                case UnitConverterAngleUnit.Quadrant:
                    return "quadrant";
                case UnitConverterAngleUnit.Microradian:
                    return "µrad";
                case UnitConverterAngleUnit.Nanoradian:
                    return "nrad";
                case UnitConverterAngleUnit.Milliarcsecond:
                    return "mas";
                case UnitConverterAngleUnit.Microarcsecond:
                    return "µas";
                case UnitConverterAngleUnit.HourAngle:
                    return "h angle";
                case UnitConverterAngleUnit.MinuteOfTime:
                    return "min time";
                case UnitConverterAngleUnit.SecondOfTime:
                    return "s time";
                case UnitConverterAngleUnit.NatoMil:
                    return "NATO mil";
                case UnitConverterAngleUnit.ArtilleryMil:
                    return "art mil";
                case UnitConverterAngleUnit.BinaryDegree:
                    return "brad";
                case UnitConverterAngleUnit.Sextant:
                    return "sextant";
                case UnitConverterAngleUnit.Sign:
                    return "sign";
                case UnitConverterAngleUnit.CompassPoint:
                    return "point";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngleUnit.Arcsecond:
                    return "arcsecond";
                case UnitConverterAngleUnit.Arcminute:
                    return "arcminute";
                case UnitConverterAngleUnit.Degree:
                    return "degree";
                case UnitConverterAngleUnit.Radian:
                    return "radian";
                case UnitConverterAngleUnit.Milliradian:
                    return "milliradian";
                case UnitConverterAngleUnit.Gradian:
                    return "gradian";
                case UnitConverterAngleUnit.Turn:
                    return "turn";
                case UnitConverterAngleUnit.Quadrant:
                    return "quadrant";
                case UnitConverterAngleUnit.Microradian:
                    return "Microradian";
                case UnitConverterAngleUnit.Nanoradian:
                    return "Nanoradian";
                case UnitConverterAngleUnit.Milliarcsecond:
                    return "Milliarcsecond";
                case UnitConverterAngleUnit.Microarcsecond:
                    return "Microarcsecond";
                case UnitConverterAngleUnit.HourAngle:
                    return "Hour Angle";
                case UnitConverterAngleUnit.MinuteOfTime:
                    return "Minute Of Time";
                case UnitConverterAngleUnit.SecondOfTime:
                    return "Second Of Time";
                case UnitConverterAngleUnit.NatoMil:
                    return "Nato Mil";
                case UnitConverterAngleUnit.ArtilleryMil:
                    return "Artillery Mil";
                case UnitConverterAngleUnit.BinaryDegree:
                    return "Binary Degree";
                case UnitConverterAngleUnit.Sextant:
                    return "Sextant";
                case UnitConverterAngleUnit.Sign:
                    return "Sign";
                case UnitConverterAngleUnit.CompassPoint:
                    return "Compass Point";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngleUnit.Arcsecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngleUnit.Arcminute:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngleUnit.Degree:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngleUnit.Radian:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngleUnit.Milliradian:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngleUnit.Gradian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.Turn:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngleUnit.Quadrant:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngleUnit.Microradian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.Nanoradian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.Milliarcsecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.Microarcsecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.HourAngle:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterAngleUnit.MinuteOfTime:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterAngleUnit.SecondOfTime:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterAngleUnit.NatoMil:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.ArtilleryMil:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.BinaryDegree:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngleUnit.Sextant:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterAngleUnit.Sign:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterAngleUnit.CompassPoint:
                    return UnitConverterUnitSystem.Nautical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAngleUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAngleUnit.Arcsecond, UnitConverterAngleUnit.Arcminute, UnitConverterAngleUnit.Radian, UnitConverterAngleUnit.Milliradian };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterAngleUnit.Degree, UnitConverterAngleUnit.Turn, UnitConverterAngleUnit.Quadrant };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAngleUnit.Gradian, UnitConverterAngleUnit.Microradian, UnitConverterAngleUnit.Nanoradian, UnitConverterAngleUnit.Milliarcsecond, UnitConverterAngleUnit.Microarcsecond, UnitConverterAngleUnit.NatoMil, UnitConverterAngleUnit.ArtilleryMil, UnitConverterAngleUnit.BinaryDegree };
                case UnitConverterUnitSystem.Astronomical:
                    return new[] { UnitConverterAngleUnit.HourAngle, UnitConverterAngleUnit.MinuteOfTime, UnitConverterAngleUnit.SecondOfTime };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterAngleUnit.Sextant, UnitConverterAngleUnit.Sign };
                case UnitConverterUnitSystem.Nautical:
                    return new[] { UnitConverterAngleUnit.CompassPoint };
                default:
                    return new[] { UnitConverterAngleUnit.Arcsecond, UnitConverterAngleUnit.Arcminute, UnitConverterAngleUnit.Degree, UnitConverterAngleUnit.Radian, UnitConverterAngleUnit.Milliradian, UnitConverterAngleUnit.Gradian, UnitConverterAngleUnit.Turn, UnitConverterAngleUnit.Quadrant, UnitConverterAngleUnit.Microradian, UnitConverterAngleUnit.Nanoradian, UnitConverterAngleUnit.Milliarcsecond, UnitConverterAngleUnit.Microarcsecond, UnitConverterAngleUnit.HourAngle, UnitConverterAngleUnit.MinuteOfTime, UnitConverterAngleUnit.SecondOfTime, UnitConverterAngleUnit.NatoMil, UnitConverterAngleUnit.ArtilleryMil, UnitConverterAngleUnit.BinaryDegree, UnitConverterAngleUnit.Sextant, UnitConverterAngleUnit.Sign, UnitConverterAngleUnit.CompassPoint };
            }
        }
    }
}
