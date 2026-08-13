#nullable enable

namespace Braintrust
{
    public partial interface IProjectGroupsClient
    {
        /// <summary>
        /// Partially update project_group<br/>
        /// Partially update a project_group object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectGroupId">
        /// ProjectGroup id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PatchProjectGroupIdAsync(
            global::System.Guid projectGroupId,

            global::Braintrust.PatchProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_group<br/>
        /// Partially update a project_group object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectGroupId">
        /// ProjectGroup id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ProjectGroup>> PatchProjectGroupIdAsResponseAsync(
            global::System.Guid projectGroupId,

            global::Braintrust.PatchProjectGroup request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_group<br/>
        /// Partially update a project_group object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectGroupId">
        /// ProjectGroup id
        /// </param>
        /// <param name="name">
        /// Name of the project group
        /// </param>
        /// <param name="description">
        /// Textual description of the project group
        /// </param>
        /// <param name="addMemberProjects">
        /// A list of project IDs to add to the project group
        /// </param>
        /// <param name="removeMemberProjects">
        /// A list of project IDs to remove from the project group
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectGroup> PatchProjectGroupIdAsync(
            global::System.Guid projectGroupId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberProjects = default,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberProjects = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}