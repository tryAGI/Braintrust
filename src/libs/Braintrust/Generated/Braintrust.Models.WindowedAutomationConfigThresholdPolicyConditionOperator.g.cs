
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum WindowedAutomationConfigThresholdPolicyConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigThresholdPolicyConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigThresholdPolicyConditionOperator value)
        {
            return value switch
            {
                WindowedAutomationConfigThresholdPolicyConditionOperator.Eq => "eq",
                WindowedAutomationConfigThresholdPolicyConditionOperator.Gt => "gt",
                WindowedAutomationConfigThresholdPolicyConditionOperator.Gte => "gte",
                WindowedAutomationConfigThresholdPolicyConditionOperator.Lt => "lt",
                WindowedAutomationConfigThresholdPolicyConditionOperator.Lte => "lte",
                WindowedAutomationConfigThresholdPolicyConditionOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigThresholdPolicyConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => WindowedAutomationConfigThresholdPolicyConditionOperator.Eq,
                "gt" => WindowedAutomationConfigThresholdPolicyConditionOperator.Gt,
                "gte" => WindowedAutomationConfigThresholdPolicyConditionOperator.Gte,
                "lt" => WindowedAutomationConfigThresholdPolicyConditionOperator.Lt,
                "lte" => WindowedAutomationConfigThresholdPolicyConditionOperator.Lte,
                "neq" => WindowedAutomationConfigThresholdPolicyConditionOperator.Neq,
                _ => null,
            };
        }
    }
}