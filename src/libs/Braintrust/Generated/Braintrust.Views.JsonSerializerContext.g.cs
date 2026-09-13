
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewType), TypeInfoPropertyName = "ViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclObjectType), TypeInfoPropertyName = "AclObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewDataSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptions), TypeInfoPropertyName = "ViewOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsOptionsSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsExcludedMeasureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsYMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsXAxisType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsSymbolGroupingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsPointSizeMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>), TypeInfoPropertyName = "AnyOfStringViewOptionsTableViewOptionsTimeRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape), TypeInfoPropertyName = "ViewOptionsTableViewOptionsQueryShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.View))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewViewType), TypeInfoPropertyName = "ViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateViewViewType), TypeInfoPropertyName = "CreateViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchViewViewType), TypeInfoPropertyName = "PatchViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DeleteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetViewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewType?), TypeInfoPropertyName = "NullableViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclObjectType?), TypeInfoPropertyName = "NullableAclObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptions?), TypeInfoPropertyName = "NullableViewOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsOptionsSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsExcludedMeasureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsYMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsXAxisType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsSymbolGroupingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsPointSizeMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>?), TypeInfoPropertyName = "NullableAnyOfStringViewOptionsTableViewOptionsTimeRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsQueryShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewViewType?), TypeInfoPropertyName = "NullableViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateViewViewType?), TypeInfoPropertyName = "NullableCreateViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchViewViewType?), TypeInfoPropertyName = "NullablePatchViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.View>))]
    internal sealed partial class ViewsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ViewsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ViewsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ViewsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>());
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
                    typeToConvert == typeof(global::Braintrust.ViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewType?)

                    || typeToConvert == typeof(global::Braintrust.AclObjectType)

                    || typeToConvert == typeof(global::Braintrust.AclObjectType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?)

                    || typeToConvert == typeof(global::Braintrust.ViewViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewViewType?)

                    || typeToConvert == typeof(global::Braintrust.CreateViewViewType)

                    || typeToConvert == typeof(global::Braintrust.CreateViewViewType?)

                    || typeToConvert == typeof(global::Braintrust.PatchViewViewType)

                    || typeToConvert == typeof(global::Braintrust.PatchViewViewType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.ViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclObjectType))
                {
                    return new global::Braintrust.JsonConverters.AclObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclObjectType?))
                {
                    return new global::Braintrust.JsonConverters.AclObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsPointSizeMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsPointSizeMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateViewViewType))
                {
                    return new global::Braintrust.JsonConverters.CreateViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.CreateViewViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchViewViewType))
                {
                    return new global::Braintrust.JsonConverters.PatchViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.PatchViewViewTypeNullableJsonConverter();
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
                    0 => new ViewsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}