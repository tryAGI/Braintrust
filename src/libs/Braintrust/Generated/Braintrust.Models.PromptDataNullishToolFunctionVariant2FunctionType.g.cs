
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptDataNullishToolFunctionVariant2FunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataNullishToolFunctionVariant2FunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataNullishToolFunctionVariant2FunctionType value)
        {
            return value switch
            {
                PromptDataNullishToolFunctionVariant2FunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataNullishToolFunctionVariant2FunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PromptDataNullishToolFunctionVariant2FunctionType.Function,
                _ => null,
            };
        }
    }
}