using NUnit.Framework;
using UnitTools.Quantities;

namespace UnitTools.Tests.Quantities
{
    [TestFixture]
    public sealed class DirectIndirectQuantityParityTests
    {
        [Test]
        public void LengthDirectAndIndirectFactoriesMatch()
        {
            Length<decimal> direct = LengthMethods.FromMiles(2m);
            Length<decimal> indirect = LengthMethods.From(2m, UnitTools.Length.UnitToolsLengthUnit.Mile);

            Assert.That(indirect.Metres, Is.EqualTo(direct.Metres));
            Assert.That(indirect.In(UnitTools.Length.UnitToolsLengthUnit.Kilometer), Is.EqualTo(direct.ToKilometres()));
            Assert.That(
                LengthMethods.Convert(2m, UnitTools.Length.UnitToolsLengthUnit.Mile, UnitTools.Length.UnitToolsLengthUnit.Kilometer),
                Is.EqualTo(direct.ToKilometres()));
        }

        [Test]
        public void PressureDirectAndIndirectRoutesMatch()
        {
            Pressure<decimal> direct = PressureMethods.FromBars(1.5m);
            Pressure<decimal> indirect = PressureMethods.From(1.5m, UnitTools.Pressure.UnitToolsPressureUnit.Bar);

            Assert.That(indirect.Pascals, Is.EqualTo(direct.Pascals));
            Assert.That(
                PressureMethods.Convert(1.5m, UnitTools.Pressure.UnitToolsPressureUnit.Bar, UnitTools.Pressure.UnitToolsPressureUnit.Kilopascal),
                Is.EqualTo(direct.ToKilopascals()));
        }

        [Test]
        public void ElectricalDirectAndIndirectRoutesMatch()
        {
            Voltage<decimal> directVoltage = VoltageMethods.FromVolts(12m);
            Voltage<decimal> indirectVoltage = VoltageMethods.From(12m, UnitTools.Voltage.UnitToolsVoltageUnit.Volt);

            Resistance<decimal> directResistance = ResistanceMethods.FromKiloohms(2m);
            Resistance<decimal> indirectResistance = ResistanceMethods.From(2m, UnitTools.ElectricResistance.UnitToolsElectricResistanceUnit.Kiloohm);

            Assert.That(indirectVoltage.Volts, Is.EqualTo(directVoltage.Volts));
            Assert.That(indirectResistance.Ohms, Is.EqualTo(directResistance.Ohms));
        }

        [Test]
        public void PreviouslyUnsupportedLengthUnitsNowHaveDirectAndIndirectParity()
        {
            Length<decimal> direct = LengthMethods.FromParsec(1m);
            Length<decimal> indirect = LengthMethods.From(1m, UnitTools.Length.UnitToolsLengthUnit.Parsec);

            Assert.That(indirect.Metres, Is.EqualTo(direct.Metres));
            Assert.That(indirect.In(UnitTools.Length.UnitToolsLengthUnit.Parsec), Is.EqualTo(1m));
        }
    }
}
