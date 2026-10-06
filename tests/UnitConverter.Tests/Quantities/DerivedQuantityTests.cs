using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class DerivedQuantityTests
    {
        [Test]
        public void LengthTimesLengthProducesArea()
        {
            Length<decimal> width = Length<decimal>.FromMetres(12m);
            Length<decimal> height = Length<decimal>.FromMetres(5m);

            Area<decimal> area = width * height;

            Assert.That(area.SquareMetres, Is.EqualTo(60m));
        }

        [Test]
        public void AreaTimesLengthProducesVolume()
        {
            Area<decimal> area = Area<decimal>.FromSquareMetres(60m);
            Length<decimal> depth = Length<decimal>.FromMetres(2.5m);

            Volume<decimal> volume = area * depth;

            Assert.That(volume.CubicMetres, Is.EqualTo(150m));
            Assert.That(volume.Litres, Is.EqualTo(150000m));
        }

        [Test]
        public void SpeedDividedByTimeProducesAcceleration()
        {
            Speed<decimal> speed = Speed<decimal>.FromMetresPerSecond(30m);
            Time<decimal> time = Time<decimal>.FromSeconds(6m);

            Acceleration<decimal> acceleration = speed / time;

            Assert.That(acceleration.MetresPerSecondSquared, Is.EqualTo(5m));
        }

        [Test]
        public void MassTimesAccelerationProducesForce()
        {
            Mass<decimal> mass = Mass<decimal>.FromKilograms(12m);
            Acceleration<decimal> acceleration = Acceleration<decimal>.FromMetresPerSecondSquared(3.5m);

            Force<decimal> force = mass * acceleration;

            Assert.That(force.Newtons, Is.EqualTo(42m));
        }

        [Test]
        public void ForceDividedByMassReturnsAcceleration()
        {
            Force<decimal> force = Force<decimal>.FromNewtons(42m);
            Mass<decimal> mass = Mass<decimal>.FromKilograms(12m);

            Acceleration<decimal> acceleration = force / mass;

            Assert.That(acceleration.MetresPerSecondSquared, Is.EqualTo(3.5m));
        }

        [Test]
        public void VolumeAndAreaRecoverLength()
        {
            Volume<decimal> volume = Volume<decimal>.FromCubicMetres(150m);
            Area<decimal> area = Area<decimal>.FromSquareMetres(60m);

            Length<decimal> length = volume / area;

            Assert.That(length.Metres, Is.EqualTo(2.5m));
        }
    }
}
