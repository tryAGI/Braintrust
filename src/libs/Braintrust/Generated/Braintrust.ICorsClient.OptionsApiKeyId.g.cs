#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/api_key/{api_key_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}