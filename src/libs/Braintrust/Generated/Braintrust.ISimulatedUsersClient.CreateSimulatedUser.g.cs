#nullable enable

namespace Braintrust
{
    public partial interface ISimulatedUsersClient
    {
        /// <summary>
        /// Create simulated user<br/>
        /// Create a simulated user with a new UUID. Display names may repeat. Requires project update permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> CreateSimulatedUserAsync(
            global::System.Guid projectId,

            global::Braintrust.CreateSimulatedUser request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create simulated user<br/>
        /// Create a simulated user with a new UUID. Display names may repeat. Requires project update permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.SimulatedUser>> CreateSimulatedUserAsResponseAsync(
            global::System.Guid projectId,

            global::Braintrust.CreateSimulatedUser request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create simulated user<br/>
        /// Create a simulated user with a new UUID. Display names may repeat. Requires project update permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the simulated user
        /// </param>
        /// <param name="instructions">
        /// The simulated user's role, scenario, and behavior
        /// </param>
        /// <param name="goal">
        /// The simulated user's objective, used to decide when to end the conversation
        /// </param>
        /// <param name="voiceConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> CreateSimulatedUserAsync(
            global::System.Guid projectId,
            string name,
            string instructions,
            global::Braintrust.SimulatedUserVoiceConfig voiceConfig,
            string? goal = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}