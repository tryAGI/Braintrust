
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType), TypeInfoPropertyName = "EnvVarObjectType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType2), TypeInfoPropertyName = "EnvVarObjectType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarSecretCategory), TypeInfoPropertyName = "EnvVarSecretCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequestObjectType), TypeInfoPropertyName = "PostEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequestObjectType), TypeInfoPropertyName = "PutEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchEnvVarIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType?), TypeInfoPropertyName = "NullableEnvVarObjectType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType2?), TypeInfoPropertyName = "NullableEnvVarObjectType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarSecretCategory?), TypeInfoPropertyName = "NullableEnvVarSecretCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequestObjectType?), TypeInfoPropertyName = "NullablePostEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequestObjectType?), TypeInfoPropertyName = "NullablePutEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.EnvVar>))]
    internal sealed partial class EnvVarsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvVarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnvVarsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnvVarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Braintrust.EnvVarObjectType)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType?)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType2)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType2?)

                    || typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory)

                    || typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory?)

                    || typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType)

                    || typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType?)

                    || typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType)

                    || typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType2))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType2?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory))
                {
                    return new global::Braintrust.JsonConverters.EnvVarSecretCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarSecretCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType))
                {
                    return new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType?))
                {
                    return new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType))
                {
                    return new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType?))
                {
                    return new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter();
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
                    0 => new EnvVarsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}