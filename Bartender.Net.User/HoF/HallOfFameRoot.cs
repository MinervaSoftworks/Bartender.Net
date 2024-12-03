using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("attacks")]
    public virtual required HallOfFameRank Attacks { get; set; }

    [JsonProperty ("battlestats")]
    public virtual required HallOfFameRank Battlestats { get; set; }

    [JsonProperty ("busts")]
    public virtual required HallOfFameRank Busts { get; set; }

    [JsonProperty ("defends")]
    public virtual required HallOfFameRank Defends { get; set; }

    [JsonProperty ("networth")]
    public virtual required HallOfFameRank Networth { get; set; }

    [JsonProperty ("offences")]
    public virtual required HallOfFameRank Offences { get; set; }

    [JsonProperty ("revives")]
    public virtual required HallOfFameRank Revives { get; set; }

    [JsonProperty ("traveltime")]
    public virtual required HallOfFameRank Traveltime { get; set; }

    [JsonProperty ("workstats")]
    public virtual required HallOfFameRank Workstats { get; set; }

    [JsonProperty ("level")]
    public virtual required HallOfFameRank Level { get; set; }

    [JsonProperty ("rank")]
    public virtual required HallOfFameRank Rank { get; set; }

    [JsonProperty ("awards")]
    public virtual required HallOfFameRank Awards { get; set; }

    public int AttacksID { get; set; }

    public int BattlestatsID { get; set; }

    public int BustsID { get; set; }

    public int DefendsID { get; set; }

    public int NetworthID { get; set; }

    public int OffencesID { get; set; }

    public int RevivesID { get; set; }

    public int TraveltimeID { get; set; }

    public int WorkstatsID { get; set; }

    public int LevelID { get; set; }

    public int RankID { get; set; }

    public int AwardsID { get; set; }
}

