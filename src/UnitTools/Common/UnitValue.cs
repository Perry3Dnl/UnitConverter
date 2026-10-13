namespace UnitTools
{
    using System;
    using System.Globalization;
    using UnitTools.Catalog;

    /// <summary>
    /// Optional value-plus-unit wrapper. Existing numeric converter APIs remain unchanged.
    /// </summary>
    public readonly struct UnitValue<TUnit> : IEquatable<UnitValue<TUnit>>, IFormattable
        where TUnit : struct
    {
        public UnitValue(double value, TUnit unit)
        {
            if (!typeof(TUnit).IsEnum)
            {
                throw new ArgumentException("TUnit must be a unit enum.", nameof(unit));
            }

            UnitToolsFamilyDescriptor<TUnit> descriptor;
            if (!UnitToolsCatalog.TryGetFamily(out descriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            if (!descriptor.TryGetUnit(unit, out _))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
            }

            Value = value;
            Unit = unit;
        }

        public double Value { get; }
        public TUnit Unit { get; }

        public UnitValue<TUnit> To(TUnit unit)
        {
            UnitToolsFamilyDescriptor<TUnit> descriptor;
            if (!UnitToolsCatalog.TryGetFamily(out descriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            if (!descriptor.TryGetUnit(unit, out _))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(unit),
                    unit,
                    "Unsupported unit.");
            }

            return new UnitValue<TUnit>(
                descriptor.Convert(Value, Unit, unit),
                unit);
        }

        public double As(TUnit unit)
        {
            return To(unit).Value;
        }

        public bool Equals(UnitValue<TUnit> other)
        {
            return Value.Equals(other.Value) &&
                System.Collections.Generic.EqualityComparer<TUnit>.Default.Equals(Unit, other.Unit);
        }

        public override bool Equals(object obj)
        {
            return obj is UnitValue<TUnit> && Equals((UnitValue<TUnit>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ Unit.GetHashCode();
            }
        }

        public static bool operator ==(UnitValue<TUnit> left, UnitValue<TUnit> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UnitValue<TUnit> left, UnitValue<TUnit> right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return UnitToolsFormatter.Format(Value, Unit);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return UnitToolsFormatter.Format(
                Value,
                Unit,
                format,
                formatProvider ?? CultureInfo.InvariantCulture,
                UnitToolsUnitFormat.Symbol);
        }
    }
}
