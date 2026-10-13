using NUnit.Framework;
using UnitTools.Quantities;

namespace UnitTools.Tests.Quantities
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
        public void ExistingDimensionalRelationsHaveUsefulInverseOperators()
        {
            Length<decimal> distance = Length<decimal>.FromMetres(120m);
            Time<decimal> duration = Time<decimal>.FromSeconds(10m);
            Speed<decimal> speed = distance / duration;

            Assert.That((distance / speed).Seconds, Is.EqualTo(duration.Seconds));

            Acceleration<decimal> acceleration =
                Acceleration<decimal>.FromMetresPerSecondSquared(3m);
            Assert.That((speed / acceleration).Seconds, Is.EqualTo(4m));

            Force<decimal> force = Force<decimal>.FromNewtons(240m);
            Length<decimal> arm = Length<decimal>.FromMetres(2m);
            Energy<decimal> energy = force * arm;

            Assert.That((energy / force).Metres, Is.EqualTo(arm.Metres));
            Assert.That((energy / arm).Newtons, Is.EqualTo(force.Newtons));

            Power<decimal> power = Power<decimal>.FromWatts(24m);
            Energy<decimal> timedEnergy = power * duration;
            Assert.That((timedEnergy / power).Seconds, Is.EqualTo(duration.Seconds));

            Area<decimal> area = Area<decimal>.FromSquareMetres(3m);
            Pressure<decimal> pressure = Pressure<decimal>.FromPascals(80m);
            Force<decimal> pressureForce = pressure * area;

            Assert.That((pressureForce / pressure).SquareMetres, Is.EqualTo(area.SquareMetres));
            Assert.That((area * pressure).Newtons, Is.EqualTo(pressureForce.Newtons));
        }

        [Test]
        public void MassDensityAndMechanicalRelationsRoundTrip()
        {
            Mass<decimal> mass = Mass<decimal>.FromKilograms(12m);
            Volume<decimal> volume = Volume<decimal>.FromCubicMetres(3m);
            Density<decimal> density = mass / volume;

            Assert.That((mass / density).CubicMetres, Is.EqualTo(volume.CubicMetres));

            Length<decimal> displacement = Length<decimal>.FromMetres(2m);
            Force<decimal> springForce = Force<decimal>.FromNewtons(30m);
            SpringConstant<decimal> spring = springForce / displacement;
            Assert.That((spring * displacement).Newtons, Is.EqualTo(springForce.Newtons));

            Speed<decimal> speed = Speed<decimal>.FromMetresPerSecond(5m);
            Force<decimal> dampingForce = Force<decimal>.FromNewtons(20m);
            DampingCoefficient<decimal> damping = dampingForce / speed;
            Assert.That((damping * speed).Newtons, Is.EqualTo(dampingForce.Newtons));

            MechanicalMobility<decimal> mobility = speed / dampingForce;
            Assert.That((mobility * dampingForce).MetresPerSecond, Is.EqualTo(speed.MetresPerSecond));
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