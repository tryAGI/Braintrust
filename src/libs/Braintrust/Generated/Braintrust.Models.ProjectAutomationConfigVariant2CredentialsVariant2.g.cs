
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAutomationConfigVariant2CredentialsVariant2(
            string serviceAccountEmail,
            global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type type)
        {
            this.Type = type;
            this.ServiceAccountEmail = serviceAccountEmail ?? throw new global::System.ArgumentNullException(nameof(serviceAccountEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant2CredentialsVariant2" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant2CredentialsVariant2()
        {
        }
    }
}