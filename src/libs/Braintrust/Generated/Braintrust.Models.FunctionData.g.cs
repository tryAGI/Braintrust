#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionData : global::System.IEquatable<FunctionData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionDataPrompt? Prompt { get; init; }
#else
        public global::Braintrust.FunctionDataPrompt? Prompt { get; }
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
        public global::Braintrust.FunctionDataCode? Code { get; init; }
#else
        public global::Braintrust.FunctionDataCode? Code { get; }
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
        public global::Braintrust.FunctionDataRemoteEval? RemoteEval { get; init; }
#else
        public global::Braintrust.FunctionDataRemoteEval? RemoteEval { get; }
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
        public global::Braintrust.FunctionDataGlobal? Global { get; init; }
#else
        public global::Braintrust.FunctionDataGlobal? Global { get; }
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
        public global::Braintrust.FunctionDataParameters? Parameters { get; init; }
#else
        public global::Braintrust.FunctionDataParameters? Parameters { get; }
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
        public static implicit operator FunctionData(global::Braintrust.FunctionDataPrompt value) => new FunctionData((global::Braintrust.FunctionDataPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataPrompt?(FunctionData @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FunctionDataPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.FunctionDataCode value) => new FunctionData((global::Braintrust.FunctionDataCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataCode?(FunctionData @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FunctionDataCode? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.GraphData value) => new FunctionData((global::Braintrust.GraphData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.GraphData?(FunctionData @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.GraphData? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.FunctionDataRemoteEval value) => new FunctionData((global::Braintrust.FunctionDataRemoteEval?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataRemoteEval?(FunctionData @this) => @this.RemoteEval;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FunctionDataRemoteEval? value)
        {
            RemoteEval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.FunctionDataGlobal value) => new FunctionData((global::Braintrust.FunctionDataGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataGlobal?(FunctionData @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FunctionDataGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.FacetData value) => new FunctionData((global::Braintrust.FacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FacetData?(FunctionData @this) => @this.Facet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FacetData? value)
        {
            Facet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.BatchedFacetData value) => new FunctionData((global::Braintrust.BatchedFacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.BatchedFacetData?(FunctionData @this) => @this.BatchedFacet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.BatchedFacetData? value)
        {
            BatchedFacet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.FunctionDataParameters value) => new FunctionData((global::Braintrust.FunctionDataParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionDataParameters?(FunctionData @this) => @this.Parameters;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.FunctionDataParameters? value)
        {
            Parameters = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object> value) => new FunctionData((global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?(FunctionData @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(
            global::Braintrust.FunctionDataPrompt? prompt,
            global::Braintrust.FunctionDataCode? code,
            global::Braintrust.GraphData? graph,
            global::Braintrust.FunctionDataRemoteEval? remoteEval,
            global::Braintrust.FunctionDataGlobal? global,
            global::Braintrust.FacetData? facet,
            global::Braintrust.BatchedFacetData? batchedFacet,
            global::Braintrust.FunctionDataParameters? parameters,
            global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value9
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value9?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt || IsCode || IsGraph || IsRemoteEval || IsGlobal || IsFacet || IsBatchedFacet || IsParameters || IsValue9;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FunctionDataPrompt?, TResult>? prompt = null,
            global::System.Func<global::Braintrust.FunctionDataCode?, TResult>? code = null,
            global::System.Func<global::Braintrust.GraphData?, TResult>? graph = null,
            global::System.Func<global::Braintrust.FunctionDataRemoteEval?, TResult>? remoteEval = null,
            global::System.Func<global::Braintrust.FunctionDataGlobal?, TResult>? global = null,
            global::System.Func<global::Braintrust.FacetData?, TResult>? facet = null,
            global::System.Func<global::Braintrust.BatchedFacetData?, TResult>? batchedFacet = null,
            global::System.Func<global::Braintrust.FunctionDataParameters?, TResult>? parameters = null,
            global::System.Func<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?, TResult>? value9 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.FunctionDataPrompt?>? prompt = null,
            global::System.Action<global::Braintrust.FunctionDataCode?>? code = null,
            global::System.Action<global::Braintrust.GraphData?>? graph = null,
            global::System.Action<global::Braintrust.FunctionDataRemoteEval?>? remoteEval = null,
            global::System.Action<global::Braintrust.FunctionDataGlobal?>? global = null,
            global::System.Action<global::Braintrust.FacetData?>? facet = null,
            global::System.Action<global::Braintrust.BatchedFacetData?>? batchedFacet = null,
            global::System.Action<global::Braintrust.FunctionDataParameters?>? parameters = null,
            global::System.Action<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>? value9 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Prompt,
                typeof(global::Braintrust.FunctionDataPrompt),
                Code,
                typeof(global::Braintrust.FunctionDataCode),
                Graph,
                typeof(global::Braintrust.GraphData),
                RemoteEval,
                typeof(global::Braintrust.FunctionDataRemoteEval),
                Global,
                typeof(global::Braintrust.FunctionDataGlobal),
                Facet,
                typeof(global::Braintrust.FacetData),
                BatchedFacet,
                typeof(global::Braintrust.BatchedFacetData),
                Parameters,
                typeof(global::Braintrust.FunctionDataParameters),
                Value9,
                typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>),
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
        public bool Equals(FunctionData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataCode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.GraphData?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataRemoteEval?>.Default.Equals(RemoteEval, other.RemoteEval) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FacetData?>.Default.Equals(Facet, other.Facet) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.BatchedFacetData?>.Default.Equals(BatchedFacet, other.BatchedFacet) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionDataParameters?>.Default.Equals(Parameters, other.Parameters) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>.Default.Equals(Value9, other.Value9) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionData obj1, FunctionData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionData obj1, FunctionData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionData o && Equals(o);
        }
    }
}
