
#nullable enable

namespace Dust
{
    /// <summary>
    /// Execution status of the tool
    /// </summary>
    public enum PrivateAgentMCPActionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        BlockedAuthenticationRequired,
        /// <summary>
        /// 
        /// </summary>
        BlockedChildActionInputRequired,
        /// <summary>
        /// 
        /// </summary>
        BlockedFileAuthorizationRequired,
        /// <summary>
        /// 
        /// </summary>
        BlockedUserAnswerRequired,
        /// <summary>
        /// 
        /// </summary>
        BlockedValidationRequired,
        /// <summary>
        /// 
        /// </summary>
        Denied,
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        ReadyAllowedExplicitly,
        /// <summary>
        /// 
        /// </summary>
        ReadyAllowedImplicitly,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMCPActionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMCPActionStatus value)
        {
            return value switch
            {
                PrivateAgentMCPActionStatus.BlockedAuthenticationRequired => "blocked_authentication_required",
                PrivateAgentMCPActionStatus.BlockedChildActionInputRequired => "blocked_child_action_input_required",
                PrivateAgentMCPActionStatus.BlockedFileAuthorizationRequired => "blocked_file_authorization_required",
                PrivateAgentMCPActionStatus.BlockedUserAnswerRequired => "blocked_user_answer_required",
                PrivateAgentMCPActionStatus.BlockedValidationRequired => "blocked_validation_required",
                PrivateAgentMCPActionStatus.Denied => "denied",
                PrivateAgentMCPActionStatus.Errored => "errored",
                PrivateAgentMCPActionStatus.ReadyAllowedExplicitly => "ready_allowed_explicitly",
                PrivateAgentMCPActionStatus.ReadyAllowedImplicitly => "ready_allowed_implicitly",
                PrivateAgentMCPActionStatus.Running => "running",
                PrivateAgentMCPActionStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMCPActionStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked_authentication_required" => PrivateAgentMCPActionStatus.BlockedAuthenticationRequired,
                "blocked_child_action_input_required" => PrivateAgentMCPActionStatus.BlockedChildActionInputRequired,
                "blocked_file_authorization_required" => PrivateAgentMCPActionStatus.BlockedFileAuthorizationRequired,
                "blocked_user_answer_required" => PrivateAgentMCPActionStatus.BlockedUserAnswerRequired,
                "blocked_validation_required" => PrivateAgentMCPActionStatus.BlockedValidationRequired,
                "denied" => PrivateAgentMCPActionStatus.Denied,
                "errored" => PrivateAgentMCPActionStatus.Errored,
                "ready_allowed_explicitly" => PrivateAgentMCPActionStatus.ReadyAllowedExplicitly,
                "ready_allowed_implicitly" => PrivateAgentMCPActionStatus.ReadyAllowedImplicitly,
                "running" => PrivateAgentMCPActionStatus.Running,
                "succeeded" => PrivateAgentMCPActionStatus.Succeeded,
                _ => null,
            };
        }
    }
}