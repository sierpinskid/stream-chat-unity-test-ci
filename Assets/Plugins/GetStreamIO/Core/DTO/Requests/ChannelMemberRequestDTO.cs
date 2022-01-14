//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using GetStreamIO.Core.DTO.Responses;
using GetStreamIO.Core.DTO.Events;
using GetStreamIO.Core.DTO.Models;

namespace GetStreamIO.Core.DTO.Requests
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class ChannelMemberRequestDTO
    {
        /// <summary>
        /// Expiration date of the ban
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ban_expires", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BanExpires { get; set; }

        /// <summary>
        /// Whether member is banned this channel or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Banned { get; set; }

        /// <summary>
        /// Role of the member in the channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChannelRole { get; set; }

        /// <summary>
        /// Date/time of creation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("deleted_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Date when invite was accepted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_accepted_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? InviteAcceptedAt { get; set; }

        /// <summary>
        /// Date when invite was rejected
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_rejected_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? InviteRejectedAt { get; set; }

        /// <summary>
        /// Whether member was invited or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Invited { get; set; }

        /// <summary>
        /// Whether member is channel moderator or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_moderator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsModerator { get; set; }

        /// <summary>
        /// Permission level of the member in the channel (DEPRECATED: use channel_role instead)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChannelMemberRoleType? Role { get; set; }

        /// <summary>
        /// Whether member is shadow banned in this channel or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shadow_banned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShadowBanned { get; set; }

        /// <summary>
        /// Date/time of the last update
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserObjectRequestDTO User { get; set; }

        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

