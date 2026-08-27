
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectAutomationConfigVariant2CredentialsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant2CredentialsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2CredentialsVariant1Type value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2CredentialsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => CreateProjectAutomationConfigVariant2CredentialsVariant1Type.AwsIam,
                _ => null,
            };
        }
    }
}