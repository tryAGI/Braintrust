#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class SavedPreprocessorIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.SavedPreprocessorId>
    {
        /// <inheritdoc />
        public override global::Braintrust.SavedPreprocessorId Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("function_type")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Braintrust.SavedPreprocessorIdFunction? function = default;
            global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? preprocessorGlobal = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdFunction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdFunction).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal).Name}");
                        preprocessorGlobal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (function == null && preprocessorGlobal == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdFunction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdFunction).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (function == null && preprocessorGlobal == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal).Name}");
                    preprocessorGlobal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Braintrust.SavedPreprocessorId(
                function,

                preprocessorGlobal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.SavedPreprocessorId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunction(), typeInfo);
            }
            else if (value.IsPreprocessorGlobal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPreprocessorGlobal(), typeInfo);
            }
        }
    }
}