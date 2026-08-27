
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchOrganizationMembersInviteUsersServiceAccount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional name of an initial service token to create for the new service account. This is a narrow compatibility carve-out only on PATCH /v1/organization/members. When this field is set, the request must be authenticated with a service token that has organization-owner permissions, not a user API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_name")]
        public string? TokenName { get; set; }

        /// <summary>
        /// Number of seconds from now after which the initial service token should expire. If omitted, the token never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_expires_in_seconds")]
        public int? TokenExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsersServiceAccount" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tokenName">
        /// Optional name of an initial service token to create for the new service account. This is a narrow compatibility carve-out only on PATCH /v1/organization/members. When this field is set, the request must be authenticated with a service token that has organization-owner permissions, not a user API key.
        /// </param>
        /// <param name="tokenExpiresInSeconds">
        /// Number of seconds from now after which the initial service token should expire. If omitted, the token never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationMembersInviteUsersServiceAccount(
            string name,
            string? tokenName,
            int? tokenExpiresInSeconds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenName = tokenName;
            this.TokenExpiresInSeconds = tokenExpiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsersServiceAccount" /> class.
        /// </summary>
        public PatchOrganizationMembersInviteUsersServiceAccount()
        {
        }

    }
}