/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Braintrust.IntegrationTests;

public partial class Tests
{
    //// Braintrust provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// prompt management and experiment tracking.

    [TestMethod]
    public async Task Meai_AsListProjectsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists all projects:
        var tool = client.AsListProjectsTool(limit: 5);

        tool.Name.Should().Be("ListProjects");
        tool.Description.Should().Contain("projects");

        //// The tool returns a JSON array of project objects with `id` and `name` fields.
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListProjects result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsListPromptsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available prompts:
        var tool = client.AsListPromptsTool(limit: 5);

        tool.Name.Should().Be("ListPrompts");
        tool.Description.Should().Contain("prompt");

        //// The tool accepts an optional `projectName` parameter to filter prompts.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments { ["projectName"] = null },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListPrompts result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsGetPromptTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that retrieves a prompt by slug:
        var tool = client.AsGetPromptTool();

        tool.Name.Should().Be("GetPrompt");
        tool.Description.Should().Contain("slug");
    }

    [TestMethod]
    public async Task Meai_AsListExperimentsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists experiments:
        var tool = client.AsListExperimentsTool(limit: 5);

        tool.Name.Should().Be("ListExperiments");
        tool.Description.Should().Contain("experiment");

        //// The tool accepts an optional `projectName` parameter to filter experiments.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments { ["projectName"] = null },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListExperiments result: {result}");
    }
}
