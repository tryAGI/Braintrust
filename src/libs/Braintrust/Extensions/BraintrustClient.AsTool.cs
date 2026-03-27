#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Braintrust;

/// <summary>
/// Extensions for using BraintrustClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class BraintrustToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available prompts.
    /// Useful for agents that need to discover prompt templates.
    /// </summary>
    /// <param name="client">The Braintrust client.</param>
    /// <param name="limit">Maximum number of prompts to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPromptsTool(
        this BraintrustClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? projectName, CancellationToken cancellationToken) =>
            {
                var response = await client.Prompts.GetPromptAsync(
                    limit: limit,
                    projectName: projectName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Objects.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    slug = p.Slug,
                    description = p.Description,
                    tags = p.Tags,
                }));
            },
            name: "ListPrompts",
            description: "Lists available prompt templates in Braintrust. Optionally filter by project name. Returns prompt IDs, names, slugs, descriptions, and tags.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a prompt by slug.
    /// Useful for agents that need to load a specific prompt template.
    /// </summary>
    /// <param name="client">The Braintrust client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetPromptTool(this BraintrustClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string slug, CancellationToken cancellationToken) =>
            {
                var response = await client.Prompts.GetPromptAsync(
                    slug: slug,
                    limit: 1,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var prompt = response.Objects.FirstOrDefault();
                if (prompt is null)
                {
                    return $"No prompt found with slug '{slug}'.";
                }

                return JsonSerializer.Serialize(new
                {
                    id = prompt.Id,
                    name = prompt.Name,
                    slug = prompt.Slug,
                    description = prompt.Description,
                    tags = prompt.Tags,
                    function_type = prompt.FunctionType?.ToString(),
                    created = prompt.Created,
                });
            },
            name: "GetPrompt",
            description: "Retrieves a specific prompt template from Braintrust by its slug. Returns the prompt's ID, name, description, tags, and metadata.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists projects.
    /// Useful for agents that need to discover available projects.
    /// </summary>
    /// <param name="client">The Braintrust client.</param>
    /// <param name="limit">Maximum number of projects to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListProjectsTool(
        this BraintrustClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.GetProjectAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Objects.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                }));
            },
            name: "ListProjects",
            description: "Lists available projects in Braintrust. Returns project IDs and names.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists experiments for a project.
    /// Useful for agents that need to inspect evaluation history.
    /// </summary>
    /// <param name="client">The Braintrust client.</param>
    /// <param name="limit">Maximum number of experiments to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListExperimentsTool(
        this BraintrustClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? projectName, CancellationToken cancellationToken) =>
            {
                var response = await client.Experiments.GetExperimentAsync(
                    limit: limit,
                    projectName: projectName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Objects.Select(e => new
                {
                    id = e.Id,
                    name = e.Name,
                    created = e.Created,
                }));
            },
            name: "ListExperiments",
            description: "Lists experiments in Braintrust. Optionally filter by project name. Returns experiment IDs, names, and creation dates.");
    }
}
