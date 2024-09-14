using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportData : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bounties")]
    public required List<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public required List<ReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public required List<FriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public required List<ReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public required List<FriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public required int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public required string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }

    [JsonProperty ("otherlist")]
    public required List<Warrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("toplist")]
    public required List<Warrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public required int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public required int TrueLevel { get; set; }
}
