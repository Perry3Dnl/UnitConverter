using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class DirectIndirectQuantityParityTests
    {
        [Test]
        public void LengthDirectAndIndirectFactoriesMatch()
        {
            Length<decimal> direct = LengthMethods.FromMiles(2m);
            Length<decimal> indirect = LengthMethods.From(2m, UnitConverter.Length.UnitConverterLengthUnit.Mile);

            Assert.That(indirect.Metres, Is.EqualTo(direct.Metres));
            Assert.That(indirect.In(UnitConverter.Length.UnitConverterLengthUnit.Kilometer), Is.EqualTo(direct.ToKilometres()));
            Assert.That(
                LengthMethods.Convert(2m, UnitConverter.Length.UnitConverterLengthUnit.Mile, UnitConverter.Length.UnitConverterLengthUnit.Kilometer),
                Is.EqualTo(direct.ToKilometres()));
        }

        [Test]
        public void PressureDirectAndIndirectRoutesMatch()
        {
            Pressure<decimal> direct = PressureMethods.FromBars(1.5m);
            Pressure<decimal> indirect = PressureMethods.From(1.5m, UnitConverter.Pressure.UnitConverterPressureUnit.Bar);

            Assert.That(indirect.Pascals, Is.EqualTo(direct.Pascals));
            Assert.That(
                PressureMethods.Convert(1.5m, UnitConverter.Pressure.UnitConverterPressureUnit.Bar, UnitConverter.Pressure.UnitConverterPressureUnit.Kilopascal),
                Is.EqualTo(direct.ToKilopascals()));
        }

        [Test]
        public void ElectricalDirectAndIndirectRoutesMatch()
        {
            Voltage<decimal> directVoltage = VoltageMethods.FromVolts(12m);
            Voltage<decimal> indirectVoltage = VoltageMethods.From(12m, UnitConverter.Voltage.UnitConverterVoltageUnit.Volt);

            Resistance<decimal> directResistance = ResistanceMethods.FromKiloohms(2m);
            Resistance<decimal> indirectResistance = ResistanceMethods.From(2m, UnitConverter.ElectricResistance.UnitConverterElectricResistanceUnit.Kiloohm);

            Assert.That(indirectVoltage.Volts, Is.EqualTo(directVoltage.Volts));
            Assert.That(indirectResistance.Ohms, Is.EqualTo(directResistance.Ohms));
        }

        [Test]
        public void UnsupportedRuntimeUnitIsRejectedInsteadOfSilentlyChangingSemantics()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() =>
                LengthMethods.From(1m, UnitConverter.Length.UnitConverterLengthUnit.Parsec));
        }
    }
}
