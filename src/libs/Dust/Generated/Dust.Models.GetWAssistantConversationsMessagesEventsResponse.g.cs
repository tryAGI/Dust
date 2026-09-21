
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesEventsResponse
    {
        /// <summary>
        /// Redis stream ID used as the resume cursor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Agent message event discriminated by its type field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesEventsResponse" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Redis stream ID used as the resume cursor.
        /// </param>
        /// <param name="data">
        /// Agent message event discriminated by its type field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesEventsResponse(
            string eventId,
            object data)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesEventsResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesEventsResponse()
        {
        }

    }
}