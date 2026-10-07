#if NET8_0_OR_GREATER
namespace UnitConverter.Quantities
{
    using System;
    using System.Numerics;
    using UnitConverter.FuelEconomy;

    public enum FuelEfficiencyUnit
    {
        KilometerPerLiter = (int)UnitConverterFuelEconomyUnit.KilometerPerLiter,
        MilePerUSGallon = (int)UnitConverterFuelEconomyUnit.MilePerUSGallon,
        MilePerImperialGallon = (int)UnitConverterFuelEconomyUnit.MilePerImperialGallon,
        MilePerLiter = (int)UnitConverterFuelEconomyUnit.MilePerLiter,
        NauticalMilePerUSGallon = (int)UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon,
        MeterPerLiter = (int)UnitConverterFuelEconomyUnit.MeterPerLiter,
        KilometerPerUSGallon = (int)UnitConverterFuelEconomyUnit.KilometerPerUSGallon,
        KilometerPerImperialGallon = (int)UnitConverterFuelEconomyUnit.KilometerPerImperialGallon,
        NauticalMilePerImperialGallon = (int)UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon,
        KilometerPerMilliliter = (int)UnitConverterFuelEconomyUnit.KilometerPerMilliliter,
        MeterPerMilliliter = (int)UnitConverterFuelEconomyUnit.MeterPerMilliliter,
    }

    public enum FuelConsumptionUnit
    {
        LiterPer100Kilometer = (int)UnitConverterFuelEconomyUnit.LiterPer100Kilometer,
        LiterPerKilometer = (int)UnitConverterFuelEconomyUnit.LiterPerKilometer,
        LiterPerMile = (int)UnitConverterFuelEconomyUnit.LiterPerMile,
        USGallonPerMile = (int)UnitConverterFuelEconomyUnit.USGallonPerMile,
        ImperialGallonPerMile = (int)UnitConverterFuelEconomyUnit.ImperialGallonPerMile,
        MilliliterPerKilometer = (int)UnitConverterFuelEconomyUnit.MilliliterPerKilometer,
        LiterPer10Kilometer = (int)UnitConverterFuelEconomyUnit.LiterPer10Kilometer,
        LiterPer100Mile = (int)UnitConverterFuelEconomyUnit.LiterPer100Mile,
        USGallonPer100Mile = (int)UnitConverterFuelEconomyUnit.USGallonPer100Mile,
        ImperialGallonPer100Mile = (int)UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile,
        USGallonPer100Kilometer = (int)UnitConverterFuelEconomyUnit.USGallonPer100Kilometer,
        ImperialGallonPer100Kilometer = (int)UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer,
    }

