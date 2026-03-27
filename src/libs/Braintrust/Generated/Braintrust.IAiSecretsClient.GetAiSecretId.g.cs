#nullable enable

namespace Braintrust
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Get ai_secret<br/>
        /// Get an ai_secret object by its id
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> GetAiSecretIdAsync(
            global::System.Guid aiSecretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}