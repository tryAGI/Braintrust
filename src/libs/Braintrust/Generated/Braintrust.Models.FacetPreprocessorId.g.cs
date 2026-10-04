#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The saved, global, or inline preprocessor to use for facet extraction. If not provided, the project default preprocessor will be used, falling back to the global 'thread' preprocessor.
    /// </summary>
    public readonly partial struct FacetPreprocessorId : global::System.IEquatable<FacetPreprocessorId>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FacetPreprocessorIdFunction? Function { get; init; }
#else
        public global::Braintrust.FacetPreprocessorIdFunction? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FacetPreprocessorIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FacetPreprocessorIdGlobal? Global { get; init; }
#else
        public global::Braintrust.FacetPreprocessorIdGlobal? Global { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Global))]
#endif
        public bool IsGlobal => Global != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FacetPreprocessorIdGlobal? value)
        {
            value = Global;
            return IsGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal PickGlobal() => Global is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Global' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? PreprocessorInline { get; init; }
#else
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? PreprocessorInline { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreprocessorInline))]
#endif
        public bool IsPreprocessorInline => PreprocessorInline != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreprocessorInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FacetPreprocessorIdPreprocessorInline? value)
        {
            value = PreprocessorInline;
            return IsPreprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline PickPreprocessorInline() => PreprocessorInline is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorInline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdFunction value) => new FacetPreprocessorId((global::Braintrust.FacetPreprocessorIdFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.FacetPreprocessorIdFunction?(FacetPreprocessorId @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FacetPreprocessorId FromFunction(global::Braintrust.FacetPreprocessorIdFunction? value) => new FacetPreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdGlobal value) => new FacetPreprocessorId((global::Braintrust.FacetPreprocessorIdGlobal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.FacetPreprocessorIdGlobal?(FacetPreprocessorId @this) => @this.Global;

        /// <summary>
        ///
        /// </summary>
        public FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FacetPreprocessorId FromGlobal(global::Braintrust.FacetPreprocessorIdGlobal? value) => new FacetPreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdPreprocessorInline value) => new FacetPreprocessorId((global::Braintrust.FacetPreprocessorIdPreprocessorInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.FacetPreprocessorIdPreprocessorInline?(FacetPreprocessorId @this) => @this.PreprocessorInline;

        /// <summary>
        ///
        /// </summary>
        public FacetPreprocessorId(global::Braintrust.FacetPreprocessorIdPreprocessorInline? value)
        {
            PreprocessorInline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FacetPreprocessorId FromPreprocessorInline(global::Braintrust.FacetPreprocessorIdPreprocessorInline? value) => new FacetPreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public FacetPreprocessorId(
            global::Braintrust.FacetPreprocessorIdFunction? function,
            global::Braintrust.FacetPreprocessorIdGlobal? global,
            global::Braintrust.FacetPreprocessorIdPreprocessorInline? preprocessorInline
            )
        {
            Function = function;
            Global = global;
            PreprocessorInline = preprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreprocessorInline as object ??
            Global as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString() ??
            PreprocessorInline?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal || IsPreprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FacetPreprocessorIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.FacetPreprocessorIdGlobal, TResult>? global = null,
            global::System.Func<global::Braintrust.FacetPreprocessorIdPreprocessorInline, TResult>? preprocessorInline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0 && function != null)
            {
                return function(__value0);
            }
            else if (Global is { } __value1 && global != null)
            {
                return global(__value1);
            }
            else if (PreprocessorInline is { } __value2 && preprocessorInline != null)
            {
                return preprocessorInline(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.FacetPreprocessorIdFunction>? function = null,

            global::System.Action<global::Braintrust.FacetPreprocessorIdGlobal>? global = null,

            global::System.Action<global::Braintrust.FacetPreprocessorIdPreprocessorInline>? preprocessorInline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Global is { } __value1)
            {
                global?.Invoke(__value1);
            }
            else if (PreprocessorInline is { } __value2)
            {
                preprocessorInline?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.FacetPreprocessorIdFunction>? function = null,
            global::System.Action<global::Braintrust.FacetPreprocessorIdGlobal>? global = null,
            global::System.Action<global::Braintrust.FacetPreprocessorIdPreprocessorInline>? preprocessorInline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Global is { } __value1)
            {
                global?.Invoke(__value1);
            }
            else if (PreprocessorInline is { } __value2)
            {
                preprocessorInline?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Braintrust.FacetPreprocessorIdFunction),
                Global,
                typeof(global::Braintrust.FacetPreprocessorIdGlobal),
                PreprocessorInline,
                typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline),
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
        public bool Equals(FacetPreprocessorId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdPreprocessorInline?>.Default.Equals(PreprocessorInline, other.PreprocessorInline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FacetPreprocessorId obj1, FacetPreprocessorId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FacetPreprocessorId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FacetPreprocessorId obj1, FacetPreprocessorId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FacetPreprocessorId o && Equals(o);
        }
    }
}
