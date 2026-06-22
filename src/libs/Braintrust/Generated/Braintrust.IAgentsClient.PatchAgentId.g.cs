#nullable enable

namespace Braintrust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Partially update agent<br/>
        /// Partially update a agent object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="agentId">
        /// Agent id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Agent> PatchAgentIdAsync(
            global::System.Guid agentId,

            global::Braintrust.PatchAgent request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update agent<br/>
        /// Partially update a agent object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="agentId">
        /// Agent id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.Agent>> PatchAgentIdAsResponseAsync(
            global::System.Guid agentId,

            global::Braintrust.PatchAgent request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update agent<br/>
        /// Partially update a agent object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="agentId">
        /// Agent id
        /// </param>
        /// <param name="name">
        /// Name of the agent. Within a project, agent names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the agent
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the agent
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Agent> PatchAgentIdAsync(
            global::System.Guid agentId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}