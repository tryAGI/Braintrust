#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionDataNullish : global::System.IEquatable<FunctionDataNullish>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataNullishPrompt? Prompt { get; init; }
#else
        public global::Braintrust.FunctionDataNullishPrompt? Prompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataNullishCode? Code { get; init; }
#else
        public global::Braintrust.FunctionDataNullishCode? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// This feature is preliminary and unsupported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.GraphData? Graph { get; init; }
#else
        public global::Braintrust.GraphData? Graph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graph))]
#endif
        public bool IsGraph => Graph != null;

        /// <summary>
        /// A remote eval to run
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataNullishRemoteEval? RemoteEval { get; init; }
#else
        public global::Braintrust.FunctionDataNullishRemoteEval? RemoteEval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemoteEval))]
#endif
        public bool IsRemoteEval => RemoteEval != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataNullishGlobal? Global { get; init; }
#else
        public global::Braintrust.FunctionDataNullishGlobal? Global { get; }
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
#if NET6_0_OR_GREATER
        public global::Braintrust.FacetData? Facet { get; init; }
#else
        public global::Braintrust.FacetData? Facet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Facet))]
#endif
        public bool IsFacet => Facet != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.BatchedFacetData? BatchedFacet { get; init; }
#else
        public global::Braintrust.BatchedFacetData? BatchedFacet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchedFacet))]
#endif
        public bool IsBatchedFacet => BatchedFacet != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataNullishParameters? Parameters { get; init; }
#else
        public global::Braintrust.FunctionDataNullishParameters? Parameters { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Parameters))]
#endif
        public bool IsParameters => Parameters != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Value9 { get; init; }
