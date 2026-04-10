#nullable enable

namespace Braintrust
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Partially update project<br/>
        /// Partially update a project object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Project> PatchProjectIdAsync(
            global::System.Guid projectId,

            global::Braintrust.PatchProject request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project<br/>
        /// Partially update a project object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description"></param>
        /// <param name="userId"></param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Project> PatchProjectIdAsync(
            global::System.Guid projectId,
            string? name = default,
            string? description = default,
            string? userId = default,
            global::Braintrust.AllOf<global::Braintrust.ProjectSettings, object>? settings = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}