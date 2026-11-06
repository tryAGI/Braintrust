#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PromptBlockData : global::System.IEquatable<PromptBlockData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataChat? Chat { get; init; }
#else
        public global::Braintrust.PromptBlockDataChat? Chat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.PromptBlockDataChat? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat PickChat() => Chat is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataCompletion? Completion { get; init; }
#else
        public global::Braintrust.PromptBlockDataCompletion? Completion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompletion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.PromptBlockDataCompletion? value)
        {
            value = Completion;
            return IsCompletion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion PickCompletion() => Completion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataDecisions? Decisions { get; init; }
#else
        public global::Braintrust.PromptBlockDataDecisions? Decisions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Decisions))]
#endif
        public bool IsDecisions => Decisions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.PromptBlockDataDecisions? value)
        {
            value = Decisions;
            return IsDecisions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisions PickDecisions() => Decisions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Decisions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockData(global::Braintrust.PromptBlockDataChat value) => new PromptBlockData((global::Braintrust.PromptBlockDataChat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataChat?(PromptBlockData @this) => @this.Chat;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockData(global::Braintrust.PromptBlockDataChat? value)
        {
            Chat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockData FromChat(global::Braintrust.PromptBlockDataChat? value) => new PromptBlockData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockData(global::Braintrust.PromptBlockDataCompletion value) => new PromptBlockData((global::Braintrust.PromptBlockDataCompletion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataCompletion?(PromptBlockData @this) => @this.Completion;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockData(global::Braintrust.PromptBlockDataCompletion? value)
        {
            Completion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockData FromCompletion(global::Braintrust.PromptBlockDataCompletion? value) => new PromptBlockData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockData(global::Braintrust.PromptBlockDataDecisions value) => new PromptBlockData((global::Braintrust.PromptBlockDataDecisions?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataDecisions?(PromptBlockData @this) => @this.Decisions;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockData(global::Braintrust.PromptBlockDataDecisions? value)
        {
            Decisions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockData FromDecisions(global::Braintrust.PromptBlockDataDecisions? value) => new PromptBlockData(value);

        /// <summary>
        ///
        /// </summary>
        public PromptBlockData(
            global::Braintrust.PromptBlockDataChat? chat,
            global::Braintrust.PromptBlockDataCompletion? completion,
            global::Braintrust.PromptBlockDataDecisions? decisions
            )
        {
            Chat = chat;
            Completion = completion;
            Decisions = decisions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Decisions as object ??
            Completion as object ??
            Chat as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Completion?.ToString() ??
            Decisions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChat || IsCompletion || IsDecisions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.PromptBlockDataChat, TResult>? chat = null,
            global::System.Func<global::Braintrust.PromptBlockDataCompletion, TResult>? completion = null,
            global::System.Func<global::Braintrust.PromptBlockDataDecisions, TResult>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0 && chat != null)
            {
                return chat(__value0);
            }
            else if (Completion is { } __value1 && completion != null)
            {
                return completion(__value1);
            }
            else if (Decisions is { } __value2 && decisions != null)
            {
                return decisions(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.PromptBlockDataChat>? chat = null,

            global::System.Action<global::Braintrust.PromptBlockDataCompletion>? completion = null,

            global::System.Action<global::Braintrust.PromptBlockDataDecisions>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0)
            {
                chat?.Invoke(__value0);
            }
            else if (Completion is { } __value1)
            {
                completion?.Invoke(__value1);
            }
            else if (Decisions is { } __value2)
            {
                decisions?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.PromptBlockDataChat>? chat = null,
            global::System.Action<global::Braintrust.PromptBlockDataCompletion>? completion = null,
            global::System.Action<global::Braintrust.PromptBlockDataDecisions>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0)
            {
                chat?.Invoke(__value0);
            }
            else if (Completion is { } __value1)
            {
                completion?.Invoke(__value1);
            }
            else if (Decisions is { } __value2)
            {
                decisions?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::Braintrust.PromptBlockDataChat),
                Completion,
                typeof(global::Braintrust.PromptBlockDataCompletion),
                Decisions,
                typeof(global::Braintrust.PromptBlockDataDecisions),
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
        public bool Equals(PromptBlockData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataChat?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataCompletion?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataDecisions?>.Default.Equals(Decisions, other.Decisions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptBlockData obj1, PromptBlockData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptBlockData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptBlockData obj1, PromptBlockData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptBlockData o && Equals(o);
        }
    }
}
