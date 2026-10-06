using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class AdditionalQuantityTests
    {
        [Test]
        public void MassDividedByVolumeProducesDensity()
        {
            Mass<decimal> mass = Mass<decimal>.FromKilograms(1000m);
            Volume<decimal> volume = Volume<decimal>.FromCubicMetres(1m);

            Density<decimal> density = mass / volume;

            Assert.That(density.KilogramsPerCubicMetre, Is.EqualTo(1000m));
            Assert.That(density.GramsPerCubicCentimetre, Is.EqualTo(1m));
        }

        [Test]
        public void DensityTimesVolumeProducesMass()
        {
            Density<decimal> density = Density<decimal>.FromKilogramsPerCubicMetre(997m);
            Volume<decimal> volume = Volume<decimal>.FromLitres(2m);

            Mass<decimal> mass = density * volume;

            Assert.That(mass.Kilograms, Is.EqualTo(1.994m));
        }

        [Test]
        public void FrequencyCanBeCreatedFromPeriod()
        {
            Time<decimal> period = Time<decimal>.FromMilliseconds(20m);

            Frequency<decimal> frequency = Frequency<decimal>.FromPeriod(period);

            Assert.That(frequency.Hertz, Is.EqualTo(50m));
            Assert.That(frequency.Period.Milliseconds, Is.EqualTo(20m));
        }

        [Test]
        public void CurrentTimesTimeProducesCharge()
        {
            ElectricCurrent<decimal> current = ElectricCurrent<decimal>.FromAmperes(2m);
            Time<decimal> time = Time<decimal>.FromSeconds(15m);

            ElectricCharge<decimal> charge = current * time;

            Assert.That(charge.Coulombs, Is.EqualTo(30m));
        }

        [Test]
        public void VoltageTimesCurrentProducesPower()
        {
            Voltage<decimal> voltage = Voltage<decimal>.FromVolts(230m);
            ElectricCurrent<decimal> current = ElectricCurrent<decimal>.FromAmperes(2m);

            Power<decimal> power = voltage * current;

            Assert.That(power.Watts, Is.EqualTo(460m));
        }

        [Test]
        public void OhmsLawIsDimensionallyTyped()
        {
            Voltage<decimal> voltage = Voltage<decimal>.FromVolts(12m);
            ElectricCurrent<decimal> current = ElectricCurrent<decimal>.FromAmperes(3m);

            Resistance<decimal> resistance = voltage / current;
            ElectricCurrent<decimal> reconstructed = voltage / resistance;

            Assert.That(resistance.Ohms, Is.EqualTo(4m));
            Assert.That(reconstructed.Amperes, Is.EqualTo(3m));
        }
    }
}
