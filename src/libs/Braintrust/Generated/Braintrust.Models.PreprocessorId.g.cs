#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// For prompt-backed functions: the saved, global, or inline preprocessor to use for trace template variables. Set to null to disable preprocessing. If omitted, the traced project's default preprocessor will be used, falling back to the global 'thread' preprocessor.
    /// </summary>
    public readonly partial struct PreprocessorId : global::System.IEquatable<PreprocessorId>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PreprocessorIdFunction? Function { get; init; }
#else
        public global::Braintrust.PreprocessorIdFunction? Function { get; }
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
            out global::Braintrust.PreprocessorIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? PreprocessorGlobal { get; init; }
#else
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? PreprocessorGlobal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreprocessorGlobal))]
#endif
        public bool IsPreprocessorGlobal => PreprocessorGlobal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreprocessorGlobal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.PreprocessorIdPreprocessorGlobal? value)
        {
            value = PreprocessorGlobal;
            return IsPreprocessorGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal PickPreprocessorGlobal() => PreprocessorGlobal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorGlobal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PreprocessorIdPreprocessorInline? PreprocessorInline { get; init; }
#else
        public global::Braintrust.PreprocessorIdPreprocessorInline? PreprocessorInline { get; }
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
            out global::Braintrust.PreprocessorIdPreprocessorInline? value)
        {
            value = PreprocessorInline;
            return IsPreprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline PickPreprocessorInline() => PreprocessorInline is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorInline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreprocessorId(global::Braintrust.PreprocessorIdFunction value) => new PreprocessorId((global::Braintrust.PreprocessorIdFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PreprocessorIdFunction?(PreprocessorId @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public PreprocessorId(global::Braintrust.PreprocessorIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreprocessorId FromFunction(global::Braintrust.PreprocessorIdFunction? value) => new PreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreprocessorId(global::Braintrust.PreprocessorIdPreprocessorGlobal value) => new PreprocessorId((global::Braintrust.PreprocessorIdPreprocessorGlobal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PreprocessorIdPreprocessorGlobal?(PreprocessorId @this) => @this.PreprocessorGlobal;

        /// <summary>
        ///
        /// </summary>
        public PreprocessorId(global::Braintrust.PreprocessorIdPreprocessorGlobal? value)
        {
            PreprocessorGlobal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreprocessorId FromPreprocessorGlobal(global::Braintrust.PreprocessorIdPreprocessorGlobal? value) => new PreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreprocessorId(global::Braintrust.PreprocessorIdPreprocessorInline value) => new PreprocessorId((global::Braintrust.PreprocessorIdPreprocessorInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PreprocessorIdPreprocessorInline?(PreprocessorId @this) => @this.PreprocessorInline;

        /// <summary>
        ///
        /// </summary>
        public PreprocessorId(global::Braintrust.PreprocessorIdPreprocessorInline? value)
        {
            PreprocessorInline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreprocessorId FromPreprocessorInline(global::Braintrust.PreprocessorIdPreprocessorInline? value) => new PreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public PreprocessorId(
            global::Braintrust.PreprocessorIdFunction? function,
            global::Braintrust.PreprocessorIdPreprocessorGlobal? preprocessorGlobal,
            global::Braintrust.PreprocessorIdPreprocessorInline? preprocessorInline
            )
        {
            Function = function;
            PreprocessorGlobal = preprocessorGlobal;
            PreprocessorInline = preprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreprocessorInline as object ??
            PreprocessorGlobal as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            PreprocessorGlobal?.ToString() ??
            PreprocessorInline?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsPreprocessorGlobal || IsPreprocessorInline;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.PreprocessorIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.PreprocessorIdPreprocessorGlobal, TResult>? preprocessorGlobal = null,
            global::System.Func<global::Braintrust.PreprocessorIdPreprocessorInline, TResult>? preprocessorInline = null,
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
            else if (PreprocessorGlobal is { } __value1 && preprocessorGlobal != null)
            {
                return preprocessorGlobal(__value1);
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
            global::System.Action<global::Braintrust.PreprocessorIdFunction>? function = null,

            global::System.Action<global::Braintrust.PreprocessorIdPreprocessorGlobal>? preprocessorGlobal = null,

            global::System.Action<global::Braintrust.PreprocessorIdPreprocessorInline>? preprocessorInline = null,
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
            else if (PreprocessorGlobal is { } __value1)
            {
                preprocessorGlobal?.Invoke(__value1);
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
            global::System.Action<global::Braintrust.PreprocessorIdFunction>? function = null,
            global::System.Action<global::Braintrust.PreprocessorIdPreprocessorGlobal>? preprocessorGlobal = null,
            global::System.Action<global::Braintrust.PreprocessorIdPreprocessorInline>? preprocessorInline = null,
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
            else if (PreprocessorGlobal is { } __value1)
            {
                preprocessorGlobal?.Invoke(__value1);
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
                typeof(global::Braintrust.PreprocessorIdFunction),
                PreprocessorGlobal,
                typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal),
                PreprocessorInline,
                typeof(global::Braintrust.PreprocessorIdPreprocessorInline),
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
        public bool Equals(PreprocessorId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PreprocessorIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PreprocessorIdPreprocessorGlobal?>.Default.Equals(PreprocessorGlobal, other.PreprocessorGlobal) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PreprocessorIdPreprocessorInline?>.Default.Equals(PreprocessorInline, other.PreprocessorInline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PreprocessorId obj1, PreprocessorId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreprocessorId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PreprocessorId obj1, PreprocessorId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreprocessorId o && Equals(o);
        }
    }
}
