using Bartender.Net.Framework.User.Basic;
using Bartender.Net.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Basic;

public class UserBasic : IUserBasic {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get => ID; set => ID = value; }

    [JsonProperty ("gender")]
    public Gender Gender { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("status")]
    public Status Status { get; set; }
}
