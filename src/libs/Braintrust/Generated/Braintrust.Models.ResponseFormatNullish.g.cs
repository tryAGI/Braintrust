#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseFormatNullish : global::System.IEquatable<ResponseFormatNullish>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ResponseFormatNullishJsonObject? JsonObject { get; init; }
#else
        public global::Braintrust.ResponseFormatNullishJsonObject? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ResponseFormatNullishJsonSchema? JsonSchema { get; init; }
#else
        public global::Braintrust.ResponseFormatNullishJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ResponseFormatNullishText? Text { get; init; }
#else
        public global::Braintrust.ResponseFormatNullishText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ResponseFormatNullishVariant4 { get; init; }
#else
        public object? ResponseFormatNullishVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFormatNullishVariant4))]
#endif
        public bool IsResponseFormatNullishVariant4 => ResponseFormatNullishVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatNullish(global::Braintrust.ResponseFormatNullishJsonObject value) => new ResponseFormatNullish((global::Braintrust.ResponseFormatNullishJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ResponseFormatNullishJsonObject?(ResponseFormatNullish @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatNullish(global::Braintrust.ResponseFormatNullishJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatNullish(global::Braintrust.ResponseFormatNullishJsonSchema value) => new ResponseFormatNullish((global::Braintrust.ResponseFormatNullishJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ResponseFormatNullishJsonSchema?(ResponseFormatNullish @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatNullish(global::Braintrust.ResponseFormatNullishJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatNullish(global::Braintrust.ResponseFormatNullishText value) => new ResponseFormatNullish((global::Braintrust.ResponseFormatNullishText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ResponseFormatNullishText?(ResponseFormatNullish @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatNullish(global::Braintrust.ResponseFormatNullishText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatNullish(
            global::Braintrust.ResponseFormatNullishJsonObject? jsonObject,
            global::Braintrust.ResponseFormatNullishJsonSchema? jsonSchema,
            global::Braintrust.ResponseFormatNullishText? text,
            object? responseFormatNullishVariant4
            )
        {
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
            Text = text;
            ResponseFormatNullishVariant4 = responseFormatNullishVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseFormatNullishVariant4 as object ??
            Text as object ??
            JsonSchema as object ??
            JsonObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonObject?.ToString() ??
            JsonSchema?.ToString() ??
            Text?.ToString() ??
            ResponseFormatNullishVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonObject || IsJsonSchema || IsText || IsResponseFormatNullishVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ResponseFormatNullishJsonObject?, TResult>? jsonObject = null,
            global::System.Func<global::Braintrust.ResponseFormatNullishJsonSchema?, TResult>? jsonSchema = null,
            global::System.Func<global::Braintrust.ResponseFormatNullishText?, TResult>? text = null,
            global::System.Func<object?, TResult>? responseFormatNullishVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsResponseFormatNullishVariant4 && responseFormatNullishVariant4 != null)
            {
                return responseFormatNullishVariant4(ResponseFormatNullishVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ResponseFormatNullishJsonObject?>? jsonObject = null,
            global::System.Action<global::Braintrust.ResponseFormatNullishJsonSchema?>? jsonSchema = null,
            global::System.Action<global::Braintrust.ResponseFormatNullishText?>? text = null,
            global::System.Action<object?>? responseFormatNullishVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsResponseFormatNullishVariant4)
            {
                responseFormatNullishVariant4?.Invoke(ResponseFormatNullishVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonObject,
                typeof(global::Braintrust.ResponseFormatNullishJsonObject),
                JsonSchema,
                typeof(global::Braintrust.ResponseFormatNullishJsonSchema),
                Text,
                typeof(global::Braintrust.ResponseFormatNullishText),
                ResponseFormatNullishVariant4,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseFormatNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ResponseFormatNullishJsonObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ResponseFormatNullishJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ResponseFormatNullishText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ResponseFormatNullishVariant4, other.ResponseFormatNullishVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatNullish obj1, ResponseFormatNullish obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatNullish>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatNullish obj1, ResponseFormatNullish obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatNullish o && Equals(o);
        }
    }
}
