namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using UnitConverter.Catalog;
    using UnitConverter.FuelEconomy;
    using UnitConverter.SpecificGravity;
    using UnitConverter.Temperature;

    /// <summary>
    /// Decimal-native conversion entry point. Decimal inputs never pass through double.
    /// Linear factors are represented as reduced rational numbers; affine and reciprocal
    /// families use explicit rational transforms.
    /// </summary>
    public static class UnitConverterExact
    {
        public static decimal Convert<TUnit>(decimal value, TUnit from, TUnit to)
            where TUnit : struct
        {
            return UnitConverterDecimal.Convert(value, from, to);
        }

        public static bool TryConvert<TUnit>(decimal value, TUnit from, TUnit to, out decimal result)
            where TUnit : struct
        {
            try
            {
                result = Convert(value, from, to);
                return true;
            }
            catch (ArgumentException)
            {
                result = decimal.Zero;
                return false;
            }
            catch (InvalidOperationException)
            {
                result = decimal.Zero;
                return false;
            }
            catch (NotSupportedException)
            {
                result = decimal.Zero;
                return false;
            }
            catch (OverflowException)
            {
                result = decimal.Zero;
                return false;
            }
            catch (DivideByZeroException)
            {
                result = decimal.Zero;
                return false;
            }
        }
    }

    internal static class UnitConverterDecimal
    {
        internal static decimal Convert<TUnit>(decimal value, TUnit from, TUnit to)
            where TUnit : struct
        {
            if (typeof(TUnit) == typeof(UnitConverterTemperatureUnit))
            {
                return TemperatureDecimal.Convert(
                    value,
                    (UnitConverterTemperatureUnit)(object)from,
                    (UnitConverterTemperatureUnit)(object)to);
            }

            if (typeof(TUnit) == typeof(UnitConverterFuelEconomyUnit))
            {
                return FuelEconomyDecimal.Convert(
                    value,
                    (UnitConverterFuelEconomyUnit)(object)from,
                    (UnitConverterFuelEconomyUnit)(object)to);
            }

            if (typeof(TUnit) == typeof(UnitConverterSpecificGravityUnit))
            {
                return SpecificGravityDecimal.Convert(
                    value,
                    (UnitConverterSpecificGravityUnit)(object)from,
                    (UnitConverterSpecificGravityUnit)(object)to);
            }

            UnitConverterRational fromScale = LinearFamily<TUnit>.GetScale(from);
            if (EqualityComparer<TUnit>.Default.Equals(from, to))
                return value;

            UnitConverterRational toScale = LinearFamily<TUnit>.GetScale(to);
            return fromScale.Divide(toScale).Apply(value);
        }

        internal static UnitConverterFamilyDescriptor<TUnit> GetDescriptor<TUnit>()
            where TUnit : struct
            => LinearFamily<TUnit>.Descriptor;

        internal static TUnit GetBaseUnit<TUnit>() where TUnit : struct
            => LinearFamily<TUnit>.BaseUnit;

        private static class LinearFamily<TUnit> where TUnit : struct
        {
            internal static readonly UnitConverterFamilyDescriptor<TUnit> Descriptor = CreateDescriptor();
            internal static readonly TUnit BaseUnit = FindBaseUnit();
            private static readonly Dictionary<TUnit, UnitConverterRational> Scales =
                new Dictionary<TUnit, UnitConverterRational>();
            private static readonly object Sync = new object();

            internal static UnitConverterRational GetScale(TUnit unit)
            {
                Descriptor.GetUnit(unit);
                if (EqualityComparer<TUnit>.Default.Equals(unit, BaseUnit))
                    return UnitConverterRational.One;

                lock (Sync)
                {
                    UnitConverterRational scale;
                    if (Scales.TryGetValue(unit, out scale))
                        return scale;

                    double zero = Descriptor.Convert(0d, unit, BaseUnit);
                    double one = Descriptor.Convert(1d, unit, BaseUnit);

                    if (double.IsNaN(zero) || double.IsInfinity(zero) || zero != 0d)
                    {
                        throw new NotSupportedException(
                            Descriptor.Name + " is not a linear-through-origin family and requires an explicit decimal transform.");
                    }

                    if (double.IsNaN(one) || double.IsInfinity(one) || one == 0d)
                    {
                        throw new NotSupportedException(
                            "A finite non-zero base scale could not be determined for " + Descriptor.Name + "." + unit + ".");
                    }

                    scale = UnitConverterRational.FromDouble(one);
                    Scales.Add(unit, scale);
                    return scale;
                }
            }

            private static UnitConverterFamilyDescriptor<TUnit> CreateDescriptor()
            {
                UnitConverterFamilyDescriptor<TUnit> descriptor;
                if (!UnitConverterCatalog.TryGetFamily(out descriptor))
                {
                    throw new NotSupportedException(
                        "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
                }

                return descriptor;
            }

            private static TUnit FindBaseUnit()
            {
                foreach (UnitConverterUnitDescriptor unit in Descriptor.Units)
                {
                    if (string.Equals(unit.Name, Descriptor.BaseUnitName, StringComparison.Ordinal))
                        return (TUnit)unit.Unit;
                }

                throw new InvalidOperationException(
                    "The base unit '" + Descriptor.BaseUnitName + "' is not registered for " + Descriptor.Name + ".");
            }
        }

        private readonly struct AffineTransform
        {
            internal AffineTransform(UnitConverterRational scale, UnitConverterRational offset)
            {
                Scale = scale;
                Offset = offset;
            }

            internal UnitConverterRational Scale { get; }
            internal UnitConverterRational Offset { get; }
        }

        private static class TemperatureDecimal
        {
            internal static decimal Convert(decimal value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
            {
                AffineTransform source = GetTransform(from);
                AffineTransform target = GetTransform(to);
                UnitConverterRational scale = source.Scale.Divide(target.Scale);
                UnitConverterRational offset = source.Offset.Subtract(target.Offset).Divide(target.Scale);
                return UnitConverterRational.FromDecimal(value)
                    .Multiply(scale)
                    .Add(offset)
                    .ToDecimal();
            }

            private static AffineTransform GetTransform(UnitConverterTemperatureUnit unit)
            {
                UnitConverterRational one = UnitConverterRational.One;
                UnitConverterRational zero = UnitConverterRational.Zero;
                UnitConverterRational kelvinOffset = UnitConverterRational.Parse("273.15");

                switch (unit)
                {
                    case UnitConverterTemperatureUnit.Kelvin:
                        return new AffineTransform(one, zero);
                    case UnitConverterTemperatureUnit.Celsius:
                        return new AffineTransform(one, kelvinOffset);
                    case UnitConverterTemperatureUnit.Fahrenheit:
                    {
                        UnitConverterRational scale = UnitConverterRational.FromInt64(5).Divide(UnitConverterRational.FromInt64(9));
                        UnitConverterRational offset = UnitConverterRational.Parse("459.67").Multiply(scale);
                        return new AffineTransform(scale, offset);
                    }
                    case UnitConverterTemperatureUnit.Rankine:
                        return new AffineTransform(
                            UnitConverterRational.FromInt64(5).Divide(UnitConverterRational.FromInt64(9)),
                            zero);
                    case UnitConverterTemperatureUnit.Delisle:
                        return new AffineTransform(
                            UnitConverterRational.FromInt64(-2).Divide(UnitConverterRational.FromInt64(3)),
                            UnitConverterRational.Parse("373.15"));
                    case UnitConverterTemperatureUnit.Newton:
                        return new AffineTransform(
                            UnitConverterRational.FromInt64(100).Divide(UnitConverterRational.FromInt64(33)),
                            kelvinOffset);
                    case UnitConverterTemperatureUnit.Reaumur:
                        return new AffineTransform(
                            UnitConverterRational.FromInt64(5).Divide(UnitConverterRational.FromInt64(4)),
                            kelvinOffset);
                    case UnitConverterTemperatureUnit.Romer:
                    {
                        UnitConverterRational scale = UnitConverterRational.FromInt64(40).Divide(UnitConverterRational.FromInt64(21));
                        UnitConverterRational offset = kelvinOffset.Subtract(UnitConverterRational.Parse("7.5").Multiply(scale));
                        return new AffineTransform(scale, offset);
                    }
                    case UnitConverterTemperatureUnit.Millikelvin:
                        return new AffineTransform(UnitConverterRational.Parse("0.001"), zero);
                    case UnitConverterTemperatureUnit.Microkelvin:
                        return new AffineTransform(UnitConverterRational.Parse("0.000001"), zero);
                    case UnitConverterTemperatureUnit.Nanokelvin:
                        return new AffineTransform(UnitConverterRational.Parse("0.000000001"), zero);
                    case UnitConverterTemperatureUnit.Kilokelvin:
                        return new AffineTransform(UnitConverterRational.FromInt64(1000), zero);
                    case UnitConverterTemperatureUnit.Megakelvin:
                        return new AffineTransform(UnitConverterRational.Parse("1000000"), zero);
                    case UnitConverterTemperatureUnit.Gigakelvin:
                        return new AffineTransform(UnitConverterRational.Parse("1000000000"), zero);
                    case UnitConverterTemperatureUnit.PlanckTemperature:
                        return new AffineTransform(UnitConverterRational.Parse("1.416784e32"), zero);
                    case UnitConverterTemperatureUnit.ElectronVoltTemperature:
                        return new AffineTransform(UnitConverterRational.Parse("11604.518121550082"), zero);
                    case UnitConverterTemperatureUnit.MillielectronVoltTemperature:
                        return new AffineTransform(UnitConverterRational.Parse("11.604518121550082"), zero);
                    case UnitConverterTemperatureUnit.KiloelectronVoltTemperature:
                        return new AffineTransform(UnitConverterRational.Parse("11604518.121550081"), zero);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported temperature unit.");
                }
            }
        }

        private static class SpecificGravityDecimal
        {
            private static readonly UnitConverterRational One = UnitConverterRational.One;
            private static readonly UnitConverterRational Hundred = UnitConverterRational.FromInt64(100);
            private static readonly UnitConverterRational Thousand = UnitConverterRational.FromInt64(1000);
            private static readonly UnitConverterRational Million = UnitConverterRational.Parse("1000000");
            private static readonly UnitConverterRational Billion = UnitConverterRational.Parse("1000000000");
            private static readonly UnitConverterRational Trillion = UnitConverterRational.Parse("1000000000000");
            private static readonly UnitConverterRational TenThousand = UnitConverterRational.Parse("10000");
            private static readonly UnitConverterRational ApiNumerator = UnitConverterRational.Parse("141.5");
            private static readonly UnitConverterRational ApiOffset = UnitConverterRational.Parse("131.5");
            private static readonly UnitConverterRational BaumeLightNumerator = UnitConverterRational.FromInt64(140);
            private static readonly UnitConverterRational BaumeLightOffset = UnitConverterRational.FromInt64(130);
            private static readonly UnitConverterRational BaumeHeavyConstant = UnitConverterRational.FromInt64(145);
            private static readonly UnitConverterRational TwaddellScale = UnitConverterRational.FromInt64(200);

            internal static decimal Convert(
                decimal value,
                UnitConverterSpecificGravityUnit from,
                UnitConverterSpecificGravityUnit to)
            {
                UnitConverterRational exactValue = UnitConverterRational.FromDecimal(value);
                UnitConverterRational ratio = ToRatio(exactValue, from);
                return FromRatio(ratio, to).ToDecimal();
            }

            private static UnitConverterRational ToRatio(
                UnitConverterRational value,
                UnitConverterSpecificGravityUnit unit)
            {
                switch (unit)
                {
                    case UnitConverterSpecificGravityUnit.Ratio:
                    case UnitConverterSpecificGravityUnit.SpecificGravity:
                    case UnitConverterSpecificGravityUnit.RelativeDensity:
                        return value;
                    case UnitConverterSpecificGravityUnit.Percent:
                        return value.Divide(Hundred);
                    case UnitConverterSpecificGravityUnit.PerMille:
                        return value.Divide(Thousand);
                    case UnitConverterSpecificGravityUnit.Ppm:
                        return value.Divide(Million);
                    case UnitConverterSpecificGravityUnit.Ppb:
                        return value.Divide(Billion);
                    case UnitConverterSpecificGravityUnit.Ppt:
                        return value.Divide(Trillion);
                    case UnitConverterSpecificGravityUnit.BasisPoint:
                    case UnitConverterSpecificGravityUnit.PerTenThousand:
                        return value.Divide(TenThousand);
                    case UnitConverterSpecificGravityUnit.APIGravity:
                        return ApiNumerator.Divide(value.Add(ApiOffset));
                    case UnitConverterSpecificGravityUnit.BaumeLight:
                        return BaumeLightNumerator.Divide(BaumeLightOffset.Add(value));
                    case UnitConverterSpecificGravityUnit.BaumeHeavy:
                        return BaumeHeavyConstant.Divide(BaumeHeavyConstant.Subtract(value));
                    case UnitConverterSpecificGravityUnit.Twaddell:
                        return One.Add(value.Divide(TwaddellScale));
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported specific gravity unit.");
                }
            }

            private static UnitConverterRational FromRatio(
                UnitConverterRational ratio,
                UnitConverterSpecificGravityUnit unit)
            {
                switch (unit)
                {
                    case UnitConverterSpecificGravityUnit.Ratio:
                    case UnitConverterSpecificGravityUnit.SpecificGravity:
                    case UnitConverterSpecificGravityUnit.RelativeDensity:
                        return ratio;
                    case UnitConverterSpecificGravityUnit.Percent:
                        return ratio.Multiply(Hundred);
                    case UnitConverterSpecificGravityUnit.PerMille:
                        return ratio.Multiply(Thousand);
                    case UnitConverterSpecificGravityUnit.Ppm:
                        return ratio.Multiply(Million);
                    case UnitConverterSpecificGravityUnit.Ppb:
                        return ratio.Multiply(Billion);
                    case UnitConverterSpecificGravityUnit.Ppt:
                        return ratio.Multiply(Trillion);
                    case UnitConverterSpecificGravityUnit.BasisPoint:
                    case UnitConverterSpecificGravityUnit.PerTenThousand:
                        return ratio.Multiply(TenThousand);
                    case UnitConverterSpecificGravityUnit.APIGravity:
                        return ApiNumerator.Divide(ratio).Subtract(ApiOffset);
                    case UnitConverterSpecificGravityUnit.BaumeLight:
                        return BaumeLightNumerator.Divide(ratio).Subtract(BaumeLightOffset);
                    case UnitConverterSpecificGravityUnit.BaumeHeavy:
                        return BaumeHeavyConstant.Subtract(BaumeHeavyConstant.Divide(ratio));
                    case UnitConverterSpecificGravityUnit.Twaddell:
                        return ratio.Subtract(One).Multiply(TwaddellScale);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported specific gravity unit.");
                }
            }
        }

        private readonly struct FuelTransform
        {
            internal FuelTransform(UnitConverterRational factor, bool reciprocal)
            {
                Factor = factor;
                Reciprocal = reciprocal;
            }

            internal UnitConverterRational Factor { get; }
            internal bool Reciprocal { get; }
        }

        private static class FuelEconomyDecimal
        {
            private static readonly UnitConverterRational Mile = UnitConverterRational.Parse("1.609344");
            private static readonly UnitConverterRational NauticalMile = UnitConverterRational.Parse("1.852");
            private static readonly UnitConverterRational UsGallon = UnitConverterRational.Parse("3.785411784");
            private static readonly UnitConverterRational ImperialGallon = UnitConverterRational.Parse("4.54609");

            internal static decimal Convert(decimal value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
            {
                FuelTransform source = GetTransform(from);
                FuelTransform target = GetTransform(to);

                if (!source.Reciprocal && !target.Reciprocal)
                    return source.Factor.Divide(target.Factor).Apply(value);

                if (source.Reciprocal && target.Reciprocal)
                    return target.Factor.Divide(source.Factor).Apply(value);

                UnitConverterRational reciprocalConstant = source.Reciprocal
                    ? source.Factor.Divide(target.Factor)
                    : target.Factor.Divide(source.Factor);

                return reciprocalConstant.DivideBy(value);
            }

            private static FuelTransform GetTransform(UnitConverterFuelEconomyUnit unit)
            {
                switch (unit)
                {
                    case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                        return Linear(UnitConverterRational.One);
                    case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                        return Reciprocal(UnitConverterRational.FromInt64(100));
                    case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                        return Linear(Mile.Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                        return Linear(Mile.Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                        return Reciprocal(UnitConverterRational.One);
                    case UnitConverterFuelEconomyUnit.LiterPerMile:
                        return Reciprocal(Mile);
                    case UnitConverterFuelEconomyUnit.USGallonPerMile:
                        return Reciprocal(Mile.Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                        return Reciprocal(Mile.Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.MilePerLiter:
                        return Linear(Mile);
                    case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                        return Linear(NauticalMile.Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.MeterPerLiter:
                        return Linear(UnitConverterRational.Parse("0.001"));
                    case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                        return Linear(UnitConverterRational.One.Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                        return Linear(UnitConverterRational.One.Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                        return Linear(NauticalMile.Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                        return Reciprocal(UnitConverterRational.FromInt64(1000));
                    case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                        return Reciprocal(UnitConverterRational.FromInt64(10));
                    case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                        return Reciprocal(UnitConverterRational.Parse("160.9344"));
                    case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                        return Reciprocal(UnitConverterRational.Parse("160.9344").Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                        return Reciprocal(UnitConverterRational.Parse("160.9344").Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                        return Reciprocal(UnitConverterRational.FromInt64(100).Divide(UsGallon));
                    case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                        return Reciprocal(UnitConverterRational.FromInt64(100).Divide(ImperialGallon));
                    case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                        return Linear(UnitConverterRational.FromInt64(1000));
                    case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                        return Linear(UnitConverterRational.One);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported fuel economy unit.");
                }
            }

            private static FuelTransform Linear(UnitConverterRational factor)
                => new FuelTransform(factor, false);

            private static FuelTransform Reciprocal(UnitConverterRational factor)
                => new FuelTransform(factor, true);
        }
    }
}
