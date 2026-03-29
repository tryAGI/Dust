/*
order: 30
title: Conversations
slug: conversations

Examples for creating conversations and sending messages to Dust AI agents.
*/

namespace Dust.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateConversation()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();
        var agentId = GetAgentId();

        //// Create a new conversation with an initial message and mention an agent.
        //// Setting blocking to true waits for the agent's response.
        var response = await client.Conversations.CreateWByWIdAssistantConversationsAsync(
            wId: workspaceId,
            message: new Message
            {
                Content = "Hello, can you help me?",
                Mentions = [new Mention { ConfigurationId = agentId }],
            },
            title: "Test Conversation",
            blocking: true);

        //// The response contains the created conversation with its sId.
        response.Conversation1.Should().NotBeNull();
        response.Conversation1!.SId.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Example_SendMessage()
    {
        //// Create an authenticated Dust client.
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();
        var conversationId = GetConversationId();
        var agentId = GetAgentId();

        //// Send a follow-up message to an existing conversation.
        //// Include a mention to trigger the agent to respond.
        var response = await client.Conversations.CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            wId: workspaceId,
            cId: conversationId,
            content: "What can you tell me about our data sources?",
            mentions: [new Mention { ConfigurationId = agentId }]);

        //// The response contains the created message.
        response.Should().NotBeNull();
    }
}
