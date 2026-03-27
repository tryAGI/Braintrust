#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionContentPart : global::System.IEquatable<ChatCompletionContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Text { get; init; }
#else
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? ImageUrl { get; init; }
#else
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? File { get; init; }
#else
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartTextWithTitle value) => new ChatCompletionContentPart((global::Braintrust.ChatCompletionContentPartTextWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionContentPartTextWithTitle?(ChatCompletionContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartTextWithTitle? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartImageWithTitle value) => new ChatCompletionContentPart((global::Braintrust.ChatCompletionContentPartImageWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionContentPartImageWithTitle?(ChatCompletionContentPart @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartImageWithTitle? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartFileWithTitle value) => new ChatCompletionContentPart((global::Braintrust.ChatCompletionContentPartFileWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Braintrust.ChatCompletionContentPartFileWithTitle?(ChatCompletionContentPart @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::Braintrust.ChatCompletionContentPartFileWithTitle? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(
            global::Braintrust.ChatCompletionContentPartTextWithTitle? text,
            global::Braintrust.ChatCompletionContentPartImageWithTitle? imageUrl,
            global::Braintrust.ChatCompletionContentPartFileWithTitle? file
            )
        {
            Text = text;
            ImageUrl = imageUrl;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImageUrl || IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ChatCompletionContentPartTextWithTitle?, TResult>? text = null,
            global::System.Func<global::Braintrust.ChatCompletionContentPartImageWithTitle?, TResult>? imageUrl = null,
            global::System.Func<global::Braintrust.ChatCompletionContentPartFileWithTitle?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ChatCompletionContentPartTextWithTitle?>? text = null,
            global::System.Action<global::Braintrust.ChatCompletionContentPartImageWithTitle?>? imageUrl = null,
            global::System.Action<global::Braintrust.ChatCompletionContentPartFileWithTitle?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Braintrust.ChatCompletionContentPartTextWithTitle),
                ImageUrl,
                typeof(global::Braintrust.ChatCompletionContentPartImageWithTitle),
                File,
                typeof(global::Braintrust.ChatCompletionContentPartFileWithTitle),
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
        public bool Equals(ChatCompletionContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionContentPartTextWithTitle?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionContentPartImageWithTitle?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ChatCompletionContentPartFileWithTitle?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionContentPart obj1, ChatCompletionContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionContentPart obj1, ChatCompletionContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionContentPart o && Equals(o);
        }
    }
}
