#nullable enable

namespace Braintrust
{
    public partial interface IIngestKeysClient
    {
        /// <summary>
        /// Revoke ingest key<br/>
        /// Revoke an ingest key. Requires project delete_acls permission. Cached authorization remains valid until the existing key caches expire.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.IngestKey> DeleteIngestKeyAsync(
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke ingest key<br/>
        /// Revoke an ingest key. Requires project delete_acls permission. Cached authorization remains valid until the existing key caches expire.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.IngestKey>> DeleteIngestKeyAsResponseAsync(
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}