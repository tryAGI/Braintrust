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
        public ViewOptions(
            global::Braintrust.ViewOptionsMonitorViewOptions? monitorViewOptions,
            global::Braintrust.ViewOptionsTableViewOptions? tableViewOptions,
            object? value3
            )
        {
            MonitorViewOptions = monitorViewOptions;
            TableViewOptions = tableViewOptions;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            TableViewOptions as object ??
            MonitorViewOptions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MonitorViewOptions?.ToString() ??
            TableViewOptions?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMonitorViewOptions || IsTableViewOptions || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Braintrust.ViewOptionsMonitorViewOptions?, TResult>? monitorViewOptions = null,
            global::System.Func<global::Braintrust.ViewOptionsTableViewOptions?, TResult>? tableViewOptions = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMonitorViewOptions && monitorViewOptions != null)
            {
                return monitorViewOptions(MonitorViewOptions!);
            }
            else if (IsTableViewOptions && tableViewOptions != null)
            {
                return tableViewOptions(TableViewOptions!);
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
            global::System.Action<global::Braintrust.ViewOptionsMonitorViewOptions?>? monitorViewOptions = null,
            global::System.Action<global::Braintrust.ViewOptionsTableViewOptions?>? tableViewOptions = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMonitorViewOptions)
            {
                monitorViewOptions?.Invoke(MonitorViewOptions!);
            }
            else if (IsTableViewOptions)
            {
                tableViewOptions?.Invoke(TableViewOptions!);
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
                MonitorViewOptions,
                typeof(global::Braintrust.ViewOptionsMonitorViewOptions),
                TableViewOptions,
                typeof(global::Braintrust.ViewOptionsTableViewOptions),
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
        public bool Equals(ViewOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ViewOptionsMonitorViewOptions?>.Default.Equals(MonitorViewOptions, other.MonitorViewOptions) &&
                global::System.Collections.Generic.EqualityComparer<global::Braintrust.ViewOptionsTableViewOptions?>.Default.Equals(TableViewOptions, other.TableViewOptions) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
