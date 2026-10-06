using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class MechanicalQuantityTests
    {
        [Test]
        public void ForceTimesLengthProducesEnergy()
        {
            Force<decimal> force = Force<decimal>.FromNewtons(25m);
            Length<decimal> distance = Length<decimal>.FromMetres(4m);

            Energy<decimal> energy = force * distance;

            Assert.That(energy.Joules, Is.EqualTo(100m));
        }

        [Test]
        public void EnergyDividedByTimeProducesPower()
        {
            Energy<decimal> energy = Energy<decimal>.FromKilojoules(18m);
            Time<decimal> time = Time<decimal>.FromSeconds(30m);

            Power<decimal> power = energy / time;

            Assert.That(power.Watts, Is.EqualTo(600m));
        }

        [Test]
        public void PowerTimesTimeProducesEnergy()
        {
            Power<decimal> power = Power<decimal>.FromKilowatts(2m);
            Time<decimal> time = Time<decimal>.FromSeconds(90m);

            Energy<decimal> energy = power * time;

            Assert.That(energy.Kilojoules, Is.EqualTo(180m));
        }

        [Test]
        public void ForceDividedByAreaProducesPressure()
        {
            Force<decimal> force = Force<decimal>.FromNewtons(500m);
            Area<decimal> area = Area<decimal>.FromSquareMetres(0.25m);

            Pressure<decimal> pressure = force / area;

            Assert.That(pressure.Pascals, Is.EqualTo(2000m));
            Assert.That(pressure.Kilopascals, Is.EqualTo(2m));
        }

        [Test]
        public void PressureTimesAreaProducesForce()
        {
            Pressure<decimal> pressure = Pressure<decimal>.FromKilopascals(2m);
            Area<decimal> area = Area<decimal>.FromSquareMetres(0.25m);

            Force<decimal> force = pressure * area;

            Assert.That(force.Newtons, Is.EqualTo(500m));
        }

        [Test]
        public void BarConversionUsesDecimalArithmetic()
        {
            Pressure<decimal> pressure = Pressure<decimal>.FromBars(1.5m);

            Assert.That(pressure.Pascals, Is.EqualTo(150000m));
            Assert.That(pressure.Bars, Is.EqualTo(1.5m));
        }
    }
}
