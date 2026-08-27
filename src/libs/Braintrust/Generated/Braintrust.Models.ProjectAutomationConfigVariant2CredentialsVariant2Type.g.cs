
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectAutomationConfigVariant2CredentialsVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        GcpServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2CredentialsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2CredentialsVariant2Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2CredentialsVariant2Type.GcpServiceAccount => "gcp_service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2CredentialsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "gcp_service_account" => ProjectAutomationConfigVariant2CredentialsVariant2Type.GcpServiceAccount,
                _ => null,
            };
        }
    }
}