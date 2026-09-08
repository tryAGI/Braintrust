#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The return value of a scorer function.
    /// </summary>
    public readonly partial struct ScoreResult : global::System.IEquatable<ScoreResult>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ScoreObject? ObjectValue { get; init; }
#else
        public global::Braintrust.ScoreObject? ObjectValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ScoreObject? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreObject PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.NamedScore? Named { get; init; }
#else
        public global::Braintrust.NamedScore? Named { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Named))]
#endif
        public bool IsNamed => Named != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNamed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.NamedScore? value)
        {
            value = Named;
            return IsNamed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NamedScore PickNamed() => IsNamed
            ? Named!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Named' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.AnyOf<double?, bool?>? ScoreResultVariant3 { get; init; }
#else
        public global::Braintrust.AnyOf<double?, bool?>? ScoreResultVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreResultVariant3))]
#endif
        public bool IsScoreResultVariant3 => ScoreResultVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreResultVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.AnyOf<double?, bool?>? value)
        {
            value = ScoreResultVariant3;
            return IsScoreResultVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<double?, bool?> PickScoreResultVariant3() => IsScoreResultVariant3
            ? ScoreResultVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreResultVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Multiple scores. Each score must have a unique name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? ScoreResultVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? ScoreResultVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreResultVariant4))]
#endif
        public bool IsScoreResultVariant4 => ScoreResultVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreResultVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? value)
        {
            value = ScoreResultVariant4;
            return IsScoreResultVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.NamedScore> PickScoreResultVariant4() => IsScoreResultVariant4
            ? ScoreResultVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreResultVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ScoreResultVariant5 { get; init; }
#else
        public object? ScoreResultVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreResultVariant5))]
#endif
        public bool IsScoreResultVariant5 => ScoreResultVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreResultVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ScoreResultVariant5;
            return IsScoreResultVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickScoreResultVariant5() => IsScoreResultVariant5
            ? ScoreResultVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreResultVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreResult(global::Braintrust.ScoreObject value) => new ScoreResult((global::Braintrust.ScoreObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.ScoreObject?(ScoreResult @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public ScoreResult(global::Braintrust.ScoreObject? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreResult FromObjectValue(global::Braintrust.ScoreObject? value) => new ScoreResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreResult(global::Braintrust.NamedScore value) => new ScoreResult((global::Braintrust.NamedScore?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.NamedScore?(ScoreResult @this) => @this.Named;

        /// <summary>
        ///
        /// </summary>
        public ScoreResult(global::Braintrust.NamedScore? value)
        {
            Named = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreResult FromNamed(global::Braintrust.NamedScore? value) => new ScoreResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScoreResult(global::Braintrust.AnyOf<double?, bool?> value) => new ScoreResult((global::Braintrust.AnyOf<double?, bool?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.AnyOf<double?, bool?>?(ScoreResult @this) => @this.ScoreResultVariant3;

        /// <summary>
        ///
        /// </summary>
        public ScoreResult(global::Braintrust.AnyOf<double?, bool?>? value)
        {
            ScoreResultVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScoreResult FromScoreResultVariant3(global::Braintrust.AnyOf<double?, bool?>? value) => new ScoreResult(value);

        /// <summary>
        ///
        /// </summary>
        public ScoreResult(
            global::Braintrust.ScoreObject? objectValue,
            global::Braintrust.NamedScore? named,
            global::Braintrust.AnyOf<double?, bool?>? scoreResultVariant3,
            global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? scoreResultVariant4,
            object? scoreResultVariant5
            )
        {
            ObjectValue = objectValue;
            Named = named;
            ScoreResultVariant3 = scoreResultVariant3;
            ScoreResultVariant4 = scoreResultVariant4;
            ScoreResultVariant5 = scoreResultVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScoreResultVariant5 as object ??
            ScoreResultVariant4 as object ??
            ScoreResultVariant3 as object ??
            Named as object ??
            ObjectValue as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ObjectValue?.ToString() ??
            Named?.ToString() ??
            ScoreResultVariant3?.ToString() ??
            ScoreResultVariant4?.ToString() ??
            ScoreResultVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsObjectValue || IsNamed || IsScoreResultVariant3 || IsScoreResultVariant4 || IsScoreResultVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ScoreObject, TResult>? objectValue = null,
            global::System.Func<global::Braintrust.NamedScore, TResult>? named = null,
            global::System.Func<global::Braintrust.AnyOf<double?, bool?>?, TResult>? scoreResultVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>, TResult>? scoreResultVariant4 = null,
            global::System.Func<object, TResult>? scoreResultVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsNamed && named != null)
            {
                return named(Named!);
            }
            else if (IsScoreResultVariant3 && scoreResultVariant3 != null)
            {
                return scoreResultVariant3(ScoreResultVariant3!);
            }
            else if (IsScoreResultVariant4 && scoreResultVariant4 != null)
            {
                return scoreResultVariant4(ScoreResultVariant4!);
            }
            else if (IsScoreResultVariant5 && scoreResultVariant5 != null)
            {
                return scoreResultVariant5(ScoreResultVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ScoreObject>? objectValue = null,

            global::System.Action<global::Braintrust.NamedScore>? named = null,

            global::System.Action<global::Braintrust.AnyOf<double?, bool?>?>? scoreResultVariant3 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>>? scoreResultVariant4 = null,

            global::System.Action<object>? scoreResultVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsNamed)
            {
                named?.Invoke(Named!);
            }
            else if (IsScoreResultVariant3)
            {
                scoreResultVariant3?.Invoke(ScoreResultVariant3!);
            }
            else if (IsScoreResultVariant4)
            {
                scoreResultVariant4?.Invoke(ScoreResultVariant4!);
            }
            else if (IsScoreResultVariant5)
            {
                scoreResultVariant5?.Invoke(ScoreResultVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.ScoreObject>? objectValue = null,
            global::System.Action<global::Braintrust.NamedScore>? named = null,
            global::System.Action<global::Braintrust.AnyOf<double?, bool?>?>? scoreResultVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>>? scoreResultVariant4 = null,
            global::System.Action<object>? scoreResultVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsNamed)
            {
                named?.Invoke(Named!);
            }
            else if (IsScoreResultVariant3)
            {
                scoreResultVariant3?.Invoke(ScoreResultVariant3!);
            }
            else if (IsScoreResultVariant4)
            {
                scoreResultVariant4?.Invoke(ScoreResultVariant4!);
            }
            else if (IsScoreResultVariant5)
            {
                scoreResultVariant5?.Invoke(ScoreResultVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectValue,
                typeof(global::Braintrust.ScoreObject),
                Named,
                typeof(global::Braintrust.NamedScore),
                ScoreResultVariant3,
                typeof(global::Braintrust.AnyOf<double?, bool?>),
                ScoreResultVariant4,
                typeof(global::System.Collections.Generic.IList<global::Braintrust.NamedScore>),
                ScoreResultVariant5,
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
        public bool Equals(ScoreResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ScoreObject?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.NamedScore?>.Default.Equals(Named, other.Named) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.AnyOf<double?, bool?>?>.Default.Equals(ScoreResultVariant3, other.ScoreResultVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Braintrust.NamedScore>?>.Default.Equals(ScoreResultVariant4, other.ScoreResultVariant4) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ScoreResultVariant5, other.ScoreResultVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScoreResult obj1, ScoreResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScoreResult obj1, ScoreResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreResult o && Equals(o);
        }
    }
}
