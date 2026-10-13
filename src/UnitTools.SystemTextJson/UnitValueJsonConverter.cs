namespace UnitTools.SystemTextJson
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using UnitTools.Catalog;

    /// <summary>
    /// Registers UnitTools JSON converters on <see cref="JsonSerializerOptions"/>.
    /// </summary>
    public static class UnitToolsJson
    {
        /// <summary>
        /// Registers JSON support for a specific UnitValue unit enum.
        /// </summary>
        public static JsonSerializerOptions AddUnitTools<TUnit>(
            this JsonSerializerOptions options)
            where TUnit : struct
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            foreach (JsonConverter converter in options.Converters)
            {
                if (converter is UnitValueJsonConverter<TUnit>)
                {
                    return options;
                }
            }

            options.Converters.Add(new UnitValueJsonConverter<TUnit>());
            return options;
        }

        /// <summary>
        /// Registers the UnitValue converter factory for all catalog unit enum types.
        /// </summary>
        public static JsonSerializerOptions AddUnitTools(
            this JsonSerializerOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            foreach (JsonConverter converter in options.Converters)
            {
                if (converter is UnitValueJsonConverterFactory)
                {
                    return options;
                }
            }

            options.Converters.Add(new UnitValueJsonConverterFactory());
            return options;
        }
    }

    /// <summary>
    /// Creates System.Text.Json converters for UnitValue&lt;TUnit&gt; values.
    /// </summary>
    public sealed class UnitValueJsonConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsGenericType &&
                typeToConvert.GetGenericTypeDefinition() == typeof(UnitValue<>);
        }

        public override JsonConverter CreateConverter(
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            Type unitType = typeToConvert.GetGenericArguments()[0];
            Type converterType =
                typeof(UnitValueJsonConverter<>).MakeGenericType(unitType);

            return (JsonConverter)Activator.CreateInstance(converterType);
        }
    }

    /// <summary>
    /// Serializes UnitValue values using a numeric value and stable catalog unit name.
    /// </summary>
    public sealed class UnitValueJsonConverter<TUnit>
        : JsonConverter<UnitValue<TUnit>>
        where TUnit : struct
    {
        public override UnitValue<TUnit> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected an object for a UnitValue.");
            }

            double value = 0d;
            bool hasValue = false;
            string unitText = null;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("Expected a property name.");
                }

                string propertyName = reader.GetString();
                if (!reader.Read())
                {
                    throw new JsonException("Unexpected end of JSON.");
                }

                if (string.Equals(
                    propertyName,
                    "value",
                    StringComparison.OrdinalIgnoreCase))
                {
                    if (reader.TokenType != JsonTokenType.Number ||
                        !reader.TryGetDouble(out value))
                    {
                        throw new JsonException(
                            "The 'value' property must be a finite JSON number representable as Double.");
                    }

                    hasValue = true;
                }
                else if (string.Equals(
                    propertyName,
                    "unit",
                    StringComparison.OrdinalIgnoreCase))
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException(
                            "The 'unit' property must be a string.");
                    }

                    unitText = reader.GetString();
                }
                else
                {
                    reader.Skip();
                }
            }

            if (!hasValue)
            {
                throw new JsonException("The 'value' property is required.");
            }

            if (string.IsNullOrWhiteSpace(unitText))
            {
                throw new JsonException("The 'unit' property is required.");
            }

            UnitToolsFamilyDescriptor<TUnit> descriptor;
            if (!UnitToolsCatalog.TryGetFamily(out descriptor))
            {
                throw new JsonException(
                    "No unit family descriptor is registered for " +
                    typeof(TUnit).FullName + ".");
            }

            TUnit unit = default(TUnit);
            bool resolvedStableName = false;

            foreach (UnitToolsUnitDescriptor candidate in descriptor.Units)
            {
                if (string.Equals(
                    candidate.Name,
                    unitText,
                    StringComparison.Ordinal))
                {
                    unit = (TUnit)candidate.Unit;
                    resolvedStableName = true;
                    break;
                }
            }

            if (!resolvedStableName)
            {
                UnitToolsUnitResolution resolution =
                    descriptor.ResolveUnit(unitText, out unit);

                if (resolution == UnitToolsUnitResolution.Ambiguous)
                {
                    throw new JsonException(
                        "The unit '" + unitText + "' is ambiguous.");
                }

                if (resolution != UnitToolsUnitResolution.Resolved)
                {
                    throw new JsonException(
                        "The unit '" + unitText + "' is not recognized for " +
                        descriptor.Name + ".");
                }
            }

            return new UnitValue<TUnit>(value, unit);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UnitValue<TUnit> value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("value", value.Value);
            writer.WriteString("unit", value.Unit.ToString());
            writer.WriteEndObject();
        }
    }
}
