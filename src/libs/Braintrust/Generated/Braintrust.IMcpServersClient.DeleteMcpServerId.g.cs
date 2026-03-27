#nullable enable

namespace Braintrust
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Delete mcp_server<br/>
        /// Delete a mcp_server object by its id
        /// </summary>
        /// <param name="mcpServerId">
        /// McpServer id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.MCPServer> DeleteMcpServerIdAsync(
            global::System.Guid mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}