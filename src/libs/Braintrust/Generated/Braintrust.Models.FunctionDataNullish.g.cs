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
        public bool TryPickPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FunctionDataNullishPrompt? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt PickPrompt() => IsPrompt
            ? Prompt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FunctionDataNullishCode? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode PickCode() => IsCode
            ? Code!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickGraph(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.GraphData? value)
        {
            value = Graph;
            return IsGraph;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.GraphData PickGraph() => IsGraph
            ? Graph!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Graph' but the value was {ToString()}.");

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
        public bool TryPickRemoteEval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FunctionDataNullishRemoteEval? value)
        {
            value = RemoteEval;
            return IsRemoteEval;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval PickRemoteEval() => IsRemoteEval
            ? RemoteEval!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RemoteEval' but the value was {ToString()}.");

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
        public bool TryPickGlobal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FunctionDataNullishGlobal? value)
        {
            value = Global;
            return IsGlobal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal PickGlobal() => IsGlobal
            ? Global!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Global' but the value was {ToString()}.");

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
        public bool TryPickFacet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FacetData? value)
        {
            value = Facet;
            return IsFacet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FacetData PickFacet() => IsFacet
            ? Facet!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Facet' but the value was {ToString()}.");

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
        public bool TryPickBatchedFacet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.BatchedFacetData? value)
        {
            value = BatchedFacet;
            return IsBatchedFacet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.BatchedFacetData PickBatchedFacet() => IsBatchedFacet
            ? BatchedFacet!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BatchedFacet' but the value was {ToString()}.");

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
        public bool TryPickParameters(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.FunctionDataNullishParameters? value)
        {
            value = Parameters;
            return IsParameters;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters PickParameters() => IsParameters
            ? Parameters!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Parameters' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? FunctionDataNullishVariant9 { get; init; }
#else
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? FunctionDataNullishVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionDataNullishVariant9))]
#endif
        public bool IsFunctionDataNullishVariant9 => FunctionDataNullishVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionDataNullishVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value)
        {
            value = FunctionDataNullishVariant9;
            return IsFunctionDataNullishVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object> PickFunctionDataNullishVariant9() => IsFunctionDataNullishVariant9
            ? FunctionDataNullishVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionDataNullishVariant9' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FunctionDataNullishVariant10 { get; init; }
#else
        public object? FunctionDataNullishVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionDataNullishVariant10))]
