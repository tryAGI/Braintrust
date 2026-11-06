#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PromptBlockDataNullish : global::System.IEquatable<PromptBlockDataNullish>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataNullishChat? Chat { get; init; }
#else
        public global::Braintrust.PromptBlockDataNullishChat? Chat { get; }
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
            out global::Braintrust.PromptBlockDataNullishChat? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat PickChat() => Chat is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataNullishCompletion? Completion { get; init; }
#else
        public global::Braintrust.PromptBlockDataNullishCompletion? Completion { get; }
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
            out global::Braintrust.PromptBlockDataNullishCompletion? value)
        {
            value = Completion;
            return IsCompletion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion PickCompletion() => Completion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.PromptBlockDataNullishDecisions? Decisions { get; init; }
#else
        public global::Braintrust.PromptBlockDataNullishDecisions? Decisions { get; }
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
            out global::Braintrust.PromptBlockDataNullishDecisions? value)
        {
            value = Decisions;
            return IsDecisions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisions PickDecisions() => Decisions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Decisions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishChat value) => new PromptBlockDataNullish((global::Braintrust.PromptBlockDataNullishChat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataNullishChat?(PromptBlockDataNullish @this) => @this.Chat;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishChat? value)
        {
            Chat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockDataNullish FromChat(global::Braintrust.PromptBlockDataNullishChat? value) => new PromptBlockDataNullish(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishCompletion value) => new PromptBlockDataNullish((global::Braintrust.PromptBlockDataNullishCompletion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataNullishCompletion?(PromptBlockDataNullish @this) => @this.Completion;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishCompletion? value)
        {
            Completion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockDataNullish FromCompletion(global::Braintrust.PromptBlockDataNullishCompletion? value) => new PromptBlockDataNullish(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishDecisions value) => new PromptBlockDataNullish((global::Braintrust.PromptBlockDataNullishDecisions?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.PromptBlockDataNullishDecisions?(PromptBlockDataNullish @this) => @this.Decisions;

        /// <summary>
        ///
        /// </summary>
        public PromptBlockDataNullish(global::Braintrust.PromptBlockDataNullishDecisions? value)
        {
            Decisions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlockDataNullish FromDecisions(global::Braintrust.PromptBlockDataNullishDecisions? value) => new PromptBlockDataNullish(value);

        /// <summary>
        ///
        /// </summary>
        public PromptBlockDataNullish(
            global::Braintrust.PromptBlockDataNullishChat? chat,
            global::Braintrust.PromptBlockDataNullishCompletion? completion,
            global::Braintrust.PromptBlockDataNullishDecisions? decisions
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
            global::System.Func<global::Braintrust.PromptBlockDataNullishChat, TResult>? chat = null,
            global::System.Func<global::Braintrust.PromptBlockDataNullishCompletion, TResult>? completion = null,
            global::System.Func<global::Braintrust.PromptBlockDataNullishDecisions, TResult>? decisions = null,
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
            global::System.Action<global::Braintrust.PromptBlockDataNullishChat>? chat = null,

            global::System.Action<global::Braintrust.PromptBlockDataNullishCompletion>? completion = null,

            global::System.Action<global::Braintrust.PromptBlockDataNullishDecisions>? decisions = null,
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
            global::System.Action<global::Braintrust.PromptBlockDataNullishChat>? chat = null,
            global::System.Action<global::Braintrust.PromptBlockDataNullishCompletion>? completion = null,
            global::System.Action<global::Braintrust.PromptBlockDataNullishDecisions>? decisions = null,
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
                typeof(global::Braintrust.PromptBlockDataNullishChat),
                Completion,
                typeof(global::Braintrust.PromptBlockDataNullishCompletion),
                Decisions,
                typeof(global::Braintrust.PromptBlockDataNullishDecisions),
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
        public bool Equals(PromptBlockDataNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataNullishChat?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataNullishCompletion?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataNullishDecisions?>.Default.Equals(Decisions, other.Decisions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptBlockDataNullish obj1, PromptBlockDataNullish obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptBlockDataNullish>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptBlockDataNullish obj1, PromptBlockDataNullish obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptBlockDataNullish o && Equals(o);
        }
    }
}
