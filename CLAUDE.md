# CLAUDE.md -- Dust SDK

## Overview

Auto-generated C# SDK for [Dust.tt](https://dust.tt/) -- AI agent platform with conversation management, data sources, and knowledge bases.
OpenAPI spec from `https://dust.tt/swagger.json` (3.0.0).

## Build & Test

```bash
dotnet build Dust.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token via `Authorization: Bearer <key>`. Standard constructor:

```csharp
var client = new DustClient(apiKey); // DUST_API_KEY env var
```

## Key Files

- `src/libs/Dust/openapi.yaml` -- Downloaded OpenAPI 3.0 spec
- `src/libs/Dust/generate.sh` -- Downloads spec, patches security, runs autosdk
- `src/libs/Dust/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Dust/Extensions/DustClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new DustClient(apiKey);

// Agents -- list, get, search agent configurations
client.Agents.GetWByWIdAssistantAgentConfigurationsAsync(wId)
client.Agents.GetWByWIdAssistantAgentConfigurationsBySIdAsync(wId, sId)
client.Agents.GetWByWIdAssistantAgentConfigurationsSearchAsync(wId, q)

// Conversations -- create, get, send messages
client.Conversations.CreateWByWIdAssistantConversationsAsync(wId, message, ...)
client.Conversations.GetWByWIdAssistantConversationsByCIdAsync(wId, cId)
client.Conversations.CreateWByWIdAssistantConversationsByCIdMessagesAsync(wId, cId, content, mentions)

// Spaces -- list accessible spaces
client.Spaces.GetWByWIdSpacesAsync(wId)

// Data Sources -- list, search, manage documents and tables
client.Datasources.GetWByWIdSpacesBySpaceIdDataSourcesAsync(wId, spaceId)

// Search -- search nodes in the workspace
client.Search.CreateWByWIdSearchAsync(wId, query)
client.Search.GetWByWIdSearchAsync(wId, query)  // streaming

// Feedbacks -- manage message feedbacks
client.Feedbacks.GetWByWIdAssistantConversationsByCIdFeedbacksAsync(wId, cId)

// MCP -- Model Context Protocol server management
client.Mcp.CreateWByWIdMcpRegisterAsync(wId, ...)
client.Mcp.CreateWByWIdMcpHeartbeatAsync(wId, ...)

// Workspace -- usage data
client.Workspace.GetWByWIdWorkspaceUsageAsync(wId)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListAgentsTool()` -- List AI agent configurations in a workspace
- `AsGetAgentTool()` -- Get detailed agent configuration
- `AsSearchAgentsTool()` -- Search agents by name
- `AsCreateConversationTool()` -- Create conversation and send initial message
- `AsGetConversationTool()` -- Get conversation details
- `AsSendMessageTool()` -- Send message to existing conversation
- `AsListSpacesTool()` -- List workspace spaces (projects)
- `AsListDataSourcesTool()` -- List data sources in a space

## Environment Variables for Tests

- `DUST_API_KEY` -- Required. Dust API key (Bearer token)
- `DUST_WORKSPACE_ID` -- Required. Workspace ID for API calls
- `DUST_AGENT_ID` -- Required for conversation tests. Agent configuration sId
- `DUST_CONVERSATION_ID` -- Required for message tests. Existing conversation sId

## Spec Notes

- Base URLs: `https://dust.tt` (US), `https://eu.dust.tt` (EU)
- Auth: BearerAuth -- spec defines scheme but `generate.sh` injects top-level `security` array
- 22 tag categories including public and private APIs
- Private endpoints require session-based auth (not API key)
- All workspace-scoped endpoints use `{wId}` path parameter
