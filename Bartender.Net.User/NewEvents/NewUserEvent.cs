using Bartender.Net.Framework.User.NewEvents;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEvent : INewUserEvent {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("event")]
    public required string Event { get; set; }

    [JsonProperty ("seen")]
    public required bool Seen { get; set; }
}
