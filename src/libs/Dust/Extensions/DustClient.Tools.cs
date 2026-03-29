#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Dust;

/// <summary>
/// Extension methods that create <see cref="AIFunction"/> tools
/// for key Dust API operations, suitable for use with any <see cref="IChatClient"/>.
/// </summary>
public static class DustClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists agent configurations in a workspace.
    /// </summary>
    public static AIFunction AsListAgentsTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsAsync(
                    wId: workspaceId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.AgentConfigurations?.Select(a => new
                {
                    a.SId,
                    a.Name,
                    a.Description,
                    a.Status,
                    a.Scope,
                    Model = a.Model?.ModelId,
                }) ?? [];
            },
            name: "Dust_ListAgents",
            description: "List available AI agent configurations in a Dust workspace, returning their IDs, names, descriptions, and statuses.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets details of a specific agent configuration.
    /// </summary>
    public static AIFunction AsGetAgentTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The agent configuration sId")] string agentId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsBySIdAsync(
                    wId: workspaceId,
                    sId: agentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Dust_GetAgent",
            description: "Get detailed configuration of a specific Dust AI agent including its instructions, model, and settings.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches agents by name.
    /// </summary>
    public static AIFunction AsSearchAgentsTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The search query to match against agent names")] string query,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Agents.GetWByWIdAssistantAgentConfigurationsSearchAsync(
                    wId: workspaceId,
                    q: query,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Dust_SearchAgents",
            description: "Search for Dust AI agents by name within a workspace.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a new conversation and optionally sends an initial message.
    /// </summary>
    public static AIFunction AsCreateConversationTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The initial message content to send")] string messageContent,
                   [Description("The agent configuration sId to mention (triggers the agent to respond)")] string agentId,
                   [Description("Optional title for the conversation")] string? title,
                   [Description("Whether to wait for the agent's response (true) or return immediately (false). Defaults to true.")] bool? blocking,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Conversations.CreateWByWIdAssistantConversationsAsync(
                    wId: workspaceId,
                    message: new Message
                    {
                        Content = messageContent,
                        Mentions = [new Mention { ConfigurationId = agentId }],
                    },
                    title: title,
                    blocking: blocking ?? true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    ConversationId = response.Conversation1?.SId,
                    response.Conversation1?.Title,
                    response.Conversation1?.Created,
                };
            },
            name: "Dust_CreateConversation",
            description: "Create a new conversation in a Dust workspace, send an initial message, and optionally mention an agent to trigger a response.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a conversation by ID.
    /// </summary>
    public static AIFunction AsGetConversationTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The conversation sId")] string conversationId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Conversations.GetWByWIdAssistantConversationsByCIdAsync(
                    wId: workspaceId,
                    cId: conversationId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    ConversationId = response.Conversation1?.SId,
                    response.Conversation1?.Title,
                    response.Conversation1?.Visibility,
                    response.Conversation1?.Created,
                };
            },
            name: "Dust_GetConversation",
            description: "Get details of a specific conversation in a Dust workspace including its title, visibility, and creation time.");
    }

    /// <summary>
    /// Creates an AIFunction tool that sends a message to an existing conversation.
    /// </summary>
    public static AIFunction AsSendMessageTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The conversation sId")] string conversationId,
                   [Description("The message content to send")] string messageContent,
                   [Description("Optional agent configuration sId to mention (triggers the agent to respond)")] string? agentId,
                   CancellationToken cancellationToken) =>
            {
                var mentions = new List<Mention>();
                if (!string.IsNullOrEmpty(agentId))
                {
                    mentions.Add(new Mention { ConfigurationId = agentId });
                }

                var response = await client.Conversations.CreateWByWIdAssistantConversationsByCIdMessagesAsync(
                    wId: workspaceId,
                    cId: conversationId,
                    content: messageContent,
                    mentions: mentions,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Dust_SendMessage",
            description: "Send a message to an existing Dust conversation, optionally mentioning an agent to trigger a response.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists spaces in a workspace.
    /// </summary>
    public static AIFunction AsListSpacesTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Spaces.GetWByWIdSpacesAsync(
                    wId: workspaceId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Spaces?.Select(s => new
                {
                    s.SId,
                    s.Name,
                    Kind = s.Kind?.ToString(),
                }) ?? [];
            },
            name: "Dust_ListSpaces",
            description: "List available spaces (projects) in a Dust workspace.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists data sources in a space.
    /// </summary>
    public static AIFunction AsListDataSourcesTool(this DustClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The workspace ID")] string workspaceId,
                   [Description("The space sId")] string spaceId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Datasources.GetWByWIdSpacesBySpaceIdDataSourcesAsync(
                    wId: workspaceId,
                    spaceId: spaceId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Dust_ListDataSources",
            description: "List data sources (knowledge bases, connections) available in a Dust workspace space.");
    }
}
