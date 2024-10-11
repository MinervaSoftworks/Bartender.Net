using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Basic;

public class UserBasic : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get => ID; set => ID = value; }

    [JsonProperty ("gender")]
    public Gender Gender { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("status")]
    public virtual required Status Status { get; set; }
}
