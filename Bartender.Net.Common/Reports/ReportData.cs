using Newtonsoft.Json;

namespace Bartender.Net.Common.Reports;

public class ReportData {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bounties")]
    public List<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public List<ReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public List<FriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public List<ReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public List<FriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public int Money { get; set; }

    [JsonProperty ("otherlist")]
    public List<Warrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public int Speed { get; set; }

    [JsonProperty ("strength")]
    public int Strength { get; set; }

    [JsonProperty ("toplist")]
    public List<Warrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public int TrueLevel { get; set; }
}
