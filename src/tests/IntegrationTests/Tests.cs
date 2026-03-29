namespace Dust.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DustClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DUST_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DUST_API_KEY environment variable is not found.");

        var client = new DustClient(apiKey);

        return client;
    }

    private static string GetWorkspaceId()
    {
        return Environment.GetEnvironmentVariable("DUST_WORKSPACE_ID") is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException("DUST_WORKSPACE_ID environment variable is not found.");
    }

    private static string GetAgentId()
    {
        return Environment.GetEnvironmentVariable("DUST_AGENT_ID") is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException("DUST_AGENT_ID environment variable is not found.");
    }

    private static string GetConversationId()
    {
        return Environment.GetEnvironmentVariable("DUST_CONVERSATION_ID") is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException("DUST_CONVERSATION_ID environment variable is not found.");
    }
}
