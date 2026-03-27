# Authentication

The Braintrust API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [braintrust.dev](https://www.braintrust.dev/)
2. Navigate to your organization settings
3. Create a new API key

## Client Initialization

```csharp
using Braintrust;

var client = new BraintrustClient(
    apiKey: Environment.GetEnvironmentVariable("BRAINTRUST_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export BRAINTRUST_API_KEY=your-api-key-here
```
