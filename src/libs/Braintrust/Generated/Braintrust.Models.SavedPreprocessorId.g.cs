#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Saved preprocessor that renders traces for the project's pattern questions. The project default when unset.
    /// </summary>
    public readonly partial struct SavedPreprocessorId : global::System.IEquatable<SavedPreprocessorId>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.SavedPreprocessorIdFunction? Function { get; init; }
#else
        public global::Braintrust.SavedPreprocessorIdFunction? Function { get; }
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
            out global::Braintrust.SavedPreprocessorIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? PreprocessorGlobal { get; init; }
#else
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? PreprocessorGlobal { get; }
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
            out global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? value)
        {
            value = PreprocessorGlobal;
            return IsPreprocessorGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobal PickPreprocessorGlobal() => PreprocessorGlobal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorGlobal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SavedPreprocessorId(global::Braintrust.SavedPreprocessorIdFunction value) => new SavedPreprocessorId((global::Braintrust.SavedPreprocessorIdFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.SavedPreprocessorIdFunction?(SavedPreprocessorId @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public SavedPreprocessorId(global::Braintrust.SavedPreprocessorIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SavedPreprocessorId FromFunction(global::Braintrust.SavedPreprocessorIdFunction? value) => new SavedPreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SavedPreprocessorId(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal value) => new SavedPreprocessorId((global::Braintrust.SavedPreprocessorIdPreprocessorGlobal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.SavedPreprocessorIdPreprocessorGlobal?(SavedPreprocessorId @this) => @this.PreprocessorGlobal;

        /// <summary>
        ///
        /// </summary>
        public SavedPreprocessorId(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? value)
        {
            PreprocessorGlobal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SavedPreprocessorId FromPreprocessorGlobal(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? value) => new SavedPreprocessorId(value);

        /// <summary>
        ///
        /// </summary>
        public SavedPreprocessorId(
            global::Braintrust.SavedPreprocessorIdFunction? function,
            global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? preprocessorGlobal
            )
        {
            Function = function;
            PreprocessorGlobal = preprocessorGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreprocessorGlobal as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            PreprocessorGlobal?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsPreprocessorGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.SavedPreprocessorIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal, TResult>? preprocessorGlobal = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.SavedPreprocessorIdFunction>? function = null,

            global::System.Action<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal>? preprocessorGlobal = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.SavedPreprocessorIdFunction>? function = null,
            global::System.Action<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal>? preprocessorGlobal = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Braintrust.SavedPreprocessorIdFunction),
                PreprocessorGlobal,
                typeof(global::Braintrust.SavedPreprocessorIdPreprocessorGlobal),
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
        public bool Equals(SavedPreprocessorId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.SavedPreprocessorIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.SavedPreprocessorIdPreprocessorGlobal?>.Default.Equals(PreprocessorGlobal, other.PreprocessorGlobal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SavedPreprocessorId obj1, SavedPreprocessorId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SavedPreprocessorId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SavedPreprocessorId obj1, SavedPreprocessorId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SavedPreprocessorId o && Equals(o);
        }
    }
}
