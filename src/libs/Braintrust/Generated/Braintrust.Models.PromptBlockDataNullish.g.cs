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
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
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
        public PromptBlockDataNullish(
            global::Braintrust.PromptBlockDataNullishChat? chat,
            global::Braintrust.PromptBlockDataNullishCompletion? completion,
            object? value3
            )
        {
            Chat = chat;
            Completion = completion;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Completion as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Completion?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat || IsCompletion || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.PromptBlockDataNullishChat?, TResult>? chat = null,
            global::System.Func<global::Braintrust.PromptBlockDataNullishCompletion?, TResult>? completion = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.PromptBlockDataNullishChat?>? chat = null,
            global::System.Action<global::Braintrust.PromptBlockDataNullishCompletion?>? completion = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                Value3,
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
        public bool Equals(PromptBlockDataNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataNullishChat?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.PromptBlockDataNullishCompletion?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
