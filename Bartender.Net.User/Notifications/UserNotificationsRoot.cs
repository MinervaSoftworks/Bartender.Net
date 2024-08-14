using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationsRoot {
    [JsonProperty ("notifications")]
    public required UserNotifications Notifications { get; set; }
}