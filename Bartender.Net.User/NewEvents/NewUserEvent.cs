using Bartender.Net.Framework.User.NewEvents;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEvent : INewUserEvent {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("event")]
    public string Event { get; set; }

    [JsonProperty ("seen")]
    public bool Seen { get; set; }
}
