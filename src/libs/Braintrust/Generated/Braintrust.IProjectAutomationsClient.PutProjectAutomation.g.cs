#nullable enable

namespace Braintrust
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Create or replace project_automation<br/>
        /// Create or replace project_automation. If there is an existing project_automation with the same name as the one specified in the request, will replace the existing project_automation with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> PutProjectAutomationAsync(

            global::Braintrust.CreateProjectAutomation request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace project_automation<br/>
        /// Create or replace project_automation. If there is an existing project_automation with the same name as the one specified in the request, will replace the existing project_automation with the provided fields
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project automation belongs under
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
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> PutProjectAutomationAsync(
            global::System.Guid projectId,
            string name,
            global::Braintrust.AnyOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig> config,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}