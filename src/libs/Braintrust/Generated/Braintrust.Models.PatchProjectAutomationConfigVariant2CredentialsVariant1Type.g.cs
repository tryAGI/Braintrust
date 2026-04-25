
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchProjectAutomationConfigVariant2CredentialsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2CredentialsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2CredentialsVariant1Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2CredentialsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => PatchProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam,
                _ => null,
            };
        }
    }
}