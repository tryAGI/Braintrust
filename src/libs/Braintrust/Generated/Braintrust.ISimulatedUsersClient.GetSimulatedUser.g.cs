#nullable enable

namespace Braintrust
{
    public partial interface ISimulatedUsersClient
    {
        /// <summary>
        /// Get simulated user<br/>
        /// Retrieve a simulated user by its UUID within the specified project. Requires project read permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> GetSimulatedUserAsync(
            global::System.Guid projectId,
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get simulated user<br/>
        /// Retrieve a simulated user by its UUID within the specified project. Requires project read permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.SimulatedUser>> GetSimulatedUserAsResponseAsync(
            global::System.Guid projectId,
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}