#nullable enable

namespace Braintrust
{
    public partial interface ICustomColumnsClient
    {
        /// <summary>
        /// Create custom column<br/>
        /// Create a new custom column. If there is an existing custom column with the same name in the same scope, will return the existing custom column unmodified. Requires update permission on the scoping object.<br/>
        /// Custom columns are scoped to a specific table by the combination of `object_type`, `object_id`, `subtype`, and `variant`. Use the same scope when creating and listing columns. Use these combinations to display columns in the corresponding UI table:<br/>
        /// | Page | `object_type` | `object_id` | `subtype` | `variant` |<br/>
        /// | --- | --- | --- | --- | --- |<br/>
        /// | Dataset | `dataset` | Dataset ID | `""` | `dataset` |<br/>
        /// | Project logs | `project` | Project ID | `project_log` | `project_log` |<br/>
        /// | Experiment details | `project` | Project ID | `experiment` | `experiment` |<br/>
        /// | Experiments list | `project` | Project ID | `experiment` | `experiment_list` |<br/>
        /// Experiment span columns apply across experiments in the project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CustomColumn> PostCustomColumnAsync(

            global::Braintrust.CreateCustomColumn request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom column<br/>
        /// Create a new custom column. If there is an existing custom column with the same name in the same scope, will return the existing custom column unmodified. Requires update permission on the scoping object.<br/>
        /// Custom columns are scoped to a specific table by the combination of `object_type`, `object_id`, `subtype`, and `variant`. Use the same scope when creating and listing columns. Use these combinations to display columns in the corresponding UI table:<br/>
        /// | Page | `object_type` | `object_id` | `subtype` | `variant` |<br/>
        /// | --- | --- | --- | --- | --- |<br/>
        /// | Dataset | `dataset` | Dataset ID | `""` | `dataset` |<br/>
        /// | Project logs | `project` | Project ID | `project_log` | `project_log` |<br/>
        /// | Experiment details | `project` | Project ID | `experiment` | `experiment` |<br/>
        /// | Experiments list | `project` | Project ID | `experiment` | `experiment_list` |<br/>
        /// Experiment span columns apply across experiments in the project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.CustomColumn>> PostCustomColumnAsResponseAsync(

            global::Braintrust.CreateCustomColumn request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom column<br/>
        /// Create a new custom column. If there is an existing custom column with the same name in the same scope, will return the existing custom column unmodified. Requires update permission on the scoping object.<br/>
        /// Custom columns are scoped to a specific table by the combination of `object_type`, `object_id`, `subtype`, and `variant`. Use the same scope when creating and listing columns. Use these combinations to display columns in the corresponding UI table:<br/>
        /// | Page | `object_type` | `object_id` | `subtype` | `variant` |<br/>
        /// | --- | --- | --- | --- | --- |<br/>
        /// | Dataset | `dataset` | Dataset ID | `""` | `dataset` |<br/>
        /// | Project logs | `project` | Project ID | `project_log` | `project_log` |<br/>
        /// | Experiment details | `project` | Project ID | `experiment` | `experiment` |<br/>
        /// | Experiments list | `project` | Project ID | `experiment` | `experiment_list` |<br/>
        /// Experiment span columns apply across experiments in the project.
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="objectId">
        /// The ID of the scoping object. Use the project ID for project logs, experiment spans, and the experiments list. Use the dataset ID for dataset rows
        /// </param>
        /// <param name="subtype">
        /// The child object type the custom column applies to, such as `experiment` or `project_log`. Use an empty string when the column applies directly to the scoping object, such as a dataset
        /// </param>
        /// <param name="variant"></param>
        /// <param name="name">
        /// The name of the custom column
        /// </param>
        /// <param name="expr">
        /// The expression used to extract the value for the custom column
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CustomColumn> PostCustomColumnAsync(
            global::Braintrust.AllOf<global::Braintrust.AclObjectType?, object> objectType,
            global::System.Guid objectId,
            global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?> subtype,
            string name,
            string expr,
            global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? variant = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}