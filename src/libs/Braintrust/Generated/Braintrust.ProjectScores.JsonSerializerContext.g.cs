
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreType), TypeInfoPropertyName = "ProjectScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum), TypeInfoPropertyName = "FunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId), TypeInfoPropertyName = "SavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType), TypeInfoPropertyName = "SavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType), TypeInfoPropertyName = "SavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AutomationStatus), TypeInfoPropertyName = "AutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType), TypeInfoPropertyName = "SpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType), TypeInfoPropertyName = "TraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType), TypeInfoPropertyName = "GroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopePlacement), TypeInfoPropertyName = "GroupScopePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>), TypeInfoPropertyName = "AnyOfSpanScopeTraceScopeGroupScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategories), TypeInfoPropertyName = "ProjectScoreCategories2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>), TypeInfoPropertyName = "AnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType), TypeInfoPropertyName = "OnlineScoreConfigScorerVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType), TypeInfoPropertyName = "OnlineScoreConfigScorerVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionWhen))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionBehavior), TypeInfoPropertyName = "ProjectScoreConditionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigObjectType), TypeInfoPropertyName = "ProjectScoreConfigObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>), TypeInfoPropertyName = "AnyOfProjectScoreTypeIListAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>), TypeInfoPropertyName = "AllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreType?), TypeInfoPropertyName = "NullableProjectScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum?), TypeInfoPropertyName = "NullableFunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId?), TypeInfoPropertyName = "NullableSavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AutomationStatus?), TypeInfoPropertyName = "NullableAutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType?), TypeInfoPropertyName = "NullableSpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType?), TypeInfoPropertyName = "NullableTraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType?), TypeInfoPropertyName = "NullableGroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopePlacement?), TypeInfoPropertyName = "NullableGroupScopePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>?), TypeInfoPropertyName = "NullableAnyOfSpanScopeTraceScopeGroupScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategories?), TypeInfoPropertyName = "NullableProjectScoreCategories2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>?), TypeInfoPropertyName = "NullableAllOfSavedFunctionIdAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?), TypeInfoPropertyName = "NullableOnlineScoreConfigScorerVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?), TypeInfoPropertyName = "NullableOnlineScoreConfigScorerVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionBehavior?), TypeInfoPropertyName = "NullableProjectScoreConditionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigObjectType?), TypeInfoPropertyName = "NullableProjectScoreConfigObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>?), TypeInfoPropertyName = "NullableAnyOfProjectScoreTypeIListAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>?), TypeInfoPropertyName = "NullableAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScore>))]
    internal sealed partial class ProjectScoresSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectScoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectScoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectScoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectScoreCategoriesJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>());
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
                    typeToConvert == typeof(global::Braintrust.ProjectScoreType)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.AutomationStatus)

                    || typeToConvert == typeof(global::Braintrust.AutomationStatus?)

                    || typeToConvert == typeof(global::Braintrust.SpanScopeType)

                    || typeToConvert == typeof(global::Braintrust.SpanScopeType?)

                    || typeToConvert == typeof(global::Braintrust.TraceScopeType)

                    || typeToConvert == typeof(global::Braintrust.TraceScopeType?)

                    || typeToConvert == typeof(global::Braintrust.GroupScopeType)

                    || typeToConvert == typeof(global::Braintrust.GroupScopeType?)

                    || typeToConvert == typeof(global::Braintrust.GroupScopePlacement)

                    || typeToConvert == typeof(global::Braintrust.GroupScopePlacement?)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior?)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.ProjectScoreType))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Braintrust.AutomationStatus))
                {
                    return new global::Braintrust.JsonConverters.AutomationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AutomationStatus?))
                {
                    return new global::Braintrust.JsonConverters.AutomationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanScopeType))
                {
                    return new global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanScopeType?))
                {
                    return new global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TraceScopeType))
                {
                    return new global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TraceScopeType?))
                {
                    return new global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopeType))
                {
                    return new global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopeType?))
                {
                    return new global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopePlacement))
                {
                    return new global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopePlacement?))
                {
                    return new global::Braintrust.JsonConverters.GroupScopePlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConditionBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConditionBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConfigObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConfigObjectTypeNullableJsonConverter();
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
                    0 => new ProjectScoresSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}