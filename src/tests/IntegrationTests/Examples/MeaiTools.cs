/*
order: 40
title: MEAI Tools
slug: meai-tools

Examples showing how to use Dust AIFunction tools with Microsoft.Extensions.AI.
*/

using Microsoft.Extensions.AI;

namespace Dust.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiListAgentsTool()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();

        //// Create the ListAgents AIFunction tool.
        //// This tool can be passed to any IChatClient that supports function calling.
        AIFunction tool = client.AsListAgentsTool();

        //// Verify the tool has the expected name and description.
        tool.Name.Should().Be("Dust_ListAgents");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Example_MeaiCreateConversationTool()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();

        //// Create the CreateConversation AIFunction tool.
        AIFunction tool = client.AsCreateConversationTool();

        //// Verify the tool has the expected name and description.
        tool.Name.Should().Be("Dust_CreateConversation");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Example_MeaiListSpacesTool()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();

        //// Create the ListSpaces AIFunction tool.
        AIFunction tool = client.AsListSpacesTool();

        //// Verify the tool has the expected name and description.
        tool.Name.Should().Be("Dust_ListSpaces");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Example_AllTools()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();

        //// Create all available AIFunction tools for use with any IChatClient.
        var tools = new[]
        {
            client.AsListAgentsTool(),
            client.AsGetAgentTool(),
            client.AsSearchAgentsTool(),
            client.AsCreateConversationTool(),
            client.AsGetConversationTool(),
            client.AsSendMessageTool(),
            client.AsListSpacesTool(),
            client.AsListDataSourcesTool(),
        };

        //// All 8 tools should be created successfully.
        tools.Should().HaveCount(8);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
