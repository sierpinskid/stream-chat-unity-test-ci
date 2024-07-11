namespace StreamChat.Core.Helpers
{
    internal static class IInternalChannelNotificationExtensions
    {
        /// <summary>
        /// Workaround for a bug that some notifications don't have the channel type and id set in the channel object.
        /// But it's available in the ChannelType and ChannelId fields
        /// </summary>
        public static void HotWireChannelTypeAndId(this IInternalChannelNotification notification)
        {
            if (string.IsNullOrEmpty(notification.Channel.Id))
            {
                notification.Channel.Id = notification.ChannelId;
            }

            if (string.IsNullOrEmpty(notification.Channel.Type))
            {
                notification.Channel.Type = notification.ChannelType;
            }
        }
    }
}