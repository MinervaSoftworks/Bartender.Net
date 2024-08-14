using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFame {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public HallOfFameRank Attacks { get; set; }

    [JsonProperty ("battlestats")]
    public HallOfFameRank Battlestats { get; set; }

    [JsonProperty ("busts")]
    public HallOfFameRank Busts { get; set; }

    [JsonProperty ("defends")]
    public HallOfFameRank Defends { get; set; }

    [JsonProperty ("networth")]
    public HallOfFameRank Networth { get; set; }

    [JsonProperty ("offences")]
    public HallOfFameRank Offences { get; set; }

    [JsonProperty ("revives")]
    public HallOfFameRank Revives { get; set; }

    [JsonProperty ("traveltime")]
    public HallOfFameRank Traveltime { get; set; }

    [JsonProperty ("workstats")]
    public HallOfFameRank Workstats { get; set; }

    [JsonProperty ("level")]
    public HallOfFameRank Level { get; set; }

    [JsonProperty ("rank")]
    public HallOfFameRank Rank { get; set; }

    [JsonProperty ("awards")]
    public HallOfFameRank Awards { get; set; }
}

