namespace UnitConverter.Quantities
{
    using System;
    using UnitConverter.Catalog;

    /// <summary>
    /// Decimal-native, family-typed quantity wrapper available for every registered unit enum.
    /// The unit enum is part of the CLR type, so quantities from different families cannot be
    /// mixed by the arithmetic operators.
    /// </summary>
    public readonly struct ExactQuantity<TUnit> :
        IEquatable<ExactQuantity<TUnit>>,
        IComparable<ExactQuantity<TUnit>>
        where TUnit : struct
    {
        private readonly decimal _baseValue;

        private ExactQuantity(decimal baseValue)
        {
            _baseValue = baseValue;
        }

        public decimal BaseValue => _baseValue;

        public static ExactQuantity<TUnit> From(decimal value, TUnit unit)
        {
            TUnit baseUnit = UnitConverterDecimal.GetBaseUnit<TUnit>();
            return new ExactQuantity<TUnit>(UnitConverterExact.Convert(value, unit, baseUnit));
        }

        public decimal In(TUnit unit)
        {
            TUnit baseUnit = UnitConverterDecimal.GetBaseUnit<TUnit>();
            return UnitConverterExact.Convert(_baseValue, baseUnit, unit);
        }

        public static ExactQuantity<TUnit> operator +(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
        {
            EnsureUniformDimensions();
            return new ExactQuantity<TUnit>(left._baseValue + right._baseValue);
        }

        public static ExactQuantity<TUnit> operator -(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
        {
            EnsureUniformDimensions();
            return new ExactQuantity<TUnit>(left._baseValue - right._baseValue);
        }

        public static ExactQuantity<TUnit> operator -(ExactQuantity<TUnit> value)
        {
            EnsureUniformDimensions();
            return new ExactQuantity<TUnit>(-value._baseValue);
        }

        public static ExactQuantity<TUnit> operator *(ExactQuantity<TUnit> quantity, decimal scalar)
        {
            EnsureUniformDimensions();
            return new ExactQuantity<TUnit>(quantity._baseValue * scalar);
        }

        public static ExactQuantity<TUnit> operator *(decimal scalar, ExactQuantity<TUnit> quantity)
            => quantity * scalar;

        public static ExactQuantity<TUnit> operator /(ExactQuantity<TUnit> quantity, decimal scalar)
        {
            EnsureUniformDimensions();
            return new ExactQuantity<TUnit>(quantity._baseValue / scalar);
        }

        public static decimal operator /(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
        {
            EnsureUniformDimensions();
            return left._baseValue / right._baseValue;
        }

        public static bool operator ==(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => left.Equals(right);

        public static bool operator !=(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => !left.Equals(right);

        public static bool operator <(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => left._baseValue < right._baseValue;

        public static bool operator >(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => left._baseValue > right._baseValue;

        public static bool operator <=(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => left._baseValue <= right._baseValue;

        public static bool operator >=(ExactQuantity<TUnit> left, ExactQuantity<TUnit> right)
            => left._baseValue >= right._baseValue;

        public bool Equals(ExactQuantity<TUnit> other)
            => _baseValue == other._baseValue;

        public override bool Equals(object obj)
            => obj is ExactQuantity<TUnit> other && Equals(other);

        public override int GetHashCode()
            => _baseValue.GetHashCode();

        public int CompareTo(ExactQuantity<TUnit> other)
            => _baseValue.CompareTo(other._baseValue);

        public override string ToString()
            => _baseValue.ToString();

        private static void EnsureUniformDimensions()
        {
            UnitConverterFamilyDescriptor<TUnit> descriptor = UnitConverterDecimal.GetDescriptor<TUnit>();
            if (!descriptor.HasUniformDimensions)
            {
                throw new InvalidOperationException(
                    "Arithmetic is not available on ExactQuantity<" + typeof(TUnit).Name +
                    "> because that unit enum contains multiple physical dimensions. Convert the value explicitly instead.");
            }
        }
    }

    public static class ExactQuantity
    {
        public static ExactQuantity<TUnit> From<TUnit>(decimal value, TUnit unit)
            where TUnit : struct
            => ExactQuantity<TUnit>.From(value, unit);
    }
}
