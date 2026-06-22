#nullable enable

namespace Braintrust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create agent<br/>
        /// Create a new agent. If there is an existing agent with the same name as the one specified in the request, will return the existing agent unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Agent> PostAgentAsync(

            global::Braintrust.CreateAgent request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Create a new agent. If there is an existing agent with the same name as the one specified in the request, will return the existing agent unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.Agent>> PostAgentAsResponseAsync(

            global::Braintrust.CreateAgent request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Create a new agent. If there is an existing agent with the same name as the one specified in the request, will return the existing agent unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the agent belongs under
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
        global::System.Threading.Tasks.Task<global::Braintrust.Agent> PostAgentAsync(
            global::System.Guid projectId,
            string name,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}