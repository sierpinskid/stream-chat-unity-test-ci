//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using GetStreamIO.Core.DTO.Responses;
using GetStreamIO.Core.DTO.Requests;
using GetStreamIO.Core.DTO.Events;

namespace GetStreamIO.Core.DTO.Models
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class OwnUserDTO
    {
        [Newtonsoft.Json.JsonProperty("banned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Banned { get; set; }

        [Newtonsoft.Json.JsonProperty("channel_mutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChannelMuteDTO> ChannelMutes { get; set; }

        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("deactivated_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeactivatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("deleted_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeletedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DeviceDTO> Devices { get; set; }

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("invisible", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Invisible { get; set; }

        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        [Newtonsoft.Json.JsonProperty("last_active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastActive { get; set; }

        [Newtonsoft.Json.JsonProperty("latest_hidden_channels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> LatestHiddenChannels { get; set; }

        [Newtonsoft.Json.JsonProperty("mutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UserMuteDTO> Mutes { get; set; }

        [Newtonsoft.Json.JsonProperty("online", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Online { get; set; }

        [Newtonsoft.Json.JsonProperty("push_notifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PushNotificationSettingsDTO PushNotifications { get; set; }

        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Role { get; set; }

        [Newtonsoft.Json.JsonProperty("teams", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Teams { get; set; }

        [Newtonsoft.Json.JsonProperty("total_unread_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalUnreadCount { get; set; }

        [Newtonsoft.Json.JsonProperty("unread_channels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnreadChannels { get; set; }

        [Newtonsoft.Json.JsonProperty("unread_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnreadCount { get; set; }

        [Newtonsoft.Json.JsonProperty("updated_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

