#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class GraphNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.GraphNode>
    {
        /// <inheritdoc />
        public override global::Braintrust.GraphNode Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("function")) __score0++;
            if (__jsonProps.Contains("position")) __score0++;
            if (__jsonProps.Contains("position.x")) __score0++;
            if (__jsonProps.Contains("position.y")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("position")) __score1++;
            if (__jsonProps.Contains("position.x")) __score1++;
            if (__jsonProps.Contains("position.y")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("position")) __score2++;
            if (__jsonProps.Contains("position.x")) __score2++;
            if (__jsonProps.Contains("position.y")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("position")) __score3++;
            if (__jsonProps.Contains("position.x")) __score3++;
            if (__jsonProps.Contains("position.y")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("expr")) __score4++;
            if (__jsonProps.Contains("position")) __score4++;
            if (__jsonProps.Contains("position.x")) __score4++;
            if (__jsonProps.Contains("position.y")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("condition")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("position")) __score5++;
            if (__jsonProps.Contains("position.x")) __score5++;
            if (__jsonProps.Contains("position.y")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("position")) __score6++;
            if (__jsonProps.Contains("position.x")) __score6++;
            if (__jsonProps.Contains("position.y")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("position")) __score7++;
            if (__jsonProps.Contains("position.x")) __score7++;
            if (__jsonProps.Contains("position.y")) __score7++;
            if (__jsonProps.Contains("prompt")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
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

            global::Braintrust.GraphNodeVariant1? graphNodeVariant1 = default;
            global::Braintrust.GraphNodeVariant2? graphNodeVariant2 = default;
            global::Braintrust.GraphNodeVariant3? graphNodeVariant3 = default;
            global::Braintrust.GraphNodeVariant4? graphNodeVariant4 = default;
            global::Braintrust.GraphNodeVariant5? graphNodeVariant5 = default;
            global::Braintrust.GraphNodeVariant6? graphNodeVariant6 = default;
            global::Braintrust.GraphNodeVariant7? graphNodeVariant7 = default;
            global::Braintrust.GraphNodeVariant8? graphNodeVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant1).Name}");
                        graphNodeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant2).Name}");
                        graphNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant3).Name}");
                        graphNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant4).Name}");
                        graphNodeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant5).Name}");
                        graphNodeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant6).Name}");
                        graphNodeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant7).Name}");
                        graphNodeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant8).Name}");
                        graphNodeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (graphNodeVariant1 == null && graphNodeVariant2 == null && graphNodeVariant3 == null && graphNodeVariant4 == null && graphNodeVariant5 == null && graphNodeVariant6 == null && graphNodeVariant7 == null && graphNodeVariant8 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant1).Name}");
                    graphNodeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant2).Name}");
                    graphNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant3).Name}");
                    graphNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant4).Name}");
                    graphNodeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant5).Name}");
                    graphNodeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant6).Name}");
                    graphNodeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant7).Name}");
                    graphNodeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant8).Name}");
                    graphNodeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Braintrust.GraphNode(
                graphNodeVariant1,

                graphNodeVariant2,

                graphNodeVariant3,

                graphNodeVariant4,

                graphNodeVariant5,

                graphNodeVariant6,

                graphNodeVariant7,

                graphNodeVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.GraphNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGraphNodeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant1!, typeInfo);
            }
            else if (value.IsGraphNodeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant2!, typeInfo);
            }
            else if (value.IsGraphNodeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant3!, typeInfo);
            }
            else if (value.IsGraphNodeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant4!, typeInfo);
            }
            else if (value.IsGraphNodeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant5!, typeInfo);
            }
            else if (value.IsGraphNodeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant6!, typeInfo);
            }
            else if (value.IsGraphNodeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant7!, typeInfo);
            }
            else if (value.IsGraphNodeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.GraphNodeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.GraphNodeVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.GraphNodeVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GraphNodeVariant8!, typeInfo);
            }
        }
    }
}