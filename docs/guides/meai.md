# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Braintrust SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Braintrust's prompt management and experiment tracking capabilities.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `ListProjects` | Lists available projects |
| `AsListPromptsTool()` | `ListPrompts` | Lists prompt templates, optionally filtered by project |
| `AsGetPromptTool()` | `GetPrompt` | Retrieves a specific prompt by slug |
| `AsListExperimentsTool()` | `ListExperiments` | Lists experiments, optionally filtered by project |

## Usage

```csharp
using Braintrust;
using Microsoft.Extensions.AI;

// Create the Braintrust client
var braintrust = new BraintrustClient(apiKey);

// Create tools
var tools = new AIFunction[]
{
    braintrust.AsListProjectsTool(),
    braintrust.AsListPromptsTool(),
    braintrust.AsGetPromptTool(),
    braintrust.AsListExperimentsTool(),
};

// Use with any IChatClient (OpenAI, Anthropic, etc.)
IChatClient chatClient = /* your chat client */;

var response = await chatClient.GetResponseAsync(
    "List all my Braintrust projects and their prompts.",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ListProjects

Returns a JSON array of projects with `id` and `name` fields.

```csharp
var tool = client.AsListProjectsTool(limit: 10);
```

### ListPrompts

Returns a JSON array of prompts with `id`, `name`, `slug`, `description`, and `tags` fields.
Accepts an optional `projectName` parameter to filter by project.

```csharp
var tool = client.AsListPromptsTool(limit: 20);
```

### GetPrompt

Returns a single prompt's details by slug, including `id`, `name`, `slug`, `description`,
`tags`, `function_type`, and `created` date.

```csharp
var tool = client.AsGetPromptTool();
```

### ListExperiments

Returns a JSON array of experiments with `id`, `name`, and `created` fields.
Accepts an optional `projectName` parameter to filter by project.

```csharp
var tool = client.AsListExperimentsTool(limit: 20);
```
