#nullable enable

namespace Braintrust
{
    public partial interface IIngestKeysClient
    {
        /// <summary>
        /// Create ingest key<br/>
        /// Create a publishable key for one existing project. Requires project create_acls permission. Ingest keys do not expire and remain valid until revoked. The configuration URL is returned on creation and can be retrieved again by listing the project's ingest keys.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.CreateIngestKeyResponse2>> CreateIngestKeyAsync(

            global::Braintrust.CreateIngestKeyRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create ingest key<br/>
        /// Create a publishable key for one existing project. Requires project create_acls permission. Ingest keys do not expire and remain valid until revoked. The configuration URL is returned on creation and can be retrieved again by listing the project's ingest keys.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.CreateIngestKeyResponse2>>> CreateIngestKeyAsResponseAsync(

            global::Braintrust.CreateIngestKeyRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create ingest key<br/>
        /// Create a publishable key for one existing project. Requires project create_acls permission. Ingest keys do not expire and remain valid until revoked. The configuration URL is returned on creation and can be retrieved again by listing the project's ingest keys.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.CreateIngestKeyResponse2>> CreateIngestKeyAsync(
            global::System.Guid projectId,
            string name,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}