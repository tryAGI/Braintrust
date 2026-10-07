
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant2CredentialsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter))]
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type Type { get; set; }

        /// <summary>
        /// The GCP service account email to impersonate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountEmail { get; set; }

        /// <summary>
        /// The name of a Google workload identity federation credential configured in this organization's AI providers. Supported data planes can use it regardless of hosting environment. If omitted, the data plane's GCP identity is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_name")]
        public string? CredentialName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant2CredentialsVariant2" /> class.
        /// </summary>
        /// <param name="serviceAccountEmail">
        /// The GCP service account email to impersonate
        /// </param>
        /// <param name="type"></param>
        /// <param name="credentialName">
        /// The name of a Google workload identity federation credential configured in this organization's AI providers. Supported data planes can use it regardless of hosting environment. If omitted, the data plane's GCP identity is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAutomationConfigVariant2CredentialsVariant2(
            string serviceAccountEmail,
            global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type type,
            string? credentialName)
        {
            this.Type = type;
            this.ServiceAccountEmail = serviceAccountEmail ?? throw new global::System.ArgumentNullException(nameof(serviceAccountEmail));
            this.CredentialName = credentialName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant2CredentialsVariant2" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant2CredentialsVariant2()
        {
        }

    }
}