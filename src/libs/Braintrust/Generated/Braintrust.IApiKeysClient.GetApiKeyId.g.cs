#nullable enable

namespace Braintrust
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Get api_key<br/>
        /// Get an api_key object by its id
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ApiKey> GetApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}