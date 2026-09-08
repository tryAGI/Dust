
#nullable enable

namespace Dust
{
    /// <summary>
    /// For `kind: schedule`, either a cron config (`cron`, `timezone`) or an interval<br/>
    /// config (`intervalDays`, `dayOfWeek`, `hour`, `minute`, `timezone`). For<br/>
    /// `kind: webhook`, `{ includePayload, event?, filter? }`.
    /// </summary>
    public sealed partial class TriggerConfiguration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}