#nullable enable

namespace Braintrust
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Create AI secret<br/>
        /// Create a new AI secret. If there is an existing AI secret with the same name as the one specified in the request, will return the existing AI secret unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> PostAiSecretAsync(

            global::Braintrust.CreateAISecret request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create AI secret<br/>
        /// Create a new AI secret. If there is an existing AI secret with the same name as the one specified in the request, will return the existing AI secret unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.AISecret>> PostAiSecretAsResponseAsync(

            global::Braintrust.CreateAISecret request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create AI secret<br/>
        /// Create a new AI secret. If there is an existing AI secret with the same name as the one specified in the request, will return the existing AI secret unmodified
        /// </summary>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="secret">
        /// Secret value. If omitted in a PUT request, the existing secret value will be left intact, not replaced with null.
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the AI Secret belongs in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> PostAiSecretAsync(
            string name,
            string? type = default,
            object? metadata = default,
            string? secret = default,
            string? orgName = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}