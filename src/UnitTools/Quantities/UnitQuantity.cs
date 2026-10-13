#if NET8_0_OR_GREATER
namespace UnitTools.Quantities
{
    using System;
    using System.Numerics;
    using UnitTools.Catalog;

    /// <summary>
    /// Universal strongly typed quantity wrapper for every unit family whose units share
    /// one physical dimension. The unit enum is part of the CLR type, so values from
    /// unrelated families cannot be added, subtracted, compared, or divided by accident.
    /// </summary>
    public readonly struct UnitQuantity<T, TUnit> :
        IEquatable<UnitQuantity<T, TUnit>>,
        IComparable<UnitQuantity<T, TUnit>>,
        IFormattable
        where T : IFloatingPoint<T>
        where TUnit : struct
    {
        private static readonly UnitToolsFamilyDescriptor<TUnit> Descriptor =
            global::UnitTools.UnitToolsDecimal.GetDescriptor<TUnit>();
        private static readonly TUnit BaseUnit =
            global::UnitTools.UnitToolsDecimal.GetBaseUnit<TUnit>();

        private readonly T _baseValue;

        private UnitQuantity(T baseValue, TUnit unit)
        {
            _baseValue = baseValue;
            Unit = unit;
        }

        public TUnit Unit { get; }
        public UnitToolsFamily Family => Descriptor.Family;
        public UnitToolsDimensions Dimensions => Descriptor.Dimensions;
        public T Value => As(Unit);

        public static UnitQuantity<T, TUnit> From(T value, TUnit unit)
        {
            EnsureUniformFamily();
            Descriptor.GetUnit(unit);
            return new UnitQuantity<T, TUnit>(
                UnitToolsNumeric.Convert(value, unit, BaseUnit),
                unit);
        }

        public T As(TUnit unit)
        {
            Descriptor.GetUnit(unit);
            return UnitToolsNumeric.Convert(_baseValue, BaseUnit, unit);
        }

        public UnitQuantity<T, TUnit> To(TUnit unit)
        {
            Descriptor.GetUnit(unit);
            return new UnitQuantity<T, TUnit>(_baseValue, unit);
        }

        public static UnitQuantity<T, TUnit> operator +(
            UnitQuantity<T, TUnit> left,
            UnitQuantity<T, TUnit> right)
            => new UnitQuantity<T, TUnit>(left._baseValue + right._baseValue, left.Unit);

        public static UnitQuantity<T, TUnit> operator -(
            UnitQuantity<T, TUnit> left,
            UnitQuantity<T, TUnit> right)
            => new UnitQuantity<T, TUnit>(left._baseValue - right._baseValue, left.Unit);

        public static UnitQuantity<T, TUnit> operator -(UnitQuantity<T, TUnit> value)
            => new UnitQuantity<T, TUnit>(-value._baseValue, value.Unit);

        public static UnitQuantity<T, TUnit> operator *(
            UnitQuantity<T, TUnit> quantity,
            T scalar)
            => new UnitQuantity<T, TUnit>(quantity._baseValue * scalar, quantity.Unit);

        public static UnitQuantity<T, TUnit> operator *(
            T scalar,
            UnitQuantity<T, TUnit> quantity)
            => quantity * scalar;

        public static UnitQuantity<T, TUnit> operator /(
            UnitQuantity<T, TUnit> quantity,
            T scalar)
            => new UnitQuantity<T, TUnit>(quantity._baseValue / scalar, quantity.Unit);

        public static T operator /(
            UnitQuantity<T, TUnit> left,
            UnitQuantity<T, TUnit> right)
            => left._baseValue / right._baseValue;

        public static bool operator ==(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => left.Equals(right);

        public static bool operator !=(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => !left.Equals(right);

        public static bool operator <(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => left._baseValue < right._baseValue;

        public static bool operator >(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => left._baseValue > right._baseValue;

        public static bool operator <=(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => left._baseValue <= right._baseValue;

        public static bool operator >=(UnitQuantity<T, TUnit> left, UnitQuantity<T, TUnit> right)
            => left._baseValue >= right._baseValue;

        public bool Equals(UnitQuantity<T, TUnit> other) => _baseValue == other._baseValue;
        public override bool Equals(object obj) => obj is UnitQuantity<T, TUnit> other && Equals(other);
        public override int GetHashCode() => _baseValue.GetHashCode();
        public int CompareTo(UnitQuantity<T, TUnit> other) => _baseValue.CompareTo(other._baseValue);

        public override string ToString()
            => ToString(null, null);

        public string ToString(string format, IFormatProvider formatProvider)
        {
            T value = Value;
            string symbol = Descriptor.GetUnit(Unit).Symbol;
            return value.ToString(format, formatProvider) + " " + symbol;
        }

        private static void EnsureUniformFamily()
        {
            if (!Descriptor.HasUniformDimensions)
            {
                throw new NotSupportedException(
                    Descriptor.Name + " contains units with different physical dimensions. " +
                    "Use the dedicated dimension-safe quantity types for that family.");
            }
        }
    }

    public static class UnitQuantity
    {
        public static UnitQuantity<T, TUnit> From<T, TUnit>(T value, TUnit unit)
            where T : IFloatingPoint<T>
            where TUnit : struct
            => UnitQuantity<T, TUnit>.From(value, unit);
    }

    public static class UnitQuantityExtensions
    {
        public static UnitQuantity<T, TUnit> AsQuantity<T, TUnit>(this T value, TUnit unit)
            where T : IFloatingPoint<T>
            where TUnit : struct
            => UnitQuantity<T, TUnit>.From(value, unit);
    }

    internal static class UnitToolsNumeric
    {
        internal static T Convert<T, TUnit>(T value, TUnit from, TUnit to)
            where T : IFloatingPoint<T>
            where TUnit : struct
        {
            if (typeof(T) == typeof(decimal))
            {
                decimal converted = global::UnitTools.UnitToolsExact.Convert(
                    (decimal)(object)value,
                    from,
                    to);
                return (T)(object)converted;
            }

            UnitToolsFamilyDescriptor<TUnit> descriptor =
                global::UnitTools.UnitToolsDecimal.GetDescriptor<TUnit>();
            double input = double.CreateChecked(value);
            double result = descriptor.Convert(input, from, to);
            return T.CreateChecked(result);
        }
    }
}
#endif
