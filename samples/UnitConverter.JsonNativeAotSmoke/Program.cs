using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using UnitConverter;
using UnitConverter.Length;
using UnitConverter.SystemTextJson;

public static class Program
{
    public static void Main()
    {
        var options = new JsonSerializerOptions();
        options.AddUnitConverter<UnitConverterLengthUnit>();

        var context = new AppJsonContext(options);
        JsonTypeInfo<UnitValue<UnitConverterLengthUnit>> typeInfo =
            (JsonTypeInfo<UnitValue<UnitConverterLengthUnit>>)context.GetTypeInfo(
                typeof(UnitValue<UnitConverterLengthUnit>));

        var value =
            new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

        string json = JsonSerializer.Serialize(value, typeInfo);
        UnitValue<UnitConverterLengthUnit> restored =
            JsonSerializer.Deserialize(json, typeInfo);

        if (!restored.Equals(value))
        {
            throw new InvalidOperationException(
                "NativeAOT JSON round-trip failed.");
        }
    }
}

[JsonSerializable(typeof(UnitValue<UnitConverterLengthUnit>))]
internal partial class AppJsonContext : JsonSerializerContext
{
}
