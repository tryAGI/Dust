
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWFilesRequestUseCase
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
        UpsertDocument,
        /// <summary>
        /// 
        /// </summary>
        UpsertTable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWFilesRequestUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWFilesRequestUseCase value)
        {
            return value switch
            {
                CreateWFilesRequestUseCase.Avatar => "avatar",
                CreateWFilesRequestUseCase.Conversation => "conversation",
                CreateWFilesRequestUseCase.FoldersDocument => "folders_document",
                CreateWFilesRequestUseCase.ProjectContext => "project_context",
                CreateWFilesRequestUseCase.SkillAttachment => "skill_attachment",
                CreateWFilesRequestUseCase.UpsertDocument => "upsert_document",
                CreateWFilesRequestUseCase.UpsertTable => "upsert_table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWFilesRequestUseCase? ToEnum(string value)
        {
            return value switch
            {
                "avatar" => CreateWFilesRequestUseCase.Avatar,
                "conversation" => CreateWFilesRequestUseCase.Conversation,
                "folders_document" => CreateWFilesRequestUseCase.FoldersDocument,
                "project_context" => CreateWFilesRequestUseCase.ProjectContext,
                "skill_attachment" => CreateWFilesRequestUseCase.SkillAttachment,
                "upsert_document" => CreateWFilesRequestUseCase.UpsertDocument,
                "upsert_table" => CreateWFilesRequestUseCase.UpsertTable,
                _ => null,
            };
        }
    }
}