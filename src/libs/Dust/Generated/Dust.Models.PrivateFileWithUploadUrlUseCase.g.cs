
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateFileWithUploadUrlUseCase
    {
        /// <summary>
        /// 
        /// </summary>
        Avatar,
        /// <summary>
        /// 
        /// </summary>
        Conversation,
        /// <summary>
        /// 
        /// </summary>
        FoldersDocument,
        /// <summary>
        /// 
        /// </summary>
        ProjectContext,
        /// <summary>
        /// 
        /// </summary>
        SkillAttachment,
        /// <summary>
        /// 
        /// </summary>
        ToolOutput,
        /// <summary>
        /// 
        /// </summary>
        UpsertDocument,
        /// <summary>
        /// 
        /// </summary>
        UpsertTable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFileWithUploadUrlUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFileWithUploadUrlUseCase value)
        {
            return value switch
            {
                PrivateFileWithUploadUrlUseCase.Avatar => "avatar",
                PrivateFileWithUploadUrlUseCase.Conversation => "conversation",
                PrivateFileWithUploadUrlUseCase.FoldersDocument => "folders_document",
                PrivateFileWithUploadUrlUseCase.ProjectContext => "project_context",
                PrivateFileWithUploadUrlUseCase.SkillAttachment => "skill_attachment",
                PrivateFileWithUploadUrlUseCase.ToolOutput => "tool_output",
                PrivateFileWithUploadUrlUseCase.UpsertDocument => "upsert_document",
                PrivateFileWithUploadUrlUseCase.UpsertTable => "upsert_table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFileWithUploadUrlUseCase? ToEnum(string value)
        {
            return value switch
            {
                "avatar" => PrivateFileWithUploadUrlUseCase.Avatar,
                "conversation" => PrivateFileWithUploadUrlUseCase.Conversation,
                "folders_document" => PrivateFileWithUploadUrlUseCase.FoldersDocument,
                "project_context" => PrivateFileWithUploadUrlUseCase.ProjectContext,
                "skill_attachment" => PrivateFileWithUploadUrlUseCase.SkillAttachment,
                "tool_output" => PrivateFileWithUploadUrlUseCase.ToolOutput,
                "upsert_document" => PrivateFileWithUploadUrlUseCase.UpsertDocument,
                "upsert_table" => PrivateFileWithUploadUrlUseCase.UpsertTable,
                _ => null,
            };
        }
    }
}