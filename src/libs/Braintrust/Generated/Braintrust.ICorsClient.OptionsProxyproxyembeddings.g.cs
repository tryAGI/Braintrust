#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/proxy/embeddings`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProxyproxyembeddingsAsync(
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}