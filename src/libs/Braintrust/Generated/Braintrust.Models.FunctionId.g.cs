#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The function to evaluate
    /// </summary>
    public readonly partial struct FunctionId : global::System.IEquatable<FunctionId>
    {
        /// <summary>
        /// Function id
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdFunctionId1? Id1 { get; init; }
#else
        public global::Braintrust.FunctionIdFunctionId1? Id1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Id1))]
#endif
        public bool IsId1 => Id1 != null;

        /// <summary>
        /// Project name and slug
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdProjectSlug? ProjectSlug { get; init; }
#else
        public global::Braintrust.FunctionIdProjectSlug? ProjectSlug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectSlug))]
#endif
        public bool IsProjectSlug => ProjectSlug != null;

        /// <summary>
        /// Global function name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdGlobalFunction? GlobalFunction { get; init; }
#else
        public global::Braintrust.FunctionIdGlobalFunction? GlobalFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalFunction))]
#endif
        public bool IsGlobalFunction => GlobalFunction != null;

        /// <summary>
        /// Prompt session id
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdPromptSessionId? PromptSessionId { get; init; }
#else
        public global::Braintrust.FunctionIdPromptSessionId? PromptSessionId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptSessionId))]
#endif
        public bool IsPromptSessionId => PromptSessionId != null;

        /// <summary>
        /// Inline code function
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdInlineCode? InlineCode { get; init; }
#else
        public global::Braintrust.FunctionIdInlineCode? InlineCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineCode))]
#endif
        public bool IsInlineCode => InlineCode != null;

        /// <summary>
        /// Inline function definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdInlineFunction? InlineFunction { get; init; }
#else
        public global::Braintrust.FunctionIdInlineFunction? InlineFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineFunction))]
#endif
        public bool IsInlineFunction => InlineFunction != null;

        /// <summary>
        /// Inline prompt definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.FunctionIdInlinePrompt? InlinePrompt { get; init; }
#else
        public global::Braintrust.FunctionIdInlinePrompt? InlinePrompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlinePrompt))]
