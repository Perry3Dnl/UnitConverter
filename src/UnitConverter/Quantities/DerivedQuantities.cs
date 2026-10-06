#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitConverter.Quantities
{
    public readonly partial struct Mass<T> :
        IEquatable<Mass<T>>,
        IComparable<Mass<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _kilograms;

        private Mass(T kilograms) => _kilograms = kilograms;

        public T Kilograms => _kilograms;
        public T Grams => _kilograms * T.CreateChecked(1000);
        public T Milligrams => _kilograms * T.CreateChecked(1_000_000);

        public static Mass<T> FromKilograms(T value) => new Mass<T>(value);
        public static Mass<T> FromGrams(T value) => new Mass<T>(value / T.CreateChecked(1000));
        public static Mass<T> FromMilligrams(T value) => new Mass<T>(value / T.CreateChecked(1_000_000));

        public static Mass<T> operator +(Mass<T> left, Mass<T> right) => FromKilograms(left._kilograms + right._kilograms);
        public static Mass<T> operator -(Mass<T> left, Mass<T> right) => FromKilograms(left._kilograms - right._kilograms);
        public static Mass<T> operator *(Mass<T> quantity, T scalar) => FromKilograms(quantity._kilograms * scalar);
        public static Mass<T> operator /(Mass<T> quantity, T scalar) => FromKilograms(quantity._kilograms / scalar);
        public static Force<T> operator *(Mass<T> mass, Acceleration<T> acceleration)
            => Force<T>.FromNewtons(mass._kilograms * acceleration.MetresPerSecondSquared);
        public static Density<T> operator /(Mass<T> mass, Volume<T> volume)
            => Density<T>.FromKilogramsPerCubicMetre(mass._kilograms / volume.CubicMetres);

        public static bool operator ==(Mass<T> left, Mass<T> right) => left.Equals(right);
        public static bool operator !=(Mass<T> left, Mass<T> right) => !left.Equals(right);
        public static bool operator <(Mass<T> left, Mass<T> right) => left._kilograms < right._kilograms;
        public static bool operator >(Mass<T> left, Mass<T> right) => left._kilograms > right._kilograms;
        public static bool operator <=(Mass<T> left, Mass<T> right) => left._kilograms <= right._kilograms;
        public static bool operator >=(Mass<T> left, Mass<T> right) => left._kilograms >= right._kilograms;

        public bool Equals(Mass<T> other) => _kilograms == other._kilograms;
        public override bool Equals(object obj) => obj is Mass<T> other && Equals(other);
        public override int GetHashCode() => _kilograms.GetHashCode();
        public int CompareTo(Mass<T> other) => _kilograms.CompareTo(other._kilograms);
        public override string ToString() => _kilograms.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _kilograms.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _kilograms.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Acceleration<T> :
        IEquatable<Acceleration<T>>,
        IComparable<Acceleration<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _metresPerSecondSquared;

        private Acceleration(T value) => _metresPerSecondSquared = value;

        public T MetresPerSecondSquared => _metresPerSecondSquared;

        public static Acceleration<T> FromMetresPerSecondSquared(T value) => new Acceleration<T>(value);

        public static Acceleration<T> operator +(Acceleration<T> left, Acceleration<T> right)
            => FromMetresPerSecondSquared(left._metresPerSecondSquared + right._metresPerSecondSquared);
        public static Acceleration<T> operator -(Acceleration<T> left, Acceleration<T> right)
            => FromMetresPerSecondSquared(left._metresPerSecondSquared - right._metresPerSecondSquared);
        public static Acceleration<T> operator *(Acceleration<T> quantity, T scalar)
            => FromMetresPerSecondSquared(quantity._metresPerSecondSquared * scalar);
        public static Acceleration<T> operator /(Acceleration<T> quantity, T scalar)
            => FromMetresPerSecondSquared(quantity._metresPerSecondSquared / scalar);
        public static Speed<T> operator *(Acceleration<T> acceleration, Time<T> time)
            => Speed<T>.FromMetresPerSecond(acceleration._metresPerSecondSquared * time.Seconds);
        public static Force<T> operator *(Acceleration<T> acceleration, Mass<T> mass)
            => Force<T>.FromNewtons(acceleration._metresPerSecondSquared * mass.Kilograms);

        public static bool operator ==(Acceleration<T> left, Acceleration<T> right) => left.Equals(right);
        public static bool operator !=(Acceleration<T> left, Acceleration<T> right) => !left.Equals(right);
        public static bool operator <(Acceleration<T> left, Acceleration<T> right) => left._metresPerSecondSquared < right._metresPerSecondSquared;
        public static bool operator >(Acceleration<T> left, Acceleration<T> right) => left._metresPerSecondSquared > right._metresPerSecondSquared;
        public static bool operator <=(Acceleration<T> left, Acceleration<T> right) => left._metresPerSecondSquared <= right._metresPerSecondSquared;
        public static bool operator >=(Acceleration<T> left, Acceleration<T> right) => left._metresPerSecondSquared >= right._metresPerSecondSquared;

        public bool Equals(Acceleration<T> other) => _metresPerSecondSquared == other._metresPerSecondSquared;
        public override bool Equals(object obj) => obj is Acceleration<T> other && Equals(other);
        public override int GetHashCode() => _metresPerSecondSquared.GetHashCode();
        public int CompareTo(Acceleration<T> other) => _metresPerSecondSquared.CompareTo(other._metresPerSecondSquared);
        public override string ToString() => _metresPerSecondSquared.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _metresPerSecondSquared.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _metresPerSecondSquared.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Force<T> :
        IEquatable<Force<T>>,
        IComparable<Force<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _newtons;

        private Force(T newtons) => _newtons = newtons;

        public T Newtons => _newtons;
        public T Kilonewtons => _newtons / T.CreateChecked(1000);

        public static Force<T> FromNewtons(T value) => new Force<T>(value);
        public static Force<T> FromKilonewtons(T value) => new Force<T>(value * T.CreateChecked(1000));

        public static Force<T> operator +(Force<T> left, Force<T> right) => FromNewtons(left._newtons + right._newtons);
        public static Force<T> operator -(Force<T> left, Force<T> right) => FromNewtons(left._newtons - right._newtons);
        public static Force<T> operator *(Force<T> quantity, T scalar) => FromNewtons(quantity._newtons * scalar);
        public static Force<T> operator /(Force<T> quantity, T scalar) => FromNewtons(quantity._newtons / scalar);
        public static Acceleration<T> operator /(Force<T> force, Mass<T> mass)
            => Acceleration<T>.FromMetresPerSecondSquared(force._newtons / mass.Kilograms);
        public static Mass<T> operator /(Force<T> force, Acceleration<T> acceleration)
            => Mass<T>.FromKilograms(force._newtons / acceleration.MetresPerSecondSquared);
        public static Energy<T> operator *(Force<T> force, Length<T> length)
            => Energy<T>.FromJoules(force._newtons * length.Metres);
        public static Pressure<T> operator /(Force<T> force, Area<T> area)
            => Pressure<T>.FromPascals(force._newtons / area.SquareMetres);

        public static bool operator ==(Force<T> left, Force<T> right) => left.Equals(right);
        public static bool operator !=(Force<T> left, Force<T> right) => !left.Equals(right);
        public static bool operator <(Force<T> left, Force<T> right) => left._newtons < right._newtons;
        public static bool operator >(Force<T> left, Force<T> right) => left._newtons > right._newtons;
        public static bool operator <=(Force<T> left, Force<T> right) => left._newtons <= right._newtons;
        public static bool operator >=(Force<T> left, Force<T> right) => left._newtons >= right._newtons;

        public bool Equals(Force<T> other) => _newtons == other._newtons;
        public override bool Equals(object obj) => obj is Force<T> other && Equals(other);
        public override int GetHashCode() => _newtons.GetHashCode();
        public int CompareTo(Force<T> other) => _newtons.CompareTo(other._newtons);
        public override string ToString() => _newtons.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _newtons.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _newtons.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Area<T> :
        IEquatable<Area<T>>,
        IComparable<Area<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _squareMetres;

        private Area(T squareMetres) => _squareMetres = squareMetres;

        public T SquareMetres => _squareMetres;
        public T SquareKilometres => _squareMetres / T.CreateChecked(1_000_000);
        public T Hectares => _squareMetres / T.CreateChecked(10_000);

        public static Area<T> FromSquareMetres(T value) => new Area<T>(value);
        public static Area<T> FromSquareKilometres(T value) => new Area<T>(value * T.CreateChecked(1_000_000));
        public static Area<T> FromHectares(T value) => new Area<T>(value * T.CreateChecked(10_000));

        public static Area<T> operator +(Area<T> left, Area<T> right) => FromSquareMetres(left._squareMetres + right._squareMetres);
        public static Area<T> operator -(Area<T> left, Area<T> right) => FromSquareMetres(left._squareMetres - right._squareMetres);
        public static Area<T> operator *(Area<T> quantity, T scalar) => FromSquareMetres(quantity._squareMetres * scalar);
        public static Area<T> operator /(Area<T> quantity, T scalar) => FromSquareMetres(quantity._squareMetres / scalar);
        public static Volume<T> operator *(Area<T> area, Length<T> length)
            => Volume<T>.FromCubicMetres(area._squareMetres * length.Metres);
        public static Volume<T> operator *(Length<T> length, Area<T> area)
            => Volume<T>.FromCubicMetres(length.Metres * area._squareMetres);
        public static Length<T> operator /(Area<T> area, Length<T> length)
            => Length<T>.FromMetres(area._squareMetres / length.Metres);

        public static bool operator ==(Area<T> left, Area<T> right) => left.Equals(right);
        public static bool operator !=(Area<T> left, Area<T> right) => !left.Equals(right);
        public static bool operator <(Area<T> left, Area<T> right) => left._squareMetres < right._squareMetres;
        public static bool operator >(Area<T> left, Area<T> right) => left._squareMetres > right._squareMetres;
        public static bool operator <=(Area<T> left, Area<T> right) => left._squareMetres <= right._squareMetres;
        public static bool operator >=(Area<T> left, Area<T> right) => left._squareMetres >= right._squareMetres;

        public bool Equals(Area<T> other) => _squareMetres == other._squareMetres;
        public override bool Equals(object obj) => obj is Area<T> other && Equals(other);
        public override int GetHashCode() => _squareMetres.GetHashCode();
        public int CompareTo(Area<T> other) => _squareMetres.CompareTo(other._squareMetres);
        public override string ToString() => _squareMetres.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _squareMetres.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _squareMetres.TryFormat(destination, out charsWritten, format, provider);
    }

    public readonly partial struct Volume<T> :
        IEquatable<Volume<T>>,
        IComparable<Volume<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _cubicMetres;

        private Volume(T cubicMetres) => _cubicMetres = cubicMetres;

        public T CubicMetres => _cubicMetres;
        public T Litres => _cubicMetres * T.CreateChecked(1000);
        public T Millilitres => _cubicMetres * T.CreateChecked(1_000_000);

        public static Volume<T> FromCubicMetres(T value) => new Volume<T>(value);
        public static Volume<T> FromLitres(T value) => new Volume<T>(value / T.CreateChecked(1000));
        public static Volume<T> FromMillilitres(T value) => new Volume<T>(value / T.CreateChecked(1_000_000));

        public static Volume<T> operator +(Volume<T> left, Volume<T> right) => FromCubicMetres(left._cubicMetres + right._cubicMetres);
        public static Volume<T> operator -(Volume<T> left, Volume<T> right) => FromCubicMetres(left._cubicMetres - right._cubicMetres);
        public static Volume<T> operator *(Volume<T> quantity, T scalar) => FromCubicMetres(quantity._cubicMetres * scalar);
        public static Volume<T> operator /(Volume<T> quantity, T scalar) => FromCubicMetres(quantity._cubicMetres / scalar);
        public static Length<T> operator /(Volume<T> volume, Area<T> area)
            => Length<T>.FromMetres(volume._cubicMetres / area.SquareMetres);
        public static Area<T> operator /(Volume<T> volume, Length<T> length)
            => Area<T>.FromSquareMetres(volume._cubicMetres / length.Metres);
        public static Mass<T> operator *(Volume<T> volume, Density<T> density)
            => Mass<T>.FromKilograms(volume._cubicMetres * density.KilogramsPerCubicMetre);

        public static bool operator ==(Volume<T> left, Volume<T> right) => left.Equals(right);
        public static bool operator !=(Volume<T> left, Volume<T> right) => !left.Equals(right);
        public static bool operator <(Volume<T> left, Volume<T> right) => left._cubicMetres < right._cubicMetres;
        public static bool operator >(Volume<T> left, Volume<T> right) => left._cubicMetres > right._cubicMetres;
        public static bool operator <=(Volume<T> left, Volume<T> right) => left._cubicMetres <= right._cubicMetres;
        public static bool operator >=(Volume<T> left, Volume<T> right) => left._cubicMetres >= right._cubicMetres;

        public bool Equals(Volume<T> other) => _cubicMetres == other._cubicMetres;
        public override bool Equals(object obj) => obj is Volume<T> other && Equals(other);
        public override int GetHashCode() => _cubicMetres.GetHashCode();
        public int CompareTo(Volume<T> other) => _cubicMetres.CompareTo(other._cubicMetres);
        public override string ToString() => _cubicMetres.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _cubicMetres.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _cubicMetres.TryFormat(destination, out charsWritten, format, provider);
    }
}
#endif
