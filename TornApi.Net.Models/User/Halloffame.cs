using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class HallOfFame {
    [JsonProperty("attacks")]
    public HoFRank Attacks { get; set; }

    [JsonProperty("battlestats")]
    public HoFRank Battlestats { get; set; }

    [JsonProperty("busts")]
    public HoFRank Busts { get; set; }

    [JsonProperty("defends")]
    public HoFRank Defends { get; set; }

    [JsonProperty("networth")]
    public HoFRank Networth { get; set; }

    [JsonProperty("offences")]
    public HoFRank Offences { get; set; }

    [JsonProperty("revives")]
    public HoFRank Revives { get; set; }

    [JsonProperty("traveltime")]
    public HoFRank Traveltime { get; set; }

    [JsonProperty("workstats")]
    public HoFRank Workstats { get; set; }

    [JsonProperty("level")]
    public HoFRank Level { get; set; }

    [JsonProperty("rank")]
    public HoFRank Rank { get; set; }

    [JsonProperty("awards")]
    public HoFRank Awards { get; set; }
}

