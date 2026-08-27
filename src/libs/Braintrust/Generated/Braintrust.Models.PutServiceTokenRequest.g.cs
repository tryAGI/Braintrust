
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutServiceTokenRequest
    {
        /// <summary>
        /// Name of the service token. Does not have to be unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// The ID of the service account to which the token should belong. To create a service account, visit [**Settings &gt; Service tokens**](https://www.braintrust.dev/app/~/configuration/org/service-tokens) in the Braintrust UI or call [`PATCH /v1/organization/members`](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Number of seconds from now after which the service token should expire. If omitted, the token never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutServiceTokenRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the service token. Does not have to be unique
        /// </param>
        /// <param name="serviceAccountId">
        /// The ID of the service account to which the token should belong. To create a service account, visit [**Settings &gt; Service tokens**](https://www.braintrust.dev/app/~/configuration/org/service-tokens) in the Braintrust UI or call [`PATCH /v1/organization/members`](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership).
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </param>
        /// <param name="expiresInSeconds">
        /// Number of seconds from now after which the service token should expire. If omitted, the token never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutServiceTokenRequest(
            string name,
            string serviceAccountId,
            string? orgName,
            int? expiresInSeconds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrgName = orgName;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutServiceTokenRequest" /> class.
        /// </summary>
        public PutServiceTokenRequest()
        {
        }

    }
}