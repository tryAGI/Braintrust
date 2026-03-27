#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelParams : global::System.IEquatable<ModelParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ModelParamsOpenAIModelParams? OpenAIModelParams { get; init; }
#else
        public global::Braintrust.ModelParamsOpenAIModelParams? OpenAIModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIModelParams))]
#endif
        public bool IsOpenAIModelParams => OpenAIModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ModelParamsAnthropicModelParams? AnthropicModelParams { get; init; }
#else
        public global::Braintrust.ModelParamsAnthropicModelParams? AnthropicModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicModelParams))]
#endif
        public bool IsAnthropicModelParams => AnthropicModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ModelParamsGoogleModelParams? GoogleModelParams { get; init; }
#else
        public global::Braintrust.ModelParamsGoogleModelParams? GoogleModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleModelParams))]
#endif
        public bool IsGoogleModelParams => GoogleModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ModelParamsWindowAIModelParams? WindowAIModelParams { get; init; }
#else
        public global::Braintrust.ModelParamsWindowAIModelParams? WindowAIModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WindowAIModelParams))]
#endif
        public bool IsWindowAIModelParams => WindowAIModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ModelParamsJsCompletionParams? JsCompletionParams { get; init; }
#else
        public global::Braintrust.ModelParamsJsCompletionParams? JsCompletionParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsCompletionParams))]
#endif
        public bool IsJsCompletionParams => JsCompletionParams != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::Braintrust.ModelParamsOpenAIModelParams value) => new ModelParams((global::Braintrust.ModelParamsOpenAIModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ModelParamsOpenAIModelParams?(ModelParams @this) => @this.OpenAIModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::Braintrust.ModelParamsOpenAIModelParams? value)
        {
            OpenAIModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::Braintrust.ModelParamsAnthropicModelParams value) => new ModelParams((global::Braintrust.ModelParamsAnthropicModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ModelParamsAnthropicModelParams?(ModelParams @this) => @this.AnthropicModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::Braintrust.ModelParamsAnthropicModelParams? value)
        {
            AnthropicModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::Braintrust.ModelParamsGoogleModelParams value) => new ModelParams((global::Braintrust.ModelParamsGoogleModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ModelParamsGoogleModelParams?(ModelParams @this) => @this.GoogleModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::Braintrust.ModelParamsGoogleModelParams? value)
        {
            GoogleModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::Braintrust.ModelParamsWindowAIModelParams value) => new ModelParams((global::Braintrust.ModelParamsWindowAIModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ModelParamsWindowAIModelParams?(ModelParams @this) => @this.WindowAIModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::Braintrust.ModelParamsWindowAIModelParams? value)
        {
            WindowAIModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::Braintrust.ModelParamsJsCompletionParams value) => new ModelParams((global::Braintrust.ModelParamsJsCompletionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ModelParamsJsCompletionParams?(ModelParams @this) => @this.JsCompletionParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::Braintrust.ModelParamsJsCompletionParams? value)
        {
            JsCompletionParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(
            global::Braintrust.ModelParamsOpenAIModelParams? openAIModelParams,
            global::Braintrust.ModelParamsAnthropicModelParams? anthropicModelParams,
            global::Braintrust.ModelParamsGoogleModelParams? googleModelParams,
            global::Braintrust.ModelParamsWindowAIModelParams? windowAIModelParams,
            global::Braintrust.ModelParamsJsCompletionParams? jsCompletionParams
            )
        {
            OpenAIModelParams = openAIModelParams;
            AnthropicModelParams = anthropicModelParams;
            GoogleModelParams = googleModelParams;
            WindowAIModelParams = windowAIModelParams;
            JsCompletionParams = jsCompletionParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsCompletionParams as object ??
            WindowAIModelParams as object ??
            GoogleModelParams as object ??
            AnthropicModelParams as object ??
            OpenAIModelParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIModelParams?.ToString() ??
            AnthropicModelParams?.ToString() ??
            GoogleModelParams?.ToString() ??
            WindowAIModelParams?.ToString() ??
            JsCompletionParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIModelParams || IsAnthropicModelParams || IsGoogleModelParams || IsWindowAIModelParams || IsJsCompletionParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ModelParamsOpenAIModelParams?, TResult>? openAIModelParams = null,
            global::System.Func<global::Braintrust.ModelParamsAnthropicModelParams?, TResult>? anthropicModelParams = null,
            global::System.Func<global::Braintrust.ModelParamsGoogleModelParams?, TResult>? googleModelParams = null,
            global::System.Func<global::Braintrust.ModelParamsWindowAIModelParams?, TResult>? windowAIModelParams = null,
            global::System.Func<global::Braintrust.ModelParamsJsCompletionParams?, TResult>? jsCompletionParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIModelParams && openAIModelParams != null)
            {
                return openAIModelParams(OpenAIModelParams!);
            }
            else if (IsAnthropicModelParams && anthropicModelParams != null)
            {
                return anthropicModelParams(AnthropicModelParams!);
            }
            else if (IsGoogleModelParams && googleModelParams != null)
            {
                return googleModelParams(GoogleModelParams!);
            }
            else if (IsWindowAIModelParams && windowAIModelParams != null)
            {
                return windowAIModelParams(WindowAIModelParams!);
            }
            else if (IsJsCompletionParams && jsCompletionParams != null)
            {
                return jsCompletionParams(JsCompletionParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ModelParamsOpenAIModelParams?>? openAIModelParams = null,
            global::System.Action<global::Braintrust.ModelParamsAnthropicModelParams?>? anthropicModelParams = null,
            global::System.Action<global::Braintrust.ModelParamsGoogleModelParams?>? googleModelParams = null,
            global::System.Action<global::Braintrust.ModelParamsWindowAIModelParams?>? windowAIModelParams = null,
            global::System.Action<global::Braintrust.ModelParamsJsCompletionParams?>? jsCompletionParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIModelParams)
            {
                openAIModelParams?.Invoke(OpenAIModelParams!);
            }
            else if (IsAnthropicModelParams)
            {
                anthropicModelParams?.Invoke(AnthropicModelParams!);
            }
            else if (IsGoogleModelParams)
            {
                googleModelParams?.Invoke(GoogleModelParams!);
            }
            else if (IsWindowAIModelParams)
            {
                windowAIModelParams?.Invoke(WindowAIModelParams!);
            }
            else if (IsJsCompletionParams)
            {
                jsCompletionParams?.Invoke(JsCompletionParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIModelParams,
                typeof(global::Braintrust.ModelParamsOpenAIModelParams),
                AnthropicModelParams,
                typeof(global::Braintrust.ModelParamsAnthropicModelParams),
                GoogleModelParams,
                typeof(global::Braintrust.ModelParamsGoogleModelParams),
                WindowAIModelParams,
                typeof(global::Braintrust.ModelParamsWindowAIModelParams),
                JsCompletionParams,
                typeof(global::Braintrust.ModelParamsJsCompletionParams),
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
        public bool Equals(ModelParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ModelParamsOpenAIModelParams?>.Default.Equals(OpenAIModelParams, other.OpenAIModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ModelParamsAnthropicModelParams?>.Default.Equals(AnthropicModelParams, other.AnthropicModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ModelParamsGoogleModelParams?>.Default.Equals(GoogleModelParams, other.GoogleModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ModelParamsWindowAIModelParams?>.Default.Equals(WindowAIModelParams, other.WindowAIModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ModelParamsJsCompletionParams?>.Default.Equals(JsCompletionParams, other.JsCompletionParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelParams obj1, ModelParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelParams obj1, ModelParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelParams o && Equals(o);
        }
    }
}
