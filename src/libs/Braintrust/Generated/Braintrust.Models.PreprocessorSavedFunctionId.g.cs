#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// For prompt-backed scorers: the preprocessor function to use for trace template variables. Set to null to disable preprocessing. If omitted, the traced project's default preprocessor will be used, falling back to the global 'thread' preprocessor.
    /// </summary>
    public readonly partial struct PreprocessorSavedFunctionId : global::System.IEquatable<PreprocessorSavedFunctionId>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PreprocessorSavedFunctionIdFunction? Function { get; init; }
#else
        public global::Braintrust.PreprocessorSavedFunctionIdFunction? Function { get; }
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
            out global::Braintrust.PreprocessorSavedFunctionIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.PreprocessorSavedFunctionIdFunction PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? PreprocessorGlobal { get; init; }
#else
        public global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? PreprocessorGlobal { get; }
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
            out global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? value)
        {
            value = PreprocessorGlobal;
            return IsPreprocessorGlobal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal PickPreprocessorGlobal() => IsPreprocessorGlobal
            ? PreprocessorGlobal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorGlobal' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? PreprocessorSavedFunctionIdVariant3 { get; init; }
#else
        public object? PreprocessorSavedFunctionIdVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreprocessorSavedFunctionIdVariant3))]
#endif
        public bool IsPreprocessorSavedFunctionIdVariant3 => PreprocessorSavedFunctionIdVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPreprocessorSavedFunctionIdVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = PreprocessorSavedFunctionIdVariant3;
            return IsPreprocessorSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickPreprocessorSavedFunctionIdVariant3() => IsPreprocessorSavedFunctionIdVariant3
            ? PreprocessorSavedFunctionIdVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreprocessorSavedFunctionIdVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreprocessorSavedFunctionId(global::Braintrust.PreprocessorSavedFunctionIdFunction value) => new PreprocessorSavedFunctionId((global::Braintrust.PreprocessorSavedFunctionIdFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.PreprocessorSavedFunctionIdFunction?(PreprocessorSavedFunctionId @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public PreprocessorSavedFunctionId(global::Braintrust.PreprocessorSavedFunctionIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreprocessorSavedFunctionId FromFunction(global::Braintrust.PreprocessorSavedFunctionIdFunction? value) => new PreprocessorSavedFunctionId(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreprocessorSavedFunctionId(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal value) => new PreprocessorSavedFunctionId((global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal?(PreprocessorSavedFunctionId @this) => @this.PreprocessorGlobal;

        /// <summary>
        /// 
        /// </summary>
        public PreprocessorSavedFunctionId(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? value)
        {
            PreprocessorGlobal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreprocessorSavedFunctionId FromPreprocessorGlobal(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? value) => new PreprocessorSavedFunctionId(value);

        /// <summary>
        /// 
        /// </summary>
        public PreprocessorSavedFunctionId(
            global::Braintrust.PreprocessorSavedFunctionIdFunction? function,
            global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal? preprocessorGlobal,
            object? preprocessorSavedFunctionIdVariant3
            )
        {
            Function = function;
            PreprocessorGlobal = preprocessorGlobal;
            PreprocessorSavedFunctionIdVariant3 = preprocessorSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PreprocessorSavedFunctionIdVariant3 as object ??
            PreprocessorGlobal as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            PreprocessorGlobal?.ToString() ??
            PreprocessorSavedFunctionIdVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsPreprocessorGlobal || IsPreprocessorSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.PreprocessorSavedFunctionIdFunction, TResult>? function = null,
            global::System.Func<global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal, TResult>? preprocessorGlobal = null,
            global::System.Func<object, TResult>? preprocessorSavedFunctionIdVariant3 = null,
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
            else if (IsPreprocessorGlobal && preprocessorGlobal != null)
            {
                return preprocessorGlobal(PreprocessorGlobal!);
            }
            else if (IsPreprocessorSavedFunctionIdVariant3 && preprocessorSavedFunctionIdVariant3 != null)
            {
                return preprocessorSavedFunctionIdVariant3(PreprocessorSavedFunctionIdVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.PreprocessorSavedFunctionIdFunction>? function = null,

            global::System.Action<global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal>? preprocessorGlobal = null,

            global::System.Action<object>? preprocessorSavedFunctionIdVariant3 = null,
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
            else if (IsPreprocessorGlobal)
            {
                preprocessorGlobal?.Invoke(PreprocessorGlobal!);
            }
            else if (IsPreprocessorSavedFunctionIdVariant3)
            {
                preprocessorSavedFunctionIdVariant3?.Invoke(PreprocessorSavedFunctionIdVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.PreprocessorSavedFunctionIdFunction>? function = null,
            global::System.Action<global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal>? preprocessorGlobal = null,
            global::System.Action<object>? preprocessorSavedFunctionIdVariant3 = null,
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
            else if (IsPreprocessorGlobal)
            {
                preprocessorGlobal?.Invoke(PreprocessorGlobal!);
            }
            else if (IsPreprocessorSavedFunctionIdVariant3)
            {
                preprocessorSavedFunctionIdVariant3?.Invoke(PreprocessorSavedFunctionIdVariant3!);
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
                typeof(global::Braintrust.PreprocessorSavedFunctionIdFunction),
                PreprocessorGlobal,
                typeof(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal),
                PreprocessorSavedFunctionIdVariant3,
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
        public bool Equals(PreprocessorSavedFunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PreprocessorSavedFunctionIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobal?>.Default.Equals(PreprocessorGlobal, other.PreprocessorGlobal) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PreprocessorSavedFunctionIdVariant3, other.PreprocessorSavedFunctionIdVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PreprocessorSavedFunctionId obj1, PreprocessorSavedFunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreprocessorSavedFunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PreprocessorSavedFunctionId obj1, PreprocessorSavedFunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreprocessorSavedFunctionId o && Equals(o);
        }
    }
}
