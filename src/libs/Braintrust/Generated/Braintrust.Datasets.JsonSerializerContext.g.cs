
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object?>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum), TypeInfoPropertyName = "FunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType), TypeInfoPropertyName = "ObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId), TypeInfoPropertyName = "SavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType), TypeInfoPropertyName = "SavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType), TypeInfoPropertyName = "SavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchEventsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchemaStatus), TypeInfoPropertyName = "FeedbackResponseSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEventClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchDatasetEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource), TypeInfoPropertyName = "FeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DataSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SummarizeDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum?), TypeInfoPropertyName = "NullableFunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType?), TypeInfoPropertyName = "NullableObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId?), TypeInfoPropertyName = "NullableSavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchemaStatus?), TypeInfoPropertyName = "NullableFeedbackResponseSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource?), TypeInfoPropertyName = "NullableFeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.DatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Dataset>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Braintrust.JsonConverters.IdsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Braintrust.FunctionTypeEnum)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus)

                    || typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus))
                {
                    return new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}