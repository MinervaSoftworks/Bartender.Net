using Bartender.Net.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Basic;

public class UserBasic {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("gender")]
    public required Gender Gender { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }

    [JsonProperty ("status")]
    public required Status Status { get; set; }
}
