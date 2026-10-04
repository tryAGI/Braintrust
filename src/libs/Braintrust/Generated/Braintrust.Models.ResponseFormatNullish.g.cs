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
        public bool TryPickJsonObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ResponseFormatNullishJsonObject? value)
        {
            value = JsonObject;
            return IsJsonObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject PickJsonObject() => JsonObject is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonObject' but the value was {ToString()}.");

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
        public bool TryPickJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ResponseFormatNullishJsonSchema? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema PickJsonSchema() => JsonSchema is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");

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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ResponseFormatNullishText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
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
        public static ResponseFormatNullish FromJsonObject(global::Braintrust.ResponseFormatNullishJsonObject? value) => new ResponseFormatNullish(value);

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
        public static ResponseFormatNullish FromJsonSchema(global::Braintrust.ResponseFormatNullishJsonSchema? value) => new ResponseFormatNullish(value);

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
        public static ResponseFormatNullish FromText(global::Braintrust.ResponseFormatNullishText? value) => new ResponseFormatNullish(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseFormatNullish(
            global::Braintrust.ResponseFormatNullishJsonObject? jsonObject,
            global::Braintrust.ResponseFormatNullishJsonSchema? jsonSchema,
            global::Braintrust.ResponseFormatNullishText? text
            )
        {
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
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
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJsonObject || IsJsonSchema || IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ResponseFormatNullishJsonObject, TResult>? jsonObject = null,
            global::System.Func<global::Braintrust.ResponseFormatNullishJsonSchema, TResult>? jsonSchema = null,
            global::System.Func<global::Braintrust.ResponseFormatNullishText, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonObject is { } __value0 && jsonObject != null)
            {
                return jsonObject(__value0);
            }
            else if (JsonSchema is { } __value1 && jsonSchema != null)
            {
                return jsonSchema(__value1);
            }
            else if (Text is { } __value2 && text != null)
            {
                return text(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ResponseFormatNullishJsonObject>? jsonObject = null,

            global::System.Action<global::Braintrust.ResponseFormatNullishJsonSchema>? jsonSchema = null,

            global::System.Action<global::Braintrust.ResponseFormatNullishText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonObject is { } __value0)
            {
                jsonObject?.Invoke(__value0);
            }
            else if (JsonSchema is { } __value1)
            {
                jsonSchema?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.ResponseFormatNullishJsonObject>? jsonObject = null,
            global::System.Action<global::Braintrust.ResponseFormatNullishJsonSchema>? jsonSchema = null,
            global::System.Action<global::Braintrust.ResponseFormatNullishText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JsonObject is { } __value0)
            {
                jsonObject?.Invoke(__value0);
            }
            else if (JsonSchema is { } __value1)
            {
                jsonSchema?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
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
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ResponseFormatNullishText?>.Default.Equals(Text, other.Text)
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
