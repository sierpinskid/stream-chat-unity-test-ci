using StreamChat.Core.LowLevelClient.Models;

namespace StreamChat.Core.Helpers
{
    /// <summary>
    /// Interface for a group of channel related notification events. This enables <see cref="IInternalChannelNotificationExtensions"/>
    /// </summary>
    internal interface IInternalChannelNotification
    {
        Channel Channel { get; }
        string ChannelId { get; }
        string ChannelType { get; }
    }
}