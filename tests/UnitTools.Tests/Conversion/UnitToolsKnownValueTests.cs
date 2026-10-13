namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Length;
    using UnitTools.Mass;
    using UnitTools.Power;
    using UnitTools.Temperature;
    using UnitTools.Speed;
    using UnitTools.Pressure;
    using UnitTools.Energy;
    using UnitTools.Voltage;
    using UnitTools.Current;

    public sealed class UnitToolsKnownValueTests
    {
        [Test]
        public void Length_Centimeter_To_Millimeter_ReturnsExpectedValue()
        {
            double result = UnitToolsLength.Convert(
                12.5d,
                UnitToolsLengthUnit.Centimeter,
                UnitToolsLengthUnit.Millimeter);

            UnitToolsTestAssert.AreApproximatelyEqual(125d, result);
        }

        [Test]
        public void Length_Foot_To_Meter_ReturnsExpectedValue()
        {
            double result = UnitToolsLength.Convert(
                1d,
                UnitToolsLengthUnit.Foot,
                UnitToolsLengthUnit.Meter);

            UnitToolsTestAssert.AreApproximatelyEqual(0.3048d, result);
        }

        [Test]
        public void Mass_Pound_To_Kilogram_ReturnsExpectedValue()
        {
            double result = UnitToolsMass.Convert(
                1d,
                UnitToolsMassUnit.Pound,
                UnitToolsMassUnit.Kilogram);

            UnitToolsTestAssert.AreApproximatelyEqual(0.45359237d, result);
        }

        [Test]
        public void Power_Kilowatt_To_Watt_ReturnsExpectedValue()
        {
            double result = UnitToolsPower.Convert(
                1d,
                UnitToolsPowerUnit.Kilowatt,
                UnitToolsPowerUnit.Watt);

            UnitToolsTestAssert.AreApproximatelyEqual(1000d, result);
        }

        [Test]
        public void Temperature_Celsius_To_Fahrenheit_ReturnsExpectedValue()
        {
            double result = UnitToolsTemperature.Convert(
                100d,
                UnitToolsTemperatureUnit.Celsius,
                UnitToolsTemperatureUnit.Fahrenheit);

            UnitToolsTestAssert.AreApproximatelyEqual(212d, result);
        }

        [Test]
        public void Speed_MetersPerSecond_To_KilometersPerHour_ReturnsExpectedValue()
        {
            double result = UnitToolsSpeed.Convert(
                1d,
                UnitToolsSpeedUnit.MeterPerSecond,
                UnitToolsSpeedUnit.KilometerPerHour);

            UnitToolsTestAssert.AreApproximatelyEqual(3.6d, result);
        }

        [Test]
        public void Pressure_Bar_To_Pascal_ReturnsExpectedValue()
        {
            double result = UnitToolsPressure.Convert(
                1d,
                UnitToolsPressureUnit.Bar,
                UnitToolsPressureUnit.Pascal);

            UnitToolsTestAssert.AreApproximatelyEqual(100000d, result);
        }

        [Test]
        public void Energy_KilowattHour_To_Joule_ReturnsExpectedValue()
        {
            double result = UnitToolsEnergy.Convert(
                1d,
                UnitToolsEnergyUnit.KilowattHour,
                UnitToolsEnergyUnit.Joule);

            UnitToolsTestAssert.AreApproximatelyEqual(3600000d, result);
        }

        [Test]
        public void Voltage_Kilovolt_To_Volt_ReturnsExpectedValue()
        {
            double result = UnitToolsVoltage.Convert(
                1d,
                UnitToolsVoltageUnit.Kilovolt,
                UnitToolsVoltageUnit.Volt);

            UnitToolsTestAssert.AreApproximatelyEqual(1000d, result);
        }

        [Test]
        public void Current_Milliampere_To_Ampere_ReturnsExpectedValue()
        {
            double result = UnitToolsCurrent.Convert(
                1000d,
                UnitToolsCurrentUnit.Milliampere,
                UnitToolsCurrentUnit.Ampere);

            UnitToolsTestAssert.AreApproximatelyEqual(1d, result);
        }
    }
}
