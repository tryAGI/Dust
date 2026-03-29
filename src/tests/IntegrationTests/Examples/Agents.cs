/*
order: 20
title: Agents
slug: agents

Examples for working with Dust AI agents: listing, searching, and getting agent details.
*/

namespace Dust.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAgents()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();

        //// List all agent configurations in the workspace.
        var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsAsync(
            wId: workspaceId);

        //// Verify agents were returned.
        response.AgentConfigurations.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_SearchAgents()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();

        //// Search for agents by name.
        var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsSearchAsync(
            wId: workspaceId,
            q: "helper");

        //// The response contains matching agent configurations.
        response.Should().NotBeNull();
    }
}
