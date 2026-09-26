
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of the object the environment variable is scoped for
    /// </summary>
    public enum PostEnvVarRequestObjectType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        McpServer,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostEnvVarRequestObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostEnvVarRequestObjectType value)
        {
            return value switch
            {
                PostEnvVarRequestObjectType.Function => "function",
                PostEnvVarRequestObjectType.McpServer => "mcp_server",
                PostEnvVarRequestObjectType.Organization => "organization",
                PostEnvVarRequestObjectType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostEnvVarRequestObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PostEnvVarRequestObjectType.Function,
                "mcp_server" => PostEnvVarRequestObjectType.McpServer,
                "organization" => PostEnvVarRequestObjectType.Organization,
                "project" => PostEnvVarRequestObjectType.Project,
                _ => null,
            };
        }
    }
}