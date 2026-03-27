#nullable enable

namespace Braintrust
{
    public partial interface ICrossObjectClient
    {
        /// <summary>
        /// Cross-object insert<br/>
        /// Insert events and feedback across object types
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CrossObjectInsertResponse> PostCrossObjectInsertAsync(

            global::Braintrust.CrossObjectInsertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cross-object insert<br/>
        /// Insert events and feedback across object types
        /// </summary>
        /// <param name="experiment">
        /// A mapping from experiment id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="dataset">
        /// A mapping from dataset id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="projectLogs">
        /// A mapping from project id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CrossObjectInsertResponse> PostCrossObjectInsertAsync(
            global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>? experiment = default,
            global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>? dataset = default,
            global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>? projectLogs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}