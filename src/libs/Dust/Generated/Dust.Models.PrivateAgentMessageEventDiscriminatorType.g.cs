
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentActionSuccess,
        /// <summary>
        /// 
        /// </summary>
        AgentContextPruned,
        /// <summary>
        /// 
        /// </summary>
        AgentError,
        /// <summary>
        /// 
        /// </summary>
        AgentGenerationCancelled,
        /// <summary>
        /// 
        /// </summary>
        AgentMessageSuccess,
        /// <summary>
        /// 
        /// </summary>
        GenerationTokens,
        /// <summary>
        /// 
        /// </summary>
        ToolApproveExecution,
        /// <summary>
        /// 
        /// </summary>
        ToolCallStarted,
        /// <summary>
        /// 
        /// </summary>
        ToolError,
        /// <summary>
        /// 
        /// </summary>
        ToolFileAuthRequired,
        /// <summary>
        /// 
        /// </summary>
        ToolNotification,
        /// <summary>
        /// 
        /// </summary>
        ToolParams,
        /// <summary>
        /// 
        /// </summary>
        ToolPersonalAuthRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageEventDiscriminatorType value)
        {
            return value switch
            {
                PrivateAgentMessageEventDiscriminatorType.AgentActionSuccess => "agent_action_success",
                PrivateAgentMessageEventDiscriminatorType.AgentContextPruned => "agent_context_pruned",
                PrivateAgentMessageEventDiscriminatorType.AgentError => "agent_error",
                PrivateAgentMessageEventDiscriminatorType.AgentGenerationCancelled => "agent_generation_cancelled",
                PrivateAgentMessageEventDiscriminatorType.AgentMessageSuccess => "agent_message_success",
                PrivateAgentMessageEventDiscriminatorType.GenerationTokens => "generation_tokens",
                PrivateAgentMessageEventDiscriminatorType.ToolApproveExecution => "tool_approve_execution",
                PrivateAgentMessageEventDiscriminatorType.ToolCallStarted => "tool_call_started",
                PrivateAgentMessageEventDiscriminatorType.ToolError => "tool_error",
                PrivateAgentMessageEventDiscriminatorType.ToolFileAuthRequired => "tool_file_auth_required",
                PrivateAgentMessageEventDiscriminatorType.ToolNotification => "tool_notification",
                PrivateAgentMessageEventDiscriminatorType.ToolParams => "tool_params",
                PrivateAgentMessageEventDiscriminatorType.ToolPersonalAuthRequired => "tool_personal_auth_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_action_success" => PrivateAgentMessageEventDiscriminatorType.AgentActionSuccess,
                "agent_context_pruned" => PrivateAgentMessageEventDiscriminatorType.AgentContextPruned,
                "agent_error" => PrivateAgentMessageEventDiscriminatorType.AgentError,
                "agent_generation_cancelled" => PrivateAgentMessageEventDiscriminatorType.AgentGenerationCancelled,
                "agent_message_success" => PrivateAgentMessageEventDiscriminatorType.AgentMessageSuccess,
                "generation_tokens" => PrivateAgentMessageEventDiscriminatorType.GenerationTokens,
                "tool_approve_execution" => PrivateAgentMessageEventDiscriminatorType.ToolApproveExecution,
                "tool_call_started" => PrivateAgentMessageEventDiscriminatorType.ToolCallStarted,
                "tool_error" => PrivateAgentMessageEventDiscriminatorType.ToolError,
                "tool_file_auth_required" => PrivateAgentMessageEventDiscriminatorType.ToolFileAuthRequired,
                "tool_notification" => PrivateAgentMessageEventDiscriminatorType.ToolNotification,
                "tool_params" => PrivateAgentMessageEventDiscriminatorType.ToolParams,
                "tool_personal_auth_required" => PrivateAgentMessageEventDiscriminatorType.ToolPersonalAuthRequired,
                _ => null,
            };
        }
    }
}