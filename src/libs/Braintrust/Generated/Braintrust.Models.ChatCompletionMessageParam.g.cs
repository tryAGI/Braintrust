#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionMessageParam : global::System.IEquatable<ChatCompletionMessageParam>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamSystem? System { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamSystem? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamUser? User { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamUser? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamAssistant? Assistant { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamAssistant? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamTool? Tool { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamTool? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamFunction? Function { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamFunction? Function { get; }
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
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Developer { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Developer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionMessageParamFallback? Fallback { get; init; }
#else
        public global::Braintrust.ChatCompletionMessageParamFallback? Fallback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fallback))]
#endif
        public bool IsFallback => Fallback != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamSystem value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamSystem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamSystem?(ChatCompletionMessageParam @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamSystem? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamUser value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamUser?(ChatCompletionMessageParam @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamUser? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamAssistant value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamAssistant?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamAssistant?(ChatCompletionMessageParam @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamAssistant? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamTool value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamTool?(ChatCompletionMessageParam @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamFunction value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamFunction?(ChatCompletionMessageParam @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamDeveloper value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamDeveloper?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamDeveloper?(ChatCompletionMessageParam @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamDeveloper? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamFallback value) => new ChatCompletionMessageParam((global::Braintrust.ChatCompletionMessageParamFallback?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionMessageParamFallback?(ChatCompletionMessageParam @this) => @this.Fallback;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Braintrust.ChatCompletionMessageParamFallback? value)
        {
            Fallback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(
            global::Braintrust.ChatCompletionMessageParamSystem? system,
            global::Braintrust.ChatCompletionMessageParamUser? user,
            global::Braintrust.ChatCompletionMessageParamAssistant? assistant,
            global::Braintrust.ChatCompletionMessageParamTool? tool,
            global::Braintrust.ChatCompletionMessageParamFunction? function,
            global::Braintrust.ChatCompletionMessageParamDeveloper? developer,
            global::Braintrust.ChatCompletionMessageParamFallback? fallback
            )
        {
            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
            Developer = developer;
            Fallback = fallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fallback as object ??
            Developer as object ??
            Function as object ??
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString() ??
            Function?.ToString() ??
            Developer?.ToString() ??
            Fallback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem || IsUser || IsAssistant || IsTool || IsFunction || IsDeveloper || IsFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ChatCompletionMessageParamSystem?, TResult>? system = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamUser?, TResult>? user = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamAssistant?, TResult>? assistant = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamTool?, TResult>? tool = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamFunction?, TResult>? function = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamDeveloper?, TResult>? developer = null,
            global::System.Func<global::Braintrust.ChatCompletionMessageParamFallback?, TResult>? fallback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }
            else if (IsFallback && fallback != null)
            {
                return fallback(Fallback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ChatCompletionMessageParamSystem?>? system = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamUser?>? user = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamAssistant?>? assistant = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamTool?>? tool = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamFunction?>? function = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamDeveloper?>? developer = null,
            global::System.Action<global::Braintrust.ChatCompletionMessageParamFallback?>? fallback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsFallback)
            {
                fallback?.Invoke(Fallback!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::Braintrust.ChatCompletionMessageParamSystem),
                User,
                typeof(global::Braintrust.ChatCompletionMessageParamUser),
                Assistant,
                typeof(global::Braintrust.ChatCompletionMessageParamAssistant),
                Tool,
                typeof(global::Braintrust.ChatCompletionMessageParamTool),
                Function,
                typeof(global::Braintrust.ChatCompletionMessageParamFunction),
                Developer,
                typeof(global::Braintrust.ChatCompletionMessageParamDeveloper),
                Fallback,
                typeof(global::Braintrust.ChatCompletionMessageParamFallback),
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
        public bool Equals(ChatCompletionMessageParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamSystem?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamUser?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamAssistant?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamTool?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamDeveloper?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionMessageParamFallback?>.Default.Equals(Fallback, other.Fallback) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageParam o && Equals(o);
        }
    }
}
