#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Options for the view in the app
    /// </summary>
    public readonly partial struct ViewOptions : global::System.IEquatable<ViewOptions>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ViewOptionsMonitorViewOptions? MonitorViewOptions { get; init; }
#else
        public global::Braintrust.ViewOptionsMonitorViewOptions? MonitorViewOptions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorViewOptions))]
#endif
        public bool IsMonitorViewOptions => MonitorViewOptions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMonitorViewOptions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ViewOptionsMonitorViewOptions? value)
        {
            value = MonitorViewOptions;
            return IsMonitorViewOptions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions PickMonitorViewOptions() => MonitorViewOptions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorViewOptions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Braintrust.ViewOptionsTableViewOptions? TableViewOptions { get; init; }
#else
        public global::Braintrust.ViewOptionsTableViewOptions? TableViewOptions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TableViewOptions))]
#endif
        public bool IsTableViewOptions => TableViewOptions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTableViewOptions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Braintrust.ViewOptionsTableViewOptions? value)
        {
            value = TableViewOptions;
            return IsTableViewOptions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions PickTableViewOptions() => TableViewOptions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TableViewOptions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ViewOptions(global::Braintrust.ViewOptionsMonitorViewOptions value) => new ViewOptions((global::Braintrust.ViewOptionsMonitorViewOptions?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.ViewOptionsMonitorViewOptions?(ViewOptions @this) => @this.MonitorViewOptions;

        /// <summary>
        ///
        /// </summary>
        public ViewOptions(global::Braintrust.ViewOptionsMonitorViewOptions? value)
        {
            MonitorViewOptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViewOptions FromMonitorViewOptions(global::Braintrust.ViewOptionsMonitorViewOptions? value) => new ViewOptions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ViewOptions(global::Braintrust.ViewOptionsTableViewOptions value) => new ViewOptions((global::Braintrust.ViewOptionsTableViewOptions?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Braintrust.ViewOptionsTableViewOptions?(ViewOptions @this) => @this.TableViewOptions;

        /// <summary>
        ///
        /// </summary>
        public ViewOptions(global::Braintrust.ViewOptionsTableViewOptions? value)
        {
            TableViewOptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ViewOptions FromTableViewOptions(global::Braintrust.ViewOptionsTableViewOptions? value) => new ViewOptions(value);

        /// <summary>
        ///
        /// </summary>
        public ViewOptions(
            global::Braintrust.ViewOptionsMonitorViewOptions? monitorViewOptions,
            global::Braintrust.ViewOptionsTableViewOptions? tableViewOptions
            )
        {
            MonitorViewOptions = monitorViewOptions;
            TableViewOptions = tableViewOptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TableViewOptions as object ??
            MonitorViewOptions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MonitorViewOptions?.ToString() ??
            TableViewOptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMonitorViewOptions || IsTableViewOptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ViewOptionsMonitorViewOptions, TResult>? monitorViewOptions = null,
            global::System.Func<global::Braintrust.ViewOptionsTableViewOptions, TResult>? tableViewOptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MonitorViewOptions is { } __value0 && monitorViewOptions != null)
            {
                return monitorViewOptions(__value0);
            }
            else if (TableViewOptions is { } __value1 && tableViewOptions != null)
            {
                return tableViewOptions(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Braintrust.ViewOptionsMonitorViewOptions>? monitorViewOptions = null,

            global::System.Action<global::Braintrust.ViewOptionsTableViewOptions>? tableViewOptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MonitorViewOptions is { } __value0)
            {
                monitorViewOptions?.Invoke(__value0);
            }
            else if (TableViewOptions is { } __value1)
            {
                tableViewOptions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Braintrust.ViewOptionsMonitorViewOptions>? monitorViewOptions = null,
            global::System.Action<global::Braintrust.ViewOptionsTableViewOptions>? tableViewOptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MonitorViewOptions is { } __value0)
            {
                monitorViewOptions?.Invoke(__value0);
            }
            else if (TableViewOptions is { } __value1)
            {
                tableViewOptions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MonitorViewOptions,
                typeof(global::Braintrust.ViewOptionsMonitorViewOptions),
                TableViewOptions,
                typeof(global::Braintrust.ViewOptionsTableViewOptions),
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
        public bool Equals(ViewOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ViewOptionsMonitorViewOptions?>.Default.Equals(MonitorViewOptions, other.MonitorViewOptions) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ViewOptionsTableViewOptions?>.Default.Equals(TableViewOptions, other.TableViewOptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ViewOptions obj1, ViewOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ViewOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ViewOptions obj1, ViewOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ViewOptions o && Equals(o);
        }
    }
}
