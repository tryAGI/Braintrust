#nullable enable

namespace Braintrust
{
    public partial interface ICustomColumnsClient
    {
        /// <summary>
        /// List custom columns<br/>
        /// List the custom columns defined for a table. Requires read permission on the scoping object.<br/>
        /// Custom columns are scoped to a specific table by the combination of `object_type`, `object_id`, `subtype`, and `variant`. Use the same scope when creating and listing columns. Use these combinations to display columns in the corresponding UI table:<br/>
        /// | Page | `object_type` | `object_id` | `subtype` | `variant` |<br/>
        /// | --- | --- | --- | --- | --- |<br/>
        /// | Dataset | `dataset` | Dataset ID | `""` | `dataset` |<br/>
        /// | Project logs | `project` | Project ID | `project_log` | `project_log` |<br/>
        /// | Experiment details | `project` | Project ID | `experiment` | `experiment` |<br/>
        /// | Experiments list | `project` | Project ID | `experiment` | `experiment_list` |<br/>
        /// Experiment span columns apply across experiments in the project.
        /// </summary>
        /// <param name="objectType">
        /// The type of the object the custom column is scoped to, usually `project`
        /// </param>
        /// <param name="objectId">
        /// The ID of the scoping object. Use the project ID for project logs, experiment spans, and the experiments list. Use the dataset ID for dataset rows
        /// </param>
        /// <param name="subtype">
        /// The child object type the custom column applies to, such as `experiment` or `project_log`. Use an empty string when the column applies directly to the scoping object, such as a dataset
        /// </param>
        /// <param name="variant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.GetCustomColumnResponse> GetCustomColumnAsync(
            global::Braintrust.GetCustomColumnObjectType objectType,
            global::System.Guid objectId,
            global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.GetCustomColumnSubtype2?>? subtype = default,
            global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? variant = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom columns<br/>
        /// List the custom columns defined for a table. Requires read permission on the scoping object.<br/>
        /// Custom columns are scoped to a specific table by the combination of `object_type`, `object_id`, `subtype`, and `variant`. Use the same scope when creating and listing columns. Use these combinations to display columns in the corresponding UI table:<br/>
        /// | Page | `object_type` | `object_id` | `subtype` | `variant` |<br/>
        /// | --- | --- | --- | --- | --- |<br/>
        /// | Dataset | `dataset` | Dataset ID | `""` | `dataset` |<br/>
        /// | Project logs | `project` | Project ID | `project_log` | `project_log` |<br/>
        /// | Experiment details | `project` | Project ID | `experiment` | `experiment` |<br/>
        /// | Experiments list | `project` | Project ID | `experiment` | `experiment_list` |<br/>
        /// Experiment span columns apply across experiments in the project.
        /// </summary>
        /// <param name="objectType">
        /// The type of the object the custom column is scoped to, usually `project`
        /// </param>
        /// <param name="objectId">
        /// The ID of the scoping object. Use the project ID for project logs, experiment spans, and the experiments list. Use the dataset ID for dataset rows
        /// </param>
        /// <param name="subtype">
        /// The child object type the custom column applies to, such as `experiment` or `project_log`. Use an empty string when the column applies directly to the scoping object, such as a dataset
        /// </param>
        /// <param name="variant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.GetCustomColumnResponse>> GetCustomColumnAsResponseAsync(
            global::Braintrust.GetCustomColumnObjectType objectType,
            global::System.Guid objectId,
            global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.GetCustomColumnSubtype2?>? subtype = default,
            global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? variant = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}