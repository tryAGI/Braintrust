#nullable enable

namespace Braintrust
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Delete ai_secret<br/>
        /// Delete an ai_secret object by its id
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> DeleteAiSecretIdAsync(
            global::System.Guid aiSecretId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}