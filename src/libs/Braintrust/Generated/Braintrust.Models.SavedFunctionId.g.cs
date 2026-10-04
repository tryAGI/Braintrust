#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Optional function identifier that produced the classification
    /// </summary>
    public readonly partial struct SavedFunctionId : global::System.IEquatable<SavedFunctionId>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.SavedFunctionIdFunction? Function { get; init; }
#else
        public global::Braintrust.SavedFunctionIdFunction? Function { get; }
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
            out global::Braintrust.SavedFunctionIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.SavedFunctionIdGlobal? Global { get; init; }
#else
        public global::Braintrust.SavedFunctionIdGlobal? Global { get; }
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
            out global::Braintrust.SavedFunctionIdGlobal? value)
        {
            value = Global;
            return IsGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdGlobal PickGlobal() => Global is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Global' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SavedFunctionId(global::Braintrust.SavedFunctionIdFunction value) => new SavedFunctionId((global::Braintrust.SavedFunctionIdFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.SavedFunctionIdFunction?(SavedFunctionId @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public SavedFunctionId(global::Braintrust.SavedFunctionIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SavedFunctionId FromFunction(global::Braintrust.SavedFunctionIdFunction? value) => new SavedFunctionId(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SavedFunctionId(global::Braintrust.SavedFunctionIdGlobal value) => new SavedFunctionId((global::Braintrust.SavedFunctionIdGlobal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.SavedFunctionIdGlobal?(SavedFunctionId @this) => @this.Global;

        /// <summary>
        ///
        /// </summary>
        public SavedFunctionId(global::Braintrust.SavedFunctionIdGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SavedFunctionId FromGlobal(global::Braintrust.SavedFunctionIdGlobal? value) => new SavedFunctionId(value);

        /// <summary>
        ///
        /// </summary>
        public SavedFunctionId(
            global::Braintrust.SavedFunctionIdFunction? function,
            global::Braintrust.SavedFunctionIdGlobal? global
            )
        {
            Function = function;
            Global = global;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Global as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.SavedFunctionIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.SavedFunctionIdGlobal, TResult>? global = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.SavedFunctionIdFunction>? function = null,

            global::System.Action<global::Braintrust.SavedFunctionIdGlobal>? global = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.SavedFunctionIdFunction>? function = null,
            global::System.Action<global::Braintrust.SavedFunctionIdGlobal>? global = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Braintrust.SavedFunctionIdFunction),
                Global,
                typeof(global::Braintrust.SavedFunctionIdGlobal),
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
        public bool Equals(SavedFunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.SavedFunctionIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.SavedFunctionIdGlobal?>.Default.Equals(Global, other.Global)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SavedFunctionId obj1, SavedFunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SavedFunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SavedFunctionId obj1, SavedFunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SavedFunctionId o && Equals(o);
        }
    }
}
