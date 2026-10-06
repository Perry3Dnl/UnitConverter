using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class GeneratedQuantityMethodTests
    {
        [Test]
        public void GeneratedLengthMethodsRemainExplicitAndStronglyTyped()
        {
            Length<decimal> length = LengthMethods.FromKilometres(1.25m);

            Assert.That(length.ToMetres(), Is.EqualTo(1250m));
            Assert.That(length.ToKilometres(), Is.EqualTo(1.25m));
        }

        [Test]
        public void GeneratedMassMethodsRemainExplicitAndStronglyTyped()
        {
            Mass<decimal> mass = MassMethods.FromGrams(2500m);

            Assert.That(mass.ToKilograms(), Is.EqualTo(2.5m));
            Assert.That(mass.ToGrams(), Is.EqualTo(2500m));
        }

        [Test]
        public void GeneratedPressureMethodsExposeEveryDeclaredUnit()
        {
            Pressure<decimal> pressure = PressureMethods.FromBars(1.5m);

            Assert.That(pressure.ToPascals(), Is.EqualTo(150000m));
            Assert.That(pressure.ToKilopascals(), Is.EqualTo(150m));
            Assert.That(pressure.ToBars(), Is.EqualTo(1.5m));
        }
    }
}
