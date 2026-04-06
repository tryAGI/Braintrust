#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class FunctionDataNullishJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.FunctionDataNullish>
    {
        /// <inheritdoc />
        public override global::Braintrust.FunctionDataNullish Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("edges")) __score2++;
            if (__jsonProps.Contains("nodes")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("endpoint")) __score3++;
            if (__jsonProps.Contains("eval_name")) __score3++;
            if (__jsonProps.Contains("parameters")) __score3++;
            if (__jsonProps.Contains("parameters_version")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("config")) __score4++;
            if (__jsonProps.Contains("function_type")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("embedding_model")) __score5++;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("no_match_pattern")) __score5++;
            if (__jsonProps.Contains("preprocessor")) __score5++;
            if (__jsonProps.Contains("prompt")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("facets")) __score6++;
            if (__jsonProps.Contains("preprocessor")) __score6++;
            if (__jsonProps.Contains("topic_maps")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("__schema")) __score7++;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            var __score9 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::Braintrust.FunctionDataNullishPrompt? prompt = default;
            global::Braintrust.FunctionDataNullishCode? code = default;
            global::Braintrust.GraphData? graph = default;
            global::Braintrust.FunctionDataNullishRemoteEval? remoteEval = default;
            global::Braintrust.FunctionDataNullishGlobal? global = default;
            global::Braintrust.FacetData? facet = default;
            global::Braintrust.BatchedFacetData? batchedFacet = default;
            global::Braintrust.FunctionDataNullishParameters? parameters = default;
            global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? functionDataNullishVariant9 = default;
            object? functionDataNullishVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishPrompt> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishPrompt).Name}");
                        prompt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishCode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishCode).Name}");
                        code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphData).Name}");
                        graph = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishRemoteEval), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishRemoteEval> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishRemoteEval).Name}");
                        remoteEval = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishGlobal> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishGlobal).Name}");
                        global = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetData).Name}");
                        facet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.BatchedFacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.BatchedFacetData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.BatchedFacetData).Name}");
                        batchedFacet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishParameters> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishParameters).Name}");
                        parameters = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>).Name}");
                        functionDataNullishVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        functionDataNullishVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (prompt == null && code == null && graph == null && remoteEval == null && global == null && facet == null && batchedFacet == null && parameters == null && functionDataNullishVariant9 == null && functionDataNullishVariant10 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishPrompt> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishPrompt).Name}");
                    prompt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishCode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishCode).Name}");
                    code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphData).Name}");
                    graph = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishRemoteEval), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishRemoteEval> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishRemoteEval).Name}");
                    remoteEval = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishGlobal> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishGlobal).Name}");
                    global = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetData).Name}");
                    facet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.BatchedFacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.BatchedFacetData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.BatchedFacetData).Name}");
                    batchedFacet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishParameters> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishParameters).Name}");
                    parameters = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>).Name}");
                    functionDataNullishVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    functionDataNullishVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Braintrust.FunctionDataNullish(
                prompt,

                code,

                graph,

                remoteEval,

                global,

                facet,

                batchedFacet,

                parameters,

                functionDataNullishVariant9,

                functionDataNullishVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.FunctionDataNullish value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPrompt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Prompt!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsGraph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Graph!, typeInfo);
            }
            else if (value.IsRemoteEval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishRemoteEval), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishRemoteEval?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishRemoteEval).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemoteEval!, typeInfo);
            }
            else if (value.IsGlobal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishGlobal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishGlobal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishGlobal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Global!, typeInfo);
            }
            else if (value.IsFacet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FacetData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FacetData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Facet!, typeInfo);
            }
            else if (value.IsBatchedFacet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.BatchedFacetData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.BatchedFacetData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.BatchedFacetData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BatchedFacet!, typeInfo);
            }
            else if (value.IsParameters)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.FunctionDataNullishParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.FunctionDataNullishParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.FunctionDataNullishParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Parameters!, typeInfo);
            }
            else if (value.IsFunctionDataNullishVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionDataNullishVariant9!.Value, typeInfo);
            }
            else if (value.IsFunctionDataNullishVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionDataNullishVariant10!, typeInfo);
            }
        }
    }
}