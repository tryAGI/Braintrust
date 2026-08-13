#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class FacetPreprocessorIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.FacetPreprocessorId>
    {
        /// <inheritdoc />
        public override global::Braintrust.FacetPreprocessorId Read(
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

            global::Braintrust.FacetPreprocessorIdFunction? function = default;
            global::Braintrust.FacetPreprocessorIdGlobal? global = default;
            global::Braintrust.FacetPreprocessorIdPreprocessorInline? preprocessorInline = default;
            object? facetPreprocessorIdVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdFunction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdFunction).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdGlobal> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdGlobal).Name}");
                        global = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdPreprocessorInline> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline).Name}");
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
                        facetPreprocessorIdVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && global == null && preprocessorInline == null && facetPreprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdFunction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdFunction).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && global == null && preprocessorInline == null && facetPreprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdGlobal> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdGlobal).Name}");
                    global = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && global == null && preprocessorInline == null && facetPreprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdPreprocessorInline> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline).Name}");
                    preprocessorInline = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (function == null && global == null && preprocessorInline == null && facetPreprocessorIdVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    facetPreprocessorIdVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Braintrust.FacetPreprocessorId(
                function,

                global,

                preprocessorInline,

                facetPreprocessorIdVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.FacetPreprocessorId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsGlobal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdGlobal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdGlobal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Global!, typeInfo);
            }
            else if (value.IsPreprocessorInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetPreprocessorIdPreprocessorInline?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreprocessorInline!, typeInfo);
            }
            else if (value.IsFacetPreprocessorIdVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FacetPreprocessorIdVariant4!, typeInfo);
            }
        }
    }
}