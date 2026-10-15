#nullable enable

namespace Braintrust
{
    public partial interface ISimulatedUsersClient
    {
        /// <summary>
        /// Delete simulated user<br/>
        /// Delete an existing simulated user in the specified project. Requires project update permission and project read permission because the response includes the stored simulated user.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SimulatedUser> DeleteSimulatedUserAsync(
            global::System.Guid projectId,
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete simulated user<br/>
        /// Delete an existing simulated user in the specified project. Requires project update permission and project read permission because the response includes the stored simulated user.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.SimulatedUser>> DeleteSimulatedUserAsResponseAsync(
            global::System.Guid projectId,
            global::System.Guid id,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}