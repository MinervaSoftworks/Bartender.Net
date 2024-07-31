using Bartender.Net.Framework.User.HoF;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRank : IHallOfFameRank {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("value")]
    public int Value { get; set; }

    [JsonProperty ("rank")]
    public int Rank { get; set; }
}

