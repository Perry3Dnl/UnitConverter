#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitConverter.Quantities
{
    internal readonly struct RationalFactor
    {
        public RationalFactor(long numerator, long denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            Numerator = numerator;
            Denominator = denominator;
        }

        public long Numerator { get; }
        public long Denominator { get; }

        public T Apply<T>(T value) where T : IFloatingPoint<T>
            => value * T.CreateChecked(Numerator) / T.CreateChecked(Denominator);

        public T ApplyInverse<T>(T value) where T : IFloatingPoint<T>
            => value * T.CreateChecked(Denominator) / T.CreateChecked(Numerator);
    }

    public readonly struct Length<T> :
        IEquatable<Length<T>>,
        IComparable<Length<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private static readonly RationalFactor InchToMetre = new RationalFactor(127, 5000);
        private static readonly RationalFactor FootToMetre = new RationalFactor(381, 1250);
        private static readonly RationalFactor YardToMetre = new RationalFactor(1143, 1250);
        private static readonly RationalFactor MileToMetre = new RationalFactor(201168, 125);

        private readonly T _metres;

        private Length(T metres) => _metres = metres;

        public T Metres => _metres;
        public T Kilometres => _metres / T.CreateChecked(1000);
        public T Centimetres => _metres * T.CreateChecked(100);
        public T Millimetres => _metres * T.CreateChecked(1000);
        public T Inches => InchToMetre.ApplyInverse(_metres);
        public T Feet => FootToMetre.ApplyInverse(_metres);
        public T Yards => YardToMetre.ApplyInverse(_metres);
        public T Miles => MileToMetre.ApplyInverse(_metres);

        public static Length<T> FromMetres(T value) => new Length<T>(value);
        public static Length<T> FromKilometres(T value) => new Length<T>(value * T.CreateChecked(1000));
        public static Length<T> FromCentimetres(T value) => new Length<T>(value / T.CreateChecked(100));
        public static Length<T> FromMillimetres(T value) => new Length<T>(value / T.CreateChecked(1000));
        public static Length<T> FromInches(T value) => new Length<T>(InchToMetre.Apply(value));
        public static Length<T> FromFeet(T value) => new Length<T>(FootToMetre.Apply(value));
        public static Length<T> FromYards(T value) => new Length<T>(YardToMetre.Apply(value));
        public static Length<T> FromMiles(T value) => new Length<T>(MileToMetre.Apply(value));

        public static Length<T> operator +(Length<T> left, Length<T> right) => FromMetres(left._metres + right._metres);
        public static Length<T> operator -(Length<T> left, Length<T> right) => FromMetres(left._metres - right._metres);
        public static Length<T> operator -(Length<T> value) => FromMetres(-value._metres);
        public static Length<T> operator *(Length<T> quantity, T scalar) => FromMetres(quantity._metres * scalar);
        public static Length<T> operator *(T scalar, Length<T> quantity) => quantity * scalar;
        public static Length<T> operator /(Length<T> quantity, T scalar) => FromMetres(quantity._metres / scalar);
        public static T operator /(Length<T> left, Length<T> right) => left._metres / right._metres;
        public static Speed<T> operator /(Length<T> length, Time<T> time) => Speed<T>.FromMetresPerSecond(length._metres / time.Seconds);

        public static bool operator ==(Length<T> left, Length<T> right) => left.Equals(right);
        public static bool operator !=(Length<T> left, Length<T> right) => !left.Equals(right);
        public static bool operator <(Length<T> left, Length<T> right) => left._metres < right._metres;
        public static bool operator >(Length<T> left, Length<T> right) => left._metres > right._metres;
        public static bool operator <=(Length<T> left, Length<T> right) => left._metres <= right._metres;
        public static bool operator >=(Length<T> left, Length<T> right) => left._metres >= right._metres;

        public bool Equals(Length<T> other) => _metres == other._metres;
        public override bool Equals(object obj) => obj is Length<T> other && Equals(other);
        public override int GetHashCode() => _metres.GetHashCode();
        public int CompareTo(Length<T> other) => _metres.CompareTo(other._metres);
        public override string ToString() => _metres.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _metres.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _metres.TryFormat(destination, out charsWritten, format, provider);
    }

    public static class Length
    {
        public static Length<T> FromMetres<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromMetres(value);
        public static Length<T> FromKilometres<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromKilometres(value);
        public static Length<T> FromCentimetres<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromCentimetres(value);
        public static Length<T> FromMillimetres<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromMillimetres(value);
        public static Length<T> FromInches<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromInches(value);
        public static Length<T> FromFeet<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromFeet(value);
        public static Length<T> FromYards<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromYards(value);
        public static Length<T> FromMiles<T>(T value) where T : IFloatingPoint<T> => Length<T>.FromMiles(value);
    }

    public readonly struct Time<T> :
        IEquatable<Time<T>>,
        IComparable<Time<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _seconds;

        private Time(T seconds) => _seconds = seconds;

        public T Seconds => _seconds;
        public T Milliseconds => _seconds * T.CreateChecked(1000);
        public T Minutes => _seconds / T.CreateChecked(60);
        public T Hours => _seconds / T.CreateChecked(3600);
        public T Days => _seconds / T.CreateChecked(86400);

        public static Time<T> FromSeconds(T value) => new Time<T>(value);
        public static Time<T> FromMilliseconds(T value) => new Time<T>(value / T.CreateChecked(1000));
        public static Time<T> FromMinutes(T value) => new Time<T>(value * T.CreateChecked(60));
        public static Time<T> FromHours(T value) => new Time<T>(value * T.CreateChecked(3600));
        public static Time<T> FromDays(T value) => new Time<T>(value * T.CreateChecked(86400));

        public static Time<T> operator +(Time<T> left, Time<T> right) => FromSeconds(left._seconds + right._seconds);
        public static Time<T> operator -(Time<T> left, Time<T> right) => FromSeconds(left._seconds - right._seconds);
        public static Time<T> operator -(Time<T> value) => FromSeconds(-value._seconds);
        public static Time<T> operator *(Time<T> quantity, T scalar) => FromSeconds(quantity._seconds * scalar);
        public static Time<T> operator *(T scalar, Time<T> quantity) => quantity * scalar;
        public static Length<T> operator *(Time<T> time, Speed<T> speed) => Length<T>.FromMetres(time._seconds * speed.MetresPerSecond);
        public static Time<T> operator /(Time<T> quantity, T scalar) => FromSeconds(quantity._seconds / scalar);
        public static T operator /(Time<T> left, Time<T> right) => left._seconds / right._seconds;

        public static bool operator ==(Time<T> left, Time<T> right) => left.Equals(right);
        public static bool operator !=(Time<T> left, Time<T> right) => !left.Equals(right);
        public static bool operator <(Time<T> left, Time<T> right) => left._seconds < right._seconds;
        public static bool operator >(Time<T> left, Time<T> right) => left._seconds > right._seconds;
        public static bool operator <=(Time<T> left, Time<T> right) => left._seconds <= right._seconds;
        public static bool operator >=(Time<T> left, Time<T> right) => left._seconds >= right._seconds;

        public bool Equals(Time<T> other) => _seconds == other._seconds;
        public override bool Equals(object obj) => obj is Time<T> other && Equals(other);
        public override int GetHashCode() => _seconds.GetHashCode();
        public int CompareTo(Time<T> other) => _seconds.CompareTo(other._seconds);
        public override string ToString() => _seconds.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _seconds.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _seconds.TryFormat(destination, out charsWritten, format, provider);
    }

    public static class Time
    {
        public static Time<T> FromSeconds<T>(T value) where T : IFloatingPoint<T> => Time<T>.FromSeconds(value);
        public static Time<T> FromMilliseconds<T>(T value) where T : IFloatingPoint<T> => Time<T>.FromMilliseconds(value);
        public static Time<T> FromMinutes<T>(T value) where T : IFloatingPoint<T> => Time<T>.FromMinutes(value);
        public static Time<T> FromHours<T>(T value) where T : IFloatingPoint<T> => Time<T>.FromHours(value);
        public static Time<T> FromDays<T>(T value) where T : IFloatingPoint<T> => Time<T>.FromDays(value);
    }

    public readonly struct Speed<T> :
        IEquatable<Speed<T>>,
        IComparable<Speed<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private static readonly RationalFactor MilePerHourToMetresPerSecond = new RationalFactor(1397, 3125);
        private static readonly RationalFactor KnotToMetresPerSecond = new RationalFactor(463, 900);

        private readonly T _metresPerSecond;

        private Speed(T metresPerSecond) => _metresPerSecond = metresPerSecond;

        public T MetresPerSecond => _metresPerSecond;
        public T KilometresPerHour => _metresPerSecond * T.CreateChecked(18) / T.CreateChecked(5);
        public T MilesPerHour => MilePerHourToMetresPerSecond.ApplyInverse(_metresPerSecond);
        public T Knots => KnotToMetresPerSecond.ApplyInverse(_metresPerSecond);

        public static Speed<T> FromMetresPerSecond(T value) => new Speed<T>(value);
        public static Speed<T> FromKilometresPerHour(T value) => new Speed<T>(value * T.CreateChecked(5) / T.CreateChecked(18));
        public static Speed<T> FromMilesPerHour(T value) => new Speed<T>(MilePerHourToMetresPerSecond.Apply(value));
        public static Speed<T> FromKnots(T value) => new Speed<T>(KnotToMetresPerSecond.Apply(value));

        public static Speed<T> operator +(Speed<T> left, Speed<T> right) => FromMetresPerSecond(left._metresPerSecond + right._metresPerSecond);
        public static Speed<T> operator -(Speed<T> left, Speed<T> right) => FromMetresPerSecond(left._metresPerSecond - right._metresPerSecond);
        public static Speed<T> operator -(Speed<T> value) => FromMetresPerSecond(-value._metresPerSecond);
        public static Speed<T> operator *(Speed<T> quantity, T scalar) => FromMetresPerSecond(quantity._metresPerSecond * scalar);
        public static Speed<T> operator *(T scalar, Speed<T> quantity) => quantity * scalar;
        public static Length<T> operator *(Speed<T> speed, Time<T> time) => Length<T>.FromMetres(speed._metresPerSecond * time.Seconds);
        public static Speed<T> operator /(Speed<T> quantity, T scalar) => FromMetresPerSecond(quantity._metresPerSecond / scalar);
        public static T operator /(Speed<T> left, Speed<T> right) => left._metresPerSecond / right._metresPerSecond;

        public static bool operator ==(Speed<T> left, Speed<T> right) => left.Equals(right);
        public static bool operator !=(Speed<T> left, Speed<T> right) => !left.Equals(right);
        public static bool operator <(Speed<T> left, Speed<T> right) => left._metresPerSecond < right._metresPerSecond;
        public static bool operator >(Speed<T> left, Speed<T> right) => left._metresPerSecond > right._metresPerSecond;
        public static bool operator <=(Speed<T> left, Speed<T> right) => left._metresPerSecond <= right._metresPerSecond;
        public static bool operator >=(Speed<T> left, Speed<T> right) => left._metresPerSecond >= right._metresPerSecond;

        public bool Equals(Speed<T> other) => _metresPerSecond == other._metresPerSecond;
        public override bool Equals(object obj) => obj is Speed<T> other && Equals(other);
        public override int GetHashCode() => _metresPerSecond.GetHashCode();
        public int CompareTo(Speed<T> other) => _metresPerSecond.CompareTo(other._metresPerSecond);
        public override string ToString() => _metresPerSecond.ToString();
        public string ToString(string format, IFormatProvider formatProvider) => _metresPerSecond.ToString(format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => _metresPerSecond.TryFormat(destination, out charsWritten, format, provider);
    }

    public static class Speed
    {
        public static Speed<T> FromMetresPerSecond<T>(T value) where T : IFloatingPoint<T> => Speed<T>.FromMetresPerSecond(value);
        public static Speed<T> FromKilometresPerHour<T>(T value) where T : IFloatingPoint<T> => Speed<T>.FromKilometresPerHour(value);
        public static Speed<T> FromMilesPerHour<T>(T value) where T : IFloatingPoint<T> => Speed<T>.FromMilesPerHour(value);
        public static Speed<T> FromKnots<T>(T value) where T : IFloatingPoint<T> => Speed<T>.FromKnots(value);
    }
}
#endif
