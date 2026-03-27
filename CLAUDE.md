# CLAUDE.md — Braintrust SDK

## Overview

Auto-generated C# SDK for [Braintrust](https://www.braintrust.dev/) — AI evaluation and observability platform for experiments, datasets, prompts, scoring, logging, evals, functions, and project management.
OpenAPI spec from the official [braintrustdata/braintrust-openapi](https://github.com/braintrustdata/braintrust-openapi) repo.

## Build & Test

```bash
dotnet build Braintrust.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new BraintrustClient(apiKey); // BRAINTRUST_API_KEY env var
```

## Key Files

- `src/libs/Braintrust/openapi.yaml` — OpenAPI spec (downloaded from braintrustdata/braintrust-openapi)
- `src/libs/Braintrust/generate.sh` — Downloads spec, removes invalid proxy endpoint, fixes namespace, runs autosdk
- `src/libs/Braintrust/Generated/` — **Never edit** — auto-generated code (~2000 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- `generate.sh` removes `/v1/proxy/{path+}` endpoint (generates invalid C# identifiers due to `+` in path param)
- Post-generation `sed` fix: replaces `namespace System` with `namespace Braintrust` in `JsonSerializerContextTypes` (AutoSDK codegen bug)
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Braintrust API has tagged operations generating sub-clients:
- `client.Projects.*` — Create, list, get, update, delete projects
- `client.Experiments.*` — Create, list, get, update, delete experiments; fetch/insert events
- `client.Datasets.*` — Create, list, get, update, delete datasets; fetch/insert events
- `client.Prompts.*` — Create, list, get, update, delete prompts
- `client.Functions.*` — Create, list, get, update, delete functions
- `client.Evals.*` — Run evaluations
- `client.Logs.*` — Fetch/insert log events
- `client.ProjectScores.*` — Manage project scores
- `client.ProjectTags.*` — Manage project tags
- `client.ProjectAutomations.*` — Manage project automations
- `client.Acls.*` — Access control list management
- `client.Users.*` — User management
- `client.Groups.*` — Group management
- `client.Roles.*` — Role management
- `client.Organizations.*` — Organization management
- `client.ApiKeys.*` — API key management
- `client.AiSecrets.*` — AI provider secret management
- `client.EnvVars.*` — Environment variable management
- `client.McpServers.*` — MCP server management
- `client.Views.*` — View management

## MEAI

No MEAI interface implemented — Braintrust is an evaluation/observability platform with no matching MEAI interface.
