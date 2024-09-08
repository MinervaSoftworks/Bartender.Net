using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Basic;

public class UserBasic {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get => ID; set => ID = value; }

    [JsonProperty ("gender")]
    public Gender Gender { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("status")]
    public required Status Status { get; set; }
}
