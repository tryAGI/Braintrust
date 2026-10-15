
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Deny ACP permission requests; this does not sandbox the subprocess<br/>
    /// Default Value: deny
    /// </summary>
    public enum FunctionDataSimulationConfigVariant2AgentVariant2Permissions
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataSimulationConfigVariant2AgentVariant2PermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant2AgentVariant2Permissions value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant2AgentVariant2Permissions.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant2AgentVariant2Permissions? ToEnum(string value)
        {
            return value switch
            {
                "deny" => FunctionDataSimulationConfigVariant2AgentVariant2Permissions.Deny,
                _ => null,
            };
        }
    }
}