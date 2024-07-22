using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class ReportData {
    [JsonProperty ("bounties")]
    public required IEnumerable<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public required IEnumerable<Reference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public required IEnumerable<FriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public required IEnumerable<Reference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public required IEnumerable<FriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public required int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public required string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }

    [JsonProperty ("otherlist")]
    public required IEnumerable<Warrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("toplist")]
    public required IEnumerable<Warrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public required int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public required int TrueLevel { get; set; }
}
