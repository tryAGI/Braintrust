namespace Braintrust.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BraintrustClient GetAuthenticatedClient()
    {
        var apiKey =
            global::System.Environment.GetEnvironmentVariable("BRAINTRUST_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BRAINTRUST_API_KEY environment variable is not found.");

        var client = new BraintrustClient(apiKey);
        
        return client;
    }
}
