#nullable enable

namespace Braintrust
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete api_key<br/>
        /// Delete an api_key object by its id
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ApiKey> DeleteApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}