using Bartender.Net.Framework.User.HoF;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFame : IHallOfFame {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public IHallOfFameRank Attacks { get; set; }

    [JsonProperty ("battlestats")]
    public IHallOfFameRank Battlestats { get; set; }

    [JsonProperty ("busts")]
    public IHallOfFameRank Busts { get; set; }

    [JsonProperty ("defends")]
    public IHallOfFameRank Defends { get; set; }

    [JsonProperty ("networth")]
    public IHallOfFameRank Networth { get; set; }

    [JsonProperty ("offences")]
    public IHallOfFameRank Offences { get; set; }

    [JsonProperty ("revives")]
    public IHallOfFameRank Revives { get; set; }

    [JsonProperty ("traveltime")]
    public IHallOfFameRank Traveltime { get; set; }

    [JsonProperty ("workstats")]
    public IHallOfFameRank Workstats { get; set; }

    [JsonProperty ("level")]
    public IHallOfFameRank Level { get; set; }

    [JsonProperty ("rank")]
    public IHallOfFameRank Rank { get; set; }

    [JsonProperty ("awards")]
    public IHallOfFameRank Awards { get; set; }
}