#else
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value10 { get; init; }
#else
        public object? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FunctionDataNullishPrompt value) => new FunctionDataNullish((global::Braintrust.FunctionDataNullishPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataNullishPrompt?(FunctionDataNullish @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FunctionDataNullishPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FunctionDataNullishCode value) => new FunctionDataNullish((global::Braintrust.FunctionDataNullishCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataNullishCode?(FunctionDataNullish @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FunctionDataNullishCode? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.GraphData value) => new FunctionDataNullish((global::Braintrust.GraphData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.GraphData?(FunctionDataNullish @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.GraphData? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FunctionDataNullishRemoteEval value) => new FunctionDataNullish((global::Braintrust.FunctionDataNullishRemoteEval?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataNullishRemoteEval?(FunctionDataNullish @this) => @this.RemoteEval;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FunctionDataNullishRemoteEval? value)
        {
            RemoteEval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FunctionDataNullishGlobal value) => new FunctionDataNullish((global::Braintrust.FunctionDataNullishGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataNullishGlobal?(FunctionDataNullish @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FunctionDataNullishGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FacetData value) => new FunctionDataNullish((global::Braintrust.FacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FacetData?(FunctionDataNullish @this) => @this.Facet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FacetData? value)
        {
            Facet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.BatchedFacetData value) => new FunctionDataNullish((global::Braintrust.BatchedFacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.BatchedFacetData?(FunctionDataNullish @this) => @this.BatchedFacet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.BatchedFacetData? value)
        {
            BatchedFacet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.FunctionDataNullishParameters value) => new FunctionDataNullish((global::Braintrust.FunctionDataNullishParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataNullishParameters?(FunctionDataNullish @this) => @this.Parameters;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.FunctionDataNullishParameters? value)
        {
            Parameters = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object> value) => new FunctionDataNullish((global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?(FunctionDataNullish @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(
            global::Braintrust.FunctionDataNullishPrompt? prompt,
            global::Braintrust.FunctionDataNullishCode? code,
            global::Braintrust.GraphData? graph,
            global::Braintrust.FunctionDataNullishRemoteEval? remoteEval,
            global::Braintrust.FunctionDataNullishGlobal? global,
            global::Braintrust.FacetData? facet,
            global::Braintrust.BatchedFacetData? batchedFacet,
            global::Braintrust.FunctionDataNullishParameters? parameters,
            global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value9,
            object? value10
            )
        {
            Prompt = prompt;
            Code = code;
            Graph = graph;
            RemoteEval = remoteEval;
            Global = global;
            Facet = facet;
            BatchedFacet = batchedFacet;
            Parameters = parameters;
            Value9 = value9;
            Value10 = value10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value10 as object ??
            Value9 as object ??
            Parameters as object ??
            BatchedFacet as object ??
            Facet as object ??
            Global as object ??
            RemoteEval as object ??
            Graph as object ??
            Code as object ??
            Prompt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Prompt?.ToString() ??
            Code?.ToString() ??
            Graph?.ToString() ??
            RemoteEval?.ToString() ??
            Global?.ToString() ??
            Facet?.ToString() ??
            BatchedFacet?.ToString() ??
            Parameters?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt || IsCode || IsGraph || IsRemoteEval || IsGlobal || IsFacet || IsBatchedFacet || IsParameters || IsValue9 || IsValue10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FunctionDataNullishPrompt?, TResult>? prompt = null,
            global::System.Func<global::Braintrust.FunctionDataNullishCode?, TResult>? code = null,
            global::System.Func<global::Braintrust.GraphData?, TResult>? graph = null,
            global::System.Func<global::Braintrust.FunctionDataNullishRemoteEval?, TResult>? remoteEval = null,
            global::System.Func<global::Braintrust.FunctionDataNullishGlobal?, TResult>? global = null,
            global::System.Func<global::Braintrust.FacetData?, TResult>? facet = null,
            global::System.Func<global::Braintrust.BatchedFacetData?, TResult>? batchedFacet = null,
            global::System.Func<global::Braintrust.FunctionDataNullishParameters?, TResult>? parameters = null,
            global::System.Func<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?, TResult>? value9 = null,
            global::System.Func<object?, TResult>? value10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt && prompt != null)
            {
                return prompt(Prompt!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsGraph && graph != null)
            {
                return graph(Graph!);
            }
            else if (IsRemoteEval && remoteEval != null)
            {
                return remoteEval(RemoteEval!);
            }
            else if (IsGlobal && global != null)
            {
                return global(Global!);
            }
            else if (IsFacet && facet != null)
            {
                return facet(Facet!);
            }
            else if (IsBatchedFacet && batchedFacet != null)
            {
                return batchedFacet(BatchedFacet!);
            }
            else if (IsParameters && parameters != null)
            {
                return parameters(Parameters!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.FunctionDataNullishPrompt?>? prompt = null,
            global::System.Action<global::Braintrust.FunctionDataNullishCode?>? code = null,
            global::System.Action<global::Braintrust.GraphData?>? graph = null,
            global::System.Action<global::Braintrust.FunctionDataNullishRemoteEval?>? remoteEval = null,
            global::System.Action<global::Braintrust.FunctionDataNullishGlobal?>? global = null,
            global::System.Action<global::Braintrust.FacetData?>? facet = null,
            global::System.Action<global::Braintrust.BatchedFacetData?>? batchedFacet = null,
            global::System.Action<global::Braintrust.FunctionDataNullishParameters?>? parameters = null,
            global::System.Action<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>? value9 = null,
            global::System.Action<object?>? value10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsGraph)
            {
                graph?.Invoke(Graph!);
            }
            else if (IsRemoteEval)
            {
                remoteEval?.Invoke(RemoteEval!);
            }
            else if (IsGlobal)
            {
                global?.Invoke(Global!);
            }
            else if (IsFacet)
            {
                facet?.Invoke(Facet!);
            }
            else if (IsBatchedFacet)
            {
                batchedFacet?.Invoke(BatchedFacet!);
            }
            else if (IsParameters)
            {
                parameters?.Invoke(Parameters!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Prompt,
                typeof(global::Braintrust.FunctionDataNullishPrompt),
                Code,
                typeof(global::Braintrust.FunctionDataNullishCode),
                Graph,
                typeof(global::Braintrust.GraphData),
                RemoteEval,
                typeof(global::Braintrust.FunctionDataNullishRemoteEval),
                Global,
                typeof(global::Braintrust.FunctionDataNullishGlobal),
                Facet,
                typeof(global::Braintrust.FacetData),
                BatchedFacet,
                typeof(global::Braintrust.BatchedFacetData),
                Parameters,
                typeof(global::Braintrust.FunctionDataNullishParameters),
                Value9,
                typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>),
                Value10,
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
        public bool Equals(FunctionDataNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataNullishPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataNullishCode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.GraphData?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataNullishRemoteEval?>.Default.Equals(RemoteEval, other.RemoteEval) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataNullishGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetData?>.Default.Equals(Facet, other.Facet) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.BatchedFacetData?>.Default.Equals(BatchedFacet, other.BatchedFacet) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataNullishParameters?>.Default.Equals(Parameters, other.Parameters) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value10, other.Value10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionDataNullish obj1, FunctionDataNullish obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionDataNullish>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionDataNullish obj1, FunctionDataNullish obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionDataNullish o && Equals(o);
        }
    }
}
