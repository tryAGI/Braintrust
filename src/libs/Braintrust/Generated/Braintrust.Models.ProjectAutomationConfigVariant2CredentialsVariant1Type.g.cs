
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectAutomationConfigVariant2CredentialsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2CredentialsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2CredentialsVariant1Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2CredentialsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => ProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam,
                _ => null,
            };
        }
    }
}