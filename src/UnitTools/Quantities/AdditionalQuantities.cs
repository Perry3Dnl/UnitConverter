#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitTools.Quantities
{
    public readonly partial struct Density<T> :
        IEquatable<Density<T>>,
        IComparable<Density<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _kilogramsPerCubicMetre;

        private Density(T value) => _kilogramsPerCubicMetre = value;

        public T KilogramsPerCubicMetre => _kilogramsPerCubicMetre;
        public T GramsPerCubicCentimetre => _kilogramsPerCubicMetre / T.CreateChecked(1000);

        public static Density<T> FromKilogramsPerCubicMetre(T value) => new Density<T>(value);
        public static Density<T> FromGramsPerCubicCentimetre(T value) => new Density<T>(value * T.CreateChecked(1000));

        public static Density<T> operator +(Density<T> left, Density<T> right)
            => FromKilogramsPerCubicMetre(left._kilogramsPerCubicMetre + right._kilogramsPerCubicMetre);
        public static Density<T> operator -(Density<T> left, Density<T> right)
            => FromKilogramsPerCubicMetre(left._kilogramsPerCubicMetre - right._kilogramsPerCubicMetre);
        public static Density<T> operator *(Density<T> quantity, T scalar)
            => FromKilogramsPerCubicMetre(quantity._kilogramsPerCubicMetre * scalar);
        public static Density<T> operator /(Density<T> quantity, T scalar)
            => FromKilogramsPerCubicMetre(quantity._kilogramsPerCubicMetre / scalar);
        public static Mass<T> operator *(Density<T> density, Volume<T> volume)
            => Mass<T>.FromKilograms(density._kilogramsPerCubicMetre * volume.CubicMetres);

        public static bool operator ==(Density<T> left, Density<T> right) => left.Equals(right);
        public static bool operator !=(Density<T> left, Density<T> right) => !left.Equals(right);
        public static bool operator <(Density<T> left, Density<T> right) => left._kilogramsPerCubicMetre < right._kilogramsPerCubicMetre;
        public static bool operator >(Density<T> left, Density<T> right) => left._kilogramsPerCubicMetre > right._kilogramsPerCubicMetre;
        public static bool operator <=(Density<T> left, Density<T> right) => left._kilogramsPerCubicMetre <= right._kilogramsPerCubicMetre;
        public static bool operator >=(Density<T> left, Density<T> right) => left._kilogramsPerCubicMetre >= right._kilogramsPerCubicMetre;

        public bool Equals(Density<T> other) => _kilogramsPerCubicMetre == other._kilogramsPerCubicMetre;
        public override bool Equals(object obj) => obj is Density<T> other && Equals(other);
        public override int GetHashCode() => _kilogramsPerCubicMetre.GetHashCode();
        public int CompareTo(Density<T> other) => _kilogramsPerCubicMetre.CompareTo(other._kilogramsPerCubicMetre);
        public override string ToString() => QuantityText.Format(_kilogramsPerCubicMetre, "kg/m³", null, null);
        public string ToString(string format, IFormatProvider formatProvider) => QuantityText.Format(_kilogramsPerCubicMetre, "kg/m³", format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => QuantityText.TryFormat(_kilogramsPerCubicMetre, "kg/m³".AsSpan(), destination, out charsWritten, format, provider);
    }

    public readonly partial struct Frequency<T> :
        IEquatable<Frequency<T>>,
        IComparable<Frequency<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _hertz;

        private Frequency(T hertz) => _hertz = hertz;

        public T Hertz => _hertz;
        public T Kilohertz => _hertz / T.CreateChecked(1000);
        public T Megahertz => _hertz / T.CreateChecked(1_000_000);

        public static Frequency<T> FromHertz(T value) => new Frequency<T>(value);
        public static Frequency<T> FromKilohertz(T value) => new Frequency<T>(value * T.CreateChecked(1000));
        public static Frequency<T> FromMegahertz(T value) => new Frequency<T>(value * T.CreateChecked(1_000_000));
        public static Frequency<T> FromPeriod(Time<T> period) => new Frequency<T>(T.One / period.Seconds);

        public Time<T> Period => Time<T>.FromSeconds(T.One / _hertz);

        public static Frequency<T> operator +(Frequency<T> left, Frequency<T> right) => FromHertz(left._hertz + right._hertz);
        public static Frequency<T> operator -(Frequency<T> left, Frequency<T> right) => FromHertz(left._hertz - right._hertz);
        public static Frequency<T> operator *(Frequency<T> quantity, T scalar) => FromHertz(quantity._hertz * scalar);
        public static Frequency<T> operator /(Frequency<T> quantity, T scalar) => FromHertz(quantity._hertz / scalar);
        public static T operator *(Frequency<T> frequency, Time<T> time) => frequency._hertz * time.Seconds;

        public static bool operator ==(Frequency<T> left, Frequency<T> right) => left.Equals(right);
        public static bool operator !=(Frequency<T> left, Frequency<T> right) => !left.Equals(right);
        public static bool operator <(Frequency<T> left, Frequency<T> right) => left._hertz < right._hertz;
        public static bool operator >(Frequency<T> left, Frequency<T> right) => left._hertz > right._hertz;
        public static bool operator <=(Frequency<T> left, Frequency<T> right) => left._hertz <= right._hertz;
        public static bool operator >=(Frequency<T> left, Frequency<T> right) => left._hertz >= right._hertz;

        public bool Equals(Frequency<T> other) => _hertz == other._hertz;
        public override bool Equals(object obj) => obj is Frequency<T> other && Equals(other);
        public override int GetHashCode() => _hertz.GetHashCode();
        public int CompareTo(Frequency<T> other) => _hertz.CompareTo(other._hertz);
        public override string ToString() => QuantityText.Format(_hertz, "Hz", null, null);
        public string ToString(string format, IFormatProvider formatProvider) => QuantityText.Format(_hertz, "Hz", format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => QuantityText.TryFormat(_hertz, "Hz".AsSpan(), destination, out charsWritten, format, provider);
    }

    public readonly partial struct ElectricCurrent<T> :
        IEquatable<ElectricCurrent<T>>,
        IComparable<ElectricCurrent<T>>,
        IFormattable,
        ISpanFormattable
        where T : IFloatingPoint<T>
    {
        private readonly T _amperes;

        private ElectricCurrent(T amperes) => _amperes = amperes;

        public T Amperes => _amperes;
        public T Milliamperes => _amperes * T.CreateChecked(1000);

        public static ElectricCurrent<T> FromAmperes(T value) => new ElectricCurrent<T>(value);
        public static ElectricCurrent<T> FromMilliamperes(T value) => new ElectricCurrent<T>(value / T.CreateChecked(1000));

        public static ElectricCharge<T> operator *(ElectricCurrent<T> current, Time<T> time)
            => ElectricCharge<T>.FromCoulombs(current._amperes * time.Seconds);
        public static Power<T> operator *(ElectricCurrent<T> current, Voltage<T> voltage)
            => Power<T>.FromWatts(current._amperes * voltage.Volts);

        public static bool operator ==(ElectricCurrent<T> left, ElectricCurrent<T> right) => left.Equals(right);
        public static bool operator !=(ElectricCurrent<T> left, ElectricCurrent<T> right) => !left.Equals(right);
        public static bool operator <(ElectricCurrent<T> left, ElectricCurrent<T> right) => left._amperes < right._amperes;
        public static bool operator >(ElectricCurrent<T> left, ElectricCurrent<T> right) => left._amperes > right._amperes;
        public static bool operator <=(ElectricCurrent<T> left, ElectricCurrent<T> right) => left._amperes <= right._amperes;
        public static bool operator >=(ElectricCurrent<T> left, ElectricCurrent<T> right) => left._amperes >= right._amperes;

        public bool Equals(ElectricCurrent<T> other) => _amperes == other._amperes;
        public override bool Equals(object obj) => obj is ElectricCurrent<T> other && Equals(other);
        public override int GetHashCode() => _amperes.GetHashCode();
        public int CompareTo(ElectricCurrent<T> other) => _amperes.CompareTo(other._amperes);
        public override string ToString() => QuantityText.Format(_amperes, "A", null, null);
        public string ToString(string format, IFormatProvider formatProvider) => QuantityText.Format(_amperes, "A", format, formatProvider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
            => QuantityText.TryFormat(_amperes, "A".AsSpan(), destination, out charsWritten, format, provider);
    }

    public readonly partial struct ElectricCharge<T> where T : IFloatingPoint<T>
    {
        private readonly T _coulombs;
        private ElectricCharge(T value) => _coulombs = value;
        public T Coulombs => _coulombs;
        public static ElectricCharge<T> FromCoulombs(T value) => new ElectricCharge<T>(value);
        public static ElectricCurrent<T> operator /(ElectricCharge<T> charge, Time<T> time)
            => ElectricCurrent<T>.FromAmperes(charge._coulombs / time.Seconds);
    }

    public readonly partial struct Voltage<T> where T : IFloatingPoint<T>
    {
        private readonly T _volts;
        private Voltage(T volts) => _volts = volts;
        public T Volts => _volts;
        public T Millivolts => _volts * T.CreateChecked(1000);
        public static Voltage<T> FromVolts(T value) => new Voltage<T>(value);
        public static Voltage<T> FromMillivolts(T value) => new Voltage<T>(value / T.CreateChecked(1000));
        public static Power<T> operator *(Voltage<T> voltage, ElectricCurrent<T> current)
            => Power<T>.FromWatts(voltage._volts * current.Amperes);
        public static Resistance<T> operator /(Voltage<T> voltage, ElectricCurrent<T> current)
            => Resistance<T>.FromOhms(voltage._volts / current.Amperes);
        public static ElectricCurrent<T> operator /(Voltage<T> voltage, Resistance<T> resistance)
            => ElectricCurrent<T>.FromAmperes(voltage._volts / resistance.Ohms);
    }

    public readonly partial struct Resistance<T> where T : IFloatingPoint<T>
    {
        private readonly T _ohms;
        private Resistance(T ohms) => _ohms = ohms;
        public T Ohms => _ohms;
        public T Kiloohms => _ohms / T.CreateChecked(1000);
        public static Resistance<T> FromOhms(T value) => new Resistance<T>(value);
        public static Resistance<T> FromKiloohms(T value) => new Resistance<T>(value * T.CreateChecked(1000));
        public static Voltage<T> operator *(Resistance<T> resistance, ElectricCurrent<T> current)
            => Voltage<T>.FromVolts(resistance._ohms * current.Amperes);
    }
}
#endif
