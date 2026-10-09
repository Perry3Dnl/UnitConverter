namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;
    using System.Text.Json;
    using UnitConverter.Catalog;
    using UnitConverter.Length;
    using UnitConverter.SystemTextJson;
    using UnitConverter.Temperature;

    public sealed class UnitConverterJsonTests
    {
        private static JsonSerializerOptions CreateOptions()
        {
            return new JsonSerializerOptions().AddUnitConverter();
        }

        [Test]
        public void UnitValue_RoundTrips()
        {
            var value = new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

            JsonSerializerOptions options = CreateOptions();
            string json = JsonSerializer.Serialize(value, options);
            UnitValue<UnitConverterLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    options);

            Assert.That(restored, Is.EqualTo(value));
            Assert.That(json, Does.Contain("\"value\":1.8"));
            Assert.That(json, Does.Contain("\"unit\":\"Kilometer\""));
        }

        [Test]
        public void UnitValue_Deserializer_AcceptsAliases()
        {
            const string json = "{\"value\":2,\"unit\":\"km\"}";

            UnitValue<UnitConverterLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(2d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void UnitValue_Deserializer_IsCaseInsensitiveForPropertyNames()
        {
            const string json = "{\"VALUE\":20,\"UNIT\":\"Celsius\"}";

            UnitValue<UnitConverterTemperatureUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterTemperatureUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(20d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitConverterTemperatureUnit.Celsius));
        }

        [Test]
        public void UnitValue_Deserializer_RejectsUnknownUnit()
        {
            const string json = "{\"value\":2,\"unit\":\"not-a-length\"}";

            Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    CreateOptions()));
        }

        [Test]
        public void EveryCatalogUnit_RoundTripsWithStableEnumName()
        {
            JsonSerializerOptions options = CreateOptions();

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                Type unitValueType = typeof(UnitValue<>).MakeGenericType(family.UnitType);
                ConstructorInfo constructor = unitValueType.GetConstructor(
                    new[] { typeof(double), family.UnitType });

                Assert.That(constructor, Is.Not.Null, family.Name);

                PropertyInfo valueProperty = unitValueType.GetProperty("Value");
                PropertyInfo unitProperty = unitValueType.GetProperty("Unit");

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object original = constructor.Invoke(new[] { (object)1.25d, unit.Unit });
                    string json = JsonSerializer.Serialize(original, unitValueType, options);
                    object restored = JsonSerializer.Deserialize(json, unitValueType, options);

                    string context = family.Name + "." + unit.Name;
                    Assert.That(restored, Is.Not.Null, context);
                    Assert.That(
                        (double)valueProperty.GetValue(restored),
                        Is.EqualTo(1.25d),
                        context);
                    Assert.That(
                        unitProperty.GetValue(restored),
                        Is.EqualTo(unit.Unit),
                        context);
                    Assert.That(
                        json,
                        Does.Contain("\"unit\":\"" + unit.Name + "\""),
                        context);
                }
            }
        }

        [Test]
        public void EveryCatalogSymbol_IsAcceptedAsJsonInputWhenUnambiguous()
        {
            JsonSerializerOptions options = CreateOptions();

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                Type unitValueType = typeof(UnitValue<>).MakeGenericType(family.UnitType);
                PropertyInfo unitProperty = unitValueType.GetProperty("Unit");

                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object resolved;
                    if (family.ResolveUnit(unit.Symbol, out resolved) !=
                        UnitConverterUnitResolution.Resolved)
                    {
                        continue;
                    }

                    string json =
                        "{\"value\":2.5,\"unit\":" +
                        JsonSerializer.Serialize(unit.Symbol) +
                        "}";

                    object restored =
                        JsonSerializer.Deserialize(json, unitValueType, options);

                    Assert.That(
                        unitProperty.GetValue(restored),
                        Is.EqualTo(unit.Unit),
                        family.Name + "." + unit.Name);
                }
            }
        }

        [Test]
        public void AddUnitConverter_IsIdempotent()
        {
            var options = new JsonSerializerOptions();

            options.AddUnitConverter();
            options.AddUnitConverter();

            int count = 0;
            foreach (System.Text.Json.Serialization.JsonConverter converter in
                options.Converters)
            {
                if (converter is UnitValueJsonConverterFactory)
                {
                    count++;
                }
            }

            Assert.That(count, Is.EqualTo(1));
        }
    }
}