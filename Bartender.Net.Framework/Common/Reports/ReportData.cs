using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportData : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("bounties")]
    public virtual required List<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public virtual required List<ReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public virtual required List<FriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public virtual required List<ReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public virtual required List<FriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public required int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public required string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }

    [JsonProperty ("otherlist")]
    public virtual required List<Warrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("toplist")]
    public virtual required List<Warrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public required int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public required int TrueLevel { get; set; }
}