    public readonly struct FuelEfficiency<T> : IEquatable<FuelEfficiency<T>>, IComparable<FuelEfficiency<T>>
        where T : IFloatingPoint<T>
    {
        private static readonly UnitConverterFuelEconomyUnit BaseUnit = UnitConverterFuelEconomyUnit.KilometerPerLiter;
        private readonly T _baseValue;

        private FuelEfficiency(T baseValue, FuelEfficiencyUnit unit)
        {
            _baseValue = baseValue;
            Unit = unit;
        }

        public FuelEfficiencyUnit Unit { get; }
        public T Value => As(Unit);

        public static FuelEfficiency<T> From(T value, FuelEfficiencyUnit unit)
        {
            UnitConverterFuelEconomyUnit legacy = ToLegacy(unit);
            return new FuelEfficiency<T>(UnitConverterNumeric.Convert(value, legacy, BaseUnit), unit);
        }

        public T As(FuelEfficiencyUnit unit)
            => UnitConverterNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit));

        public FuelEfficiency<T> To(FuelEfficiencyUnit unit)
            => new FuelEfficiency<T>(_baseValue, unit);

        public FuelConsumption<T> ToConsumption(FuelConsumptionUnit unit)
            => FuelConsumption<T>.From(
                UnitConverterNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit)),
                unit);

        public static FuelEfficiency<T> operator +(FuelEfficiency<T> left, FuelEfficiency<T> right)
            => new FuelEfficiency<T>(left._baseValue + right._baseValue, left.Unit);
        public static FuelEfficiency<T> operator -(FuelEfficiency<T> left, FuelEfficiency<T> right)
            => new FuelEfficiency<T>(left._baseValue - right._baseValue, left.Unit);
        public static FuelEfficiency<T> operator *(FuelEfficiency<T> value, T scalar)
            => new FuelEfficiency<T>(value._baseValue * scalar, value.Unit);
        public static FuelEfficiency<T> operator /(FuelEfficiency<T> value, T scalar)
            => new FuelEfficiency<T>(value._baseValue / scalar, value.Unit);
        public static bool operator ==(FuelEfficiency<T> left, FuelEfficiency<T> right) => left.Equals(right);
        public static bool operator !=(FuelEfficiency<T> left, FuelEfficiency<T> right) => !left.Equals(right);
        public bool Equals(FuelEfficiency<T> other) => _baseValue == other._baseValue;
        public override bool Equals(object obj) => obj is FuelEfficiency<T> other && Equals(other);
        public override int GetHashCode() => _baseValue.GetHashCode();
        public int CompareTo(FuelEfficiency<T> other) => _baseValue.CompareTo(other._baseValue);

        private static UnitConverterFuelEconomyUnit ToLegacy(FuelEfficiencyUnit unit)
            => (UnitConverterFuelEconomyUnit)(int)unit;
        private static UnitConverterFuelEconomyUnit ToLegacy(FuelConsumptionUnit unit)
            => (UnitConverterFuelEconomyUnit)(int)unit;
    }

    public readonly struct FuelConsumption<T> : IEquatable<FuelConsumption<T>>, IComparable<FuelConsumption<T>>
        where T : IFloatingPoint<T>
    {
        private static readonly UnitConverterFuelEconomyUnit BaseUnit = UnitConverterFuelEconomyUnit.LiterPer100Kilometer;
        private readonly T _baseValue;

        private FuelConsumption(T baseValue, FuelConsumptionUnit unit)
        {
            _baseValue = baseValue;
            Unit = unit;
        }

        public FuelConsumptionUnit Unit { get; }
        public T Value => As(Unit);

        public static FuelConsumption<T> From(T value, FuelConsumptionUnit unit)
        {
            UnitConverterFuelEconomyUnit legacy = ToLegacy(unit);
            return new FuelConsumption<T>(UnitConverterNumeric.Convert(value, legacy, BaseUnit), unit);
        }

        public T As(FuelConsumptionUnit unit)
            => UnitConverterNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit));

        public FuelConsumption<T> To(FuelConsumptionUnit unit)
            => new FuelConsumption<T>(_baseValue, unit);

        public FuelEfficiency<T> ToEfficiency(FuelEfficiencyUnit unit)
            => FuelEfficiency<T>.From(
                UnitConverterNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit)),
                unit);

        public static FuelConsumption<T> operator +(FuelConsumption<T> left, FuelConsumption<T> right)
            => new FuelConsumption<T>(left._baseValue + right._baseValue, left.Unit);
        public static FuelConsumption<T> operator -(FuelConsumption<T> left, FuelConsumption<T> right)
            => new FuelConsumption<T>(left._baseValue - right._baseValue, left.Unit);
        public static FuelConsumption<T> operator *(FuelConsumption<T> value, T scalar)
            => new FuelConsumption<T>(value._baseValue * scalar, value.Unit);
        public static FuelConsumption<T> operator /(FuelConsumption<T> value, T scalar)
            => new FuelConsumption<T>(value._baseValue / scalar, value.Unit);
        public static bool operator ==(FuelConsumption<T> left, FuelConsumption<T> right) => left.Equals(right);
        public static bool operator !=(FuelConsumption<T> left, FuelConsumption<T> right) => !left.Equals(right);
        public bool Equals(FuelConsumption<T> other) => _baseValue == other._baseValue;
        public override bool Equals(object obj) => obj is FuelConsumption<T> other && Equals(other);
        public override int GetHashCode() => _baseValue.GetHashCode();
        public int CompareTo(FuelConsumption<T> other) => _baseValue.CompareTo(other._baseValue);

        private static UnitConverterFuelEconomyUnit ToLegacy(FuelConsumptionUnit unit)
            => (UnitConverterFuelEconomyUnit)(int)unit;
        private static UnitConverterFuelEconomyUnit ToLegacy(FuelEfficiencyUnit unit)
            => (UnitConverterFuelEconomyUnit)(int)unit;
    }
}
#endif
