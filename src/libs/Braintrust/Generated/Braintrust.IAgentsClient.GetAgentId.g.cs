#nullable enable

namespace Braintrust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get agent<br/>
        /// Get a agent object by its id
        /// </summary>
        /// <param name="agentId">
        /// Agent id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Agent> GetAgentIdAsync(
            global::System.Guid agentId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent<br/>
        /// Get a agent object by its id
        /// </summary>
        /// <param name="agentId">
        /// Agent id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.Agent>> GetAgentIdAsResponseAsync(
            global::System.Guid agentId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}