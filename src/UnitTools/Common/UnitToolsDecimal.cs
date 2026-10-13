namespace UnitTools
{
    using System;
    using System.Collections.Generic;
    using UnitTools.Catalog;
    using UnitTools.FuelEconomy;
    using UnitTools.SpecificGravity;
    using UnitTools.Temperature;

    /// <summary>
    /// Decimal-native conversion entry point. Decimal inputs never pass through double.
    /// Linear factors are represented as reduced rational numbers; affine and reciprocal
    /// families use explicit rational transforms.
    /// </summary>
    public static class UnitToolsExact
    {
        /// <summary>
        /// Converts a decimal value without routing through double precision.
        /// </summary>
        public static decimal Convert<TUnit>(decimal value, TUnit from, TUnit to)
            where TUnit : struct
        {
            return UnitToolsDecimal.Convert(value, from, to);
        }

        /// <summary>
        /// Attempts an exact decimal conversion and returns false for expected unit, range, or arithmetic failures.
        /// </summary>
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

    internal static class UnitToolsDecimal
    {
        internal static decimal Convert<TUnit>(decimal value, TUnit from, TUnit to)
            where TUnit : struct
        {
            if (!typeof(TUnit).IsEnum)
            {
                throw new ArgumentException(
                    typeof(TUnit).FullName + " is not a unit enum.");
            }

            UnitToolsFamilyDescriptor<TUnit> registeredDescriptor;
            if (!UnitToolsCatalog.TryGetFamily(out registeredDescriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " +
                    typeof(TUnit).FullName + ".");
            }

            if (typeof(TUnit) == typeof(UnitToolsTemperatureUnit))
            {
                return TemperatureDecimal.Convert(
                    value,
                    (UnitToolsTemperatureUnit)(object)from,
                    (UnitToolsTemperatureUnit)(object)to);
            }

            if (typeof(TUnit) == typeof(UnitToolsFuelEconomyUnit))
            {
                return FuelEconomyDecimal.Convert(
                    value,
                    (UnitToolsFuelEconomyUnit)(object)from,
                    (UnitToolsFuelEconomyUnit)(object)to);
            }

            if (typeof(TUnit) == typeof(UnitToolsSpecificGravityUnit))
            {
                return SpecificGravityDecimal.Convert(
                    value,
                    (UnitToolsSpecificGravityUnit)(object)from,
                    (UnitToolsSpecificGravityUnit)(object)to);
            }

            UnitToolsRational fromScale = LinearFamily<TUnit>.GetScale(from);
            if (EqualityComparer<TUnit>.Default.Equals(from, to))
                return value;

            UnitToolsRational toScale = LinearFamily<TUnit>.GetScale(to);
            if (toScale.IsOne)
                return fromScale.Apply(value);
            if (fromScale.IsOne)
                return toScale.ApplyInverse(value);

            return fromScale.Divide(toScale).Apply(value);
        }

        internal static UnitToolsFamilyDescriptor<TUnit> GetDescriptor<TUnit>()
            where TUnit : struct
            => LinearFamily<TUnit>.Descriptor;

        internal static TUnit GetBaseUnit<TUnit>() where TUnit : struct
            => LinearFamily<TUnit>.BaseUnit;

        private static class LinearFamily<TUnit> where TUnit : struct
        {
            internal static readonly UnitToolsFamilyDescriptor<TUnit> Descriptor = CreateDescriptor();
            internal static readonly TUnit BaseUnit = FindBaseUnit();
            private static readonly Dictionary<TUnit, UnitToolsRational> Scales =
                new Dictionary<TUnit, UnitToolsRational>();
            private static readonly object Sync = new object();

            internal static UnitToolsRational GetScale(TUnit unit)
            {
                Descriptor.GetUnit(unit);
                if (EqualityComparer<TUnit>.Default.Equals(unit, BaseUnit))
                    return UnitToolsRational.One;

                lock (Sync)
                {
                    UnitToolsRational scale;
                    if (Scales.TryGetValue(unit, out scale))
                        return scale;

                    if (Descriptor.TryGetExactScale(unit, out scale))
                    {
                        Scales.Add(unit, scale);
                        return scale;
                    }

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

                    scale = UnitToolsRational.FromDouble(one);
                    Scales.Add(unit, scale);
                    return scale;
                }
            }

            private static UnitToolsFamilyDescriptor<TUnit> CreateDescriptor()
            {
                UnitToolsFamilyDescriptor<TUnit> descriptor;
                if (!UnitToolsCatalog.TryGetFamily(out descriptor))
                {
                    throw new NotSupportedException(
                        "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
                }

                return descriptor;
            }

            private static TUnit FindBaseUnit()
            {
                foreach (UnitToolsUnitDescriptor unit in Descriptor.Units)
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
            internal AffineTransform(UnitToolsRational scale, UnitToolsRational offset)
            {
                Scale = scale;
                Offset = offset;
            }

            internal UnitToolsRational Scale { get; }
            internal UnitToolsRational Offset { get; }
        }

        private static class TemperatureDecimal
        {
            internal static decimal Convert(decimal value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
            {
                AffineTransform source = GetTransform(from);
                AffineTransform target = GetTransform(to);
                UnitToolsRational scale = source.Scale.Divide(target.Scale);
                UnitToolsRational offset = source.Offset.Subtract(target.Offset).Divide(target.Scale);
                return UnitToolsRational.FromDecimal(value)
                    .Multiply(scale)
                    .Add(offset)
                    .ToDecimal();
            }

            private static AffineTransform GetTransform(UnitToolsTemperatureUnit unit)
            {
                UnitToolsRational one = UnitToolsRational.One;
                UnitToolsRational zero = UnitToolsRational.Zero;
                UnitToolsRational kelvinOffset = UnitToolsRational.Parse("273.15");

                switch (unit)
                {
                    case UnitToolsTemperatureUnit.Kelvin:
                        return new AffineTransform(one, zero);
                    case UnitToolsTemperatureUnit.Celsius:
                        return new AffineTransform(one, kelvinOffset);
                    case UnitToolsTemperatureUnit.Fahrenheit:
                    {
                        UnitToolsRational scale = UnitToolsRational.FromInt64(5).Divide(UnitToolsRational.FromInt64(9));
                        UnitToolsRational offset = UnitToolsRational.Parse("459.67").Multiply(scale);
                        return new AffineTransform(scale, offset);
                    }
                    case UnitToolsTemperatureUnit.Rankine:
                        return new AffineTransform(
                            UnitToolsRational.FromInt64(5).Divide(UnitToolsRational.FromInt64(9)),
                            zero);
                    case UnitToolsTemperatureUnit.Delisle:
                        return new AffineTransform(
                            UnitToolsRational.FromInt64(-2).Divide(UnitToolsRational.FromInt64(3)),
                            UnitToolsRational.Parse("373.15"));
                    case UnitToolsTemperatureUnit.Newton:
                        return new AffineTransform(
                            UnitToolsRational.FromInt64(100).Divide(UnitToolsRational.FromInt64(33)),
                            kelvinOffset);
                    case UnitToolsTemperatureUnit.Reaumur:
                        return new AffineTransform(
                            UnitToolsRational.FromInt64(5).Divide(UnitToolsRational.FromInt64(4)),
                            kelvinOffset);
                    case UnitToolsTemperatureUnit.Romer:
                    {
                        UnitToolsRational scale = UnitToolsRational.FromInt64(40).Divide(UnitToolsRational.FromInt64(21));
                        UnitToolsRational offset = kelvinOffset.Subtract(UnitToolsRational.Parse("7.5").Multiply(scale));
                        return new AffineTransform(scale, offset);
                    }
                    case UnitToolsTemperatureUnit.Millikelvin:
                        return new AffineTransform(UnitToolsRational.Parse("0.001"), zero);
                    case UnitToolsTemperatureUnit.Microkelvin:
                        return new AffineTransform(UnitToolsRational.Parse("0.000001"), zero);
                    case UnitToolsTemperatureUnit.Nanokelvin:
                        return new AffineTransform(UnitToolsRational.Parse("0.000000001"), zero);
                    case UnitToolsTemperatureUnit.Kilokelvin:
                        return new AffineTransform(UnitToolsRational.FromInt64(1000), zero);
                    case UnitToolsTemperatureUnit.Megakelvin:
                        return new AffineTransform(UnitToolsRational.Parse("1000000"), zero);
                    case UnitToolsTemperatureUnit.Gigakelvin:
                        return new AffineTransform(UnitToolsRational.Parse("1000000000"), zero);
                    case UnitToolsTemperatureUnit.PlanckTemperature:
                        return new AffineTransform(UnitToolsRational.Parse("1.416784e32"), zero);
                    case UnitToolsTemperatureUnit.ElectronVoltTemperature:
                        return new AffineTransform(UnitToolsRational.Parse("11604.518121550082"), zero);
                    case UnitToolsTemperatureUnit.MillielectronVoltTemperature:
                        return new AffineTransform(UnitToolsRational.Parse("11.604518121550082"), zero);
                    case UnitToolsTemperatureUnit.KiloelectronVoltTemperature:
                        return new AffineTransform(UnitToolsRational.Parse("11604518.121550081"), zero);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported temperature unit.");
                }
            }
        }

        private static class SpecificGravityDecimal
        {
            private static readonly UnitToolsRational One = UnitToolsRational.One;
            private static readonly UnitToolsRational Hundred = UnitToolsRational.FromInt64(100);
            private static readonly UnitToolsRational Thousand = UnitToolsRational.FromInt64(1000);
            private static readonly UnitToolsRational Million = UnitToolsRational.Parse("1000000");
            private static readonly UnitToolsRational Billion = UnitToolsRational.Parse("1000000000");
            private static readonly UnitToolsRational Trillion = UnitToolsRational.Parse("1000000000000");
            private static readonly UnitToolsRational TenThousand = UnitToolsRational.Parse("10000");
            private static readonly UnitToolsRational ApiNumerator = UnitToolsRational.Parse("141.5");
            private static readonly UnitToolsRational ApiOffset = UnitToolsRational.Parse("131.5");
            private static readonly UnitToolsRational BaumeLightNumerator = UnitToolsRational.FromInt64(140);
            private static readonly UnitToolsRational BaumeLightOffset = UnitToolsRational.FromInt64(130);
            private static readonly UnitToolsRational BaumeHeavyConstant = UnitToolsRational.FromInt64(145);
            private static readonly UnitToolsRational TwaddellScale = UnitToolsRational.FromInt64(200);

            internal static decimal Convert(
                decimal value,
                UnitToolsSpecificGravityUnit from,
                UnitToolsSpecificGravityUnit to)
            {
                UnitToolsRational exactValue = UnitToolsRational.FromDecimal(value);
                UnitToolsRational ratio = ToRatio(exactValue, from);
                return FromRatio(ratio, to).ToDecimal();
            }

            private static UnitToolsRational ToRatio(
                UnitToolsRational value,
                UnitToolsSpecificGravityUnit unit)
            {
                switch (unit)
                {
                    case UnitToolsSpecificGravityUnit.Ratio:
                    case UnitToolsSpecificGravityUnit.SpecificGravity:
                    case UnitToolsSpecificGravityUnit.RelativeDensity:
                        return value;
                    case UnitToolsSpecificGravityUnit.Percent:
                        return value.Divide(Hundred);
                    case UnitToolsSpecificGravityUnit.PerMille:
                        return value.Divide(Thousand);
                    case UnitToolsSpecificGravityUnit.Ppm:
                        return value.Divide(Million);
                    case UnitToolsSpecificGravityUnit.Ppb:
                        return value.Divide(Billion);
                    case UnitToolsSpecificGravityUnit.Ppt:
                        return value.Divide(Trillion);
                    case UnitToolsSpecificGravityUnit.BasisPoint:
                    case UnitToolsSpecificGravityUnit.PerTenThousand:
                        return value.Divide(TenThousand);
                    case UnitToolsSpecificGravityUnit.APIGravity:
                        return ApiNumerator.Divide(value.Add(ApiOffset));
                    case UnitToolsSpecificGravityUnit.BaumeLight:
                        return BaumeLightNumerator.Divide(BaumeLightOffset.Add(value));
                    case UnitToolsSpecificGravityUnit.BaumeHeavy:
                        return BaumeHeavyConstant.Divide(BaumeHeavyConstant.Subtract(value));
                    case UnitToolsSpecificGravityUnit.Twaddell:
                        return One.Add(value.Divide(TwaddellScale));
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported specific gravity unit.");
                }
            }

            private static UnitToolsRational FromRatio(
                UnitToolsRational ratio,
                UnitToolsSpecificGravityUnit unit)
            {
                switch (unit)
                {
                    case UnitToolsSpecificGravityUnit.Ratio:
                    case UnitToolsSpecificGravityUnit.SpecificGravity:
                    case UnitToolsSpecificGravityUnit.RelativeDensity:
                        return ratio;
                    case UnitToolsSpecificGravityUnit.Percent:
                        return ratio.Multiply(Hundred);
                    case UnitToolsSpecificGravityUnit.PerMille:
                        return ratio.Multiply(Thousand);
                    case UnitToolsSpecificGravityUnit.Ppm:
                        return ratio.Multiply(Million);
                    case UnitToolsSpecificGravityUnit.Ppb:
                        return ratio.Multiply(Billion);
                    case UnitToolsSpecificGravityUnit.Ppt:
                        return ratio.Multiply(Trillion);
                    case UnitToolsSpecificGravityUnit.BasisPoint:
                    case UnitToolsSpecificGravityUnit.PerTenThousand:
                        return ratio.Multiply(TenThousand);
                    case UnitToolsSpecificGravityUnit.APIGravity:
                        return ApiNumerator.Divide(ratio).Subtract(ApiOffset);
                    case UnitToolsSpecificGravityUnit.BaumeLight:
                        return BaumeLightNumerator.Divide(ratio).Subtract(BaumeLightOffset);
                    case UnitToolsSpecificGravityUnit.BaumeHeavy:
                        return BaumeHeavyConstant.Subtract(BaumeHeavyConstant.Divide(ratio));
                    case UnitToolsSpecificGravityUnit.Twaddell:
                        return ratio.Subtract(One).Multiply(TwaddellScale);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported specific gravity unit.");
                }
            }
        }

        private readonly struct FuelTransform
        {
            internal FuelTransform(UnitToolsRational factor, bool reciprocal)
            {
                Factor = factor;
                Reciprocal = reciprocal;
            }

            internal UnitToolsRational Factor { get; }
            internal bool Reciprocal { get; }
        }

        private static class FuelEconomyDecimal
        {
            private static readonly UnitToolsRational Mile = UnitToolsRational.Parse("1.609344");
            private static readonly UnitToolsRational NauticalMile = UnitToolsRational.Parse("1.852");
            private static readonly UnitToolsRational UsGallon = UnitToolsRational.Parse("3.785411784");
            private static readonly UnitToolsRational ImperialGallon = UnitToolsRational.Parse("4.54609");

            internal static decimal Convert(decimal value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
            {
                FuelTransform source = GetTransform(from);
                FuelTransform target = GetTransform(to);

                if (!source.Reciprocal && !target.Reciprocal)
                    return source.Factor.Divide(target.Factor).Apply(value);

                if (source.Reciprocal && target.Reciprocal)
                    return target.Factor.Divide(source.Factor).Apply(value);

                UnitToolsRational reciprocalConstant = source.Reciprocal
                    ? source.Factor.Divide(target.Factor)
                    : target.Factor.Divide(source.Factor);

                return reciprocalConstant.DivideBy(value);
            }

            private static FuelTransform GetTransform(UnitToolsFuelEconomyUnit unit)
            {
                switch (unit)
                {
                    case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                        return Linear(UnitToolsRational.One);
                    case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                        return Reciprocal(UnitToolsRational.FromInt64(100));
                    case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                        return Linear(Mile.Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                        return Linear(Mile.Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                        return Reciprocal(UnitToolsRational.One);
                    case UnitToolsFuelEconomyUnit.LiterPerMile:
                        return Reciprocal(Mile);
                    case UnitToolsFuelEconomyUnit.USGallonPerMile:
                        return Reciprocal(Mile.Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                        return Reciprocal(Mile.Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.MilePerLiter:
                        return Linear(Mile);
                    case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                        return Linear(NauticalMile.Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.MeterPerLiter:
                        return Linear(UnitToolsRational.Parse("0.001"));
                    case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                        return Linear(UnitToolsRational.One.Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                        return Linear(UnitToolsRational.One.Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                        return Linear(NauticalMile.Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                        return Reciprocal(UnitToolsRational.FromInt64(1000));
                    case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                        return Reciprocal(UnitToolsRational.FromInt64(10));
                    case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                        return Reciprocal(UnitToolsRational.Parse("160.9344"));
                    case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                        return Reciprocal(UnitToolsRational.Parse("160.9344").Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                        return Reciprocal(UnitToolsRational.Parse("160.9344").Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                        return Reciprocal(UnitToolsRational.FromInt64(100).Divide(UsGallon));
                    case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                        return Reciprocal(UnitToolsRational.FromInt64(100).Divide(ImperialGallon));
                    case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                        return Linear(UnitToolsRational.FromInt64(1000));
                    case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                        return Linear(UnitToolsRational.One);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported fuel economy unit.");
                }
            }

            private static FuelTransform Linear(UnitToolsRational factor)
                => new FuelTransform(factor, false);

            private static FuelTransform Reciprocal(UnitToolsRational factor)
                => new FuelTransform(factor, true);
        }
    }
}
