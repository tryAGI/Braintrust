#nullable enable

namespace Braintrust
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Partially update ai_secret<br/>
        /// Partially update an ai_secret object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> PatchAiSecretIdAsync(
            global::System.Guid aiSecretId,

            global::Braintrust.PatchAISecret request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update ai_secret<br/>
        /// Partially update an ai_secret object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="secret"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> PatchAiSecretIdAsync(
            global::System.Guid aiSecretId,
            string? name = default,
            string? type = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            string? secret = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}