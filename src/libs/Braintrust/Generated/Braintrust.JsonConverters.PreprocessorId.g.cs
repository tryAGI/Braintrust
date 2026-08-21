#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class PreprocessorIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.PreprocessorId>
    {
        /// <inheritdoc />
        public override global::Braintrust.PreprocessorId Read(
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
            var __score2 = 0;
            if (__jsonProps.Contains("code")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Braintrust.PreprocessorIdFunction? function = default;
            global::Braintrust.PreprocessorIdPreprocessorGlobal? preprocessorGlobal = default;
            global::Braintrust.PreprocessorIdPreprocessorInline? preprocessorInline = default;
            object? preprocessorIdVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdFunction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdFunction).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorGlobal> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal).Name}");
                        preprocessorGlobal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorInline> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorInline).Name}");
                        preprocessorInline = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        preprocessorIdVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && preprocessorGlobal == null && preprocessorInline == null && preprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdFunction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdFunction).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && preprocessorGlobal == null && preprocessorInline == null && preprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorGlobal> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal).Name}");
                    preprocessorGlobal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && preprocessorGlobal == null && preprocessorInline == null && preprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorInline> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorInline).Name}");
                    preprocessorInline = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && preprocessorGlobal == null && preprocessorInline == null && preprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    preprocessorIdVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Braintrust.PreprocessorId(
                function,

                preprocessorGlobal,

                preprocessorInline,

                preprocessorIdVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.PreprocessorId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsPreprocessorGlobal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorGlobal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreprocessorGlobal!, typeInfo);
            }
            else if (value.IsPreprocessorInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.PreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.PreprocessorIdPreprocessorInline?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.PreprocessorIdPreprocessorInline).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreprocessorInline!, typeInfo);
            }
            else if (value.IsPreprocessorIdVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreprocessorIdVariant4!, typeInfo);
            }
        }
    }
}