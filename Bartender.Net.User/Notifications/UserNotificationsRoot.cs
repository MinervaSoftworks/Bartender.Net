using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("notifications")]
    public required UserNotifications Notifications { get; set; }
}