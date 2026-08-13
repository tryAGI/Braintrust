#nullable enable

namespace Braintrust
{
    public partial interface IProjectGroupsClient
    {
        /// <summary>
        /// Get project_group<br/>
        /// Get a project_group object by its id
        /// </summary>
        /// <param name="projectGroupId">
        /// ProjectGroup id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> GetProjectGroupIdAsync(
            global::System.Guid projectGroupId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get project_group<br/>
        /// Get a project_group object by its id
        /// </summary>
        /// <param name="projectGroupId">
        /// ProjectGroup id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ProjectGroup>> GetProjectGroupIdAsResponseAsync(
            global::System.Guid projectGroupId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}