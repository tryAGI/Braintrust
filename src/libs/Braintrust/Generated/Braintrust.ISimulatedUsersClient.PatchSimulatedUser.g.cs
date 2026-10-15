#nullable enable

namespace Braintrust
{
    public partial interface ISimulatedUsersClient
    {
        /// <summary>
        /// Update simulated user<br/>
        /// Update an existing simulated user while preserving its UUID. Supplied voice_config replaces the entire voice configuration. Set goal to null to clear it. Requires project update permission and project read permission because the response includes the stored simulated user.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> PatchSimulatedUserAsync(
            global::System.Guid projectId,
            global::System.Guid id,

            global::Braintrust.PatchSimulatedUser request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update simulated user<br/>
        /// Update an existing simulated user while preserving its UUID. Supplied voice_config replaces the entire voice configuration. Set goal to null to clear it. Requires project update permission and project read permission because the response includes the stored simulated user.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.SimulatedUser>> PatchSimulatedUserAsResponseAsync(
            global::System.Guid projectId,
            global::System.Guid id,

            global::Braintrust.PatchSimulatedUser request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update simulated user<br/>
        /// Update an existing simulated user while preserving its UUID. Supplied voice_config replaces the entire voice configuration. Set goal to null to clear it. Requires project update permission and project read permission because the response includes the stored simulated user.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="name">
        /// Name of the simulated user
        /// </param>
        /// <param name="instructions">
        /// The simulated user's role, scenario, and behavior
        /// </param>
        /// <param name="goal">
        /// The simulated user's objective. Set to null to clear it.
        /// </param>
        /// <param name="voiceConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> PatchSimulatedUserAsync(
            global::System.Guid projectId,
            global::System.Guid id,
            string? name = default,
            string? instructions = default,
            string? goal = default,
            global::Braintrust.SimulatedUserVoiceConfig? voiceConfig = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}