#if NET8_0_OR_GREATER
using System.Numerics;

namespace UnitTools.Quantities
{
    public readonly partial struct Stress<T> where T : IFloatingPoint<T>
    {
        public static Force<T> operator *(Stress<T> stress, Area<T> area)
            => Force<T>.FromNewtons(stress.Pascal * area.SquareMetres);

        public static Force<T> operator *(Area<T> area, Stress<T> stress)
            => stress * area;
    }

    public readonly partial struct Strain<T> where T : IFloatingPoint<T>
    {
        public static Stress<T> operator *(Strain<T> strain, YoungModulus<T> modulus)
            => Stress<T>.FromPascal(strain.Ratio * modulus.Pascal);

        public static Stress<T> operator *(YoungModulus<T> modulus, Strain<T> strain)
            => strain * modulus;

        public static YoungModulus<T> operator /(Stress<T> stress, Strain<T> strain)
            => YoungModulus<T>.FromPascal(stress.Pascal / strain.Ratio);
    }

    public readonly partial struct YoungModulus<T> where T : IFloatingPoint<T>
    {
        public static Strain<T> operator /(Stress<T> stress, YoungModulus<T> modulus)
            => Strain<T>.FromRatio(stress.Pascal / modulus.Pascal);
    }

    public readonly partial struct SpringConstant<T> where T : IFloatingPoint<T>
    {
        public static Force<T> operator *(SpringConstant<T> spring, Length<T> length)
            => Force<T>.FromNewtons(spring.NewtonPerMeter * length.Metres);

        public static Force<T> operator *(Length<T> length, SpringConstant<T> spring)
            => spring * length;

        public static Length<T> operator /(Force<T> force, SpringConstant<T> spring)
            => Length<T>.FromMetres(force.Newtons / spring.NewtonPerMeter);
    }

    public readonly partial struct DampingCoefficient<T> where T : IFloatingPoint<T>
    {
        public static Force<T> operator *(DampingCoefficient<T> damping, Speed<T> speed)
            => Force<T>.FromNewtons(damping.NewtonSecondPerMeter * speed.MetresPerSecond);

        public static Force<T> operator *(Speed<T> speed, DampingCoefficient<T> damping)
            => damping * speed;
    }

    public readonly partial struct MechanicalMobility<T> where T : IFloatingPoint<T>
    {
        public static Speed<T> operator *(MechanicalMobility<T> mobility, Force<T> force)
            => Speed<T>.FromMetresPerSecond(mobility.MeterPerNewtonSecond * force.Newtons);

        public static Speed<T> operator *(Force<T> force, MechanicalMobility<T> mobility)
            => mobility * force;
    }

    public readonly partial struct SpecificEnergy<T> where T : IFloatingPoint<T>
    {
        public static Energy<T> operator *(SpecificEnergy<T> specificEnergy, Mass<T> mass)
            => Energy<T>.FromJoules(specificEnergy.JoulePerKilogram * mass.Kilograms);

        public static Energy<T> operator *(Mass<T> mass, SpecificEnergy<T> specificEnergy)
            => specificEnergy * mass;
    }

    public readonly partial struct SpecificEnthalpy<T> where T : IFloatingPoint<T>
    {
        public static Energy<T> operator *(SpecificEnthalpy<T> enthalpy, Mass<T> mass)
            => Energy<T>.FromJoules(enthalpy.JoulePerKilogram * mass.Kilograms);

        public static Energy<T> operator *(Mass<T> mass, SpecificEnthalpy<T> enthalpy)
            => enthalpy * mass;
    }

    public readonly partial struct HeatFluxDensity<T> where T : IFloatingPoint<T>
    {
        public static Power<T> operator *(HeatFluxDensity<T> flux, Area<T> area)
            => Power<T>.FromWatts(flux.WattPerSquareMeter * area.SquareMetres);

        public static Power<T> operator *(Area<T> area, HeatFluxDensity<T> flux)
            => flux * area;
    }

    public readonly partial struct LinearChargeDensity<T> where T : IFloatingPoint<T>
    {
        public static ElectricCharge<T> operator *(LinearChargeDensity<T> density, Length<T> length)
            => ElectricCharge<T>.FromCoulombs(density.CoulombPerMeter * length.Metres);

        public static ElectricCharge<T> operator *(Length<T> length, LinearChargeDensity<T> density)
            => density * length;
    }

    public readonly partial struct SurfaceChargeDensity<T> where T : IFloatingPoint<T>
    {
        public static ElectricCharge<T> operator *(SurfaceChargeDensity<T> density, Area<T> area)
            => ElectricCharge<T>.FromCoulombs(density.CoulombPerSquareMeter * area.SquareMetres);

        public static ElectricCharge<T> operator *(Area<T> area, SurfaceChargeDensity<T> density)
            => density * area;
    }

    public readonly partial struct Elastance<T> where T : IFloatingPoint<T>
    {
        public static Voltage<T> operator *(Elastance<T> elastance, ElectricCharge<T> charge)
            => Voltage<T>.FromVolts(elastance.PerFarad * charge.Coulombs);

        public static Voltage<T> operator *(ElectricCharge<T> charge, Elastance<T> elastance)
            => elastance * charge;
    }

    public readonly partial struct Impedance<T> where T : IFloatingPoint<T>
    {
        public static Voltage<T> operator *(Impedance<T> impedance, ElectricCurrent<T> current)
            => Voltage<T>.FromVolts(impedance.Ohm * current.Amperes);

        public static Voltage<T> operator *(ElectricCurrent<T> current, Impedance<T> impedance)
            => impedance * current;
    }

    public readonly partial struct Reactance<T> where T : IFloatingPoint<T>
    {
        public static Voltage<T> operator *(Reactance<T> reactance, ElectricCurrent<T> current)
            => Voltage<T>.FromVolts(reactance.Ohm * current.Amperes);

        public static Voltage<T> operator *(ElectricCurrent<T> current, Reactance<T> reactance)
            => reactance * current;
    }

    public readonly partial struct SpecificSurfaceArea<T> where T : IFloatingPoint<T>
    {
        public static Area<T> operator *(SpecificSurfaceArea<T> surfaceArea, Mass<T> mass)
            => Area<T>.FromSquareMetres(surfaceArea.SquareMeterPerKilogram * mass.Kilograms);

        public static Area<T> operator *(Mass<T> mass, SpecificSurfaceArea<T> surfaceArea)
            => surfaceArea * mass;
    }
}
#endif
