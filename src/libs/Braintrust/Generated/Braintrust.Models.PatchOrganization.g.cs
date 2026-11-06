
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchOrganization
    {
        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchOrganization" /> class.
        /// </summary>
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
        /// <param name="imageRenderingMode">
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganization(
            string? name,
            string? apiUrl,
            bool? isUniversalApi,
            bool? isDataplanePrivate,
            string? proxyUrl,
            string? realtimeUrl,
            global::Braintrust.ImageRenderingMode? imageRenderingMode)
        {
            this.Name = name;
            this.ApiUrl = apiUrl;
            this.IsUniversalApi = isUniversalApi;
            this.IsDataplanePrivate = isDataplanePrivate;
            this.ProxyUrl = proxyUrl;
            this.RealtimeUrl = realtimeUrl;
            this.ImageRenderingMode = imageRenderingMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganization" /> class.
        /// </summary>
        public PatchOrganization()
        {
        }

    }
}