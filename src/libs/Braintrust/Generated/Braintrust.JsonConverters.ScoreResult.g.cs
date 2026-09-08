#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public class ScoreResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ScoreResult>
    {
        /// <inheritdoc />
        public override global::Braintrust.ScoreResult Read(
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
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("score")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("score")) __score1++;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Braintrust.ScoreObject? objectValue = default;
            global::Braintrust.NamedScore? named = default;
            global::Braintrust.AnyOf<double?, bool?>? scoreResultVariant3 = default;
            global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? scoreResultVariant4 = default;
            object? scoreResultVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.ScoreObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.ScoreObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.ScoreObject).Name}");
                        objectValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.NamedScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.NamedScore> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.NamedScore).Name}");
                        named = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AnyOf<double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AnyOf<double?, bool?>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AnyOf<double?, bool?>).Name}");
                        scoreResultVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>).Name}");
                        scoreResultVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        scoreResultVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (objectValue == null && named == null && scoreResultVariant3 == null && scoreResultVariant4 == null && scoreResultVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.ScoreObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.ScoreObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.ScoreObject).Name}");
                    objectValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (objectValue == null && named == null && scoreResultVariant3 == null && scoreResultVariant4 == null && scoreResultVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.NamedScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.NamedScore> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.NamedScore).Name}");
                    named = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (objectValue == null && named == null && scoreResultVariant3 == null && scoreResultVariant4 == null && scoreResultVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AnyOf<double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AnyOf<double?, bool?>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AnyOf<double?, bool?>).Name}");
                    scoreResultVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (objectValue == null && named == null && scoreResultVariant3 == null && scoreResultVariant4 == null && scoreResultVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>).Name}");
                    scoreResultVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (objectValue == null && named == null && scoreResultVariant3 == null && scoreResultVariant4 == null && scoreResultVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    scoreResultVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Braintrust.ScoreResult(
                objectValue,

                named,

                scoreResultVariant3,

                scoreResultVariant4,

                scoreResultVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ScoreResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.ScoreObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.ScoreObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.ScoreObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!, typeInfo);
            }
            else if (value.IsNamed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.NamedScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.NamedScore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.NamedScore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Named!, typeInfo);
            }
            else if (value.IsScoreResultVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Braintrust.AnyOf<double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Braintrust.AnyOf<double?, bool?>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Braintrust.AnyOf<double?, bool?>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreResultVariant3!.Value, typeInfo);
            }
            else if (value.IsScoreResultVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreResultVariant4!, typeInfo);
            }
            else if (value.IsScoreResultVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreResultVariant5!, typeInfo);
            }
        }
    }
}