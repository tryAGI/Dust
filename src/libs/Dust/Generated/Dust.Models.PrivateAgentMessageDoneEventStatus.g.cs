
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageDoneEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageDoneEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageDoneEventStatus value)
        {
            return value switch
            {
                PrivateAgentMessageDoneEventStatus.Error => "error",
                PrivateAgentMessageDoneEventStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageDoneEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PrivateAgentMessageDoneEventStatus.Error,
                "success" => PrivateAgentMessageDoneEventStatus.Success,
                _ => null,
            };
        }
    }
}