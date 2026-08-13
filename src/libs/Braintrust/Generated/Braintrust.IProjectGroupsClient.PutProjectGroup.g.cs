#nullable enable

namespace Braintrust
{
    public partial interface IProjectGroupsClient
    {
        /// <summary>
        /// Create or replace project_group<br/>
        /// Create or replace project_group. If there is an existing project_group with the same name as the one specified in the request, will replace the existing project_group with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PutProjectGroupAsync(

            global::Braintrust.CreateProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace project_group<br/>
        /// Create or replace project_group. If there is an existing project_group with the same name as the one specified in the request, will replace the existing project_group with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ProjectGroup>> PutProjectGroupAsResponseAsync(

            global::Braintrust.CreateProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace project_group<br/>
        /// Create or replace project_group. If there is an existing project_group with the same name as the one specified in the request, will replace the existing project_group with the provided fields
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
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PutProjectGroupAsync(
            string name,
            string? description = default,
            string? orgName = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}