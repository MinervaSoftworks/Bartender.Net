using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class HallofFame {
    [JsonProperty("attacks")]
    public HofAttacks Attacks { get; set; }

    [JsonProperty("battlestats")]
    public HofBattleStats Battlestats { get; set; }

    [JsonProperty("busts")]
    public Busts Busts { get; set; }

    [JsonProperty("defends")]
    public Defends Defends { get; set; }

    [JsonProperty("networth")]
    public Networth Networth { get; set; }

    [JsonProperty("offences")]
    public Offences Offences { get; set; }

    [JsonProperty("revives")]
    public Revives Revives { get; set; }

    [JsonProperty("traveltime")]
    public Traveltime Traveltime { get; set; }

    [JsonProperty("workstats")]
    public HofWorkStats Workstats { get; set; }

    [JsonProperty("level")]
    public Level Level { get; set; }

    [JsonProperty("rank")]
    public UserRank Rank { get; set; }

    [JsonProperty("awards")]
    public Awards Awards { get; set; }
}

