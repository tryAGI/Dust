/*
order: 10
title: Getting Started
slug: getting-started

Basic example showing how to create a Dust client and list agents in your workspace.
*/

namespace Dust.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        //// Create an authenticated Dust client using your API key.
        using var client = GetAuthenticatedClient();

        //// List all agent configurations in the workspace.
        var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsAsync(
            wId: GetWorkspaceId());

        //// The response contains a list of agent configurations.
        response.AgentConfigurations.Should().NotBeNull();
    }
}
