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
        public global::Braintrust.FacetPreprocessorIdFunction PickFunction() => IsFunction
            ? Function!
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
        public global::Braintrust.FacetPreprocessorIdGlobal PickGlobal() => IsGlobal
            ? Global!
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
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline PickPreprocessorInline() => IsPreprocessorInline
            ? PreprocessorInline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorInline' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FacetPreprocessorIdVariant4 { get; init; }
#else
        public object? FacetPreprocessorIdVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetPreprocessorIdVariant4))]
#endif
        public bool IsFacetPreprocessorIdVariant4 => FacetPreprocessorIdVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFacetPreprocessorIdVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FacetPreprocessorIdVariant4;
            return IsFacetPreprocessorIdVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickFacetPreprocessorIdVariant4() => IsFacetPreprocessorIdVariant4
            ? FacetPreprocessorIdVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FacetPreprocessorIdVariant4' but the value was {ToString()}.");
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
            global::Braintrust.FacetPreprocessorIdPreprocessorInline? preprocessorInline,
            object? facetPreprocessorIdVariant4
            )
        {
            Function = function;
            Global = global;
            PreprocessorInline = preprocessorInline;
            FacetPreprocessorIdVariant4 = facetPreprocessorIdVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FacetPreprocessorIdVariant4 as object ??
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
            PreprocessorInline?.ToString() ??
            FacetPreprocessorIdVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal || IsPreprocessorInline || IsFacetPreprocessorIdVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FacetPreprocessorIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.FacetPreprocessorIdGlobal, TResult>? global = null,
            global::System.Func<global::Braintrust.FacetPreprocessorIdPreprocessorInline, TResult>? preprocessorInline = null,
            global::System.Func<object, TResult>? facetPreprocessorIdVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsGlobal && global != null)
            {
                return global(Global!);
            }
            else if (IsPreprocessorInline && preprocessorInline != null)
            {
                return preprocessorInline(PreprocessorInline!);
            }
            else if (IsFacetPreprocessorIdVariant4 && facetPreprocessorIdVariant4 != null)
            {
                return facetPreprocessorIdVariant4(FacetPreprocessorIdVariant4!);
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

            global::System.Action<object>? facetPreprocessorIdVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsGlobal)
            {
                global?.Invoke(Global!);
            }
            else if (IsPreprocessorInline)
            {
                preprocessorInline?.Invoke(PreprocessorInline!);
            }
            else if (IsFacetPreprocessorIdVariant4)
            {
                facetPreprocessorIdVariant4?.Invoke(FacetPreprocessorIdVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.FacetPreprocessorIdFunction>? function = null,
            global::System.Action<global::Braintrust.FacetPreprocessorIdGlobal>? global = null,
            global::System.Action<global::Braintrust.FacetPreprocessorIdPreprocessorInline>? preprocessorInline = null,
            global::System.Action<object>? facetPreprocessorIdVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsGlobal)
            {
                global?.Invoke(Global!);
            }
            else if (IsPreprocessorInline)
            {
                preprocessorInline?.Invoke(PreprocessorInline!);
            }
            else if (IsFacetPreprocessorIdVariant4)
            {
                facetPreprocessorIdVariant4?.Invoke(FacetPreprocessorIdVariant4!);
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
                FacetPreprocessorIdVariant4,
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
        public bool Equals(FacetPreprocessorId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetPreprocessorIdPreprocessorInline?>.Default.Equals(PreprocessorInline, other.PreprocessorInline) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FacetPreprocessorIdVariant4, other.FacetPreprocessorIdVariant4)
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
