using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationCollection {
    [JsonProperty("notifications")]
    public required UserNotifications Notifications { get; set; }
}