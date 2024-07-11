﻿using StreamChat.Core.Helpers;
using StreamChat.Core.InternalDTO.Events;
using StreamChat.Core.InternalDTO.Models;
using StreamChat.Core.LowLevelClient.Models;

namespace StreamChat.Core.LowLevelClient.Events
{
    public sealed class EventNotificationInviteRejected : EventBase,
        ILoadableFrom<NotificationInviteRejectedEventInternalDTO, EventNotificationInviteRejected>
    {
        public Channel Channel { get; set; }

        public string ChannelId { get; set; }

        public string ChannelType { get; set; }

        public string Cid { get; set; }

        public ChannelMember Member { get; set; }

        public string Type { get; set; }

        public User User { get; set; }

        EventNotificationInviteRejected
            ILoadableFrom<NotificationInviteRejectedEventInternalDTO, EventNotificationInviteRejected>.LoadFromDto(
                NotificationInviteRejectedEventInternalDTO dto)
        {
            Channel = Channel.TryLoadFromDto(dto.Channel);
            ChannelId = dto.ChannelId;
            ChannelType = dto.ChannelType;
            Cid = dto.Cid;
            CreatedAt = dto.CreatedAt;
            Member = Member.TryLoadFromDto(dto.Member);
            Type = dto.Type;
            User = User.TryLoadFromDto<UserObjectInternalDTO, User>(dto.User);
            AdditionalProperties = dto.AdditionalProperties;

            return this;
        }
    }
}