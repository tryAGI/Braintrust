
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL of the organization's data plane API. If unset, the Braintrust-hosted API is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_url")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// Whether the data plane at `api_url` also serves the AI proxy, at `api_url` with `/v1/proxy` appended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_universal_api")]
        public bool? IsUniversalApi { get; set; }

        /// <summary>
        /// Whether the organization's data plane is only reachable from a private network
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dataplane_private")]
        public bool? IsDataplanePrivate { get; set; }

        /// <summary>
        /// URL of the organization's AI proxy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_url")]
        public string? ProxyUrl { get; set; }

        /// <summary>
        /// URL of the organization's realtime service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime_url")]
        public string? RealtimeUrl { get; set; }

        /// <summary>
        /// Date of organization creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date the organization was archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Date the organization was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_rendering_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ImageRenderingModeJsonConverter))]
        public global::Braintrust.ImageRenderingMode? ImageRenderingMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="name">
        /// Name of the organization
        /// </param>
        /// <param name="apiUrl">
        /// URL of the organization's data plane API. If unset, the Braintrust-hosted API is used.
        /// </param>
        /// <param name="isUniversalApi">
        /// Whether the data plane at `api_url` also serves the AI proxy, at `api_url` with `/v1/proxy` appended
        /// </param>
        /// <param name="isDataplanePrivate">
        /// Whether the organization's data plane is only reachable from a private network
        /// </param>
        /// <param name="proxyUrl">
        /// URL of the organization's AI proxy
        /// </param>
        /// <param name="realtimeUrl">
        /// URL of the organization's realtime service
        /// </param>
        /// <param name="created">
        /// Date of organization creation
        /// </param>
        /// <param name="archivedAt">
        /// Date the organization was archived
        /// </param>
        /// <param name="deletedAt">
        /// Date the organization was deleted
        /// </param>
        /// <param name="imageRenderingMode">
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            global::System.Guid id,
            string name,
            string? apiUrl,
            bool? isUniversalApi,
            bool? isDataplanePrivate,
            string? proxyUrl,
            string? realtimeUrl,
            global::System.DateTime? created,
            global::System.DateTime? archivedAt,
            global::System.DateTime? deletedAt,
            global::Braintrust.ImageRenderingMode? imageRenderingMode)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiUrl = apiUrl;
            this.IsUniversalApi = isUniversalApi;
            this.IsDataplanePrivate = isDataplanePrivate;
            this.ProxyUrl = proxyUrl;
            this.RealtimeUrl = realtimeUrl;
            this.Created = created;
            this.ArchivedAt = archivedAt;
            this.DeletedAt = deletedAt;
            this.ImageRenderingMode = imageRenderingMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }

    }
}