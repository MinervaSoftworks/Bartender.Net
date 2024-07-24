using Bartender.Net.Framework.User.HoF;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFame : IHallOfFame {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required HallOfFameRank Attacks { get; set; }

    [JsonProperty ("battlestats")]
    public required HallOfFameRank Battlestats { get; set; }

    [JsonProperty ("busts")]
    public required HallOfFameRank Busts { get; set; }

    [JsonProperty ("defends")]
    public required HallOfFameRank Defends { get; set; }

    [JsonProperty ("networth")]
    public required HallOfFameRank Networth { get; set; }

    [JsonProperty ("offences")]
    public required HallOfFameRank Offences { get; set; }

    [JsonProperty ("revives")]
    public required HallOfFameRank Revives { get; set; }

    [JsonProperty ("traveltime")]
    public required HallOfFameRank Traveltime { get; set; }

    [JsonProperty ("workstats")]
    public required HallOfFameRank Workstats { get; set; }

    [JsonProperty ("level")]
    public required HallOfFameRank Level { get; set; }

    [JsonProperty ("rank")]
    public required HallOfFameRank Rank { get; set; }

    [JsonProperty ("awards")]
    public required HallOfFameRank Awards { get; set; }
}

