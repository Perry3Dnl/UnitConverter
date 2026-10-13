#if NET8_0_OR_GREATER
namespace UnitTools.Quantities
{
    using System;
    using System.Numerics;
    using UnitTools.FuelEconomy;

    public enum FuelEfficiencyUnit
    {
        KilometerPerLiter = (int)UnitToolsFuelEconomyUnit.KilometerPerLiter,
        MilePerUSGallon = (int)UnitToolsFuelEconomyUnit.MilePerUSGallon,
        MilePerImperialGallon = (int)UnitToolsFuelEconomyUnit.MilePerImperialGallon,
        MilePerLiter = (int)UnitToolsFuelEconomyUnit.MilePerLiter,
        NauticalMilePerUSGallon = (int)UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon,
        MeterPerLiter = (int)UnitToolsFuelEconomyUnit.MeterPerLiter,
        KilometerPerUSGallon = (int)UnitToolsFuelEconomyUnit.KilometerPerUSGallon,
        KilometerPerImperialGallon = (int)UnitToolsFuelEconomyUnit.KilometerPerImperialGallon,
        NauticalMilePerImperialGallon = (int)UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon,
        KilometerPerMilliliter = (int)UnitToolsFuelEconomyUnit.KilometerPerMilliliter,
        MeterPerMilliliter = (int)UnitToolsFuelEconomyUnit.MeterPerMilliliter,
    }

    public enum FuelConsumptionUnit
    {
        LiterPer100Kilometer = (int)UnitToolsFuelEconomyUnit.LiterPer100Kilometer,
        LiterPerKilometer = (int)UnitToolsFuelEconomyUnit.LiterPerKilometer,
        LiterPerMile = (int)UnitToolsFuelEconomyUnit.LiterPerMile,
        USGallonPerMile = (int)UnitToolsFuelEconomyUnit.USGallonPerMile,
        ImperialGallonPerMile = (int)UnitToolsFuelEconomyUnit.ImperialGallonPerMile,
        MilliliterPerKilometer = (int)UnitToolsFuelEconomyUnit.MilliliterPerKilometer,
        LiterPer10Kilometer = (int)UnitToolsFuelEconomyUnit.LiterPer10Kilometer,
        LiterPer100Mile = (int)UnitToolsFuelEconomyUnit.LiterPer100Mile,
        USGallonPer100Mile = (int)UnitToolsFuelEconomyUnit.USGallonPer100Mile,
        ImperialGallonPer100Mile = (int)UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile,
        USGallonPer100Kilometer = (int)UnitToolsFuelEconomyUnit.USGallonPer100Kilometer,
        ImperialGallonPer100Kilometer = (int)UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer,
    }

    public readonly struct FuelEfficiency<T> : IEquatable<FuelEfficiency<T>>, IComparable<FuelEfficiency<T>>
        where T : IFloatingPoint<T>
    {
        private static readonly UnitToolsFuelEconomyUnit BaseUnit = UnitToolsFuelEconomyUnit.KilometerPerLiter;
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
            UnitToolsFuelEconomyUnit legacy = ToLegacy(unit);
            return new FuelEfficiency<T>(UnitToolsNumeric.Convert(value, legacy, BaseUnit), unit);
        }

        public T As(FuelEfficiencyUnit unit)
            => UnitToolsNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit));

        public FuelEfficiency<T> To(FuelEfficiencyUnit unit)
            => new FuelEfficiency<T>(_baseValue, unit);

        public FuelConsumption<T> ToConsumption(FuelConsumptionUnit unit)
            => FuelConsumption<T>.From(
                UnitToolsNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit)),
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

        private static UnitToolsFuelEconomyUnit ToLegacy(FuelEfficiencyUnit unit)
            => (UnitToolsFuelEconomyUnit)(int)unit;
        private static UnitToolsFuelEconomyUnit ToLegacy(FuelConsumptionUnit unit)
            => (UnitToolsFuelEconomyUnit)(int)unit;
    }

    public readonly struct FuelConsumption<T> : IEquatable<FuelConsumption<T>>, IComparable<FuelConsumption<T>>
        where T : IFloatingPoint<T>
    {
        private static readonly UnitToolsFuelEconomyUnit BaseUnit = UnitToolsFuelEconomyUnit.LiterPer100Kilometer;
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
            UnitToolsFuelEconomyUnit legacy = ToLegacy(unit);
            return new FuelConsumption<T>(UnitToolsNumeric.Convert(value, legacy, BaseUnit), unit);
        }

        public T As(FuelConsumptionUnit unit)
            => UnitToolsNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit));

        public FuelConsumption<T> To(FuelConsumptionUnit unit)
            => new FuelConsumption<T>(_baseValue, unit);

        public FuelEfficiency<T> ToEfficiency(FuelEfficiencyUnit unit)
            => FuelEfficiency<T>.From(
                UnitToolsNumeric.Convert(_baseValue, BaseUnit, ToLegacy(unit)),
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

        private static UnitToolsFuelEconomyUnit ToLegacy(FuelConsumptionUnit unit)
            => (UnitToolsFuelEconomyUnit)(int)unit;
        private static UnitToolsFuelEconomyUnit ToLegacy(FuelEfficiencyUnit unit)
            => (UnitToolsFuelEconomyUnit)(int)unit;
    }
}
#endif
