# Microsoft.Extensions.AI Integration

The Dust SDK provides `AIFunction` tool wrappers for use with any `IChatClient` that supports function/tool calling via [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai).

## Available Tools

| Tool | Description |
|------|-------------|
| `AsListAgentsTool()` | List AI agent configurations in a workspace |
| `AsGetAgentTool()` | Get detailed configuration of a specific agent |
| `AsSearchAgentsTool()` | Search for agents by name |
| `AsCreateConversationTool()` | Create a new conversation with an initial message |
| `AsGetConversationTool()` | Get details of a specific conversation |
| `AsSendMessageTool()` | Send a message to an existing conversation |
| `AsListSpacesTool()` | List available spaces (projects) in a workspace |
| `AsListDataSourcesTool()` | List data sources in a workspace space |

## Usage Example

```csharp
using Dust;
using Microsoft.Extensions.AI;

// Create the Dust client
using var dustClient = new DustClient(apiKey);

// Create tools to pass to any IChatClient
var tools = new[]
{
    dustClient.AsListAgentsTool(),
    dustClient.AsGetAgentTool(),
    dustClient.AsSearchAgentsTool(),
    dustClient.AsCreateConversationTool(),
    dustClient.AsGetConversationTool(),
    dustClient.AsSendMessageTool(),
    dustClient.AsListSpacesTool(),
    dustClient.AsListDataSourcesTool(),
};

// Use with any IChatClient (e.g., OpenAI, Anthropic, Ollama)
var chatOptions = new ChatOptions { Tools = [.. tools] };
var response = await chatClient.GetResponseAsync("List all agents in my workspace", chatOptions);
```
