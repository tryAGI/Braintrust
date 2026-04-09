#nullable enable

namespace Braintrust
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Partially update project_automation<br/>
        /// Partially update a project_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> PatchProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,

            global::Braintrust.PatchProjectAutomation request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_automation<br/>
        /// Partially update a project_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the automation rule
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> PatchProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            string? name = default,
            string? description = default,
            global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}