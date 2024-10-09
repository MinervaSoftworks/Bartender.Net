using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("notifications")]
    public virtual required UserNotifications Notifications { get; set; }
}