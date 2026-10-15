
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDataSimulationConfigVariant2AgentVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataSimulationConfigVariant2AgentVariant2TypeJsonConverter))]
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Type Type { get; set; }

        /// <summary>
        /// Executable for the ACP agent subprocess, communicating over stdio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Arguments passed to the executable without shell interpretation<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Absolute working directory for the ACP session on the execution host
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cwd { get; set; }

        /// <summary>
        /// Deny ACP permission requests; this does not sandbox the subprocess<br/>
        /// Default Value: deny
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataSimulationConfigVariant2AgentVariant2PermissionsJsonConverter))]
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Permissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulationConfigVariant2AgentVariant2" /> class.
        /// </summary>
        /// <param name="command">
        /// Executable for the ACP agent subprocess, communicating over stdio
        /// </param>
        /// <param name="cwd">
        /// Absolute working directory for the ACP session on the execution host
        /// </param>
        /// <param name="type"></param>
        /// <param name="args">
        /// Arguments passed to the executable without shell interpretation<br/>
        /// Default Value: []
        /// </param>
        /// <param name="permissions">
        /// Deny ACP permission requests; this does not sandbox the subprocess<br/>
        /// Default Value: deny
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataSimulationConfigVariant2AgentVariant2(
            string command,
            string cwd,
            global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Type type,
            global::System.Collections.Generic.IList<string>? args,
            global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Permissions? permissions)
        {
            this.Type = type;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args;
            this.Cwd = cwd ?? throw new global::System.ArgumentNullException(nameof(cwd));
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulationConfigVariant2AgentVariant2" /> class.
        /// </summary>
        public FunctionDataSimulationConfigVariant2AgentVariant2()
        {
        }

    }
}