using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRank : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("value")]
    public required int Value { get; set; }

    [JsonProperty ("rank")]
    public required int Rank { get; set; }
}

