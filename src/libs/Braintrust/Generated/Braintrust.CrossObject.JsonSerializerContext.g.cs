
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanType), TypeInfoPropertyName = "SpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesPurpose), TypeInfoPropertyName = "SpanAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesLogLevel), TypeInfoPropertyName = "SpanAttributesLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType), TypeInfoPropertyName = "ObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItemSource), TypeInfoPropertyName = "FeedbackProjectLogsItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItemSource), TypeInfoPropertyName = "FeedbackExperimentItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource), TypeInfoPropertyName = "FeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestExperiment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestDataset2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestProjectLogs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanType?), TypeInfoPropertyName = "NullableSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesPurpose?), TypeInfoPropertyName = "NullableSpanAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesLogLevel?), TypeInfoPropertyName = "NullableSpanAttributesLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType?), TypeInfoPropertyName = "NullableObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItemSource?), TypeInfoPropertyName = "NullableFeedbackProjectLogsItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItemSource?), TypeInfoPropertyName = "NullableFeedbackExperimentItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource?), TypeInfoPropertyName = "NullableFeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackProjectLogsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>))]
    internal sealed partial class CrossObjectSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CrossObjectSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CrossObjectSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CrossObjectSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>());
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
                    typeToConvert == typeof(global::Braintrust.SpanType)

                    || typeToConvert == typeof(global::Braintrust.SpanType?)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose?)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesLogLevel)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesLogLevel?)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.SpanType))
                {
                    return new global::Braintrust.JsonConverters.SpanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanType?))
                {
                    return new global::Braintrust.JsonConverters.SpanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose?))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesLogLevel))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesLogLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesLogLevel?))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesLogLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter();
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
                    0 => new CrossObjectSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}