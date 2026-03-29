
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateFileWithUploadUrlStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFileWithUploadUrlStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFileWithUploadUrlStatus value)
        {
            return value switch
            {
                PrivateFileWithUploadUrlStatus.Created => "created",
                PrivateFileWithUploadUrlStatus.Failed => "failed",
                PrivateFileWithUploadUrlStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFileWithUploadUrlStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PrivateFileWithUploadUrlStatus.Created,
                "failed" => PrivateFileWithUploadUrlStatus.Failed,
                "ready" => PrivateFileWithUploadUrlStatus.Ready,
                _ => null,
            };
        }
    }
}