#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/project_tag/{project_tag_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="projectTagId">
        /// ProjectTag id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProjectTagIdAsync(
            global::System.Guid projectTagId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}