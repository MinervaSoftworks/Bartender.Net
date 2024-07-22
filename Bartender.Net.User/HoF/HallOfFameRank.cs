using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRank {
    [JsonProperty ("value")]
    public required int Value { get; set; }

    [JsonProperty ("rank")]
    public required int Rank { get; set; }
}

