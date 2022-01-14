//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using GetStreamIO.Core.DTO.Requests;
using GetStreamIO.Core.DTO.Events;
using GetStreamIO.Core.DTO.Models;

namespace GetStreamIO.Core.DTO.Responses
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class ChannelStateResponseDTO
    {
        [Newtonsoft.Json.JsonProperty("channel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChannelResponseDTO Channel { get; set; }

        /// <summary>
        /// Duration of the request in human-readable format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// Whether this channel is hidden or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hidden", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Messages before this date are hidden from the user
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hide_messages_before", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? HideMessagesBefore { get; set; }

        /// <summary>
        /// List of channel members
        /// </summary>
        [Newtonsoft.Json.JsonProperty("members", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChannelMemberDTO> Members { get; set; }

        /// <summary>
        /// Current user membership object
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChannelMemberDTO Membership { get; set; }

        /// <summary>
        /// List of channel messages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MessageDTO> Messages { get; set; }

        /// <summary>
        /// List of pinned messages in the channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pinned_messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MessageDTO> PinnedMessages { get; set; }

        /// <summary>
        /// List of read states
        /// </summary>
        [Newtonsoft.Json.JsonProperty("read", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReadDTO> Read { get; set; }

        /// <summary>
        /// Number of channel watchers
        /// </summary>
        [Newtonsoft.Json.JsonProperty("watcher_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WatcherCount { get; set; }

        /// <summary>
        /// List of user who is watching the channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("watchers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UserObjectDTO> Watchers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

