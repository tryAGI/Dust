
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateUserMessageContextOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        AgentSidekick,
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        CliProgrammatic,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Excel,
        /// <summary>
        /// 
        /// </summary>
        Extension,
        /// <summary>
        /// 
        /// </summary>
        Gsheet,
        /// <summary>
        /// 
        /// </summary>
        Make,
        /// <summary>
        /// 
        /// </summary>
        N8n,
        /// <summary>
        /// 
        /// </summary>
        OnboardingConversation,
        /// <summary>
        /// 
        /// </summary>
        Powerpoint,
        /// <summary>
        /// 
        /// </summary>
        ProjectButler,
        /// <summary>
        /// 
        /// </summary>
        ProjectKickoff,
        /// <summary>
        /// 
        /// </summary>
        Raycast,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        SlackWorkflow,
        /// <summary>
        /// 
        /// </summary>
        Teams,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        Triggered,
        /// <summary>
        /// 
        /// </summary>
        TriggeredProgrammatic,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Zapier,
        /// <summary>
        /// 
        /// </summary>
        Zendesk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateUserMessageContextOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateUserMessageContextOrigin value)
        {
            return value switch
            {
                PrivateUserMessageContextOrigin.AgentSidekick => "agent_sidekick",
                PrivateUserMessageContextOrigin.Api => "api",
                PrivateUserMessageContextOrigin.Cli => "cli",
                PrivateUserMessageContextOrigin.CliProgrammatic => "cli_programmatic",
                PrivateUserMessageContextOrigin.Email => "email",
                PrivateUserMessageContextOrigin.Excel => "excel",
                PrivateUserMessageContextOrigin.Extension => "extension",
                PrivateUserMessageContextOrigin.Gsheet => "gsheet",
                PrivateUserMessageContextOrigin.Make => "make",
                PrivateUserMessageContextOrigin.N8n => "n8n",
                PrivateUserMessageContextOrigin.OnboardingConversation => "onboarding_conversation",
                PrivateUserMessageContextOrigin.Powerpoint => "powerpoint",
                PrivateUserMessageContextOrigin.ProjectButler => "project_butler",
                PrivateUserMessageContextOrigin.ProjectKickoff => "project_kickoff",
                PrivateUserMessageContextOrigin.Raycast => "raycast",
                PrivateUserMessageContextOrigin.Slack => "slack",
                PrivateUserMessageContextOrigin.SlackWorkflow => "slack_workflow",
                PrivateUserMessageContextOrigin.Teams => "teams",
                PrivateUserMessageContextOrigin.Transcript => "transcript",
                PrivateUserMessageContextOrigin.Triggered => "triggered",
                PrivateUserMessageContextOrigin.TriggeredProgrammatic => "triggered_programmatic",
                PrivateUserMessageContextOrigin.Web => "web",
                PrivateUserMessageContextOrigin.Zapier => "zapier",
                PrivateUserMessageContextOrigin.Zendesk => "zendesk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateUserMessageContextOrigin? ToEnum(string value)
        {
            return value switch
            {
                "agent_sidekick" => PrivateUserMessageContextOrigin.AgentSidekick,
                "api" => PrivateUserMessageContextOrigin.Api,
                "cli" => PrivateUserMessageContextOrigin.Cli,
                "cli_programmatic" => PrivateUserMessageContextOrigin.CliProgrammatic,
                "email" => PrivateUserMessageContextOrigin.Email,
                "excel" => PrivateUserMessageContextOrigin.Excel,
                "extension" => PrivateUserMessageContextOrigin.Extension,
                "gsheet" => PrivateUserMessageContextOrigin.Gsheet,
                "make" => PrivateUserMessageContextOrigin.Make,
                "n8n" => PrivateUserMessageContextOrigin.N8n,
                "onboarding_conversation" => PrivateUserMessageContextOrigin.OnboardingConversation,
                "powerpoint" => PrivateUserMessageContextOrigin.Powerpoint,
                "project_butler" => PrivateUserMessageContextOrigin.ProjectButler,
                "project_kickoff" => PrivateUserMessageContextOrigin.ProjectKickoff,
                "raycast" => PrivateUserMessageContextOrigin.Raycast,
                "slack" => PrivateUserMessageContextOrigin.Slack,
                "slack_workflow" => PrivateUserMessageContextOrigin.SlackWorkflow,
                "teams" => PrivateUserMessageContextOrigin.Teams,
                "transcript" => PrivateUserMessageContextOrigin.Transcript,
                "triggered" => PrivateUserMessageContextOrigin.Triggered,
                "triggered_programmatic" => PrivateUserMessageContextOrigin.TriggeredProgrammatic,
                "web" => PrivateUserMessageContextOrigin.Web,
                "zapier" => PrivateUserMessageContextOrigin.Zapier,
                "zendesk" => PrivateUserMessageContextOrigin.Zendesk,
                _ => null,
            };
        }
    }
}