#endif
        public bool IsInlinePrompt => InlinePrompt != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdFunctionId1 value) => new FunctionId((global::Braintrust.FunctionIdFunctionId1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdFunctionId1?(FunctionId @this) => @this.Id1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdFunctionId1? value)
        {
            Id1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdProjectSlug value) => new FunctionId((global::Braintrust.FunctionIdProjectSlug?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdProjectSlug?(FunctionId @this) => @this.ProjectSlug;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdProjectSlug? value)
        {
            ProjectSlug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdGlobalFunction value) => new FunctionId((global::Braintrust.FunctionIdGlobalFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdGlobalFunction?(FunctionId @this) => @this.GlobalFunction;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdGlobalFunction? value)
        {
            GlobalFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdPromptSessionId value) => new FunctionId((global::Braintrust.FunctionIdPromptSessionId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdPromptSessionId?(FunctionId @this) => @this.PromptSessionId;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdPromptSessionId? value)
        {
            PromptSessionId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdInlineCode value) => new FunctionId((global::Braintrust.FunctionIdInlineCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdInlineCode?(FunctionId @this) => @this.InlineCode;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdInlineCode? value)
        {
            InlineCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdInlineFunction value) => new FunctionId((global::Braintrust.FunctionIdInlineFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdInlineFunction?(FunctionId @this) => @this.InlineFunction;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdInlineFunction? value)
        {
            InlineFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::Braintrust.FunctionIdInlinePrompt value) => new FunctionId((global::Braintrust.FunctionIdInlinePrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.FunctionIdInlinePrompt?(FunctionId @this) => @this.InlinePrompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::Braintrust.FunctionIdInlinePrompt? value)
        {
            InlinePrompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(
            global::Braintrust.FunctionIdFunctionId1? id1,
            global::Braintrust.FunctionIdProjectSlug? projectSlug,
            global::Braintrust.FunctionIdGlobalFunction? globalFunction,
            global::Braintrust.FunctionIdPromptSessionId? promptSessionId,
            global::Braintrust.FunctionIdInlineCode? inlineCode,
            global::Braintrust.FunctionIdInlineFunction? inlineFunction,
            global::Braintrust.FunctionIdInlinePrompt? inlinePrompt
            )
        {
            Id1 = id1;
            ProjectSlug = projectSlug;
            GlobalFunction = globalFunction;
            PromptSessionId = promptSessionId;
            InlineCode = inlineCode;
            InlineFunction = inlineFunction;
            InlinePrompt = inlinePrompt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlinePrompt as object ??
            InlineFunction as object ??
            InlineCode as object ??
            PromptSessionId as object ??
            GlobalFunction as object ??
            ProjectSlug as object ??
            Id1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Id1?.ToString() ??
            ProjectSlug?.ToString() ??
            GlobalFunction?.ToString() ??
            PromptSessionId?.ToString() ??
            InlineCode?.ToString() ??
            InlineFunction?.ToString() ??
            InlinePrompt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsId1 || IsProjectSlug || IsGlobalFunction || IsPromptSessionId || IsInlineCode || IsInlineFunction || IsInlinePrompt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.FunctionIdFunctionId1?, TResult>? id1 = null,
            global::System.Func<global::Braintrust.FunctionIdProjectSlug?, TResult>? projectSlug = null,
            global::System.Func<global::Braintrust.FunctionIdGlobalFunction?, TResult>? globalFunction = null,
            global::System.Func<global::Braintrust.FunctionIdPromptSessionId?, TResult>? promptSessionId = null,
            global::System.Func<global::Braintrust.FunctionIdInlineCode?, TResult>? inlineCode = null,
            global::System.Func<global::Braintrust.FunctionIdInlineFunction?, TResult>? inlineFunction = null,
            global::System.Func<global::Braintrust.FunctionIdInlinePrompt?, TResult>? inlinePrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsId1 && id1 != null)
            {
                return id1(Id1!);
            }
            else if (IsProjectSlug && projectSlug != null)
            {
                return projectSlug(ProjectSlug!);
            }
            else if (IsGlobalFunction && globalFunction != null)
            {
                return globalFunction(GlobalFunction!);
            }
            else if (IsPromptSessionId && promptSessionId != null)
            {
                return promptSessionId(PromptSessionId!);
            }
            else if (IsInlineCode && inlineCode != null)
            {
                return inlineCode(InlineCode!);
            }
            else if (IsInlineFunction && inlineFunction != null)
            {
                return inlineFunction(InlineFunction!);
            }
            else if (IsInlinePrompt && inlinePrompt != null)
            {
                return inlinePrompt(InlinePrompt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.FunctionIdFunctionId1?>? id1 = null,
            global::System.Action<global::Braintrust.FunctionIdProjectSlug?>? projectSlug = null,
            global::System.Action<global::Braintrust.FunctionIdGlobalFunction?>? globalFunction = null,
            global::System.Action<global::Braintrust.FunctionIdPromptSessionId?>? promptSessionId = null,
            global::System.Action<global::Braintrust.FunctionIdInlineCode?>? inlineCode = null,
            global::System.Action<global::Braintrust.FunctionIdInlineFunction?>? inlineFunction = null,
            global::System.Action<global::Braintrust.FunctionIdInlinePrompt?>? inlinePrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsId1)
            {
                id1?.Invoke(Id1!);
            }
            else if (IsProjectSlug)
            {
                projectSlug?.Invoke(ProjectSlug!);
            }
            else if (IsGlobalFunction)
            {
                globalFunction?.Invoke(GlobalFunction!);
            }
            else if (IsPromptSessionId)
            {
                promptSessionId?.Invoke(PromptSessionId!);
            }
            else if (IsInlineCode)
            {
                inlineCode?.Invoke(InlineCode!);
            }
            else if (IsInlineFunction)
            {
                inlineFunction?.Invoke(InlineFunction!);
            }
            else if (IsInlinePrompt)
            {
                inlinePrompt?.Invoke(InlinePrompt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Id1,
                typeof(global::Braintrust.FunctionIdFunctionId1),
                ProjectSlug,
                typeof(global::Braintrust.FunctionIdProjectSlug),
                GlobalFunction,
                typeof(global::Braintrust.FunctionIdGlobalFunction),
                PromptSessionId,
                typeof(global::Braintrust.FunctionIdPromptSessionId),
                InlineCode,
                typeof(global::Braintrust.FunctionIdInlineCode),
                InlineFunction,
                typeof(global::Braintrust.FunctionIdInlineFunction),
                InlinePrompt,
                typeof(global::Braintrust.FunctionIdInlinePrompt),
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
        public bool Equals(FunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdFunctionId1?>.Default.Equals(Id1, other.Id1) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdProjectSlug?>.Default.Equals(ProjectSlug, other.ProjectSlug) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdGlobalFunction?>.Default.Equals(GlobalFunction, other.GlobalFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdPromptSessionId?>.Default.Equals(PromptSessionId, other.PromptSessionId) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdInlineCode?>.Default.Equals(InlineCode, other.InlineCode) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdInlineFunction?>.Default.Equals(InlineFunction, other.InlineFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.FunctionIdInlinePrompt?>.Default.Equals(InlinePrompt, other.InlinePrompt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionId obj1, FunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionId obj1, FunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionId o && Equals(o);
        }
    }
}
