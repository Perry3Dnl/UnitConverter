namespace RealisticPhysics.UnitConversion.Tests
{
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Length;
    using RealisticPhysics.UnitConversion.Mass;
    using RealisticPhysics.UnitConversion.Power;
    using RealisticPhysics.UnitConversion.Temperature;
    using RealisticPhysics.UnitConversion.Speed;
    using RealisticPhysics.UnitConversion.Pressure;
    using RealisticPhysics.UnitConversion.Energy;
    using RealisticPhysics.UnitConversion.Voltage;
    using RealisticPhysics.UnitConversion.Current;

    public sealed class UnitConverterKnownValueTests
    {
        [Test]
        public void Length_Centimeter_To_Millimeter_ReturnsExpectedValue()
        {
            double result = UnitConverterLength.Convert(
                12.5d,
                UnitConverterLengthUnit.Centimeter,
                UnitConverterLengthUnit.Millimeter);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(125d, result);
        }

        [Test]
        public void Length_Foot_To_Meter_ReturnsExpectedValue()
        {
            double result = UnitConverterLength.Convert(
                1d,
                UnitConverterLengthUnit.Foot,
                UnitConverterLengthUnit.Meter);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(0.3048d, result);
        }

        [Test]
        public void Mass_Pound_To_Kilogram_ReturnsExpectedValue()
        {
            double result = UnitConverterMass.Convert(
                1d,
                UnitConverterMassUnit.Pound,
                UnitConverterMassUnit.Kilogram);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(0.45359237d, result);
        }

        [Test]
        public void Power_Kilowatt_To_Watt_ReturnsExpectedValue()
        {
            double result = UnitConverterPower.Convert(
                1d,
                UnitConverterPowerUnit.Kilowatt,
                UnitConverterPowerUnit.Watt);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(1000d, result);
        }

        [Test]
        public void Temperature_Celsius_To_Fahrenheit_ReturnsExpectedValue()
        {
            double result = UnitConverterTemperature.Convert(
                100d,
                UnitConverterTemperatureUnit.Celsius,
                UnitConverterTemperatureUnit.Fahrenheit);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(212d, result);
        }

        [Test]
        public void Speed_MetersPerSecond_To_KilometersPerHour_ReturnsExpectedValue()
        {
            double result = UnitConverterSpeed.Convert(
                1d,
                UnitConverterSpeedUnit.MeterPerSecond,
                UnitConverterSpeedUnit.KilometerPerHour);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(3.6d, result);
        }

        [Test]
        public void Pressure_Bar_To_Pascal_ReturnsExpectedValue()
        {
            double result = UnitConverterPressure.Convert(
                1d,
                UnitConverterPressureUnit.Bar,
                UnitConverterPressureUnit.Pascal);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(100000d, result);
        }

        [Test]
        public void Energy_KilowattHour_To_Joule_ReturnsExpectedValue()
        {
            double result = UnitConverterEnergy.Convert(
                1d,
                UnitConverterEnergyUnit.KilowattHour,
                UnitConverterEnergyUnit.Joule);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(3600000d, result);
        }

        [Test]
        public void Voltage_Kilovolt_To_Volt_ReturnsExpectedValue()
        {
            double result = UnitConverterVoltage.Convert(
                1d,
                UnitConverterVoltageUnit.Kilovolt,
                UnitConverterVoltageUnit.Volt);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(1000d, result);
        }

        [Test]
        public void Current_Milliampere_To_Ampere_ReturnsExpectedValue()
        {
            double result = UnitConverterCurrent.Convert(
                1000d,
                UnitConverterCurrentUnit.Milliampere,
                UnitConverterCurrentUnit.Ampere);

            RealisticPhysicsTestAssert.AreApproximatelyEqual(1d, result);
        }
    }
}