#endif
        public bool IsFunctionDataNullishVariant10 => FunctionDataNullishVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionDataNullishVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FunctionDataNullishVariant10;
            return IsFunctionDataNullishVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickFunctionDataNullishVariant10() => IsFunctionDataNullishVariant10
            ? FunctionDataNullishVariant10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionDataNullishVariant10' but the value was {ToString()}.");
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
        public static FunctionDataNullish FromPrompt(global::Braintrust.FunctionDataNullishPrompt? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromCode(global::Braintrust.FunctionDataNullishCode? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromGraph(global::Braintrust.GraphData? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromRemoteEval(global::Braintrust.FunctionDataNullishRemoteEval? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromGlobal(global::Braintrust.FunctionDataNullishGlobal? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromFacet(global::Braintrust.FacetData? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromBatchedFacet(global::Braintrust.BatchedFacetData? value) => new FunctionDataNullish(value);

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
        public static FunctionDataNullish FromParameters(global::Braintrust.FunctionDataNullishParameters? value) => new FunctionDataNullish(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object> value) => new FunctionDataNullish((global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?(FunctionDataNullish @this) => @this.FunctionDataNullishVariant9;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value)
        {
            FunctionDataNullishVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FunctionDataNullish FromFunctionDataNullishVariant9(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? value) => new FunctionDataNullish(value);

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
            global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? functionDataNullishVariant9,
            object? functionDataNullishVariant10
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
            FunctionDataNullishVariant9 = functionDataNullishVariant9;
            FunctionDataNullishVariant10 = functionDataNullishVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionDataNullishVariant10 as object ??
            FunctionDataNullishVariant9 as object ??
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
            FunctionDataNullishVariant9?.ToString() ??
            FunctionDataNullishVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt || IsCode || IsGraph || IsRemoteEval || IsGlobal || IsFacet || IsBatchedFacet || IsParameters || IsFunctionDataNullishVariant9 || IsFunctionDataNullishVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FunctionDataNullishPrompt, TResult>? prompt = null,
            global::System.Func<global::Braintrust.FunctionDataNullishCode, TResult>? code = null,
            global::System.Func<global::Braintrust.GraphData, TResult>? graph = null,
            global::System.Func<global::Braintrust.FunctionDataNullishRemoteEval, TResult>? remoteEval = null,
            global::System.Func<global::Braintrust.FunctionDataNullishGlobal, TResult>? global = null,
            global::System.Func<global::Braintrust.FacetData, TResult>? facet = null,
            global::System.Func<global::Braintrust.BatchedFacetData, TResult>? batchedFacet = null,
            global::System.Func<global::Braintrust.FunctionDataNullishParameters, TResult>? parameters = null,
            global::System.Func<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?, TResult>? functionDataNullishVariant9 = null,
            global::System.Func<object, TResult>? functionDataNullishVariant10 = null,
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
            else if (IsFunctionDataNullishVariant9 && functionDataNullishVariant9 != null)
            {
                return functionDataNullishVariant9(FunctionDataNullishVariant9!);
            }
            else if (IsFunctionDataNullishVariant10 && functionDataNullishVariant10 != null)
            {
                return functionDataNullishVariant10(FunctionDataNullishVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.FunctionDataNullishPrompt>? prompt = null,

            global::System.Action<global::Braintrust.FunctionDataNullishCode>? code = null,

            global::System.Action<global::Braintrust.GraphData>? graph = null,

            global::System.Action<global::Braintrust.FunctionDataNullishRemoteEval>? remoteEval = null,

            global::System.Action<global::Braintrust.FunctionDataNullishGlobal>? global = null,

            global::System.Action<global::Braintrust.FacetData>? facet = null,

            global::System.Action<global::Braintrust.BatchedFacetData>? batchedFacet = null,

            global::System.Action<global::Braintrust.FunctionDataNullishParameters>? parameters = null,

            global::System.Action<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>? functionDataNullishVariant9 = null,

            global::System.Action<object>? functionDataNullishVariant10 = null,
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
            else if (IsFunctionDataNullishVariant9)
            {
                functionDataNullishVariant9?.Invoke(FunctionDataNullishVariant9!);
            }
            else if (IsFunctionDataNullishVariant10)
            {
                functionDataNullishVariant10?.Invoke(FunctionDataNullishVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.FunctionDataNullishPrompt>? prompt = null,
            global::System.Action<global::Braintrust.FunctionDataNullishCode>? code = null,
            global::System.Action<global::Braintrust.GraphData>? graph = null,
            global::System.Action<global::Braintrust.FunctionDataNullishRemoteEval>? remoteEval = null,
            global::System.Action<global::Braintrust.FunctionDataNullishGlobal>? global = null,
            global::System.Action<global::Braintrust.FacetData>? facet = null,
            global::System.Action<global::Braintrust.BatchedFacetData>? batchedFacet = null,
            global::System.Action<global::Braintrust.FunctionDataNullishParameters>? parameters = null,
            global::System.Action<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>? functionDataNullishVariant9 = null,
            global::System.Action<object>? functionDataNullishVariant10 = null,
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
            else if (IsFunctionDataNullishVariant9)
            {
                functionDataNullishVariant9?.Invoke(FunctionDataNullishVariant9!);
            }
            else if (IsFunctionDataNullishVariant10)
            {
                functionDataNullishVariant10?.Invoke(FunctionDataNullishVariant10!);
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
                FunctionDataNullishVariant9,
                typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>),
                FunctionDataNullishVariant10,
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
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?>.Default.Equals(FunctionDataNullishVariant9, other.FunctionDataNullishVariant9) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FunctionDataNullishVariant10, other.FunctionDataNullishVariant10) 
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
