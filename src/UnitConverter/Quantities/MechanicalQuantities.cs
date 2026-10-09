#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitConverter.Quantities
{
    public readonly partial struct Energy<T> :
        IEquatable<Energy<T>>,
        IComparable<Energy<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _joules;

        private Energy(T joules) => _joules = joules;

        public T Joules => _joules;
        public T Kilojoules => _joules / T.CreateChecked(1000);

        public static Energy<T> FromJoules(T value) => new Energy<T>(value);
        public static Energy<T> FromKilojoules(T value) => new Energy<T>(value * T.CreateChecked(1000));

        public static Energy<T> operator +(Energy<T> left, Energy<T> right) => FromJoules(left._joules + right._joules);
        public static Energy<T> operator -(Energy<T> left, Energy<T> right) => FromJoules(left._joules - right._joules);
        public static Energy<T> operator *(Energy<T> quantity, T scalar) => FromJoules(quantity._joules * scalar);
        public static Energy<T> operator /(Energy<T> quantity, T scalar) => FromJoules(quantity._joules / scalar);
        public static Power<T> operator /(Energy<T> energy, Time<T> time)
            => Power<T>.FromWatts(energy._joules / time.Seconds);
        public static Time<T> operator /(Energy<T> energy, Power<T> power)
            => Time<T>.FromSeconds(energy._joules / power.Watts);
        public static Force<T> operator /(Energy<T> energy, Length<T> length)
            => Force<T>.FromNewtons(energy._joules / length.Metres);
        public static Length<T> operator /(Energy<T> energy, Force<T> force)
            => Length<T>.FromMetres(energy._joules / force.Newtons);

        public static bool operator ==(Energy<T> left, Energy<T> right) => left.Equals(right);
        public static bool operator !=(Energy<T> left, Energy<T> right) => !left.Equals(right);
        public static bool operator <(Energy<T> left, Energy<T> right) => left._joules < right._joules;
        public static bool operator >(Energy<T> left, Energy<T> right) => left._joules > right._joules;
        public static bool operator <=(Energy<T> left, Energy<T> right) => left._joules <= right._joules;
        public static bool operator >=(Energy<T> left, Energy<T> right) => left._joules >= right._joules;

        public bool Equals(Energy<T> other) => _joules == other._joules;
        public override bool Equals(object obj) => obj is Energy<T> other && Equals(other);
        public override int GetHashCode() => _joules.GetHashCode();
        public int CompareTo(Energy<T> other) => _joules.CompareTo(other._joules);
        public override string ToString() => _joules.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _joules.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _joules.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Power<T> :
        IEquatable<Power<T>>,
        IComparable<Power<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _watts;

        private Power(T watts) => _watts = watts;

        public T Watts => _watts;
        public T Kilowatts => _watts / T.CreateChecked(1000);

        public static Power<T> FromWatts(T value) => new Power<T>(value);
        public static Power<T> FromKilowatts(T value) => new Power<T>(value * T.CreateChecked(1000));

        public static Power<T> operator +(Power<T> left, Power<T> right) => FromWatts(left._watts + right._watts);
        public static Power<T> operator -(Power<T> left, Power<T> right) => FromWatts(left._watts - right._watts);
        public static Power<T> operator *(Power<T> quantity, T scalar) => FromWatts(quantity._watts * scalar);
        public static Power<T> operator /(Power<T> quantity, T scalar) => FromWatts(quantity._watts / scalar);
        public static Energy<T> operator *(Power<T> power, Time<T> time)
            => Energy<T>.FromJoules(power._watts * time.Seconds);

        public static bool operator ==(Power<T> left, Power<T> right) => left.Equals(right);
        public static bool operator !=(Power<T> left, Power<T> right) => !left.Equals(right);
        public static bool operator <(Power<T> left, Power<T> right) => left._watts < right._watts;
        public static bool operator >(Power<T> left, Power<T> right) => left._watts > right._watts;
        public static bool operator <=(Power<T> left, Power<T> right) => left._watts <= right._watts;
        public static bool operator >=(Power<T> left, Power<T> right) => left._watts >= right._watts;

        public bool Equals(Power<T> other) => _watts == other._watts;
        public override bool Equals(object obj) => obj is Power<T> other && Equals(other);
        public override int GetHashCode() => _watts.GetHashCode();
        public int CompareTo(Power<T> other) => _watts.CompareTo(other._watts);
        public override string ToString() => _watts.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _watts.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _watts.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Pressure<T> :
        IEquatable<Pressure<T>>,
        IComparable<Pressure<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _pascals;

        private Pressure(T pascals) => _pascals = pascals;

        public T Pascals => _pascals;
        public T Kilopascals => _pascals / T.CreateChecked(1000);
        public T Megapascals => _pascals / T.CreateChecked(1_000_000);
        public T Bars => _pascals / T.CreateChecked(100_000);

        public static Pressure<T> FromPascals(T value) => new Pressure<T>(value);
        public static Pressure<T> FromKilopascals(T value) => new Pressure<T>(value * T.CreateChecked(1000));
        public static Pressure<T> FromMegapascals(T value) => new Pressure<T>(value * T.CreateChecked(1_000_000));
        public static Pressure<T> FromBars(T value) => new Pressure<T>(value * T.CreateChecked(100_000));

        public static Pressure<T> operator +(Pressure<T> left, Pressure<T> right) => FromPascals(left._pascals + right._pascals);
        public static Pressure<T> operator -(Pressure<T> left, Pressure<T> right) => FromPascals(left._pascals - right._pascals);
        public static Pressure<T> operator *(Pressure<T> quantity, T scalar) => FromPascals(quantity._pascals * scalar);
        public static Pressure<T> operator /(Pressure<T> quantity, T scalar) => FromPascals(quantity._pascals / scalar);
        public static Force<T> operator *(Pressure<T> pressure, Area<T> area)
            => Force<T>.FromNewtons(pressure._pascals * area.SquareMetres);
        public static Force<T> operator *(Area<T> area, Pressure<T> pressure)
            => Force<T>.FromNewtons(area.SquareMetres * pressure._pascals);

        public static bool operator ==(Pressure<T> left, Pressure<T> right) => left.Equals(right);
        public static bool operator !=(Pressure<T> left, Pressure<T> right) => !left.Equals(right);
        public static bool operator <(Pressure<T> left, Pressure<T> right) => left._pascals < right._pascals;
        public static bool operator >(Pressure<T> left, Pressure<T> right) => left._pascals > right._pascals;
        public static bool operator <=(Pressure<T> left, Pressure<T> right) => left._pascals <= right._pascals;
        public static bool operator >=(Pressure<T> left, Pressure<T> right) => left._pascals >= right._pascals;

        public bool Equals(Pressure<T> other) => _pascals == other._pascals;
        public override bool Equals(object obj) => obj is Pressure<T> other && Equals(other);
        public override int GetHashCode() => _pascals.GetHashCode();
        public int CompareTo(Pressure<T> other) => _pascals.CompareTo(other._pascals);
        public override string ToString() => _pascals.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _pascals.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _pascals.TryFormat(destination, out charsWritten, format, provider);
    }
}
#endif