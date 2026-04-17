
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWAssistantConversationsRequestVariant4AccessMode
    {
        /// <summary>
        /// 
        /// </summary>
        ParticipantsOnly,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMembers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWAssistantConversationsRequestVariant4AccessModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWAssistantConversationsRequestVariant4AccessMode value)
        {
            return value switch
            {
                PatchWAssistantConversationsRequestVariant4AccessMode.ParticipantsOnly => "participants_only",
                PatchWAssistantConversationsRequestVariant4AccessMode.WorkspaceMembers => "workspace_members",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWAssistantConversationsRequestVariant4AccessMode? ToEnum(string value)
        {
            return value switch
            {
                "participants_only" => PatchWAssistantConversationsRequestVariant4AccessMode.ParticipantsOnly,
                "workspace_members" => PatchWAssistantConversationsRequestVariant4AccessMode.WorkspaceMembers,
                _ => null,
            };
        }
    }
}