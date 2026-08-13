#nullable enable

namespace Braintrust
{
    public partial interface IProjectGroupsClient
    {
        /// <summary>
        /// Create project_group<br/>
        /// Create a new project_group. If there is an existing project_group with the same name as the one specified in the request, will return the existing project_group unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PostProjectGroupAsync(

            global::Braintrust.CreateProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_group<br/>
        /// Create a new project_group. If there is an existing project_group with the same name as the one specified in the request, will return the existing project_group unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ProjectGroup>> PostProjectGroupAsResponseAsync(

            global::Braintrust.CreateProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_group<br/>
        /// Create a new project_group. If there is an existing project_group with the same name as the one specified in the request, will return the existing project_group unmodified
        /// </summary>
        /// <param name="name">
        /// Name of the project group
        /// </param>
        /// <param name="description">
        /// Textual description of the project group
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project group belongs in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PostProjectGroupAsync(
            string name,
            string? description = default,
            string? orgName = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}