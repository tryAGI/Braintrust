
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The category of the secret: env_var for regular environment variables, ai_provider for AI provider API keys<br/>
    /// Default Value: env_var
    /// </summary>
    public enum EnvVarSecretCategory
    {
        /// <summary>
        /// env_var for regular environment variables, ai_provider for AI provider API keys
        /// </summary>
        AiProvider,
        /// <summary>
        ///
        /// </summary>
        AutomationIntegration,
        /// <summary>
        /// env_var for regular environment variables, ai_provider for AI provider API keys
        /// </summary>
        EnvVar,
        /// <summary>
        ///
        /// </summary>
        SandboxProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvVarSecretCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvVarSecretCategory value)
        {
            return value switch
            {
                EnvVarSecretCategory.AiProvider => "ai_provider",
                EnvVarSecretCategory.AutomationIntegration => "automation_integration",
                EnvVarSecretCategory.EnvVar => "env_var",
                EnvVarSecretCategory.SandboxProvider => "sandbox_provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvVarSecretCategory? ToEnum(string value)
        {
            return value switch
            {
                "ai_provider" => EnvVarSecretCategory.AiProvider,
                "automation_integration" => EnvVarSecretCategory.AutomationIntegration,
                "env_var" => EnvVarSecretCategory.EnvVar,
                "sandbox_provider" => EnvVarSecretCategory.SandboxProvider,
                _ => null,
            };
        }
    }
}